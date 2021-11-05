using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNo.Models;

namespace TestNo.Data
{
    public class TestNoContext : DbContext
    {
        public TestNoContext (DbContextOptions<TestNoContext> options)
            : base(options)
        {
        }

        public DbSet<TestNo.Models.NhanVien> NhanVien { get; set; }

        public DbSet<TestNo.Models.KhachHang> KhachHang { get; set; }

        public DbSet<TestNo.Models.HoaDon> HoaDon { get; set; }

        public DbSet<TestNo.Models.SanPham> SanPham { get; set; }

        public DbSet<TestNo.Models.ChiTietHD> ChiTietHD { get; set; }
    }
}
