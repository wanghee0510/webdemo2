using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class AddSingerViewModel
    {
        public  Song Song { get; set; }
        public List<Singer> SingerInSong { get; set; }
        public List<Singer> SingerToAdd { get; set; }
        public int SingerID { get; set; }
        public int SongID { get; set; }
    }
}
