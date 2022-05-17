using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class calender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Calenders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Years = table.Column<int>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    StartingDay = table.Column<int>(nullable: false),
                    EndDay = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Baner = table.Column<string>(nullable: true),
                    DataReceive = table.Column<DateTime>(nullable: false),
                    DateDestruction = table.Column<DateTime>(nullable: false),
                    TimeReceive = table.Column<int>(nullable: false),
                    TimeDestruction = table.Column<int>(nullable: false),
                    executing = table.Column<string>(nullable: true),
                    Tel1 = table.Column<string>(nullable: true),
                    Tel2 = table.Column<string>(nullable: true),
                    Supervisor = table.Column<string>(nullable: true),
                    SupervisorTel = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Calenders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Calenders");
        }
    }
}
