USE [DEVTEST]
GO
/****** Object:  Table [dbo].[TWTApp]    Script Date: 02/08/2019 16:09:45 ******/
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
/****** Object:  Table [dbo].[TWTCustomer]    Script Date: 02/08/2019 16:09:45 ******/
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
/****** Object:  Table [dbo].[TWTCustomerApp]    Script Date: 02/08/2019 16:09:45 ******/
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
/****** Object:  Table [dbo].[TWTLog]    Script Date: 02/08/2019 16:09:45 ******/
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
/****** Object:  Table [dbo].[TWTSubscription]    Script Date: 02/08/2019 16:09:45 ******/
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
 CONSTRAINT [PK_TWTSubscription] PRIMARY KEY CLUSTERED 
(
	[SubScriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
