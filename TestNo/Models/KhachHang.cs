using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNo.Models
{
    public class KhachHang
    {
        [Key]
        [Required]
        public int MaKH { get; set; }
        [Required]
        [StringLength(40)]
        public string HoTenKH { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string DienThoai { get; set; }
    }
}
