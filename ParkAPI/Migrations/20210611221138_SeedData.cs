using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "Phone", "Type", "Url" },
                values: new object[] { 1, "(text courtesy of stateparks.oregon.gov) Diggers, this park's for you! Razor clamming is a favorite activity as well as surfing. If you plan to visit prime Newport attractions like the Oregon Coast Aquarium and Hatfield Marine Science Center, you must stop in for a refreshing picnic at Agate Beach.", "Near Newport, Oregon, United States", "Agate Beach", "541-265-4560", "State", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=152" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "Phone", "Type", "Url" },
                values: new object[] { 2, "(text courtesy of stateparks.oregon.gov) Large trees characterize this forested park along Hwy 36 between Junction City and Triangle Lake. There's a picnic area, restroom, and short trail along the Long Tom River. Bring a lunch and relax!", "Near Eugene, Oregon, United States", "Alderwood", "541-937-1173", "State", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);
        }
    }
}
