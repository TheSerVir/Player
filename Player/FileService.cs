using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Player.Models;
using System.IO;

namespace Player
{
    public class FileService
    {

        private static string path = HttpContext.Current.Server.MapPath("~/Files");

        public static IEnumerable<Song> GetSongs()
        {
            List<Song> songs = new List<Song>();
            string[] files = Directory.GetFiles(path, "*.mp3");

            foreach(string file in files) {
                string[] temp = file.Split('\\');
                string songFileName = temp[temp.Length-1];

                songs.Add(GetSong(songFileName));
            }

            return songs;
        }

        public static Song GetSong(string songFileName)
        {
            string file = path + "/" + songFileName;
            if (File.Exists(file))
            {
                TagLib.File f = TagLib.File.Create(file);

                string artist = string.Join(",", f.Tag.Artists);
                string title = f.Tag.Title;

                return new Song
                {
                    Artist = (artist.Trim().Length == 0) ? "Unknown" : artist,
                    Name = (title.Trim().Length == 0) ? songFileName : title,
                    Url = "/Files/" + songFileName
                };
            }
            return null;
        } 

    }
}