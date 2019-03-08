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
	[DescriptionH] [nvarchar](MAX) NULL,
	[DescriptionF] [nvarchar](MAX) NULL,
	[TRemark] [varchar](250) NULL,
	[DocStatus] [int] NULL,
	[ApproveBy] [varchar](10) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveTime] [datetime] NULL,
	[CancelBy] [varchar](10) NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [nvarchar](255) NULL,
	CONSTRAINT PK_QuotaionH PRIMARY KEY CLUSTERED
	(
		BranchCode,QNo
	)
)
GO
CREATE TABLE [dbo].[Job_QuotationDetail](
	[BranchCode] [varchar](5) NOT NULL,
	[QNo] [varchar](15) NOT NULL,
	[SeqNo] [smallint] NOT NULL,
	[JobType] [smallint] NOT NULL,
	[ShipBy] [smallint] NOT NULL,
	[Description] [nvarchar](MAX) NULL,
	CONSTRAINT PK_QuoDetail PRIMARY KEY CLUSTERED
	(
		BranchCode,QNo,SeqNo
	)
)
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
	CONSTRAINT PK_QuoItem PRIMARY KEY CLUSTERED
	(
		BranchCode,QNo,SeqNo,ItemNo
	)
)
GO