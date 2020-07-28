using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class Singer
    {
        [Key]
        public int SingerID { get; set; }
        [Required]
        public string SingerName { get; set; }
        public string BirthDay { get; set; }
        public List<SingerSong> singerSongs { get; set; }
    }
}
