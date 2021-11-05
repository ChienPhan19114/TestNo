using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNo.Models
{
    public class SanPham
    {
        [Key]
        [Required]
        public int MaSP { get; set; }
        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }
        [Required]
        [StringLength(10)]
        public string DonViTinh { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(0, int.MaxValue, ErrorMessage = "Phai la so duong.")]
        [RegularExpression(@"\d+(\.\d{0,2})?", ErrorMessage = "Toi da 2 chu so thap phan.")]
        public Decimal DonGia { get; set; }
    }
}
