using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestNo.Models
{
    public class ChiTietHD
    {
        [Required]
        [ForeignKey("MaHD")]
        public int MaHD { get; set; }
        [Required]
        [ForeignKey("MaSP")]
        public int MaSP { get; set; }
        [Key]
        [DataType(DataType.Text)]
        [Range(0, int.MaxValue, ErrorMessage = "Phai la so duong.")]
        public Decimal SoLuong { get; set; }    
    }
}
