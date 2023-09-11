USE [master]
GO
/****** Object:  Database [Yolcu360]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE DATABASE [Yolcu360]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Yolcu360', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Yolcu360.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Yolcu360_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Yolcu360_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Yolcu360] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Yolcu360].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Yolcu360] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Yolcu360] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Yolcu360] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Yolcu360] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Yolcu360] SET ARITHABORT OFF 
GO
ALTER DATABASE [Yolcu360] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Yolcu360] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Yolcu360] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Yolcu360] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Yolcu360] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Yolcu360] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Yolcu360] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Yolcu360] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Yolcu360] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Yolcu360] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Yolcu360] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Yolcu360] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Yolcu360] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Yolcu360] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Yolcu360] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Yolcu360] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Yolcu360] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Yolcu360] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Yolcu360] SET  MULTI_USER 
GO
ALTER DATABASE [Yolcu360] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Yolcu360] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Yolcu360] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Yolcu360] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Yolcu360] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Yolcu360] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Yolcu360] SET QUERY_STORE = ON
GO
ALTER DATABASE [Yolcu360] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Yolcu360]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/11/2023 8:13:43 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AboutCities]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AboutCities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Desc] [nvarchar](1500) NOT NULL,
	[ImageName] [nvarchar](100) NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_AboutCities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Fullname] [nvarchar](50) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[MailConfirmCode] [int] NULL,
	[Address] [nvarchar](200) NULL,
	[Birthday] [nvarchar](50) NULL,
	[Pasport] [nvarchar](50) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[PriceDaily] [money] NOT NULL,
	[DepozitPrice] [money] NOT NULL,
	[TotalMillage] [decimal](18, 2) NOT NULL,
	[ImageName] [nvarchar](100) NOT NULL,
	[IsFreeCancelation] [bit] NOT NULL,
	[CancelationPrice] [money] NULL,
	[MinDriverAge] [int] NOT NULL,
	[MinYoungDriverAge] [int] NULL,
	[MinYoungDriverLisanseYear] [int] NULL,
	[Transmission] [int] NOT NULL,
	[FuelType] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[OfficeId] [int] NOT NULL,
	[ModelId] [int] NOT NULL,
	[MinDriverLisanseYear] [int] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
	[ImageName] [nvarchar](100) NULL,
	[HomeSliderOrder] [int] NULL,
	[HomePopularOrder] [int] NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offices]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CityId] [int] NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[OpenTimes] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Offices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rents]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[Fullname] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Birthday] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Pasport] [nvarchar](50) NOT NULL,
	[CarPrice] [money] NOT NULL,
	[ExtPrice] [money] NOT NULL,
	[PickUpDate] [datetime2](7) NOT NULL,
	[DropOffDate] [datetime2](7) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[DropOfficeId] [int] NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Rents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[Comment] [nvarchar](500) NULL,
	[CleannesPoint] [int] NOT NULL,
	[PersonelPoint] [int] NOT NULL,
	[SpeedPoint] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types]    Script Date: 9/11/2023 8:13:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230730111031_createBrandTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731133032_addCityAndOfficeTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731155256_FeatOfficeTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731161732_addCArsTAble', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731185818_featConfigurationsTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230802113111_addUserSystem', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230803105852_addUserMailConfirmCode', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230804084906_addreviewTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230804162604_createCountryTable', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230805192403_addCityTableImageNameColumn', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230818134641_addCitySliderOrder', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230818145115_addCitiesHomePageOrder', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230821044308_addAboutCityEntity', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230821114122_ChangeTitle', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230823160821_addModelEntity', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230823161101_modelconfiguration', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230825034140_changeFilled', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230826053741_changeFilledCar', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230826081930_featRealtion', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230826093415_changeconfiguration', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230829004447_addDateTimeReview', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230902101204_changeCityValidationCahnge', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230905125039_addRentEntity', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230905154811_addRentDropOffice', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230905161842_featRentEntity', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230906053434_changeReviewMainPoint', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230906185008_addUserProperty', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230907094511_AppUserValidation', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230907182221_featRentConfiguration', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230907182639_featRentConfigurationAgain', N'6.0.20')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230907183328_featRentConfigurationAgainAgain', N'6.0.20')
GO
SET IDENTITY_INSERT [dbo].[AboutCities] ON 
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (1, 2, N'Mallorca Airport Rent a Car', N'If you need car rental Mallorca for exploring every corner of the island, you can check out Yolcu360. Yolcu360 makes investigation among the all car rental companies in Mallorca Airport and Mallorca city office. Then it compares the options to find the best price. Yolcu360 just makes investigation for you. In the end, the choice is yours and you choose the most suitable car rental Mallorca for you. When you arrive at Mallorca Airport or Mallorca city office, your car rental Mallorca will be ready.', N'8ec74c9d-0c8a-4d56-91b8-6923a7c6ad7fmallorca.jpg', 1)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (3, 2, N'Information About Mallorca', N'Mallorca is the biggest island in Spain and it is found on the Mediterranean. The capital of the island is Palma. It has a remarkable place in terms of tourism like the other Balearic Islands. The amazing and admiring island of Mallorca offers a number of hidden beauties that only locals or well-informed foreigners know about. It means that there are lots of unique places that you can visit. That makes your holiday more memorable. If you do not want to miss any of these places, it will be better for making investigations and creating an effective destination list that determines the route of your holiday. You should have your own car to follow your own destination. If you do not have a private car, you can prefer car rental Mallorca Airport. A number of car rental companies are available in both Mallorca Airport and Mallorca city office. You can take help from Yolcu360 about finding the best car rental Mallorca Airport among the numerous companies. It searches and compares the car rentals to offer the most suitable one. When you arrive at Mallorca city office or Mallorca Airport, your car rental will be ready for you. You can begin your traveling without losing any time.', NULL, 2)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (4, 2, NULL, N'Here are some places that you can visit; Palau de l''Almudaina is originally an Islamic fort. It was converted into a residence for the Mallorcan monarchs at the end of the 13th century. Still, the King of Spain stays in here. The royal family is rarely staying in there, except for the occasional ceremony, as they prefer to spend summer in the Palau Marivent. The next destination can be Monestir de Lluc. Monestir de Lluc is a huge complex monastery. It dates mostly from the 17th to 18th centuries.', NULL, 3)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (5, 2, N'Beaches in Mallorca', N'The island of Mallorca is a highly popular holiday destination in Spain and most of the tourists prefer going to Mallorca for an admiring holiday. There are so many reasons for being preferred so much. There are so many amazing and famous beaches in Mallorca. Most of the tourists, who prefer going to Mallorca for their holiday, prefer to spend their time on these unique beaches. The beaches give you the chance of resting and relaxing while sleeping on the sands and sunbathe. It is possible to feel the nature in these beaches. To swim in the crystal clear sea can be an unforgettable memory for you and when you need something, it is possible to find almost everything on these beaches. The other thing that you should not forget to do is to spend a few days in Palma, which is the capital city of Mallorca. You can enjoy getting to experience a bit of Spanish city life while on a beach holiday.', NULL, 4)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (6, 2, NULL, N'If you do not want to spend your time by getting bored, car hire Mallorca can offer the advantages that you want. You can go anywhere easily. It is possible to experience your dream holiday thanks to car hire Mallorca. You can create your own destination list according to the things that you want to do in Mallorca and you can move in accordance with your own destination list at your own pace. There are lots of companies of car hire in Mallorca Airport and Mallorca city office. But it may not be easy to find the suitable car hire among the numerous options, so you can check out Yolcu360. It makes to find a suitable car hire Mallorca easier for you. Yolcu360 searches and compares the options for the best car hire Mallorca. You can take the car and start your holiday when you arrive at Mallorca Airport and Mallorca city office.', NULL, 5)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (7, 2, N'Buildings in Mallorca', N'There are several great holiday destinations in Spain and Mallorca is just one of them. It is preferred by so many tourists every year thanks to its natural and cultural beauties. If you want to experience an unforgettable holiday, do not wait to pack your bags. Here is some advice for you about the places you must see in Mallorca. Catedral de Mallorca is the most remarkable icon of the city and the city''s major architectural landmark. So, you should definitely see Catedral de Mallorca. Also, you should know that this is the only cathedral reflected in the sea. That makes the cathedral gorgeous. Real Cartuja de Valldemossa is the other attraction that should be in your destination list. Real Cartuja de Valldemossa is a grand old monastery. It was home to kings, monks and a pair of 19th-century celebrities: composer Frédéric Chopin and George Sand. It dates back to 1310 when Jaume II built a palace on the site.', NULL, 6)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (8, 2, NULL, N'Car hires Palma Mallorca is the most preferred way of traveling. Tourists and locals prefer car hire for their traveling on the island because car hire Palma Mallorca offers comfort. At the same time, it will be practical and flexible. There are lots of car hire companies in Mallorca Airport and Mallorca city office. Still, it is not challenging to find the suitable car hire Palma Mallorca with the help of Yolcu360. Yolcu360 makes finding the suitable car hire easier for you. It makes investigation among all the companies in Mallorca city office and Mallorca Airport. Then it offers the best car hire Palma Mallorca with the best prices to you. After that, the only thing that you need to do is taking your car and enjoying your holiday in the amazing island.', NULL, 7)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (9, 2, NULL, N'If you want to escape from the crowded of the cities and your daily responsibilities, Mallorca is an ideal holiday destination that you can prefer for an amazing holiday. So, which places can you visit in Mallorca? Because Mallorca is an island, it is possible to find a number of amazing beaches. So you can get rest by enjoying the sea and the sun in Mallorca. Also, there are some historical and cultural sights that you should see in there. Catedral de Mallorca is among the first places that you should see. It is a gorgeous structure and it is the city''s major architectural landmark. You can take so many amazing photos in there. Real Cartuja de Valldemossa is among the most visited cities in Mallorca.', NULL, 8)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (10, 2, NULL, N'It grand old monastery and former royal residence have a chequered history. Also, Real Cartuja de Valldemossawas once home to kings, monks and a pair of 19th-century celebrities: composer Frédéric Chopin and George Sand. There are numerous places that you should see in Mallorca so it is better to create your own destination list for an unforgettable holiday. You can make the search for the historical and cultural sights of the city and you can arrange your destination list according to these places. Car rental Mallorca Palma Airport makes your traveling easier and more comfortable. Numerous car rental companies are available at Mallorca Airport and Mallorca city office. Because Mallorca Airport and Mallorca city office is the location for car rental. So you do not have to lose your time by looking for a car rental. Yolcu360 finds all the car rental companies for the ideal car rental Mallorca Palma Airport. Then it compares the options to offer the best prices to you. You just need to enjoy your holiday, then.', NULL, 9)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (11, 2, N'Aktivities in Mallorca', N'If you get bored and want to do different things, Mallorca, which is the largest island in the Balearic Islands, is the place that you are looking for. There are so many different amazing activities to do in Mallorca during your summer holiday. It is possible to chill out at a beach club. You can lie down on the amazing sands and sunbathe while watching the amazing scene. Whenever you want, you can swim in the crystal clear the Mediterranean Sea. The beaches also offer a cool restaurant and bar, and other facilities. So you can spend a day in these amazing beaches and you can find everything when you need. After a day which is full of sun and sea, you can attend music concerts on the island in the evening. Mallorca is the place of various music concerts and theatre performances. Various music concerts and theatre performances are available there. You can attend many open-air live music events take place during the summer months. A number of different international festivals of classical music, jazz, pop, and rock are available in Mallorca. If you want to see and discover cultural and historical items, there are several interesting museums in Mallorca. In addition to these museums, several art galleries are also found in Mallorca.', NULL, 10)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (12, 2, N'Information About Mallorca City', N'Mallorca is the biggest and most amazing island in Spain. There are so many reasons to visit there. If you want to spend your holiday in Spain, Palma de Mallorca is among the most preferred destinations. Palma de Mallorca offers a great holiday with its unique beaches, natural beauties and historical sights. You can reserve a day for the beaches. You have the advantage of enjoying the sun and sea in these beaches. Also, you can find almost anything that you need. So you can spend a day on a beach easily. Then you can visit the historical and cultural sights of the island. You can visit Casa Robert Graves. Robert Grave is a poet and author. He lived in Deià, Mallorca, from 1929 until his death. Casa Robert Graves is a fascinating tribute to the British writer. It is a well-presented and awarding insight into his life and a tribute to his work. It is possible to find period furnishings, a detailed film on his life, love-life, and writings, and sundry books, pictures and everyday objects that belonged to Graves himself. There are also many other structures that you can visit in Palma de Mallorca.', NULL, 11)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (13, 2, NULL, N'The only way of the exploring every corner of Mallorca is car rental Palma de Mallorca Airport. It is also the most economical way of holiday. There are two locations that you can find car rental; Mallorca Airport and Mallorca city office. You can take help from Yolcu360 about finding the best car rental Palma de Mallorca Airport. It searches all the companies in Mallorca Airport and Mallorca city office. It compares all the options the find the best prices. After that, you can take your car rental Palma de Mallorca Airport and start your holiday without losing time.', NULL, 12)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (14, 2, N'Popular Locations in Mallorca', N'Every people dreams of an amazing holiday on the Mediterranean coastline. Especially, Spain is in the lead among the Mediterranean countries. There are lots of amazing and admiring attractions that you can visit in Mallorca such as; Catedral de Mallorca, Real Cartuja de Valldemossa, Museu Fundación Juan March, Fundació Pilar i Joan Miró, Monestir de Lluc, Casa Robert Graves, Sala Picasso & Sala Miró, and so on. But the prices make scare most of the people who admire a holiday in Mallorca and they have to give up on their dreams. Now, you do not have to scare off the prices, anymore. Because it is possible to experience an amazing holiday in Mallorca. There are several ways of experiencing an amazing holiday at reasonable prices.', NULL, 13)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (15, 2, NULL, N'The traveling the city is one of the main issues of a great holiday. It is better to find a way of traveling Mallorca with a cheaper price. It is not impossible to find cheap car rental Mallorca. There are a number of car rental companies in Mallorca Airport and Mallorca city office. If you book in advance, you can access more options and the options can be cheaper. Also, you can take help from Yolcu360. Because Yolcu360 makes an investigation in a detailed way for a cheap car rental Mallorca. It compares the options for finding the best prices. That makes your holiday also practical. The time is very precious and you need it so much while traveling. There are so many amazing attractions in Mallorca, because of that to spend your time by exploring every corner of the island at your own pace. You do not lose your time by looking for a suitable and cheap car rental Mallorca after arriving at Mallorca Airport or Mallorca city office with Yolcu360''s special services.', NULL, 14)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (16, 2, N'What to do in Mallorca?', N'Mallorca is a popular holiday destination like the other Balearic Islands. It is preferred by tourists, generally. Mallorca offers different types of things that you can do. For example, you can spend a few days in Palma, which is Mallorca’s capital city. It is a great place for visiting. Also, there are several beaches that you can go swimming. The beaches are preferred mostly by the tourists. You can spend a day on a beach. You can sunbathe and swim in the crystal clear sea. In addition to that, it is possible to find almost everything when you need it. The other thing that you can do in Mallorca is to spend a few nights in Cala Figuera is a working fishing port, so there is no beach in there. It is a small and quiet place, so it is great to rest and relax. You can wake up early and go for catching a fish. You should not forget that Mallorca has amazing sunsets, so if you are planning to go Mallorca for an amazing and memorable holiday, you should not come back from there without watching the sunset from Colonia de Sant Pere.', NULL, 15)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (17, 2, NULL, N'There are also many other different things that you can do there. The best and easiest way of traveling in Mallorca is to rent a car in Mallorca. You can check out for the best rent a car Mallorca. It can search all the rent a car company in Mallorca Airport and Mallorca city office. Then it compares the options to find the best prices on Yolcu360. In the end, it offers the best rent a car Mallorca to you. After choosing the car, you can take is from Mallorca Airport or Mallorca city office. And you can begin your travel without losing any time.', NULL, 16)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (18, 2, N'Car Rental Palma De Mallorca', N'Sometimes, people need a break and go for a holiday. To experience an priceless and admiring holiday, you should take into consideration some important topics. How to travel the island is among these important topics. Because there are lots of things to do and lots of places to visit in Mallorca, so you can prefer rent a car Palma de Mallorca for the best holiday experience. There are numerous options in Mallorca Airport and Mallorca city office. Because of that, it is not easy to find the best rent a car in Palma de Mallorca for you. You do not have to spend your precious time by looking for rent a car in Palma de Mallorca because Yolcu360 can do that on the behalf of you. The only thing that you need to do is to point your demands and expectations. According to these demands and expectations, Yolcu360 searches for a suitable car among the numerous options, then it compares the options to offer the best rent a car Palma de Mallorca with the best prices. In the end, you are free to choose the most suitable one for you. It is also the most practical way of traveling. Because you can take your rent a car Palma de Mallorca and start your holiday without waiting when you arrive at Mallorca Airport or Mallorca city office.', NULL, 17)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (19, 2, NULL, N'Mallorca is one of the most popular holiday destinations in Spain and there are lots of different activities that you can do in the summer months. You can go to a beach for relaxing and swimming. You can attend concerts after a day which is full of sun and sea. It means that you can do everything you want in Mallorca and the island can meet your expectations.', NULL, 18)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (20, 4, N'Barcelona Airport - El Prat (BCN) Rent a Car', N'Barcelona is located in the northeastern part of the Mediterranean coast of the Iberian Peninsula. Barcelona is the second largest city in Spain in population. Barcelona is the capital of Catalonia, which is one of the Spain autonomous regions. Catalan and Castillian Spanish are the official''s language in Barcelona. Barcelona is different from the rest of Spain because of that, you can experience an unforgettable holiday visiting Barcelona. It will be useful to research the architectural items and natural beauties for visiting because it will be more challenging to decide where you should visit when you are in Barcelona. If you want to visit Barcelona, there are so many places that are waiting for being discovered. It is one of the most popular tourist destinations. So many tourists prefer Barcelona for their holiday every year. It is possible to find many cultural items there. We recommend you meet with the special rent a car service of Yolcu360 in Barcelona. You will have a chance to compare and evaluate all of the available car rental options via Yolcu360''s special website and mobile application. Finally, you are ready to discover Barcelona in your car.', N'479490eb-4e8c-4565-960a-e4b5e7c73991barca.jpg', 1)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (21, 4, N'Information About Barcelona', N'Barcelona has numerous famous museums such as; Fundacio Joan Miro or the Museu Picasso. Also, Barcelona is a rich town in terms of architectural items such as the well-known Sagrada Familia and Park Güel, which are designed by Antoni Gaudi. Barcelona has not only cultural and architectural items but also natural beauties. It also offers vast and sandy beaches. So, what is the best way of discovering Barcelona? If Barcelona is among your holiday plans, there are some options that you can prefer for traveling and discovering the city, but to rent a car in Barcelona is the best way of discovering Barcelona.', NULL, 2)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (22, 4, N'Historic Buildings in Barcelona', N'If you are fancier about European countries, Barcelona should be among your destination list. Barcelona is one of the most preffered cities of Europe after London and Paris. There are so many places to visit and explore in there. There are numerous unique architectural structures, and most of them are designed by Antoni Gaudi. Antoni Gaudi was a famous Spanish architect. Barcelona became home to most of his great works such as La Sagrada Familia, Park Guel, Casa Vicens, Palau Güel, Teresian College, Casa Calvet, Bellesguard, and etc. It is possible to find numerous architectural structures works of art in Barcelona. Barcelona is the right place for you if you are looking for arcthitectural structures and works of art. As it is seen, there are numerous places that are waiting for being explored, so it is not possible to visit all places via a tour.', NULL, 3)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (23, 4, NULL, N'Hire a car will be the right choice for you if you want to manage your own holiday. There are so many advantages to hire a car in Barcelona for travelling. Everyting will totally up to you, so there will be no restriction. You can visit wherever and whenever you want. You can stay at anywhere as long as you want. Besides, hiring a car in Barcelona is the most comfortable way of travelling. Also the travelling will be one of the most enjoyable part of your holiday. You can discover not only famous structures in Barcelona but also desolate streets of Barcelona. If you do not have a personal car while travelling, it is possible to have many difficulties especially in terms of personal belongings. But it will be easier travelling with a car, you can carry with your belongings with you wherever you want. If you want to decide hire a car for your holiday, you need to be careful about the companies of car hire. The companies of car hire should be reliable, first of all. Yolcu 360 is the answer that you are looking for. Thanks to Yolcu 360, you can find the most suitable car for you with affordable prices. After that, the only thing you need to do enjoy your holiday.', NULL, 4)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (24, 4, N'Places to see in Barcelona', N'Barcelona is the city of culture, art, history and architecture. It is possible to find so many structures relating to not only culture and art but also history and architecture. So, if you are fancier about culture and history, Barcelona offers many historical and cultural items for you. A holiday in Barcelona is ideally suited for the ones who want to both enjoy and discover new things. There are lots of structures that can amaze you. La Sagrada Familia is the main example for that. La Sagrada Familia is the symbol of Barcelona, also the leader of modern architecture, which was taken over by Antoni Gaudi on 1883. But, Antoni Gaudi could not complete La Sagrada Familia because he died in 1926. So, La Sagrada Familia was left half finished in that period.', NULL, 5)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (25, 4, NULL, N'Nowadays, the building of La Sagrada Familia continues. The architecture of La Sagrada Familia is highly extraordinary, so it can attract millions of tourists every year, also it is known as “ The never-ending church build” among the people. Park Guel is another fantastic structure that you need to see. Park Guel is designed for the Guell Family. Also, Barcelona is not only the perfect place for the ones who fancier about culture and history but also the ones who fancier about football. Camp Nou is one of the most famous stadiums in the world, and it is located in Barcelona. Camp Nou has the spectator capacity of 99.300. It is possible to visit the museum in Camp Nou. There are so many things to do in Barcelona, and most of the tourists prefer car hire in Barcelona. Because car hire makes everything easier for travelers. To travel all around Barcelone at owning your pace appeals the tourists. If you prefer Yolcu360 for hiring a car in Barcelona, it will be easier and safe everything for you.', NULL, 6)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (26, 4, N'Transportation in Barcelona', N'Barcelona is a popular destination for many tourists. It is among the most famous cities in the world. Barcelona is the capital of the autonomous Catalonia region within the Kingdom of Spain. It is known for its unique architecture, amazing food, world-class museums, and art galleries. Also, Barcelona has numerous unique natural beauties. It means that there are a lot of places that you can visit and discover, and there are a lot of things to do. If you do not want to lose your time in organizing your trip destinations in Barcelona, it will be useful to arrange everything before beginning your trip. You can research the famous places in Barcelona, and you can arrange your destinations according to your researches. While you arranging your trip destinations for Barcelona, you should not forget one of the most important topics.', NULL, 7)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (27, 4, NULL, N'How should you travel to Barcelona? There may be so many options for visiting and discovering Barcelona. You can attend some tours. But if you want to be free and not connected to anyone, car rental is just for you. Renting a car is a good way to discover all the corners of the city. There are so many things to see in Barcelona streets. Thanks to car rental, you can arrange everything just for you. Also, another important topic is choosing the car companies. There are lots of choices of car rental companies at the airport. You can compare the prices with Yolcu360, and you can find the most appropriate choice for you. You can do whatever you want or you can go wherever you want. It is possible to discover Barcelona as you wish. After arranging everything including the car rental, you can begin your Barcelona holiday. There will be nothing to do except for enjoying and discovering Barcelona. When you arrive at Barcelone, your car will be waiting for you at Barcelona Airport, which is known as Barcelona El Prat Airport (BCN).', NULL, 8)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (28, 4, N'Car rental Barcelona Sants Train Station', N'Barcelona is a city found in Catalonia, Spain. It becomes one of the first tourist destination of Spain and it has everything to please the tourists. Barcelona has the power of fascinate to the tourists with a history among the oldest in Europe. It will be wrong if it is said that it has only a huge history. Barcelona is also a rich city in terms of cultural and arhitectural. Barcelona is sited between the sea and the mountains, so natural beauty of Barcelona should not be forgotten; it has magnificent beaches in La Costa Brava. The city has amazing impress of being the most cosmopolitan, modern and important in Spain. It means that you can find the traditional and modern in together.', NULL, 9)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (29, 4, NULL, N'If you are in Barcelona, La Sagrada Familia should be the top on your list, it is a wonder of the architecture and designed by Antoni Gaudi. The another masterwork of Gaudi is Park Guell. You shoul not come back from Barcelona without seeing Park Guell. If you are lover of football, Camp Nou the famous stadium in Barcelona will be waiting for you.In addition that, there are numerous museums that you can visit in there. So, do you have any plan about how to travel the city ? You can travel by taxi or bus, or you can use the subway for travelling. Or how about to drive yourself ? Anywhere you want to go in Barcelona is beyond just an enjoyable drive away in your car. There are several possibilities for car rental in Barcelona. You can find the car rental companies at Barcelona Sants Train Station. Barcelona Sants Train Station is the main station in Barcelona. The station is a junction of national, high speed, local and international trains. Also, direct train connection is available between Sants and the airport. Yolcu360, which is a famous company of car rental, finds the options in accordance with your wish and compare them. Thanks to this way, you can find the most suitable car for you.', NULL, 10)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (30, 4, N'Holiday at Barcelona', N'Barcelona is the fascinating city in Spain, and it attracts tourists from all over the world. It is the second biggest city in Spain. The architecture, the art, the history, the culture, delicious food, and the football are brought close together in Barcelona. Barcelona appeals to every kind of person such as; football lover, history lover, culture lover or architectural lover. Every type of person can find something within his or her field of interest. Because of that, this city becomes the most visited city of Spain. There are so many places that are waiting for being explored such as Sagrada Familia, Barcelona Cathedral, Plaça de Catalunya or Camp Nou. In addition to these places, every corner of Barcelona is enchanting and worth for exploring, and it achieves to fascinate the tourists with its natural beauty.', NULL, 11)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (31, 4, NULL, N'If Barcelona takes place in your holiday destination, it will be enjoyable and full of explorings holiday. The best way of these experience is car rental because there are many advantages of renting a car in the moment of traveling. In the holiday, time is of the essence for you, and you do not want to lose any time by looking for a car or any vehicle. If you do not want to lose time by arranging these type of works, it will be good for you to arrange everything in advance. If you rent a car via Yolcu360, it will be safer and easier for you. You can lead your own holiday, and you can do whatever you want. When you arrive in Barcelona, the car will be ready for you, and you can begin your amazing holiday after taking your car. So, there will be no losing time. You can begin to explore amazing Barcelona streets instead of losing time trying to rent a car.', NULL, 12)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (32, 4, N'Museums in Barcelona', N'Who does not want to experience an unforgettable holiday in Barcelona? It is sure that Barcelona is the dream of many people. There are many reasons to visit Barcelona. For example, so much history exists in Barcelona. When we look at the world history, Barcelona is one of the oldest cities of the world. Also, it is possible to see the marks of Antoni Gaudi who is the famous architect and designer in almost every corner of Barcelona. There are so many museums that you can visit. If you are a lover of football, you can visit Camp Nou, which is one of the most famous stadiums in the world. That means Barcelona is a perfect choice for an amazing holiday and there are so many things to do. If you are fond of your comfort, car rental is the right option for you while traveling.', NULL, 13)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (33, 4, NULL, N'But, what about the prices of car rental in Barcelona? To think about car rental in Barcelona can make you scared, but you do not have to be scared. Because it is possible to rent a car at cheaper prices. The season that hiring the car affects the prices mostly. You need to research the companies, and it will be easier the find affordable prices if you compare the prices. Also, preferring smaller cars has advantages in terms of price, and the usage of smaller cars will be easier and more comfortable for you. Other advantages of using smaller cars are that less fuel consumption. In addition to that, you can rent a car with an affordable price thanks to early booking. When you take all these conditions into consideration, to find a suitable car at affordable prices is not an easy thing. You can find the most suitable car for you, and you can rent that car at cheaper prices. Thanks to Yolcu360, to find the most suitable car is super easy for you by comparing prices between the companies.', NULL, 14)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (34, 4, N'Places visit in Barcelona', N'If you want to travel to Europe, to start your travel from Barcelona will be the magnificent beginning of Europe holiday. Barcelona is the second biggest city in Spain and one of the most popular cities in Europe. So many people want to visit Barcelona because it is the city of art and culture. Many architectural structures will be waiting for being explored, these are the mainly; La Sagrada Familia, Park Guell, Casa Mila, Casa Museu Gaudi and so on. Besides, Camp Nou, which is one of the most popular stadiums in the world, is located there. Barcelona is situated between the Mediterranean and the Serra de Collserola Hills. It offers lots of enticements for tourists, so it attracts millions of tourists every year. Every person can find something in accordance with his or her point of interest. Some people want to learn and explore new things, so they can visit museums.', NULL, 15)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (35, 4, NULL, N'The other ones want to have a good time, it is also possible to find available places for them. So, who does not want to travel to Barcelona with a luxury car? Definitely, every person wants to travel on a luxury car. Luxury car rental is not a dream anymore. It is possible to rent a luxury car in accordance with your budget with Yolcu360. Yolcu360 offers all suitable types of luxury car and compare them to find the most suitable one for you. You should book early as far as possible. Also, you may find options for luxury cars with affordable prices thanks to last minute booking. But, early booking offers more extensive options than last minute booking. In the last minute booking, you may have to choose between available cars. Still, it is possible to find affordable prices via Yolcu360. Get ready for a memorable Barcelona experience.', NULL, 16)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (36, 4, N'What to do in Barcelona?', N'Barcelona is the second biggest city in Spain, and so many tourists prefer Barcelona for an amazing and memorable holiday. Another reason for being preferred mostly is that Barcelona can draw every type of person’s attention. It is rich in terms of natural, historical and cultural, so all of them are waiting for being explored. You should arrange everything before beginning the holiday. For example, you can research the places in Barcelona, then you can create your own destination. After beginning your holiday, you can follow the destination that was created in advance. If you are planning a holiday in Barcelona, renting a car will be the right choice for you rather than the other options.', NULL, 17)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (37, 4, NULL, N'Because it may not be possible to travel as you want. You can attend some travel tours but it may not be as comfortable as renting a car. Besides, there are many chances for cheaper prices thanks to early booking. To rent a car becomes a necessity more than the luxury in the last years. Especially, if you are planning travel, renting a car makes everything easier and more practical for you. But there are so many options, so to find the most appropriate one is not an easy task. The features of the car are vital and also the price is another important factor. Yolcu360 compares the prices of cars and offers the best choices for renting a car for you. The small cars are the most appropriate for traveling in terms of parking. Then it will be easier to use small cars in intense traffic. If you rent a car in advance, you can take your car when you arrive at Barcelona Airport. After all, the only thing you need to do is enjoying the holiday.', NULL, 18)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (38, 3, N'Madrid Barajas International Airport Rent a Car', N'You can use airways or train way for arriving Madrid. If you use airways for arriving, you can find everything that you may need in Madrid Airport. Also you can prefer train way and it is the same, you can find everything in Madrid Atocha train station. So, if you need car hire Madrid, it is also possible to find several car hire companies in Madrid Airport or Madrid Atocha train station. You can search yolcu 360 for finding the suitable car rental Madrid easily. Yolcu 360 searches for the best car hire Madrid among all the options and it compares them to find the best price. Then the car will be ready for you in Madrid Airport or Madrid Atocha train station.', N'f33e058e-85ca-4474-acdc-3f1166c9a39cmadrid.jpg', 1)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (39, 3, N'What to do in Madrid?', N'Madrid is among the most popular holiday destinations of European countries. Every year, millions of tourists visit the city because itt is a great place for exploring. There are so many different things that you can do in Madrid. For example, you can taste Spanish hot chocolate in Chocolatería San Ginés if you visit Madrid in winter months. Also you can see Flamenco tableos in Madrid. Even if Flamenco is a dance that originated in Andalusia, Murcia and Extremadura, Madrid has some famous tablaos in the country. It is also possible to see a variety of cultural and historical items in the city. You can see Madrid’s art collections in Reina Sofia Museum. The many works by the 20th-century artists Picasso and Dalí are available in the museum, so that makes the museum one of the most visited attractions of the city. The other place that worths for being visited is Royal Palace, which was built in the mid-1700s for King Philip V. You should see the inside of Royal Palace for the full experience because the royal collections and frescoes are sublime.', NULL, 2)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (40, 3, NULL, N'Madrid is the capital city of Spain and it is also the largest city of the country. If Spain is on your destination list, you can begin to travel from Madrid, which is the capital city. So, which places can you visit in Madrid? Puerta del Sol is the main square of Madrid. Also, it is a popular meeting place for not only locals but also tourists. This square is found next to Casa de Correos, which is Post Office Building. There is a clock at the top of the Casa de Correos, as this marks the televised countdown on New Year’s Eve. You can have a good time in Puerta del Sol, so it will be better to begin your travel from there. If you want to explore the sense of the city, Gran Vía is a great place for you. You can walk along Gran Vía. It is a centre of entertainment, shopping and cultural. You can do shopping or go to a cafe for drinking something. Gran Vía is so full of life that you may not be aware of the time and spend hours in there without awaring. There are also lots of historical places in Madrid such as; Royal Palace.', NULL, 3)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (41, 3, N'Historic Buildings in Madrid', N'Madrid is the great place for an unique holiday experience. There are so many reasons of being the great place for experiencing a great holiday. First of all, the city appeals to every type of person. It means that every type of person can something interesting for themselves. For the ones who loves historical sites, there are lots of places that waiting for being visited. Here are the some amazing historical structures for the ones who love history. If you want to trip through Spain’s rich history, National Archaeological Museum will be waiting for its visitors. You can see the a variety of pieces gathered from across Spain. Royal Palace is the another important and the most visited structures in Madrid. It was constructed in the mid-1700s for King Philip V. You should visit the inside of Royal Palace to see royal collections. If you are fancier about football, you could not come back from Madrid without seeing Santiago Bernabéu Stadium. Even if you do not be fancier about football, still you may want to see the stadium because Real Madrid are among Europe’s most successful football team with a record-breaking 11 European Cups to their name. Also you can explore the natural beauties of the city.', NULL, 4)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (42, 3, NULL, N'The Prado is one of the best and most famous museums in the world so it is among the places that you should visit absolutely. The collection of masterpieces by renaissance and baroque masters are found in the museum. There are a variety of must-see works in there, so the Prado should be in your list.', NULL, 5)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (43, 3, NULL, N'Car rental Madrid Airport is the most preffered way of travelling the city. If you are looking for a car rental Madrid Airport, there are some places that you can find the suitable cars. There are several car rental companies in Madrid Airport and Madrid Atocha train station. Yolcu 360 helps you to find the best car rental Madrid Airport by searching all the companies. It makes everything more practical for you. After all, you can take your car rental Madrid Airport from Madrid Atocha train station or Madrid Airport.', NULL, 6)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (44, 3, N'Holiday at Madrid', N'Who do not want to experience a memorable holiday on the Mediterrenaen coastline? If you are also among ones who want to experience an amazing holiday, Spain is a great place for you. Why you should prefer Spain for an amazing holiday? There are lots of reasons of choosing the country as a perfect holiday destination. There are several famaous cities in Spain. Madrid, which is the capital city, is one of the most famous cities of Spain. Madrid appeals to every type of people. If you are the lover of art, you can lose yourself in Madrid. It is possible to see numerous art works which was made by Spanish painters such as Picasso, Dalí and Miró. The Prado is among the must-see places for the art lovers. The Prado is one of the most famous art museums in the city. It is possible to see the collection of masterpieces by renaissance and baroque masters. The other famous museum after the Prado is Thyssen-Bornemisza Museum of Art. It is a part of Madrid’s Golden Triangle of Art. You can see the works of art that were made by the artists like Hans Holbein, Hans Baldung Grien and Albrecht Dürer. There are also lots of different places that appeal different types of people.', NULL, 7)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (45, 3, NULL, N'You can make your holiday more comfortable and flexible by preffering car rental Madrid Spain. You can find several car rental companies in Madrid Airport and Madrid Atocha train station. If you want to the best car rental Madrid Spain, yolcu 360 is here to help you. It searches all the car rental companies to find the most suitable car rental Madrid Spain for you according to your budget. Then the car will be ready when you arrive at Madrid Airport or Madrid Atocha train station.', NULL, 8)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (46, 3, N'Museums in Madrid', N'Madrid is an amazing city that is full of life and culture. That makes Madrid is the one of the perfect holiday destinations. Let’s have a loot at the amazing places in Madrid. The Prado is one of the best and most famous art museum in the world. You can see the collection of masterpieces by renaissance and baroque masters in the museum. It is one of the most visited places in the city. Royal Palace is the other famous place that is preffered mostly. It was built in the mid-1700s for King Philip V. You should go inside for the full experience. If you want to see historical items of Madrid, you can visit National Archaeological Museum. Invaluable pieces gathered from across Spain are available in National Archaeological Museum. It is a trip through Spain’s rich history. There are also popular squares that you can do shopping, walking or drinking something in a cafe. Puerta del Sol is a grand square next to the Casa de Correos, which is Post Office Building. It is popular meeting place for both locals and tourists.', NULL, 9)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (47, 3, N'Places to Visit in Madrid', N'Madrid is one of the most famous cities of Spain and the city is visited by millions of tourists every year. It is possible to find full of life and culture in Madrid. You have to reserve a long time to explore the every corner of the city because there are so many places that are waiting for being explored. If you want to see the natural beauties of Madrid, you can visit Retiro Park. The Retiro Park is just a few steps away from the Prado. So it can be your next destination after the Prado. The another historical masterpiece is Royal Palace. Royal Palace was built in the mid-1700s for King Philip. It is the largest royal palace in western Europe.', NULL, 10)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (48, 3, NULL, N'Madrid is one of the most famous cities of Spain and the city is visited by millions of tourists every year. It is possible to find full of life and culture in Madrid. You have to reserve a long time to explore the every corner of the city because there are so many places that are waiting for being explored. If you want to see the natural beauties of Madrid, you can visit Retiro Park. The Retiro Park is just a few steps away from the Prado. So it can be your next destination after the Prado. The another historical masterpiece is Royal Palace. Royal Palace was built in the mid-1700s for King Philip. It is the largest royal palace in western Europe.', NULL, 11)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (49, 3, NULL, N'Rent a car Madrid is the most preffered way of an unique holiday. Because it offers both comfort and reasonable prices. If you are wondering about how it is possible, you can check out yolcu 360. It helps you to find the suitable rent a car Madrid with reasonable prices by searching and comparing among the all options in Madrid Airport and Madrid Atocha train station. If you find the rent a car Madrid in advance, that makes everything more practical for you. You can take the car from Madrid Airport or Madrid Atocha train station.', NULL, 12)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (50, 3, NULL, N'So, what is the best way of travelling in Madrid? The answer can change according to your demands and expectations from the holiday. If you want to experience an unique holiday, you should prefer car rental Madrid. Because car rental Madrid gives you the chance of managing your own holiday at your own pace. You can create your own destination. That makes your holiday more memorable for you. There are so many car rental companies in Madrid Airport and Madrid Atocha train station. You can search yolcu 360 for the best car rental Madrid if you don’t lose any time by looking for a car. It searches and finds the ideal option with the ideal prices. Then you can take your car rental Madrid from Madrid Airport or Madrid Atocha train station.', NULL, 13)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (51, 3, N'Places to See in Madrid', N'Madrid is the capital city of Spain. There are a number of famous cities in Spain and Madrid is also one of these most popular holiday destinations. There are lots of historic sights and natural beauties that you can visit. Here are the some places that you can visit; Plaza Mayor is one of the must-see places in Madrid. There are nine entrances to the square and within the porticoes at the bottom of the buildings are several cafes. You can walk and explore the square. It is possible to take lots of amazing photos in this grand square. After Plaza Mayor, you can reach Mercado San Miguel easily from Plaza Mayor. It is a marketplace that dates to 1916. Mercado San Miguel hosts of tapas bars here serving all the favourites like patatas bravas, gambas al ajillo and boquerones, with a glass of beer, rioja or vermouth. It also Europe’s largest municipal market with 200 stalls. The other thing that you can do is to see flamenco show. Flamenco shows are highly popular in Madrid.', NULL, 14)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (52, 3, NULL, N'If you want to create your own destination list, you should prefer rent a car Madrid Atocha. There are lots of possiblities of rent a car if you prefer to travel with your own car. It is possible to find rent a car companies in Madrid Airport and Madrid Atocha train station. Yolcu 360 can help you about finding the suitable rent a car Madrid Atocha. It searches all the companies for appropriate one according to your demands and expectations. The only thing that you need to do is choosing the suitable rent a car Madrid Atocha for you. So, when you arrive at Madrid Atocha train station, it is possible to take the car and begin your travelling without losing any time.', NULL, 15)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (53, 3, N'Car Rental Madrid Train Station', N'There are lots of places to visit, so car rental Madrid train station can be the right choice for you. There are lots of car rental companies in Madrid Airport and Madrid train station. To find the suitable car rental is easy with the help of Yolcu 360. Yolcu 360 searches for all the car rental Madrid train station companies. After all, it offers the best car rental Madrid train station and it compares the options to find the best prices. Yolcu 360 just searches for a suitable car, then the choice is yours. After choosing your car rental, it will be ready for you when you arrive at Madrid Airport or Madrid train station.', NULL, 16)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (54, 3, N'Rental Cars in Madrid Airport', N'Malaga is one of the most famous cities in Europe. It is possible to learn many things about Spain culture in Madrid. There are a variety of places that you should see in the city. If you want to experience a unique holiday, it will be better to arrange everything in advance. for example, you can create your own destination list according to the places that you want to see and you can prefer Madrid Airport car rental return for the best holiday experience. So you can follow your own destination list. There are several car rental companies in Madrid Airport and Madrid Atocha train station. The easiest way of finding the suitable car is Yolcu 360. Yolcu 360 searches all the suitable cars which is in Madrid Airport and Madrid Atocha train station. Then it compares the options to find the best prices. Also it is the most practical way. When you arrive at Madrid, your Madrid Airport car rental return will be ready. You can take it and begin your holiday without losing any time.', NULL, 17)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (55, 3, N'Cheap Car Rental Madrid', N'Every people is dreaming about a holiday in Madrid. Madrid is highly popular holiday destination among the European countries. But the prices can make you scary and you may have to give up on your dreams. Now, you do not have to be scared because it is possible to experience an admiring and unique holiday with cheaper prices in Madrid. The most economical way of travelling in the Madrid is car rental. To find cheap car rental Madrid is not impossible, anymore. You need to book in advance if you want to find affordable prices for car rental. Also you can take help from Yolcu 360. Thanks to Yolcu 360, you can find the best car for you among the all companies in Madrid Airport or Madrid Atocha train station. It searches for the cheap car rental Madrid, it also compares the options to find the best prices. When you arrive at Madrid Airport or Madrid Atocha train station, your car rental will be ready for you. So you do not lose any time by looking for a cheap car rental Madrid after arriving the city and you can hit the road.', NULL, 18)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (56, 3, NULL, N'Madrid has so many attractions that you can visit. Puerta del Sol is a grand square of Madrid. This square is highly popular and famous so it is a meeting point for both tourists and locals. Also it is possible walking, shopping and drinking something in a cafe in Gran Vía. In the evenings you can go to the cinema or a musical. In the night, there are so many nightclubs that you can enjoy in there. So Gran Vía offers all types of entertainment to you. Mercado San Miguel is a gorgeous marketplace which dates back to 1916. It’s Europe’s largest municipal market with 200 stalls. So these places are among the must-see places of Madrid.', NULL, 19)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (57, 3, N'Rental Cars in Madrid', N'What is the best way of travelling? If you want to explore every corner of the city, to prefer rental cars in Madrid will be the right choice for you. You can lead your own journey at your own pace thanks to rental cars in Madrid. You can find a variety number of rental cars in Madrid in Madrid Airport or Madrid Atocha train station. To find the best rental cars in Madrid is not easy among all the rental cars so yolcu 360 makes finding the suitable rental cars easier for you. It searches all the companies to find the best rental cars in Madrid and it compares the options for reasonable prices. Then you can take your car in Madrid Airport or Madrid Atocha train station.', NULL, 20)
GO
INSERT [dbo].[AboutCities] ([Id], [CityId], [Title], [Desc], [ImageName], [Order]) VALUES (58, 3, NULL, N'So, which places can you visit in Madrid? Gran Vía is a great place to start your amazing travel in Madrid if you want to feel the sense of the city. You can walk through it and explore the city. Gran Vía offers entertainment, shopping and so on. So you can spend hours without even noticing. Also Plaza Mayor is the other must-see place. It is a renaissance square, laid out in the early-1600s. Nine entrances to the square are available, also you find several cafes at the bottom of the buildings. In Reina Sofia Museum, you can see Madrid’s art collections. These art collections are masterpiece of the 20th-century artists Picasso and Dalí. So you can add the museum in your destination list. If you want to feel the nature in Madrid, you can see Retiro Park. The Retiro is Madrid’s green heart and full of elegant gardens. It was a royal property until the end of the 19th century. Then it was opened to the public. These are just some of the amazing places of Madrid. There are also some other places that are waiting for being visited.', NULL, 21)
GO
SET IDENTITY_INSERT [dbo].[AboutCities] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'04d7ed47-3590-4069-b3c7-394836cb9dbf', N'SuperAdmin', N'SUPERADMIN', N'adc4f298-cf99-43fe-b61a-c025a027ed02')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7e30ae7c-d717-49d5-a2d5-6ee20a02c2f3', N'Admin', N'ADMIN', N'568ada74-7ada-4153-9982-ed49c1fff27c')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e', N'Member', N'MEMBER', N'4d653399-8613-4af8-899d-830770d261bf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'53a9029e-8329-4101-b640-1f5e12e88179', N'04d7ed47-3590-4069-b3c7-394836cb9dbf')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fa1cac95-95e4-4042-a744-42428bab91c5', N'7e30ae7c-d717-49d5-a2d5-6ee20a02c2f3')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0c8b06bf-2434-49cb-8c3f-16d09f91e9e3', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'34584a23-f9bf-4cb8-9f86-c54a115f0987', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'55a1a4d1-e207-4a2b-a362-88f98aa96399', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a91a7d6e-bf2c-4166-9027-83a06fb46ec2', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa8f873b-68b1-43cb-8ad4-0822cb1623c8', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b0563f89-f92f-41ac-ade8-9aaec63cec03', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', N'b91f8b9b-606a-4a04-98a1-11cfb06c9f5e')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'0c8b06bf-2434-49cb-8c3f-16d09f91e9e3', N'AppUser', N'Bahruz Rahimli', N'bexarehimlee', N'BEXAREHIMLEE', N'behruzrehimov@mail.ru', N'BEHRUZREHIMOV@MAIL.RU', 1, N'AQAAAAEAACcQAAAAECTWCv3ynTGKJwqIcAVNVTEw7T3y/3EawErOZdNDwjhmV5jChW7If6kKk+BuAWqkkQ==', N'6WBXT4SRZRS2FJDJBOUQQLFEYQYE4TF6', N'309f3568-970e-4f37-9386-8532e27eeef8', NULL, 0, 0, NULL, 1, 0, 6216, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'34584a23-f9bf-4cb8-9f86-c54a115f0987', N'AppUser', N'Irade Rehimova', N'Irada77', N'IRADA77', N'iradarahimova@gmail.com', N'IRADARAHIMOVA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAvMNlLZ4VXgvU0ZXDhHANf29iFA/hcL03J/PZU9C2D0B8XA3W2gmajig4klO03vKw==', N'HX2FMGGLGOZXJWUZFFHDT7STZLX3TOUQ', N'724e53e9-1b18-4489-9678-47179307c286', NULL, 0, 0, NULL, 1, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'53a9029e-8329-4101-b640-1f5e12e88179', N'AppUser', N'Super Admin', N'SuperAdmin', N'SUPERADMIN', N'SuperAdmin@gmail.com', N'SUPERADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOvY5+Zm1F6i86HFX5ZTd4v8yLF6KKp+a5knn2r9Aiesji5hoSdgHDNx3eQdWbqfnQ==', N'5DH5W57LOTKDEFLNZ76I6XFH5DPW4BAH', N'607b053a-7373-4a9f-94f1-07fa9ebbf5f4', NULL, 0, 0, NULL, 1, 0, 0, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'55a1a4d1-e207-4a2b-a362-88f98aa96399', N'AppUser', N'Agabala', N'Agabala', N'AGABALA', N'agabala.93@gmail.com', N'AGABALA.93@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOZL3cazKoac1xzmrAOJx8L8qBykywkd7yL11a9lAf074iYjh43EXLAZTu6Nd5drcA==', N'OGKUZ264JZBHXWQLXI7EDVKPDJZP2MH3', N'82a19928-aced-44af-b985-2cb8015193fd', NULL, 0, 0, NULL, 1, 0, 4021, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'a91a7d6e-bf2c-4166-9027-83a06fb46ec2', N'AppUser', N'Rehim Veliyev', N'rehim2', N'REHIM2', N'rehimveliyev1@gmail.com', N'REHIMVELIYEV1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOv+0mxdm1v+lFwW7x2aykQ584rRdNP62KYd3Bv2HnaVAdTKB+D9QkOBr0z2As+LvA==', N'YNABBWRM32I2AK6KQZ4MUCBSNU7COHQF', N'0f73f7ca-662c-4155-87a3-9a5f39b412fc', NULL, 0, 0, NULL, 1, 0, 1199, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'aa8f873b-68b1-43cb-8ad4-0822cb1623c8', N'AppUser', N'Xalid', N'Xalid123', N'XALID123', N'khalidms@code.edu.az', N'KHALIDMS@CODE.EDU.AZ', 1, N'AQAAAAEAACcQAAAAEFpQIvnPH1kyeHVtDuDmO/E+9TqDmxBUlIeeVsh/HSy+DzwHgweXD4fSRJ7fTKyCJg==', N'LWAN66XJKN6T6AIEBOQCK64RMTYBX2YP', N'3ec42c49-3021-49a0-b7a5-c8e102ef596d', NULL, 0, 0, NULL, 1, 0, 8529, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'b0563f89-f92f-41ac-ade8-9aaec63cec03', N'AppUser', N'Behruz Rehimov', N'bexarehimli', N'BEXAREHIMLI', N'bahruzkr@code.edu.az', N'BAHRUZKR@CODE.EDU.AZ', 1, N'AQAAAAEAACcQAAAAENgloxz57HdFeNPlRG4kqkaf7vVEDFpCgXcX20GVVubJDY1B4sRrQGMwUm8KL+gKkw==', N'THBKOSY4ECAXC7MZ6LBQGPNH7LRBPRID', N'b907b900-fd93-4cd6-9d62-cb5d8bb924f7', NULL, 0, 0, NULL, 1, 0, 3856, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', N'AppUser', N'Nigar Mahmudova', N'NigarMahmud', N'NIGARMAHMUD', N'nigar.makhmud@outlook.com', N'NIGAR.MAKHMUD@OUTLOOK.COM', 1, N'AQAAAAEAACcQAAAAEIRSKPtvkrOWx6VpardgdaigydmKIyCBZXVxOaPmXd6OFB3Tym+CLqGDU89ITjDYGw==', N'GEN6DLOOFAWAAURD5FHFU3QH44DSQP6I', N'880ada74-f6dd-4f08-b89b-463d058e2249', NULL, 0, 0, NULL, 1, 0, 9273, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', N'AppUser', N'Rehim Veliyev', N'rehimdevop', N'REHIMDEVOP', N'rahimvaliyev99@gmail.com', N'RAHIMVALIYEV99@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECh2XGS87h/z9cElCPRURxAB8dZatD84DX/JYVV8oH0JCqFlggLRUGKYsEg9/EdN1A==', N'JXUNDFYZ65VDSXS6LVVV2TSGKYJ7O5RU', N'8b891406-2892-4bf4-ae03-0de7428c3d96', NULL, 0, 0, NULL, 1, 0, 4011, NULL, NULL, NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Fullname], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [MailConfirmCode], [Address], [Birthday], [Pasport]) VALUES (N'fa1cac95-95e4-4042-a744-42428bab91c5', N'AppUser', N'Behruz Rehimov', N'AdminBahruz', N'ADMINBAHRUZ', N'0555547775', N'0555547775', 0, N'AQAAAAEAACcQAAAAEJX4pRoTCnTWXRIzQB2Px3ktrK5Sw19JnqAQYs2Gdf8MQZlPG7YiyTdPU8DIO0kJlg==', N'ZYYQHYNTO2TS5NDWPXJDQSZYNUV3QITZ', N'7fe96eeb-a07a-4ab8-a576-b0ea68df28f5', N'0555547775', 0, 0, NULL, 1, 0, 0, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (1, N'Mercedes Benz')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (2, N'Ford')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (3, N'Opel')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (4, N'Volkswagen')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (5, N'Renault')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (6, N'BMW')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (7, N'Audi')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (8, N'Fiat')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (9, N'Honda')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (10, N'Kia')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (11, N'Rande Rover')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (12, N'Nissan')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (13, N'Skoda')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (14, N'Hyundai')
GO
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (15, N'Toyota')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (2, N'BMW X3', 263.6500, 451.9700, CAST(1500.00 AS Decimal(18, 2)), N'96856b15-614d-4a82-8fcf-48a8a7fe1bc6car1.png', 1, 0.0000, 27, NULL, NULL, 1, 4, 11, 19, 18, 5)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (3, N'Hyundai Accent Blue', 45.6900, 112.9900, CAST(750.00 AS Decimal(18, 2)), N'44e380c1-1786-47d2-8a5e-97964960c795car3.png', 1, 0.0000, 23, NULL, NULL, 2, 4, 3, 19, 11, 2)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (4, N'Opel Astra Sedan', 44.4700, 56.4900, CAST(1500.00 AS Decimal(18, 2)), N'21750971-44e5-4173-b30c-989a9b0f931ecar4.png', 1, 0.0000, 25, NULL, NULL, 2, 4, 6, 19, 15, 2)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (5, N'Mercedes Benz Vito', 362.9800, 376.6400, CAST(900.00 AS Decimal(18, 2)), N'98c450fa-4da9-4e27-98a3-f9f629adcc4fcar5.png', 1, 0.0000, 27, NULL, NULL, 2, 1, 10, 19, 3, 5)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (6, N'Fiat Doblo', 29.4100, 75.3200, CAST(1500.00 AS Decimal(18, 2)), N'c78825d8-985f-4a46-b17b-a77098819f8ecar6.png', 1, 0.0000, 23, NULL, NULL, 2, 1, 9, 19, 19, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (7, N'Fiat Doblo Cedan', 28.5700, 72.4400, CAST(1500.00 AS Decimal(18, 2)), N'18fb01cf-78cb-42fb-a242-0d3cbd5035f7car6.png', 1, 0.0000, 23, NULL, NULL, 2, 1, 9, 19, 19, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (8, N'Mercedes Benz E Series', 183.7100, 188.3200, CAST(1500.00 AS Decimal(18, 2)), N'bd207b0e-f97c-44f4-8c59-c156260203dccar7.png', 1, 0.0000, 27, 25, 3, 1, 2, 1, 19, 5, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (9, N'Mercedes Benz C Series', 131.6600, 188.3200, CAST(1500.00 AS Decimal(18, 2)), N'80d2f181-86e8-409f-bf6e-c0293e3bbe48car8.png', 1, 0.0000, 27, 21, 3, 1, 2, 4, 19, 6, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (10, N'Hyundai Tucson', 147.8100, 197.9400, CAST(750.00 AS Decimal(18, 2)), N'2d5081e1-5a1e-41dc-9841-7039087e4852car9.png', 1, 0.0000, 28, NULL, NULL, 1, 1, 11, 19, 10, 5)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (11, N'Kia Rio', 49.4900, 56.4900, CAST(1150.00 AS Decimal(18, 2)), N'3292126c-1f2d-4b61-902a-f815b3ea3035car10.png', 1, 0.0000, 21, NULL, NULL, 1, 4, 6, 19, 7, 4)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (12, N'Nissan Juke', 49.8000, 94.1600, CAST(1050.00 AS Decimal(18, 2)), N'd3a5e265-9c1c-48b1-a33b-1ded29b23587car11.png', 1, 0.0000, 25, 22, 2, 1, 4, 11, 19, 13, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (13, N'Nissan Qashqai', 68.1000, 131.8200, CAST(1050.00 AS Decimal(18, 2)), N'b50da17d-79fd-4d6d-84b1-f0c17115c055car11.png', 1, 0.0000, 25, 23, 2, 1, 4, 11, 19, 14, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (14, N'Toyota Corolla', 62.5800, 75.3200, CAST(1500.00 AS Decimal(18, 2)), N'abd4f575-9b9a-4136-b791-3bab48cc0113car12.png', 1, 0.0000, 24, 21, 1, 1, 3, 6, 19, 17, 3)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (17, N'Kia Rio', 57.1100, 58.4700, CAST(1500.00 AS Decimal(18, 2)), N'b99f12c5-10f2-4f12-99df-1b84ae50382bcar1.png', 1, 0.0000, 24, NULL, NULL, 1, 4, 6, 23, 7, 2)
GO
INSERT [dbo].[Cars] ([Id], [Name], [PriceDaily], [DepozitPrice], [TotalMillage], [ImageName], [IsFreeCancelation], [CancelationPrice], [MinDriverAge], [MinYoungDriverAge], [MinYoungDriverLisanseYear], [Transmission], [FuelType], [TypeId], [OfficeId], [ModelId], [MinDriverLisanseYear]) VALUES (18, N'Hyundai Santa Fe', 333.2400, 345.5300, CAST(1500.00 AS Decimal(18, 2)), N'bcf34909-48ec-4ead-923b-1ab6d3192f35car2.png', 1, 0.0000, 25, NULL, NULL, 1, 4, 9, 23, 24, 2)
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (2, N'Mallorca', 1, N'1ef1ea3f-fa28-44f0-9459-5e7d2cdae748mallorca.jpg', 0, 1)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (3, N'Madrid', 1, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (4, N'Barcelona', 1, N'd3402686-e15f-40d0-b40a-987e63ac7caeBarcelona.jpg', 2, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (5, N'Rome', 2, N'a5789d7f-7016-4a5b-838d-8ed6987be8baroma.jpg', 3, 3)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (6, N'Milano', 2, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (7, N'Paris', 3, N'5b8b0a25-e097-46a6-9284-814c2426e850paris.jpg', 4, 4)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (8, N'Nice', 3, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (9, N'Vienna', 4, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (10, N'Zurich', 5, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (11, N'Berlin', 6, N'9043ab22-fa8e-4dc9-9589-ee3302adfbc5berlin.jpg', 0, 2)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (12, N'Munich', 6, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (13, N'Dusseldorf', 6, NULL, 1, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (14, N'Cologne', 6, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (15, N'Amsterdam', 7, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (16, N'Frankfurt', 6, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (17, N'Istanbul', 9, NULL, 6, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (18, N'Athens', 8, NULL, 0, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (19, N'Izmir', 9, NULL, 7, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (20, N'Ankara', 9, NULL, 8, 0)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (22, N'London', 11, N'1ef4dd8a-dac1-4b51-a680-31c66f907a7blondon.jpg', 0, 5)
GO
INSERT [dbo].[Cities] ([Id], [Name], [CountryId], [ImageName], [HomeSliderOrder], [HomePopularOrder]) VALUES (30, N'Baku', 12, N'5ee43bfc-c969-4aac-a6b7-9d9e42acb72bcar1.png', 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (1, N'Spain')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (2, N'Italy')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (3, N'France')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (4, N'Austria')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (5, N'Switzerland')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (6, N'Germany')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (7, N'Netherlands')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (8, N'Greece')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (9, N'Turkey')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (11, N'United Kingdom')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (12, N'Azərbaycan')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Model] ON 
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (3, 1, N'Vito')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (4, 1, N'C200')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (5, 1, N'E serias')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (6, 1, N'C series')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (7, 10, N'Rio')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (8, 10, N'Sportage')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (9, 10, N'Sorento')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (10, 14, N'Tucson')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (11, 14, N'Accent')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (12, 14, N'Elantra')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (13, 12, N'Juke')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (14, 12, N'Qashqai')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (15, 3, N'Astra')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (16, 3, N'Corsa')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (17, 15, N'Corolla')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (18, 6, N'X3')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (19, 8, N'Doblo')
GO
INSERT [dbo].[Model] ([Id], [BrandId], [Name]) VALUES (24, 14, N'Santa Fe')
GO
SET IDENTITY_INSERT [dbo].[Model] OFF
GO
SET IDENTITY_INSERT [dbo].[Offices] ON 
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (3, N'Palma de Mallorca Airport', 2, N'Carretera Del Aeropuerto Camí De Son Fangós, 147 Palma de Mallorca', N'07:00-23:00', N'(34) 971494160')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (4, N'Barcelona El Prat Airport', 4, N'Aeropuerto El Prat *No Truck Return* Keybox İn Parking El Prat de Llobregat', N'07:00 -23:59', N'+(34) 911505000')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (5, N'Madrid-Barajas Adolfo Suárez Airport', 3, N'Av. De La Hispanidad.', N'07:00 -23:00', N'+(34) 918341400')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (6, N'Rome Fiumicino Leonardo da Vinci Airport', 5, N'Rome Fiumicino Leonardo da Vinci Airport', N'07:00 -23:59', N'+(34) 918341400')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (7, N'Milano Ferno Malpensa Airport', 6, N'Malpensa Airport C/O Terminal 1 Malpensa Apt', N'07:30 -23:30', N'+(39) 230568786')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (8, N'Paris Charles de Gaulle Airport', 7, N'Charles De Gaulle Apt Terminal 1', N'08:00 -22:00', N'+(33) 825825490')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (9, N'Nice Côte d''Azur Airport', 8, N'34 Boulevard Des Jardiniers', N'07:30 -21:30', N'+(33) 825825490')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (10, N'Vienna Airport', 9, N'Büro Eg Shuttle Bus To Zeppelinstrasse 4,', N'08:00 -20:00', N'+(43) 6649159040')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (11, N'Zurich Zurich Airport', 10, N'Zurich Zurich Airport', N'08:00 -20:00', N'+(43) 6649159040')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (12, N'Berlin Brandenburg Airport', 11, N'Flughafen Berlin Brandenburg Melli-Beese-Ring 1', N'07:00 -23:00', N'+(49) 306349160')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (13, N'Munich Airport', 12, N'Terminalstraße Mitte', N'08:00 -21:00', N'+(34) 902360636')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (14, N'Dusseldorf Airport', 13, N'Flughafenstrasse 120', N'07:00 -22:00', N'+(49) 211942380')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (15, N'Cologne Bonn Airport', 14, N'Mietwagenzentrum Ankunftsebene 0 Terminal 2', N'09:00 -15:00', N'+(49) 2203955880')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (16, N'Amsterdam Schiphol Airport', 15, N'Amsterdam Airport Schiphol Aankomstpassage 10', N'07:00 -22:00', N'+(31) 208092090')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (17, N'Athens Spata Artemida Airport', 18, N'114 Leoforos Varis Koropiou Avenue - - -', N'08:00 -21:00', N'+(30) 2106022300')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (18, N'Frankfurt an der Oder Airport', 16, N'Terminal - Car Rental Center', N'08:00 -23:59', N'+(49) 6543509558')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (19, N'Istanbul Airport', 17, N'Tayakadın Mahallesi, Terminal Caddesi No:1 34283', N'00:00 -23:59', N'+(90) 2127055856')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (20, N'Heathrow Airport', 22, N'Holiday İnn M4j4 Sipson Road West Drayton', N'07:00 -19:00', N'+(44) 2086197000')
GO
INSERT [dbo].[Offices] ([Id], [Name], [CityId], [Address], [OpenTimes], [Phone]) VALUES (23, N'Baku-Heydar Aliyev International Airport', 30, N'Bina Settlement - -', N'10:00-19:00', N'+(994) 502779988')
GO
SET IDENTITY_INSERT [dbo].[Offices] OFF
GO
SET IDENTITY_INSERT [dbo].[Rents] ON 
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (7, 2, N'test1', N'Test2', N'rahimvaliyev99@gmail.com', N'test2', N'Test2', N'test2', 0.0000, 0.0000, CAST(N'2023-09-05T18:48:36.8870000' AS DateTime2), CAST(N'2023-09-08T18:48:36.8870000' AS DateTime2), NULL, NULL, CAST(N'2023-09-05T18:50:48.2160337' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (8, 8, N'test1', N'Test2', N'rahimvaliyev99@gmail.com', N'test2', N'Test2', N'test2', 367.4200, 19.8000, CAST(N'2023-09-05T20:00:00.0000000' AS DateTime2), CAST(N'2023-09-07T20:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2023-09-05T19:02:06.6450717' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1002, 4, N'Test2', N'Test2', N'rahimvaliyev99@gmail.com', N'test2', N'Test2', N'test2', 133.4100, 29.7000, CAST(N'2023-09-06T08:54:12.9760000' AS DateTime2), CAST(N'2023-09-09T08:54:12.9760000' AS DateTime2), N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', NULL, CAST(N'2023-09-06T12:56:41.9656640' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1004, 4, N'Behruz Rehimov', N'0555547775', N'behruzrehimov@mail.ru', N'02.08.2022', N'Xirdalan seheri', N'AA55477', 44.4700, 8.4500, CAST(N'2023-09-07T20:00:00.0000000' AS DateTime2), CAST(N'2023-09-08T20:00:00.0000000' AS DateTime2), NULL, NULL, CAST(N'2023-09-07T15:50:35.6943578' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1005, 7, N'Bahruz Rahimli', N'0555547775', N'behruzrehimov@mail.ru', N'02.08.2022', N'Xirdalan seheri', N'AA55477', 85.7100, 0.0000, CAST(N'2023-09-07T18:36:06.7230000' AS DateTime2), CAST(N'2023-09-10T18:36:06.7230000' AS DateTime2), NULL, NULL, CAST(N'2023-09-07T22:39:19.1378635' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1006, 12, N'Bahruz Rahimov', N'0555547775', N'bahruzkr@code.edu.az', N'02.08.1995', N'Xirdalan seher seans 47', N'AA123854', 149.4000, 0.0000, CAST(N'2023-09-09T11:12:45.6930000' AS DateTime2), CAST(N'2023-09-12T11:12:45.6930000' AS DateTime2), N'b0563f89-f92f-41ac-ade8-9aaec63cec03', NULL, CAST(N'2023-09-09T15:20:04.0810694' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1007, 7, N'Bahruz Rahimli', N'0555547775', N'behruzrehimov@mail.ru', N'02.08.2022', N'Xirdalan seheri', N'AA55477', 85.7100, 0.0000, CAST(N'2023-09-10T08:11:29.1490000' AS DateTime2), CAST(N'2023-09-13T08:11:29.1490000' AS DateTime2), N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', NULL, CAST(N'2023-09-10T12:18:40.3386749' AS DateTime2))
GO
INSERT [dbo].[Rents] ([Id], [CarId], [Fullname], [Phone], [Email], [Birthday], [Address], [Pasport], [CarPrice], [ExtPrice], [PickUpDate], [DropOffDate], [UserId], [DropOfficeId], [CreateDate]) VALUES (1008, 3, N'Nigar Mahmudova', N'0554741038', N'nigar.makhmud@outlook.com', N'02.08.2000', N'Heyder Aliyev', N'AA55477', 137.0700, 0.0000, CAST(N'2023-09-10T08:39:07.7620000' AS DateTime2), CAST(N'2023-09-13T08:39:07.7620000' AS DateTime2), N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', NULL, CAST(N'2023-09-10T12:45:52.8313199' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Rents] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (4, 2, N'Fikrimce mashini rahatligi, surush hissi kifayet qeder yaxshidir', 4, 5, 5, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-08-31T06:36:44.8981303' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (5, 2, N'Chox yaxshi masindir', 5, 5, 5, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-08-31T06:42:17.9119613' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (6, 2, N'yaxshi idi', 4, 3, 5, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-08-31T07:10:05.9607742' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (7, 5, N'Kollektivle seyahet uchun eladir', 5, 5, 5, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-08-31T07:12:19.7044984' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (8, 7, N'Coxda rahat mashin deyil', 3, 4, 3, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-08-31T07:13:32.5427260' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (9, 12, N'Mashini goturerken yanacagi full deyildi', 4, 3, 4, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-08-31T07:17:05.5160730' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (10, 3, N'salam', 5, 5, 5, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-08-31T09:07:56.2530899' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (11, 10, N'', 5, 4, 5, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-09-05T19:37:45.0045485' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (12, 10, N'', 5, 4, 4, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-09-05T19:45:43.5918755' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1011, 3, N'Mashin cox narahatdir', 3, 4, 3, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-09-06T06:03:45.8202784' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1012, 3, N'', 4, 5, 4, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-09-06T10:09:29.4618052' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1013, 2, N'', 4, 5, 4, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-09-06T12:17:41.4352790' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1014, 2, N'Perfect', 5, 5, 5, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-09-06T12:46:18.7162321' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1015, 3, N'Perfect', 5, 5, 5, N'bf006de6-6587-41b0-a9b7-9c5e5d1232c4', CAST(N'2023-09-06T12:51:52.4153682' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1020, 6, N'Perfect', 5, 5, 3, N'b0563f89-f92f-41ac-ade8-9aaec63cec03', CAST(N'2023-09-09T14:49:33.6094174' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1021, 4, N'', 4, 3, 4, N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', CAST(N'2023-09-10T21:17:18.7314073' AS DateTime2))
GO
INSERT [dbo].[Reviews] ([Id], [CarId], [Comment], [CleannesPoint], [PersonelPoint], [SpeedPoint], [UserId], [CreateDate]) VALUES (1022, 9, N'', 4, 5, 4, N'bbce8ca7-20f1-4d8c-985d-48155849dfa7', CAST(N'2023-09-11T14:52:49.3328476' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
SET IDENTITY_INSERT [dbo].[Types] ON 
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (1, N'Comfort')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (2, N'Compact')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (3, N'Economic')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (4, N'Luxury')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (5, N'Fullsize Elite')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (6, N'Intermediate')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (7, N'Intermediate Elite')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (8, N'Large Elite')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (9, N'Standart')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (10, N'Van')
GO
INSERT [dbo].[Types] ([Id], [Name]) VALUES (11, N'SUV')
GO
SET IDENTITY_INSERT [dbo].[Types] OFF
GO
/****** Object:  Index [IX_AboutCities_CityId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_AboutCities_CityId] ON [dbo].[AboutCities]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cars_ModelId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cars_ModelId] ON [dbo].[Cars]
(
	[ModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cars_OfficeId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cars_OfficeId] ON [dbo].[Cars]
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cars_TypeId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cars_TypeId] ON [dbo].[Cars]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cities_CountryId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cities_CountryId] ON [dbo].[Cities]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Model_BrandId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Model_BrandId] ON [dbo].[Model]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Offices_CityId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Offices_CityId] ON [dbo].[Offices]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rents_CarId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rents_CarId] ON [dbo].[Rents]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Rents_UserId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rents_UserId] ON [dbo].[Rents]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_CarId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_CarId] ON [dbo].[Reviews]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Reviews_UserId]    Script Date: 9/11/2023 8:13:43 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_UserId] ON [dbo].[Reviews]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (N'') FOR [ImageName]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [TypeId]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [OfficeId]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [ModelId]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [MinDriverLisanseYear]
GO
ALTER TABLE [dbo].[Cities] ADD  DEFAULT ((0)) FOR [CountryId]
GO
ALTER TABLE [dbo].[Model] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Offices] ADD  DEFAULT ((0)) FOR [CityId]
GO
ALTER TABLE [dbo].[Offices] ADD  DEFAULT (N'') FOR [Address]
GO
ALTER TABLE [dbo].[Offices] ADD  DEFAULT (N'') FOR [OpenTimes]
GO
ALTER TABLE [dbo].[Offices] ADD  DEFAULT (N'') FOR [Phone]
GO
ALTER TABLE [dbo].[Rents] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreateDate]
GO
ALTER TABLE [dbo].[Reviews] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreateDate]
GO
ALTER TABLE [dbo].[AboutCities]  WITH CHECK ADD  CONSTRAINT [FK_AboutCities_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AboutCities] CHECK CONSTRAINT [FK_AboutCities_Cities_CityId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Model_ModelId] FOREIGN KEY([ModelId])
REFERENCES [dbo].[Model] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Model_ModelId]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Offices_OfficeId] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Offices_OfficeId]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Types_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Types] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Types_TypeId]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries_CountryId]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Brands_BrandId]
GO
ALTER TABLE [dbo].[Offices]  WITH CHECK ADD  CONSTRAINT [FK_Offices_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Offices] CHECK CONSTRAINT [FK_Offices_Cities_CityId]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Cars_CarId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Cars_CarId]
GO
USE [master]
GO
ALTER DATABASE [Yolcu360] SET  READ_WRITE 
GO
