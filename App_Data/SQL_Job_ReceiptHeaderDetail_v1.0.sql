USE [JOB_WEB]
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
	CONSTRAINT PK_ReceiptHeader PRIMARY KEY CLUSTERED 
	(
		BranchCode,ReceiptNo
	)
)

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
	[ControlItemNo] int NULL,
	[InvoiceNo] [varchar](15) NULL,
	[InvoiceItemNo] int NULL,
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
	CONSTRAINT PK_ReceiptD PRIMARY KEY CLUSTERED 
	(
		BranchCode,ReceiptNo,ItemNo
	)
)
GO