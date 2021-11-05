using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestNo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoNV = table.Column<string>(maxLength: 30, nullable: true),
                    TenNV = table.Column<string>(maxLength: 12, nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoai = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
