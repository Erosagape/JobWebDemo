USE JOB_WEB
go
create table dbo.Job_SrvGroup
(
	GroupCode varchar(10) NOT NULL PRIMARY KEY,
	GroupName nvarchar(255) NOT NULL,
	GLAccountCode varchar(15) NULL,
	IsApplyPolicy int,
	IsTaxCharge tinyint NULL,
	Is50Tavi tinyint NULL,
	Rate50Tavi float NULL,
	IsCredit tinyint NULL,
	IsExpense tinyint NULL,
	IsHaveSlip tinyint NULL,
	IsLtdAdv50Tavi tinyint NULL
)
go
alter table dbo.Job_SrvSingle add GroupCode varchar(10) 
go
insert into dbo.Job_SrvGroup values('SRV','Services (Vat 7,WHT 3)','4100-02',1,1,1,3,0,0,0,0)
insert into dbo.Job_SrvGroup values('ADV','Credit Advances','1130-10',1,0,0,0,1,0,1,0)
insert into dbo.Job_SrvGroup values('CST','Costs','1130-17',1,0,0,0,0,1,0,0)
insert into dbo.Job_SrvGroup values('TRN','Transportations','4200-09',1,0,1,1,1,0,1,1)
insert into dbo.Job_SrvGroup values('FR1','Freights (WHT)','4100-15',1,1,1,0,1,0,1,1)
insert into dbo.Job_SrvGroup values('FR0','Freights (NO-WHT)','4100-15',1,1,0,0,1,0,1,0)
insert into dbo.Job_SrvGroup values('ERN','Earnests','1130-12',1,0,0,0,0,1,1,0)
go