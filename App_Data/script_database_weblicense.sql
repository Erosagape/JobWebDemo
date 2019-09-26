USE [tawantec_weblicense]
GO
/****** Object:  Table [dbo].[TWTApp]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTApp](
	[AppID] [varchar](50) NOT NULL,
	[AppNameTH] [nvarchar](255) NULL,
	[AppNameEN] [nvarchar](255) NULL,
	[AppMainURL] [nvarchar](255) NULL,
 CONSTRAINT [PK_TWTApp] PRIMARY KEY CLUSTERED 
(
	[AppID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTCustomer]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTCustomer](
	[CustID] [varchar](50) NOT NULL,
	[CustName] [nvarchar](max) NULL,
	[CustTaxID] [varchar](50) NULL,
	[CustAddress] [ntext] NULL,
	[CustContact] [nvarchar](255) NULL,
	[CustTelFaxMobile] [nvarchar](255) NULL,
	[BeginDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[Active] [bit] NULL,
	[CustRemark] [nvarchar](max) NULL,
	[CustMessage] [nvarchar](max) NULL,
 CONSTRAINT [PK_TWTCustomer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTCustomerApp]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTCustomerApp](
	[AppID] [varchar](50) NOT NULL,
	[CustID] [varchar](50) NOT NULL,
	[WebURL] [nvarchar](255) NULL,
	[WebDBType] [int] NULL,
	[WebTranDB] [varchar](50) NULL,
	[WebMasDB] [varchar](50) NULL,
	[WebTranConnect] [nvarchar](max) NULL,
	[WebMasConnect] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[SubscriptionID] [int] NULL,
	[Seq] [int] NOT NULL,
	[DefaultLang] [varchar](5) NULL,
 CONSTRAINT [PK_TWTCustomerApp] PRIMARY KEY CLUSTERED 
(
	[AppID] ASC,
	[CustID] ASC,
	[Seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTLog]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTLog](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[CustID] [varchar](50) NULL,
	[AppID] [varchar](50) NULL,
	[ModuleName] [varchar](255) NULL,
	[LogAction] [varchar](255) NULL,
	[Message] [nvarchar](max) NULL,
 CONSTRAINT [PK_TWTLog] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTSubscription]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTSubscription](
	[SubScriptionID] [int] IDENTITY(0,1) NOT NULL,
	[SubscriptionName] [nvarchar](255) NULL,
	[SubscriptionDesc] [nvarchar](max) NULL,
	[AppID] [varchar](50) NULL,
	[Edition] [int] NULL,
	[BeginDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[LoginCount] [int] NULL,
 CONSTRAINT [PK_TWTSubscription] PRIMARY KEY CLUSTERED 
(
	[SubScriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTUser]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTUser](
	[TWTUserID] [varchar](50) NOT NULL,
	[TWTUserPassword] [nvarchar](50) NULL,
	[TWTUserName] [nvarchar](255) NULL,
 CONSTRAINT [PK_TWTUser] PRIMARY KEY CLUSTERED 
(
	[TWTUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TWTWebLogin]    Script Date: 25/09/2019 14:15:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TWTWebLogin](
	[CustID] [varchar](50) NOT NULL,
	[AppID] [varchar](50) NOT NULL,
	[UserLogIN] [varchar](50) NOT NULL,
	[FromIP] [varchar](50) NULL,
	[SessionID] [varchar](50) NULL,
	[LoginDateTime] [datetime] NULL,
	[ExpireDateTime] [datetime] NULL,
 CONSTRAINT [PK_TWTWebLogin] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC,
	[AppID] ASC,
	[UserLogIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TWTApp] ([AppID], [AppNameTH], [AppNameEN], [AppMainURL]) VALUES (N'JOBSHIPPING', N'ระบบบริหารงานชิปปิ้ง', N'Shipping Management System', N'192.168.1.222')
INSERT [dbo].[TWTCustomer] ([CustID], [CustName], [CustTaxID], [CustAddress], [CustContact], [CustTelFaxMobile], [BeginDate], [ExpireDate], [Active], [CustRemark], [CustMessage]) VALUES (N'APL', N'เอพีแอล ลอจิสติกส์', N'-', N'-', N'-', N'-', CAST(N'1900-01-01 00:00:00.000' AS DateTime), CAST(N'9999-12-31 00:00:00.000' AS DateTime), 1, N'ระบบทดสอบ', N'สวัสดีครับ')
INSERT [dbo].[TWTCustomerApp] ([AppID], [CustID], [WebURL], [WebDBType], [WebTranDB], [WebMasDB], [WebTranConnect], [WebMasConnect], [Active], [SubscriptionID], [Seq], [DefaultLang]) VALUES (N'JOBSHIPPING', N'APL', N'192.168.1.222', 0, N'tawantec_job_apl', N'tawantec_jobmaster', N'Data Source=.\MSSQLSERVER2012;Initial Catalog=tawantec_job_apl;User id=sa;Password=1234;Persist Security Info=False', N'Data Source=.\MSSQLSERVER2012;Initial Catalog=tawantec_jobmaster;User id=sa;Password=1234;Persist Security Info=False', 1, 1, 1, N'TH')
SET IDENTITY_INSERT [dbo].[TWTLog] ON 

INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (46, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGIN', N'BOAT', N'9/25/2019 4:44:54 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (47, N'APL(192.168.1.35)', N'mrkoda4kygci5x1al3tnvkfq', N'LOGIN', N'ADMIN', N'9/25/2019 4:45:22 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (48, N'APL(192.168.1.43)', N'ypkujlihgku0wrkovq1rowd2', N'LOGIN', N'test', N'9/25/2019 4:47:08 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (49, N'APL(192.168.1.43)', N'JOBSHIPPING', N'ExecuteSQL', N'[ERROR]The ConnectionString property has not been initialized.', N'
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'''')<>'''' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'''')='''' AND ISNULL(ih.CancelProve,'''')='''' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo

              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'''')<>'''' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND JobStatus<>99 AND ISNULL(CancelProve,'''')=''''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND ISNULL(CancelProve,'''')<>''''
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus

')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (50, N'APL(192.168.1.43)', N'ih5fsbxttgcj0zlerpfiijeb', N'LOGIN', N'ACM', N'9/25/2019 4:49:48 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (51, N'APL(192.168.1.43)', N'ypkujlihgku0wrkovq1rowd2', N'LOGOUT', N'test', N'9/25/2019 4:51:26 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (52, N'APL(192.168.1.43)', N'JOBSHIPPING', N'ExecuteSQL', N'[ERROR]The ConnectionString property has not been initialized.', N'
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'''')<>'''' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'''')='''' AND ISNULL(ih.CancelProve,'''')='''' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo

              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'''')<>'''' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND JobStatus<>99 AND ISNULL(CancelProve,'''')=''''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND ISNULL(CancelProve,'''')<>''''
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus

')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (53, N'APL(192.168.1.43)', N'ih5fsbxttgcj0zlerpfiijeb', N'LOGOUT', N'ACM', N'9/25/2019 4:51:54 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (54, N'APL(192.168.1.43)', N'JOBSHIPPING', N'ExecuteSQL', N'[ERROR]The ConnectionString property has not been initialized.', N'
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'''')<>'''' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'''')='''' AND ISNULL(ih.CancelProve,'''')='''' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo

              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'''')<>'''' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND JobStatus<>99 AND ISNULL(CancelProve,'''')=''''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND ISNULL(CancelProve,'''')<>''''
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus

')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (55, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGOUT', N'BOAT', N'9/25/2019 4:52:10 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (56, N'APL(192.168.1.43)', N'JOBSHIPPING', N'ExecuteSQL', N'[ERROR]The ConnectionString property has not been initialized.', N'
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'''')<>'''' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'''')='''' AND ISNULL(ih.CancelProve,'''')='''' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo

              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'''')<>'''' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND JobStatus<>99 AND ISNULL(CancelProve,'''')=''''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND ISNULL(CancelProve,'''')<>''''
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus

')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (57, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGIN', N'CS', N'9/25/2019 4:52:24 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (58, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGOUT', N'CS', N'9/25/2019 4:52:59 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (59, N'APL(192.168.1.43)', N'phhvbsep3yuew14kdpb04jvy', N'LOGIN', N'CS', N'9/25/2019 4:53:47 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (60, N'APL(192.168.1.43)', N'phhvbsep3yuew14kdpb04jvy', N'LOGOUT', N'CS', N'9/25/2019 4:53:54 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (61, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGIN', N'pasit', N'9/25/2019 4:54:48 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (62, N'APL(192.168.1.43)', N'2aqcy0iehuq3fkjx24eoieqs', N'LOGOUT', N'pasit', N'9/25/2019 4:59:52 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (63, N'APL(192.168.1.43)', N'ochfwoollpdpvrdo4x5qts5y', N'LOGIN', N'BOAT', N'9/25/2019 5:07:56 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (64, N'APL(192.168.1.43)', N'jesb02pgvuimrqwdbgd1rlro', N'LOGIN', N'ADMIN', N'9/25/2019 5:15:48 AM')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (65, N'APL(192.168.1.35)', N'JOBSHIPPING', N'ExecuteSQL', N'[ERROR]The ConnectionString property has not been initialized.', N'
UPDATE j
SET j.JobStatus=c.JobStatus
FROM Job_Order j INNER JOIN (
    SELECT s.BranchCode,s.JNo,MAX(s.JobStatus) as JobStatus
    FROM (
        SELECT BranchCode,JNo,0 as JobStatus FROM Job_Order 
        WHERE ConfirmDate IS NULL 
        AND JobStatus<>99 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate IS NULL
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,1 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND NOT DutyDate<=GETDATE()
        AND JobStatus<>1 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,2 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NULL AND DutyDate<=GETDATE()
        AND JobStatus<>2 AND NOT ISNULL(CancelReson,'''')<>'''' 
        UNION
        SELECT BranchCode,JNo,3 FROM Job_Order 
        WHERE ConfirmDate IS NOT NULL AND CloseJobDate IS NOT NULL
        AND JobStatus<>3 AND NOT ISNULL(CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,4 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)=0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,5 FROM Job_Order a 
        WHERE EXISTS(
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)>SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
              AND SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)>0
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION 
        SELECT a.BranchCode,a.JNo,6 FROM Job_Order a 
        WHERE EXISTS (
              SELECT b.BranchCode,b.JobNo as JNo,
              SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END) as TotalBill,
              COUNT(*) as TotalDoc
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              WHERE b.BranchCode=a.BranchCode AND b.JobNo=a.JNo
              AND h.DocStatus<>99 
              GROUP BY b.BranchCode,b.JobNo
              HAVING COUNT(*)=SUM(CASE WHEN ISNULL(b.LinkBillNo,'''')<>'''' THEN 1 ELSE 0 END)
        )
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT a.BranchCode,a.JNo,7 FROM Job_Order a 
        WHERE EXISTS
        (
              SELECT b.BranchCode,b.JobNo as JNo,SUM(b.BNet-ISNULL(r.TotalRcv,0)-ISNULL(c.CreditNet,0)-ISNULL(r.AmtCredit,0)-ISNULL(r.AmtDiscount,0)) as Balance
              FROM Job_ClearDetail b INNER JOIN Job_ClearHeader h
              ON b.BranchCode=h.BranchCode AND b.ClrNo=h.ClrNo
              LEFT JOIN (
                SELECT rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,Sum(rd.Net) as TotalRcv,id.AmtCredit,id.AmtDiscount
                FROM Job_ReceiptHeader rh INNER JOIN Job_ReceiptDetail rd
                ON rh.BranchCode=rd.BranchCode AND rh.ReceiptNo=rd.ReceiptNo
                INNER JOIN Job_InvoiceHeader ih
                ON rd.BranchCode=ih.BranchCode AND rd.InvoiceNo=ih.DocNo
                INNER JOIN Job_InvoiceDetail id
                ON rd.BranchCode=id.BranchCode AND rd.InvoiceNo=id.DocNo AND rd.InvoiceItemNo=id.ItemNo
                WHERE ISNULL(rh.CancelProve,'''')='''' AND ISNULL(ih.CancelProve,'''')='''' 
                GROUP BY rh.BranchCode,rd.InvoiceNo,rd.InvoiceItemNo,id.AmtCredit,id.AmtDiscount
              ) r                
              ON b.BranchCode=r.BranchCode AND b.LinkBillNo=r.InvoiceNo AND b.LinkItem=r.InvoiceItemNo
              LEFT JOIN (
                
select cd.BranchCode,cd.BillingNo,cd.BillItemNo,    
	sum(cd.DiffAmt) as CreditAmt,
	sum(cd.VATAmt) as CreditVat,
	sum(cd.WHTAmt) as CreditWht,
	sum(cd.TotalNet) as CreditNet,
    max(cd.DocNo) as CreditNo
	from Job_CNDNDetail cd inner join Job_CNDNHeader ch
	on cd.BranchCode=ch.BranchCode AND cd.DocNo=ch.DocNo
	and ch.DocStatus=1
	group by cd.BranchCode,cd.BillingNo,cd.BillItemNo

              ) c
              ON b.BranchCode=c.BranchCode AND b.LinkBillNo=c.BillingNo AND b.LinkItem=c.BillItemNo
              WHERE h.DocStatus<>99 AND b.BranchCode=a.BranchCode AND b.JobNo=a.JNo 
              AND b.LinkItem>0 AND ISNULL(b.LinkBillNo,'''')<>'''' 
              GROUP BY b.BranchCode,b.JobNo
              HAVING SUM(b.BNet-ISNULL(r.TotalRcv,0))<=0
        ) AND a.ConfirmDate IS NOT NULL AND a.CloseJobDate IS NOT NULL  
        AND a.JobStatus<>99 AND NOT ISNULL(a.CancelReson,'''')<>''''
        UNION
        SELECT BranchCode,JNo,98 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND JobStatus<>99 AND ISNULL(CancelProve,'''')=''''
        UNION
        SELECT BranchCode,JNo,99 as JobStatus FROM Job_Order 
        WHERE ISNULL(CancelReson,'''')<>'''' AND ISNULL(CancelProve,'''')<>''''
    ) s
    GROUP BY s.BranchCode,s.JNo
) c
ON j.BranchCode=c.BranchCode
AND j.JNo=c.JNo 
WHERE j.JobStatus<> c.JobStatus

')
INSERT [dbo].[TWTLog] ([LogID], [CustID], [AppID], [ModuleName], [LogAction], [Message]) VALUES (66, N'APL(192.168.1.43)', N'3drbc1xuronczpfetj1wqim3', N'LOGIN', N'ADMIN', N'9/25/2019 7:05:54 AM')
SET IDENTITY_INSERT [dbo].[TWTLog] OFF
SET IDENTITY_INSERT [dbo].[TWTSubscription] ON 

INSERT [dbo].[TWTSubscription] ([SubScriptionID], [SubscriptionName], [SubscriptionDesc], [AppID], [Edition], [BeginDate], [ExpireDate], [LoginCount]) VALUES (0, N'ทดสอบระบบภายใน', N'สำหรับ CS/PGM', N'JOBSHIPPING', 0, CAST(N'1900-01-01 00:00:00.000' AS DateTime), CAST(N'9999-12-31 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[TWTSubscription] ([SubScriptionID], [SubscriptionName], [SubscriptionDesc], [AppID], [Edition], [BeginDate], [ExpireDate], [LoginCount]) VALUES (1, N'ทดสอบระบบ', N'สำหรับ www.tawantechonline.com', N'JOBSHIPPING', 0, CAST(N'2019-10-01 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[TWTSubscription] OFF
INSERT [dbo].[TWTUser] ([TWTUserID], [TWTUserPassword], [TWTUserName]) VALUES (N'tawantech', N'9t;yogm8', N'ตะวันเทค')
INSERT [dbo].[TWTWebLogin] ([CustID], [AppID], [UserLogIN], [FromIP], [SessionID], [LoginDateTime], [ExpireDateTime]) VALUES (N'APL', N'JOBSHIPPING', N'ACM', N'192.168.1.43', N'ih5fsbxttgcj0zlerpfiijeb', CAST(N'2019-09-25 11:49:48.233' AS DateTime), CAST(N'2019-09-25 11:51:54.217' AS DateTime))
INSERT [dbo].[TWTWebLogin] ([CustID], [AppID], [UserLogIN], [FromIP], [SessionID], [LoginDateTime], [ExpireDateTime]) VALUES (N'APL', N'JOBSHIPPING', N'admin', N'192.168.1.43', N'3drbc1xuronczpfetj1wqim3', CAST(N'2019-09-25 14:05:54.800' AS DateTime), CAST(N'2019-09-25 14:25:54.800' AS DateTime))
INSERT [dbo].[TWTWebLogin] ([CustID], [AppID], [UserLogIN], [FromIP], [SessionID], [LoginDateTime], [ExpireDateTime]) VALUES (N'APL', N'JOBSHIPPING', N'BOAT', N'192.168.1.43', N'ochfwoollpdpvrdo4x5qts5y', CAST(N'2019-09-25 12:07:56.550' AS DateTime), CAST(N'2019-09-25 12:27:56.550' AS DateTime))
INSERT [dbo].[TWTWebLogin] ([CustID], [AppID], [UserLogIN], [FromIP], [SessionID], [LoginDateTime], [ExpireDateTime]) VALUES (N'APL', N'JOBSHIPPING', N'CS', N'192.168.1.43', N'phhvbsep3yuew14kdpb04jvy', CAST(N'2019-09-25 11:53:47.507' AS DateTime), CAST(N'2019-09-25 11:53:54.120' AS DateTime))
INSERT [dbo].[TWTWebLogin] ([CustID], [AppID], [UserLogIN], [FromIP], [SessionID], [LoginDateTime], [ExpireDateTime]) VALUES (N'APL', N'JOBSHIPPING', N'test', N'192.168.1.43', N'ypkujlihgku0wrkovq1rowd2', CAST(N'2019-09-25 11:47:08.490' AS DateTime), CAST(N'2019-09-25 11:51:26.823' AS DateTime))
