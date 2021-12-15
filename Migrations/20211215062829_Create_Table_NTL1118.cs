using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenThiLuong118.Migrations
{
    public partial class Create_Table_NTL1118 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTL1118s",
                columns: table => new
                {
                    NTLId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTLName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NTLGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTL1118s", x => x.NTLId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTL1118s");
        }
    }
}
