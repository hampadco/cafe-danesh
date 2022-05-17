using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class tbl_page : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Users");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameCompany",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ostan",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shoar",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telegram",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Pages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    MainCat = table.Column<int>(nullable: false),
                    SubCat = table.Column<int>(nullable: false),
                    MainImage = table.Column<string>(nullable: true),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    Citys = table.Column<string>(nullable: true),
                    TypeSend = table.Column<string>(nullable: true),
                    TypePay = table.Column<string>(nullable: true),
                    LocationPay = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Pages");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "NameCompany",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Ostan",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Shoar",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "Tbl_User");

            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Len = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameFamily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typework = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.Id);
                });
        }
    }
}
