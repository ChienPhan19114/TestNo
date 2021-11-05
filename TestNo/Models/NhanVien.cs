using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestNo.Models
{
    public class NhanVien
    {
        public enum Gender
        {
            Nam,
            Nữ,
        }
        [Key]
        [Required]
        
        public int MaNV { get; set; }
        [Required]
        [StringLength(30)]
        public string HoNV { get; set; }
        [Required]
        [StringLength(12)]
        public string TenNV { get; set; }
        [Required]
        public Gender GioiTinh { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgaySinh { get; set; }
        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string DienThoai { get; set; }
    }
}
