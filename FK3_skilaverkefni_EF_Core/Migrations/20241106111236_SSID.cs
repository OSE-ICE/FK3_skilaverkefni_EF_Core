using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FK3_skilaverkefni_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class SSID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SSID",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSID",
                table: "Students");
        }
    }
}
