using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class SingerModel
    {
        public int SingerID { get; set; }
        
        public string SingerName { get; set; }
        public string BirthDay { get; set; }
        public List<SingerSong> singerSongs { get; set; }
    }
}
