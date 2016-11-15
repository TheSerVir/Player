using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Player.Models
{
    public class PlayerDbInitializer : DropCreateDatabaseAlways<PlayerContext>
    {
        protected override void Seed(PlayerContext db)
        {
            IEnumerable<Song> songs = FileService.GetSongs();
            foreach(Song song in songs)
            {
                db.Songs.Add(song);
            }
            base.Seed(db);
        }
    }
}
