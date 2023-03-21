using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CNPMNC.Migrations
{
    public partial class addInitV0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaiThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "HinhThucs",
                columns: table => new
                {
                    HinhThucID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHinhThuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucs", x => x.HinhThucID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTins",
                columns: table => new
                {
                    LoaiTinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiTin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTins", x => x.LoaiTinID);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrangs",
                columns: table => new
                {
                    TinhTrangID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrangs", x => x.TinhTrangID);
                });

            migrationBuilder.CreateTable(
                name: "TrangThais",
                columns: table => new
                {
                    TrangThaiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThais", x => x.TrangThaiID);
                });

            migrationBuilder.CreateTable(
                name: "TinRaoVats",
                columns: table => new
                {
                    TinRaoVatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    TrangThaiID = table.Column<int>(type: "int", nullable: false),
                    TinhTrangID = table.Column<int>(type: "int", nullable: false),
                    LoaiTinID = table.Column<int>(type: "int", nullable: false),
                    HinhThucID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayGioDang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaTinDang = table.Column<int>(type: "int", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinRaoVats", x => x.TinRaoVatID);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_HinhThucs_HinhThucID",
                        column: x => x.HinhThucID,
                        principalTable: "HinhThucs",
                        principalColumn: "HinhThucID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_LoaiTins_LoaiTinID",
                        column: x => x.LoaiTinID,
                        principalTable: "LoaiTins",
                        principalColumn: "LoaiTinID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_TinhTrangs_TinhTrangID",
                        column: x => x.TinhTrangID,
                        principalTable: "TinhTrangs",
                        principalColumn: "TinhTrangID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinRaoVats_TrangThais_TrangThaiID",
                        column: x => x.TrangThaiID,
                        principalTable: "TrangThais",
                        principalColumn: "TrangThaiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_CategoryID",
                table: "TinRaoVats",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_CityID",
                table: "TinRaoVats",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_HinhThucID",
                table: "TinRaoVats",
                column: "HinhThucID");

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_LoaiTinID",
                table: "TinRaoVats",
                column: "LoaiTinID");

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_TinhTrangID",
                table: "TinRaoVats",
                column: "TinhTrangID");

            migrationBuilder.CreateIndex(
                name: "IX_TinRaoVats_TrangThaiID",
                table: "TinRaoVats",
                column: "TrangThaiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TinRaoVats");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "HinhThucs");

            migrationBuilder.DropTable(
                name: "LoaiTins");

            migrationBuilder.DropTable(
                name: "TinhTrangs");

            migrationBuilder.DropTable(
                name: "TrangThais");
        }
    }
}
