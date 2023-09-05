using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaSachDotNet.Migrations
{
    public partial class AddTheLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sachs",
                table: "sachs");

            migrationBuilder.RenameTable(
                name: "sachs",
                newName: "sach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sach",
                table: "sach",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sach_theLoaiId",
                table: "sach",
                column: "theLoaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_sach_TheLoai_theLoaiId",
                table: "sach",
                column: "theLoaiId",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sach_TheLoai_theLoaiId",
                table: "sach");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sach",
                table: "sach");

            migrationBuilder.DropIndex(
                name: "IX_sach_theLoaiId",
                table: "sach");

            migrationBuilder.RenameTable(
                name: "sach",
                newName: "sachs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sachs",
                table: "sachs",
                column: "Id");
        }
    }
}
