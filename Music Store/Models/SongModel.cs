using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class SongModel
    {
        
        public int SongID { get; set; }
        
        public string SongName { get; set; }
        public List<SingerSong> singerSongs { get; set; }
        
       
       
    }
}
