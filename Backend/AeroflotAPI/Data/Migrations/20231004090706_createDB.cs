using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AeroflotAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportZones",
                columns: table => new
                {
                    IdReportZone = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdZone = table.Column<string>(type: "text", nullable: false),
                    ZoneName = table.Column<string>(type: "text", nullable: false),
                    IdPlane = table.Column<string>(type: "text", nullable: false),
                    DateTimeStartGroup = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DateTimeFinishGroup = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    BadEquipJson = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportZones", x => x.IdReportZone);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportZones_IdReportZone",
                table: "ReportZones",
                column: "IdReportZone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportZones");
        }
    }
}
