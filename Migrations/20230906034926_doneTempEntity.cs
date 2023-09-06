using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaSachDotNet.Migrations
{
    public partial class doneTempEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sach_TheLoai_theLoaiId",
                table: "sach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai");

            migrationBuilder.RenameTable(
                name: "TheLoai",
                newName: "theLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_theLoai",
                table: "theLoai",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tokenExpired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    userId = table.Column<long>(type: "bigint", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTHD",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    hoaDonId = table.Column<long>(type: "bigint", nullable: false),
                    sachId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTHD", x => x.id);
                    table.ForeignKey(
                        name: "FK_CTHD_HoaDon",
                        column: x => x.hoaDonId,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTHD_Sach",
                        column: x => x.sachId,
                        principalTable: "sach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTHD_hoaDonId",
                table: "CTHD",
                column: "hoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_CTHD_sachId",
                table: "CTHD",
                column: "sachId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_userId",
                table: "HoaDon",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_sach_theLoai_theLoaiId",
                table: "sach",
                column: "theLoaiId",
                principalTable: "theLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sach_theLoai_theLoaiId",
                table: "sach");

            migrationBuilder.DropTable(
                name: "CTHD");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_theLoai",
                table: "theLoai");

            migrationBuilder.RenameTable(
                name: "theLoai",
                newName: "TheLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sach_TheLoai_theLoaiId",
                table: "sach",
                column: "theLoaiId",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
