using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        public string SongName { get; set; }
        public List<SingerSong> singerSongs { get; set; }
       
    }
}
