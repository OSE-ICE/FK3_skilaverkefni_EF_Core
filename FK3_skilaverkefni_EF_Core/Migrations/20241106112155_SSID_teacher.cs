using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FK3_skilaverkefni_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class SSID_teacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SSID",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSID",
                table: "Teachers");
        }
    }
}
