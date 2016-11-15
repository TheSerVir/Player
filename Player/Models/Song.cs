using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
