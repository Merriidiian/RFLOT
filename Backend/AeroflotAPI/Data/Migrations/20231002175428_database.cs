using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AeroflotAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equips",
                columns: table => new
                {
                    RfId = table.Column<string>(type: "text", nullable: false),
                    IdZone = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DataExploitationBegin = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DataExploitationFinish = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EquipmentInformation = table.Column<string>(type: "text", nullable: false),
                    PlanePlace = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equips", x => x.RfId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    IdPlane = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CheckFlag = table.Column<bool>(type: "boolean", nullable: false),
                    NameChecker = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equips_RfId",
                table: "Equips",
                column: "RfId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_Id",
                table: "People",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zones_Id",
                table: "Zones",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equips");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
