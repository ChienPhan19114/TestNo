using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNo.Models;

namespace TestNo.Data
{
    public class NhanVienContext : DbContext
    {
        public NhanVienContext(DbContextOptions<NhanVienContext> options) : base(options) { }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}
