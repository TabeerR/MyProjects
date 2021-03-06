USE [master]
GO
/****** Object:  Database [OOP_ERP]    Script Date: 11/05/2019 11:34:44 ******/
CREATE DATABASE [OOP_ERP] ON  PRIMARY 
( NAME = N'OOP_ERP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OOP_ERP.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OOP_ERP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OOP_ERP_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OOP_ERP] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OOP_ERP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OOP_ERP] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OOP_ERP] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OOP_ERP] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OOP_ERP] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OOP_ERP] SET ARITHABORT OFF
GO
ALTER DATABASE [OOP_ERP] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [OOP_ERP] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OOP_ERP] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OOP_ERP] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OOP_ERP] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OOP_ERP] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OOP_ERP] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OOP_ERP] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OOP_ERP] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OOP_ERP] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OOP_ERP] SET  ENABLE_BROKER
GO
ALTER DATABASE [OOP_ERP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OOP_ERP] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OOP_ERP] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OOP_ERP] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OOP_ERP] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OOP_ERP] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OOP_ERP] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OOP_ERP] SET  READ_WRITE
GO
ALTER DATABASE [OOP_ERP] SET RECOVERY FULL
GO
ALTER DATABASE [OOP_ERP] SET  MULTI_USER
GO
ALTER DATABASE [OOP_ERP] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OOP_ERP] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'OOP_ERP', N'ON'
GO
USE [OOP_ERP]
GO
/****** Object:  Table [dbo].[VendorMaster]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VendorMaster](
	[VendorId] [int] NULL,
	[VendorName] [varchar](20) NULL,
	[VendorAdress] [varchar](20) NULL,
	[NTNCode] [int] NULL,
	[VendorPayTerm] [varchar](20) NULL,
	[ContactPerson] [varchar](20) NULL,
	[ContactNumber] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VacancyUpdates]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VacancyUpdates](
	[Vac_id] [int] NULL,
	[CandidiateId] [int] NULL,
	[InternalTest] [varchar](20) NULL,
	[Status] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacancy]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacancy](
	[Vac_id] [int] NULL,
	[Vacancy] [varchar](20) NULL,
	[Department] [varchar](20) NULL,
	[Positions] [int] NULL,
	[Experience] [int] NULL,
	[Qualification] [varchar](20) NULL,
	[DatePosted] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SelectionStatus]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SelectionStatus](
	[Vac_id] [int] NULL,
	[CandidiateId] [int] NULL,
	[EmployeeID] [int] NULL,
	[Department] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalaryEntity]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalaryEntity](
	[SalaryId] [int] NULL,
	[Sal_Emp] [varchar](20) NULL,
	[Sal_Amount] [int] NULL,
	[Sal_type] [varchar](20) NULL,
	[Details] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RFQRep]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RFQRep](
	[Q_Id] [int] NULL,
	[ProductID] [int] NULL,
	[VendorName] [int] NULL,
	[Quantity] [int] NULL,
	[Rate] [int] NULL,
	[DateGenerated] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RFQ]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RFQ](
	[Q_id] [int] NULL,
	[productID] [int] NULL,
	[Quantity] [int] NULL,
	[R_date] [date] NULL,
	[Assignby] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Q_Response]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Q_Response](
	[Q_id] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[R_Date] [date] NULL,
	[Vendor] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PO]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PO](
	[PO_id] [int] NULL,
	[ProdutName] [varchar](20) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[VendorName] [int] NULL,
	[VendorContact] [int] NULL,
	[DelDate] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PayrollEntity]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PayrollEntity](
	[PayrollId] [int] NULL,
	[Pay_Emp] [varchar](20) NULL,
	[payroll_title] [varchar](20) NULL,
	[payroll_type] [varchar](20) NULL,
	[Details] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderProcessing]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderProcessing](
	[Ord_id] [int] NULL,
	[Ord_Customer] [varchar](20) NULL,
	[Ord_type] [varchar](20) NULL,
	[Ord_quatity] [int] NULL,
	[OrdDate] [date] NULL,
	[ProductId] [int] NULL,
	[ProdPrice] [int] NULL,
	[TotalAmt] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaterialMaster]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaterialMaster](
	[M_Id] [int] NULL,
	[M_Name] [varchar](20) NULL,
	[M_Quantity] [int] NULL,
	[StorageLoc] [varchar](30) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoices](
	[Inv_Id] [int] NULL,
	[VendorName] [varchar](20) NULL,
	[InvoiceNum] [int] NULL,
	[PostingDate] [date] NULL,
	[Amount] [int] NULL,
	[TaxDeducted] [int] NULL,
	[InvStatus] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hiring]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hiring](
	[Emp_id] [int] NULL,
	[Emp_Name] [varchar](20) NULL,
	[Gender] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[Qualification] [varchar](20) NULL,
	[salary] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeMaster](
	[EmployeeID] [int] NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[DOB] [date] NULL,
	[CNIC] [bigint] NULL,
	[Addres] [varchar](20) NULL,
	[ContactNum] [int] NULL,
	[Email] [varchar](20) NULL,
	[Department] [varchar](20) NULL,
	[JoiningDate] [date] NULL,
	[Details] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Delivery](
	[TrackingId] [int] NULL,
	[Rel_Status] [varchar](20) NULL,
	[Cancellation_staus] [varchar](20) NULL,
	[Consistancy_status] [varchar](20) NULL,
	[Delivery_Type] [varchar](20) NULL,
	[Shipping_party] [varchar](20) NULL,
	[Shipping_Name] [varchar](20) NULL,
	[Shipping_addres] [varchar](20) NULL,
	[Sender_Party] [varchar](20) NULL,
	[Sender_Addres] [varchar](20) NULL,
	[Shipment_Date] [date] NULL,
	[delivery_Date] [date] NULL,
	[Organization] [varchar](20) NULL,
	[Gross_weight] [int] NULL,
	[Gross_Volume] [int] NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedOn] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerMaster]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerMaster](
	[C_Id] [int] NULL,
	[C_Name] [varchar](20) NULL,
	[C_phone] [int] NULL,
	[C_Address] [varchar](40) NULL,
	[C_PayTerms] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BlockInvoices]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BlockInvoices](
	[Inv_Id] [int] NULL,
	[VendorName] [varchar](20) NULL,
	[InvoiceNum] [int] NULL,
	[PostingDate] [date] NULL,
	[DateBlock] [date] NULL,
	[Details] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Billing]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Billing](
	[ProductID] [int] NULL,
	[ProdutPrice] [int] NULL,
	[Location] [varchar](20) NULL,
	[Del_Charges] [int] NULL,
	[Subtotal] [int] NULL,
	[Tax] [int] NULL,
	[Total] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 11/05/2019 11:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Attendance](
	[EmpId] [int] NULL,
	[EmpName] [varchar](20) NULL,
	[EmpContact] [int] NULL,
	[Email] [varchar](20) NULL,
	[Addres] [varchar](20) NULL,
	[Timing] [time](7) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
