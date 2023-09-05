using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaSachDotNet.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sachs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    giaBan = table.Column<double>(type: "float", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    theLoaiId = table.Column<long>(type: "bigint", nullable: false),
                    giaBanDau = table.Column<double>(type: "float", nullable: false),
                    gioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soTrang = table.Column<int>(type: "int", nullable: false),
                    ngonNgu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tacgiaid = table.Column<long>(type: "bigint", nullable: false),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sachs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sachs");
        }
    }
}
