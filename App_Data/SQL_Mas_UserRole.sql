create table dbo.Mas_UserRole
(
	RoleID varchar(50) NOT NULL PRIMARY KEY,
	RoleDesc nvarchar(255) NOT NULL
)
go
insert into dbo.Mas_UserRole values
('MGT','Marketing Staff'),
('CS','Customer Services Staff'),
('SP','Shipping Staff'),
('FIN','Finance Staff'),
('ACC','Accounting Staff'),
('MGT-MGR','Marketing Manager'),
('CS-MGR','Customer Services Manager'),
('SP-MGR','Shipping Manager'),
('FIN-MGR','Finance Manager'),
('ACC-MGR','Accounting Manager')
go
CREATE TABLE dbo.Mas_UserRoleDetail
(
	RoleID varchar(50) NOT NULL,
	UserID varchar(10) NOT NULL,
	CONSTRAINT PK_RoleDetail PRIMARY KEY CLUSTERED 
	(
	RoleID,UserID
	)
)
GO
CREATE TABLE dbo.Mas_UserRolePolicy
(
	RoleID varchar(50) NOT NULL,
	ModuleID varchar(50) NOT NULL,
	Author varchar(10) NULL,
	CONSTRAINT PK_RolePolicy PRIMARY KEY CLUSTERED
	(
		RoleID,ModuleID
	)
)
go
/*Patch data*/
Update dbo.Mas_Config SET ConfigKey='Quotation' WHERE ConfigKey='Index' And ConfigCode='MODULE_SALES'
Update dbo.Mas_Config SET ConfigValue='รายการปรับปรุง' WHERE ConfigKey='Adjustment' And ConfigCode='MODULE_ACC'
Insert into dbo.Mas_Config values('MODULE_SALES','QuoApprove','อนุมัติใบเสนอราคา')
,('MODULE_ADV','EstimateCost','ประมาณการค่าใช้จ่าย')
,('MODULE_ADV','CreditAdv','เบิกเงินสดย่อย')
,('MODULE_ACC','RecvInv','รับชำระตามใบแจ้งหนี้')
,('MODULE_ACC','GenerateInv','สร้างใบแจ้งหนี้')
,('MODULE_ACC','Costing','ต้นทุนค่าบริการค่าใช้จ่าย')
,('MODULE_ACC','Expense','บิลค่าใช้จ่าย')
,('MODULE_CLR','Earnest','เคลียร์เงินมัดจำตู้')
,('MODULE_ACC','GLNote','สมุุดรายวัน')
,('MODULE_ACC','PettyCash','เงินสดย่อย')
,('MODULE_ACC','Cheque','รับเช็คล่วงหน้า')
,('MODULE_ACC','CreditNote','ใบเพิ่มหนี้/ลดหนี้')
,('MODULE_CS','Transport','ใบจองรถ')
,('MODULE_ADM','Role','บทบาทผู้ใช้งาน')
GO
/*structure*/
INSERT INTO dbo.Mas_UserRolePolicy values
('MGT','MODULE_SALES/Quotation','MEIRP'),
('MGT','MODULE_ADV/EstimateCost','MRP'),
('MGT','MODULE_ADV/CreditAdv','MEIRP'),
('MGT-MGR','MODULE_SALES/QuoApprove','MEIRDP'),
('MGT-MGR','MODULE_SALES/Quotation','MEIRDP'),
('MGT-MGR','MODULE_ADV/EstimateCost','MEIRDP'),
('MGT-MGR','MODULE_ADV/CreditAdv','MEIRDP'),
('CS','MODULE_CS/CreateJob','MEIRDP'),
('CS','MODULE_CS/Index','MEIRDP'),
('CS','MODULE_CS/ShowJob','MEIRP'),
('CS','MODULE_CS/Transport','MEIRP'),
('CS','MODULE_ADV/Index','MEIRP'),
('CS','MODULE_CLR/Index','MEIRP'),
('CS','MODULE_ACC/WHTax','MEIRP'),
('CS','MODULE_ADV/EstimateCost','MRP'),
('CS','MODULE_ADV/CreditAdv','MRP'),
('CS-MGR','MODULE_CS/Transport','MEIRDP'),
('CS-MGR','MODULE_CS/CreateJob','MEIRDP'),
('CS-MGR','MODULE_CS/Index','MEIRDP'),
('CS-MGR','MODULE_CS/ShowJob','MEIRDP'),
('CS-MGR','MODULE_ADV/Index','MEIRDP'),
('CS-MGR','MODULE_CLR/Index','MEIRDP'),
('CS-MGR','MODULE_ADV/Approve','MEIRDP'),
('CS-MGR','MODULE_CLR/Approve','MEIRDP'),
('CS-MGR','MODULE_ADV/EstimateCost','MEIRDP'),
('CS-MGR','MODULE_ADV/CreditAdv','MEIRDP'),
('CS-MGR','MODULE_ACC/Costing','MRP'),
('SP','MODULE_ADV/Index','MEIRP'),
('SP','MODULE_CLR/Index','MEIRP'),
('SP','MODULE_CS/Index','MEIRDP'),
('SP','MODULE_CS/ShowJob','MRP'),
('SP','MODULE_CS/Transport','MEIRP'),
('SP','MODULE_ADV/EstimateCost','MRP'),
('SP','MODULE_ADV/CreditAdv','MEIRP'),
('SP-MGR','MODULE_CS/Index','MEIRDP'),
('SP-MGR','MODULE_CS/ShowJob','MRP'),
('SP-MGR','MODULE_CS/Transport','MEIRDP'),
('SP-MGR','MODULE_ADV/Index','MEIRDP'),
('SP-MGR','MODULE_CLR/Index','MEIRDP'),
('SP-MGR','MODULE_ADV/Approve','MEIRDP'),
('SP-MGR','MODULE_CLR/Approve','MEIRDP'),
('SP-MGR','MODULE_ADV/EstimateCost','MEIRDP'),
('SP-MGR','MODULE_ADV/CreditAdv','MEIRDP'),
('SP-MGR','MODULE_ACC/Costing','MRP'),
('FIN','MODULE_ADV/Payment','MEIRDP'),
('FIN','MODULE_CLR/Receive','MEIRDP'),
('FIN','MODULE_ADV/Index','MEIRDP'),
('FIN','MODULE_CLR/Index','MEIRDP'),
('FIN','MODULE_CS/CreateJob','MEIRDP'),
('FIN','MODULE_CS/Index','MEIRDP'),
('FIN','MODULE_CS/ShowJob','MEIRP'),
('FIN','MODULE_CS/Transport','MEIRP'),
('FIN','MODULE_ACC/Voucher','MEIRP'),
('FIN','MODULE_ACC/Billing','MEIRP'),
('FIN','MODULE_ACC/Invoice','MEIRP'),
('FIN','MODULE_ACC/Receipt','MEIRP'),
('FIN','MODULE_ACC/TaxInvoice','MEIRP'),
('FIN','MODULE_ACC/WHTax','MEIRDP'),
('FIN','MODULE_ACC/RecvInv','MEIRP'),
('FIN','MODULE_ACC/Expense','MEIRP'),
('FIN','MODULE_ACC/Earnest','MEIRP'),
('FIN','MODULE_ACC/Cheque','MEIRP'),
('FIN','MODULE_ACC/PettyCash','MEIRP'),
('FIN','MODULE_ADV/EstimateCost','MEIRDP'),
('FIN','MODULE_ADV/CreditAdv','MEIRDP'),
('FIN','MODULE_ACC/Costing','MEIRP'),
('FIN','MODULE_ACC/GenerateInv','MEIRP'),
('FIN-MGR','MODULE_ADV/Payment','MEIRDP'),
('FIN-MGR','MODULE_CLR/Receive','MEIRDP'),
('FIN-MGR','MODULE_ADV/Index','MEIRDP'),
('FIN-MGR','MODULE_CLR/Index','MEIRDP'),
('FIN-MGR','MODULE_CS/CreateJob','MEIRDP'),
('FIN-MGR','MODULE_CS/Index','MEIRDP'),
('FIN-MGR','MODULE_CS/ShowJob','MEIRP'),
('FIN-MGR','MODULE_CS/Transport','MEIRDP'),
('FIN-MGR','MODULE_ACC/Voucher','MEIRDP'),
('FIN-MGR','MODULE_ACC/Billing','MEIRDP'),
('FIN-MGR','MODULE_ACC/Invoice','MEIRDP'),
('FIN-MGR','MODULE_ACC/Receipt','MEIRDP'),
('FIN-MGR','MODULE_ACC/TaxInvoice','MEIRDP'),
('FIN-MGR','MODULE_ACC/WHTax','MEIRDP'),
('FIN-MGR','MODULE_ACC/RecvInv','MEIRDP'),
('FIN-MGR','MODULE_ACC/Expense','MEIRDP'),
('FIN-MGR','MODULE_ACC/Earnest','MEIRDP'),
('FIN-MGR','MODULE_ACC/Cheque','MEIRDP'),
('FIN-MGR','MODULE_ACC/PettyCash','MEIRDP'),
('FIN-MGR','MODULE_ADV/EstimateCost','MEIRDP'),
('FIN-MGR','MODULE_ADV/CreditAdv','MEIRDP'),
('FIN-MGR','MODULE_ACC/Costing','MEIRDP'),
('FIN-MGR','MODULE_ACC/GenerateInv','MEIRDP'),
('ACC','MODULE_ADV/Payment','MEIRDP'),
('ACC','MODULE_CLR/Receive','MEIRDP'),
('ACC','MODULE_ADV/Index','MEIRDP'),
('ACC','MODULE_CLR/Index','MEIRDP'),
('ACC','MODULE_CS/CreateJob','MEIRDP'),
('ACC','MODULE_CS/Index','MEIRDP'),
('ACC','MODULE_CS/ShowJob','MEIRP'),
('ACC','MODULE_CS/Transport','MEIRP'),
('ACC','MODULE_ACC/Voucher','MEIRDP'),
('ACC','MODULE_ACC/Billing','MEIRDP'),
('ACC','MODULE_ACC/Invoice','MEIRDP'),
('ACC','MODULE_ACC/Receipt','MEIRP'),
('ACC','MODULE_ACC/TaxInvoice','MEIRP'),
('ACC','MODULE_ACC/WHTax','MEIRDP'),
('ACC','MODULE_ACC/RecvInv','MEIRP'),
('ACC','MODULE_ACC/Expense','MEIRDP'),
('ACC','MODULE_ACC/Earnest','MEIRDP'),
('ACC','MODULE_ACC/Adjustment','MEIRP'),
('ACC','MODULE_ACC/Cheque','MEIRP'),
('ACC','MODULE_ACC/PettyCash','MEIRP'),
('ACC','MODULE_ACC/GLNote','MEIRP'),
('ACC','MODULE_ACC/CreditNote','MEIRP'),
('ACC','MODULE_ADV/EstimateCost','MEIRDP'),
('ACC','MODULE_ADV/CreditAdv','MEIRDP'),
('ACC','MODULE_ACC/Costing','MEIRDP'),
('ACC','MODULE_ACC/GenerateInv','MEIRDP'),
('ACC-MGR','MODULE_ADV/Payment','MEIRDP'),
('ACC-MGR','MODULE_CLR/Receive','MEIRDP'),
('ACC-MGR','MODULE_ADV/Index','MEIRDP'),
('ACC-MGR','MODULE_CLR/Index','MEIRDP'),
('ACC-MGR','MODULE_CS/CreateJob','MEIRDP'),
('ACC-MGR','MODULE_CS/Index','MEIRDP'),
('ACC-MGR','MODULE_CS/ShowJob','MEIRP'),
('ACC-MGR','MODULE_CS/Transport','MEIRDP'),
('ACC-MGR','MODULE_ACC/Voucher','MEIRDP'),
('ACC-MGR','MODULE_ACC/Billing','MEIRDP'),
('ACC-MGR','MODULE_ACC/Invoice','MEIRDP'),
('ACC-MGR','MODULE_ACC/Receipt','MEIRDP'),
('ACC-MGR','MODULE_ACC/TaxInvoice','MEIRDP'),
('ACC-MGR','MODULE_ACC/WHTax','MEIRDP'),
('ACC-MGR','MODULE_ACC/RecvInv','MEIRDP'),
('ACC-MGR','MODULE_ACC/Expense','MEIRDP'),
('ACC-MGR','MODULE_ACC/Earnest','MEIRDP'),
('ACC-MGR','MODULE_ACC/Adjustment','MEIRDP'),
('ACC-MGR','MODULE_ACC/Cheque','MEIRDP'),
('ACC-MGR','MODULE_ACC/PettyCash','MEIRDP'),
('ACC-MGR','MODULE_ACC/GLNote','MEIRDP'),
('ACC-MGR','MODULE_ACC/CreditNote','MEIRDP'),
('ACC-MGR','MODULE_ADV/EstimateCost','MEIRDP'),
('ACC-MGR','MODULE_ADV/CreditAdv','MEIRDP'),
('ACC-MGR','MODULE_ACC/Costing','MEIRDP'),
('ACC-MGR','MODULE_ACC/GenerateInv','MEIRDP')
go
