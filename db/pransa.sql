USE [master]
GO
/****** Object:  Database [pransa_db]    Script Date: 8/10/2021 2:57:38 PM ******/
CREATE DATABASE [pransa_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pransa_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\pransa_db.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pransa_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\pransa_db_log.ldf' , SIZE = 1600KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pransa_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pransa_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pransa_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pransa_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pransa_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pransa_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pransa_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [pransa_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pransa_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pransa_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pransa_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pransa_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pransa_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pransa_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pransa_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pransa_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pransa_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pransa_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pransa_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pransa_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pransa_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pransa_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pransa_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [pransa_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pransa_db] SET RECOVERY FULL 
GO
ALTER DATABASE [pransa_db] SET  MULTI_USER 
GO
ALTER DATABASE [pransa_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pransa_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pransa_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pransa_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [pransa_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'pransa_db', N'ON'
GO
USE [pransa_db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_GalleryProducts]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_GalleryProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_GalleryProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_ImageGalleries]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ImageGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGallery] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_ImageGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Adress]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Adress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstAddress] [nvarchar](max) NULL,
	[SecondAddress] [nvarchar](max) NULL,
	[LocationAd] [nvarchar](max) NULL,
	[Tel1Ad] [nvarchar](max) NULL,
	[Tel2Ad] [nvarchar](max) NULL,
	[Officetel1Ad] [nvarchar](max) NULL,
	[Officetel2Ad] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Adress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Agencie]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Agencie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageAg] [nvarchar](max) NULL,
	[NameAg] [nvarchar](max) NULL,
	[NamePersenAg] [nvarchar](max) NULL,
	[TelAg] [nvarchar](max) NULL,
	[OfficetelAg] [nvarchar](max) NULL,
	[LocationAg] [nvarchar](max) NULL,
	[DescreptionAg] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Agencie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Baner]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Baner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[IdBaner] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Baner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Blog]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleBLo] [nvarchar](max) NULL,
	[IdCtegoryBlo] [int] NOT NULL,
	[SummaryBlo] [nvarchar](max) NULL,
	[ImageMainBlo] [nvarchar](max) NULL,
	[FullTextBlo] [nvarchar](max) NULL,
	[KeywordsBlo] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCat] [nvarchar](max) NULL,
	[FatherIdCat] [int] NOT NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Comments]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[State] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[Answer] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[User] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Experts]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Experts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameEx] [nvarchar](max) NULL,
	[ImageEx] [nvarchar](max) NULL,
	[TelEx] [nvarchar](max) NULL,
	[OfficeTelEx] [nvarchar](max) NULL,
	[LocationEx] [nvarchar](max) NULL,
	[AboutEx] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Experts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Factors]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Factors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Order] [nvarchar](max) NULL,
	[Product_Id] [int] NOT NULL,
	[product_Name] [nvarchar](max) NULL,
	[Product_Count] [int] NOT NULL,
	[product_Price] [int] NOT NULL,
	[Total_sum] [int] NOT NULL,
	[RFactor] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Factors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Financial]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Financial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserNameFi] [nvarchar](max) NULL,
	[TelFi] [nvarchar](max) NULL,
	[RemovalFi] [nvarchar](max) NULL,
	[DepositFi] [nvarchar](max) NULL,
	[DateFi] [datetime2](7) NOT NULL,
	[StateFi] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Financial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Gallery]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleGal] [nvarchar](max) NULL,
	[pathImage] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Gallery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Logo]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Logo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleLogo] [nvarchar](max) NULL,
	[ImageLogo] [nvarchar](max) NULL,
	[FavIcon] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Logo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Message]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SenderMess] [nvarchar](max) NULL,
	[ResiverMess] [nvarchar](max) NULL,
	[DateMess] [datetime2](7) NOT NULL,
	[SubjectMess] [nvarchar](max) NULL,
	[TextMess] [nvarchar](max) NULL,
	[StateMess] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[pathfile] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Message] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_MyFavorites]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_MyFavorites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdKala] [int] NOT NULL,
	[IdUser] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_MyFavorites] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Order]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_user] [nvarchar](max) NULL,
	[Date_Order] [datetime2](7) NOT NULL,
	[Pay] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[RFactor] [int] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Date_Send] [datetime2](7) NOT NULL DEFAULT ('0001-01-01T00:00:00.0000000'),
	[Post] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Originality]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Originality](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProductOri] [int] NOT NULL,
	[NumberProductOri] [nvarchar](max) NULL,
	[DateCreateOri] [datetime2](7) NOT NULL,
	[HologramCodeOri] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Originality] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleProductPro] [nvarchar](max) NULL,
	[ImageMainPro] [nvarchar](max) NULL,
	[CategoryIdPro] [nvarchar](max) NULL,
	[PricePro] [int] NOT NULL,
	[OfferPro] [nvarchar](max) NULL,
	[SizePro] [nvarchar](max) NULL,
	[ColorPro] [nvarchar](max) NULL,
	[BrandPro] [nvarchar](max) NULL,
	[TypeCarPro] [nvarchar](max) NULL,
	[MaterialPro] [nvarchar](max) NULL,
	[TotalPro] [nvarchar](max) NULL,
	[DescreptionPro] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[CategoryChildIdPro] [nvarchar](max) NULL,
	[Price_Pro] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Richats]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Richats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScriptChat] [nvarchar](max) NULL,
	[zarinpal] [nvarchar](max) NULL,
	[enemad] [nvarchar](max) NULL,
	[sms] [nvarchar](max) NULL,
	[website] [nvarchar](max) NULL,
	[paternsms] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Richats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Slider]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Slider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Slider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_SocialNetwork]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SocialNetwork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Instagram] [nvarchar](max) NULL,
	[Telegram] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Whatsapp] [nvarchar](max) NULL,
	[Aparat] [nvarchar](max) NULL,
	[Youtube] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_SocialNetwork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Teaser]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Teaser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleTeaser] [nvarchar](max) NULL,
	[CategoryIdTeaser] [nvarchar](max) NULL,
	[VideoPathTeaser] [nvarchar](max) NULL,
	[LinkVideoTeaser] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Teaser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserNameUs] [nvarchar](max) NULL,
	[EmailUS] [nvarchar](max) NULL,
	[PhoneUs] [nvarchar](max) NULL,
	[PasswordUs] [nvarchar](max) NULL,
	[AddressUs] [nvarchar](max) NULL,
	[ProfileImageUs] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Token] [nvarchar](max) NULL,
	[NationalCode] [nvarchar](max) NULL,
	[UserFamilyUs] [nvarchar](max) NULL,
	[Post] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Users]    Script Date: 8/10/2021 2:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameFamily] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
	[Lat] [nvarchar](max) NULL,
	[Len] [nvarchar](max) NULL,
	[token] [nvarchar](max) NULL,
	[photo] [nvarchar](max) NULL,
	[Post] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210729075259_newdb', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210729122513_prodouct', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210730093902_majidi', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210731044030_majidiii', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210802060853_aass', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210802194745_aassh', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210803100957_aasshs', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210803132103_aasshsa', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210803132524_aasshsas', N'3.1.8')
SET IDENTITY_INSERT [dbo].[tb_GalleryProducts] ON 

INSERT [dbo].[tb_GalleryProducts] ([Id], [IdProduct], [ImagePath], [Language]) VALUES (25, 12, N'80a4ab9a-c5ac-4e2f-a355-07c1b6129dfd.jpg', N'fa')
INSERT [dbo].[tb_GalleryProducts] ([Id], [IdProduct], [ImagePath], [Language]) VALUES (26, 16, N'044d80cf-657d-40b1-b793-3f887096c1f5.jpg', N'fa')
INSERT [dbo].[tb_GalleryProducts] ([Id], [IdProduct], [ImagePath], [Language]) VALUES (27, 16, N'82835dad-48c6-41b1-84f9-ff1a1e090f8a.jpg', N'fa')
INSERT [dbo].[tb_GalleryProducts] ([Id], [IdProduct], [ImagePath], [Language]) VALUES (28, 16, N'0998e56a-ff9f-452e-9cee-963504cde233.jpg', N'fa')
INSERT [dbo].[tb_GalleryProducts] ([Id], [IdProduct], [ImagePath], [Language]) VALUES (29, 16, N'76c73c53-742b-4302-a025-039a5982c96d.jpg', N'fa')
SET IDENTITY_INSERT [dbo].[tb_GalleryProducts] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Baner] ON 

INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (15, NULL, 0, 12, NULL, N'dd5435aa-17bb-4afc-a5a6-d6649ccf73b0.jpg', N'fa', 5)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (16, NULL, 0, 12, NULL, N'830fecf4-4dbd-47f8-8e82-d81ae2c6b281.jpg', N'fa', 6)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (17, NULL, 0, 12, NULL, N'c99903e2-87bc-498d-b1bb-7ad36a3438fd.jpg', N'fa', 7)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (18, NULL, 0, 12, NULL, N'183d9c22-c0e7-49cd-909c-ea7178f7a214.jpg', N'fa', 8)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (19, NULL, 0, 13, NULL, N'6330fa37-f500-43ef-96a5-e0f0ca4646e3.jpg', N'fa', 9)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (24, NULL, 0, 12, NULL, N'21fce305-4904-4315-80a1-9d65e28885ae.jpg', N'fa', 1)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (25, NULL, 0, 12, NULL, N'575e186d-d74b-4379-9281-7f684ba247a7.jpg', N'fa', 2)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (26, NULL, 0, 12, NULL, N'c0377fa5-cb9b-4749-84e4-d97dcddfaa37.jpg', N'fa', 3)
INSERT [dbo].[Tbl_Baner] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language], [IdBaner]) VALUES (27, NULL, 0, 12, NULL, N'2a0f04bc-7a54-40b3-9c83-296e910d91ac.jpg', N'fa', 4)
SET IDENTITY_INSERT [dbo].[Tbl_Baner] OFF
SET IDENTITY_INSERT [dbo].[tbl_category] ON 

INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (9, N'کرم', 0, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (10, N'داروگر', 9, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (12, N'چراغ', 10, N'fa')
SET IDENTITY_INSERT [dbo].[tbl_category] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Factors] ON 

INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (15, N'09214351340', 16, N'x', 1, 20000, 20000, 596588)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (16, N'09214351340', 15, N'kala', 1, 1500000, 1500000, 596588)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (17, N'09214351340', 12, N'لیزری', 1, 23750, 23750, 596588)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (18, N'09214351340', 16, N'x', 1, 20000, 20000, 288162)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (19, N'09336192158', 16, N'x', 1, 20000, 20000, 719381)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (20, N'09336192158', 14, N'neon', 1, 509600, 509600, 719381)
INSERT [dbo].[Tbl_Factors] ([Id], [Id_Order], [Product_Id], [product_Name], [Product_Count], [product_Price], [Total_sum], [RFactor]) VALUES (21, N'09336192158', 14, N'neon', 1, 509600, 509600, 557869)
SET IDENTITY_INSERT [dbo].[Tbl_Factors] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Logo] ON 

INSERT [dbo].[Tbl_Logo] ([Id], [TitleLogo], [ImageLogo], [FavIcon], [Language]) VALUES (4, N'پرنسا', N'00fc412d-44a0-427f-bd28-78666360da4e.png', N'f3f937fe-2817-4781-9cbc-ab0ddd8d56d0.png', N'fa')
SET IDENTITY_INSERT [dbo].[Tbl_Logo] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Order] ON 

INSERT [dbo].[Tbl_Order] ([Id], [Id_user], [Date_Order], [Pay], [State], [RFactor], [Address], [Date_Send], [Post]) VALUES (8, N'09214351340', CAST(N'2021-08-03 10:14:38.6721304' AS DateTime2), N'1543750', N'OKK', 596588, N'تهران-میرداماد-وزیری پور', CAST(N'2021-08-03 10:20:31.4508344' AS DateTime2), NULL)
INSERT [dbo].[Tbl_Order] ([Id], [Id_user], [Date_Order], [Pay], [State], [RFactor], [Address], [Date_Send], [Post]) VALUES (9, N'09214351340', CAST(N'2021-08-03 13:31:32.9376144' AS DateTime2), N'20000', N'OKK', 288162, N'تهران-میرداماد-وزیری پور', CAST(N'2021-08-03 13:31:55.1174293' AS DateTime2), N'2222222222222')
INSERT [dbo].[Tbl_Order] ([Id], [Id_user], [Date_Order], [Pay], [State], [RFactor], [Address], [Date_Send], [Post]) VALUES (10, N'09336192158', CAST(N'2021-08-03 19:29:47.1707205' AS DateTime2), N'529600', N'OK', 719381, N'kjkghjklfgjklbdfgjkldhgfjklhjljhnkl', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'8558')
INSERT [dbo].[Tbl_Order] ([Id], [Id_user], [Date_Order], [Pay], [State], [RFactor], [Address], [Date_Send], [Post]) VALUES (11, N'09336192158', CAST(N'2021-08-03 19:38:47.9764856' AS DateTime2), N'509600', N'OK', 557869, N'kjkghjklfgjklbdfgjkldhgfjklhjljhnkl', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'8558')
SET IDENTITY_INSERT [dbo].[Tbl_Order] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Product] ON 

INSERT [dbo].[Tbl_Product] ([Id], [TitleProductPro], [ImageMainPro], [CategoryIdPro], [PricePro], [OfferPro], [SizePro], [ColorPro], [BrandPro], [TypeCarPro], [MaterialPro], [TotalPro], [DescreptionPro], [Language], [CategoryChildIdPro], [Price_Pro]) VALUES (12, N'لیزری', N'5a08d22b-8306-4548-b753-24f2a57e7d3c.jpg', N'10', 25000, N'5', N'2', NULL, N'المانی', N'1', N'تخفیف', N'4 عدد', N'<div class="ql-editor ql-blank" data-gramm="false" contenteditable="true"><p>glijdgl;rtjhtrgioopgjiet;</p></div><div class="ql-clipboard" contenteditable="true" tabindex="-1"></div><div class="ql-tooltip ql-hidden"><a class="ql-preview" target="_blank" href="about:blank"></a><input type="text" data-formula="e=mc^2" data-link="https://quilljs.com" data-video="Embed URL"><a class="ql-action"></a><a class="ql-remove"></a></div>', N'fa', N'12', 23750)
INSERT [dbo].[Tbl_Product] ([Id], [TitleProductPro], [ImageMainPro], [CategoryIdPro], [PricePro], [OfferPro], [SizePro], [ColorPro], [BrandPro], [TypeCarPro], [MaterialPro], [TotalPro], [DescreptionPro], [Language], [CategoryChildIdPro], [Price_Pro]) VALUES (13, N'رکاب اصلی', N'ef94f34d-983a-403c-ae10-4405dc62b685.jpg', N'10', 150000, N'0', N'110', NULL, N'ایرانی', N'1', N'تخفیف', N'3', NULL, N'fa', N'12', 150000)
INSERT [dbo].[Tbl_Product] ([Id], [TitleProductPro], [ImageMainPro], [CategoryIdPro], [PricePro], [OfferPro], [SizePro], [ColorPro], [BrandPro], [TypeCarPro], [MaterialPro], [TotalPro], [DescreptionPro], [Language], [CategoryChildIdPro], [Price_Pro]) VALUES (14, N'neon', N'1d932d86-c140-41bf-bfd2-fb89d770dabb.jpg', N'10', 520000, N'2', N'25', NULL, N'jepan', N'1', N'تخفیف', N'2 عدد', NULL, N'fa', N'12', 509600)
INSERT [dbo].[Tbl_Product] ([Id], [TitleProductPro], [ImageMainPro], [CategoryIdPro], [PricePro], [OfferPro], [SizePro], [ColorPro], [BrandPro], [TypeCarPro], [MaterialPro], [TotalPro], [DescreptionPro], [Language], [CategoryChildIdPro], [Price_Pro]) VALUES (15, N'kala', N'd66e92e0-46ff-4c0e-89f2-28c1003a4f46.jpg', N'10', 1500000, N'0', N'2', NULL, N'2000', N'1', N'پیشنهادلحظه ای', N'1 عدد', NULL, N'fa', N'12', 1500000)
INSERT [dbo].[Tbl_Product] ([Id], [TitleProductPro], [ImageMainPro], [CategoryIdPro], [PricePro], [OfferPro], [SizePro], [ColorPro], [BrandPro], [TypeCarPro], [MaterialPro], [TotalPro], [DescreptionPro], [Language], [CategoryChildIdPro], [Price_Pro]) VALUES (16, N'x', N'a6f9d20c-9c0d-4bc7-b130-6a9a10302e24.jpg', N'10', 25000, N'20', N'36', NULL, N'المانی', N'1', N'تخفیف', N'4 عدد', NULL, N'fa', N'12', 20000)
SET IDENTITY_INSERT [dbo].[Tbl_Product] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Slider] ON 

INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (5, NULL, 0, 12, NULL, N'6be67137-c56f-4cec-8d72-382a35bb2876.jpg', N'fa')
INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (6, NULL, 0, 12, NULL, N'4def1e81-85f0-4234-bc84-ec8ad4837fe1.jpg', N'fa')
INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (7, NULL, 0, 12, NULL, N'fd72369b-be10-4239-ad00-cd8d262d05dc.jpg', N'fa')
SET IDENTITY_INSERT [dbo].[Tbl_Slider] OFF
SET IDENTITY_INSERT [dbo].[Tbl_SocialNetwork] ON 

INSERT [dbo].[Tbl_SocialNetwork] ([Id], [Instagram], [Telegram], [Facebook], [Twitter], [Whatsapp], [Aparat], [Youtube], [Language]) VALUES (2, N'pransa', N'pransa', N'pransa', NULL, N'pransa', N'pransa', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_SocialNetwork] OFF
SET IDENTITY_INSERT [dbo].[Tbl_User] ON 

INSERT [dbo].[Tbl_User] ([Id], [UserNameUs], [EmailUS], [PhoneUs], [PasswordUs], [AddressUs], [ProfileImageUs], [Language], [Token], [NationalCode], [UserFamilyUs], [Post]) VALUES (3, N'admin', NULL, N'09214351340', NULL, N'تهران-میرداماد-وزیری پور', N'0e32cb42-07e4-49aa-956a-e885fcffd7d2.jpg', NULL, N'3503', N'1720188408', N'mmmm', N'2222222222222')
INSERT [dbo].[Tbl_User] ([Id], [UserNameUs], [EmailUS], [PhoneUs], [PasswordUs], [AddressUs], [ProfileImageUs], [Language], [Token], [NationalCode], [UserFamilyUs], [Post]) VALUES (4, NULL, NULL, N'09223514415', NULL, NULL, NULL, NULL, N'5932', NULL, NULL, NULL)
INSERT [dbo].[Tbl_User] ([Id], [UserNameUs], [EmailUS], [PhoneUs], [PasswordUs], [AddressUs], [ProfileImageUs], [Language], [Token], [NationalCode], [UserFamilyUs], [Post]) VALUES (5, N'nikatak4423', NULL, N'09336192158', NULL, N'kjkghjklfgjklbdfgjkldhgfjklhjljhnkl', N'ebb26600-47ff-4c41-97db-8a51d88ce5a2.jpg', NULL, N'3146', N'1720188408', N'mmmm', N'8558')
SET IDENTITY_INSERT [dbo].[Tbl_User] OFF
ALTER TABLE [dbo].[Tbl_Comments] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
USE [master]
GO
ALTER DATABASE [pransa_db] SET  READ_WRITE 
GO
