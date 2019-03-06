CREATE TABLE dbo.Job_GLHeader
(
	BranchCode varchar(5) NOT NULL,
	GLRefNo varchar(15) NOT NULL,
	FiscalYear varchar(10) NOT NULL,
	LastupDate datetime NULL,
	UpdateBy varchar(15) NULL,
	GLType varchar(10) NULL,
	Remark nvarchar(255) NULL,
	TotalDebit float,
	TotalCredit float,
	ApproveDate datetime NULL,
	ApproveBy varchar(15) NULL,
	PostDate datetime NULL,
	PostBy varchar(15) NULL,
	CancelDate datetime NULL,
	CancelBy varchar(15) NULL,
	CancelReason nvarchar(255) NULL,
	CONSTRAINT PK_GLHeader PRIMARY KEY CLUSTERED
	(
		BranchCode,GLRefNo
	)
)
GO
CREATE TABLE dbo.Job_GLDetail
(
	BranchCode varchar(5) NOT NULL,
	GLRefNo varchar(15) NOT NULL,
	ItemNo int not null,
	GLAccountCode varchar(50),
	GLDescription nvarchar(255),
	SourceDocument nvarchar(MAX),
	DebitAmt float,
	CreditAmt float,
	EntryDate datetime NULL,
	EntryBy varchar(15) NULL,
	CONSTRAINT PK_GLDetail PRIMARY KEY CLUSTERED
	(
		BranchCode,GLRefNo,ItemNo
	)	
)
GO