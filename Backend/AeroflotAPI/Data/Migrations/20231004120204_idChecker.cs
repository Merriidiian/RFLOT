using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeroflotAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class idChecker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdChecker",
                table: "ReportZones",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdChecker",
                table: "ReportZones");
        }
    }
}
