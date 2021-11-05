using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNo.Models;

namespace TestNo.Data
{
    public class ChiTietHDContext : DbContext
    {
        public ChiTietHDContext(DbContextOptions<ChiTietHDContext> options) : base(options) { }
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
    }
}
