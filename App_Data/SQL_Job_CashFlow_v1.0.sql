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
)
)
GO

