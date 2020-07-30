using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class Pic
    {
        [Key]
        public int PicId { get; set; }
        [Required]
        public string PicName { get; set; }
        [Required]
        public int GiaTien { get; set; }
        [Required]
        public string TieuDe { get; set; }
    }
}
