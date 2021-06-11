using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32) CHARACTER SET utf8mb4", maxLength: 32, nullable: false),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Url = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Phone = table.Column<string>(type: "varchar(12) CHARACTER SET utf8mb4", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
