
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
	[DocStatus] int NULL,
	[CancelDate] [datetime] NULL,
	[CancelReason] [varchar](255) NULL,
	[Remark] [varchar](255) NULL,
	CONSTRAINT PK_CNDN PRIMARY KEY CLUSTERED
	(
		BranchCode,DocNo
	)
) 
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
	CONSTRAINT PK_CNDNDetail PRIMARY KEY CLUSTERED
	(
		BranchCode,DocNo,ItemNo
	)
)
