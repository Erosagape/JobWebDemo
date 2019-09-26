USE [tawantec_job_apl]
GO
/****** Object:  Table [dbo].[Job_AdvDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_AdvHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_BillAcceptDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
	[AmtCustAdvance] [float] NULL,
	[AmtForeign] [float] NULL,
	[InvDate] [datetime] NULL,
	[RefNo] [nvarchar](max) NULL,
	[AmtVATRate] [float] NULL,
	[AmtWHRate] [float] NULL,
	[AmtDiscount] [float] NULL,
	[AmtDiscRate] [float] NULL,
 CONSTRAINT [PK_BillAcceptD] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BillAcceptHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
	[EmpCode] [varchar](10) NULL,
	[RecDateTime] [datetime] NULL,
	[TotalCustAdv] [float] NULL,
	[TotalAdvance] [float] NULL,
	[TotalChargeVAT] [float] NULL,
	[TotalChargeNonVAT] [float] NULL,
	[TotalVAT] [float] NULL,
	[TotalWH] [float] NULL,
	[TotalDiscount] [float] NULL,
	[TotalNet] [float] NULL,
 CONSTRAINT [PK_BillAcceptH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BillAcceptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_BudgetPolicy]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_CashControl]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_CashControlDoc]    Script Date: 25/09/2019 14:13:38 ******/
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
	[DocNo] [varchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[Job_CashControlSub]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_ClearDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_ClearExp]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_ClearExp](
	[BranchCode] [varchar](5) NOT NULL,
	[JNo] [varchar](15) NOT NULL,
	[SICode] [nvarchar](10) NOT NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[AmountCharge] [float] NULL,
	[Status] [varchar](5) NULL,
 CONSTRAINT [PK_ClearExp] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC,
	[SICode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_ClearHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_CNDNDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
	[Is50Tavi] [int] NULL,
	[WHTRate] [float] NULL,
	[WHTAmt] [float] NULL,
	[BillItemNo] [int] NULL,
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
/****** Object:  Table [dbo].[Job_CNDNHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_Document]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_GLDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_GLHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_InvoiceDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_InvoiceHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
	[RefNo] [nvarchar](max) NULL,
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
	[SumDiscount] [float] NULL,
	[DiscountRate] [float] NULL,
	[DiscountCal] [float] NULL,
	[TotalDiscount] [float] NULL,
 CONSTRAINT [PK_InvH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_LoadInfo]    Script Date: 25/09/2019 14:13:38 ******/
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
	[BookingNo] [varchar](50) NOT NULL,
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
 CONSTRAINT [PK_LoadInfo] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BookingNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_LoadInfoDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
	[BookingNo] [varchar](50) NOT NULL,
	[TimeUsed] [float] NULL,
	[DeliveryNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoadInfoDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BookingNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_Order]    Script Date: 25/09/2019 14:13:38 ******/
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
	[DeliveryNo] [nvarchar](50) NULL,
	[DeliveryTo] [nvarchar](500) NULL,
	[DeliveryAddr] [nvarchar](max) NULL,
 CONSTRAINT [pk_JobOrder] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[JNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_PaymentDetail]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_PaymentDetail](
	[BranchCode] [varchar](3) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[SICode] [varchar](10) NULL,
	[SDescription] [varchar](255) NULL,
	[SRemark] [varchar](100) NULL,
	[Qty] [float] NOT NULL,
	[QtyUnit] [varchar](30) NULL,
	[UnitPrice] [varchar](30) NULL,
	[IsTaxCharge] [tinyint] NOT NULL,
	[Is50Tavi] [tinyint] NOT NULL,
	[DiscountPerc] [float] NOT NULL,
	[Amt] [float] NOT NULL,
	[AmtDisc] [float] NOT NULL,
	[AmtVAT] [float] NOT NULL,
	[AmtWHT] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[FTotal] [float] NOT NULL,
	[ForJNo] [varchar](50) NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_PaymentHeader]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_PaymentHeader](
	[BranchCode] [varchar](5) NOT NULL,
	[DocNo] [varchar](15) NOT NULL,
	[DocDate] [datetime] NULL,
	[VenCode] [varchar](15) NULL,
	[ContactName] [varchar](100) NULL,
	[EmpCode] [varchar](10) NULL,
	[PoNo] [varchar](50) NULL,
	[VATRate] [float] NOT NULL,
	[TaxRate] [float] NOT NULL,
	[TotalExpense] [float] NOT NULL,
	[TotalTax] [float] NOT NULL,
	[TotalVAT] [float] NOT NULL,
	[TotalDiscount] [float] NOT NULL,
	[TotalNet] [float] NOT NULL,
	[Remark] [varchar](max) NULL,
	[CancelReson] [varchar](100) NULL,
	[CancelProve] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelTime] [datetime] NULL,
	[CurrencyCode] [varchar](50) NULL,
	[ExchangeRate] [float] NOT NULL,
	[ForeignAmt] [float] NOT NULL,
	[RefNo] [varchar](50) NULL,
	[PayType] [varchar](2) NULL,
 CONSTRAINT [PK_PaymentH] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_QuotationDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_QuotationHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_QuotationItem]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_ReceiptDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_ReceiptHeader]    Script Date: 25/09/2019 14:13:38 ******/
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
	[FTotalNet] [float] NULL,
 CONSTRAINT [PK_ReceiptHeader] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_SrvGroup]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_SrvSingle]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_WHTax]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Job_WHTaxDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_Account]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_Account](
	[AccCode] [varchar](10) NOT NULL,
	[AccTName] [nvarchar](255) NULL,
	[AccEName] [nvarchar](255) NULL,
	[AccType] [int] NULL,
	[AccMain] [varchar](20) NULL,
	[AccSide] [char](1) NULL,
 CONSTRAINT [PK_Mas_Account] PRIMARY KEY CLUSTERED 
(
	[AccCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_BookAccount]    Script Date: 25/09/2019 14:13:38 ******/
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
	[GLAccountCode] [varchar](10) NULL,
 CONSTRAINT [pk_masbookacc] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[BookCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Branch]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_Company]    Script Date: 25/09/2019 14:13:38 ******/
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
	[TAddress1] [nvarchar](max) NULL,
	[TAddress2] [nvarchar](max) NULL,
	[EAddress1] [nvarchar](max) NULL,
	[EAddress2] [nvarchar](max) NULL,
	[Phone] [nvarchar](255) NULL,
	[FaxNumber] [nvarchar](255) NULL,
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
	[TAddress] [nvarchar](max) NULL,
	[TDistrict] [nvarchar](max) NULL,
	[TSubProvince] [nvarchar](max) NULL,
	[TProvince] [nvarchar](255) NULL,
	[TPostCode] [nvarchar](255) NULL,
	[DMailAddress] [nvarchar](255) NULL,
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
	[WEB_SITE] [nvarchar](max) NULL,
 CONSTRAINT [pk_company] PRIMARY KEY CLUSTERED 
(
	[CustCode] ASC,
	[Branch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_CompanyContact]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_CompanyContact](
	[CustCode] [varchar](15) NOT NULL,
	[Branch] [varchar](10) NOT NULL,
	[ItemNo] [smallint] NOT NULL,
	[Department] [nvarchar](255) NULL,
	[Position] [nvarchar](255) NULL,
	[ContactName] [nvarchar](max) NULL,
	[EMail] [varchar](255) NULL,
	[Phone] [varchar](255) NULL,
 CONSTRAINT [PK_CustContact] PRIMARY KEY CLUSTERED 
(
	[CustCode] ASC,
	[Branch] ASC,
	[ItemNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_Config]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_CurrencyCode]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[MAS_GLACCOUNT]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_User]    Script Date: 25/09/2019 14:13:38 ******/
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
	[MobilePhone] [varchar](50) NULL,
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
	[DeptID] [nvarchar](10) NULL,
 CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserAuth]    Script Date: 25/09/2019 14:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mas_UserAuth](
	[UserID] [varchar](50) NOT NULL,
	[AppID] [varchar](255) NOT NULL,
	[MenuID] [varchar](255) NOT NULL,
	[Author] [varchar](10) NULL,
	CONSTRAINT [pk_userauth] PRIMARY KEY CLUSTERED 
(
	[UserID],[AppID],[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mas_UserRole]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_UserRoleDetail]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_UserRolePolicy]    Script Date: 25/09/2019 14:13:38 ******/
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
/****** Object:  Table [dbo].[Mas_Vender]    Script Date: 25/09/2019 14:13:38 ******/
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
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'ADV', N'Credit Advances', N'1030', 1, 0, 0, 0, 1, 0, 1, 0)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'CST', N'Costs', N'5000', 1, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'ERN', N'Earnests', N'1910', 1, 0, 0, 0, 0, 1, 1, 0)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'FR0', N'Freights (NO-WHT)', N'4050', 1, 2, 0, 0, 1, 0, 1, 0)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'FR1', N'Freights (WHT)', N'4050', 1, 1, 1, 1, 1, 0, 1, 1)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'SRV', N'Services (Vat 7,WHT 3)', N'4010', 1, 1, 1, 3, 0, 0, 0, 0)
INSERT [dbo].[Job_SrvGroup] ([GroupCode], [GroupName], [GLAccountCode], [IsApplyPolicy], [IsTaxCharge], [Is50Tavi], [Rate50Tavi], [IsCredit], [IsExpense], [IsHaveSlip], [IsLtdAdv50Tavi]) VALUES (N'TRN', N'Transportations', N'4060', 1, 0, 1, 1, 1, 0, 1, 1)
INSERT [dbo].[Mas_Branch] ([Code], [BrName]) VALUES (N'00', N'สำนักงานใหญ่')
INSERT [dbo].[Mas_Branch] ([Code], [BrName]) VALUES (N'01', N'แหลมฉบัง')
INSERT [dbo].[Mas_Branch] ([Code], [BrName]) VALUES (N'02', N'สุวรรณภูมิ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'01', N'REQUEST')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'02', N'APPROVE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'03', N'PAYMENT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'04', N'PART-CLEARING')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'05', N'FULL-CLEARING')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'06', N'CLEARED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_STATUS', N'99', N'CANCELLED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_TYPE', N'01', N'ค่าใช้จ่ายการเตรียมงาน (C/S)')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_TYPE', N'02', N'ค่าดำเนินการทางพิธีการ (C/S)')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_TYPE', N'03', N'ค่าใช้จ่ายในระหว่างการตรวจปล่อย (S/P)')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'ADV_TYPE', N'04', N'ค่าใช้จ่ายอื่นๆ หลังการตรวจปล่อย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CHQ_STATUS', N'C', N'CHECKING')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CHQ_STATUS', N'P', N'PASS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CHQ_STATUS', N'R', N'RETURN')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'1', N'Marketing Dept.')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'2', N'Customer Services')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'3', N'Shipping Dept')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'4', N'Financial Dept')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'5', N'Accounting Dept')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_FROM', N'6', N'IT Administration Dept')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_STATUS', N'01', N'REQUEST')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_STATUS', N'02', N'APPROVED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_STATUS', N'03', N'CLEARED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_STATUS', N'99', N'CANCEL')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_TYPE', N'1', N'Advance')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_TYPE', N'2', N'Cost (Non-advance)')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CLR_TYPE', N'3', N'Services')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMMERCIAL_LEVEL', N'RT', N'RETAIL')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMMERCIAL_LEVEL', N'WO', N'WHOLESALER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'AG', N'AGENT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'CO', N'CONSIGNEE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'DI', N'DISTRIBUTOR')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'FW', N'FORWARDER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'MA', N'MANUFACTURERS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'OT', N'OTHERS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'TR', N'TRANSPORTER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'COMPANY_TYPE', N'VE', N'VENDER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'CONSIGNEE', N'ผู้ซื้อขาย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'CUSTOMERS', N'ลูกค้าทั่วไป')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'INTERNAL', N'หน่วยงานภายใน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'NOTIFY_PARTY', N'ผู้รับส่งสินค้า')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'PERSON', N'บุคคลทั่วไป')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_GROUP', N'PROSPECT', N'ผู้มุ่งหวัง')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_TYPE', N'0', N'LOCAL')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMER_TYPE', N'1', N'FOREIGN')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_19BIS', N'BG', N'BANK GUARANTEE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_19BIS', N'CA', N'CASH')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_19BIS', N'DD', N'DRAFT DEPOSIT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_EXPENSES', N'AF', N'AFTA')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_EXPENSES', N'NX', N'TAX EXCEPTS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_EXPENSES', N'OT', N'OTHERS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_EXPENSES', N'TX', N'TAX PAID')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_PRIVILEGE', N'CB', N'CUSTOMS BROKER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'CUSTOMS_PRIVILEGE', N'GC', N'GOLD CARD')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_ACC', N'G', N'GL')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_ACC', N'P', N'PV')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_ACC', N'R', N'RV')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_TYPE', N'ADV', N'ADVANCE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_TYPE', N'CLR', N'CLEARING')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_TYPE', N'INV', N'INVOICE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'DOCUMENT_TYPE', N'PAY', N'BILL PAYMENT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'00', N'PENDING CONFIRM')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'01', N'WAIT FOR OPERATION')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'02', N'WAIT FOR CLEAR')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'03', N'WORKING FINISHED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'04', N'EXPENSES CLEARED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'05', N'BILLING INCOMPLETE')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'06', N'BILLING COMPLETED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'07', N'JOB COMPLETED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'98', N'HOLD FOR CHECKING')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_STATUS', N'99', N'JOB CANCELLED')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_TYPE', N'01', N'IMPORT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_TYPE', N'02', N'EXPORT')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'JOB_TYPE', N'03', N'DOMESTIC')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'ACC', N'Accounting')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'ADM', N'Admin')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'ADV', N'Advance Request')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'CLR', N'Advance Clearing')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'CS', N'Job Control')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'MAS', N'Master Files')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'REP', N'Reports & Analysis')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE', N'SALES', N'Marketing')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'AccountCode', N'ผังบัญชี')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Adjustment', N'รายการปรับปรุง')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Approve', N'อนุมัติรายการ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Billing', N'ใบวางบิล')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Cheque', N'รับเช็คล่วงหน้า')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Costing', N'ต้นทุนค่าบริการค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'CreditNote', N'ใบเพิ่มหนี้/ลดหนี้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Expense', N'บิลค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'GenerateInv', N'สร้างใบแจ้งหนี้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'GLNote', N'สมุุดรายวัน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Invoice', N'ใบแจ้งหนี้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Payment', N'จ่ายเงินตามบิลค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'PettyCash', N'เงินสดย่อย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Receipt', N'ใบเสร็จรับเงิน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'RecvInv', N'รับชำระตามใบแจ้งหนี้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'TaxInvoice', N'ใบกำกับภาษี')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'Voucher', N'ข้อมูลการรับ/จ่ายเงิน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ACC', N'WHTax', N'ใบหัก ณ ที่จ่าย')
GO
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADM', N'FileManager', N'File Manager')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADM', N'Role', N'บทบาทผู้ใช้งาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADM', N'SQLAdmin', N'SQL Administrator')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADV', N'Approve', N'อนุมัติใบเบิกค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADV', N'CreditAdv', N'เบิกเงินสดย่อย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADV', N'EstimateCost', N'ประมาณการค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADV', N'Index', N'ใบเบิกค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_ADV', N'Payment', N'จ่ายเงินตามใบเบิกค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CLR', N'Approve', N'อนุมัติใบปิดค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CLR', N'Earnest', N'เคลียร์เงินมัดจำตู้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CLR', N'Index', N'ใบปิดค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CLR', N'Receive', N'รับเคลียร์เงินจากใบปิดค่าใช้จ่าย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CS', N'CreateJob', N'เปิดงานใหม่')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CS', N'Index', N'ค้นหางาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CS', N'ShowJob', N'รายละเอียดงาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_CS', N'Transport', N'ใบจองรถ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Bank', N'ธนาคาร')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'BookAccount', N'สมุดบัญชีธนาคาร')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Branch', N'สาขา')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'BudgetPolicy', N'มาตรฐานค่าบริการ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'CompanyContact', N'รายชื่อผู้ติดต่อ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Country', N'ประเทศ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Currency', N'สกุลเงิน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Customers', N'ผู้นำเข้าส่งออก')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'CustomsPort', N'ท่าที่ตรวจปล่อย')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'CustomsUnit', N'หน่วยสินค้า')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'DeclareType', N'ประเภทใบขนสินค้า')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Index', N'ค่าคงที่ระบบ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'InterPort', N'ท่าต่างประเทศ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Province', N'จังหวัด/อำเภอ/ตำบล')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'ServiceCode', N'ค่าบริการต่างๆ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'ServiceGroup', N'กลุ่มค่าบริการ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'ServUnit', N'หน่วยการบริการ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'UserAuth', N'สิทธิการใช้งาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Users', N'ผู้ใช้งาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Venders', N'ผู้ให้บริการ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_MAS', N'Vessel', N'ชื่อพาหนะ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_REP', N'Export', N'ส่งออกข้อมูล')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_REP', N'Import', N'นำเข้าข้อมูล')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_REP', N'Index', N'รายงานต่างๆ')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_REP', N'Tracking', N'ตรวจสอบสถานะงาน')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_SALES', N'QuoApprove', N'อนุมัติใบเสนอราคา')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'MODULE_SALES', N'Quotation', N'ใบเสนอราคา')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PAYMENT_TYPE', N'CA', N'Cash/Transfer')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PAYMENT_TYPE', N'CH', N'Cashier Cheque')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PAYMENT_TYPE', N'CR', N'Credit')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PAYMENT_TYPE', N'CU', N'Customer Cheque')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_ADDRESS1', N'เลขที่ 5/17 สุขุมวิท 54 แขวงพระโขนงไต้')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_ADDRESS2', N'เขตพระโขนง กทม 10260')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_EMAIL', N'all@tawantech.co.th')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_FAX', N'02-7159988')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_LOGO', N'logo-tawan.jpg')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_NAME', N'บริษัท ตะวันเทคโนโลยี จำกัด')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_TAXBRANCH', N'00000')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_TAXNUMBER', N'0105544112818')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'COMPANY_TEL', N'02-7159598')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'CURRENCY', N'THB')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'DEFAULT_BRANCH', N'00')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'PAYMENT_CREDIT_DAYS', N'30')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'PROFILE', N'VATRATE', N'0.07')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SERVICE_TYPE', N'EXP', N'Expenses')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SERVICE_TYPE', N'INC', N'Income')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SERVICE_TYPE', N'STD', N'Standard Services')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'01', N'AIR')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'02', N'SEA')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'03', N'TRUCK')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'04', N'TRAIN')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'05', N'PARCEL')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'06', N'PASSENGER')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'SHIP_BY', N'07', N'19BIS')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'01', N'Managing director')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'02', N'Manager')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'03', N'Sales')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'04', N'Customer Services')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'05', N'Shipping')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'06', N'Accounting')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'98', N'Others')
INSERT [dbo].[Mas_Config] ([ConfigCode], [ConfigKey], [ConfigValue]) VALUES (N'USER_LEVEL', N'99', N'Administrators')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'ACM', N'acm', N'ผู้จัดการฝ่ายบัญชี', N'Account Manager', N'ACC-MGR', NULL, NULL, NULL, NULL, 2, 0, 0, N'', N'account@tawantech.co.th', N'', 0, 0, 0, N'BOAT', N'', N'TH', N'', N'', N'', N'', N'5')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'ADMIN', N'1234', N'ADMINISTRATOR', N'ADMINISTRATOR', N'ADMINISTRATOR', NULL, NULL, NULL, NULL, 99, 0, 0, N'11111111111111111', N'', N'', 1, 0, 0, N'', N'', N'TH', N'', N'', N',01,02,03,04,05,06', N',01,02,03,04', N'6')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'BOAT', N'4780', N'พุทธิพงษ์ คงพ่วง', N'Phuthipong Kongpoung', N'IT', NULL, NULL, NULL, NULL, 99, 0, 0, N'', N'puttipong@tawantech.co.th', N'0823320506', 0, 0, 0, N'ADMIN', N'', N'EN', N'', N'', N'', N'', N'6')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'CASH1', N'cash1', N'แคชเชียร์', N'Cashier 1', N'finance', NULL, NULL, NULL, NULL, 6, 0, 0, N'', N'', N'', 0, 0, 0, N'ACM', N'', N'TH', N'', N'', N'', N'', N'4')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'CS', N'CS', N'นางสาวรักดี ใฝ่เรียน', N'Miss Rukdee Fairean', N'CS Import', NULL, NULL, NULL, NULL, 4, 0, 0, N'', N'cs@tawantech.co.th', N'02-9989898', 0, 0, 0, N'BOAT', N'', N'TH', N'', N'', N'', N'', N'2')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'pasit', N'1234', N'pasit', N'', N'', NULL, NULL, NULL, NULL, 99, 0, 0, N'', N'', N'', 0, 0, 0, N'', N'', N'TH', N'', N'', N'', N'', N'6')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'SHP', N'shp', N'ชิปปิ้ง', N'Shipping', N'Shipping Import', NULL, NULL, NULL, NULL, 5, 0, 0, N'', N'', N'', 0, 0, 0, N'BOAT', N'', N'TH', N'', N'', N'', N'', N'3')
INSERT [dbo].[Mas_User] ([UserID], [UPassword], [TName], [EName], [TPosition], [LoginDate], [LoginTime], [LogoutDate], [LogoutTime], [UPosition], [MaxRateDisc], [MaxAdvance], [JobAuthorize], [EMail], [MobilePhone], [IsAlertByAgent], [IsAlertByEMail], [IsAlertBySMS], [UserUpline], [GLAccountCode], [UsedLanguage], [DMailAccount], [DMailPassword], [JobPolicy], [AlertPolicy], [DeptID]) VALUES (N'test', N'test', N'พนักงานทดสอบ', N'test user', N'', NULL, NULL, NULL, NULL, 2, 0, 0, N'', N'', N'', 0, 0, 0, N'ADMIN', N'', N'', N'', N'', N'', N'', N'1')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_MAS', N'Branch', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_MAS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_MAS', N'Users', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_MAS', N'UserAuth', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_ADM', N'Role', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_REP', N'Import', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'admin', N'MODULE_REP', N'Export', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'AccountCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Adjustment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'CreditNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'GLNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_ADV', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CLR', N'Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CLR', N'Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_MAS', N'BookAccount', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ACM', N'MODULE_MAS', N'BudgetPolicy', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'AccountCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Adjustment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Approve', N'MIREDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'CreditNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'GLNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADM', N'FileManager', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADM', N'SQLAdmin', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADV', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_ADV', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CLR', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CLR', N'Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CLR', N'Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Bank', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'BookAccount', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'BudgetPolicy', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'CompanyContact', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Country', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Currency', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Customers', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'CustomsPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'CustomsUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'DeclareType', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'InterPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Province', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'ServiceCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'ServiceGroup', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'ServUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Venders', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_MAS', N'Vessel', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_REP', N'Dashboard', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_REP', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_REP', N'Reports', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_SALES', N'QuoApprove', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'ADMIN', N'MODULE_SALES', N'Quotation', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'AccountCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Adjustment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Approve', N'MIREDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'CreditNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Expense', N'MEIRDP')
GO
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'GLNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADM', N'FileManager', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADM', N'Role', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADM', N'SQLAdmin', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADV', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_ADV', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CLR', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CLR', N'Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CLR', N'Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Bank', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'BookAccount', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Branch', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'BudgetPolicy', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'CompanyContact', N'MIREDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Country', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Currency', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Customers', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'CustomsPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'CustomsUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'DeclareType', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'InterPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Province', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'ServiceCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'ServiceGroup', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'ServUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'UserAuth', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Users', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Venders', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_MAS', N'Vessel', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_REP', N'Dashboard', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_REP', N'Export', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_REP', N'Import', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_REP', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_REP', N'Reports', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_SALES', N'QuoApprove', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'BOAT', N'MODULE_SALES', N'Quotation', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_ADV', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CLR', N'Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CLR', N'Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CASH1', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'CS', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'AccountCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Adjustment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'CreditNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'GLNote', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Receipt', N'MEIRDP')
GO
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADM', N'FileManager', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADM', N'Role', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADM', N'SQLAdmin', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADV', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_ADV', N'Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CLR', N'Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CLR', N'Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CLR', N'Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Bank', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'BookAccount', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Branch', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'BudgetPolicy', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'CompanyContact', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Country', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Currency', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Customers', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'CustomsPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'CustomsUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'DeclareType', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'InterPort', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Province', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'ServiceCode', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'ServiceGroup', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'ServUnit', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'UserAuth', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Users', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Venders', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_MAS', N'Vessel', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_REP', N'Dashboard', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_REP', N'Export', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_REP', N'Import', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_REP', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_REP', N'Reports', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_SALES', N'QuoApprove', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'pasit', N'MODULE_SALES', N'Quotation', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_ACC', N'Invoice', N'MIR')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_ACC', N'WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_ADV', N'CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_ADV', N'EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_ADV', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_CLR', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_CS', N'CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_CS', N'Index', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_CS', N'ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserAuth] ([UserID], [AppID], [MenuID], [Author]) VALUES (N'test', N'MODULE_CS', N'Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'ACC', N'Accounting Staff', 5)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'ACC-MGR', N'Accounting Manager', 5)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'CS', N'Customer Services Staff', 2)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'CS-MGR', N'Customer Services Manager', 2)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'FIN', N'Finance Staff', 4)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'FIN-MGR', N'Finance Manager', 4)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'IT', N'IT Department', 6)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'IT_MGR', N'IT MANAGER', 0)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'MGT', N'Marketing Staff', 1)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'MGT-MGR', N'Marketing Manager', 1)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'SP', N'Shipping Staff', 3)
INSERT [dbo].[Mas_UserRole] ([RoleID], [RoleDesc], [RoleGroup]) VALUES (N'SP-MGR', N'Shipping Manager', 3)
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC', N'ACM')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC', N'BOAT')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC-MGR', N'ACM')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC-MGR', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'ACC-MGR', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS', N'BOAT')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS', N'CS')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS', N'test')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS-MGR', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS-MGR', N'BOAT')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'CS-MGR', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN', N'ACM')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN', N'BOAT')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN', N'CASH1')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN-MGR', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'FIN-MGR', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'IT', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'IT', N'BOAT')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'IT', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'MGT', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'MGT', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'MGT-MGR', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'MGT-MGR', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'SP', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'SP', N'pasit')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'SP-MGR', N'ADMIN')
INSERT [dbo].[Mas_UserRoleDetail] ([RoleID], [UserID]) VALUES (N'SP-MGR', N'pasit')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Adjustment', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Cheque', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/CreditNote', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/GLNote', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Payment', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/PettyCash', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Receipt', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/RecvInv', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/TaxInvoice', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ACC/WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ADV/CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ADV/EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ADV/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_ADV/Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CLR/Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CLR/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CLR/Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CS/CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CS/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CS/ShowJob', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC', N'MODULE_CS/Transport', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/AccountCode', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/Adjustment', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/CreditNote', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/GLNote', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_ACC/Voucher', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_CS/Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_MAS/BookAccount', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'ACC-MGR', N'MODULE_MAS/BudgetPolicy', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_ACC/WHTax', N'MIREP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_ADV/CreditAdv', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_ADV/EstimateCost', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_ADV/Index', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_CLR/Index', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_CS/CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_CS/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_CS/ShowJob', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS', N'MODULE_CS/Transport', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_ACC/Costing', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_ADV/Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_ADV/CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_ADV/EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_ADV/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_CLR/Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_CLR/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_CS/ShowJob', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'CS-MGR', N'MODULE_CS/Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Billing', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Cheque', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Costing', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Expense', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/GenerateInv', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Invoice', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Payment', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/PettyCash', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Receipt', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/RecvInv', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/TaxInvoice', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/Voucher', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ACC/WHTax', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ADV/CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ADV/EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ADV/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_ADV/Payment', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CLR/Earnest', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CLR/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CLR/Receive', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CS/CreateJob', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CS/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CS/ShowJob', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN', N'MODULE_CS/Transport', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Billing', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Cheque', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Costing', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Expense', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/GenerateInv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Invoice', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/PettyCash', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Receipt', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/RecvInv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/TaxInvoice', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_ACC/Voucher', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_CLR/Earnest', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_CLR/Receive', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'FIN-MGR', N'MODULE_CS/Transport', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ACC/AccountCode', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ACC/Expense', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ACC/Payment', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ADM/FileManager', N'M')
GO
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ADM/Role', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_ADM/SQLAdmin', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Bank', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/BookAccount', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Branch', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/BudgetPolicy', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Country', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Currency', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Customers', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/CustomsPort', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/CustomsUnit', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/DeclareType', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Index', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/InterPort', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Province', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/ServiceCode', N'MR')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/ServiceGroup', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/ServUnit', N'MIRE')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/UserAuth', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Users', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Venders', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_MAS/Vessel', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_REP/Dashboard', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_REP/Export', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_REP/Import', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_REP/Index', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_REP/Reports', N'M')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_SALES/QuoApprove', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'IT', N'MODULE_SALES/Quotation', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT', N'MODULE_ADV/CreditAdv', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT', N'MODULE_ADV/EstimateCost', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT', N'MODULE_SALES/Quotation', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_ADV/CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_ADV/EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_MAS/BudgetPolicy', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_MAS/CompanyContact', N'MIREDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_SALES/QuoApprove', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'MGT-MGR', N'MODULE_SALES/Quotation', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_ADV/CreditAdv', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_ADV/EstimateCost', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_ADV/Index', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_CLR/Index', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_CS/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_CS/ShowJob', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP', N'MODULE_CS/Transport', N'MEIRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_ACC/Costing', N'MRP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_ADV/Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_ADV/CreditAdv', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_ADV/EstimateCost', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_ADV/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_CLR/Approve', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_CLR/Index', N'MEIRDP')
INSERT [dbo].[Mas_UserRolePolicy] ([RoleID], [ModuleID], [Author]) VALUES (N'SP-MGR', N'MODULE_CS/Transport', N'MEIRDP')
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [AdvQty]
GO
ALTER TABLE [dbo].[Job_AdvDetail] ADD  DEFAULT ((1)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Job_AdvHeader] ADD  DEFAULT ((1)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Job_CNDNDetail] ADD  DEFAULT ((0)) FOR [Is50Tavi]
GO
ALTER TABLE [dbo].[Job_CNDNDetail] ADD  DEFAULT ((0)) FOR [WHTRate]
GO
ALTER TABLE [dbo].[Job_CNDNDetail] ADD  DEFAULT ((0)) FOR [WHTAmt]
GO
ALTER TABLE [dbo].[Job_CNDNDetail] ADD  DEFAULT ((0)) FOR [BillItemNo]
GO
ALTER TABLE [dbo].[Job_LoadInfoDetail] ADD  DEFAULT ('') FOR [DeliveryNo]
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
ALTER TABLE [dbo].[Mas_BookAccount] ADD  CONSTRAINT [DF_Mas_BookAccount_IsLocal]  DEFAULT ((0)) FOR [IsLocal]
GO
ALTER TABLE [dbo].[Mas_BookAccount] ADD  DEFAULT ((0)) FOR [LimitBalance]
GO
ALTER TABLE [dbo].[Mas_BookAccount] ADD  DEFAULT ('') FOR [GLAccountCode]
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
