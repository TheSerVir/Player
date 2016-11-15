using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Player.Models
{
    public class PlayerContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }
}
