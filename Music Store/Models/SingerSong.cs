using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class SingerSong
    {
        public int SingerID { get; set; }
        public int SongID { get; set; }
        public Singer Singer { get; set; }
        public Song Song { get; set; }
    }
}
