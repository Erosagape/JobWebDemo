USE JOB_WEB
go
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
	[TotalDiscount] [float] NULL,
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
	CONSTRAINT PK_InvH PRIMARY KEY CLUSTERED (
	BranchCode,DocNo
	)
)
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
	[DiscountType] int NOT NULL,
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
..
	CONSTRAINT PK_InvD PRIMARY KEY CLUSTERED 
	(
		BranchCode,DocNo,ItemNo
	)
)
GO


