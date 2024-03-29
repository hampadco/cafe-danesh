﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class firstt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_GalleryProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_GalleryProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ImageGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGallery = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ImageGalleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Adress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstAddress = table.Column<string>(nullable: true),
                    SecondAddress = table.Column<string>(nullable: true),
                    LocationAd = table.Column<string>(nullable: true),
                    Tel1Ad = table.Column<string>(nullable: true),
                    Tel2Ad = table.Column<string>(nullable: true),
                    Officetel1Ad = table.Column<string>(nullable: true),
                    Officetel2Ad = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Agencie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageAg = table.Column<string>(nullable: true),
                    NameAg = table.Column<string>(nullable: true),
                    NamePersenAg = table.Column<string>(nullable: true),
                    TelAg = table.Column<string>(nullable: true),
                    OfficetelAg = table.Column<string>(nullable: true),
                    LocationAg = table.Column<string>(nullable: true),
                    DescreptionAg = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Agencie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Baner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlid = table.Column<string>(nullable: true),
                    CategoryIdSlid = table.Column<int>(nullable: false),
                    CategoryProductIdSlid = table.Column<int>(nullable: false),
                    TypeSlid = table.Column<string>(nullable: true),
                    ImageMainSlid = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    IdBaner = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Baner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleBLo = table.Column<string>(nullable: true),
                    IdCtegoryBlo = table.Column<int>(nullable: false),
                    SummaryBlo = table.Column<string>(nullable: true),
                    ImageMainBlo = table.Column<string>(nullable: true),
                    FullTextBlo = table.Column<string>(nullable: true),
                    KeywordsBlo = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCat = table.Column<string>(nullable: true),
                    FatherIdCat = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ColorProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(nullable: true),
                    IdProduct = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ColorProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    product_id = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Experts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEx = table.Column<string>(nullable: true),
                    ImageEx = table.Column<string>(nullable: true),
                    TelEx = table.Column<string>(nullable: true),
                    OfficeTelEx = table.Column<string>(nullable: true),
                    LocationEx = table.Column<string>(nullable: true),
                    AboutEx = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Factors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Order = table.Column<string>(nullable: true),
                    Product_Id = table.Column<int>(nullable: false),
                    product_Name = table.Column<string>(nullable: true),
                    Product_Count = table.Column<int>(nullable: false),
                    product_Price = table.Column<int>(nullable: false),
                    Total_sum = table.Column<int>(nullable: false),
                    RFactor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Factors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Financial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameFi = table.Column<string>(nullable: true),
                    TelFi = table.Column<string>(nullable: true),
                    RemovalFi = table.Column<string>(nullable: true),
                    DepositFi = table.Column<string>(nullable: true),
                    DateFi = table.Column<DateTime>(nullable: false),
                    StateFi = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Financial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleGal = table.Column<string>(nullable: true),
                    pathImage = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Logo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleLogo = table.Column<string>(nullable: true),
                    ImageLogo = table.Column<string>(nullable: true),
                    FavIcon = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Logo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderMess = table.Column<string>(nullable: true),
                    ResiverMess = table.Column<string>(nullable: true),
                    DateMess = table.Column<DateTime>(nullable: false),
                    SubjectMess = table.Column<string>(nullable: true),
                    TextMess = table.Column<string>(nullable: true),
                    StateMess = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    pathfile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MyFavorites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKala = table.Column<int>(nullable: false),
                    IdUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MyFavorites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_user = table.Column<string>(nullable: true),
                    Date_Order = table.Column<DateTime>(nullable: false),
                    Date_Send = table.Column<DateTime>(nullable: false),
                    Pay = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    RFactor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Originality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProductOri = table.Column<int>(nullable: false),
                    NumberProductOri = table.Column<string>(nullable: true),
                    DateCreateOri = table.Column<DateTime>(nullable: false),
                    HologramCodeOri = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Originality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleProductPro = table.Column<string>(nullable: true),
                    ImageMainPro = table.Column<string>(nullable: true),
                    CategoryIdPro = table.Column<string>(nullable: true),
                    CategoryChildIdPro = table.Column<string>(nullable: true),
                    PricePro = table.Column<int>(nullable: false),
                    Price_Pro = table.Column<int>(nullable: false),
                    OfferPro = table.Column<string>(nullable: true),
                    SizePro = table.Column<string>(nullable: true),
                    ColorPro = table.Column<string>(nullable: true),
                    BrandPro = table.Column<string>(nullable: true),
                    TypeCarPro = table.Column<string>(nullable: true),
                    MaterialPro = table.Column<string>(nullable: true),
                    TotalPro = table.Column<string>(nullable: true),
                    DescreptionPro = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Richats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptChat = table.Column<string>(nullable: true),
                    zarinpal = table.Column<string>(nullable: true),
                    enemad = table.Column<string>(nullable: true),
                    sms = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true),
                    paternsms = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Richats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlid = table.Column<string>(nullable: true),
                    CategoryIdSlid = table.Column<int>(nullable: false),
                    CategoryProductIdSlid = table.Column<int>(nullable: false),
                    TypeSlid = table.Column<string>(nullable: true),
                    ImageMainSlid = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SocialNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instagram = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<string>(nullable: true),
                    Aparat = table.Column<string>(nullable: true),
                    Youtube = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SocialNetwork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Teaser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTeaser = table.Column<string>(nullable: true),
                    CategoryIdTeaser = table.Column<string>(nullable: true),
                    VideoPathTeaser = table.Column<string>(nullable: true),
                    LinkVideoTeaser = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Teaser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameUs = table.Column<string>(nullable: true),
                    EmailUS = table.Column<string>(nullable: true),
                    PhoneUs = table.Column<string>(nullable: true),
                    PasswordUs = table.Column<string>(nullable: true),
                    AddressUs = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    ProfileImageUs = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    UserFamilyUs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFamily = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Len = table.Column<string>(nullable: true),
                    token = table.Column<string>(nullable: true),
                    photo = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_GalleryProducts");

            migrationBuilder.DropTable(
                name: "tb_ImageGalleries");

            migrationBuilder.DropTable(
                name: "Tbl_Adress");

            migrationBuilder.DropTable(
                name: "Tbl_Agencie");

            migrationBuilder.DropTable(
                name: "Tbl_Baner");

            migrationBuilder.DropTable(
                name: "Tbl_Blog");

            migrationBuilder.DropTable(
                name: "tbl_category");

            migrationBuilder.DropTable(
                name: "Tbl_ColorProducts");

            migrationBuilder.DropTable(
                name: "Tbl_Comments");

            migrationBuilder.DropTable(
                name: "Tbl_Experts");

            migrationBuilder.DropTable(
                name: "Tbl_Factors");

            migrationBuilder.DropTable(
                name: "Tbl_Financial");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_Logo");

            migrationBuilder.DropTable(
                name: "Tbl_Message");

            migrationBuilder.DropTable(
                name: "Tbl_MyFavorites");

            migrationBuilder.DropTable(
                name: "Tbl_Order");

            migrationBuilder.DropTable(
                name: "Tbl_Originality");

            migrationBuilder.DropTable(
                name: "Tbl_Product");

            migrationBuilder.DropTable(
                name: "Tbl_Richats");

            migrationBuilder.DropTable(
                name: "Tbl_Slider");

            migrationBuilder.DropTable(
                name: "Tbl_SocialNetwork");

            migrationBuilder.DropTable(
                name: "Tbl_Teaser");

            migrationBuilder.DropTable(
                name: "Tbl_User");

            migrationBuilder.DropTable(
                name: "Tbl_Users");
        }
    }
}
