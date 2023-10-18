using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeroflotAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class typeCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeCheck",
                table: "ReportZones",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeCheck",
                table: "ReportZones");
        }
    }
}
