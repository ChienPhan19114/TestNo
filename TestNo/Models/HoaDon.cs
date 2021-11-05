using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNo.Models
{
    public class HoaDon
    {
        [Key]
        [Required]
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        [Required]
        public int MaKH { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayLapHD { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayNhanHang { get; set; }
    }
}
