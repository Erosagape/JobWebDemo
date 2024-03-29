USE [master]
GO
/****** Object:  Database [JOB_WEB]    Script Date: 17/05/2019 13:56:27 ******/
CREATE DATABASE [JOB_WEB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JOB_WEB', FILENAME = N'D:\DB\JOB_WEB.MDF' , SIZE = 48128KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JOB_WEB_log', FILENAME = N'D:\DB\JOB_WEB_log.LDF' , SIZE = 24384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JOB_WEB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JOB_WEB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JOB_WEB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JOB_WEB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JOB_WEB] SET ARITHABORT OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JOB_WEB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JOB_WEB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JOB_WEB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JOB_WEB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JOB_WEB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JOB_WEB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JOB_WEB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JOB_WEB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JOB_WEB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JOB_WEB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JOB_WEB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JOB_WEB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JOB_WEB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JOB_WEB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JOB_WEB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JOB_WEB] SET  MULTI_USER 
GO
ALTER DATABASE [JOB_WEB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JOB_WEB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JOB_WEB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JOB_WEB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [JOB_WEB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [JOB_WEB]
GO
/****** Object:  UserDefinedFunction [dbo].[GetJobStatus]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[GetJobStatus]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN
	DECLARE @stsname varchar(50)
	IF @jobsts='99' 
		SET @stsname='CANCEL'
	else IF @jobsts='6' 
		SET @stsname='COMPLETE'
	else IF @jobsts='5'
		SET @stsname='FULL-BILL'
	else IF @jobsts='4'
		SET @stsname='PART-BILL'
	else IF @jobsts='3'
		SET @stsname='CLOSE'		
	else IF @jobsts='2'
		SET @stsname='PROCESS'		
	else 
		SET @stsname='OPEN';
		
	RETURN @stsname
END 


GO
/****** Object:  UserDefinedFunction [dbo].[GetJobType]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetJobType]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN
	DECLARE @stsname varchar(50)
	IF @jobsts='1' 
		SET @stsname='IMPORT'
	else IF @jobsts='2' 
		SET @stsname='EXPORT'
	else IF @jobsts='3'
		SET @stsname='TRANSPORT'
	else IF @jobsts='4'
		SET @stsname='CO FORM'
	else IF @jobsts='5'
		SET @stsname='GENERAL'		
	else IF @jobsts='6'
		SET @stsname='DOCUMENT'		
	else 
		SET @stsname='OTHERS';
		
	RETURN @stsname
END 











GO
/****** Object:  UserDefinedFunction [dbo].[GetShipBy]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetShipBy]
(
@jobsts varchar(20)
)
RETURNS varchar(50)
AS 
BEGIN

	DECLARE @stsname varchar(50)
	IF @jobsts='1' 
		SET @stsname='AIR'
	else IF @jobsts='2' 
		SET @stsname='SEA'
	else IF @jobsts='3'
		SET @stsname='TRAIN'
	else IF @jobsts='4'
		SET @stsname='TRUCK'
	else IF @jobsts='5'
		SET @stsname='GENERAL'		
	else IF @jobsts='6'
		SET @stsname='PASSENGER'		
	else IF @jobsts='7'
		SET @stsname='FREIGHT'
	else IF @jobsts='8'
		SET @stsname='LCB'						
	else IF @jobsts='9'
		SET @stsname='BOI'			
	else IF @jobsts='10'
		SET @stsname='RE EXPORT'				
	else IF @jobsts='11'
		SET @stsname='FORMULA'				
	else IF @jobsts='12'
		SET @stsname='ENTER 19 BIS'
	else IF @jobsts='13'
		SET @stsname='LOCAL'								
	else IF @jobsts='14'
		SET @stsname='TAX-RETURN'
	else IF @jobsts='15'
		SET @stsname='FORM-A'																			
	else IF @jobsts='16'
		SET @stsname='FORM-D'
	else IF @jobsts='17'
		SET @stsname='FORM-E'	
	else IF @jobsts='18'
		SET @stsname='FORM-CO'
	else IF @jobsts='19'
		SET @stsname='CHAMBER'							
	else IF @jobsts='20'
		SET @stsname='FORM-AI'
	else IF @jobsts='21'
		SET @stsname='FORM-AK'
	else IF @jobsts='22'
		SET @stsname='TEXTTILE'
	else IF @jobsts='23'
		SET @stsname='THAI-AUS'								
	else IF @jobsts='24'
		SET @stsname='JTEPA'
	else IF @jobsts='25'
		SET @stsname='MEXICO'
	else IF @jobsts='26'
		SET @stsname='ANNZ'
	else IF @jobsts='27'
		SET @stsname='REGISTER'
	else IF @jobsts='28'
		SET @stsname='BANKING'
	else IF @jobsts='29'
		SET @stsname='LEGALIZE'
	else IF @jobsts='30'
		SET @stsname='INSURANCE'
	else IF @jobsts='31'
		SET @stsname='COURIER'
	else IF @jobsts='32'
		SET @stsname='MARKETING'
	else IF @jobsts='33'
		SET @stsname='FREIGHT'
	else IF @jobsts='34'
		SET @stsname='DOCUMENT'
	else IF @jobsts='35'
		SET @stsname='WAREHOUSE'
	else IF @jobsts='36'
		SET @stsname='CONSIGNMENT'
	else IF @jobsts='37'
		SET @stsname='SUPPPLY-CHAIN'
	else IF @jobsts='38'
		SET @stsname='MILK-RUN'
	else IF @jobsts='39'
		SET @stsname='CUSTOMER-SERVICE'
	else 
		SET @stsname='OTHERS';
		
	RETURN @stsname
END 







GO
/****** Object:  UserDefinedFunction [dbo].[GetUserName]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUserName]
(
@CSCode varchar(30)
)
RETURNS varchar(255)
AS
BEGIN
	DECLARE @username varchar(255)
	
	SELECT @username=TName from Mas_User where UserID=@CSCode
	
	RETURN @username
		
END


GO
/****** Object:  Table [dbo].[BankCode]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BankCode](
	[BankCode] [varchar](50) NOT NULL,
	[BankName] [nvarchar](2000) NULL,
	[BankBranch] [nvarchar](2000) NULL,
	[BankForm] [nvarchar](2000) NULL,
 CONSTRAINT [PK_BankCode] PRIMARY KEY CLUSTERED 
(
	[BankCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChequeDetail]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChequeDetail](
	[BankID] [varchar](50) NOT NULL,
	[ChequeNo] [varchar](50) NOT NULL,
	[Seq] [int] NOT NULL,
	[JobNo] [varchar](50) NULL,
	[Expense] [nvarchar](2000) NULL,
	[Amount] [float] NULL,
	[VoucherNo] [varchar](50) NULL,
 CONSTRAINT [PK_ChequeDetail] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC,
	[ChequeNo] ASC,
	[Seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChequeHeader]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChequeHeader](
	[BankID] [varchar](50) NOT NULL,
	[ChequeNo] [varchar](50) NOT NULL,
	[ChequeType] [varchar](50) NULL,
	[ChequeDate] [date] NULL,
	[IssueDate] [date] NULL,
	[IssueBy] [varchar](50) NULL,
	[CustCode] [varchar](50) NULL,
	[PayTo] [nvarchar](2000) NULL,
	[Total] [float] NULL,
	[ChequeStatus] [varchar](50) NULL,
	[BookNo] [varchar](50) NULL,
	[HaveSquare] [varchar](50) NULL,
	[Payee] [varchar](50) NULL,
	[HaveLine] [varchar](50) NULL,
	[Remark] [nvarchar](2000) NULL,
	[Printed] [varchar](50) NULL,
 CONSTRAINT [PK_ChequeHeader] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC,
	[ChequeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChequeType]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChequeType](
	[ChequeType] [varchar](50) NOT NULL,
	[ChequeTypeDesc] [nvarchar](2000) NULL,
 CONSTRAINT [PK_ChequeType] PRIMARY KEY CLUSTERED 
(
	[ChequeType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_AdvDetail]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_AdvDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[AdvNo] [varchar](15) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[STCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[AdvAmount] [float] NULL,
	[IsChargeVAT] [tinyint] NULL,
	[ChargeVAT] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[Charge50Tavi] [float] NULL,
	[TRemark] [varchar](100) NULL,
	[IsDuplicate] [tinyint] NULL,
	[PayChqTo] [varchar](100) NULL,
	[Doc50Tavi] [varchar](10) NULL,
	[Is50Tavi] [tinyint] NULL,
	[VATRate] [float] NULL,
	[AdvNet] [float] NULL,
	[SDescription] [varchar](100) NULL,
	[ForJNo] [varchar](15) NULL,
	[VenCode] [varchar](50) NULL,
	[CurrencyCode] [varchar](12) NULL,
	[ExchangeRate] [float] NOT NULL,
	[AdvQty] [float] NOT NULL,
	[UnitPrice] [float] NOT NULL,
 CONSTRAINT [pk_adv_d] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[AdvNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_AdvHeader]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_AdvHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[AdvNo] [varchar](15) NOT NULL,
	[JobType] [tinyint] NULL,
	[AdvDate] [datetime] NULL,
	[AdvType] [tinyint] NULL,
	[EmpCode] [varchar](10) NULL,
	[JNo] [varchar](15) NULL,
	[InvNo] [varchar](100) NULL,
	[DocStatus] [tinyint] NULL,
	[VATRate] [int] NULL,
	[TotalAdvance] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TRemark] [varchar](250) NULL,
	[ApproveBy] [varchar](10) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[PaymentBy] [varchar](10) NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentTime] [datetime] NULL,
	[PaymentRef] [varchar](20) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[AdvCash] [float] NULL,
	[AdvChqCash] [float] NULL,
	[AdvChq] [float] NULL,
	[AdvCred] [float] NULL,
	[PayChqTo] [varchar](100) NULL,
	[PayChqDate] [datetime] NULL,
	[Doc50Tavi] [varchar](15) NULL,
	[AdvBy] [varchar](10) NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[ShipBy] [tinyint] NULL,
	[PaymentNo] [varchar](20) NULL,
	[MainCurrency] [varchar](12) NULL,
	[SubCurrency] [varchar](12) NULL,
	[ExchangeRate] [float] NOT NULL,
 CONSTRAINT [pk_adv_h] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[AdvNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_AdvMJob]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_AdvMJob](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[AdvNO] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[AdvDate] [datetime] NULL,
	[CSCode] [varchar](10) NULL,
	[TotalDuty] [float] NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](100) NULL,
	[IsDuplicate] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillAcceptDetail]    Script Date: 17/05/2019 13:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillAcceptDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[BillAcceptNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[InvNo] [varchar](50) NULL,
	[AmtAdvance] [float] NULL,
	[AmtChargeNonVAT] [float] NULL,
	[AmtChargeVAT] [float] NULL,
	[AmtWH] [float] NULL,
	[AmtVAT] [float] NULL,
	[AmtTotal] [float] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
 CONSTRAINT [PK_BillAcceptD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillAcceptHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillAcceptHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[BillAcceptNo] [varchar](15) NOT NULL,
	[BillDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillRecvBy] [varchar](30) NULL,
	[BillRecvDate] [datetime] NULL,
	[DuePaymentDate] [datetime] NULL,
	[BillRemark] [varchar](255) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
 CONSTRAINT [PK_BillAcceptH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillAnn]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillAnn](
	[BranchCode] [varchar](3) NULL,
	[DocNO] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[RecvBy] [varchar](30) NULL,
	[RecvDate] [datetime] NULL,
	[PaymentDate] [datetime] NULL,
	[TRemark] [varchar](255) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillAnnSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillAnnSub](
	[BranchCode] [varchar](3) NULL,
	[DocNO] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[BillNo] [varchar](50) NULL,
	[AmtAdvance] [float] NULL,
	[AmtChargeNoVAT] [float] NULL,
	[AmtChargeVAT] [float] NULL,
	[AmtWH1] [float] NULL,
	[AmtWH3] [float] NULL,
	[AmtVAT] [float] NULL,
	[AmtTotal] [float] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptNo] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillingDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillingDetail](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[ExpSlipNO] [varchar](100) NULL,
	[SRemark] [varchar](100) NULL,
	[QtyUnit] [varchar](30) NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NOT NULL,
	[CurrencyCodeCredit] [varchar](50) NULL,
	[ExchangeRateCredit] [float] NOT NULL,
	[ForeignAmtCredit] [float] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[ForeignDisc] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[FQty] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillingHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BillingHeader](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[JobNo] [varchar](3000) NULL,
	[JobBillAmt] [tinyint] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[ContactName] [varchar](100) NULL,
	[EmpCode] [varchar](10) NULL,
	[PrintedBy] [varchar](10) NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) NULL,
	[VATRate] [float] NULL,
	[Tavi50Rate1] [float] NULL,
	[Tavi50Rate2] [float] NULL,
	[TaxInvNo] [varchar](15) NULL,
	[TaxInvDate] [datetime] NULL,
	[TotalAdvance] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalIsTaxCharge] [float] NULL,
	[TotalIs50Tavi1] [float] NULL,
	[TotalIs50Tavi2] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi1] [float] NULL,
	[Total50Tavi2] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[TotalNet] [float] NULL,
	[BillDate] [datetime] NULL,
	[BillTime] [datetime] NULL,
	[BillAcceptNo] [varchar](15) NULL,
	[PayDate] [datetime] NULL,
	[PayTime] [datetime] NULL,
	[Remark1] [varchar](max) NULL,
	[Remark2] [varchar](max) NULL,
	[Remark3] [varchar](max) NULL,
	[Remark4] [varchar](max) NULL,
	[Remark5] [varchar](max) NULL,
	[Remark6] [varchar](max) NULL,
	[Remark7] [varchar](max) NULL,
	[Remark8] [varchar](max) NULL,
	[Remark9] [varchar](max) NULL,
	[Remark10] [varchar](max) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[PaidFlag] [tinyint] NULL,
	[ShippingRemark] [varchar](50) NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[QuatationNo] [varchar](15) NULL,
	[Revise] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BudgetPolicy]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_BudgetPolicy](
	[ID] [int] NOT NULL,
	[BranchCode] [varchar](5) NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[MaxAdvance] [float] NULL,
	[MaxCost] [float] NULL,
	[MinCharge] [float] NULL,
	[MinProfit] [float] NULL,
	[Active] [varchar](5) NULL,
	[LastUpdate] [datetime] NULL,
	[UpdateBy] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CashControl]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CashControl](
	[BranchCode] [varchar](3) NOT NULL,
	[ControlNo] [varchar](15) NOT NULL,
	[VoucherDate] [datetime] NULL,
	[TRemark] [varchar](100) NULL,
	[RecUser] [varchar](10) NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL,
	[PostedBy] [varchar](10) NULL,
	[PostedDate] [datetime] NULL,
	[PostedTime] [datetime] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
 CONSTRAINT [PK_CashControl] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CashControlDoc]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CashControlDoc](
	[BranchCode] [varchar](3) NOT NULL,
	[ControlNo] [varchar](15) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[DocType] [varchar](5) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[CmpType] [varchar](1) NULL,
	[CmpCode] [varchar](15) NULL,
	[CmpBranch] [varchar](4) NULL,
	[PaidAmount] [float] NULL,
	[TotalAmount] [float] NULL,
	[acType] [varchar](15) NULL,
 CONSTRAINT [PK_CashControldoc] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CashControlSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CashControlSub](
	[BranchCode] [varchar](3) NOT NULL,
	[ControlNo] [varchar](15) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[PRVoucher] [varchar](20) NULL,
	[PRType] [varchar](1) NULL,
	[ChqNo] [varchar](20) NULL,
	[BookCode] [varchar](15) NULL,
	[BankCode] [varchar](10) NULL,
	[BankBranch] [varchar](50) NULL,
	[ChqDate] [datetime] NULL,
	[CashAmount] [float] NULL,
	[ChqAmount] [float] NULL,
	[CreditAmount] [float] NULL,
	[IsLocal] [tinyint] NULL,
	[ChqStatus] [varchar](1) NULL,
	[TRemark] [varchar](100) NULL,
	[PayChqTo] [varchar](100) NULL,
	[DocNo] [varchar](15) NULL,
	[SICode] [varchar](100) NULL,
	[RecvBank] [varchar](5) NULL,
	[RecvBranch] [varchar](50) NULL,
	[acType] [varchar](15) NULL,
	[SumAmount] [float] NULL,
	[CurrencyCode] [varchar](20) NULL,
	[ExchangeRate] [float] NULL,
	[TotalAmount] [float] NULL,
	[VatInc] [float] NULL,
	[VatExc] [float] NULL,
	[WhtInc] [float] NULL,
	[WhtExc] [float] NULL,
	[TotalNet] [float] NULL,
	[ForJNo] [varchar](15) NULL,
 CONSTRAINT [PK_CashControlSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ControlNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CashFlow]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CashFlow](
	[BranchCode] [varchar](5) NOT NULL,
	[RefNo] [varchar](20) NOT NULL,
	[AccType] [smallint] NOT NULL,
	[BankCode] [varchar](5) NOT NULL,
	[BookAcc] [varchar](15) NULL,
	[Remark] [varchar](100) NULL,
	[RecordDate] [datetime] NULL,
	[RecordBy] [varchar](10) NULL,
	[ChqNo] [varchar](50) NULL,
	[ChqDate] [datetime] NULL,
	[ChqPayTo] [varchar](255) NULL,
	[ChqBackNote] [varchar](255) NULL,
	[ChqAmount] [float] NULL,
	[ChqStatus] [int] NULL,
	[ClearDate] [datetime] NULL,
	[ChqDueDate] [datetime] NULL,
	[TransRefNo] [varchar](50) NULL,
	[TransDate] [datetime] NULL,
	[TransAmt] [float] NULL,
	[TransBy] [varchar](10) NULL,
	[TransBank] [varchar](5) NOT NULL,
	[TransBookAcc] [varchar](15) NULL,
	[SourceDocType] [varchar](10) NULL,
	[SourceDocNo] [varchar](15) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[BankCharge] [float] NULL,
	[IsWHT] [float] NULL,
	[WHTRate] [float] NULL,
	[WHTDocNo] [varchar](15) NULL,
	[WHTAmt] [float] NULL,
	[TotalAmt] [float] NULL,
	[IsVat] [float] NULL,
	[VatRate] [float] NULL,
	[TotalVat] [float] NULL,
	[TotalNet] [float] NULL,
	[SlipNo] [varchar](15) NULL,
	[SlipDate] [datetime] NULL,
	[ApproveBy] [varchar](50) NULL,
	[ApproveDate] [datetime] NULL,
	[PrintDate] [datetime] NULL,
	[PrintBy] [varchar](50) NULL,
	[CancelBy] [varchar](50) NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) NULL,
	[PostBy] [varchar](50) NULL,
	[PostDate] [datetime] NULL,
	[ControlNo] [varchar](50) NULL,
	[VoucherNo] [varchar](50) NULL,
	[VoucherItemNo] [int] NULL,
	[GLAccountCode] [varchar](15) NULL,
	[DebitAmt] [float] NULL,
	[CreditAmt] [float] NULL,
 CONSTRAINT [PK_Job_CashFlow] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ClearDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ClearDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[ClrNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[LinkItem] [smallint] NULL,
	[STCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[VenderCode] [varchar](10) NULL,
	[Qty] [float] NULL,
	[UnitCode] [varchar](10) NULL,
	[CurrencyCode] [varchar](3) NULL,
	[CurRate] [float] NULL,
	[UnitPrice] [float] NULL,
	[FPrice] [float] NULL,
	[BPrice] [float] NULL,
	[QUnitPrice] [float] NULL,
	[QFPrice] [float] NULL,
	[QBPrice] [float] NULL,
	[UnitCost] [float] NULL,
	[FCost] [float] NULL,
	[BCost] [float] NULL,
	[ChargeVAT] [float] NULL,
	[Tax50Tavi] [float] NULL,
	[AdvNO] [varchar](15) NULL,
	[AdvAmount] [float] NULL,
	[UsedAmount] [float] NULL,
	[IsQuoItem] [tinyint] NULL,
	[SlipNO] [varchar](50) NULL,
	[Remark] [varchar](100) NULL,
	[IsDuplicate] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[Pay50TaviTo] [nvarchar](255) NULL,
	[NO50Tavi] [varchar](10) NULL,
	[Date50Tavi] [datetime] NULL,
	[VenderBillingNo] [varchar](15) NULL,
	[AirQtyStep] [varchar](100) NULL,
	[StepSub] [varchar](4000) NULL,
	[JobNo] [varchar](15) NULL,
	[AdvItemNo] [smallint] NULL,
	[LinkBillNo] [varchar](50) NULL,
	[VATType] [smallint] NULL,
	[VATRate] [float] NULL,
	[Tax50TaviRate] [float] NULL,
	[QNo] [varchar](15) NULL,
	[FNet] [float] NOT NULL,
	[BNet] [float] NOT NULL,
 CONSTRAINT [pK_ClearDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ClrNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ClearExp]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ClearExp](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[AmountCharge] [float] NULL,
	[Status] [varchar](5) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ClearHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ClearHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[ClrNo] [varchar](15) NOT NULL,
	[ClrDate] [datetime] NULL,
	[ClearanceDate] [datetime] NULL,
	[EmpCode] [varchar](10) NULL,
	[AdvRefNo] [varchar](255) NULL,
	[AdvTotal] [float] NULL,
	[JobType] [tinyint] NULL,
	[JNo] [varchar](15) NULL,
	[InvNo] [varchar](100) NULL,
	[ClearType] [tinyint] NULL,
	[ClearFrom] [tinyint] NULL,
	[DocStatus] [tinyint] NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](250) NULL,
	[ApproveBy] [varchar](10) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](20) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CoPersonCode] [varchar](15) NULL,
	[CTN_NO] [varchar](15) NULL,
	[ClearTotal] [float] NULL,
	[ClearVat] [float] NOT NULL,
	[ClearWht] [float] NOT NULL,
	[ClearNet] [float] NOT NULL,
	[ClearBill] [float] NOT NULL,
	[ClearCost] [float] NOT NULL,
 CONSTRAINT [PK_ClearHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ClrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ClearMJob]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ClearMJob](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[ClrNO] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[ClrDate] [datetime] NULL,
	[CSCode] [varchar](10) NULL,
	[TotalExpense] [float] NULL,
	[TRemark] [varchar](100) NULL,
	[IsDuplicate] [tinyint] NULL,
	[SICode] [varchar](10) NULL,
	[SlipNo] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CNDNDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CNDNDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[BillingNo] [varchar](15) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[OriginalAmt] [float] NULL,
	[CorrectAmt] [float] NULL,
	[DiffAmt] [float] NULL,
	[IsTaxCharge] [int] NULL,
	[VATRate] [float] NULL,
	[VATAmt] [float] NULL,
	[TotalNet] [float] NULL,
	[CurrencyCode] [varchar](3) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignNet] [float] NULL,
 CONSTRAINT [PK_CNDNDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CNDNHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CNDNHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[DocType] [smallint] NULL,
	[CustCode] [varchar](15) NOT NULL,
	[CustBranch] [varchar](5) NOT NULL,
	[DocDate] [datetime] NULL,
	[EmpCode] [varchar](10) NULL,
	[ApproveBy] [varchar](110) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[UpdateBy] [varchar](110) NULL,
	[LastupDate] [datetime] NULL,
	[DocStatus] [int] NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) NULL,
	[Remark] [varchar](255) NULL,
 CONSTRAINT [PK_CNDN] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Controls]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Controls](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[SCID] [varchar](10) NULL,
	[EmpCode] [varchar](10) NULL,
	[BDate] [datetime] NULL,
	[BTime] [datetime] NULL,
	[NDate] [datetime] NULL,
	[NTime] [datetime] NULL,
	[ADate] [datetime] NULL,
	[AlertReson] [varchar](250) NULL,
	[UnLockBy] [varchar](10) NULL,
	[UnLockDate] [datetime] NULL,
	[UnLockTime] [datetime] NULL,
	[TRemark] [varchar](255) NULL,
	[DayStart] [tinyint] NULL,
	[DayStartDate] [datetime] NULL,
	[AmtDHoliday] [tinyint] NULL,
	[AmtDPeriod] [tinyint] NULL,
	[AmtDOverDue] [tinyint] NULL,
	[MaximumDay] [int] NULL,
	[Field1] [varchar](255) NULL,
	[Field2] [varchar](255) NULL,
	[Field3] [varchar](255) NULL,
	[Field4] [varchar](255) NULL,
	[Field5] [varchar](255) NULL,
	[Field6] [varchar](255) NULL,
	[Field7] [varchar](255) NULL,
	[Field8] [varchar](255) NULL,
	[Field9] [varchar](255) NULL,
	[Field10] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CoPersonSlip]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CoPersonSlip](
	[BranchCode] [varchar](3) NULL,
	[CoPersonCode] [varchar](15) NULL,
	[DocNO] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[AmtTotal] [float] NULL,
	[AmtWH] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CoPersonSlipSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CoPersonSlipSub](
	[BranchCode] [varchar](3) NULL,
	[CoPersonCode] [varchar](15) NULL,
	[DocNO] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[AmtCharge] [float] NULL,
	[AmtWH] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CPolicyDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CPolicyDetail](
	[PolicyCode] [varchar](10) NULL,
	[ItemNo] [smallint] NULL,
	[SCID] [varchar](10) NULL,
	[SCDescription] [varchar](100) NULL,
	[MaximumDay] [smallint] NULL,
	[DayStart] [tinyint] NULL,
	[Field1] [varchar](255) NULL,
	[Field2] [varchar](255) NULL,
	[Field3] [varchar](255) NULL,
	[Field4] [varchar](255) NULL,
	[Field5] [varchar](255) NULL,
	[Field6] [varchar](255) NULL,
	[Field7] [varchar](255) NULL,
	[Field8] [varchar](255) NULL,
	[Field9] [varchar](255) NULL,
	[Field10] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CPolicyHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CPolicyHeader](
	[PolicyCode] [varchar](10) NULL,
	[PolicyName] [varchar](100) NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustAdvChq]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustAdvChq](
	[BranchCode] [varchar](3) NOT NULL,
	[RefNo] [varchar](20) NOT NULL,
	[BankCode] [varchar](5) NOT NULL,
	[ChqNo] [varchar](20) NOT NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[ChqDate] [datetime] NULL,
	[ChqAmount] [float] NULL,
	[TotalUsed] [float] NULL,
	[PayTo] [varchar](100) NULL,
	[Remark] [varchar](100) NULL,
	[RecordDate] [datetime] NULL,
	[RecordBy] [varchar](10) NULL,
	[DepBookAcc] [varchar](15) NULL,
	[DepDate] [datetime] NULL,
	[DepUser] [varchar](10) NULL,
	[ApproveBy] [varchar](50) NULL,
	[ApproveDate] [datetime] NULL,
	[CancelBy] [varchar](50) NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) NULL,
	[ClearBy] [varchar](50) NULL,
	[ClearDate] [datetime] NULL,
	[ControlNo] [varchar](50) NULL,
 CONSTRAINT [PK_Job_CustAdvChq] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustAdvChqDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustAdvChqDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[RefNo] [varchar](20) NOT NULL,
	[SeqNo] [int] NOT NULL,
	[JNo] [varchar](50) NOT NULL,
	[LinkItem] [int] NOT NULL,
	[BillingNo] [varchar](15) NULL,
	[SICode] [varchar](50) NOT NULL,
	[PayAmount] [float] NULL,
	[Remark] [varchar](100) NULL,
	[VoucherNo] [int] NULL,
 CONSTRAINT [PK_Job_CustAdvChqDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC,
	[SeqNo] ASC,
	[JNo] ASC,
	[LinkItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustAdvChqSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustAdvChqSub](
	[BranchCode] [varchar](5) NOT NULL,
	[RefNo] [varchar](20) NOT NULL,
	[SeqNo] [int] NOT NULL,
	[JNO] [varchar](50) NOT NULL,
	[BillFlag] [varchar](1) NULL,
	[BillingNo] [varchar](15) NOT NULL,
	[SICode] [varchar](100) NULL,
	[PayAmount] [float] NULL,
	[Remark] [varchar](100) NULL,
	[ClearingNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
 CONSTRAINT [PK_Job_CustAdvChqSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[RefNo] ASC,
	[SeqNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustAdvDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustAdvDetail](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[DocNo] [tinyint] NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[TotalExpense] [float] NULL,
	[PayTo] [varchar](100) NULL,
	[PaySlipNo] [varchar](50) NULL,
	[Remark] [varchar](255) NULL,
	[PaySlipDate] [datetime] NULL,
	[ReceiptDue] [datetime] NULL,
	[ReceiptNo] [varchar](50) NULL,
	[ReceiptDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustAdvHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustAdvHeader](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[DocNo] [tinyint] NULL,
	[DocDate] [datetime] NULL,
	[TotalAdvance] [float] NULL,
	[RefNO] [varchar](15) NULL,
	[AdvNo] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_CustExp]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_CustExp](
	[Custcode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[AmountCharge] [float] NULL,
	[Status] [varchar](5) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_DebitNote]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_DebitNote](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[InvNo] [varchar](15) NULL,
	[EmpCode] [varchar](10) NULL,
	[ApproveBy] [varchar](110) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[Remark] [varchar](255) NULL,
	[VatRate] [float] NULL,
	[VatAmt] [float] NULL,
	[TotalNet] [float] NULL,
	[VatInclude] [smallint] NULL,
	[IsCreditNote] [smallint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_DebitNoteSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_DebitNoteSub](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[ItemNo] [int] NULL,
	[BillingNo] [varchar](15) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[OriginalAmt] [float] NULL,
	[CorrectAmt] [float] NULL,
	[DiffAmt] [float] NULL,
	[CurrencyCode] [varchar](3) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Delivery]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Delivery](
	[JobNo] [varchar](50) NOT NULL,
	[Seq] [int] NOT NULL,
	[DeliverTo] [varchar](50) NULL,
	[DeliverAddr] [varchar](500) NULL,
 CONSTRAINT [PK_Job_Delivery] PRIMARY KEY CLUSTERED 
(
	[JobNo] ASC,
	[Seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Detail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Detail](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[LinkItem] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[STCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[SRemark] [varchar](250) NULL,
	[VenderCode] [varchar](10) NULL,
	[VenderContact] [varchar](100) NULL,
	[EmpCode] [varchar](10) NULL,
	[Start] [varchar](5) NULL,
	[CY] [varchar](5) NULL,
	[Endding] [varchar](5) NULL,
	[DNNo] [varchar](15) NULL,
	[PdtType] [varchar](5) NULL,
	[Qty] [float] NULL,
	[UnitCode] [varchar](10) NULL,
	[CurrencyCode] [varchar](3) NULL,
	[CurRate] [float] NULL,
	[UnitPrice] [float] NULL,
	[FPrice] [float] NULL,
	[BPrice] [float] NULL,
	[QUnitPrice] [float] NULL,
	[QFPrice] [float] NULL,
	[QBPrice] [float] NULL,
	[UnitCost] [float] NULL,
	[FCost] [float] NULL,
	[BCost] [float] NULL,
	[Tax50Tavi] [float] NULL,
	[BillExtn] [tinyint] NULL,
	[ChargeDate] [datetime] NULL,
	[IsQuoItem] [tinyint] NULL,
	[ProductName] [varchar](100) NULL,
	[ClearingNO] [varchar](15) NULL,
	[RSlipNO] [varchar](100) NULL,
	[AirQtyStep] [varchar](100) NULL,
	[StepSub] [varchar](4000) NULL,
	[PostFlag] [varchar](3) NULL,
	[PostStatus] [varchar](1) NULL,
	[PostErrMsg] [varchar](100) NULL,
	[LastestPostDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_DetailOption]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_DetailOption](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[Field1] [varchar](255) NULL,
	[Field2] [varchar](255) NULL,
	[Field3] [varchar](255) NULL,
	[Field4] [varchar](255) NULL,
	[Field5] [varchar](255) NULL,
	[Field6] [varchar](255) NULL,
	[Field7] [varchar](255) NULL,
	[Field8] [varchar](255) NULL,
	[Field9] [varchar](255) NULL,
	[Field10] [varchar](255) NULL,
	[Field11] [varchar](255) NULL,
	[Field12] [varchar](255) NULL,
	[Field13] [varchar](255) NULL,
	[Field14] [varchar](255) NULL,
	[Field15] [varchar](255) NULL,
	[Field16] [varchar](255) NULL,
	[Field17] [varchar](255) NULL,
	[Field18] [varchar](255) NULL,
	[Field19] [varchar](255) NULL,
	[Field20] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_DocFollow]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_DocFollow](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[DocType] [varchar](5) NULL,
	[DocNo] [varchar](20) NULL,
	[DDuration] [smallint] NULL,
	[DueDate] [datetime] NULL,
	[FollowResult] [varchar](1) NULL,
	[ExternalUnit] [varchar](70) NULL,
	[ExternalContact] [varchar](50) NULL,
	[ExternalTel] [varchar](50) NULL,
	[FollowReson] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_DocPolicy]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_DocPolicy](
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[DocTypeList] [varchar](255) NULL,
	[PolicyCode] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Document]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Document](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[DocType] [varchar](5) NULL,
	[DocDate] [datetime] NULL,
	[DocNo] [varchar](20) NULL,
	[Description] [varchar](250) NULL,
	[FileName] [varchar](100) NULL,
	[StorePlace] [varchar](100) NULL,
	[IsCalling] [tinyint] NULL,
	[RecvCallDate] [datetime] NULL,
	[RecvCallBy] [varchar](50) NULL,
	[IsFollowUp] [tinyint] NULL,
	[BeginFollowDate] [datetime] NULL,
	[FinishFollowDate] [datetime] NULL,
	[FollowBy] [varchar](50) NULL,
	[IsSendToCustomer] [tinyint] NULL,
	[SendToDate] [datetime] NULL,
	[SendToBy] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_GLDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_GLDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[GLRefNo] [varchar](15) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[GLAccountCode] [varchar](50) NULL,
	[GLDescription] [nvarchar](255) NULL,
	[SourceDocument] [nvarchar](max) NULL,
	[DebitAmt] [float] NULL,
	[CreditAmt] [float] NULL,
	[EntryDate] [datetime] NULL,
	[EntryBy] [varchar](15) NULL,
 CONSTRAINT [PK_GLDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[GLRefNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_GLHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_GLHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[GLRefNo] [varchar](15) NOT NULL,
	[FiscalYear] [varchar](10) NOT NULL,
	[LastupDate] [datetime] NULL,
	[UpdateBy] [varchar](15) NULL,
	[GLType] [varchar](10) NULL,
	[Remark] [nvarchar](255) NULL,
	[TotalDebit] [float] NULL,
	[TotalCredit] [float] NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveBy] [varchar](15) NULL,
	[PostDate] [datetime] NULL,
	[PostBy] [varchar](15) NULL,
	[CancelDate] [datetime] NULL,
	[CancelBy] [varchar](15) NULL,
	[CancelReason] [nvarchar](255) NULL,
 CONSTRAINT [PK_GLHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[GLRefNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_InvoiceDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_InvoiceDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[ExpSlipNO] [varchar](100) NULL,
	[SRemark] [varchar](100) NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NOT NULL,
	[Qty] [float] NOT NULL,
	[QtyUnit] [varchar](30) NULL,
	[UnitPrice] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[Amt] [float] NOT NULL,
	[FAmt] [float] NOT NULL,
	[DiscountType] [int] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[FAmtDiscount] [float] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[Amt50Tavi] [float] NOT NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[AmtVat] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
	[CurrencyCodeCredit] [varchar](50) NULL,
	[ExchangeRateCredit] [float] NOT NULL,
	[AmtCredit] [float] NOT NULL,
	[FAmtCredit] [float] NOT NULL,
	[VATRate] [float] NOT NULL,
 CONSTRAINT [PK_InvD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_InvoiceHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_InvoiceHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[ContactName] [varchar](100) NULL,
	[EmpCode] [varchar](10) NULL,
	[PrintedBy] [varchar](10) NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) NULL,
	[VATRate] [float] NULL,
	[TotalAdvance] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalIsTaxCharge] [float] NULL,
	[TotalIs50Tavi] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[TotalNet] [float] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignNet] [float] NULL,
	[BillAcceptDate] [datetime] NULL,
	[BillIssueDate] [datetime] NULL,
	[BillAcceptNo] [varchar](15) NULL,
	[Remark1] [varchar](max) NULL,
	[Remark2] [varchar](max) NULL,
	[Remark3] [varchar](max) NULL,
	[Remark4] [varchar](max) NULL,
	[Remark5] [varchar](max) NULL,
	[Remark6] [varchar](max) NULL,
	[Remark7] [varchar](max) NULL,
	[Remark8] [varchar](max) NULL,
	[Remark9] [varchar](max) NULL,
	[Remark10] [varchar](max) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[ShippingRemark] [varchar](50) NULL,
 CONSTRAINT [PK_InvH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_LoadInfo]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_LoadInfo](
	[BranchCode] [varchar](3) NOT NULL,
	[JNo] [varchar](15) NOT NULL,
	[VenderCode] [varchar](10) NULL,
	[ContactName] [varchar](100) NULL,
	[BookingNo] [varchar](50) NULL,
	[LoadDate] [datetime] NULL,
	[Remark] [varchar](250) NULL,
	[PackingPlace] [varchar](250) NULL,
	[CYPlace] [varchar](250) NULL,
	[FactoryPlace] [varchar](250) NULL,
	[ReturnPlace] [varchar](250) NULL,
	[PackingDate] [datetime] NULL,
	[CYDate] [datetime] NULL,
	[FactoryDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
	[PackingTime] [datetime] NULL,
	[CYTime] [datetime] NULL,
	[FactoryTime] [datetime] NULL,
	[ReturnTime] [datetime] NULL,
	[NotifyCode] [varchar](50) NULL,
	[TransMode] [varchar](50) NULL,
	[PaymentCondition] [varchar](20) NULL,
	[PaymentBy] [varchar](255) NULL,
 CONSTRAINT [PK_JOB_LOADINFO] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_LoadInfoDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_LoadInfoDetail](
	[BranchCode] [varchar](3) NOT NULL,
	[JNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[CTN_NO] [varchar](15) NULL,
	[SealNumber] [varchar](20) NULL,
	[TruckNO] [varchar](15) NULL,
	[TruckIN] [datetime] NULL,
	[Start] [datetime] NULL,
	[Finish] [datetime] NULL,
	[TimeUsed] [datetime] NULL,
	[CauseCode] [varchar](5) NULL,
	[Comment] [varchar](100) NULL,
	[TruckType] [varchar](20) NULL,
	[Driver] [varchar](50) NULL,
	[TargetYardDate] [datetime] NULL,
	[TargetYardTime] [datetime] NULL,
	[ActualYardDate] [datetime] NULL,
	[ActualYardTime] [datetime] NULL,
	[UnloadFinishDate] [datetime] NULL,
	[UnloadFinishTime] [datetime] NULL,
	[UnloadDate] [datetime] NULL,
	[UnloadTime] [datetime] NULL,
	[Location] [varchar](500) NULL,
	[ReturnDate] [datetime] NULL,
	[ShippingMark] [varchar](max) NULL,
	[ProductDesc] [varchar](max) NULL,
	[CTN_SIZE] [varchar](15) NULL,
	[ProductQty] [float] NULL,
	[ProductUnit] [varchar](20) NULL,
	[GrossWeight] [float] NULL,
	[Measurement] [float] NULL,
 CONSTRAINT [PK_JOB_LOADINFODETAIL] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Order]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Order](
	[BranchCode] [varchar](5) NOT NULL,
	[JNo] [varchar](15) NOT NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
 CONSTRAINT [pk_JobOrder] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_OrderLog]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_OrderLog](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[ItemNo] [int] NULL,
	[EmpCode] [varchar](10) NULL,
	[LogDate] [datetime] NULL,
	[LogTime] [datetime] NULL,
	[TRemark] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_OSRCreditNote]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_OSRCreditNote](
	[BranchCode] [varchar](5) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](5) NULL,
	[TotalCharge] [float] NOT NULL,
	[TotalVAT] [float] NOT NULL,
	[BillNo] [varchar](15) NULL,
	[Remark1] [varchar](100) NULL,
	[Remark2] [varchar](100) NULL,
	[Remark3] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_PaymentDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_PaymentDetail](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[ExpSlipNO] [varchar](100) NULL,
	[SRemark] [varchar](100) NULL,
	[QtyUnit] [varchar](30) NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[AmtAdvance] [float] NOT NULL,
	[AmtCharge] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NOT NULL,
	[CurrencyCodeCredit] [varchar](50) NULL,
	[ExchangeRateCredit] [float] NOT NULL,
	[ForeignAmtCredit] [float] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[AmtDiscount] [float] NOT NULL,
	[ForeignDisc] [float] NOT NULL,
	[FUnitPrice] [float] NOT NULL,
	[FQty] [float] NOT NULL,
	[FTotalAmt] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_PaymentHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_PaymentHeader](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[JNo] [varchar](15) NULL,
	[JobBillAmt] [tinyint] NOT NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[ContactName] [varchar](100) NULL,
	[EmpCode] [varchar](10) NULL,
	[PrintedBy] [varchar](10) NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[RefNo] [varchar](255) NULL,
	[VATRate] [float] NOT NULL,
	[Tavi50Rate1] [float] NOT NULL,
	[Tavi50Rate2] [float] NOT NULL,
	[TaxInvNo] [varchar](15) NULL,
	[TaxInvDate] [datetime] NULL,
	[TotalAdvance] [float] NOT NULL,
	[TotalCharge] [float] NOT NULL,
	[TotalIsTaxCharge] [float] NOT NULL,
	[TotalIs50Tavi1] [float] NOT NULL,
	[TotalIs50Tavi2] [float] NOT NULL,
	[TotalVAT] [float] NOT NULL,
	[Total50Tavi1] [float] NOT NULL,
	[Total50Tavi2] [float] NOT NULL,
	[TotalCustAdv] [float] NOT NULL,
	[TotalNet] [float] NOT NULL,
	[BillDate] [datetime] NULL,
	[BillTime] [datetime] NULL,
	[BillAcceptNo] [varchar](15) NULL,
	[PayDate] [datetime] NULL,
	[PayTime] [datetime] NULL,
	[Remark1] [varchar](255) NULL,
	[Remark2] [varchar](255) NULL,
	[Remark3] [varchar](255) NULL,
	[Remark4] [varchar](255) NULL,
	[Remark5] [varchar](255) NULL,
	[Remark6] [varchar](255) NULL,
	[Remark7] [varchar](255) NULL,
	[Remark8] [varchar](255) NULL,
	[Remark9] [varchar](255) NULL,
	[Remark10] [varchar](255) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[PaidFlag] [tinyint] NOT NULL,
	[ShippingRemark] [varchar](50) NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[QuatationNo] [varchar](15) NULL,
	[Revise] [int] NOT NULL,
	[JobCustCode] [varchar](15) NULL,
	[JobCustBranch] [varchar](4) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuoDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuoDetail](
	[BranchCode] [varchar](3) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[LinkItem] [smallint] NULL,
	[Description] [varchar](200) NULL,
	[TotalPrice] [int] NULL,
	[UnitCode] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuoDetailItem]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuoDetailItem](
	[BranchCode] [varchar](3) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[LinkItem] [smallint] NULL,
	[ItemNo] [smallint] NULL,
	[STCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[NameThai] [varchar](100) NULL,
	[VenderCode] [varchar](10) NULL,
	[UnitCharge] [varchar](10) NULL,
	[UnitPrice] [float] NULL,
	[CurrencyCode] [varchar](3) NULL,
	[Start] [varchar](5) NULL,
	[Endding] [varchar](5) NULL,
	[CY] [varchar](5) NULL,
	[QtyStep] [varchar](250) NULL,
	[StepSub] [varchar](4000) NULL,
	[IsPrintPrice] [tinyint] NULL,
	[IsShowOnPrint] [tinyint] NULL,
	[PrivoteType] [tinyint] NULL,
	[UnitCost] [float] NOT NULL,
	[UnitQTY] [float] NOT NULL,
	[CurrencyRate] [float] NOT NULL,
	[Isvat] [int] NOT NULL,
	[VatRate] [int] NOT NULL,
	[VatAmt] [float] NOT NULL,
	[IsTax] [int] NOT NULL,
	[TaxRate] [int] NOT NULL,
	[TaxAmt] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[CurrentTHB] [float] NOT NULL,
	[UnitDiscntPerc] [float] NOT NULL,
	[UnitDiscntAmt] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuoHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuoHeader](
	[BranchCode] [varchar](3) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ReferQNo] [varchar](20) NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](5) NULL,
	[ContactName] [varchar](100) NULL,
	[DocDate] [datetime] NULL,
	[ManagerCode] [varchar](10) NULL,
	[DescriptionH] [varchar](4000) NULL,
	[DescriptionF] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[ApproveBy] [varchar](10) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[ExchageRate] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuotationDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuotationDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[QNo] [varchar](15) NOT NULL,
	[SeqNo] [smallint] NOT NULL,
	[JobType] [smallint] NOT NULL,
	[ShipBy] [smallint] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuoDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC,
	[SeqNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuotationHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuotationHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[QNo] [varchar](15) NOT NULL,
	[ReferQNo] [varchar](20) NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](5) NULL,
	[ContactName] [varchar](100) NULL,
	[DocDate] [datetime] NULL,
	[ManagerCode] [varchar](10) NULL,
	[DescriptionH] [nvarchar](max) NULL,
	[DescriptionF] [nvarchar](max) NULL,
	[TRemark] [varchar](250) NULL,
	[DocStatus] [int] NULL,
	[ApproveBy] [varchar](10) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[CancelBy] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [nvarchar](255) NULL,
 CONSTRAINT [PK_QuotaionH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuotationItem]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_QuotationItem](
	[BranchCode] [varchar](5) NOT NULL,
	[QNo] [varchar](15) NOT NULL,
	[SeqNo] [smallint] NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) NULL,
	[DescriptionThai] [varchar](100) NULL,
	[CalculateType] [int] NOT NULL,
	[QtyBegin] [float] NULL,
	[QtyEnd] [float] NULL,
	[UnitCheck] [varchar](10) NOT NULL,
	[CurrencyCode] [varchar](3) NULL,
	[CurrencyRate] [float] NOT NULL,
	[ChargeAmt] [float] NOT NULL,
	[Isvat] [int] NOT NULL,
	[VatRate] [int] NOT NULL,
	[VatAmt] [float] NOT NULL,
	[IsTax] [int] NOT NULL,
	[TaxRate] [int] NOT NULL,
	[TaxAmt] [float] NOT NULL,
	[TotalAmt] [float] NOT NULL,
	[TotalCharge] [float] NOT NULL,
	[UnitDiscntPerc] [float] NOT NULL,
	[UnitDiscntAmt] [float] NOT NULL,
	[VenderCode] [varchar](10) NULL,
	[VenderCost] [float] NULL,
	[BaseProfit] [float] NULL,
	[CommissionPerc] [float] NULL,
	[CommissionAmt] [float] NULL,
	[NetProfit] [float] NULL,
	[IsRequired] [int] NOT NULL,
 CONSTRAINT [PK_QuoItem] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[QNo] ASC,
	[SeqNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RClearExp]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RClearExp](
	[BranchCode] [varchar](3) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[DocDate] [datetime] NULL,
	[TotalNetCharge] [float] NULL,
	[TotalCustAdv] [float] NULL,
	[BillingNo] [varchar](50) NULL,
	[CancelProve] [varchar](50) NULL,
	[CancelDate] [date] NULL,
	[CancelReason] [nvarchar](255) NULL,
 CONSTRAINT [PK_RClearExp] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RClearExpSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RClearExpSub](
	[BranchCode] [varchar](3) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[AmountCharge] [float] NULL,
 CONSTRAINT [PK_RClearExpSub] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ReceiptDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ReceiptDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[ReceiptNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[CreditAmount] [float] NULL,
	[CashAmount] [float] NULL,
	[TransferAmount] [float] NULL,
	[ChequeAmount] [float] NULL,
	[ControlNo] [varchar](15) NULL,
	[VoucherNo] [varchar](15) NULL,
	[ControlItemNo] [int] NULL,
	[InvoiceNo] [varchar](15) NULL,
	[InvoiceItemNo] [int] NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[VATRate] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[Amt] [float] NULL,
	[AmtVAT] [float] NULL,
	[Amt50Tavi] [float] NULL,
	[Net] [float] NULL,
	[DCurrencyCode] [varchar](50) NULL,
	[DExchangeRate] [float] NULL,
	[FAmt] [float] NULL,
	[FAmtVAT] [float] NULL,
	[FAmt50Tavi] [float] NULL,
	[FNet] [float] NULL,
 CONSTRAINT [PK_ReceiptD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ReceiptHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ReceiptHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[ReceiptNo] [varchar](15) NOT NULL,
	[ReceiptDate] [datetime] NULL,
	[ReceiptType] [varchar](10) NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[TRemark] [varchar](250) NULL,
	[EmpCode] [varchar](10) NULL,
	[PrintedBy] [varchar](10) NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](30) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalNet] [float] NULL,
 CONSTRAINT [PK_ReceiptHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RefundTaxDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RefundTaxDetail](
	[RefundNo] [varchar](50) NOT NULL,
	[DNo] [varchar](50) NOT NULL,
	[DeclareNumber] [varchar](50) NULL,
	[ExDate] [datetime] NULL,
	[Product] [varchar](50) NULL,
	[FOB] [float] NULL,
	[NetWeight] [float] NULL,
	[GFrom] [varchar](50) NULL,
	[TTariff] [float] NULL,
	[TRate] [float] NULL,
	[TAmount] [float] NULL,
	[INVNo] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RefundTaxHeader]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RefundTaxHeader](
	[RefundNo] [varchar](50) NOT NULL,
	[SendDate] [datetime] NULL,
	[ReDate] [datetime] NULL,
	[ClaimNo] [varchar](50) NULL,
	[ClaimDate] [datetime] NULL,
	[TaxCardDate] [datetime] NULL,
	[CNDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RSlip]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RSlip](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[DocDate] [datetime] NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Remark1] [varchar](100) NULL,
	[Remark2] [varchar](100) NULL,
	[Remark3] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_RSlipSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_RSlipSub](
	[BranchCode] [varchar](3) NULL,
	[DocNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[BillNo] [varchar](15) NULL,
	[SDescription] [varchar](150) NULL,
	[AmtCharge] [float] NULL,
	[AmtVAT] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ServicePolicy]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ServicePolicy](
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[Field1] [varchar](255) NULL,
	[Field2] [varchar](255) NULL,
	[Field3] [varchar](255) NULL,
	[Field4] [varchar](255) NULL,
	[Field5] [varchar](255) NULL,
	[Field6] [varchar](255) NULL,
	[Field7] [varchar](255) NULL,
	[Field8] [varchar](255) NULL,
	[Field9] [varchar](255) NULL,
	[Field10] [varchar](255) NULL,
	[Field11] [varchar](255) NULL,
	[Field12] [varchar](255) NULL,
	[Field13] [varchar](255) NULL,
	[Field14] [varchar](255) NULL,
	[Field15] [varchar](255) NULL,
	[Field16] [varchar](255) NULL,
	[Field17] [varchar](255) NULL,
	[Field18] [varchar](255) NULL,
	[Field19] [varchar](255) NULL,
	[Field20] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvAccount]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvAccount](
	[SICode] [varchar](10) NULL,
	[JobType] [tinyint] NULL,
	[GLAccountCode] [varchar](15) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvAirCharge]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvAirCharge](
	[SICode] [varchar](10) NULL,
	[NameThai] [varchar](100) NULL,
	[NameEng] [varchar](100) NULL,
	[UnitCode] [varchar](10) NULL,
	[ProcessDesc] [varchar](250) NULL,
	[GLAccountCode] [varchar](15) NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsShowPrice] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsPay50TaviTo] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[QtyStep] [varchar](100) NULL,
	[ChargeStep] [varchar](4000) NULL,
	[IsUsedCoSlip] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvAirCost]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvAirCost](
	[VenderCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[UnitCode] [varchar](10) NULL,
	[QtyStep] [varchar](100) NULL,
	[ChargeStep] [varchar](4000) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvGroup]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvGroup](
	[GroupCode] [varchar](10) NOT NULL,
	[GroupName] [nvarchar](255) NOT NULL,
	[GLAccountCode] [varchar](15) NULL,
	[IsApplyPolicy] [int] NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvSingle]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvSingle](
	[SICode] [varchar](10) NOT NULL,
	[NameThai] [varchar](100) NULL,
	[NameEng] [varchar](100) NULL,
	[StdPrice] [float] NULL,
	[UnitCharge] [varchar](10) NULL,
	[CurrencyCode] [varchar](3) NULL,
	[DefaultVender] [varchar](15) NULL,
	[ProcessDesc] [varchar](250) NULL,
	[GLAccountCodeSales] [varchar](15) NULL,
	[GLAccountCodeCost] [varchar](15) NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[Rate50Tavi] [float] NOT NULL,
	[IsCredit] [tinyint] NOT NULL,
	[IsExpense] [tinyint] NOT NULL,
	[IsShowPrice] [tinyint] NOT NULL,
	[IsHaveSlip] [tinyint] NOT NULL,
	[IsPay50TaviTo] [tinyint] NOT NULL,
	[IsLtdAdv50Tavi] [tinyint] NOT NULL,
	[IsUsedCoSlip] [int] NOT NULL,
	[GroupCode] [varchar](10) NULL,
 CONSTRAINT [pk_sicode] PRIMARY KEY CLUSTERED 
(
	[SICode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvSingleCost]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvSingleCost](
	[VenderCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[Description] [varchar](100) NULL,
	[Cost] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvStep]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvStep](
	[SICode] [varchar](10) NULL,
	[NameThai] [varchar](100) NULL,
	[NameEng] [varchar](100) NULL,
	[Start] [varchar](5) NULL,
	[Endding] [varchar](5) NULL,
	[CY] [varchar](5) NULL,
	[UnitCharge] [varchar](10) NULL,
	[CurrencyCode] [varchar](3) NULL,
	[DefaultVender] [varchar](15) NULL,
	[ProcessDesc] [varchar](250) NULL,
	[GLAccountCode] [varchar](15) NULL,
	[IsTaxCharge] [tinyint] NULL,
	[Is50Tavi] [tinyint] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [tinyint] NULL,
	[IsExpense] [tinyint] NULL,
	[IsShowPrice] [tinyint] NULL,
	[IsHaveSlip] [tinyint] NULL,
	[IsPay50TaviTo] [tinyint] NULL,
	[IsLtdAdv50Tavi] [tinyint] NULL,
	[ChargeType] [varchar](1) NULL,
	[StepSub] [varchar](4000) NULL,
	[IsUsedCoSlip] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvStepCost]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvStepCost](
	[VenderCode] [varchar](10) NULL,
	[SICode] [varchar](10) NULL,
	[StepSub] [varchar](4000) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvTemplate]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvTemplate](
	[STCode] [varchar](10) NULL,
	[NameThai] [varchar](100) NULL,
	[TermOfPayment] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvTemplateSub]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_SrvTemplateSub](
	[STCode] [varchar](10) NULL,
	[ItemNo] [int] NULL,
	[SICode] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Tax50Tavi]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Tax50Tavi](
	[BranchCode] [varchar](4) NOT NULL,
	[DocNo] [varchar](50) NOT NULL,
	[JNo] [varchar](15) NULL,
	[DocRefType] [tinyint] NULL,
	[DocRefNo] [varchar](20) NULL,
	[DocDate] [datetime] NULL,
	[TaxNumber1] [varchar](15) NULL,
	[TName1] [varchar](max) NULL,
	[TAddress1] [varchar](150) NULL,
	[TaxNumber2] [varchar](15) NULL,
	[TName2] [varchar](max) NULL,
	[TAddress2] [varchar](150) NULL,
	[TaxNumber3] [varchar](15) NULL,
	[TName3] [varchar](max) NULL,
	[TAddress3] [varchar](150) NULL,
	[SeqInForm] [int] NULL,
	[FormType] [tinyint] NULL,
	[IncRate] [float] NULL,
	[IncOther] [varchar](70) NULL,
	[IncType1] [varchar](5) NULL,
	[PayDate1] [datetime] NULL,
	[PayAmount1] [float] NULL,
	[PayTax1] [float] NULL,
	[IncType2] [varchar](5) NULL,
	[PayDate2] [datetime] NULL,
	[PayAmount2] [float] NULL,
	[PayTax2] [float] NULL,
	[IncType3] [varchar](5) NULL,
	[PayDate3] [datetime] NULL,
	[PayAmount3] [float] NULL,
	[PayTax3] [float] NULL,
	[TotalPayAmount] [float] NULL,
	[TotalPayTax] [float] NULL,
	[SoLicenseNo] [varchar](50) NULL,
	[SoLicenseAmount] [float] NULL,
	[SoAccAmount] [float] NULL,
	[PayeeAccNo] [varchar](15) NULL,
	[SoTaxNo] [varchar](15) NULL,
	[PayTaxType] [tinyint] NULL,
	[PayTaxOther] [varchar](20) NULL,
	[IDCard1] [varchar](15) NULL,
	[IDCard2] [varchar](15) NULL,
	[IDCard3] [varchar](15) NULL,
	[PayTaxDesc1] [varchar](50) NULL,
	[PayTaxDesc2] [varchar](50) NULL,
	[TaxLawNo] [varchar](2) NULL,
	[PayTaxDesc3] [varchar](50) NULL,
	[UpdateBy] [nvarchar](255) NULL,
 CONSTRAINT [PK_JobTax50Tavi] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_TaxInvoice]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_TaxInvoice](
	[BranchCode] [varchar](3) NULL,
	[InvNo] [varchar](15) NULL,
	[InvDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToCustBranch] [varchar](4) NULL,
	[BillingNO] [varchar](255) NULL,
	[VATRate] [float] NULL,
	[TotalCharge] [float] NULL,
	[TotalVAT] [float] NULL,
	[Total50Tavi] [float] NULL,
	[TotalNet] [float] NULL,
	[TRemark] [varchar](250) NULL,
	[EmpCode] [varchar](10) NULL,
	[PrintedBy] [varchar](10) NULL,
	[PrintedDate] [datetime] NULL,
	[PrintedTime] [datetime] NULL,
	[ReceiveBy] [varchar](10) NULL,
	[ReceiveDate] [datetime] NULL,
	[ReceiveTime] [datetime] NULL,
	[ReceiveRef] [varchar](30) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NULL,
	[ForeignAmt] [float] NULL,
	[CashDate] [date] NULL,
	[CashAmount] [float] NULL,
	[Transferdate] [date] NULL,
	[TransferBank] [varchar](100) NULL,
	[TransferAmount] [float] NULL,
	[CheqDate] [date] NULL,
	[CheqBank] [varchar](100) NULL,
	[CheqAmount] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_TaxInvoiceDetail]    Script Date: 17/05/2019 13:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_TaxInvoiceDetail](
	[BranchCode] [varchar](3) NULL,
	[InvNo] [varchar](15) NULL,
	[ItemNo] [smallint] NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](100) NULL,
	[Rate50Tavi] [float] NULL,
	[AmtCharge] [float] NULL,
	[AmtVAT] [float] NULL,
	[Amt50Tavi] [float] NULL,
	[Qty] [float] NULL,
	[UnitPrice] [float] NULL,
	[QtyUnit] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Transport]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_Transport](
	[BranchCode] [varchar](50) NULL,
	[JobNo] [varchar](50) NULL,
	[TransportSeq] [int] NULL,
	[BookingDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[DueTime] [datetime] NULL,
	[FromLocation] [varchar](255) NULL,
	[ToLocation] [varchar](255) NULL,
	[CarType] [tinyint] NULL,
	[CarSize] [tinyint] NULL,
	[Product] [varchar](255) NULL,
	[Qty] [varchar](255) NULL,
	[Remark] [varchar](255) NULL,
	[RequestDept] [varchar](255) NULL,
	[RequestBy] [varchar](255) NULL,
	[ApproveBy] [varchar](50) NULL,
	[ApproveDate] [datetime] NULL,
	[Driver] [varchar](255) NULL,
	[CarID] [varchar](50) NULL,
	[Reason] [varchar](255) NULL,
	[DeliverSlip] [varchar](50) NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliverBy] [varchar](255) NULL,
	[StartTime] [varchar](10) NULL,
	[StartMile] [float] NULL,
	[EndTime] [varchar](10) NULL,
	[EndMile] [float] NULL,
	[ArrivalDate] [datetime] NULL,
	[ArrivalTime] [datetime] NULL,
	[SlipNo] [varchar](50) NULL,
	[SlipDate] [datetime] NULL,
	[CheckedBy] [varchar](50) NULL,
	[ClearBy] [varchar](50) NULL,
	[ClearDate] [datetime] NULL,
	[DocStatus] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_TruckOrder]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_TruckOrder](
	[CarNo] [varchar](15) NOT NULL,
	[CarDate] [datetime] NULL,
	[JobNo] [varchar](20) NULL,
	[CustName] [varchar](50) NULL,
	[CustTel] [varchar](20) NULL,
	[SPlace] [varchar](50) NULL,
	[DPlace] [varchar](50) NULL,
	[SenderName] [varchar](50) NULL,
	[SenderTel] [varchar](20) NULL,
	[ReceiverName] [varchar](50) NULL,
	[GoodsType] [varchar](50) NULL,
	[GoodsQty] [varchar](50) NULL,
	[GoodsWeight] [float] NULL,
	[CarType] [varchar](50) NULL,
	[CarDriver] [varchar](50) NULL,
	[CarLicense] [varchar](10) NULL,
	[CarStatus] [varchar](1) NULL,
	[CarNote] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_WHTax]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_WHTax](
	[BranchCode] [varchar](4) NOT NULL,
	[DocNo] [varchar](50) NOT NULL,
	[DocDate] [datetime] NULL,
	[TaxNumber1] [varchar](15) NULL,
	[TName1] [varchar](max) NULL,
	[TAddress1] [varchar](max) NULL,
	[TaxNumber2] [varchar](15) NULL,
	[TName2] [varchar](max) NULL,
	[TAddress2] [varchar](max) NULL,
	[TaxNumber3] [varchar](15) NULL,
	[TName3] [varchar](max) NULL,
	[TAddress3] [varchar](max) NULL,
	[IDCard1] [varchar](15) NULL,
	[IDCard2] [varchar](15) NULL,
	[IDCard3] [varchar](15) NULL,
	[SeqInForm] [int] NULL,
	[FormType] [tinyint] NULL,
	[TaxLawNo] [varchar](2) NULL,
	[IncRate] [float] NULL,
	[IncOther] [varchar](70) NULL,
	[UpdateBy] [nvarchar](255) NULL,
	[TotalPayAmount] [float] NULL,
	[TotalPayTax] [float] NULL,
	[SoLicenseNo] [varchar](50) NULL,
	[SoLicenseAmount] [float] NULL,
	[SoAccAmount] [float] NULL,
	[PayeeAccNo] [varchar](15) NULL,
	[SoTaxNo] [varchar](15) NULL,
	[PayTaxType] [tinyint] NULL,
	[PayTaxOther] [varchar](20) NULL,
	[CancelProve] [varchar](50) NULL,
	[CancelReason] [varchar](max) NULL,
	[CancelDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[TeacherAmt] [float] NULL,
	[Branch1] [varchar](5) NULL,
	[Branch2] [varchar](5) NULL,
	[Branch3] [varchar](5) NULL,
 CONSTRAINT [PK_JobWHTax] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_WHTaxDetail]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_WHTaxDetail](
	[BranchCode] [varchar](4) NOT NULL,
	[DocNo] [varchar](50) NOT NULL,
	[ItemNo] [int] NOT NULL,
	[IncType] [varchar](5) NULL,
	[PayDate] [datetime] NULL,
	[PayAmount] [float] NULL,
	[PayTax] [float] NULL,
	[PayTaxDesc] [varchar](50) NULL,
	[JNo] [varchar](15) NULL,
	[DocRefType] [tinyint] NULL,
	[DocRefNo] [varchar](20) NULL,
	[PayRate] [float] NULL,
 CONSTRAINT [PK_JobWHTaxD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Agent]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Agent](
	[Code] [varchar](50) NULL,
	[TName] [varchar](255) NULL,
	[English] [varchar](255) NULL,
	[TAddress1] [varchar](255) NULL,
	[TAddress2] [varchar](255) NULL,
	[EAddress1] [varchar](255) NULL,
	[EAddress2] [varchar](255) NULL,
	[Phone] [varchar](255) NULL,
	[FaxNumber] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_BankCode]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_BankCode](
	[Code] [varchar](5) NOT NULL,
	[BName] [varchar](50) NULL,
	[CustomsCode] [varchar](3) NULL,
 CONSTRAINT [pK_masbankcode] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_BookAccount]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_BookAccount](
	[BranchCode] [varchar](5) NOT NULL,
	[BookCode] [varchar](15) NOT NULL,
	[BookName] [varchar](100) NULL,
	[BankCode] [varchar](10) NULL,
	[BankBranch] [varchar](50) NULL,
	[IsLocal] [tinyint] NOT NULL,
	[ACType] [varchar](10) NULL,
	[TAddress1] [varchar](70) NULL,
	[TAddress2] [varchar](70) NULL,
	[EAddress1] [varchar](70) NULL,
	[EAddress2] [varchar](70) NULL,
	[Phone] [varchar](30) NULL,
	[FaxNumber] [varchar](30) NULL,
	[LimitBalance] [float] NULL,
 CONSTRAINT [pk_masbookacc] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BookCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Branch]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Branch](
	[Code] [varchar](5) NOT NULL,
	[BrName] [varchar](50) NULL,
 CONSTRAINT [pk_branch] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Broker]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Broker](
	[ID] [varchar](20) NULL,
	[Name] [varchar](60) NULL,
	[CardBeginDate] [datetime] NULL,
	[CardFinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CompAccess]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CompAccess](
	[CompName] [varchar](30) NULL,
	[AppName] [varchar](20) NULL,
	[OpenDate] [datetime] NULL,
	[OpenTime] [datetime] NULL,
	[CloseDate] [datetime] NULL,
	[CloseTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Company]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Company](
	[CustCode] [varchar](15) NOT NULL,
	[Branch] [varchar](10) NOT NULL,
	[CustGroup] [varchar](20) NULL,
	[TaxNumber] [varchar](50) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL,
	[Phone] [varchar](30) NULL,
	[FaxNumber] [varchar](30) NULL,
	[LoginName] [varchar](20) NULL,
	[LoginPassword] [varchar](20) NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCodeIM] [varchar](10) NULL,
	[CSCodeEX] [varchar](10) NULL,
	[CSCodeOT] [varchar](10) NULL,
	[GLAccountCode] [varchar](15) NULL,
	[CustType] [tinyint] NOT NULL,
	[BillToCustCode] [varchar](15) NULL,
	[BillToBranch] [varchar](10) NULL,
	[UsedLanguage] [varchar](2) NULL,
	[LevelGrade] [varchar](5) NULL,
	[TermOfPayment] [tinyint] NULL,
	[BillCondition] [varchar](100) NULL,
	[CreditLimit] [float] NULL,
	[MapText] [varchar](250) NULL,
	[MapFileName] [varchar](150) NULL,
	[CmpType] [varchar](1) NULL,
	[CmpLevelExp] [varchar](1) NULL,
	[CmpLevelImp] [varchar](1) NULL,
	[Is19bis] [tinyint] NOT NULL,
	[MgrSeq] [smallint] NOT NULL,
	[LevelNoExp] [int] NOT NULL,
	[LevelNoImp] [int] NOT NULL,
	[LnNO] [varchar](10) NULL,
	[AdjTaxCode] [varchar](10) NULL,
	[BkAuthorNo] [varchar](10) NULL,
	[BkAuthorCnn] [varchar](10) NULL,
	[LtdPsWkName] [varchar](70) NULL,
	[ConsStatus] [varchar](255) NULL,
	[CommLevel] [varchar](2) NULL,
	[DutyLimit] [float] NOT NULL,
	[CommRate] [float] NOT NULL,
	[TAddress] [varchar](255) NULL,
	[TDistrict] [varchar](35) NULL,
	[TSubProvince] [varchar](35) NULL,
	[TProvince] [varchar](3) NULL,
	[TPostCode] [varchar](9) NULL,
	[DMailAddress] [varchar](35) NULL,
	[PrivilegeOption] [varchar](1) NULL,
	[GoldCardNO] [smallint] NOT NULL,
	[CustomsBrokerSeq] [smallint] NOT NULL,
	[ISCustomerSign] [tinyint] NOT NULL,
	[ISCustomerSignInv] [tinyint] NOT NULL,
	[ISCustomerSignDec] [tinyint] NOT NULL,
	[ISCustomerSignECon] [tinyint] NOT NULL,
	[IsShippingCannotSign] [tinyint] NOT NULL,
	[ExportCode] [varchar](20) NULL,
	[Code19BIS] [varchar](15) NULL,
	[WEB_SITE] [varchar](255) NULL,
 CONSTRAINT [pk_company] PRIMARY KEY CLUSTERED 
(
	[CustCode] ASC,
	[Branch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Config]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mas_Config](
	[ConfigCode] [nvarchar](50) NOT NULL,
	[ConfigKey] [nvarchar](500) NOT NULL,
	[ConfigValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ConfigCode] ASC,
	[ConfigKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mas_Consignee]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Consignee](
	[TaxNumber] [varchar](15) NULL,
	[Code] [varchar](15) NULL,
	[Name] [varchar](70) NULL,
	[Address1] [varchar](70) NULL,
	[Address2] [varchar](70) NULL,
	[Phone] [varchar](15) NULL,
	[FaxNumber] [varchar](15) NULL,
	[CountryCode] [varchar](3) NULL,
	[CustCode] [varchar](15) NULL,
	[NameEng] [varchar](100) NULL,
	[CityName] [varchar](50) NULL,
	[ZipCode] [varchar](10) NULL,
	[DestinationPort] [varchar](30) NULL,
	[CommFormName] [varchar](100) NULL,
	[PackFormName] [varchar](100) NULL,
	[CustFormName] [varchar](100) NULL,
	[CommStyle] [varchar](2) NULL,
	[CustStyle] [varchar](2) NULL,
	[PackStyle] [varchar](2) NULL,
	[TAddress] [varchar](255) NULL,
	[TDistrict] [varchar](35) NULL,
	[TSubProvince] [varchar](35) NULL,
	[TProvince] [varchar](3) NULL,
	[TPostCode] [varchar](9) NULL,
	[DMailAddress] [varchar](35) NULL,
	[ConsStatus] [varchar](2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_ConsignTo]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_ConsignTo](
	[TaxNumber] [varchar](15) NULL,
	[ConCode] [varchar](10) NULL,
	[ConTo] [varchar](50) NULL,
	[NameEng] [varchar](100) NULL,
	[Address1] [varchar](100) NULL,
	[Address2] [varchar](100) NULL,
	[CityName] [varchar](50) NULL,
	[ZipCode] [varchar](10) NULL,
	[CountryCode] [varchar](3) NULL,
	[DestinationPort] [varchar](30) NULL,
	[Phone] [varchar](15) NULL,
	[FaxNumber] [varchar](15) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CountryFT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CountryFT](
	[CTYCODE] [varchar](3) NOT NULL,
	[CTYName] [varchar](35) NULL,
	[CURCODE] [varchar](3) NULL,
	[FTCODE] [int] NULL,
	[CUCODE] [int] NULL,
 CONSTRAINT [pk_country] PRIMARY KEY CLUSTERED 
(
	[CTYCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CurrencyCode]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CurrencyCode](
	[Code] [varchar](3) NOT NULL,
	[TName] [varchar](35) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [pk_currency] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CustContact]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CustContact](
	[CustCode] [varchar](15) NULL,
	[Branch] [varchar](4) NULL,
	[ItemNo] [smallint] NULL,
	[DepType] [varchar](20) NULL,
	[UPosition] [varchar](50) NULL,
	[CName] [varchar](70) NULL,
	[EMail] [varchar](50) NULL,
	[PhoneExtn] [varchar](10) NULL,
	[DMail] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CustCredit]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CustCredit](
	[custcode] [varchar](15) NULL,
	[custbranch] [varchar](4) NULL,
	[recvno] [varchar](255) NULL,
	[recvdate] [datetime] NULL,
	[recvamount] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_DocType]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_DocType](
	[DocType] [varchar](5) NULL,
	[DocName] [varchar](100) NULL,
	[StartAtType] [tinyint] NULL,
	[DDuration] [varchar](50) NULL,
	[IsFollowUp] [tinyint] NULL,
	[IsSendToCustomer] [tinyint] NULL,
	[IsCalling] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Factory]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Factory](
	[FactoryNo] [varchar](8) NULL,
	[FactoryName] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAS_GLACCOUNT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAS_GLACCOUNT](
	[BranchCode] [nvarchar](10) NOT NULL,
	[JobType] [int] NOT NULL,
	[ShipBy] [int] NOT NULL,
	[GLCostCode] [nvarchar](50) NULL,
	[GLCostName] [nvarchar](500) NULL,
	[GLSalesCode] [nvarchar](50) NULL,
	[GLSalsesName] [nvarchar](500) NULL,
	[IDent] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_MAS_GLACCOUNT] PRIMARY KEY CLUSTERED 
(
	[IDent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mas_HistoryLog]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_HistoryLog](
	[LogID] [int] NULL,
	[LogDate] [datetime] NULL,
	[LogTime] [datetime] NULL,
	[EmpCode] [varchar](50) NULL,
	[LogType] [tinyint] NULL,
	[Description] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_InvExpense]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_InvExpense](
	[ExpCode] [varchar](2) NULL,
	[Descriptions] [varchar](100) NULL,
	[StdCost] [float] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[GroupType] [tinyint] NULL,
	[ItemAvgType] [tinyint] NULL,
	[IsDestCharge] [tinyint] NULL,
	[Incoterms2000] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_InvUnit]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_InvUnit](
	[Code] [varchar](20) NULL,
	[TName] [varchar](50) NULL,
	[EDICode] [varchar](3) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_LoadCause]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_LoadCause](
	[Code] [varchar](5) NULL,
	[TName] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Manager]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Manager](
	[TaxNumber] [varchar](10) NULL,
	[SeqNO] [smallint] NULL,
	[Name] [varchar](60) NULL,
	[CardID] [varchar](40) NULL,
	[Type] [smallint] NULL,
	[CardBeginDate] [datetime] NULL,
	[CardFinishDate] [datetime] NULL,
	[LastUpDate] [datetime] NULL,
	[LtdPsOld] [smallint] NULL,
	[LtdPsNation] [varchar](15) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_PdtGroup]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_PdtGroup](
	[TaxNumber] [varchar](10) NULL,
	[Code] [varchar](10) NULL,
	[TName] [varchar](70) NULL,
	[EName] [varchar](70) NULL,
	[CustCode] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_PermitIssue]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_PermitIssue](
	[IssueBy] [varchar](17) NULL,
	[IssueName] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Product]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Product](
	[Taxnumber] [varchar](10) NULL,
	[GroupCode] [varchar](10) NULL,
	[Code] [varchar](20) NULL,
	[TariffClass] [varchar](7) NULL,
	[TariffSeq] [varchar](2) NULL,
	[TariffStatCode] [varchar](3) NULL,
	[RTCProductCode] [varchar](10) NULL,
	[ProductYear] [smallint] NULL,
	[WeightUnit] [varchar](3) NULL,
	[QuantityUnit] [varchar](3) NULL,
	[AllPrice] [varchar](50) NULL,
	[InvoiceQTYUnit] [varchar](50) NULL,
	[BrandName] [varchar](70) NULL,
	[ProductAttribute1] [varchar](70) NULL,
	[ProductAttribute2] [varchar](70) NULL,
	[Desc1] [varchar](70) NULL,
	[Desc2] [varchar](70) NULL,
	[Desc3] [varchar](70) NULL,
	[Degree] [float] NULL,
	[CC] [float] NULL,
	[Remark] [varchar](80) NULL,
	[AFTACode] [varchar](5) NULL,
	[ExciseNo] [varchar](20) NULL,
	[LastUpdate] [datetime] NULL,
	[AnnPrice] [float] NULL,
	[FormulaNo] [varchar](20) NULL,
	[NewRawCode] [varchar](6) NULL,
	[OldRawCode] [varchar](15) NULL,
	[RawUnit] [varchar](3) NULL,
	[OtherPdtName] [tinyint] NULL,
	[CurUnitPrice] [varchar](3) NULL,
	[BondNo] [varchar](10) NULL,
	[BoiNo] [varchar](20) NULL,
	[Compen] [varchar](1) NULL,
	[Announce1] [varchar](100) NULL,
	[Announce2] [varchar](100) NULL,
	[ShipMark1] [varchar](35) NULL,
	[ShipMark2] [varchar](35) NULL,
	[ShipMark3] [varchar](35) NULL,
	[ShipMark4] [varchar](35) NULL,
	[ShipMark5] [varchar](35) NULL,
	[ShipMark6] [varchar](35) NULL,
	[CustCode] [varchar](15) NULL,
	[InvDesc] [varchar](150) NULL,
	[DecDesc1] [varchar](70) NULL,
	[DecDesc2] [varchar](70) NULL,
	[DecDesc3] [varchar](70) NULL,
	[DecDesc4] [varchar](70) NULL,
	[DecDesc5] [varchar](70) NULL,
	[CardAmt] [smallint] NULL,
	[IsRawmat] [tinyint] NULL,
	[RawCode] [varchar](20) NULL,
	[BOIQuotaCode] [varchar](4) NULL,
	[BOIQuotaNo] [varchar](6) NULL,
	[BOIType] [tinyint] NULL,
	[PermitNo] [varchar](15) NULL,
	[CommodityAWB] [varchar](4) NULL,
	[RTCCode] [varchar](10) NULL,
	[PrivilegeCode] [varchar](3) NULL,
	[ExportTariff] [varchar](12) NULL,
	[UNDGNumber] [varchar](4) NULL,
	[PdtUnitCode] [varchar](3) NULL,
	[IsPermit] [tinyint] NULL,
	[IsReExport] [tinyint] NULL,
	[Prate] [float] NULL,
	[Srate] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_ProductMark]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_ProductMark](
	[TaxNumber] [varchar](15) NULL,
	[GroupCode] [varchar](10) NULL,
	[Code] [varchar](20) NULL,
	[Consignee] [varchar](10) NULL,
	[BrandName] [varchar](70) NULL,
	[MarkDesc1] [varchar](50) NULL,
	[MarkDesc2] [varchar](50) NULL,
	[MarkDesc3] [varchar](50) NULL,
	[MarkDesc4] [varchar](50) NULL,
	[MarkDesc5] [varchar](50) NULL,
	[MarkDesc6] [varchar](50) NULL,
	[ImageFileName] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_ProductSub]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_ProductSub](
	[TaxNumber] [varchar](15) NULL,
	[GroupCode] [varchar](10) NULL,
	[Code] [varchar](20) NULL,
	[SubCode] [varchar](10) NULL,
	[SubDescEng] [varchar](100) NULL,
	[SubDescThai] [varchar](100) NULL,
	[SubLabel] [varchar](100) NULL,
	[ImageFileName] [varchar](100) NULL,
	[DimSize] [varchar](50) NULL,
	[DimUnit] [varchar](20) NULL,
	[OriginalUnit] [varchar](20) NULL,
	[WeightUnit] [varchar](20) NULL,
	[PackRatio] [varchar](100) NULL,
	[SalesPackUnit] [varchar](20) NULL,
	[SalesPackPerQty] [float] NULL,
	[SalesPrice] [varchar](100) NULL,
	[CalcPriceFrom] [tinyint] NULL,
	[SubRawCode] [varchar](20) NULL,
	[SubRawUnit] [varchar](3) NULL,
	[SubFormulaNo] [varchar](30) NULL,
	[NetWeight] [float] NULL,
	[GrossWeight] [float] NULL,
	[BarcodeType] [varchar](15) NULL,
	[BarCodeNo] [varchar](20) NULL,
	[PackToPrint] [varchar](100) NULL,
	[UnitRatio] [varchar](50) NULL,
	[PackageUnit] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Province]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Province](
	[ProvinceCode] [varchar](3) NULL,
	[ProvinceName] [varchar](35) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_ProvinceSub]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_ProvinceSub](
	[ProvinceCode] [varchar](3) NULL,
	[SubProvince] [varchar](35) NULL,
	[District] [varchar](35) NULL,
	[PostCode] [varchar](9) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFEDR]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFEDR](
	[ExportTariff] [varchar](12) NULL,
	[TariffSeq] [varchar](5) NULL,
	[DutyCode] [varchar](1) NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) NULL,
	[Description] [varchar](4000) NULL,
	[DescriptionEng] [varchar](4000) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[AnnDesc] [varchar](4000) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFIDR]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFIDR](
	[ImportTariff] [varchar](12) NULL,
	[TariffSeq] [varchar](5) NULL,
	[DutyCode] [varchar](1) NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[Description] [varchar](4000) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFIPC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFIPC](
	[PortCode] [varchar](5) NULL,
	[PortName] [varchar](125) NULL,
	[CountryCode] [varchar](2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFPVC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFPVC](
	[PrivCode] [varchar](3) NULL,
	[PrivDesc] [varchar](255) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[Description] [varchar](4000) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFPVL]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFPVL](
	[TariffClass] [varchar](12) NULL,
	[TariffSeq] [varchar](5) NULL,
	[CountryCode] [varchar](2) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[TGRLEV] [varchar](3) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFSSG]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFSSG](
	[TGRLEV] [varchar](3) NULL,
	[TGYear] [smallint] NULL,
	[PermitQty] [float] NULL,
	[PermitQtyRmn] [float] NULL,
	[QtyUnit] [varchar](3) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFTRC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFTRC](
	[TariffClass] [varchar](12) NULL,
	[TariffDescThai] [varchar](4000) NULL,
	[TariffDescEng] [varchar](4000) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_REFTRS]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_REFTRS](
	[TariffClass] [varchar](12) NULL,
	[StatCode] [varchar](3) NULL,
	[StatDescThai] [varchar](4000) NULL,
	[StatDescEng] [varchar](4000) NULL,
	[UnitCode] [varchar](3) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Register]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Register](
	[TaxNumber] [varchar](10) NULL,
	[LtdNameEng] [varchar](70) NULL,
	[LtdNameThai] [varchar](70) NULL,
	[MgrSeq] [smallint] NULL,
	[AddrSeq] [smallint] NULL,
	[EDIUserID] [varchar](8) NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFARS]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFARS](
	[AreaCode] [varchar](5) NOT NULL,
	[AreaName] [varchar](70) NULL,
	[AccNo] [varchar](10) NULL,
	[Payee] [varchar](10) NULL,
	[BankCode] [varchar](5) NULL,
	[AcType] [varchar](1) NULL,
 CONSTRAINT [pk_customsPort] PRIMARY KEY CLUSTERED 
(
	[AreaCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFATA]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFATA](
	[CTYATA] [varchar](2) NULL,
	[CUNCDE01] [smallint] NULL,
	[CUNCDE02] [smallint] NULL,
	[CUNCDE03] [smallint] NULL,
	[CUNCDE04] [smallint] NULL,
	[CUNCDE05] [smallint] NULL,
	[CUNCDE06] [smallint] NULL,
	[CUNCDE07] [smallint] NULL,
	[CUNCDE08] [smallint] NULL,
	[CUNCDE09] [smallint] NULL,
	[CUNCDE10] [smallint] NULL,
	[CUNCDE11] [smallint] NULL,
	[CUNCDE12] [smallint] NULL,
	[CUNCDE13] [smallint] NULL,
	[CUNCDE14] [smallint] NULL,
	[CUNNME01] [varchar](50) NULL,
	[CUNNME02] [varchar](50) NULL,
	[CUNNME03] [varchar](50) NULL,
	[CUNNME04] [varchar](50) NULL,
	[CUNNME05] [varchar](50) NULL,
	[CUNNME06] [varchar](50) NULL,
	[CUNNME07] [varchar](50) NULL,
	[CUNNME08] [varchar](50) NULL,
	[CUNNME09] [varchar](50) NULL,
	[CUNNME10] [varchar](50) NULL,
	[CUNNME11] [varchar](50) NULL,
	[CUNNME12] [varchar](50) NULL,
	[CUNNME13] [varchar](50) NULL,
	[CUNNME14] [varchar](50) NULL,
	[AGM01] [varchar](1) NULL,
	[AGM02] [varchar](1) NULL,
	[AGM03] [varchar](1) NULL,
	[AGM04] [varchar](1) NULL,
	[AGM05] [varchar](1) NULL,
	[AGM06] [varchar](1) NULL,
	[AGM07] [varchar](1) NULL,
	[AGM08] [varchar](1) NULL,
	[AGM09] [varchar](1) NULL,
	[AGM10] [varchar](1) NULL,
	[AGM11] [varchar](1) NULL,
	[AGM12] [varchar](1) NULL,
	[AGM13] [varchar](1) NULL,
	[AGM14] [varchar](1) NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](50) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFBFM]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFBFM](
	[TaxNumber] [varchar](10) NULL,
	[Code] [varchar](20) NULL,
	[Parent] [varchar](40) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[Desc1] [varchar](50) NULL,
	[Desc2] [varchar](50) NULL,
	[Desc3] [varchar](50) NULL,
	[Desc4] [varchar](50) NULL,
	[UID] [varchar](6) NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFBOI]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFBOI](
	[BOINumber] [varchar](7) NULL,
	[BOI_Expand] [varchar](30) NULL,
	[IssuedDate] [datetime] NULL,
	[RefNumber] [varchar](10) NULL,
	[TaxNumber1] [varchar](10) NULL,
	[TaxNumber2] [varchar](10) NULL,
	[TaxNumber3] [varchar](10) NULL,
	[TaxNumber4] [varchar](10) NULL,
	[MachineEffDate] [datetime] NULL,
	[MachineExpDate] [datetime] NULL,
	[RawMatEffDate] [datetime] NULL,
	[RawMatExpDate] [datetime] NULL,
	[GoodType1] [float] NULL,
	[GoodType2] [float] NULL,
	[GoodType3] [float] NULL,
	[UID] [varchar](6) NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFBQT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFBQT](
	[BOIQTANUM] [varchar](10) NULL,
	[DTEISU] [datetime] NULL,
	[BOIQTATYP] [smallint] NULL,
	[BOIEMTRTE] [float] NULL,
	[CAT] [varchar](1) NULL,
	[CMPTAXNUM1] [varchar](10) NULL,
	[CMPTAXNUM2] [varchar](10) NULL,
	[CMPTAXNUM3] [varchar](10) NULL,
	[CMPTAXNUM4] [varchar](10) NULL,
	[REFBQTNUM] [varchar](10) NULL,
	[DTEREFBQT] [datetime] NULL,
	[IVCNUM1] [varchar](35) NULL,
	[DTEIVC1] [datetime] NULL,
	[IVCNUM2] [varchar](35) NULL,
	[DTEIVC2] [datetime] NULL,
	[IVCNUM3] [varchar](35) NULL,
	[DTEIVC3] [datetime] NULL,
	[IVCNUM4] [varchar](35) NULL,
	[DTEIVC4] [datetime] NULL,
	[BOINUM1] [varchar](7) NULL,
	[DTEBOI1] [datetime] NULL,
	[BOINUM2] [varchar](7) NULL,
	[DTEBOI2] [datetime] NULL,
	[BOINUM3] [varchar](7) NULL,
	[DTEBOI3] [datetime] NULL,
	[BOINUM4] [varchar](7) NULL,
	[DTEBOI4] [datetime] NULL,
	[DTEEFV] [datetime] NULL,
	[DTEEPR] [varchar](50) NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFCEP]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFCEP](
	[TRFCLS] [varchar](7) NULL,
	[CEPCDE] [varchar](3) NULL,
	[TRFSEQ] [varchar](2) NULL,
	[DSCTRS1] [varchar](60) NULL,
	[DSCTRS2] [varchar](60) NULL,
	[DSCTRS3] [varchar](60) NULL,
	[DSCTRS4] [varchar](60) NULL,
	[DSCTRS5] [varchar](60) NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DTYRTE1] [float] NULL,
	[DTYRTE2] [float] NULL,
	[BNAGM] [varchar](1) NULL,
	[IDAGM] [varchar](1) NULL,
	[LAAGM] [varchar](1) NULL,
	[MYAGM] [varchar](1) NULL,
	[MMAGM] [varchar](1) NULL,
	[PHAGM] [varchar](1) NULL,
	[SGAGM] [varchar](1) NULL,
	[VNAGM] [varchar](1) NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL,
	[KHAGM] [varchar](1) NULL,
	[DTYSPE1] [float] NULL,
	[DTYSPE2] [float] NULL,
	[DTYCDE] [varchar](1) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFCKD]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFCKD](
	[CKDAPRNUM] [varchar](8) NULL,
	[BANNME] [varchar](20) NULL,
	[PRDATB1] [varchar](35) NULL,
	[PRDCDE] [varchar](20) NULL,
	[CMPTAXNUM] [varchar](10) NULL,
	[CMPBRN] [varchar](4) NULL,
	[PRTTYP] [varchar](50) NULL,
	[CKDSEQNUM] [int] NULL,
	[QTYPERUNT] [smallint] NULL,
	[DPMIDT] [varchar](8) NULL,
	[JOBTYP] [varchar](2) NULL,
	[CKDPRTNME] [varchar](50) NULL,
	[PRTNTE] [varchar](50) NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFCTR]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFCTR](
	[TariffClass] [varchar](7) NULL,
	[TariffSeq] [varchar](2) NULL,
	[CompensationRate] [float] NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFDCT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFDCT](
	[Type] [varchar](3) NOT NULL,
	[Description] [varchar](50) NULL,
	[Category] [varchar](1) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [pk_declareType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFDRT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFDRT](
	[TRFCLS] [varchar](12) NULL,
	[TRFSEQ] [varchar](5) NULL,
	[DTYCDE] [varchar](1) NULL,
	[DTYYRTE] [float] NULL,
	[DTYSPE] [float] NULL,
	[SPECDE] [varchar](3) NULL,
	[ANONUM] [varchar](10) NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DSCTRS1] [varchar](60) NULL,
	[DSCTRS2] [varchar](60) NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFDTB]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFDTB](
	[DTBUNTCDE] [varchar](6) NULL,
	[DTBCST] [float] NULL,
	[SUBUNTCDE] [varchar](3) NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFECS]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFECS](
	[ECSNUM] [varchar](8) NULL,
	[DTESTR] [datetime] NULL,
	[ECSCDE] [varchar](1) NULL,
	[ECSRTE] [float] NULL,
	[ECSSPE] [float] NULL,
	[SPECDE] [varchar](3) NULL,
	[CALAVRCDE] [varchar](1) NULL,
	[CALSPE] [varchar](1) NULL,
	[DIFCDE] [varchar](1) NULL,
	[CST] [float] NULL,
	[ANONUM] [varchar](10) NULL,
	[DTEANO] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFECU]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFECU](
	[CurrencyCode] [varchar](3) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFEDR]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFEDR](
	[TariffClass] [varchar](12) NULL,
	[TariffSeq] [varchar](5) NULL,
	[DutyCode] [varchar](1) NULL,
	[AdDutyRate] [float] NULL,
	[SpecDutyRate] [float] NULL,
	[SpecCode] [varchar](3) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFERT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFERT](
	[ERT] [float] NULL,
	[CSTWHLCL] [float] NULL,
	[CSTWOLCL] [float] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFETB]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFETB](
	[ETBNUM] [varchar](4) NULL,
	[ETBNME] [varchar](35) NULL,
	[CMPTAXNUM] [varchar](10) NULL,
	[CMPBRN] [varchar](4) NULL,
	[ADR1] [varchar](70) NULL,
	[ADR2] [varchar](70) NULL,
	[PHN] [varchar](15) NULL,
	[FAXNUM] [varchar](15) NULL,
	[ETBOFRNME] [varchar](35) NULL,
	[ETBFACCDE] [varchar](2) NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[UIDCTEAMN] [varchar](6) NULL,
	[DTECTEAMN] [datetime] NULL,
	[TMECTEAMN] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFEXP]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFEXP](
	[ExportTariff] [varchar](12) NULL,
	[TariffSeq] [varchar](5) NULL,
	[DutyCode] [varchar](1) NULL,
	[DutyRate] [float] NULL,
	[DutyRateS] [float] NULL,
	[SpecCode] [varchar](3) NULL,
	[Description] [varchar](4000) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFFCU]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFFCU](
	[CurrencyCode] [varchar](3) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFFMU]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFFMU](
	[FormulaNo] [varchar](10) NULL,
	[TaxNumber] [varchar](50) NULL,
	[Parent] [varchar](40) NULL,
	[Desc1] [varchar](50) NULL,
	[Desc2] [varchar](50) NULL,
	[Desc3] [varchar](50) NULL,
	[Desc4] [varchar](50) NULL,
	[Desc5] [varchar](50) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[UID] [varchar](6) NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFGTY]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFGTY](
	[GoodsType] [float] NULL,
	[Description] [varchar](60) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[UID] [varchar](6) NULL,
	[RecDate] [datetime] NULL,
	[RecTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFICC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFICC](
	[CountryCode] [varchar](2) NULL,
	[CountryName] [varchar](35) NULL,
	[CurrencyCode] [varchar](3) NULL,
	[WTOCountry] [varchar](1) NULL,
	[Continent] [varchar](2) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFICD]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFICD](
	[PortCode] [varchar](3) NULL,
	[PortName] [varchar](35) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFICU]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFICU](
	[CurrencyCode] [varchar](3) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[ExchangeRate] [float] NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFIPC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFIPC](
	[PortCode] [varchar](3) NOT NULL,
	[PortName] [varchar](35) NULL,
	[CountryCode] [varchar](3) NOT NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
 CONSTRAINT [pk_interport] PRIMARY KEY CLUSTERED 
(
	[PortCode] ASC,
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFIPN]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFIPN](
	[MICode] [varchar](2) NULL,
	[Message1] [varchar](50) NULL,
	[Message2] [varchar](50) NULL,
	[Message3] [varchar](50) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFPMG]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFPMG](
	[TariffClass] [varchar](7) NULL,
	[TariffCode] [varchar](3) NULL,
	[PermissionGT] [varchar](2) NULL,
	[PermitIssue] [varchar](10) NULL,
	[GoodsDesc1] [varchar](50) NULL,
	[GoodsDesc2] [varchar](50) NULL,
	[GoodsDesc3] [varchar](50) NULL,
	[GoodsDesc4] [varchar](50) NULL,
	[AnnounceNo] [varchar](10) NULL,
	[AnnounceDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[CreateID] [varchar](6) NULL,
	[CreateDate] [datetime] NULL,
	[CreateTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFPMS]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFPMS](
	[PermitID] [varchar](15) NULL,
	[PermitIssue] [varchar](10) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[TaxNumber] [varchar](10) NULL,
	[TariffClass] [varchar](7) NULL,
	[InvoiceNumber] [varchar](17) NULL,
	[InvoiceDate] [datetime] NULL,
	[PermitDesc1] [varchar](50) NULL,
	[PermitDesc2] [varchar](50) NULL,
	[LastUpdate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFTRC]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFTRC](
	[TariffClass] [varchar](12) NULL,
	[CompIndicator] [varchar](1) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[VatRate] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFTRS]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFTRS](
	[TariffClass] [varchar](12) NULL,
	[TariffStatCode] [varchar](3) NULL,
	[GoodsUnitCode] [varchar](3) NULL,
	[Desc1] [varchar](60) NULL,
	[Desc2] [varchar](60) NULL,
	[Desc3] [varchar](60) NULL,
	[Desc4] [varchar](60) NULL,
	[Desc5] [varchar](60) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[LastUpDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFUNT]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFUNT](
	[Code] [varchar](3) NULL,
	[TName] [varchar](35) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_RFWTO]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_RFWTO](
	[TRFCLS] [varchar](7) NULL,
	[TRFSEQ] [varchar](2) NULL,
	[DTYCDE] [varchar](1) NULL,
	[DTYYRTE] [float] NULL,
	[DTYSPE] [float] NULL,
	[SPECDE] [varchar](3) NULL,
	[ANONUM] [varchar](10) NULL,
	[DTEANO] [datetime] NULL,
	[DTESTR] [datetime] NULL,
	[DTEFIN] [datetime] NULL,
	[DSCTRS1] [varchar](60) NULL,
	[DSCTRS2] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_ServUnitType]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_ServUnitType](
	[UnitType] [varchar](10) NOT NULL,
	[UName] [varchar](50) NULL,
	[EName] [varchar](50) NULL,
	[IsCTNUnit] [int] NULL,
 CONSTRAINT [pk_servunit] PRIMARY KEY CLUSTERED 
(
	[UnitType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_TaxCode]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_TaxCode](
	[TaxNumber] [varchar](15) NULL,
	[TName] [varchar](100) NULL,
	[Address1] [varchar](70) NULL,
	[Address2] [varchar](70) NULL,
	[Phone] [varchar](30) NULL,
	[FaxNumber] [varchar](30) NULL,
	[QuotaAmount] [float] NULL,
	[SkipCoSlip] [int] NULL,
	[UsedAmount] [float] NULL,
	[Status] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_User]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_User](
	[UserID] [varchar](10) NOT NULL,
	[UPassword] [varchar](70) NULL,
	[TName] [varchar](70) NULL,
	[EName] [varchar](70) NULL,
	[TPosition] [varchar](50) NULL,
	[LoginDate] [datetime] NULL,
	[LoginTime] [datetime] NULL,
	[LogoutDate] [datetime] NULL,
	[LogoutTime] [datetime] NULL,
	[UPosition] [smallint] NULL,
	[MaxRateDisc] [float] NULL,
	[MaxAdvance] [float] NULL,
	[JobAuthorize] [varchar](20) NULL,
	[EMail] [varchar](50) NULL,
	[MobilePhone] [varchar](10) NULL,
	[IsAlertByAgent] [tinyint] NULL,
	[IsAlertByEMail] [tinyint] NULL,
	[IsAlertBySMS] [tinyint] NULL,
	[UserUpline] [varchar](10) NULL,
	[GLAccountCode] [varchar](15) NULL,
	[UsedLanguage] [varchar](2) NULL,
	[DMailAccount] [varchar](50) NULL,
	[DMailPassword] [varchar](50) NULL,
	[JobPolicy] [varchar](255) NULL,
	[AlertPolicy] [varchar](255) NULL,
 CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserAuth]    Script Date: 17/05/2019 13:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_UserAuth](
	[UserID] [varchar](50) NULL,
	[AppID] [varchar](255) NULL,
	[MenuID] [varchar](255) NULL,
	[Author] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserRole]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_UserRole](
	[RoleID] [varchar](50) NOT NULL,
	[RoleDesc] [nvarchar](255) NOT NULL,
	[RoleGroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserRoleDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_UserRoleDetail](
	[RoleID] [varchar](50) NOT NULL,
	[UserID] [varchar](10) NOT NULL,
 CONSTRAINT [PK_RoleDetail] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserRolePolicy]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_UserRolePolicy](
	[RoleID] [varchar](50) NOT NULL,
	[ModuleID] [varchar](50) NOT NULL,
	[Author] [varchar](10) NULL,
 CONSTRAINT [PK_RolePolicy] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Vender]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Vender](
	[VenCode] [varchar](50) NOT NULL,
	[BranchCode] [varchar](10) NULL,
	[TaxNumber] [varchar](30) NULL,
	[Title] [varchar](15) NULL,
	[TName] [varchar](120) NULL,
	[English] [varchar](120) NULL,
	[TAddress1] [varchar](150) NULL,
	[TAddress2] [varchar](150) NULL,
	[EAddress1] [varchar](150) NULL,
	[EAddress2] [varchar](150) NULL,
	[Phone] [varchar](30) NULL,
	[FaxNumber] [varchar](30) NULL,
	[LoginName] [varchar](20) NULL,
	[LoginPassword] [varchar](20) NULL,
	[GLAccountCode] [varchar](15) NULL,
	[ContactAcc] [varchar](150) NULL,
	[ContactSale] [varchar](150) NULL,
	[ContactSupport1] [varchar](150) NULL,
	[ContactSupport2] [varchar](150) NULL,
	[ContactSupport3] [varchar](150) NULL,
	[WEB_SITE] [varchar](255) NULL,
 CONSTRAINT [pk_vender] PRIMARY KEY CLUSTERED 
(
	[VenCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Vessel]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Vessel](
	[RegsNumber] [varchar](17) NULL,
	[TName] [varchar](35) NULL,
	[VesselType] [varchar](1) NULL,
	[OTNumber] [varchar](10) NULL,
	[CompanyBranch] [varchar](4) NULL,
	[NCountry] [varchar](2) NULL,
	[CargoType] [varchar](50) NULL,
	[TICount] [varchar](3) NULL,
	[RiskRating] [varchar](2) NULL,
	[TareTonnage] [varchar](6) NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NSM$]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NSM$](
	[SICode] [nvarchar](255) NULL,
	[NameThai] [nvarchar](255) NULL,
	[NameEng] [nvarchar](255) NULL,
	[SICode1] [nvarchar](255) NULL,
	[StdPrice] [float] NULL,
	[UnitCharge] [nvarchar](255) NULL,
	[CurrencyCode] [nvarchar](255) NULL,
	[DefaultVender] [nvarchar](255) NULL,
	[ProcessDesc] [nvarchar](255) NULL,
	[GLAccountCode Sales] [float] NULL,
	[GLAccountCode Cost] [float] NULL,
	[IsTaxCharge] [float] NULL,
	[Is50Tavi] [float] NULL,
	[Rate50Tavi] [float] NULL,
	[IsCredit] [float] NULL,
	[IsExpense] [float] NULL,
	[IsShowPrice] [float] NULL,
	[IsHaveSlip] [float] NULL,
	[IsPay50TaviTo] [float] NULL,
	[IsLtdAdv50Tavi] [float] NULL,
	[IsUsedCoSlip] [float] NULL,
	[F22] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tracking1]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking1](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking2]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking2](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking3]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking3](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking4]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking4](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking5]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking5](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking6]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking6](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking7]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking7](
	[BranchCode] [varchar](3) NULL,
	[JNo] [varchar](15) NULL,
	[JRevise] [tinyint] NULL,
	[ConfirmDate] [datetime] NULL,
	[CPolicyCode] [varchar](10) NULL,
	[DocDate] [datetime] NULL,
	[CustCode] [varchar](15) NULL,
	[CustBranch] [varchar](4) NULL,
	[CustContactName] [varchar](100) NULL,
	[QNo] [varchar](15) NULL,
	[Revise] [smallint] NULL,
	[ManagerCode] [varchar](10) NULL,
	[CSCode] [varchar](10) NULL,
	[Description] [varchar](4000) NULL,
	[TRemark] [varchar](250) NULL,
	[JobStatus] [tinyint] NULL,
	[JobType] [tinyint] NULL,
	[ShipBy] [tinyint] NULL,
	[InvNo] [varchar](100) NULL,
	[InvTotal] [float] NULL,
	[InvProduct] [varchar](100) NULL,
	[InvCountry] [varchar](2) NULL,
	[InvFCountry] [varchar](2) NULL,
	[InvInterPort] [varchar](3) NULL,
	[InvProductQty] [float] NULL,
	[InvProductUnit] [varchar](3) NULL,
	[InvCurUnit] [varchar](3) NULL,
	[InvCurRate] [float] NULL,
	[ImExDate] [datetime] NULL,
	[BLNo] [varchar](40) NULL,
	[BookingNo] [varchar](50) NULL,
	[ClearPort] [varchar](5) NULL,
	[ClearPortNo] [varchar](15) NULL,
	[ClearDate] [datetime] NULL,
	[LoadDate] [datetime] NULL,
	[ForwarderCode] [varchar](10) NULL,
	[AgentCode] [varchar](5) NULL,
	[VesselName] [varchar](50) NULL,
	[ETDDate] [datetime] NULL,
	[ETADate] [datetime] NULL,
	[ETTime] [datetime] NULL,
	[FNetPrice] [varchar](50) NULL,
	[BNetPrice] [float] NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelProveDate] [datetime] NULL,
	[CancelProveTime] [datetime] NULL,
	[CloseJobDate] [datetime] NULL,
	[CloseJobTime] [datetime] NULL,
	[CloseJobBy] [varchar](10) NULL,
	[DeclareType] [varchar](3) NULL,
	[DeclareNumber] [varchar](20) NULL,
	[DeclareStatus] [varchar](1) NULL,
	[TyAuthorSp] [varchar](2) NULL,
	[Ty19BIS] [varchar](2) NULL,
	[TyClearTax] [varchar](2) NULL,
	[TyClearTaxReson] [varchar](50) NULL,
	[EstDeliverDate] [datetime] NULL,
	[EstDeliverTime] [datetime] NULL,
	[TotalContainer] [varchar](50) NULL,
	[DutyDate] [datetime] NULL,
	[DutyAmount] [float] NULL,
	[DutyCustPayOther] [varchar](30) NULL,
	[DutyCustPayChqAmt] [float] NULL,
	[DutyCustPayBankAmt] [float] NULL,
	[DutyCustPayEPAYAmt] [float] NULL,
	[DutyCustPayCardAmt] [float] NULL,
	[DutyCustPayCashAmt] [float] NULL,
	[DutyCustPayOtherAmt] [float] NULL,
	[DutyLtdPayOther] [varchar](30) NULL,
	[DutyLtdPayChqAmt] [float] NULL,
	[DutyLtdPayEPAYAmt] [float] NULL,
	[DutyLtdPayCashAmt] [float] NULL,
	[DutyLtdPayOtherAmt] [float] NULL,
	[ConfirmChqDate] [datetime] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[ShippingCmd] [varchar](70) NULL,
	[TotalGW] [float] NULL,
	[GWUnit] [varchar](3) NULL,
	[TSRequest] [tinyint] NULL,
	[ShipmentType] [tinyint] NULL,
	[ReadyToClearDate] [datetime] NULL,
	[Commission] [int] NULL,
	[CommPayTo] [varchar](100) NULL,
	[ProjectName] [varchar](100) NULL,
	[MVesselName] [varchar](50) NULL,
	[TotalNW] [float] NULL,
	[Measurement] [varchar](20) NULL,
	[CustRefNO] [varchar](50) NULL,
	[TotalQty] [varchar](50) NULL,
	[HAWB] [varchar](50) NULL,
	[MAWB] [varchar](50) NULL,
	[consigneecode] [varchar](50) NULL,
	[privilegests] [varchar](255) NULL,
	[CustID] [varchar](20) NULL,
	[Title] [varchar](15) NULL,
	[NameThai] [varchar](255) NULL,
	[NameEng] [varchar](255) NULL,
	[AreaName] [varchar](70) NULL,
	[CSName] [varchar](70) NULL,
	[SalesCode] [varchar](10) NULL,
	[ConsigneeName] [varchar](100) NULL,
	[ForwarderName] [varchar](120) NULL,
	[AgentName] [varchar](120) NULL,
	[TAddress1] [varchar](80) NULL,
	[TAddress2] [varchar](80) NULL,
	[EAddress1] [varchar](80) NULL,
	[EAddress2] [varchar](80) NULL,
	[SupportBy] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tracking8]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tracking8](
	[JobType] [tinyint] NULL,
	[ShippingEmp] [varchar](10) NULL,
	[AvgPoint] [int] NULL,
	[JobNo] [int] NULL,
	[TotalDay] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vJOB_DocAmount]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJOB_DocAmount] as SELECT DocNo,SUM(PaidAmount) AS DocAmount FROM dbo.Job_CashControlDoc GROUP BY DocNo


GO
/****** Object:  View [dbo].[qJob_BillHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_BillHeader]
AS
SELECT     a.BranchCode, a.DocNo, a.DocDate, a.JobNo, a.JobBillAmt, a.CustCode, a.CustBranch, a.BillToCustCode, a.BillToCustBranch, a.ContactName, a.EmpCode, 
                      a.PrintedBy, a.PrintedDate, a.PrintedTime, a.RefNo, a.VATRate, a.Tavi50Rate1, a.Tavi50Rate2, a.TaxInvNo, a.TaxInvDate, a.TotalAdvance, a.TotalCharge, 
                      a.TotalIsTaxCharge, a.TotalIs50Tavi1, a.TotalIs50Tavi2, a.TotalVAT, a.Total50Tavi1, a.Total50Tavi2, a.TotalCustAdv, a.TotalNet, a.BillDate, a.BillTime, a.BillAcceptNo, 
                      a.PayDate, a.PayTime, a.Remark1, a.Remark2, a.Remark3, a.Remark4, a.Remark5, a.Remark6, a.Remark7, a.Remark8, a.Remark9, a.Remark10, a.CancelReson, 
                      a.CancelProve, a.CancelDate, a.CancelTime, a.PaidFlag, a.ShippingRemark, a.CurrencyCode, a.ExchangeRate, a.ForeignAmt, b.BrName AS BranchName, 
                      a.CustCode + '-' + a.CustBranch AS CustID, c.NameThai AS CustTName, c.NameEng AS CustEName, c.LevelGrade, c.CreditLimit, d.JobType, d.ShipBy, d.JobStatus, 
                      d.DocDate AS JobDate, e.DocAmount AS RcvAmount, d.DutyDate
FROM         dbo.Job_BillingHeader AS a LEFT OUTER JOIN
                      dbo.Mas_Branch AS b ON a.BranchCode = b.Code LEFT OUTER JOIN
                      dbo.Mas_Company AS c ON a.CustCode = c.CustCode AND a.CustBranch = c.Branch LEFT OUTER JOIN
                      dbo.Job_Order AS d ON a.BranchCode = d.BranchCode AND a.JobNo = d.JNo LEFT OUTER JOIN
                      dbo.vJOB_DocAmount AS e ON a.DocNo = e.DocNo


GO
/****** Object:  View [dbo].[qJob_BillDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_BillDetail]
AS
SELECT        dbo.Job_BillingHeader.BranchCode, dbo.Job_BillingHeader.DocNo, dbo.Job_BillingHeader.DocDate, dbo.Job_BillingHeader.JobNo, dbo.Job_BillingHeader.JobBillAmt, dbo.Job_BillingHeader.CustCode, 
                         dbo.Job_BillingHeader.CustBranch, dbo.Job_BillingHeader.BillToCustCode, dbo.Job_BillingHeader.BillToCustBranch, dbo.Job_BillingHeader.ContactName, dbo.Job_BillingHeader.EmpCode, dbo.Job_BillingHeader.PrintedBy, 
                         dbo.Job_BillingHeader.PrintedDate, dbo.Job_BillingHeader.PrintedTime, dbo.Job_BillingHeader.RefNo, dbo.Job_BillingHeader.VATRate, dbo.Job_BillingHeader.Tavi50Rate1, dbo.Job_BillingHeader.Tavi50Rate2, 
                         dbo.Job_BillingHeader.TaxInvNo, dbo.Job_BillingHeader.TaxInvDate, dbo.Job_BillingHeader.TotalAdvance, dbo.Job_BillingHeader.TotalCharge, dbo.Job_BillingHeader.TotalIsTaxCharge, dbo.Job_BillingHeader.TotalIs50Tavi1, 
                         dbo.Job_BillingHeader.TotalIs50Tavi2, dbo.Job_BillingHeader.TotalVAT, dbo.Job_BillingHeader.Total50Tavi1, dbo.Job_BillingHeader.Total50Tavi2, dbo.Job_BillingHeader.TotalCustAdv, dbo.Job_BillingHeader.TotalNet, 
                         dbo.Job_BillingHeader.BillDate, dbo.Job_BillingHeader.BillTime, dbo.Job_BillingHeader.BillAcceptNo, dbo.Job_BillingHeader.PayDate, dbo.Job_BillingHeader.PayTime, dbo.Job_BillingHeader.Remark1, 
                         dbo.Job_BillingHeader.Remark2, dbo.Job_BillingHeader.Remark3, dbo.Job_BillingHeader.Remark4, dbo.Job_BillingHeader.Remark5, dbo.Job_BillingHeader.Remark6, dbo.Job_BillingHeader.Remark7, 
                         dbo.Job_BillingHeader.Remark8, dbo.Job_BillingHeader.Remark9, dbo.Job_BillingHeader.Remark10, dbo.Job_BillingHeader.CancelReson, dbo.Job_BillingHeader.CancelProve, dbo.Job_BillingHeader.CancelDate, 
                         dbo.Job_BillingHeader.CancelTime, dbo.Job_BillingHeader.PaidFlag, dbo.Job_BillingHeader.ShippingRemark, dbo.Job_BillingHeader.CurrencyCode, dbo.Job_BillingHeader.ExchangeRate, dbo.Job_BillingHeader.ForeignAmt, 
                         dbo.Job_BillingDetail.ItemNo, dbo.Job_BillingDetail.SICode, dbo.Job_BillingDetail.SDescription, dbo.Job_BillingDetail.ExpSlipNO, dbo.Job_BillingDetail.SRemark, dbo.Job_BillingDetail.QtyUnit, 
                         dbo.Job_BillingDetail.IsTaxCharge, dbo.Job_BillingDetail.Is50Tavi, dbo.Job_BillingDetail.Rate50Tavi, dbo.Job_BillingDetail.AmtAdvance, dbo.Job_BillingDetail.AmtCharge, dbo.Job_Order.InvNo, dbo.Job_Order.InvProduct, 
                         dbo.Job_Order.VesselName, dbo.Job_Order.ETADate, dbo.Job_Order.ETDDate, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, 
                         dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Job_Order.DeclareNumber, dbo.Job_BillingDetail.ForeignAmt AS DForeignAmt, 
                         dbo.Job_BillingDetail.CurrencyCode AS DCurrencyCode, dbo.Job_BillingDetail.ExchangeRate AS DExchangeRate, dbo.Job_BillingDetail.DiscountPerc, dbo.Job_BillingDetail.AmtDiscount, dbo.Job_BillingDetail.ForeignDisc, 
                         dbo.Job_BillingDetail.FUnitPrice, dbo.Job_BillingDetail.FQty, dbo.Job_BillingDetail.FTotalAmt, dbo.Mas_Company.TaxNumber, dbo.Job_BillingDetail.CurrencyCodeCredit, dbo.Job_BillingDetail.ExchangeRateCredit, 
                         dbo.Job_BillingDetail.ForeignAmtCredit, dbo.Job_SrvSingle.ProcessDesc, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_Order.BLNo, dbo.Job_Order.BookingNo, 
                         dbo.Job_Order.ClearPortNo, dbo.Job_Order.InvTotal, dbo.Job_Order.InvCountry, dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, 
                         dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.ClearPort, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.LoadDate, dbo.Job_Order.ClearDate, dbo.Job_Order.TotalContainer, 
                         dbo.Job_Order.ShippingCmd, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.ProjectName, dbo.Job_Order.MVesselName, dbo.Job_Order.Commission, dbo.Job_Order.TotalNW, dbo.Job_Order.Measurement, 
                         dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, dbo.Job_Order.MAWB, dbo.Mas_User.TName AS EmpName
FROM            dbo.Mas_User RIGHT OUTER JOIN
                         dbo.Job_BillingHeader ON dbo.Mas_User.UserID = dbo.Job_BillingHeader.EmpCode LEFT OUTER JOIN
                         dbo.Job_SrvSingle INNER JOIN
                         dbo.Job_BillingDetail ON dbo.Job_SrvSingle.SICode = dbo.Job_BillingDetail.SICode ON dbo.Job_BillingHeader.BranchCode = dbo.Job_BillingDetail.BranchCode AND 
                         dbo.Job_BillingHeader.DocNo = dbo.Job_BillingDetail.DocNo LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_BillingHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_BillingHeader.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.Job_BillingHeader.BillToCustBranch = dbo.Mas_Company.Branch




GO
/****** Object:  View [dbo].[qrpt_TaxInvFristStep]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_TaxInvFristStep]
AS
SELECT     BranchCode, TaxInvNo, ISNULL(SUM(AmtAdvance), 0) AS Reimbuse, ISNULL(SUM(AmtCharge), 0) AS Services, ISNULL(IsTaxCharge, 0) 
                      AS IsTaxCharge, ISNULL(VATRate, 0) AS VATRate, ISNULL(Is50Tavi, 0) AS Is50Tavi, ISNULL(Rate50Tavi, 0) AS Rate50Tavi, ProcessDesc, 
                      CancelReson
FROM         dbo.qJob_BillDetail
GROUP BY BranchCode, AmtCharge, IsTaxCharge, VATRate, Is50Tavi, Rate50Tavi, TaxInvNo, ProcessDesc, CancelReson




GO
/****** Object:  View [dbo].[qrpt_TaxInvSecondStep]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_TaxInvSecondStep]
AS
SELECT     BranchCode, TaxInvNo, DocNo, ISNULL(SUM(AmtAdvance), 0) AS Reimbuse, ISNULL(SUM(AmtCharge), 0) AS Services, ISNULL(IsTaxCharge, 0) 
                      AS IsTaxCharge, ISNULL(VATRate, 0) AS VATRate, ISNULL(Is50Tavi, 0) AS Is50Tavi, ISNULL(Rate50Tavi, 0) AS Rate50Tavi, ProcessDesc, 
                      CancelReson
FROM         dbo.qJob_BillDetail
GROUP BY BranchCode, AmtCharge, IsTaxCharge, VATRate, Is50Tavi, Rate50Tavi, TaxInvNo, ProcessDesc, CancelReson, DocNo




GO
/****** Object:  View [dbo].[Q_ProfitSales]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_ProfitSales]
AS
SELECT     dbo.qJob_BillDetail.GLAccountCodeSales, dbo.qJob_BillDetail.ProcessDesc, ROUND(SUM(dbo.qJob_BillDetail.AmtCharge), 2) AS SrvCharge, 
                      ROUND(SUM(dbo.qJob_BillDetail.AmtAdvance), 2) AS SrvAdvance, ROUND(SUM(dbo.qJob_BillDetail.AmtCharge + dbo.qJob_BillDetail.AmtAdvance), 2) AS TotalAmt, 
                      dbo.Job_Order.JNo
FROM         dbo.Job_Order INNER JOIN
                      dbo.qJob_BillDetail ON dbo.Job_Order.BranchCode = dbo.qJob_BillDetail.BranchCode AND dbo.Job_Order.JNo = dbo.qJob_BillDetail.JobNo
WHERE     (dbo.qJob_BillDetail.GLAccountCodeSales IS NOT NULL) AND (dbo.qJob_BillDetail.CancelReson = '') OR
                      (dbo.qJob_BillDetail.CancelReson IS NULL)
GROUP BY dbo.qJob_BillDetail.GLAccountCodeSales, dbo.qJob_BillDetail.ProcessDesc, dbo.Job_Order.JNo


GO
/****** Object:  View [dbo].[qJob_Detail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Detail]
AS
SELECT     dbo.Mas_Branch.Code AS BRCode, dbo.Mas_Branch.BrName, dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_Order.JRevise, dbo.Job_Order.ConfirmDate, 
                      dbo.Job_Order.CPolicyCode, dbo.Job_Order.DocDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.CustContactName, dbo.Job_Order.QNo, 
                      dbo.Job_Order.Revise, dbo.Job_Order.ManagerCode, dbo.Job_Order.CSCode, dbo.Job_Order.Description, dbo.Job_Order.TRemark, dbo.Job_Order.JobStatus, 
                      dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.InvNo, dbo.Job_Order.InvTotal, dbo.Job_Order.InvProduct, dbo.Job_Order.InvCountry, 
                      dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, dbo.Job_Order.InvProductQty, dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, 
                      dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.BLNo, dbo.Job_Order.BookingNo, dbo.Job_Order.ClearPort, dbo.Job_Order.ClearPortNo, 
                      dbo.Job_Order.ClearDate, dbo.Job_Order.LoadDate, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.VesselName, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.ETTime, dbo.Job_Order.FNetPrice, dbo.Job_Order.BNetPrice, dbo.Job_Order.CancelReson, dbo.Job_Order.CancelDate, 
                      dbo.Job_Order.CancelTime, dbo.Job_Order.CancelProve, dbo.Job_Order.CancelProveDate, dbo.Job_Order.CancelProveTime, dbo.Job_Order.CloseJobDate, 
                      dbo.Job_Order.CloseJobTime, dbo.Job_Order.CloseJobBy, dbo.Job_Order.DeclareType, dbo.Job_Order.DeclareNumber, dbo.Job_Order.DeclareStatus, 
                      dbo.Job_Order.TyAuthorSp, dbo.Job_Order.Ty19BIS, dbo.Job_Order.TyClearTax, dbo.Job_Order.TyClearTaxReson, dbo.Job_Order.EstDeliverDate, 
                      dbo.Job_Order.EstDeliverTime, dbo.Job_Order.TotalContainer, dbo.Job_Order.DutyDate, dbo.Job_Order.DutyAmount, dbo.Job_Order.DutyCustPayOther, 
                      dbo.Job_Order.DutyCustPayChqAmt, dbo.Job_Order.DutyCustPayBankAmt, dbo.Job_Order.DutyCustPayEPAYAmt, dbo.Job_Order.DutyCustPayCardAmt, 
                      dbo.Job_Order.DutyCustPayCashAmt, dbo.Job_Order.DutyCustPayOtherAmt, dbo.Job_Order.DutyLtdPayOther, dbo.Job_Order.DutyLtdPayChqAmt, 
                      dbo.Job_Order.DutyLtdPayEPAYAmt, dbo.Job_Order.DutyLtdPayCashAmt, dbo.Job_Order.DutyLtdPayOtherAmt, dbo.Job_Order.ConfirmChqDate, 
                      dbo.Job_Order.ShippingEmp, dbo.Job_Order.ShippingCmd, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, dbo.Job_Order.TSRequest, dbo.Job_Order.ShipmentType, 
                      dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.Commission, dbo.Job_Order.CommPayTo, dbo.Job_Order.ProjectName, dbo.Job_Order.MVesselName, 
                      dbo.Job_Order.TotalNW, dbo.Job_Order.Measurement, dbo.Job_Order.CustRefNO, dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, dbo.Job_Order.MAWB, 
                      dbo.Job_Order.consigneecode, dbo.Job_Order.privilegests, dbo.Job_Detail.STCode, dbo.Job_Detail.SICode, dbo.Job_Detail.SDescription, dbo.Job_Detail.SRemark, 
                      dbo.Job_Detail.VenderCode, dbo.Job_Detail.VenderContact, dbo.Job_Detail.EmpCode, dbo.Job_Detail.Start, dbo.Job_Detail.CY, dbo.Job_Detail.Endding, 
                      dbo.Job_Detail.DNNo, dbo.Job_Detail.PdtType, dbo.Job_Detail.Qty, dbo.Job_Detail.UnitCode, dbo.Job_Detail.CurrencyCode, dbo.Job_Detail.CurRate, 
                      dbo.Job_Detail.FPrice, dbo.Job_Detail.BPrice, dbo.Job_Detail.QUnitPrice, dbo.Job_Detail.QFPrice, dbo.Job_Detail.QBPrice, dbo.Job_Detail.UnitCost, 
                      dbo.Job_Detail.FCost, dbo.Job_Detail.BCost, dbo.Job_Detail.Tax50Tavi, dbo.Job_Detail.BillExtn, dbo.Job_Detail.ChargeDate, dbo.Job_Detail.IsQuoItem, 
                      dbo.Job_Detail.ProductName, dbo.Job_Detail.AirQtyStep, dbo.Job_Detail.StepSub, dbo.Mas_Agent.TName AS AgentName, dbo.Mas_RFICC.CountryName, 
                      dbo.Mas_RFARS.AreaName, dbo.Mas_User.TName AS SalesName, dbo.Mas_Company.CustGroup, 
                      dbo.Mas_Company.Title + ' ' + dbo.Mas_Company.NameThai AS CustName, dbo.Mas_ServUnitType.IsCTNUnit, 
                      dbo.Job_Order.CustCode + '-' + dbo.Job_Order.CustBranch AS CustID, dbo.Job_Detail.RSlipNO, dbo.Job_Detail.ClearingNO, dbo.Job_SrvSingle.ProcessDesc, 
                      dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost
FROM         dbo.Job_SrvSingle INNER JOIN
                      dbo.Job_Detail ON dbo.Job_SrvSingle.SICode = dbo.Job_Detail.SICode RIGHT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_Detail.JNo = dbo.Job_Order.JNo AND dbo.Job_Detail.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                      dbo.Mas_Branch ON dbo.Job_Order.BranchCode = dbo.Mas_Branch.Code LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_Order.ManagerCode = dbo.Mas_User.UserID LEFT OUTER JOIN
                      dbo.Mas_Agent ON dbo.Job_Order.AgentCode = dbo.Mas_Agent.Code LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode LEFT OUTER JOIN
                      dbo.Mas_RFARS ON dbo.Job_Order.ClearPort = dbo.Mas_RFARS.AreaCode LEFT OUTER JOIN
                      dbo.Mas_RFICC ON dbo.Job_Order.InvCountry = dbo.Mas_RFICC.CountryCode LEFT OUTER JOIN
                      dbo.Mas_ServUnitType ON dbo.Job_Detail.UnitCode = dbo.Mas_ServUnitType.UnitType


GO
/****** Object:  View [dbo].[Q_ProfitCost]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_ProfitCost]
AS
SELECT     dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_SrvSingle.ProcessDesc, ISNULL(SUM(dbo.qJob_Detail.UnitCost), 0) AS AdvCost, dbo.Job_Order.JNo, 
                      dbo.qJob_Detail.SICode
FROM         dbo.Job_Order INNER JOIN
                      dbo.qJob_Detail ON dbo.Job_Order.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.Job_Order.JNo = dbo.qJob_Detail.JNo INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_Detail.SICode = dbo.Job_SrvSingle.SICode
GROUP BY dbo.Job_SrvSingle.GLAccountCodeCost, dbo.Job_SrvSingle.ProcessDesc, dbo.qJob_Detail.UnitCost, dbo.Job_Order.JNo, dbo.qJob_Detail.SICode


GO
/****** Object:  View [dbo].[Q_CostJoinProfit]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_CostJoinProfit]
AS
SELECT     dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, dbo.Job_Order.CPolicyCode, dbo.Job_Order.CSCode, 
                      dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, Mas_Customers.TaxNumber AS CustTaxNumber, Mas_Customers.NameEng AS CustName, 
                      Mas_Consignee.CustCode AS ConsignCode, Mas_Consignee.Branch AS ConsignBranch, Mas_Consignee.TaxNumber AS ConsignTaxNumber, 
                      Mas_Consignee.NameEng AS ConsignName, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, CONVERT(date, dbo.Job_Order.ETDDate) 
                      AS ETDDate, CONVERT(date, dbo.Job_Order.ETADate) AS ETADate, dbo.Job_Order.MAWB, dbo.Job_Order.HAWB,
                          (SELECT     COUNT(JobBillAmt) AS BiilingAmt
                            FROM          dbo.Job_BillingHeader
                            WHERE      (JobNo = dbo.Job_Order.JNo) AND (BranchCode = dbo.Job_Order.BranchCode)) AS LastBiiling,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_1
                            WHERE      (GLAccountCodeSales = '50000') AND (JNo = dbo.Job_Order.JNo)) AS Sales_DS,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_2
                            WHERE      (GLAccountCodeSales = '50010') AND (JNo = dbo.Job_Order.JNo)) AS Sales_DSR,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_3
                            WHERE      (GLAccountCodeSales = '50020') AND (JNo = dbo.Job_Order.JNo)) AS Sales_OS,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_4
                            WHERE      (GLAccountCodeSales = '50030') AND (JNo = dbo.Job_Order.JNo)) AS Sales_OSR,
                          (SELECT     ISNULL(SUM(TotalAmt), 0) AS Dee
                            FROM          dbo.Q_ProfitSales AS Q_ProfitSales_1
                            WHERE      (JNo = dbo.Job_Order.JNo)) AS SubTotal_Sales,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost
                            WHERE      (ProcessDesc = 'DS') AND (JNo = dbo.Job_Order.JNo)) AS Cost_DS,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_5
                            WHERE      (ProcessDesc = 'DSR') AND (JNo = dbo.Job_Order.JNo)) AS Cost_DSR,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_3
                            WHERE      (ProcessDesc = 'OS') AND (JNo = dbo.Job_Order.JNo)) AS Cost_OS,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS dsr
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_2
                            WHERE      (ProcessDesc = 'OSR') AND (JNo = dbo.Job_Order.JNo)) AS Cost_OSR,
                          (SELECT     ISNULL(SUM(AdvCost), 0) AS Dee
                            FROM          dbo.Q_ProfitCost AS Q_ProfitCost_1
                            WHERE      (JNo = dbo.Job_Order.JNo)) AS SubTotal_Cost, CONVERT(date, dbo.Job_Order.ConfirmDate) AS ConfirmDate
FROM         dbo.Mas_Company AS Mas_Customers INNER JOIN
                      dbo.Job_Order ON Mas_Customers.CustCode = dbo.Job_Order.CustCode AND Mas_Customers.Branch = dbo.Job_Order.CustBranch INNER JOIN
                      dbo.Mas_Company AS Mas_Consignee ON dbo.Job_Order.consigneecode = Mas_Consignee.CustCode


GO
/****** Object:  View [dbo].[qJob_ClearDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_ClearDetail] AS 
SELECT Job_ClearHeader.*, Job_ClearDetail.ItemNo, Job_ClearDetail.LinkItem, Job_ClearDetail.STCode, Job_ClearDetail.SICode, Job_ClearDetail.SDescription, Job_ClearDetail.VenderCode, Job_ClearDetail.Qty, Job_ClearDetail.UnitCode, Job_ClearDetail.CurrencyCode, Job_ClearDetail.CurRate, Job_ClearDetail.ChargeVAT, Job_ClearDetail.UnitPrice, Job_ClearDetail.FPrice, Job_ClearDetail.BPrice, Job_ClearDetail.QUnitPrice, Job_ClearDetail.QFPrice, Job_ClearDetail.QBPrice, Job_ClearDetail.UnitCost, Job_ClearDetail.FCost, Job_ClearDetail.BCost, Job_ClearDetail.Tax50Tavi, Job_ClearDetail.AdvNO, Job_ClearDetail.AdvAmount, Job_ClearDetail.UsedAmount, Job_ClearDetail.IsQuoItem, Job_ClearDetail.SlipNO, Job_ClearDetail.Remark, Job_ClearDetail.AirQtyStep, Job_ClearDetail.StepSub, Job_Order.CustCode, Job_Order.CustBranch, Mas_User.TName AS CSName, Mas_Company.NameThai AS CustName, Job_ClearDetail.Pay50TaviTo, Job_ClearDetail.NO50Tavi, Job_ClearDetail.Date50Tavi, Job_ClearDetail.VenderBillingNo, Job_ClearDetail.IsDuplicate, Job_ClearDetail.IsLtdAdv50Tavi, Job_ClearDetail.JobNo
FROM (((Job_ClearHeader LEFT JOIN Job_ClearDetail ON (Job_ClearHeader.ClrNo = Job_ClearDetail.ClrNo) AND (Job_ClearHeader.BranchCode = Job_ClearDetail.BranchCode)) LEFT JOIN Job_Order ON (Job_ClearHeader.JNo = Job_Order.JNo) AND (Job_ClearHeader.BranchCode = Job_Order.BranchCode)) LEFT JOIN Mas_User ON Job_ClearHeader.EmpCode = Mas_User.UserID) LEFT JOIN Mas_Company ON (Job_Order.CustBranch = Mas_Company.Branch) AND (Job_Order.CustCode = Mas_Company.CustCode)


GO
/****** Object:  View [dbo].[vAdv_Balance]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vAdv_Balance] AS SELECT  dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.PaymentDate, dbo.Job_AdvHeader.PaymentBy,dbo.Job_AdvHeader.AdvCash,dbo.Job_AdvHeader.AdvChqCash,dbo.Job_AdvHeader.AdvChq,dbo.Job_AdvHeader.AdvCash + dbo.Job_AdvHeader.AdvChqCash + dbo.Job_AdvHeader.AdvChq AS TotalAdvance,SUM(ISNULL(dbo.qJob_ClearDetail.UsedAmount, 0)) AS TotalClear, dbo.qJob_ClearDetail.DocStatus FROM         dbo.qJob_ClearDetail RIGHT OUTER JOIN dbo.Job_AdvHeader ON dbo.qJob_ClearDetail.AdvNO = dbo.Job_AdvHeader.AdvNo WHERE     (dbo.Job_AdvHeader.DocStatus <> 99) GROUP BY dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.PaymentDate,dbo.Job_AdvHeader.AdvCash , dbo.Job_AdvHeader.AdvChqCash ,dbo.Job_AdvHeader.AdvChq,dbo.Job_AdvHeader.PaymentBy,dbo.qJob_ClearDetail.DocStatus

GO
/****** Object:  View [dbo].[qJob_CashControl]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CashControl] AS 
SELECT Job_CashControl.*, Job_CashControlSub.ItemNo, Job_CashControlSub.PRVoucher, Job_CashControlSub.PRType, Job_CashControlSub.ChqNo, Job_CashControlSub.BookCode, Job_CashControlSub.BankCode, Job_CashControlSub.BankBranch, Mas_BankCode.BName AS BankName, Mas_BookAccount.BookName, Mas_BookAccount.BankCode AS BookBank, Mas_BookAccount.BankBranch AS BookBankBranch, Job_CashControlSub.ChqDate, Job_CashControlSub.CashAmount, Job_CashControlSub.ChqAmount, Job_CashControlSub.CreditAmount, Job_CashControlSub.IsLocal, Job_CashControlSub.ChqStatus, Job_CashControlSub.TRemark AS SRemark, Job_CashControlSub.PayChqTo, Mas_Branch.BrName, Mas_User.TName AS UserName
FROM ((((Job_CashControl LEFT JOIN Job_CashControlSub ON (Job_CashControl.ControlNo=Job_CashControlSub.ControlNo) AND (Job_CashControl.BranchCode=Job_CashControlSub.BranchCode)) LEFT JOIN Mas_BookAccount ON (Job_CashControlSub.BranchCode=Mas_BookAccount.BranchCode) AND (Job_CashControlSub.BookCode=Mas_BookAccount.BookCode)) LEFT JOIN Mas_Branch ON Job_CashControl.BranchCode=Mas_Branch.Code) LEFT JOIN Mas_BankCode ON Job_CashControlSub.BankCode=Mas_BankCode.Code) LEFT JOIN Mas_User ON Job_CashControl.RecUser=Mas_User.UserID


GO
/****** Object:  View [dbo].[Q_VouherStateTwo]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_VouherStateTwo]
AS
SELECT     dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.qJob_CashControl.PRVoucher, dbo.Job_CashControlDoc.DocNo, 
                      dbo.qJob_CashControl.PRType, ROUND(ISNULL(dbo.qJob_CashControl.CashAmount, 0), 2) AS CashAmount, 
                      ROUND(ISNULL(dbo.qJob_CashControl.ChqAmount, 0), 2) AS ChqAmount, ROUND(ISNULL(dbo.qJob_CashControl.CreditAmount, 0), 2) AS CreditAmount, 
                      ROUND(ISNULL(dbo.qJob_CashControl.CashAmount + dbo.qJob_CashControl.ChqAmount + dbo.qJob_CashControl.CreditAmount, 0), 2) 
                      AS PaymentTotal, ROUND(ISNULL(dbo.Job_CashControlDoc.TotalAmount, 0), 2) AS TotalDocAmt
FROM         dbo.qJob_CashControl INNER JOIN
                      dbo.Job_CashControlDoc ON dbo.qJob_CashControl.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                      dbo.qJob_CashControl.ControlNo = dbo.Job_CashControlDoc.ControlNo


GO
/****** Object:  View [dbo].[Q_PaymentRef]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_PaymentRef]
AS
SELECT     dbo.Job_CashControl.BranchCode, dbo.Job_CashControl.ControlNo, dbo.Job_CashControlSub.PRVoucher, dbo.Job_CashControl.VoucherDate, 
                      dbo.Job_CashControlDoc.DocNo, dbo.Job_CashControl.RecUser AS UserPvocher
FROM         dbo.Job_CashControl INNER JOIN
                      dbo.Job_CashControlSub ON dbo.Job_CashControl.BranchCode = dbo.Job_CashControlSub.BranchCode AND 
                      dbo.Job_CashControl.ControlNo = dbo.Job_CashControlSub.ControlNo INNER JOIN
                      dbo.Job_CashControlDoc ON dbo.Job_CashControlSub.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                      dbo.Job_CashControlSub.ControlNo = dbo.Job_CashControlDoc.ControlNo



GO
/****** Object:  View [dbo].[Q_VouherStateOne]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_VouherStateOne]
AS
SELECT     [BranchCode] AS BranchCode, [ClrNo] AS DocNo, [ClrDate] AS DocDate, [EmpCode] AS UserCode, [JNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      AdvTotal AS AdvAmt, isnull(TotalExpense, 0) AS UsedAmt
FROM         [Job_ClearHeader]
UNION
SELECT     [BranchCode] AS BranchCode, [AdvNo] AS DocNo, [AdvDate] AS DocDate, [EmpCode] AS UserCode, [JNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      isnull((TotalAdvance+TotalVAT)-Total50Tavi,0) AS AdvAmt, 0 AS UsedAmt
FROM         [Job_AdvHeader]
UNION
SELECT     [BranchCode] AS BranchCode, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [JobNo] AS JobNo, [CancelReson] AS IsDocCancel, 
                      0 AS AdvAmt, 0 AS UsedAmt
FROM         [Job_BillingHeader]


GO
/****** Object:  View [dbo].[Q_StatementAccount]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Q_StatementAccount]
AS
SELECT        dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.PRVoucher, CONVERT(date, dbo.Q_PaymentRef.VoucherDate) AS VoucherDate, CONVERT(date, dbo.Job_Order.ConfirmDate) 
                         AS JobStatusDate, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustBranch, dbo.Job_Order.CustCode, 
                         dbo.Q_VouherStateOne.JobNo, dbo.Q_PaymentRef.DocNo, dbo.Job_CashControlDoc.DocType, CONVERT(date, dbo.Q_VouherStateOne.DocDate) AS DocDate, dbo.Q_VouherStateOne.IsDocCancel, 
                         dbo.Q_PaymentRef.UserPvocher, dbo.qJob_CashControl.BookCode, dbo.qJob_CashControl.PRType, ROUND(ISNULL(SUM(dbo.Q_VouherStateOne.AdvAmt), 0), 2) AS AdvanceAmt, 
                         ROUND(ISNULL(SUM(dbo.Q_VouherStateOne.UsedAmt), 0), 2) AS ClearingAmt, ISNULL
                             ((SELECT        ISNULL(SUM(TotalDocAmt), 0) AS A
                                 FROM            dbo.Q_VouherStateTwo
                                 WHERE        (ControlNo = dbo.Q_PaymentRef.ControlNo) AND (DocNo = dbo.Q_PaymentRef.DocNo) AND (PRType = 'P')), 0) AS TotalPayMent, ISNULL
                             ((SELECT        ISNULL(SUM(TotalDocAmt), 0) AS A
                                 FROM            dbo.Q_VouherStateTwo AS Q_VouherStateTwo_1
                                 WHERE        (ControlNo = dbo.Q_PaymentRef.ControlNo) AND (DocNo = dbo.Q_PaymentRef.DocNo) AND (PRType = 'R')), 0) AS TotalRecieve, CONVERT(date, dbo.qJob_CashControl.ChqDate) AS DEPODate, 
                         dbo.Mas_BookAccount.BookName, dbo.Mas_BookAccount.BankCode, dbo.Mas_BookAccount.BankBranch, dbo.Mas_BookAccount.ACType
FROM            dbo.qJob_CashControl INNER JOIN
                         dbo.Q_PaymentRef ON dbo.qJob_CashControl.ControlNo = dbo.Q_PaymentRef.ControlNo AND dbo.qJob_CashControl.BranchCode = dbo.Q_PaymentRef.BranchCode INNER JOIN
                         dbo.Q_VouherStateOne ON dbo.Q_PaymentRef.BranchCode = dbo.Q_VouherStateOne.BranchCode AND dbo.Q_PaymentRef.DocNo = dbo.Q_VouherStateOne.DocNo INNER JOIN
                         dbo.Job_Order ON dbo.Q_VouherStateOne.BranchCode = dbo.Job_Order.BranchCode AND dbo.Q_VouherStateOne.JobNo = dbo.Job_Order.JNo INNER JOIN
                         dbo.Job_CashControlDoc ON dbo.Q_PaymentRef.BranchCode = dbo.Job_CashControlDoc.BranchCode AND dbo.Q_PaymentRef.DocNo = dbo.Job_CashControlDoc.DocNo INNER JOIN
                         dbo.Mas_BookAccount ON dbo.qJob_CashControl.BookCode = dbo.Mas_BookAccount.BookCode
WHERE        (dbo.qJob_CashControl.CancelReson = '')
GROUP BY dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.ControlNo, dbo.Q_PaymentRef.DocNo, dbo.qJob_CashControl.BranchCode, dbo.qJob_CashControl.ControlNo, dbo.Q_PaymentRef.PRVoucher, 
                         dbo.Q_PaymentRef.VoucherDate, dbo.Job_Order.ConfirmDate, dbo.qJob_CashControl.ChqDate, dbo.Job_Order.DocDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustBranch, 
                         dbo.Job_Order.CustCode, dbo.Q_VouherStateOne.JobNo, dbo.Q_PaymentRef.DocNo, dbo.Job_CashControlDoc.DocType, dbo.Q_VouherStateOne.DocDate, dbo.Q_VouherStateOne.IsDocCancel, dbo.Q_PaymentRef.UserPvocher, 
                         dbo.qJob_CashControl.BookCode, dbo.qJob_CashControl.PRType, dbo.Q_VouherStateOne.AdvAmt, dbo.Q_VouherStateOne.UsedAmt, dbo.Mas_BookAccount.BookName, dbo.Mas_BookAccount.BankCode, 
                         dbo.Mas_BookAccount.BankBranch, dbo.Mas_BookAccount.ACType



GO
/****** Object:  View [dbo].[View_RefClr]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_RefClr]
AS
SELECT     dbo.qJob_ClearDetail.BranchCode, dbo.qJob_ClearDetail.JNo, dbo.qJob_ClearDetail.AdvRefNo, dbo.qJob_ClearDetail.ClrNo, 
                      dbo.qJob_ClearDetail.ClrDate, dbo.qJob_ClearDetail.ClearType, dbo.qJob_ClearDetail.ClearFrom, dbo.qJob_ClearDetail.DocStatus, 
                      dbo.qJob_ClearDetail.SICode, dbo.qJob_ClearDetail.UnitPrice, dbo.qJob_ClearDetail.UnitCost, dbo.qJob_ClearDetail.ChargeVAT, 
                      dbo.qJob_ClearDetail.Tax50Tavi, dbo.qJob_ClearDetail.AdvAmount, dbo.qJob_ClearDetail.UsedAmount, dbo.qJob_CashControl.ControlNo, 
                      dbo.qJob_CashControl.PRVoucher, dbo.qJob_CashControl.VoucherDate, dbo.qJob_CashControl.RecUser, dbo.qJob_ClearDetail.ReceiveRef, 
                      dbo.qJob_CashControl.UserName
FROM         dbo.qJob_ClearDetail LEFT OUTER JOIN
                      dbo.qJob_CashControl ON dbo.qJob_ClearDetail.BranchCode = dbo.qJob_CashControl.BranchCode AND 
                      dbo.qJob_ClearDetail.ReceiveRef = dbo.qJob_CashControl.PRVoucher



GO
/****** Object:  View [dbo].[QE_QuotationHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QuotationHeader]
AS
SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_Order.JNo, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Job_QuoHeader.BillToCustCode, dbo.Job_QuoHeader.BillToCustBranch, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, dbo.Job_QuoHeader.DescriptionH, 
                      dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, dbo.Job_QuoHeader.ApproveDate, 
                      dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoHeader.ExchageRate
FROM         dbo.Job_QuoHeader INNER JOIN
                      dbo.Job_Order ON dbo.Job_QuoHeader.QNo = dbo.Job_Order.QNo AND dbo.Job_QuoHeader.Revise = dbo.Job_Order.Revise




GO
/****** Object:  View [dbo].[QE_QuoDetailItem]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QuoDetailItem]
AS
SELECT     dbo.QE_QuotationHeader.BranchCode, dbo.QE_QuotationHeader.JNo, dbo.Job_QuoDetailItem.QNo, dbo.Job_QuoDetailItem.Revise, dbo.Job_QuoDetailItem.LinkItem, 
                      dbo.Job_QuoDetailItem.ItemNo, dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, dbo.Job_QuoDetailItem.StepSub, 
                      dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, dbo.Job_QuoDetailItem.UnitCost, 
                      dbo.Job_QuoDetailItem.UnitQTY, dbo.Job_QuoDetailItem.CurrencyRate, dbo.Job_QuoDetailItem.Isvat, dbo.Job_QuoDetailItem.VatRate, dbo.Job_QuoDetailItem.VatAmt, 
                      dbo.Job_QuoDetailItem.IsTax, dbo.Job_QuoDetailItem.TaxRate, dbo.Job_QuoDetailItem.TaxAmt, dbo.Job_QuoDetailItem.TotalAmt, dbo.Job_QuoDetailItem.CurrentTHB, 
                      dbo.Job_QuoDetailItem.UnitDiscntPerc, dbo.Job_QuoDetailItem.UnitDiscntAmt
FROM         dbo.QE_QuotationHeader INNER JOIN
                      dbo.Job_QuoDetailItem ON dbo.QE_QuotationHeader.BranchCode = dbo.Job_QuoDetailItem.BranchCode AND 
                      dbo.QE_QuotationHeader.QNo = dbo.Job_QuoDetailItem.QNo AND dbo.QE_QuotationHeader.Revise = dbo.Job_QuoDetailItem.Revise




GO
/****** Object:  View [dbo].[QE_QoutationDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_QoutationDetail]
AS
SELECT     dbo.QE_QuotationHeader.BranchCode, dbo.QE_QuotationHeader.JNo, dbo.Job_QuoDetail.QNo, dbo.Job_QuoDetail.Revise, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode
FROM         dbo.QE_QuotationHeader INNER JOIN
                      dbo.Job_QuoDetail ON dbo.QE_QuotationHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.QE_QuotationHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.QE_QuotationHeader.Revise = dbo.Job_QuoDetail.Revise




GO
/****** Object:  View [dbo].[qJob_AdvHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_AdvHeader]
AS
SELECT        dbo.Job_AdvHeader.BranchCode, dbo.Job_AdvHeader.AdvNo, dbo.Job_AdvHeader.JobType, dbo.Job_AdvHeader.AdvDate, dbo.Job_AdvHeader.AdvType, dbo.Job_AdvHeader.EmpCode, dbo.Job_AdvHeader.JNo, 
                         dbo.Job_AdvHeader.InvNo, dbo.Job_AdvHeader.DocStatus, dbo.Job_AdvHeader.VATRate, dbo.Job_AdvHeader.TotalAdvance, dbo.Job_AdvHeader.TotalVAT, dbo.Job_AdvHeader.Total50Tavi, dbo.Job_AdvHeader.TRemark, 
                         dbo.Job_AdvHeader.ApproveBy, dbo.Job_AdvHeader.ApproveDate, dbo.Job_AdvHeader.ApproveTime, dbo.Job_AdvHeader.PaymentBy, dbo.Job_AdvHeader.PaymentDate, dbo.Job_AdvHeader.PaymentTime, 
                         dbo.Job_AdvHeader.PaymentRef, dbo.Job_AdvHeader.CancelReson, dbo.Job_AdvHeader.CancelProve, dbo.Job_AdvHeader.CancelDate, dbo.Job_AdvHeader.CancelTime, dbo.Job_AdvHeader.AdvCash, 
                         dbo.Job_AdvHeader.AdvChqCash, dbo.Job_AdvHeader.AdvChq, dbo.Job_AdvHeader.AdvCred, dbo.Job_AdvHeader.PayChqTo, dbo.Job_AdvHeader.PayChqDate, dbo.Job_AdvHeader.Doc50Tavi, dbo.Job_AdvHeader.AdvBy, 
                         dbo.Job_AdvHeader.PaymentNo, dbo.Mas_User.TName AS UserName, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Mas_Company.NameThai AS CustName, dbo.Job_Order.TotalGW, dbo.Job_Order.GWUnit, 
                         dbo.Job_Order.TotalContainer, dbo.Job_Order.ShipBy, dbo.Job_Order.JobStatus
FROM            dbo.Job_AdvHeader LEFT OUTER JOIN
                         dbo.Mas_User ON dbo.Job_AdvHeader.EmpCode = dbo.Mas_User.UserID LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_AdvHeader.JNo = dbo.Job_Order.JNo AND dbo.Job_AdvHeader.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode

GO
/****** Object:  View [dbo].[qJob_ClearHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[qJob_ClearHeader]
AS
SELECT     dbo.Job_ClearHeader.BranchCode, dbo.Job_ClearHeader.ClrNo, dbo.Job_ClearHeader.ClrDate, dbo.Job_ClearHeader.ClearanceDate, 
                      dbo.Job_ClearHeader.EmpCode, dbo.Job_ClearHeader.AdvRefNo, dbo.Job_ClearHeader.AdvTotal, dbo.Job_ClearHeader.JobType, 
                      dbo.Job_ClearHeader.JNo, dbo.Job_ClearHeader.InvNo, dbo.Job_ClearHeader.ClearType, dbo.Job_ClearHeader.ClearFrom, 
                      dbo.Job_ClearHeader.DocStatus, dbo.Job_ClearHeader.TotalExpense, dbo.Job_ClearHeader.TRemark, dbo.Job_ClearHeader.ApproveBy, 
                      dbo.Job_ClearHeader.ApproveDate, dbo.Job_ClearHeader.ApproveTime, dbo.Job_ClearHeader.ReceiveBy, dbo.Job_ClearHeader.ReceiveDate, 
                      dbo.Job_ClearHeader.ReceiveTime, dbo.Job_ClearHeader.ReceiveRef, dbo.Job_ClearHeader.CancelReson, dbo.Job_ClearHeader.CancelProve, 
                      dbo.Job_ClearHeader.CancelDate, dbo.Job_ClearHeader.CancelTime, dbo.Job_ClearHeader.CoPersonCode, dbo.Job_Order.QNo, 
                      dbo.Job_Order.Revise, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Mas_Company.NameThai AS CustName, 
                      dbo.Mas_User.TName AS CSName, dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.ShipBy
FROM         dbo.Job_ClearHeader LEFT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_ClearHeader.BranchCode = dbo.Job_Order.BranchCode AND 
                      dbo.Job_ClearHeader.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode AND 
                      dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_ClearHeader.EmpCode = dbo.Mas_User.UserID





GO
/****** Object:  View [dbo].[vKPI_Advance]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vKPI_Advance]
AS
SELECT     a.AdvNo, a.AdvDate, a.EmpCode AS AdvBy, a.JNo, a.ApproveBy, a.ApproveDate, a.PaymentBy, a.PaymentDate, b.EmpCode AS ClrBy, b.ClrNo, 
                      b.ClrDate, b.ReceiveBy, b.ReceiveDate, DATEDIFF(D, b.ClrDate, a.PaymentDate) AS DaysClear, DATEDIFF(D, b.ReceiveDate, b.ClrDate) 
                      AS DaysAccReceive, a.TotalAdvance, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, a.JobType
FROM         dbo.qJob_AdvHeader AS a LEFT OUTER JOIN
                      dbo.Job_Order ON a.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.qJob_ClearHeader AS b ON a.AdvNo = b.AdvRefNo
WHERE     (a.DocStatus <> 99)


GO
/****** Object:  View [dbo].[qJob_Order]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_Order]
AS
SELECT        a.BranchCode, a.JNo, a.JRevise, a.ConfirmDate, a.CPolicyCode, a.DocDate, a.CustCode, a.CustBranch, a.CustContactName, a.QNo, a.Revise, a.ManagerCode, a.CSCode, a.Description, a.TRemark, a.JobStatus, a.JobType, 
                         a.ShipBy, a.InvNo, a.InvTotal, a.InvProduct, a.InvCountry, a.InvFCountry, a.InvInterPort, a.InvProductQty, a.InvProductUnit, a.InvCurUnit, a.InvCurRate, a.ImExDate, a.BLNo, a.BookingNo, a.ClearPort, a.ClearPortNo, a.ClearDate, 
                         a.LoadDate, a.ForwarderCode, a.AgentCode, a.VesselName, a.ETDDate, a.ETADate, a.ETTime, a.FNetPrice, a.BNetPrice, a.CancelReson, a.CancelDate, a.CancelTime, a.CancelProve, a.CancelProveDate, a.CancelProveTime, 
                         a.CloseJobDate, a.CloseJobTime, a.CloseJobBy, a.DeclareType, a.DeclareNumber, a.DeclareStatus, a.TyAuthorSp, a.Ty19BIS, a.TyClearTax, a.TyClearTaxReson, a.EstDeliverDate, a.EstDeliverTime, a.TotalContainer, 
                         a.DutyDate, a.DutyAmount, a.DutyCustPayOther, a.DutyCustPayChqAmt, a.DutyCustPayBankAmt, a.DutyCustPayEPAYAmt, a.DutyCustPayCardAmt, a.DutyCustPayCashAmt, a.DutyCustPayOtherAmt, a.DutyLtdPayOther, 
                         a.DutyLtdPayChqAmt, a.DutyLtdPayEPAYAmt, a.DutyLtdPayCashAmt, a.DutyLtdPayOtherAmt, a.ConfirmChqDate, a.ShippingEmp, a.ShippingCmd, a.TotalGW, a.GWUnit, a.TSRequest, a.ShipmentType, a.ReadyToClearDate, 
                         a.Commission, a.CommPayTo, a.ProjectName, a.MVesselName, a.TotalNW, a.Measurement, a.CustRefNO, a.TotalQty, a.HAWB, a.MAWB, a.consigneecode, a.privilegests, a.CustCode + '-' + a.CustBranch AS CustID, b.Title, 
                         b.NameThai, b.NameEng, d.AreaName, e.TName AS CSName, b.ManagerCode AS SalesCode, f.NameEng AS ConsigneeName, g.TName AS ForwarderName, dbo.Mas_Vender.TName AS AgentName, b.TAddress1, b.TAddress2, 
                         b.EAddress1, b.EAddress2
FROM            dbo.Job_Order AS a LEFT OUTER JOIN
                         dbo.Mas_Vender ON a.AgentCode = dbo.Mas_Vender.VenCode LEFT OUTER JOIN
                         dbo.Mas_Vender AS g ON a.ForwarderCode = g.VenCode LEFT OUTER JOIN
                         dbo.Mas_Company AS b ON a.CustCode = b.CustCode AND a.CustBranch = b.Branch LEFT OUTER JOIN
                         dbo.Mas_Consignee AS f ON a.consigneecode = f.Code AND b.TaxNumber = f.TaxNumber LEFT OUTER JOIN
                         dbo.Mas_RFARS AS d ON a.ClearPort = d.AreaCode LEFT OUTER JOIN
                         dbo.Mas_User AS e ON a.CSCode = e.UserID



GO
/****** Object:  View [dbo].[vJob_VolumeByCust]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_VolumeByCust]
AS
SELECT     YEAR(DocDate) AS JobYear, MONTH(DocDate) AS JobMonth, JobStatus, JobType, ShipBy, COUNT(JNo) AS CountJob, CustCode
FROM         dbo.qJob_Order
GROUP BY MONTH(DocDate), YEAR(DocDate), JobStatus, JobType, ShipBy, CustCode


GO
/****** Object:  View [dbo].[QE_UnionCashJob]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_UnionCashJob]
AS
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [ClrNo] AS DocNo, [ClrDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_ClearHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [AdvNo] AS DocNo, [AdvDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_AdvHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JobNo] AS JNo, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_BillingHeader]
UNION
SELECT        [BranchCode] AS BranchCode, [JNo] AS JNo, [DocNo] AS DocNo, [DocDate] AS DocDate, [EmpCode] AS UserCode, [CancelReson] AS IsDocCancel
FROM            [Job_PaymentHeader]



GO
/****** Object:  View [dbo].[QE_CashControlRefJob]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlRefJob]
AS
SELECT        dbo.Job_CashControlDoc.BranchCode, dbo.QE_UnionCashJob.JNo, dbo.Job_CashControlDoc.ControlNo, dbo.Job_CashControlDoc.DocNo
FROM            dbo.Job_CashControlDoc INNER JOIN
                         dbo.QE_UnionCashJob ON dbo.Job_CashControlDoc.BranchCode = dbo.QE_UnionCashJob.BranchCode AND dbo.Job_CashControlDoc.DocNo = dbo.QE_UnionCashJob.DocNo



GO
/****** Object:  View [dbo].[vJob_Volume]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Volume]
AS
SELECT     YEAR(DutyDate) AS JobYear, MONTH(DutyDate) AS JobMonth, JobStatus, JobType, ShipBy, COUNT(JNo) AS CountJob, CSCode
FROM         dbo.qJob_Order
WHERE     (DutyDate IS NOT NULL)
GROUP BY MONTH(DutyDate), YEAR(DutyDate), JobStatus, JobType, ShipBy, CSCode


GO
/****** Object:  View [dbo].[QE_CashControlHeder]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlHeder]
AS
SELECT DISTINCT 
                         dbo.Job_CashControl.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControl.ControlNo, dbo.Job_CashControl.VoucherDate, dbo.Job_CashControl.TRemark, dbo.Job_CashControl.RecUser, 
                         dbo.Job_CashControl.RecDate, dbo.Job_CashControl.RecTime, dbo.Job_CashControl.PostedBy, dbo.Job_CashControl.PostedDate, dbo.Job_CashControl.PostedTime, dbo.Job_CashControl.CancelReson, 
                         dbo.Job_CashControl.CancelProve, dbo.Job_CashControl.CancelDate, dbo.Job_CashControl.CancelTime
FROM            dbo.Job_CashControl INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControl.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControl.ControlNo = dbo.QE_CashControlRefJob.ControlNo



GO
/****** Object:  View [dbo].[QE_CashControlSub]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlSub]
AS
SELECT DISTINCT 
                         dbo.Job_CashControlSub.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControlSub.ControlNo, dbo.Job_CashControlSub.ItemNo, dbo.Job_CashControlSub.PRVoucher, dbo.Job_CashControlSub.PRType, 
                         dbo.Job_CashControlSub.ChqNo, dbo.Job_CashControlSub.BookCode, dbo.Job_CashControlSub.BankCode, dbo.Job_CashControlSub.BankBranch, dbo.Job_CashControlSub.ChqDate, dbo.Job_CashControlSub.CashAmount, 
                         dbo.Job_CashControlSub.ChqAmount, dbo.Job_CashControlSub.CreditAmount, dbo.Job_CashControlSub.IsLocal, dbo.Job_CashControlSub.ChqStatus, dbo.Job_CashControlSub.TRemark, dbo.Job_CashControlSub.PayChqTo, 
                         dbo.Job_CashControlSub.DocNo, dbo.Job_CashControlSub.SICode, dbo.Job_CashControlSub.RecvBank, dbo.Job_CashControlSub.RecvBranch
FROM            dbo.Job_CashControlSub INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControlSub.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControlSub.ControlNo = dbo.QE_CashControlRefJob.ControlNo



GO
/****** Object:  View [dbo].[vJob_Count]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Count]
AS
SELECT     JobType, ShipBy, CustCode, CSCode, JobStatus, COUNT(*) AS TotalJob
FROM         dbo.qJob_Order
GROUP BY JobType, ShipBy, CustCode, CSCode, JobStatus


GO
/****** Object:  View [dbo].[QE_CashControlDoc]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_CashControlDoc]
AS
SELECT        dbo.Job_CashControlDoc.BranchCode, dbo.QE_CashControlRefJob.JNo, dbo.Job_CashControlDoc.ControlNo, dbo.Job_CashControlDoc.ItemNo, dbo.Job_CashControlDoc.DocType, dbo.Job_CashControlDoc.DocNo, 
                         dbo.Job_CashControlDoc.DocDate, dbo.Job_CashControlDoc.CmpType, dbo.Job_CashControlDoc.CmpCode, dbo.Job_CashControlDoc.CmpBranch, dbo.Job_CashControlDoc.PaidAmount, 
                         dbo.Job_CashControlDoc.TotalAmount
FROM            dbo.Job_CashControlDoc INNER JOIN
                         dbo.QE_CashControlRefJob ON dbo.Job_CashControlDoc.BranchCode = dbo.QE_CashControlRefJob.BranchCode AND dbo.Job_CashControlDoc.ControlNo = dbo.QE_CashControlRefJob.ControlNo AND 
                         dbo.Job_CashControlDoc.DocNo = dbo.QE_CashControlRefJob.DocNo



GO
/****** Object:  View [dbo].[vKPI_AdvanceSum]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vKPI_AdvanceSum]
AS
SELECT     JNo, COUNT(*) AS TotalAdvDoc, SUM(CASE WHEN DaysClear <= - 7 THEN 1 ELSE 0 END) AS TotalClrOnTime, 
                      SUM(CASE WHEN DaysAccReceive <= - 5 THEN 1 ELSE 0 END) AS TotalRcvOnTime, SUM(CASE WHEN DaysClear <= - 7 THEN 1 ELSE 0 END) 
                      * 100 / COUNT(*) AS AdvClrScore, SUM(CASE WHEN DaysAccReceive <= - 5 THEN 1 ELSE 0 END) * 100 / COUNT(*) AS ClrRcvScore
FROM         dbo.vKPI_Advance
GROUP BY JNo



GO
/****** Object:  View [dbo].[qrpt_ksat_Biggg]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_ksat_Biggg]
AS
SELECT     dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.JobNo, Asrv.ProcessDesc AS PCSales, 
                      Asrv.GLAccountCodeSales AS GLSALES, Mas_GlSaleName.GLSalsesName, dbo.qJob_BillDetail.AmtCharge AS SalePrice, 
                      Bsrv.ProcessDesc AS PCCost, Bsrv.GLAccountCodeCost AS GLCOST, Mas_GLCostName.GLCostName, dbo.qJob_BillDetail.AmtAdvance AS CostPrice, 
                      dbo.qJob_Detail.UnitCost AS CmpCost, ROUND(dbo.qJob_BillDetail.AmtCharge - dbo.qJob_Detail.UnitCost, 2) AS SalesPrf, 
                      ROUND(dbo.qJob_BillDetail.AmtAdvance - dbo.qJob_Detail.UnitCost, 2) AS CostPrf
FROM         dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle AS Asrv ON dbo.qJob_BillDetail.SICode = Asrv.SICode INNER JOIN
                      dbo.Job_SrvSingle AS Bsrv ON dbo.qJob_BillDetail.SICode = Bsrv.SICode INNER JOIN
                      dbo.qJob_Detail ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_BillDetail.JobNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_Detail.DNNo AND dbo.qJob_BillDetail.SICode = dbo.qJob_Detail.SICode INNER JOIN
                      dbo.MAS_GLACCOUNT AS Mas_GlSaleName ON Asrv.GLAccountCodeSales = Mas_GlSaleName.GLSalesCode INNER JOIN
                      dbo.MAS_GLACCOUNT AS Mas_GLCostName ON Bsrv.GLAccountCodeCost = Mas_GLCostName.GLCostCode



GO
/****** Object:  View [dbo].[qrpt_CostState]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_CostState]
AS
SELECT     dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.NameThai, 
                      dbo.qJob_BillDetail.TaxNumber, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      dbo.qJob_BillDetail.TotalAdvance + dbo.qJob_BillDetail.TotalCharge AS GRAmount, dbo.qJob_BillDetail.TotalVAT, 
                      dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2 AS TotalTax, dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.DCurrencyCode, 
                      dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.EmpCode, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, 
                      MAS_GLACCOUNT_1.GLCostName
FROM         dbo.MAS_GLACCOUNT AS MAS_GLACCOUNT_1 INNER JOIN
                      dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_BillDetail.SICode = dbo.Job_SrvSingle.SICode ON MAS_GLACCOUNT_1.GLCostCode = dbo.Job_SrvSingle.GLAccountCodeCost



GO
/****** Object:  View [dbo].[qrpt_SalseState]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qrpt_SalseState]
AS
SELECT     dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.NameThai, 
                      dbo.qJob_BillDetail.TaxNumber, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      dbo.qJob_BillDetail.TotalAdvance + dbo.qJob_BillDetail.TotalCharge AS GRAmount, dbo.qJob_BillDetail.TotalVAT, 
                      dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2 AS TotalTax, dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.DCurrencyCode, 
                      dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.EmpCode, dbo.Job_SrvSingle.GLAccountCodeSales, dbo.Job_SrvSingle.GLAccountCodeCost, 
                      MAS_GLACCOUNT_1.GLSalsesName
FROM         dbo.MAS_GLACCOUNT AS MAS_GLACCOUNT_1 INNER JOIN
                      dbo.qJob_BillDetail INNER JOIN
                      dbo.Job_SrvSingle ON dbo.qJob_BillDetail.SICode = dbo.Job_SrvSingle.SICode ON MAS_GLACCOUNT_1.GLSalesCode = dbo.Job_SrvSingle.GLAccountCodeSales



GO
/****** Object:  View [dbo].[Q_ProfitCalculate]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_ProfitCalculate]
AS
SELECT        BranchCode, JNo, Sales_DS - Cost_DS AS Profit_DS, Sales_DSR - Cost_DSR AS Profit_DSR, Sales_OS - Cost_OS AS Profit_OS, Sales_OSR - Cost_OSR AS Profit_OSR, ROUND((((Sales_DS - Cost_DS) + (Sales_DSR - Cost_DSR)) 
                         + (Sales_OS - Cost_OS)) + (Sales_OSR - Cost_OSR), 2) AS SubTotal_Profit
FROM            dbo.Q_CostJoinProfit



GO
/****** Object:  View [dbo].[Q_ReportCostAndProfit]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Q_ReportCostAndProfit]
AS
SELECT     dbo.Q_CostJoinProfit.BranchCode, dbo.Q_CostJoinProfit.JNo, dbo.Q_CostJoinProfit.JobDate, dbo.Q_CostJoinProfit.LastBiiling AS TotalInvoice,
                          (SELECT     CONVERT(date, DocDate) AS BiiiDate
                            FROM          dbo.Job_BillingHeader
                            WHERE      (JobNo = dbo.Q_CostJoinProfit.JNo) AND (BranchCode = dbo.Q_CostJoinProfit.BranchCode) AND 
                                                   (JobBillAmt = dbo.Q_CostJoinProfit.LastBiiling)) AS LastInvDate, dbo.Q_CostJoinProfit.CPolicyCode AS JobState, 
                      dbo.Q_CostJoinProfit.JobType, dbo.Q_CostJoinProfit.ShipBy, dbo.Q_CostJoinProfit.JobStatus, dbo.Q_CostJoinProfit.CSCode, 
                      dbo.Q_CostJoinProfit.CustCode, dbo.Q_CostJoinProfit.CustBranch, dbo.Q_CostJoinProfit.CustTaxNumber, dbo.Q_CostJoinProfit.CustName, 
                      dbo.Q_CostJoinProfit.ConsignCode, dbo.Q_CostJoinProfit.ConsignBranch, dbo.Q_CostJoinProfit.ConsignTaxNumber, 
                      dbo.Q_CostJoinProfit.ConsignName, dbo.Q_CostJoinProfit.ETDDate, dbo.Q_CostJoinProfit.ETADate, dbo.Q_CostJoinProfit.MAWB, 
                      dbo.Q_CostJoinProfit.HAWB, dbo.Q_CostJoinProfit.Sales_DS, dbo.Q_CostJoinProfit.Sales_DSR, dbo.Q_CostJoinProfit.Sales_OS, 
                      dbo.Q_CostJoinProfit.Sales_OSR, dbo.Q_CostJoinProfit.SubTotal_Sales, dbo.Q_CostJoinProfit.Cost_DS, dbo.Q_CostJoinProfit.Cost_DSR, 
                      dbo.Q_CostJoinProfit.Cost_OS, dbo.Q_CostJoinProfit.Cost_OSR, dbo.Q_CostJoinProfit.SubTotal_Cost, dbo.Q_ProfitCalculate.Profit_DS, 
                      dbo.Q_ProfitCalculate.Profit_DSR, dbo.Q_ProfitCalculate.Profit_OS, dbo.Q_ProfitCalculate.Profit_OSR, dbo.Q_ProfitCalculate.SubTotal_Profit, 
                      CONVERT(date, dbo.Q_CostJoinProfit.ConfirmDate) AS JobStatusDate
FROM         dbo.Q_CostJoinProfit INNER JOIN
                      dbo.Q_ProfitCalculate ON dbo.Q_CostJoinProfit.BranchCode = dbo.Q_ProfitCalculate.BranchCode AND 
                      dbo.Q_CostJoinProfit.JNo = dbo.Q_ProfitCalculate.JNo
WHERE     (dbo.Q_CostJoinProfit.LastBiiling > 0)



GO
/****** Object:  View [dbo].[qJob_RSlip]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_RSlip]
AS
SELECT     dbo.Job_RSlip.BranchCode, dbo.Job_RSlip.DocNo AS RSlipNo, CONVERT(date, dbo.Job_RSlip.DocDate) AS RSlipDate, 
                      dbo.Job_RSlipSub.BillNo AS RefInvNo
FROM         dbo.Job_RSlip INNER JOIN
                      dbo.Job_RSlipSub ON dbo.Job_RSlip.BranchCode = dbo.Job_RSlipSub.BranchCode AND dbo.Job_RSlip.DocNo = dbo.Job_RSlipSub.DocNo



GO
/****** Object:  View [dbo].[Q_FinancialCostReport]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_FinancialCostReport]
AS
SELECT     dbo.qJob_ClearDetail.BranchCode, dbo.qJob_ClearDetail.ClrNo, dbo.qJob_ClearDetail.ClrDate, MONTH(dbo.qJob_ClearDetail.ClrDate) AS ClrMonth, 
                      dbo.qJob_ClearDetail.AdvRefNo, dbo.qJob_ClearDetail.InvNo, dbo.qJob_ClearDetail.ClearType, dbo.qJob_ClearDetail.ClearFrom, 
                      dbo.qJob_ClearDetail.DocStatus AS ClrDocStatus, dbo.qJob_ClearDetail.CancelReson AS ClrCancelReson, dbo.qJob_ClearDetail.CancelProve AS ClrCancelProve, 
                      CONVERT(Date, dbo.qJob_ClearDetail.CancelDate) AS ClrCancelDate, dbo.Q_PaymentRef.ControlNo, dbo.Q_PaymentRef.PRVoucher, CONVERT(Date, 
                      dbo.Q_PaymentRef.VoucherDate) AS PVDate, dbo.qJob_ClearDetail.SICode, dbo.qJob_ClearDetail.SDescription, dbo.qJob_ClearDetail.VenderCode, 
                      dbo.Mas_Vender.TaxNumber AS VendorTaxNumber, dbo.Mas_Vender.English AS VendorEname, dbo.qJob_ClearDetail.CurrencyCode, dbo.qJob_ClearDetail.CurRate, 
                      dbo.qJob_ClearDetail.ChargeVAT, dbo.qJob_ClearDetail.Tax50Tavi AS TaxAmt, 
                      dbo.qJob_ClearDetail.UsedAmount - dbo.qJob_ClearDetail.ChargeVAT + dbo.qJob_ClearDetail.Tax50Tavi AS PreVat, dbo.qJob_ClearDetail.UsedAmount, 
                      dbo.qJob_ClearDetail.EmpCode AS ClrEmpCode, dbo.qJob_ClearDetail.CSName AS ClrEmpName, dbo.qJob_ClearDetail.SlipNO, dbo.qJob_ClearDetail.CustCode, 
                      dbo.qJob_ClearDetail.CustBranch, dbo.qJob_ClearDetail.CustName, dbo.qJob_Detail.JNo, CONVERT(Date, dbo.qJob_Detail.ConfirmDate) AS JobStatusDate, 
                      CONVERT(Date, dbo.qJob_Detail.DocDate) AS JobDate, dbo.qJob_Detail.CPolicyCode, dbo.qJob_Detail.JobType, dbo.qJob_Detail.ShipBy, dbo.qJob_Detail.JobStatus, 
                      CONVERT(Date, dbo.qJob_Detail.ImExDate) AS IEDate, dbo.qJob_Detail.BLNo, CONVERT(Date, dbo.qJob_Detail.ETDDate) AS ETDDate, CONVERT(Date, 
                      dbo.qJob_Detail.ETADate) AS ETADate, dbo.qJob_Detail.HAWB, dbo.qJob_Detail.MAWB, dbo.qJob_BillDetail.DocNo AS InvoiceNo, CONVERT(Date, 
                      dbo.qJob_BillDetail.DocDate) AS InvoiceDate, CONVERT(Date, dbo.qJob_BillDetail.TaxInvDate) AS TaxInvDate, dbo.qJob_BillDetail.BillToCustCode, 
                      dbo.qJob_BillDetail.BillToCustBranch, dbo.Mas_Company.TaxNumber AS BillToTaxNumber, dbo.Mas_Company.NameThai AS BillToNameThai, 
                      dbo.qJob_BillDetail.TaxInvNo, dbo.qJob_RSlip.RSlipNo AS DebitNo, dbo.qJob_RSlip.RSlipDate AS DebitDate, dbo.qJob_BillDetail.ProcessDesc, 
                      dbo.MAS_GLACCOUNT.GLCostCode AS GLAccountCode, dbo.MAS_GLACCOUNT.GLCostName
FROM         dbo.qJob_ClearDetail LEFT OUTER JOIN
                      dbo.qJob_Detail ON dbo.qJob_ClearDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_ClearDetail.JNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_ClearDetail.ClrNo = dbo.qJob_Detail.ClearingNO AND dbo.qJob_ClearDetail.SICode = dbo.qJob_Detail.SICode INNER JOIN
                      dbo.MAS_GLACCOUNT ON dbo.qJob_Detail.GLAccountCodeCost = dbo.MAS_GLACCOUNT.GLCostCode LEFT OUTER JOIN
                      dbo.Q_PaymentRef ON dbo.qJob_ClearDetail.BranchCode = dbo.Q_PaymentRef.BranchCode AND 
                      dbo.qJob_ClearDetail.ClrNo = dbo.Q_PaymentRef.DocNo LEFT OUTER JOIN
                      dbo.Mas_Vender ON dbo.qJob_ClearDetail.VenderCode = dbo.Mas_Vender.VenCode LEFT OUTER JOIN
                      dbo.qJob_BillDetail ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_Detail.BranchCode AND dbo.qJob_BillDetail.JobNo = dbo.qJob_Detail.JNo AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_Detail.DNNo AND dbo.qJob_BillDetail.SICode = dbo.qJob_Detail.SICode LEFT OUTER JOIN
                      dbo.qJob_RSlip ON dbo.qJob_RSlip.BranchCode = dbo.qJob_BillDetail.BranchCode AND dbo.qJob_RSlip.RefInvNo = dbo.qJob_BillDetail.DocNo LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.qJob_BillDetail.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.qJob_BillDetail.BillToCustBranch = dbo.Mas_Company.Branch


GO
/****** Object:  View [dbo].[Q_FinancialSalesReport]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Q_FinancialSalesReport]
AS
SELECT     dbo.qJob_BillDetail.BranchCode, dbo.qJob_BillDetail.DocNo AS InvoceNo, CONVERT(date, dbo.qJob_BillDetail.DocDate) AS InvoiceDate, 
                      MONTH(dbo.qJob_BillDetail.DocDate) AS InvoiceMonth, dbo.qJob_BillDetail.JobNo, dbo.qJob_BillDetail.JobBillAmt, dbo.qJob_BillDetail.CustCode, 
                      dbo.qJob_BillDetail.CustBranch, Mas_Customers.TaxNumber AS CustTaxNumber, Mas_Customers.NameEng AS CustName, 
                      dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.TaxNumber AS BillToTaxNumber, 
                      dbo.qJob_BillDetail.NameEng AS BillToName, dbo.qJob_BillDetail.EmpCode, dbo.qJob_BillDetail.CurrencyCode, dbo.qJob_BillDetail.ExchangeRate, 
                      dbo.qJob_RSlip.RSlipNo, CONVERT(date, dbo.qJob_RSlip.RSlipDate) AS RSlipDate, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, 
                      ISNULL(SUM(dbo.qJob_BillDetail.IsTaxCharge), 0) AS IsVat, ISNULL(SUM(dbo.qJob_BillDetail.Is50Tavi), 0) AS IsTax, 
                      ISNULL(SUM(dbo.qJob_BillDetail.Rate50Tavi), 0) AS TaxRate, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.AmtAdvance), 0), 2) AS AmtAdvance, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.AmtCharge), 0), 2) AS AmtCharge, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalVAT), 0), 2) AS TotalVAT, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.Total50Tavi1 + dbo.qJob_BillDetail.Total50Tavi2), 0), 2) AS TotalTax, 
                      ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalCustAdv), 0), 2) AS TotalCustAdv, ROUND(ISNULL(SUM(dbo.qJob_BillDetail.TotalNet), 0), 2) AS TotalNet, 
                      dbo.qJob_BillDetail.ProcessDesc, dbo.qJob_BillDetail.GLAccountCodeSales AS GLAccountCode, dbo.MAS_GLACCOUNT.GLSalsesName, 
                      dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, CONVERT(date, dbo.Job_Order.ETDDate) AS ETDDate, CONVERT(date, 
                      dbo.Job_Order.ETADate) AS ETADate, CONVERT(date, dbo.Job_Order.DocDate) AS JobDate, CONVERT(date, dbo.Job_Order.ConfirmDate) 
                      AS JobStatusDate, dbo.Job_Order.CPolicyCode
FROM         dbo.qJob_BillDetail LEFT OUTER JOIN
                      dbo.qJob_RSlip ON dbo.qJob_BillDetail.BranchCode = dbo.qJob_RSlip.BranchCode AND 
                      dbo.qJob_BillDetail.DocNo = dbo.qJob_RSlip.RefInvNo INNER JOIN
                      dbo.Mas_Company AS Mas_Customers ON dbo.qJob_BillDetail.CustCode = Mas_Customers.CustCode AND 
                      dbo.qJob_BillDetail.CustBranch = Mas_Customers.Branch INNER JOIN
                      dbo.Job_Order ON dbo.qJob_BillDetail.BranchCode = dbo.Job_Order.BranchCode AND 
                      dbo.qJob_BillDetail.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.MAS_GLACCOUNT ON dbo.qJob_BillDetail.GLAccountCodeSales = dbo.MAS_GLACCOUNT.GLSalesCode
GROUP BY dbo.qJob_BillDetail.BranchCode, dbo.qJob_BillDetail.DocNo, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.DocDate, dbo.qJob_BillDetail.JobNo, 
                      dbo.qJob_BillDetail.JobBillAmt, dbo.qJob_BillDetail.CustCode, dbo.qJob_BillDetail.CustBranch, Mas_Customers.TaxNumber, 
                      Mas_Customers.NameEng, dbo.qJob_BillDetail.BillToCustCode, dbo.qJob_BillDetail.BillToCustBranch, dbo.qJob_BillDetail.TaxNumber, 
                      dbo.qJob_BillDetail.NameEng, dbo.qJob_BillDetail.EmpCode, dbo.qJob_BillDetail.CurrencyCode, dbo.qJob_BillDetail.ExchangeRate, 
                      dbo.qJob_RSlip.RSlipNo, dbo.qJob_RSlip.RSlipDate, dbo.qJob_BillDetail.SICode, dbo.qJob_BillDetail.SDescription, dbo.qJob_BillDetail.IsTaxCharge, 
                      dbo.qJob_BillDetail.Is50Tavi, dbo.qJob_BillDetail.Rate50Tavi, dbo.qJob_BillDetail.AmtAdvance, dbo.qJob_BillDetail.AmtCharge, 
                      dbo.qJob_BillDetail.TotalVAT, dbo.qJob_BillDetail.Total50Tavi1, dbo.qJob_BillDetail.Total50Tavi2, dbo.qJob_BillDetail.TotalCustAdv, 
                      dbo.qJob_BillDetail.TotalNet, dbo.qJob_BillDetail.ProcessDesc, dbo.qJob_BillDetail.GLAccountCodeSales, dbo.MAS_GLACCOUNT.GLSalsesName, 
                      dbo.Job_Order.ConfirmDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.CPolicyCode, dbo.Job_Order.DocDate


GO
/****** Object:  View [dbo].[qGL_SetEarnest]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[qGL_SetEarnest]
as
select a.*,b.GLCostName from
(
	select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,UsedAmount-ChargeVAT as DEBIT,0 as CREDIT,CustName,'1130-12' as ACCode  from qJob_ClearDetail
	where SICode in(
		select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
	)
	union
	select ClrDate,ClrNo,JNo,0 as DEBIT,UsedAmount-ChargeVAT as CREDIT,CustName,'1111-00'  from qJob_ClearDetail
	where SICode in(
		select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
	)
) a inner join MAS_GLACCOUNT b
on a.ACCode=b.GLCostCode

GO
/****** Object:  View [dbo].[qGL_RcvEarnest]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[qGL_RcvEarnest]
as
select a.*,b.GLCostName 
from
(
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,UsedAmount-ChargeVAT-Convert(numeric,substring(Remark,2,charindex(':',Remark,0)-2)) as DEBIT,0 as CREDIT,CustName,'1111-00' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%'
union
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,Convert(numeric,substring(Remark,2,charindex(':',Remark,0)-2)) as DEBIT,0 as CRedit,CustName,'1130-10' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%' and SUBSTRING(Remark,2,1)<>'0'
union
select ClrDate as DocDate,ClrNo as DocNo,JNo as JobNo,0 as DEBIT,UsedAmount-ChargeVAT as CRedit,CustName,'1130-12' as ACCode  from qJob_ClearDetail
where SICode in(
	select SICode from Job_SrvSingle where GLAccountCodeCost='1130-12'	
) and DocStatus=3 and Remark like '#%' 
) a inner join MAS_GLACCOUNT b
on a.ACCode=b.GLCostCode



GO
/****** Object:  View [dbo].[qGL_RcvAR]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[qGL_RcvAR]
as
with recv
as
(	
	select a.*,b.DocNo from
	(
	select ctl.BranchCode,ctl.ControlNo,ctl.VoucherDate,
	SUM(ctl.CashAmount) as Cash,
	SUM(ctl.ChqAmount) as Chq,
	SUM(ISNULL(ctl.CreditAmount,0)) as Credit
	,ctl.PayChqTo,ctl.BookCode,ISNULL(book.EAddress2,'1111-00') as AccCode 
	from qJob_CashControl ctl 
        left join Mas_BookAccount book 
        on ctl.BookCode=book.BookCode
	where ctl.ControlNo in(
	    select ControlNo from Job_CashControlDoc where
	    DocType='INV' And ControlNo=ctl.ControlNo)
	and Not ctl.CancelProve <>''
	group by ctl.BranchCode,ctl.ControlNo,ctl.VoucherDate,ctl.PayChqTo,ctl.BookCode,ISNULL(book.EAddress2,'1111-00')
	) a	inner join Job_CashControlDoc b
	on a.ControlNo=b.ControlNo and a.PayChqTo=b.DocNo
	and b.DocType ='INV' 	
)
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate ,SUM(r.Cash) as DEBIT,0 as CREDIT
,b.CustTName as CustName,'1111-00' as ACCode
from recv r inner join qJob_BillHeader b
on r.BranchCode=b.BranchCode and r.DocNo=b.DocNo
and b.TaxInvNo <>'' and not b.CancelProve <>''
and r.Cash>0
group by b.TaxInvNo,b.TaxInvDate ,b.DocNo,b.JobNo,r.VoucherDate,b.CustTName 
union
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate ,SUM(r.Chq),0
,b.CustTName as NameEng,r.AccCode as ACCode
from recv r inner join qJob_BillHeader b
on r.BranchCode=b.BranchCode and r.DocNo=b.DocNo
and b.TaxInvNo <>'' and not b.CancelProve <>''
and r.Chq>0
group by b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,r.VoucherDate,b.CustTName,r.AccCode
union
select b.TaxInvNo,b.TaxInvDate,b.DocNo,b.JobNo,b.DocDate ,b.Total50Tavi2,0
,b.CustTName as NameEng,'1151-13' as ACCode
from qJob_BillHeader b inner join recv r on b.BranchCode=r.BranchCode and b.DocNo=r.DocNo
where b.TaxInvNo <>'' and not b.CancelProve <>''
and b.Total50Tavi2>0 




GO
/****** Object:  View [dbo].[q_StateMentAccount_V2]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[q_StateMentAccount_V2] 
AS
SELECT a.*,isnull(a.[TotalRecieve]-a.[TotalPayMent],0) as Balance,
CASE WHEN b.ChqAmount >0 then 'CH' ELSE (
  CASE WHEN b.CashAmount>0 then 'CA' ELSE 'CR' END
) END as VCType 
FROM [Q_StatementAccount] a left join 
Job_CashControlSub b on
a.ControlNo=b.ControlNo and a.PRVoucher=b.PRVoucher

GO
/****** Object:  View [dbo].[qAlert_M001]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qAlert_M001] AS 
SELECT Job_Order.BranchCode, Job_Order.JobStatus, Job_Order.CSCode, Job_Order.JNo, Job_Controls.ItemNo AS LinkItem, Job_Controls.NDate, Job_Controls.ADate, Year([ADate]) AS AlertYear
FROM Job_Order LEFT JOIN Job_Controls ON (Job_Order.BranchCode = Job_Controls.BranchCode) AND (Job_Order.JNo = Job_Controls.JNo)
WHERE (((Job_Order.JobStatus)=2) AND ((Year([ADate]))>1900))


GO
/****** Object:  View [dbo].[QE_Advance]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_Advance]
AS
SELECT        dbo.Job_AdvDetail.ItemNo, dbo.Job_AdvDetail.STCode, dbo.Job_AdvDetail.SICode, dbo.Job_AdvDetail.AdvAmount, dbo.Job_AdvDetail.IsChargeVAT, dbo.Job_AdvDetail.ChargeVAT, dbo.Job_AdvDetail.Rate50Tavi, 
                         dbo.Job_AdvDetail.Charge50Tavi, dbo.Job_AdvDetail.TRemark, dbo.Job_AdvDetail.IsDuplicate, dbo.Job_AdvDetail.PayChqTo, dbo.Job_AdvDetail.Doc50Tavi, dbo.Job_AdvHeader.BranchCode, dbo.Job_AdvHeader.JNo, 
                         dbo.Job_AdvDetail.AdvNo
FROM            dbo.Job_AdvHeader INNER JOIN
                         dbo.Job_AdvDetail ON dbo.Job_AdvHeader.BranchCode = dbo.Job_AdvDetail.BranchCode AND dbo.Job_AdvHeader.AdvNo = dbo.Job_AdvDetail.AdvNo



GO
/****** Object:  View [dbo].[QE_Clearing]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QE_Clearing]
AS
SELECT     dbo.Job_ClearHeader.BranchCode, dbo.Job_ClearHeader.JNo, dbo.Job_ClearDetail.ClrNo, dbo.Job_ClearDetail.ItemNo, dbo.Job_ClearDetail.LinkItem, 
                      dbo.Job_ClearDetail.STCode, dbo.Job_ClearDetail.SICode, dbo.Job_ClearDetail.SDescription, dbo.Job_ClearDetail.VenderCode, dbo.Job_ClearDetail.Qty, 
                      dbo.Job_ClearDetail.UnitCode, dbo.Job_ClearDetail.CurrencyCode, dbo.Job_ClearDetail.CurRate, dbo.Job_ClearDetail.UnitPrice, dbo.Job_ClearDetail.FPrice, 
                      dbo.Job_ClearDetail.BPrice, dbo.Job_ClearDetail.QUnitPrice, dbo.Job_ClearDetail.QFPrice, dbo.Job_ClearDetail.QBPrice, dbo.Job_ClearDetail.UnitCost, 
                      dbo.Job_ClearDetail.FCost, dbo.Job_ClearDetail.BCost, dbo.Job_ClearDetail.ChargeVAT, dbo.Job_ClearDetail.Tax50Tavi, dbo.Job_ClearDetail.AdvNO, 
                      dbo.Job_ClearDetail.AdvAmount, dbo.Job_ClearDetail.UsedAmount, dbo.Job_ClearDetail.IsQuoItem, dbo.Job_ClearDetail.SlipNO, dbo.Job_ClearDetail.Remark, 
                      dbo.Job_ClearDetail.IsDuplicate, dbo.Job_ClearDetail.IsLtdAdv50Tavi, dbo.Job_ClearDetail.Pay50TaviTo, dbo.Job_ClearDetail.NO50Tavi, 
                      dbo.Job_ClearDetail.Date50Tavi, dbo.Job_ClearDetail.VenderBillingNo, dbo.Job_ClearDetail.AirQtyStep, dbo.Job_ClearDetail.StepSub, 
                      dbo.Job_ClearDetail.JobNo
FROM         dbo.Job_ClearHeader INNER JOIN
                      dbo.Job_ClearDetail ON dbo.Job_ClearHeader.BranchCode = dbo.Job_ClearDetail.BranchCode AND dbo.Job_ClearHeader.ClrNo = dbo.Job_ClearDetail.ClrNo




GO
/****** Object:  View [dbo].[QE_CustAdvanceCheqHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QE_CustAdvanceCheqHeader]
AS
SELECT DISTINCT 
                      dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChqSub.JNO, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, 
                      dbo.Job_CustAdvChq.ChqNo, dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, 
                      dbo.Job_CustAdvChq.ChqAmount, dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, 
                      dbo.Job_CustAdvChq.RecordDate, dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, 
                      dbo.Job_CustAdvChq.DepUser, dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, 
                      dbo.Job_CustAdvChq.CancelDate, dbo.Job_CustAdvChq.CancelReason, dbo.Job_CustAdvChq.ClearBy, dbo.Job_CustAdvChq.ClearDate, 
                      dbo.Job_CustAdvChq.ControlNo
FROM         dbo.Job_CustAdvChq INNER JOIN
                      dbo.Job_CustAdvChqSub ON dbo.Job_CustAdvChq.BranchCode = dbo.Job_CustAdvChqSub.BranchCode AND 
                      dbo.Job_CustAdvChq.RefNo = dbo.Job_CustAdvChqSub.RefNo


GO
/****** Object:  View [dbo].[QE_InvoiceAPDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_InvoiceAPDetail]
AS
SELECT        dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentDetail.DocNo, dbo.Job_PaymentDetail.ItemNo, dbo.Job_PaymentDetail.SICode, dbo.Job_PaymentDetail.SDescription, 
                         dbo.Job_PaymentDetail.ExpSlipNO, dbo.Job_PaymentDetail.SRemark, dbo.Job_PaymentDetail.QtyUnit, dbo.Job_PaymentDetail.IsTaxCharge, dbo.Job_PaymentDetail.Is50Tavi, dbo.Job_PaymentDetail.Rate50Tavi, 
                         dbo.Job_PaymentDetail.AmtAdvance, dbo.Job_PaymentDetail.AmtCharge, dbo.Job_PaymentDetail.ForeignAmt, dbo.Job_PaymentDetail.CurrencyCode, dbo.Job_PaymentDetail.ExchangeRate, 
                         dbo.Job_PaymentDetail.CurrencyCodeCredit, dbo.Job_PaymentDetail.ExchangeRateCredit, dbo.Job_PaymentDetail.ForeignAmtCredit, dbo.Job_PaymentDetail.DiscountPerc, dbo.Job_PaymentDetail.AmtDiscount, 
                         dbo.Job_PaymentDetail.ForeignDisc, dbo.Job_PaymentDetail.FUnitPrice, dbo.Job_PaymentDetail.FQty, dbo.Job_PaymentDetail.FTotalAmt
FROM            dbo.Job_PaymentHeader INNER JOIN
                         dbo.Job_PaymentDetail ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_PaymentDetail.BranchCode AND dbo.Job_PaymentHeader.DocNo = dbo.Job_PaymentDetail.DocNo



GO
/****** Object:  View [dbo].[QE_ListSelectJob]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[QE_ListSelectJob]
AS
SELECT        BranchCode, JNo, JRevise, CONVERT(date, ConfirmDate, 103) AS ConfirmDate, CPolicyCode, CONVERT(date, DocDate, 103) AS DocDate, CustCode, CustBranch, QNo, Revise, CSCode, JobStatus, JobType, ShipBy, 
                         CONVERT(date, ETDDate, 103) AS ETDDate, CONVERT(date, ETADate, 103) AS ETADate, HAWB, MAWB
FROM            dbo.Job_Order



GO
/****** Object:  View [dbo].[qJob_AdvMJob]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_AdvMJob] AS 
SELECT Job_AdvMJob.*, Job_Order.ImExDate, Job_Order.TotalGW, Job_Order.GWUnit, Mas_Company.NameThai AS CustName, Mas_User.TName AS EmpName, Job_AdvHeader.DocStatus AS AdvDocStatus
FROM (((Job_AdvMJob LEFT JOIN Job_Order ON (Job_AdvMJob.BranchCode = Job_Order.BranchCode) AND (Job_AdvMJob.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_AdvMJob.CSCode = Mas_User.UserID) LEFT JOIN Job_AdvHeader ON (Job_AdvMJob.BranchCode = Job_AdvHeader.BranchCode) AND (Job_AdvMJob.AdvNO = Job_AdvHeader.AdvNo)


GO
/****** Object:  View [dbo].[qJob_ClearMJob]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_ClearMJob] AS 
SELECT Job_ClearMJob.*, Job_ClearHeader.DocStatus, Job_Order.ImExDate, Job_Order.ClearDate, Job_Order.TotalContainer, Job_Order.TotalGW, Job_Order.GWUnit, Mas_Company.NameThai AS CustName, Mas_User.TName AS EmpName, Job_Order.InvNo, Job_ClearHeader.EmpCode
FROM (((Job_ClearMJob LEFT JOIN Job_ClearHeader ON (Job_ClearMJob.BranchCode = Job_ClearHeader.BranchCode) AND (Job_ClearMJob.ClrNO = Job_ClearHeader.ClrNo)) LEFT JOIN Job_Order ON (Job_ClearHeader.BranchCode = Job_Order.BranchCode) AND (Job_ClearHeader.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_ClearMJob.CSCode = Mas_User.UserID


GO
/****** Object:  View [dbo].[qJob_Controls]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Controls] AS 
SELECT Job_Order.CPolicyCode, Job_CPolicyHeader.PolicyName, Job_Controls.BranchCode, Job_Controls.JNo, Job_Controls.ItemNo, Job_Controls.SCID, Job_CPolicyDetail.SCDescription, Job_Controls.EmpCode, Job_Controls.BDate, Job_Controls.BTime, Job_Controls.NDate, Job_Controls.NTime, Job_Controls.ADate, Job_Controls.AlertReson, Job_Controls.UnLockBy, Job_Controls.UnLockDate, Job_Controls.UnLockTime, Job_Controls.TRemark, Job_Controls.DayStart, Job_Controls.DayStartDate, Job_Controls.AmtDHoliday, Job_Controls.AmtDPeriod, Job_Controls.AmtDOverDue, Job_Controls.MaximumDay, Job_Controls.Field1, Job_Controls.Field2, Job_Controls.Field3, Job_Controls.Field4, Job_Controls.Field5, Job_Controls.Field6, Job_Controls.Field7, Job_Controls.Field8, Job_Controls.Field9, Job_Controls.Field10, Job_Order.DocDate
FROM (Job_Order INNER JOIN Job_Controls ON (Job_Order.JNo = Job_Controls.JNo) AND (Job_Order.BranchCode = Job_Controls.BranchCode)) INNER JOIN (Job_CPolicyHeader INNER JOIN Job_CPolicyDetail ON Job_CPolicyHeader.PolicyCode = Job_CPolicyDetail.PolicyCode) ON (Job_Controls.SCID = Job_CPolicyDetail.SCID) AND (Job_Controls.ItemNo = Job_CPolicyDetail.ItemNo) AND (Job_Order.CPolicyCode = Job_CPolicyHeader.PolicyCode)


GO
/****** Object:  View [dbo].[qJob_CoPersonSlip]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CoPersonSlip] AS 
SELECT Job_CoPersonSlip.*, Mas_TaxCode.TName AS CoPersonName, Job_ClearHeader.JNo, Job_ClearHeader.InvNo, Mas_Company.NameThai AS CustName
FROM (((Job_CoPersonSlip LEFT JOIN Job_ClearHeader ON (Job_CoPersonSlip.BranchCode = Job_ClearHeader.BranchCode) AND (Job_CoPersonSlip.DocNO = Job_ClearHeader.ClrNo)) LEFT JOIN Job_Order ON (Job_ClearHeader.BranchCode = Job_Order.BranchCode) AND (Job_ClearHeader.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_TaxCode ON Job_CoPersonSlip.CoPersonCode = Mas_TaxCode.TaxNumber


GO
/****** Object:  View [dbo].[qJob_CustAdvance]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_CustAdvance]
AS
SELECT     dbo.Job_CustAdvHeader.BranchCode, dbo.Job_CustAdvHeader.JNo, dbo.Job_CustAdvHeader.DocNo, dbo.Job_CustAdvHeader.DocDate, 
                      dbo.Job_CustAdvHeader.TotalAdvance, dbo.Job_CustAdvHeader.RefNO, dbo.Job_CustAdvHeader.AdvNo, dbo.Job_CustAdvDetail.ItemNo, 
                      dbo.Job_CustAdvDetail.SICode, dbo.Job_CustAdvDetail.SDescription, dbo.Job_CustAdvDetail.TotalExpense, dbo.Job_CustAdvDetail.PayTo, 
                      dbo.Job_CustAdvDetail.PaySlipNo, dbo.Job_CustAdvDetail.PaySlipDate, dbo.Job_CustAdvDetail.Remark, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.NameThai, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, 
                      dbo.Job_Order.ShipBy, dbo.Job_CustAdvDetail.ReceiptDue, dbo.Job_CustAdvDetail.ReceiptNo, dbo.Job_CustAdvDetail.ReceiptDate
FROM         dbo.Job_CustAdvHeader INNER JOIN
                      dbo.Job_CustAdvDetail ON dbo.Job_CustAdvHeader.DocNo = dbo.Job_CustAdvDetail.DocNo AND 
                      dbo.Job_CustAdvHeader.JNo = dbo.Job_CustAdvDetail.JNo AND 
                      dbo.Job_CustAdvHeader.BranchCode = dbo.Job_CustAdvDetail.BranchCode INNER JOIN
                      dbo.Job_Order ON dbo.Job_CustAdvHeader.JNo = dbo.Job_Order.JNo INNER JOIN
                      dbo.Mas_Company ON dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch AND dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode


GO
/****** Object:  View [dbo].[qJob_CustAdvChq]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_CustAdvChq]
AS
SELECT     dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, dbo.Job_CustAdvChq.ChqNo, 
                      dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, dbo.Job_CustAdvChq.ChqAmount, 
                      dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, dbo.Job_CustAdvChq.RecordDate, 
                      dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, dbo.Job_CustAdvChq.DepUser, 
                      dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, dbo.Job_CustAdvChq.CancelDate, 
                      dbo.Job_CustAdvChq.CancelReason, dbo.Job_CustAdvChq.ClearBy, dbo.Job_CustAdvChq.ClearDate, dbo.Job_CustAdvChq.ControlNo, 
                      dbo.Mas_Company.CustGroup, dbo.Mas_Company.TaxNumber, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, 
                      dbo.Mas_Company.NameEng
FROM         dbo.Job_CustAdvChq LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.Job_CustAdvChq.CustCode = dbo.Mas_Company.CustCode AND 
                      dbo.Job_CustAdvChq.CustBranch = dbo.Mas_Company.Branch



GO
/****** Object:  View [dbo].[qJob_CustAdvChqSub]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_CustAdvChqSub]
AS
SELECT     dbo.Job_CustAdvChq.BranchCode, dbo.Job_CustAdvChq.RefNo, dbo.Job_CustAdvChq.BankCode, dbo.Job_CustAdvChq.ChqNo, 
                      dbo.Job_CustAdvChq.CustCode, dbo.Job_CustAdvChq.CustBranch, dbo.Job_CustAdvChq.ChqDate, dbo.Job_CustAdvChq.ChqAmount, 
                      dbo.Job_CustAdvChq.TotalUsed, dbo.Job_CustAdvChq.PayTo, dbo.Job_CustAdvChq.Remark, dbo.Job_CustAdvChq.RecordDate, 
                      dbo.Job_CustAdvChq.RecordBy, dbo.Job_CustAdvChq.DepBookAcc, dbo.Job_CustAdvChq.DepDate, dbo.Job_CustAdvChq.DepUser, 
                      dbo.Job_CustAdvChq.ControlNo, dbo.Job_CustAdvChq.ApproveBy, dbo.Job_CustAdvChq.ApproveDate, dbo.Job_CustAdvChq.CancelBy, 
                      dbo.Job_CustAdvChq.CancelDate, dbo.Job_CustAdvChq.CancelReason, 
                      dbo.Job_CustAdvChqSub.SeqNo, dbo.Job_CustAdvChqSub.JNO, dbo.Job_CustAdvChqSub.PayAmount, 
                      dbo.Job_CustAdvChqSub.Remark AS DRemark, dbo.Job_CustAdvChqSub.BillingNo, dbo.Mas_BankCode.BName AS BankName, 
                      dbo.Job_CustAdvChqSub.SICode, dbo.Job_CustAdvChqSub.ClearingNo, dbo.Job_CustAdvChqSub.ItemNo,
                      dbo.Job_CustAdvChqSub.BillFlag
FROM         dbo.Job_CustAdvChq LEFT OUTER JOIN
                      dbo.Mas_BankCode ON dbo.Job_CustAdvChq.BankCode = dbo.Mas_BankCode.Code LEFT OUTER JOIN
                      dbo.Job_CustAdvChqSub ON dbo.Job_CustAdvChq.BranchCode = dbo.Job_CustAdvChqSub.BranchCode AND 
                      dbo.Job_CustAdvChq.RefNo = dbo.Job_CustAdvChqSub.RefNo



GO
/****** Object:  View [dbo].[qJob_DebitNote]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_DebitNote] AS SELECT a.BranchCode,a.DocNo,a.DocDate,a.InvNo,a.EmpCode,a.ApproveBy,a.ApproveDate,a.ApproveTime,a.Remark,a.VatInclude,a.IsCreditNote,SUM(b.DiffAmt) AS AmtChange,a.VatRate,a.VatAmt,a.TotalNet FROM dbo.Job_DebitNote a INNER JOIN dbo.Job_DebitNoteSub b ON a.BranchCode = b.BranchCode AND a.DocNo = b.DocNo GROUP BY a.BranchCode,a.DocNo,a.DocDate,a.InvNo,a.EmpCode,a.ApproveBy,a.ApproveDate,a.ApproveTime,a.Remark,a.VatInclude,a.IsCreditNote,a.VatRate,a.VatAmt,a.TotalNet

GO
/****** Object:  View [dbo].[qJob_DebitNoteSub]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_DebitNoteSub]
AS
SELECT     dbo.Job_DebitNote.BranchCode, dbo.Job_DebitNote.DocNo, dbo.Job_DebitNote.DocDate, dbo.Job_DebitNote.InvNo, dbo.Job_DebitNote.EmpCode, 
                      dbo.Job_DebitNote.ApproveBy, dbo.Job_DebitNote.ApproveDate, dbo.Job_DebitNote.ApproveTime, dbo.Job_DebitNote.Remark, 
                      dbo.Job_DebitNote.VatRate, dbo.Job_DebitNote.VatAmt, dbo.Job_DebitNote.TotalNet, dbo.Job_DebitNote.VatInclude, dbo.Job_DebitNote.IsCreditNote, 
                      dbo.Job_DebitNoteSub.ItemNo, dbo.Job_DebitNoteSub.BillingNo, dbo.Job_DebitNoteSub.SICode, dbo.Job_DebitNoteSub.SDescription, 
                      dbo.Job_DebitNoteSub.OriginalAmt, dbo.Job_DebitNoteSub.CorrectAmt, dbo.Job_DebitNoteSub.DiffAmt, dbo.Job_DebitNoteSub.CurrencyCode, 
                      dbo.Job_DebitNoteSub.ExchangeRate, dbo.Job_DebitNoteSub.ForeignAmt, dbo.Job_BillingHeader.CustCode, dbo.Job_BillingHeader.CustBranch, 
                      dbo.Job_BillingHeader.JobNo, dbo.Job_BillingHeader.BillAcceptNo, dbo.Job_BillingHeader.BillDate, dbo.Job_BillingHeader.TaxInvNo, 
                      dbo.Job_BillingHeader.TaxInvDate, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, 
                      dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.TaxNumber
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_BillingHeader ON dbo.Mas_Company.CustCode = dbo.Job_BillingHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_BillingHeader.CustBranch RIGHT OUTER JOIN
                      dbo.Job_DebitNoteSub RIGHT OUTER JOIN
                      dbo.Job_DebitNote ON dbo.Job_DebitNoteSub.BranchCode = dbo.Job_DebitNote.BranchCode AND 
                      dbo.Job_DebitNoteSub.DocNo = dbo.Job_DebitNote.DocNo ON dbo.Job_BillingHeader.DocNo = dbo.Job_DebitNoteSub.BillingNo



GO
/****** Object:  View [dbo].[qJob_Document]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Document] AS 
SELECT Job_Document.*, Mas_DocType.DocName, Job_Order.DocDate AS JobDate, Job_Order.ImExDate, Job_Order.CustCode, Job_Order.CustBranch, Job_Order.[CustCode]+'-'+[CustBranch] AS CustID, Mas_Company.NameThai AS CustTName, Mas_User.TName AS CSName
FROM (((Job_Document LEFT JOIN Mas_DocType ON Job_Document.DocType = Mas_DocType.DocType) LEFT JOIN Job_Order ON (Job_Document.BranchCode = Job_Order.BranchCode) AND (Job_Document.JNo = Job_Order.JNo)) LEFT JOIN Mas_Company ON (Job_Order.CustCode = Mas_Company.CustCode) AND (Job_Order.CustBranch = Mas_Company.Branch)) LEFT JOIN Mas_User ON Job_Order.CSCode = Mas_User.UserID


GO
/****** Object:  View [dbo].[qJob_LoadInfo]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_LoadInfo]
AS
SELECT        dbo.Job_Order.BranchCode, dbo.Job_Order.JNo, dbo.Job_Order.JRevise, dbo.Job_Order.ConfirmDate, dbo.Job_Order.CPolicyCode, dbo.Job_Order.DocDate, 
                         dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.CustContactName, dbo.Job_Order.QNo, dbo.Job_Order.Revise, dbo.Job_Order.ManagerCode, 
                         dbo.Job_Order.CSCode, dbo.Job_Order.Description, dbo.Job_Order.TRemark, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, 
                         dbo.Job_Order.InvNo, dbo.Job_Order.InvTotal, dbo.Job_Order.InvProduct, dbo.Job_Order.InvCountry, dbo.Job_Order.InvFCountry, dbo.Job_Order.InvInterPort, 
                         dbo.Job_Order.InvProductQty, dbo.Job_Order.InvProductUnit, dbo.Job_Order.InvCurUnit, dbo.Job_Order.InvCurRate, dbo.Job_Order.ImExDate, dbo.Job_Order.BLNo, 
                         dbo.Job_Order.ClearPort, dbo.Job_Order.ClearPortNo, dbo.Job_Order.ClearDate, dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, 
                         dbo.Job_Order.VesselName, dbo.Job_Order.ETDDate, dbo.Job_Order.ETADate, dbo.Job_Order.ETTime, dbo.Job_Order.FNetPrice, dbo.Job_Order.BNetPrice, 
                         dbo.Job_Order.CancelReson, dbo.Job_Order.CancelDate, dbo.Job_Order.CancelTime, dbo.Job_Order.CancelProve, dbo.Job_Order.CancelProveDate, 
                         dbo.Job_Order.CancelProveTime, dbo.Job_Order.CloseJobDate, dbo.Job_Order.CloseJobTime, dbo.Job_Order.CloseJobBy, dbo.Job_Order.DeclareType, 
                         dbo.Job_Order.DeclareNumber, dbo.Job_Order.DeclareStatus, dbo.Job_Order.TyAuthorSp, dbo.Job_Order.Ty19BIS, dbo.Job_Order.TyClearTax, 
                         dbo.Job_Order.TyClearTaxReson, dbo.Job_Order.EstDeliverDate, dbo.Job_Order.EstDeliverTime, dbo.Job_Order.TotalContainer, dbo.Job_Order.DutyDate, 
                         dbo.Job_Order.DutyAmount, dbo.Job_Order.DutyCustPayOther, dbo.Job_Order.DutyCustPayChqAmt, dbo.Job_Order.DutyCustPayBankAmt, 
                         dbo.Job_Order.DutyCustPayEPAYAmt, dbo.Job_Order.DutyCustPayCardAmt, dbo.Job_Order.DutyCustPayCashAmt, dbo.Job_Order.DutyCustPayOtherAmt, 
                         dbo.Job_Order.DutyLtdPayOther, dbo.Job_Order.DutyLtdPayChqAmt, dbo.Job_Order.DutyLtdPayEPAYAmt, dbo.Job_Order.DutyLtdPayCashAmt, 
                         dbo.Job_Order.DutyLtdPayOtherAmt, dbo.Job_Order.ConfirmChqDate, dbo.Job_Order.ShippingEmp, dbo.Job_Order.ShippingCmd, dbo.Job_Order.TotalGW, 
                         dbo.Job_Order.GWUnit, dbo.Job_Order.TSRequest, dbo.Job_Order.ShipmentType, dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.Commission, 
                         dbo.Job_Order.CommPayTo, dbo.Job_Order.ProjectName, dbo.Job_Order.MVesselName, dbo.Job_Order.TotalNW, dbo.Job_Order.CustRefNO, 
                         dbo.Job_Order.TotalQty, dbo.Job_Order.HAWB, dbo.Job_Order.MAWB, dbo.Job_Order.consigneecode, dbo.Job_Order.privilegests, dbo.Job_LoadInfo.VenderCode, 
                         dbo.Job_LoadInfo.ContactName, dbo.Job_LoadInfoDetail.ItemNo, dbo.Job_LoadInfoDetail.CTN_NO, dbo.Job_LoadInfoDetail.SealNumber, 
                         dbo.Job_LoadInfoDetail.TruckNO, dbo.Job_LoadInfoDetail.TruckIN, dbo.Job_LoadInfoDetail.Start, dbo.Job_LoadInfoDetail.Finish, dbo.Job_LoadInfoDetail.TimeUsed, 
                         dbo.Job_LoadInfoDetail.CauseCode, dbo.Job_LoadInfoDetail.Comment, dbo.Mas_Company.NameThai, dbo.Mas_LoadCause.TName, dbo.Job_LoadInfo.BookingNo, 
                         dbo.Job_LoadInfo.LoadDate, dbo.Job_LoadInfo.Remark, dbo.Job_LoadInfo.PackingPlace, dbo.Job_LoadInfo.CYPlace, dbo.Job_LoadInfo.FactoryPlace, 
                         dbo.Job_LoadInfo.ReturnPlace, dbo.Job_LoadInfo.PackingDate, dbo.Job_LoadInfo.CYDate, dbo.Job_LoadInfo.FactoryDate, dbo.Job_LoadInfo.PackingTime, 
                         dbo.Job_LoadInfo.CYTime, dbo.Job_LoadInfo.FactoryTime, dbo.Job_LoadInfo.ReturnTime, dbo.Job_LoadInfo.NotifyCode, dbo.Job_LoadInfo.TransMode, 
                         dbo.Job_LoadInfo.PaymentCondition, dbo.Job_LoadInfo.PaymentBy, dbo.Job_LoadInfoDetail.TruckType, dbo.Job_LoadInfoDetail.Driver, 
                         dbo.Job_LoadInfoDetail.TargetYardDate, dbo.Job_LoadInfoDetail.TargetYardTime, dbo.Job_LoadInfoDetail.ActualYardDate, dbo.Job_LoadInfoDetail.ActualYardTime, 
                         dbo.Job_LoadInfoDetail.UnloadFinishDate, dbo.Job_LoadInfoDetail.UnloadFinishTime, dbo.Job_LoadInfoDetail.UnloadDate, dbo.Job_LoadInfoDetail.UnloadTime, 
                         dbo.Job_LoadInfoDetail.Location, dbo.Job_LoadInfoDetail.ReturnDate, dbo.Job_LoadInfoDetail.ShippingMark, dbo.Job_LoadInfoDetail.ProductDesc, 
                         dbo.Job_LoadInfoDetail.CTN_SIZE, dbo.Job_LoadInfoDetail.ProductQty, dbo.Job_LoadInfoDetail.ProductUnit, dbo.Job_LoadInfoDetail.GrossWeight, 
                         dbo.Job_LoadInfoDetail.Measurement
FROM            dbo.Job_LoadInfo LEFT OUTER JOIN
                         dbo.Job_LoadInfoDetail ON dbo.Job_LoadInfo.BranchCode = dbo.Job_LoadInfoDetail.BranchCode AND 
                         dbo.Job_LoadInfo.JNo = dbo.Job_LoadInfoDetail.JNo LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_LoadInfo.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_LoadInfo.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_Order.CustCode = dbo.Mas_Company.CustCode AND dbo.Job_Order.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Mas_LoadCause ON dbo.Job_LoadInfoDetail.CauseCode = dbo.Mas_LoadCause.Code


GO
/****** Object:  View [dbo].[qJob_PayDetail]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_PayDetail]
AS
SELECT        dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.DocNo, dbo.Job_PaymentHeader.DocDate, dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentHeader.JobBillAmt, dbo.Job_PaymentHeader.CustCode, 
                         dbo.Job_PaymentHeader.CustBranch, dbo.Job_PaymentHeader.BillToCustCode, dbo.Job_PaymentHeader.BillToCustBranch, dbo.Job_PaymentHeader.ContactName, dbo.Job_PaymentHeader.EmpCode, 
                         dbo.Job_PaymentHeader.PrintedBy, dbo.Job_PaymentHeader.PrintedDate, dbo.Job_PaymentHeader.PrintedTime, dbo.Job_PaymentHeader.RefNo, dbo.Job_PaymentHeader.VATRate, dbo.Job_PaymentHeader.Tavi50Rate1, 
                         dbo.Job_PaymentHeader.Tavi50Rate2, dbo.Job_PaymentHeader.TaxInvNo, dbo.Job_PaymentHeader.TaxInvDate, dbo.Job_PaymentHeader.TotalAdvance, dbo.Job_PaymentHeader.TotalCharge, 
                         dbo.Job_PaymentHeader.TotalIsTaxCharge, dbo.Job_PaymentHeader.TotalIs50Tavi1, dbo.Job_PaymentHeader.TotalIs50Tavi2, dbo.Job_PaymentHeader.TotalVAT, dbo.Job_PaymentHeader.Total50Tavi1, 
                         dbo.Job_PaymentHeader.Total50Tavi2, dbo.Job_PaymentHeader.TotalCustAdv, dbo.Job_PaymentHeader.TotalNet, dbo.Job_PaymentHeader.BillDate, dbo.Job_PaymentHeader.BillTime, dbo.Job_PaymentHeader.BillAcceptNo, 
                         dbo.Job_PaymentHeader.PayDate, dbo.Job_PaymentHeader.PayTime, dbo.Job_PaymentHeader.Remark1, dbo.Job_PaymentHeader.Remark2, dbo.Job_PaymentHeader.Remark3, dbo.Job_PaymentHeader.Remark4, 
                         dbo.Job_PaymentHeader.Remark5, dbo.Job_PaymentHeader.Remark6, dbo.Job_PaymentHeader.Remark7, dbo.Job_PaymentHeader.Remark8, dbo.Job_PaymentHeader.Remark9, dbo.Job_PaymentHeader.Remark10, 
                         dbo.Job_PaymentHeader.CancelReson, dbo.Job_PaymentHeader.CancelProve, dbo.Job_PaymentHeader.CancelDate, dbo.Job_PaymentHeader.CancelTime, dbo.Job_PaymentHeader.PaidFlag, 
                         dbo.Job_PaymentHeader.ShippingRemark, dbo.Job_PaymentHeader.CurrencyCode, dbo.Job_PaymentHeader.ExchangeRate, dbo.Job_PaymentHeader.ForeignAmt, dbo.Job_PaymentDetail.ItemNo, 
                         dbo.Job_PaymentDetail.SICode, dbo.Job_PaymentDetail.SDescription, dbo.Job_PaymentDetail.ExpSlipNO, dbo.Job_PaymentDetail.SRemark, dbo.Job_PaymentDetail.QtyUnit, dbo.Job_PaymentDetail.IsTaxCharge, 
                         dbo.Job_PaymentDetail.Is50Tavi, dbo.Job_PaymentDetail.Rate50Tavi, dbo.Job_PaymentDetail.AmtAdvance, dbo.Job_PaymentDetail.AmtCharge, dbo.Job_Order.InvNo, dbo.Job_Order.InvProduct, dbo.Job_Order.VesselName, 
                         dbo.Job_Order.ETADate, dbo.Job_Order.ETDDate, dbo.Mas_Company.Title, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, 
                         dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, dbo.Mas_Company.Phone, dbo.Mas_Company.FaxNumber, dbo.Mas_Company.GLAccountCode, dbo.Mas_Company.LevelGrade, 
                         dbo.Mas_Company.TermOfPayment, dbo.Mas_Company.BillCondition, dbo.Mas_Company.CreditLimit, dbo.Mas_Company.DMailAddress
FROM            dbo.Job_PaymentHeader LEFT OUTER JOIN
                         dbo.Job_PaymentDetail ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_PaymentDetail.BranchCode AND dbo.Job_PaymentHeader.DocNo = dbo.Job_PaymentDetail.DocNo LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_PaymentHeader.JNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_PaymentHeader.BillToCustCode = dbo.Mas_Company.CustCode AND dbo.Job_PaymentHeader.BillToCustBranch = dbo.Mas_Company.Branch



GO
/****** Object:  View [dbo].[qJob_PayHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qJob_PayHeader]
AS
SELECT        dbo.Job_PaymentHeader.CustCode + '-' + dbo.Job_PaymentHeader.CustBranch AS CustID, dbo.Job_PaymentHeader.BranchCode, dbo.Job_PaymentHeader.DocNo, dbo.Job_PaymentHeader.DocDate, 
                         dbo.Job_PaymentHeader.JNo, dbo.Job_PaymentHeader.JobBillAmt, dbo.Job_PaymentHeader.CustCode, dbo.Job_PaymentHeader.CustBranch, dbo.Job_PaymentHeader.BillToCustCode, 
                         dbo.Job_PaymentHeader.BillToCustBranch, dbo.Job_PaymentHeader.ContactName, dbo.Job_PaymentHeader.EmpCode, dbo.Job_PaymentHeader.PrintedBy, dbo.Job_PaymentHeader.PrintedDate, 
                         dbo.Job_PaymentHeader.PrintedTime, dbo.Job_PaymentHeader.RefNo, dbo.Job_PaymentHeader.VATRate, dbo.Job_PaymentHeader.Tavi50Rate1, dbo.Job_PaymentHeader.Tavi50Rate2, dbo.Job_PaymentHeader.TaxInvNo, 
                         dbo.Job_PaymentHeader.TaxInvDate, dbo.Job_PaymentHeader.TotalAdvance, dbo.Job_PaymentHeader.TotalCharge, dbo.Job_PaymentHeader.TotalIsTaxCharge, dbo.Job_PaymentHeader.TotalIs50Tavi1, 
                         dbo.Job_PaymentHeader.TotalIs50Tavi2, dbo.Job_PaymentHeader.TotalVAT, dbo.Job_PaymentHeader.Total50Tavi1, dbo.Job_PaymentHeader.Total50Tavi2, dbo.Job_PaymentHeader.TotalCustAdv, 
                         dbo.Job_PaymentHeader.TotalNet, dbo.Job_PaymentHeader.BillDate, dbo.Job_PaymentHeader.BillTime, dbo.Job_PaymentHeader.BillAcceptNo, dbo.Job_PaymentHeader.PayDate, dbo.Job_PaymentHeader.PayTime, 
                         dbo.Job_PaymentHeader.Remark1, dbo.Job_PaymentHeader.Remark2, dbo.Job_PaymentHeader.Remark3, dbo.Job_PaymentHeader.Remark4, dbo.Job_PaymentHeader.Remark5, dbo.Job_PaymentHeader.Remark6, 
                         dbo.Job_PaymentHeader.Remark7, dbo.Job_PaymentHeader.Remark8, dbo.Job_PaymentHeader.Remark9, dbo.Job_PaymentHeader.Remark10, dbo.Job_PaymentHeader.CancelReson, dbo.Job_PaymentHeader.CancelProve, 
                         dbo.Job_PaymentHeader.CancelDate, dbo.Job_PaymentHeader.CancelTime, dbo.Job_PaymentHeader.PaidFlag, dbo.Job_PaymentHeader.ShippingRemark, dbo.Job_PaymentHeader.CurrencyCode, 
                         dbo.Job_PaymentHeader.ExchangeRate, dbo.Job_PaymentHeader.ForeignAmt, dbo.Job_PaymentHeader.QuatationNo, dbo.Job_PaymentHeader.Revise, dbo.Job_PaymentHeader.JobCustCode, 
                         dbo.Job_PaymentHeader.JobCustBranch, dbo.Mas_Branch.BrName, dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Mas_Company.NameThai AS CustTName,
                          dbo.Mas_Company.NameEng AS CustEName, dbo.Mas_Company.LevelGrade, dbo.Mas_Company.CreditLimit
FROM            dbo.Job_PaymentHeader LEFT OUTER JOIN
                         dbo.Mas_Branch ON dbo.Job_PaymentHeader.BranchCode = dbo.Mas_Branch.Code LEFT OUTER JOIN
                         dbo.Mas_Company ON dbo.Job_PaymentHeader.CustCode = dbo.Mas_Company.CustCode AND dbo.Job_PaymentHeader.CustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Job_Order ON dbo.Job_PaymentHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_PaymentHeader.JNo = dbo.Job_Order.JNo



GO
/****** Object:  View [dbo].[qJob_Quotation]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, Mas_User_1.TName AS IssueName, 
                      dbo.Job_QuoHeader.DescriptionH, dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, 
                      dbo.Mas_User.TName AS ApproveName, dbo.Job_QuoHeader.ApproveDate, dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode, 
                      dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai AS SDescription, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, 
                      dbo.Job_QuoDetailItem.StepSub, dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, 
                      Mas_User_1.EMail
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_QuoHeader ON dbo.Mas_Company.CustCode = dbo.Job_QuoHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_QuoHeader.CustBranch LEFT OUTER JOIN
                      dbo.Job_QuoDetailItem RIGHT OUTER JOIN
                      dbo.Job_QuoDetail ON dbo.Job_QuoDetailItem.BranchCode = dbo.Job_QuoDetail.BranchCode AND 
                      dbo.Job_QuoDetailItem.QNo = dbo.Job_QuoDetail.QNo AND dbo.Job_QuoDetailItem.Revise = dbo.Job_QuoDetail.Revise ON 
                      dbo.Job_QuoHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.Job_QuoHeader.Revise = dbo.Job_QuoDetail.Revise LEFT OUTER JOIN
                      dbo.Mas_User AS Mas_User_1 ON dbo.Job_QuoHeader.ManagerCode = Mas_User_1.UserID LEFT OUTER JOIN*/
CREATE VIEW [dbo].[qJob_Quotation]
AS
SELECT     dbo.Job_QuoHeader.BranchCode, dbo.Job_QuoHeader.QNo, dbo.Job_QuoHeader.Revise, dbo.Job_QuoHeader.ReferQNo, 
                      dbo.Job_QuoHeader.CustCode, dbo.Job_QuoHeader.CustBranch, dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, 
                      dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, dbo.Mas_Company.EAddress2, 
                      dbo.Job_QuoHeader.ContactName, dbo.Job_QuoHeader.DocDate, dbo.Job_QuoHeader.ManagerCode, Mas_User_1.TName AS IssueName, 
                      dbo.Job_QuoHeader.DescriptionH, dbo.Job_QuoHeader.DescriptionF, dbo.Job_QuoHeader.TRemark, dbo.Job_QuoHeader.ApproveBy, 
                      dbo.Mas_User.TName AS ApproveName, dbo.Job_QuoHeader.ApproveDate, dbo.Job_QuoHeader.ApproveTime, dbo.Job_QuoDetail.ItemNo, 
                      dbo.Job_QuoDetail.LinkItem, dbo.Job_QuoDetail.Description, dbo.Job_QuoDetail.TotalPrice, dbo.Job_QuoDetail.UnitCode, 
                      dbo.Job_QuoDetailItem.STCode, dbo.Job_QuoDetailItem.SICode, dbo.Job_QuoDetailItem.NameThai AS SDescription, 
                      dbo.Job_QuoDetailItem.VenderCode, dbo.Job_QuoDetailItem.UnitCharge, dbo.Job_QuoDetailItem.UnitPrice, dbo.Job_QuoDetailItem.CurrencyCode, 
                      dbo.Job_QuoDetailItem.Start, dbo.Job_QuoDetailItem.Endding, dbo.Job_QuoDetailItem.CY, dbo.Job_QuoDetailItem.QtyStep, 
                      dbo.Job_QuoDetailItem.StepSub, dbo.Job_QuoDetailItem.IsPrintPrice, dbo.Job_QuoDetailItem.IsShowOnPrint, dbo.Job_QuoDetailItem.PrivoteType, 
                      Mas_User_1.EMail, dbo.Mas_Company.BillToCustCode, dbo.Mas_Company.BillToBranch, dbo.Job_QuoDetailItem.UnitCost, 
                      dbo.Job_QuoDetailItem.UnitQTY, dbo.Job_QuoDetailItem.CurrencyRate, dbo.Job_QuoDetailItem.Isvat, dbo.Job_QuoDetailItem.VatRate, 
                      dbo.Job_QuoDetailItem.VatAmt, dbo.Job_QuoDetailItem.IsTax, dbo.Job_QuoDetailItem.TaxRate, dbo.Job_QuoDetailItem.TaxAmt, 
                      dbo.Job_QuoDetailItem.TotalAmt, dbo.Job_QuoDetailItem.CurrentTHB, dbo.Job_QuoDetailItem.UnitDiscntPerc, 
                      dbo.Job_QuoDetailItem.UnitDiscntAmt
FROM         dbo.Mas_Company RIGHT OUTER JOIN
                      dbo.Job_QuoHeader ON dbo.Mas_Company.CustCode = dbo.Job_QuoHeader.CustCode AND 
                      dbo.Mas_Company.Branch = dbo.Job_QuoHeader.CustBranch LEFT OUTER JOIN
                      dbo.Job_QuoDetailItem RIGHT OUTER JOIN
                      dbo.Job_QuoDetail ON dbo.Job_QuoDetailItem.LinkItem = dbo.Job_QuoDetail.LinkItem AND 
                      dbo.Job_QuoDetailItem.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoDetailItem.QNo = dbo.Job_QuoDetail.QNo ON 
                      dbo.Job_QuoHeader.BranchCode = dbo.Job_QuoDetail.BranchCode AND dbo.Job_QuoHeader.QNo = dbo.Job_QuoDetail.QNo AND 
                      dbo.Job_QuoHeader.Revise = dbo.Job_QuoDetail.Revise LEFT OUTER JOIN
                      dbo.Mas_User AS Mas_User_1 ON dbo.Job_QuoHeader.ManagerCode = Mas_User_1.UserID LEFT OUTER JOIN
                      dbo.Mas_User ON dbo.Job_QuoHeader.ApproveBy = dbo.Mas_User.UserID


GO
/****** Object:  View [dbo].[qJob_RefundTax]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_RefundTax] AS SELECT dbo.Job_RefundTaxHeader.RefundNo, dbo.Job_RefundTaxHeader.SendDate, dbo.Job_RefundTaxHeader.ReDate, dbo.Job_RefundTaxHeader.ClaimNo,dbo.Job_RefundTaxHeader.ClaimDate, dbo.Job_RefundTaxHeader.TaxCardDate, dbo.Job_RefundTaxDetail.DNo,dbo.Job_RefundTaxDetail.DeclareNumber, dbo.Job_RefundTaxDetail.ExDate, dbo.Job_RefundTaxDetail.Product, dbo.Job_RefundTaxDetail.FOB,dbo.Job_RefundTaxDetail.NetWeight, dbo.Job_RefundTaxDetail.GFrom, dbo.Job_RefundTaxDetail.TTariff, dbo.Job_RefundTaxDetail.TRate,dbo.Job_RefundTaxDetail.TAmount, dbo.Job_RefundTaxDetail.INVNo FROM dbo.Job_RefundTaxHeader LEFT OUTER JOIN dbo.Job_RefundTaxDetail ON dbo.Job_RefundTaxHeader.RefundNo = dbo.Job_RefundTaxDetail.RefundNo


GO
/****** Object:  View [dbo].[qJob_Shipping]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Shipping] AS 
SELECT Job_Order.BranchCode, Job_Order.ShippingEmp, Job_Order.ImExDate, Job_Order.ClearPort, Job_Order.JNo, Job_Order.JobType, Mas_User.TName AS EmpName, Job_Order.JobStatus, Job_Order.ShipBy
FROM Job_Order LEFT JOIN Mas_User ON Job_Order.ShippingEmp=Mas_User.UserID
WHERE (((Job_Order.JobStatus)=2))


GO
/****** Object:  View [dbo].[qJob_SumCost]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_SumCost] AS 
SELECT Job_Detail.BranchCode, Job_Detail.JNo, Sum(Job_Detail.QBPrice) AS SumQPrice, Sum(Job_Detail.BPrice) AS SumPrice, Sum(Job_Detail.BCost) AS SumCost, Sum([BPrice]-[BCost]) AS Profit
FROM Job_Detail
GROUP BY Job_Detail.BranchCode, Job_Detail.JNo


GO
/****** Object:  View [dbo].[qJob_Tax50Tavi]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[qJob_Tax50Tavi]
AS
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
      ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType1] as IncType
      ,[PayDate1] as PayDate
      ,[PayAmount1] as PayAmt
      ,[PayTax1] as PayTax
	  ,[PayTaxDesc1] as PayTaxDesc
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount1>0
UNION
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
      ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType2]
      ,[PayDate2]
      ,[PayAmount2]
      ,[PayTax2]
	  ,[PayTaxDesc2]
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount2>0
UNION
SELECT [BranchCode]
      ,[DocNo]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[IDCard1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[IDCard2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[IDCard3]
      ,[TName3]
      ,[TAddress3]
	  ,[SeqInForm]
      ,[FormType]
      ,[IncRate]
      ,[IncOther]
      ,[IncType3]
      ,[PayDate3]
      ,[PayAmount3]
      ,[PayTax3]
	  ,[PayTaxDesc3]
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]        
      ,[TaxLawNo]
FROM [Job_Tax50Tavi]
WHERE PayAmount3>0

GO
/****** Object:  View [dbo].[qReport_Job_Billing]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[qReport_Job_Billing]
AS
SELECT        dbo.Job_BillingHeader.BranchCode, dbo.Job_BillingHeader.BillToCustCode, dbo.Job_BillingHeader.BillToCustBranch, dbo.Mas_Company.Title, 
                         dbo.Mas_Company.NameThai, dbo.Mas_Company.NameEng, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.EAddress1, 
                         dbo.Mas_Company.EAddress2, dbo.Job_BillingHeader.TotalAdvance, dbo.Job_BillingHeader.TotalCharge, dbo.Job_BillingHeader.TotalIsTaxCharge, 
                         dbo.Job_BillingHeader.TotalIs50Tavi1, dbo.Job_BillingHeader.TotalIs50Tavi2, dbo.Job_BillingHeader.TotalVAT, dbo.Job_BillingHeader.Total50Tavi1, 
                         dbo.Job_BillingHeader.Total50Tavi2, dbo.Job_BillingHeader.TotalCustAdv, dbo.Job_BillingHeader.TotalNet, dbo.Job_BillingHeader.PayDate, dbo.Job_Order.JNo, 
                         dbo.Job_Order.DocDate AS JobDate, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch, dbo.Job_Order.CSCode, dbo.Job_Order.JobStatus, 
                         dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_CashControlDoc.DocType, dbo.Job_CashControlDoc.ControlNo, dbo.Job_BillingHeader.CancelReson, 
                         dbo.Job_BillingHeader.CancelProve, dbo.Job_BillingHeader.CancelDate, dbo.Job_BillingHeader.DocDate, dbo.Job_BillingHeader.DocNo
FROM            dbo.Job_BillingHeader INNER JOIN
                         dbo.Job_Order ON dbo.Job_BillingHeader.BranchCode = dbo.Job_Order.BranchCode AND dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo INNER JOIN
                         dbo.Mas_Company ON dbo.Job_BillingHeader.BillToCustCode = dbo.Mas_Company.CustCode AND 
                         dbo.Job_BillingHeader.BillToCustBranch = dbo.Mas_Company.Branch LEFT OUTER JOIN
                         dbo.Job_CashControlDoc ON dbo.Job_BillingHeader.BranchCode = dbo.Job_CashControlDoc.BranchCode AND 
                         dbo.Job_BillingHeader.DocNo = dbo.Job_CashControlDoc.DocNo



GO
/****** Object:  View [dbo].[vAdv_all]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vAdv_all]
AS
SELECT DISTINCT 
                      a.BranchCode, a.EmpCode, a.JNo, a.DocStatus, a.AdvNo, a.AdvDate, a.TotalAdvance, b.ClrNo, b.DocStatus AS ClrStatus, b.ClrDate, b.TotalExpense, 
                      b.ReceiveRef, b.TRemark, c.PaidAmount, c.TotalAmount, a.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.CustCode, dbo.Job_Order.CustBranch
FROM         dbo.Job_AdvHeader AS a LEFT OUTER JOIN
                      dbo.Job_Order ON a.JNo = dbo.Job_Order.JNo AND a.BranchCode = dbo.Job_Order.BranchCode LEFT OUTER JOIN
                      dbo.Job_ClearHeader AS b LEFT OUTER JOIN
                      dbo.Job_CashControlDoc AS c ON b.ClrNo = c.DocNo ON a.AdvNo = b.AdvRefNo
WHERE     (a.DocStatus < 99)



GO
/****** Object:  View [dbo].[vADV_UnClear]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vADV_UnClear] as SELECT DISTINCT dbo.Job_AdvHeader.*, ISNULL(dbo.Job_ClearHeader.DocStatus, 0) AS clrStatus FROM dbo.Job_ClearHeader RIGHT OUTER JOIN dbo.Job_ClearDetail ON dbo.Job_ClearHeader.ClrNo = dbo.Job_ClearDetail.ClrNo RIGHT OUTER JOIN dbo.Job_AdvHeader ON dbo.Job_ClearDetail.AdvNO = dbo.Job_AdvHeader.AdvNo WHERE (dbo.Job_AdvHeader.DocStatus <= 4) AND (ISNULL(dbo.Job_ClearHeader.DocStatus, 0) <= 2)


GO
/****** Object:  View [dbo].[vCheque]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vCheque]
AS
SELECT     dbo.ChequeHeader.*, dbo.ChequeDetail.Seq, dbo.ChequeDetail.JobNo, dbo.ChequeDetail.Expense, dbo.ChequeDetail.Amount, dbo.ChequeDetail.VoucherNo, 
                      dbo.Mas_Company.TaxNumber, dbo.Mas_Company.NameThai, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.Phone, 
                      dbo.Mas_Company.FaxNumber
FROM         dbo.ChequeHeader LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.ChequeHeader.CustCode = dbo.Mas_Company.CustCode LEFT OUTER JOIN
                      dbo.ChequeDetail ON dbo.ChequeHeader.BankID = dbo.ChequeDetail.BankID AND dbo.ChequeHeader.ChequeNo = dbo.ChequeDetail.ChequeNo


GO
/****** Object:  View [dbo].[vChequeHeader]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vChequeHeader]
AS
SELECT     dbo.ChequeHeader.BankID, dbo.ChequeHeader.ChequeNo, dbo.ChequeHeader.ChequeType, dbo.ChequeHeader.ChequeDate, dbo.ChequeHeader.IssueDate, 
                      dbo.ChequeHeader.IssueBy, dbo.ChequeHeader.CustCode, dbo.ChequeHeader.PayTo, dbo.ChequeHeader.Total, dbo.ChequeHeader.ChequeStatus, 
                      dbo.ChequeHeader.BookNo, dbo.ChequeHeader.HaveSquare, dbo.ChequeHeader.Payee, dbo.ChequeHeader.HaveLine, dbo.ChequeHeader.Remark, 
                      dbo.ChequeHeader.Printed, dbo.Mas_Company.NameThai, dbo.Mas_Company.TAddress1, dbo.Mas_Company.TAddress2, dbo.Mas_Company.Phone, 
                      dbo.Mas_Company.FaxNumber, dbo.Mas_Company.TaxNumber
FROM         dbo.ChequeHeader LEFT OUTER JOIN
                      dbo.Mas_Company ON dbo.ChequeHeader.CustCode = dbo.Mas_Company.CustCode


GO
/****** Object:  View [dbo].[vJob_Invoice]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_Invoice]
AS
SELECT     dbo.Job_BillingHeader.JobNo, dbo.Job_BillingDetail.SICode, dbo.Job_SrvSingle.NameThai, dbo.Job_SrvSingle.IsExpense, 
                      dbo.Job_SrvSingle.Is50Tavi, dbo.Job_SrvSingle.IsTaxCharge, dbo.Job_BillingDetail.AmtAdvance AS sumAdvance, 
                      dbo.Job_BillingDetail.AmtCharge AS sumCharge, dbo.Job_BillingDetail.AmtAdvance + dbo.Job_BillingDetail.AmtCharge AS SumAmount, 
                      dbo.Job_BillingHeader.DocNo AS FirstInvoice, dbo.Job_BillingDetail.ItemNo
FROM         dbo.Job_BillingHeader INNER JOIN
                      dbo.Job_BillingDetail ON dbo.Job_BillingHeader.DocNo = dbo.Job_BillingDetail.DocNo AND 
                      dbo.Job_BillingHeader.BranchCode = dbo.Job_BillingDetail.BranchCode LEFT OUTER JOIN
                      dbo.Job_SrvSingle ON dbo.Job_BillingDetail.SICode = dbo.Job_SrvSingle.SICode
WHERE     (NOT (ISNULL(dbo.Job_BillingHeader.CancelProve, '') <> ''))


GO
/****** Object:  View [dbo].[vJob_NoInvoice]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vJob_NoInvoice]
AS
SELECT     dbo.Job_Detail.JNo, dbo.Job_Detail.LinkItem, dbo.Job_Detail.SICode, dbo.Job_SrvSingle.NameThai, dbo.Job_SrvSingle.IsTaxCharge, 
                      dbo.Job_SrvSingle.Is50Tavi, dbo.Job_SrvSingle.IsExpense, dbo.Job_Detail.BPrice, dbo.Job_Detail.BCost, 
                      (CASE WHEN dbo.Job_Detail.BPrice > 0 THEN dbo.Job_Detail.BPrice ELSE dbo.Job_Detail.BCost END) AS sumAmount
FROM         dbo.Job_Detail LEFT OUTER JOIN
                      dbo.Job_SrvSingle ON dbo.Job_Detail.SICode = dbo.Job_SrvSingle.SICode
WHERE     (ISNULL(dbo.Job_Detail.DNNo, '') = '')


GO
/****** Object:  View [dbo].[vKPI]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vKPI]
AS
SELECT     dbo.Job_Order.JNo, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, dbo.Job_Order.ShippingEmp, dbo.Job_Order.ETDDate, dbo.Job_Order.ETADate, 
                      dbo.Job_Order.DocDate, DATEDIFF(d, dbo.Job_Order.DocDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS OpenOntime, 
                      dbo.Job_Order.ClearDate AS CustomAcceptDate, DATEDIFF(d, dbo.Job_Order.ClearDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS EDIOntime, 
                      dbo.Job_Order.ReadyToClearDate AS ReadyClearDate, DATEDIFF(d, dbo.Job_Order.ReadyToClearDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS ShippingOntime, 
                      dbo.Job_Order.DutyDate AS InspectionDate, DATEDIFF(d, dbo.Job_Order.DutyDate, 
                      (CASE WHEN dbo.Job_Order.JobType = 1 THEN dbo.Job_Order.ETADate ELSE dbo.Job_Order.ETDDate END)) AS ClearanceOntime, 
                      dbo.Job_Order.CloseJobDate, DATEDIFF(d, dbo.Job_Order.CloseJobDate,(CASE WHEN dbo.Job_Order.JobType=1 THEN dbo.Job_Order.DutyDate ELSE dbo.Job_Order.ReadyToClearDate END)) AS CloseJobOnTime, 
                      MAX(dbo.Job_AdvHeader.AdvDate) AS LastAdvance, MAX(dbo.Job_ClearHeader.ClrDate) AS LastClearing, MIN(dbo.Job_BillingHeader.DocDate) AS FirstInvoice,
                      MAX(dbo.Job_BillingHeader.DocDate) AS LastInvoice, MAX(dbo.Job_TaxInvoice.InvDate) AS LastReceipt, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, 
                      dbo.Job_Order.ForwarderCode, dbo.Job_Order.AgentCode, dbo.Job_Order.DeclareNumber, dbo.Job_Order.TotalContainer, 
                      dbo.Job_Order.ConfirmChqDate AS AccSentDate, dbo.Job_Order.ConfirmDate AS AccConfirmDate, DATEDIFF(d, dbo.Job_Order.CloseJobDate, 
                      dbo.Job_Order.ConfirmDate) AS ConfirmOntime, DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmChqDate) AS SentOntime
FROM         dbo.Job_TaxInvoice RIGHT OUTER JOIN
                      dbo.Job_BillingHeader ON dbo.Job_TaxInvoice.InvNo = dbo.Job_BillingHeader.TaxInvNo RIGHT OUTER JOIN
                      dbo.Job_Order ON dbo.Job_BillingHeader.JobNo = dbo.Job_Order.JNo LEFT OUTER JOIN
                      dbo.Job_ClearHeader ON dbo.Job_Order.JNo = dbo.Job_ClearHeader.JNo LEFT OUTER JOIN
                      dbo.Job_AdvHeader ON dbo.Job_Order.JNo = dbo.Job_AdvHeader.JNo
GROUP BY dbo.Job_Order.JNo, dbo.Job_Order.CustCode, dbo.Job_Order.CSCode, dbo.Job_Order.ShippingEmp, dbo.Job_Order.ETDDate, 
                      dbo.Job_Order.ETADate, dbo.Job_Order.DocDate, dbo.Job_Order.ClearDate, dbo.Job_Order.ReadyToClearDate, dbo.Job_Order.DutyDate, 
                      dbo.Job_Order.CloseJobDate, dbo.Job_Order.JobStatus, dbo.Job_Order.JobType, dbo.Job_Order.ShipBy, dbo.Job_Order.ForwarderCode, 
                      dbo.Job_Order.AgentCode, dbo.Job_Order.DeclareNumber, dbo.Job_Order.TotalContainer, dbo.Job_Order.ConfirmChqDate, dbo.Job_Order.ConfirmDate, 
                      DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmDate), DATEDIFF(d, dbo.Job_Order.CloseJobDate, dbo.Job_Order.ConfirmChqDate)





GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IDX_BudgetPolicy]    Script Date: 17/05/2019 13:56:30 ******/
CREATE NONCLUSTERED INDEX [IDX_BudgetPolicy] ON [dbo].[Job_BudgetPolicy]
(
	[Active] ASC,
	[BranchCode] ASC,
	[JobType] ASC,
	[ShipBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [AdvQty]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Job_AdvHeader] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ItemNo]  DEFAULT ((0)) FOR [ItemNo]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtAdvance]  DEFAULT ((0)) FOR [AmtAdvance]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtCharge]  DEFAULT ((0)) FOR [AmtCharge]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ExchangeRate]  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ExchangeRateCredit]  DEFAULT ((0)) FOR [ExchangeRateCredit]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignAmtCredit]  DEFAULT ((0)) FOR [ForeignAmtCredit]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_DiscountPerc]  DEFAULT ((0)) FOR [DiscountPerc]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_AmtDiscount]  DEFAULT ((0)) FOR [AmtDiscount]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_ForeignDisc]  DEFAULT ((0)) FOR [ForeignDisc]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FUnitPrice]  DEFAULT ((0)) FOR [FUnitPrice]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FQty]  DEFAULT ((0)) FOR [FQty]
GO
ALTER TABLE [dbo].[Job_BillingDetail] ADD  CONSTRAINT [DF_Job_BillDSub_FTotalAmt]  DEFAULT ((0)) FOR [FTotalAmt]
GO
ALTER TABLE [dbo].[Job_BillingHeader] ADD  CONSTRAINT [DF_Job_BillingHeader_Revise]  DEFAULT ((0)) FOR [Revise]
GO
ALTER TABLE [dbo].[Job_OSRCreditNote] ADD  CONSTRAINT [DF_Job_KSACreditNote_TotalCharge]  DEFAULT ((0)) FOR [TotalCharge]
GO
ALTER TABLE [dbo].[Job_OSRCreditNote] ADD  CONSTRAINT [DF_Job_KSACreditNote_TotalVAT]  DEFAULT ((0)) FOR [TotalVAT]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ItemNo]  DEFAULT ((0)) FOR [ItemNo]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtAdvance]  DEFAULT ((0)) FOR [AmtAdvance]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtCharge]  DEFAULT ((0)) FOR [AmtCharge]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ExchangeRate]  DEFAULT ((0)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ExchangeRateCredit]  DEFAULT ((0)) FOR [ExchangeRateCredit]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignAmtCredit]  DEFAULT ((0)) FOR [ForeignAmtCredit]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_DiscountPerc]  DEFAULT ((0)) FOR [DiscountPerc]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_AmtDiscount]  DEFAULT ((0)) FOR [AmtDiscount]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_ForeignDisc]  DEFAULT ((0)) FOR [ForeignDisc]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FUnitPrice]  DEFAULT ((0)) FOR [FUnitPrice]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FQty]  DEFAULT ((0)) FOR [FQty]
GO
ALTER TABLE [dbo].[Job_PaymentDetail] ADD  CONSTRAINT [DF_Job_PaymentDetail_FTotalAmt]  DEFAULT ((0)) FOR [FTotalAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_JobBillAmt]  DEFAULT ((0)) FOR [JobBillAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_VATRate]  DEFAULT ((0)) FOR [VATRate]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate1]  DEFAULT ((0)) FOR [Tavi50Rate1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Tavi50Rate2]  DEFAULT ((0)) FOR [Tavi50Rate2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalAdvance]  DEFAULT ((0)) FOR [TotalAdvance]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalCharge]  DEFAULT ((0)) FOR [TotalCharge]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIsTaxCharge]  DEFAULT ((0)) FOR [TotalIsTaxCharge]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi1]  DEFAULT ((0)) FOR [TotalIs50Tavi1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalIs50Tavi2]  DEFAULT ((0)) FOR [TotalIs50Tavi2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalVAT]  DEFAULT ((0)) FOR [TotalVAT]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi1]  DEFAULT ((0)) FOR [Total50Tavi1]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Total50Tavi2]  DEFAULT ((0)) FOR [Total50Tavi2]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalCustAdv]  DEFAULT ((0)) FOR [TotalCustAdv]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_TotalNet]  DEFAULT ((0)) FOR [TotalNet]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_PaidFlag]  DEFAULT ((0)) FOR [PaidFlag]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_ExchangeRate]  DEFAULT ((0)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_ForeignAmt]  DEFAULT ((0)) FOR [ForeignAmt]
GO
ALTER TABLE [dbo].[Job_PaymentHeader] ADD  CONSTRAINT [DF_Job_PaymentHeader_Revise]  DEFAULT ((0)) FOR [Revise]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitCost]  DEFAULT ((0)) FOR [UnitCost]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitQTY]  DEFAULT ((1)) FOR [UnitQTY]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_CurrencyRate]  DEFAULT ((1)) FOR [CurrencyRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_Isvat]  DEFAULT ((0)) FOR [Isvat]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_VatRate]  DEFAULT ((0)) FOR [VatRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_VatAmt]  DEFAULT ((0)) FOR [VatAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_IsTax]  DEFAULT ((0)) FOR [IsTax]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TaxRate]  DEFAULT ((0)) FOR [TaxRate]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TaxAmt]  DEFAULT ((0)) FOR [TaxAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_TotalAmt]  DEFAULT ((0)) FOR [TotalAmt]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_ForeignAmt]  DEFAULT ((0)) FOR [CurrentTHB]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntPerc]  DEFAULT ((0)) FOR [UnitDiscntPerc]
GO
ALTER TABLE [dbo].[Job_QuoDetailItem] ADD  CONSTRAINT [DF_Job_QuoDetailItem_UnitDiscntAmt]  DEFAULT ((0)) FOR [UnitDiscntAmt]
GO
ALTER TABLE [dbo].[Job_QuoHeader] ADD  CONSTRAINT [DF_Job_QuoHeader_ExchageRate]  DEFAULT ((0)) FOR [ExchageRate]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsTaxCharge]  DEFAULT ((0)) FOR [IsTaxCharge]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_Is50Tavi]  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_Rate50Tavi]  DEFAULT ((0)) FOR [Rate50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsCredit]  DEFAULT ((0)) FOR [IsCredit]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsExpense]  DEFAULT ((0)) FOR [IsExpense]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsShowPrice]  DEFAULT ((0)) FOR [IsShowPrice]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsHaveSlip]  DEFAULT ((0)) FOR [IsHaveSlip]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsPay50TaviTo]  DEFAULT ((0)) FOR [IsPay50TaviTo]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsLtdAdv50Tavi]  DEFAULT ((0)) FOR [IsLtdAdv50Tavi]
GO
ALTER TABLE [dbo].[Job_SrvSingle] ADD  CONSTRAINT [DF_Job_SrvSingle_IsUsedCoSlip]  DEFAULT ((0)) FOR [IsUsedCoSlip]
GO
ALTER TABLE [dbo].[Job_TaxInvoiceDetail] ADD  CONSTRAINT [DF_Job_TaxInvoiceDetail_BranchCode]  DEFAULT ((0)) FOR [BranchCode]
GO
ALTER TABLE [dbo].[Mas_BookAccount] ADD  CONSTRAINT [DF_Mas_BookAccount_IsLocal]  DEFAULT ((0)) FOR [IsLocal]
GO
ALTER TABLE [dbo].[Mas_BookAccount] ADD  DEFAULT ((0)) FOR [LimitBalance]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CustType]  DEFAULT ((0)) FOR [CustType]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_Is19bis]  DEFAULT ((0)) FOR [Is19bis]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_MgrSeq]  DEFAULT ((0)) FOR [MgrSeq]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_LevelNoExp]  DEFAULT ((0)) FOR [LevelNoExp]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_LevelNoImp]  DEFAULT ((0)) FOR [LevelNoImp]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_DutyLimit]  DEFAULT ((0)) FOR [DutyLimit]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CommRate]  DEFAULT ((0)) FOR [CommRate]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_GoldCardNO]  DEFAULT ((0)) FOR [GoldCardNO]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_CustomsBrokerSeq]  DEFAULT ((0)) FOR [CustomsBrokerSeq]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSign]  DEFAULT ((0)) FOR [ISCustomerSign]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignInv]  DEFAULT ((0)) FOR [ISCustomerSignInv]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignDec]  DEFAULT ((0)) FOR [ISCustomerSignDec]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_ISCustomerSignECon]  DEFAULT ((0)) FOR [ISCustomerSignECon]
GO
ALTER TABLE [dbo].[Mas_Company] ADD  CONSTRAINT [DF_Mas_Company_IsShippingCannotSign]  DEFAULT ((0)) FOR [IsShippingCannotSign]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_BranchCode]  DEFAULT ((0)) FOR [BranchCode]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_JobType]  DEFAULT ((0)) FOR [JobType]
GO
ALTER TABLE [dbo].[MAS_GLACCOUNT] ADD  CONSTRAINT [DF_MAS_GLACCOUNT_ShipBy]  DEFAULT ((0)) FOR [ShipBy]
GO
/****** Object:  StoredProcedure [dbo].[RefreshJobStatus]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RefreshJobStatus]
(
@JobNo varchar(20)
)
as
BEGIN
--status wait for processs--????????????????????
update a
set a.JobStatus =1 
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is null and a.JobStatus<>99 and a.JobStatus<>1
and a.JNo=@JobNo

--status process check from clearing or have adv =?????????????????? ??????????????????? ??????????????????
update a
set JobStatus =2  
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is not null and a.Jobstatus<>99 and a.JobStatus<>2
and a.JNo=@JobNo

update a 
set JobStatus =2
from Job_Order a inner join Job_Detail b on a.JNo=b.JNo where b.ClearingNO <>''
and a.JobStatus<>99 and a.JobStatus<>2
and a.JNo=@JobNo

--status close check from have closejobdate ??????????????????
update a 
set JobStatus =3
from Job_Order a where a.CloseJobBy<>'' and a.JobStatus <>99 and a.JobStatus<>3
and a.JNo=@JobNo

--status part billing check from job which have item that not issue invoice ?????????????????????????????????????????
update a
set jobstatus=4
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where ISNULL(c.IsExpense,0) =0 and ISNULL(b.DNNo,'') ='' and b.BPrice>0
and a.JNo in(select JNo from Job_detail where JNo=b.JNo and ISNULL(DNNo,'')<>'')
and a.JobStatus <>99 and a.JobStatus<>4
and a.JNo=@JobNo

--status full billing check from job which every income have invoice  ??????????????????????
update d
set JobStatus=5
from Job_Order d
where d.JNo not in(
select distinct a.JNo 
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo)
and d.JNo in(select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>'')
and d.JobStatus<>99 and d.JobStatus<>5
and d.JNo=@JobNo
--status complete when every invoice from Job have receipt ?????????????????????

update d
set JobStatus=6
from Job_Order d
where d.JNo not in(
		select distinct a.JNo 
		from Job_Order a inner join Job_detail b 
		on a.JNo=b.JNo left join Job_SrvSingle c 
		on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 
		and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo
		)
	and d.JNo in(
		select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>''
		)
	and d.JNo not in(
		select distinct e.JNo from Job_detail e where e.JNo=d.JNo and ISNULL(e.DNNo,'')<>'' and
		e.DNNo IN(select DocNo from Job_BillingHeader where DocNo=e.DNNo and ISNULL(TaxInvNo,'')='' And Not CancelProve<>'' And TotalCharge>0)
		)
	and d.JNo not in(
		select JobNo from qJob_BillBalance where Balance>0 and JobNo=d.JNo
		)
and d.JobStatus<>99 and d.JobStatus>=3 and d.JobStatus<>6
and d.JNo=@JobNo

--????????????
update Job_Order set JobStatus=99 where CancelProve<>'' and JobStatus<>99
and JNo=@JobNo

END

GO
/****** Object:  StoredProcedure [dbo].[RefreshStatusAll]    Script Date: 17/05/2019 13:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RefreshStatusAll]
as
BEGIN
--status wait for processs--????????????????????
update a
set a.JobStatus =1 
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is null and a.JobStatus<>99 and a.JobStatus<>1

--status process check from clearing or have adv =?????????????????? ??????????????????? ??????????????????
update a
set JobStatus =2  
from Job_order a left join Job_AdvHeader b on a.JNo=b.JNo
where b.AdvNo is not null and a.Jobstatus<>99 and a.JobStatus<>2

update a 
set JobStatus =2
from Job_Order a inner join Job_Detail b on a.JNo=b.JNo where b.ClearingNO <>''
and a.JobStatus<>99 and a.JobStatus<>2

--status close check from have closejobdate ??????????????????
update a 
set JobStatus =3
from Job_Order a where a.CloseJobBy<>'' and a.JobStatus <>99 and a.JobStatus<>3

--status part billing check from job which have item that not issue invoice ?????????????????????????????????????????
update a
set jobstatus=4
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where ISNULL(c.IsExpense,0) =0 and ISNULL(b.DNNo,'') ='' and b.BPrice>0
and a.JNo in(select JNo from Job_detail where JNo=b.JNo and ISNULL(DNNo,'')<>'')
and a.JobStatus <>99 and a.JobStatus<>4

--status full billing check from job which every income have invoice  ??????????????????????
update d
set JobStatus=5
from Job_Order d
where d.JNo not in(
select distinct a.JNo 
from Job_Order a inner join Job_detail b 
on a.JNo=b.JNo left join Job_SrvSingle c 
on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo)
and d.JNo in(select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>'')
and d.JobStatus<>99 and d.JobStatus<>5
--status complete when every invoice from Job have receipt ?????????????????????

update d
set JobStatus=6
from Job_Order d
where d.JNo not in(
		select distinct a.JNo 
		from Job_Order a inner join Job_detail b 
		on a.JNo=b.JNo left join Job_SrvSingle c 
		on b.SICode=c.SICode where isnull(c.IsExpense,0) =0 and b.BPrice>0 
		and ISNULL(b.DNNo,'')='' and a.JNo=d.JNo
		)
	and d.JNo in(
		select distinct JNo from Job_detail where JNo=d.JNo and ISNULL(DNNo,'')<>''
		)
	and d.JNo not in(
		select distinct e.JNo from Job_detail e where e.JNo=d.JNo and ISNULL(e.DNNo,'')<>'' and
		e.DNNo IN(select DocNo from Job_BillingHeader where DocNo=e.DNNo and ISNULL(TaxInvNo,'')='' And Not CancelProve<>'' And TotalCharge>0)
		)
	and d.JNo not in(
		select JobNo from qJob_BillBalance where Balance>0 And JobNo=d.JNo
		)
and d.JobStatus<>99 and d.JobStatus>=3 and d.JobStatus<>6

--????????????
update Job_Order set JobStatus=99 where CancelProve<>'' and JobStatus<>99

END





GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[31] 2[36] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mas_Customers"
            Begin Extent = 
               Top = 0
               Left = 407
               Bottom = 92
               Right = 592
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 142
               Bottom = 374
               Right = 333
            End
            DisplayFlags = 280
            TopColumn = 75
         End
         Begin Table = "Mas_Consignee"
            Begin Extent = 
               Top = 103
               Left = 414
               Bottom = 348
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1920
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_CostJoinProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[16] 2[84] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_ClearDetail"
            Begin Extent = 
               Top = 14
               Left = 214
               Bottom = 388
               Right = 370
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_Detail"
            Begin Extent = 
               Top = 8
               Left = 407
               Bottom = 365
               Right = 549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_PaymentRef"
            Begin Extent = 
               Top = 2
               Left = 26
               Bottom = 152
               Right = 178
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Vender"
            Begin Extent = 
               Top = 156
               Left = 38
               Bottom = 275
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 11
               Left = 595
               Bottom = 375
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_RSlip"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 429
            End
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'          DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT"
            Begin Extent = 
               Top = 399
               Left = 802
               Bottom = 582
               Right = 954
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialCostReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[64] 2[36] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[26] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 364
               Bottom = 361
               Right = 546
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_RSlip"
            Begin Extent = 
               Top = 7
               Left = 813
               Bottom = 133
               Right = 965
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Customers"
            Begin Extent = 
               Top = 142
               Left = 813
               Bottom = 299
               Right = 998
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT"
            Begin Extent = 
               Top = 315
               Left = 833
               Bottom = 493
               Right = 985
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 4
               Left = 94
               Bottom = 359
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_FinancialSalesReport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[44] 2[30] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[95] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControl"
            Begin Extent = 
               Top = 0
               Left = 76
               Bottom = 468
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 21
               Left = 604
               Bottom = 431
               Right = 821
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlSub"
            Begin Extent = 
               Top = 12
               Left = 300
               Bottom = 496
               Right = 553
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2490
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_PaymentRef'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[14] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Q_CostJoinProfit"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 343
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 15
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCalculate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[9] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_Detail"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 245
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 246
               Left = 38
               Bottom = 365
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitCost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[30] 2[47] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -672
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 363
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 320
               Bottom = 780
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2280
         Width = 2115
         Width = 1905
         Width = 3345
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ProfitSales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[51] 2[21] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Q_CostJoinProfit"
            Begin Extent = 
               Top = 3
               Left = 340
               Bottom = 360
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_ProfitCalculate"
            Begin Extent = 
               Top = 7
               Left = 550
               Bottom = 328
               Right = 702
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 40
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 7' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'20
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_ReportCostAndProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[63] 2[32] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[90] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 0
               Left = 99
               Bottom = 618
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_PaymentRef"
            Begin Extent = 
               Top = 0
               Left = 344
               Bottom = 180
               Right = 523
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Q_VouherStateOne"
            Begin Extent = 
               Top = 5
               Left = 566
               Bottom = 224
               Right = 735
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 3
               Left = 792
               Bottom = 554
               Right = 991
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Mas_BookAccount"
            Begin Extent = 
               Top = 444
               Left = 365
               Bottom = 643
               Right = 563
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 180
               Left = 395
               Bottom = 310
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'idth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_StatementAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[4] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateOne'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[34] 2[43] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[85] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 6
               Left = 154
               Bottom = 656
               Right = 365
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 12
               Left = 443
               Bottom = 283
               Right = 614
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Q_VouherStateTwo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 6
               Left = 50
               Bottom = 320
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_AdvDetail"
            Begin Extent = 
               Top = 0
               Left = 309
               Bottom = 359
               Right = 469
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[66] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[76] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4[60] 2) )"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 260
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 6
               Left = 306
               Bottom = 144
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlDoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[58] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControl"
            Begin Extent = 
               Top = 0
               Left = 147
               Bottom = 322
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 0
               Left = 411
               Bottom = 298
               Right = 581
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlHeder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[43] 2[16] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlDoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 275
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QE_UnionCashJob"
            Begin Extent = 
               Top = 6
               Left = 289
               Bottom = 277
               Right = 459
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlRefJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[3] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[89] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CashControlSub"
            Begin Extent = 
               Top = 0
               Left = 133
               Bottom = 433
               Right = 303
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "QE_CashControlRefJob"
            Begin Extent = 
               Top = 6
               Left = 439
               Bottom = 138
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CashControlSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_ClearHeader"
            Begin Extent = 
               Top = 0
               Left = 193
               Bottom = 362
               Right = 353
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_ClearDetail"
            Begin Extent = 
               Top = 6
               Left = 391
               Bottom = 360
               Right = 555
            End
            DisplayFlags = 280
            TopColumn = 19
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_Clearing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[47] 2[7] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CustAdvChq"
            Begin Extent = 
               Top = 10
               Left = 30
               Bottom = 369
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Job_CustAdvChqSub"
            Begin Extent = 
               Top = 3
               Left = 282
               Bottom = 364
               Right = 475
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_CustAdvanceCheqHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 0
               Left = 91
               Bottom = 334
               Right = 287
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_PaymentDetail"
            Begin Extent = 
               Top = 0
               Left = 379
               Bottom = 307
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_InvoiceAPDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 325
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 81
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_ListSelectJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "QE_QuotationHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 345
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetail"
            Begin Extent = 
               Top = 0
               Left = 325
               Bottom = 314
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QoutationDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 10
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "QE_QuotationHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 353
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetailItem"
            Begin Extent = 
               Top = 1
               Left = 283
               Bottom = 350
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 14
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuoDetailItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[15] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_QuoHeader"
            Begin Extent = 
               Top = 0
               Left = 61
               Bottom = 306
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 289
               Bottom = 210
               Right = 488
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_QuotationHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[22] 2[33] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[21] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'QE_UnionCashJob'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[43] 2[4] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2100
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_AdvHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[9] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[91] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 100
               Left = 763
               Bottom = 361
               Right = 953
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingDetail"
            Begin Extent = 
               Top = 0
               Left = 483
               Bottom = 373
               Right = 681
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 5
               Left = 0
               Bottom = 376
               Right = 167
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 88
               Left = 263
               Bottom = 203
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 52
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 203
               Left = 260
               Bottom = 318
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Pan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'eHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 242
               Bottom = 84
               Right = 393
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 84
               Left = 242
               Bottom = 192
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 192
               Left = 266
               Bottom = 270
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_BillHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[14] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_CustAdvHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Job_CustAdvDetail"
            Begin Extent = 
               Top = 6
               Left = 228
               Bottom = 121
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 126
               Left = 267
               Bottom = 241
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_CustAdvance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 45
               Left = 391
               Bottom = 160
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 18
         End
         Begin Table = "Job_DebitNote"
            Begin Extent = 
               Top = 0
               Left = 19
               Bottom = 115
               Right = 171
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "Job_DebitNoteSub"
            Begin Extent = 
               Top = 11
               Left = 206
               Bottom = 126
               Right = 358
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 10
               Left = 574
               Bottom = 125
               Right = 759
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_DebitNoteSub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 12
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Detail"
            Begin Extent = 
               Top = 0
               Left = 459
               Bottom = 517
               Right = 627
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Branch"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 215
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 126
               Left = 236
               Bottom = 245
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Agent"
            Begin Extent = 
               Top = 216
               Left = 38
               Bottom = 335
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 246
               Left = 236
               Bottom = 365
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_RFARS"
            Begin Extent = 
               Top = 336
               Left = 38
               Bottom = 455
               Right = 198
            End
            Di' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'splayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_RFICC"
            Begin Extent = 
               Top = 366
               Left = 236
               Bottom = 485
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_ServUnitType"
            Begin Extent = 
               Top = 456
               Left = 38
               Bottom = 575
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 6
               Left = 665
               Bottom = 364
               Right = 855
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[56] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 2
               Left = 250
               Bottom = 352
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 77
         End
         Begin Table = "Mas_Vender"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 11
               Left = 500
               Bottom = 126
               Right = 663
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "f"
            Begin Extent = 
               Top = 174
               Left = 527
               Bottom = 289
               Right = 688
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 308
               Left = 521
               Bottom = 423
               Right = 673
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 366
               Left = 38
               Bottom = 481
               Right = 195
            End
            DisplayFlags = 280
            TopColumn = 0
      ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1380
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[36] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 0
               Left = 375
               Bottom = 211
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_PaymentDetail"
            Begin Extent = 
               Top = 0
               Left = 638
               Bottom = 115
               Right = 790
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 130
               Left = 695
               Bottom = 360
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 51
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[72] 2[23] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_PaymentHeader"
            Begin Extent = 
               Top = 3
               Left = 20
               Bottom = 291
               Right = 200
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Branch"
            Begin Extent = 
               Top = 0
               Left = 456
               Bottom = 132
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 0
               Left = 636
               Bottom = 374
               Right = 842
            End
            DisplayFlags = 280
            TopColumn = 45
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 0
               Left = 267
               Bottom = 343
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'er = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_PayHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[22] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[92] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 165
               Left = 203
               Bottom = 401
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 51
         End
         Begin Table = "Job_QuoHeader"
            Begin Extent = 
               Top = 0
               Left = 558
               Bottom = 342
               Right = 710
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetailItem"
            Begin Extent = 
               Top = 14
               Left = 5
               Bottom = 302
               Right = 175
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_QuoDetail"
            Begin Extent = 
               Top = 20
               Left = 225
               Bottom = 214
               Right = 377
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User_1"
            Begin Extent = 
               Top = 155
               Left = 259
               Bottom = 270
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_User"
            Begin Extent = 
               Top = 169
               Left = 370
               Bottom = 284
               Right = 527
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 60
         Width = 284
         Width = 150' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_Quotation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_RSlip"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 301
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_RSlipSub"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 316
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2250
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qJob_RSlip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 257
               Bottom = 354
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 3
               Left = 514
               Bottom = 376
               Right = 704
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAS_GLACCOUNT_1"
            Begin Extent = 
               Top = 2
               Left = 770
               Bottom = 261
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 2220
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 900
         Width = 1500
         Width = 885
         Width = 1035
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1185
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_CostState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[26] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 419
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 50
         End
         Begin Table = "Asrv"
            Begin Extent = 
               Top = 0
               Left = 231
               Bottom = 272
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Bsrv"
            Begin Extent = 
               Top = 0
               Left = 472
               Bottom = 274
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1770
         Width = 1500
         Width = 990
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_ksat_Biggg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[67] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MAS_GLACCOUNT_1"
            Begin Extent = 
               Top = 2
               Left = 770
               Bottom = 261
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 0
               Left = 257
               Bottom = 354
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 3
               Left = 514
               Bottom = 376
               Right = 704
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 2220
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 900
         Width = 1500
         Width = 885
         Width = 1035
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1185
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_SalseState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[51] 2[14] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[94] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -864
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 725
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 22
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvFristStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_BillDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'qrpt_TaxInvSecondStep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChequeHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChequeDetail"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 114
               Right = 378
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 128
               Left = 233
               Bottom = 236
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 11
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vCheque'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChequeHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 209
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mas_Company"
            Begin Extent = 
               Top = 6
               Left = 227
               Bottom = 216
               Right = 411
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChequeHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[29] 2[39] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_ClearDetail"
            Begin Extent = 
               Top = 2
               Left = 95
               Bottom = 474
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "qJob_CashControl"
            Begin Extent = 
               Top = 0
               Left = 372
               Bottom = 436
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_RefClr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[15] 4[25] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 207
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[32] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Job_BillingDetail"
            Begin Extent = 
               Top = 16
               Left = 249
               Bottom = 167
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 11
               Left = 488
               Bottom = 126
               Right = 645
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[38] 2[7] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_Detail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 207
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_SrvSingle"
            Begin Extent = 
               Top = 4
               Left = 348
               Bottom = 205
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_NoInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[11] 4[36] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1560
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2610
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[13] 4[23] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "qJob_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vJob_VolumeByCust'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[31] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Job_TaxInvoice"
            Begin Extent = 
               Top = 0
               Left = 684
               Bottom = 232
               Right = 844
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_BillingHeader"
            Begin Extent = 
               Top = 0
               Left = 439
               Bottom = 115
               Right = 606
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 62
         End
         Begin Table = "Job_ClearHeader"
            Begin Extent = 
               Top = 170
               Left = 598
               Bottom = 438
               Right = 750
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_AdvHeader"
            Begin Extent = 
               Top = 235
               Left = 383
               Bottom = 503
               Right = 535
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 14' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'40
         Alias = 3555
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[39] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 168
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job_Order"
            Begin Extent = 
               Top = 6
               Left = 418
               Bottom = 207
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 157
               Left = 328
               Bottom = 272
               Right = 480
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vKPI_Advance'
GO
USE [master]
GO
ALTER DATABASE [JOB_WEB] SET  READ_WRITE 
GO
