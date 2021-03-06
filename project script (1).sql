USE [master]
GO
/****** Object:  Database [Star_Lounge]    Script Date: 11/26/2020 6:45:59 AM ******/
CREATE DATABASE [Star_Lounge]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Star_Lounge', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Star_Lounge.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Star_Lounge_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Star_Lounge_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Star_Lounge] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Star_Lounge].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Star_Lounge] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Star_Lounge] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Star_Lounge] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Star_Lounge] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Star_Lounge] SET ARITHABORT OFF 
GO
ALTER DATABASE [Star_Lounge] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Star_Lounge] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Star_Lounge] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Star_Lounge] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Star_Lounge] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Star_Lounge] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Star_Lounge] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Star_Lounge] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Star_Lounge] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Star_Lounge] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Star_Lounge] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Star_Lounge] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Star_Lounge] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Star_Lounge] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Star_Lounge] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Star_Lounge] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Star_Lounge] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Star_Lounge] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Star_Lounge] SET RECOVERY FULL 
GO
ALTER DATABASE [Star_Lounge] SET  MULTI_USER 
GO
ALTER DATABASE [Star_Lounge] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Star_Lounge] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Star_Lounge] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Star_Lounge] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Star_Lounge', N'ON'
GO
USE [Star_Lounge]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetOrder]    Script Date: 11/26/2020 6:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_GetOrder]
AS
BEGIN
	 Select tOrdrHere.orderid,tOrdrHere.coffeetype,tOrdrHere.category,tOrdrHere.quantity, tAddCofe.netprice  from tbl_AddCoffee tAddCofe inner join tbl_OrderHere tOrdrHere on tAddCofe.coffeename = tOrdrHere.coffeetype
END
GO
/****** Object:  Table [dbo].[tbl_AddCoffee]    Script Date: 11/26/2020 6:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_AddCoffee](
	[coffeeid] [int] IDENTITY(1,1) NOT NULL,
	[coffeename] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
	[netprice] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_AddCoffee] PRIMARY KEY CLUSTERED 
(
	[coffeeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_billing]    Script Date: 11/26/2020 6:46:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_billing](
	[billingid] [int] IDENTITY(1,1) NOT NULL,
	[selectcoffeedrink] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
	[netprice] [varchar](50) NULL,
	[discount] [varchar](50) NULL,
	[finalamount] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[totalamount] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_billing] PRIMARY KEY CLUSTERED 
(
	[billingid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_OrderHere]    Script Date: 11/26/2020 6:46:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_OrderHere](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[coffeetype] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_OrderHere] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Star_Lounge] SET  READ_WRITE 
GO
