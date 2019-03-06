CREATE TABLE [dbo].[Job_BudgetPolicy](
    [ID] int NOT NULL PRIMARY KEY,
	[BranchCode] [varchar](5) NULL,
	[JobType] tinyint NULL,
	[ShipBy] tinyint NULL,
	[SICode] varchar(10) NULL,
	[SDescription] [varchar](150) NULL,
	[TRemark] [varchar](50) NULL,
	[MaxAdvance] [float] NULL,
	[MaxCost] [float] NULL,
	[MinCharge] [float] NULL,
	[MinProfit] [float] NULL,
	[Active] [varchar](5) NULL,
	[LastUpdate] datetime NULL,
	[UpdateBy] varchar(10) NULL,
	INDEX IDX_BudgetPolicy 
	(
		Active,BranchCode,JobType,ShipBy
	)
)



