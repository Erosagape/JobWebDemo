USE [JOB_WEB]
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
	CONSTRAINT PK_BillAcceptH PRIMARY KEY CLUSTERED 
	(
		BranchCode,BillAcceptNo
	)
)
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
	CONSTRAINT PK_BillAcceptD PRIMARY KEY CLUSTERED 
	(
		BranchCode,BillAcceptNo,ItemNo
	)
)
GO

