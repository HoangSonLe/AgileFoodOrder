USE [master]
GO
/****** Object:  Database [OrderFood]    Script Date: 11/6/2019 12:03:00 PM ******/
CREATE DATABASE [OrderFood]
GO
ALTER DATABASE [OrderFood] SET COMPATIBILITY_LEVEL = 120
GO
ALTER DATABASE [OrderFood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrderFood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrderFood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrderFood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrderFood] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrderFood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OrderFood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrderFood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrderFood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrderFood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrderFood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrderFood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrderFood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrderFood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrderFood] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OrderFood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrderFood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrderFood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrderFood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrderFood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrderFood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OrderFood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrderFood] SET RECOVERY FULL 
GO
ALTER DATABASE [OrderFood] SET  MULTI_USER 
GO
ALTER DATABASE [OrderFood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrderFood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrderFood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrderFood] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OrderFood] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OrderFood', N'ON'
GO
USE [OrderFood]
GO
/****** Object:  Table [dbo].[About]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[About](
	[AboutID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[AboutImage] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AboutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comment]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[Context] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](250) NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](250) NULL,
	[Password] [varchar](250) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[Phone] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](250) NULL,
	[Password] [varchar](250) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[Phone] [nvarchar](250) NULL,
	[BirthDate] [datetime] NULL,
	[Role] [int] NULL,
	[ManagerID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](250) NULL,
	[MenuContent] [nvarchar](250) NULL,
	[ParentID] [int] NULL,
	[IsActive] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[Comment] [nvarchar](250) NULL,
	[OrderStatus] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ShipDate] [datetime] NULL,
	[Total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[SeoTitle] [varchar](250) NULL,
	[Description] [nvarchar](MAX) NULL,
	[ProductImage] [varchar](250) NULL,
	[Price] [int] NULL,
	[PromotionPrice] [int] NULL,
	[IncludeVAT] [bit] NULL,
	[Quantity] [int] NULL,
	[CategoryID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
	[ViewCounts] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[ParentID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Roles]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Slider]    Script Date: 11/6/2019 12:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slider](
	[SlideID] [int] IDENTITY(1,1) NOT NULL,
	[SliderImage] [nvarchar](250) NULL,
	[Display] [int] NULL,
	[Description] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SlideID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [UserName], [Password], [FirstName], [LastName], [Address], [Email], [Phone], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (1, N'phuongnh', N'phuongnh', N'Hoàng', N'Phương', N'280 An Duong Vuong', N'phuongnh@gmail.com', N'0123456', CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Customer] ([CustomerID], [UserName], [Password], [FirstName], [LastName], [Address], [Email], [Phone], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (2, N'thanhhv', N'thanhhv', N'Văn', N'Thành', N'280 An Duong Vuong', N'thanhhv@gmail.com', N'0123456', CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [UserName], [Password], [FirstName], [LastName], [Address], [Email], [Phone], [BirthDate], [Role], [ManagerID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (1, N'sonlh', N'b3003135720325e541923035f440ea96', N'Sơn mạp map', N'Sơn mạp mạp mapj đĩ chó', N'280 An Duong Vuong', N'sonlh@gmail.com', N'012345678', CAST(N'1998-11-02 00:00:00.000' AS DateTime), 1, 0, CAST(N'2019-11-04 23:04:49.860' AS DateTime), NULL, CAST(N'2019-11-04 23:04:49.860' AS DateTime), NULL, 1)
INSERT [dbo].[Employee] ([EmployeeID], [UserName], [Password], [FirstName], [LastName], [Address], [Email], [Phone], [BirthDate], [Role], [ManagerID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (2, N'minhlc', N'minhlc', N'Minh', N'Cẩm lò cò', N'280 An Duong Vuong', N'minhlc@gmail.com', N'012345678', CAST(N'1998-11-02 00:00:00.000' AS DateTime), 2, 1, CAST(N'2019-11-04 23:00:38.537' AS DateTime), 1, CAST(N'2019-11-04 23:00:38.537' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([MenuID], [MenuName], [MenuContent], [ParentID], [IsActive]) VALUES (1, N'Trang Chủ', N'', NULL, 1)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [MenuContent], [ParentID], [IsActive]) VALUES (2, N'Sản Phẩm', N'', NULL, 1)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [MenuContent], [ParentID], [IsActive]) VALUES (3, N'Giỏ Hàng', N'', NULL, 1)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [MenuContent], [ParentID], [IsActive]) VALUES (4, N'Liên Hệ', N'', NULL, 1)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (1, 1, 1, 3)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (2, 1, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (3, 2, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (4, 2, 3, 1)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [Comment], [OrderStatus], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [ShipDate], [Total]) VALUES (1, 1, NULL, N'Giao trước 3h', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [Comment], [OrderStatus], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [ShipDate], [Total]) VALUES (2, 2, NULL, N'Giao trước 7h', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (1, N'Bắp Bò Luộc', N'mon-hap/bap-bo-luoc', N'', N'BapBoLuoc.jpg', 70000, 65000, 0, 500235545, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 0, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (2, N'Cá Diêu Hồng Hấp', N'mon-hap/ca-dieu-hong-hap', N'', N'CaDieuHongHap.jpg', 80000, 65000, 1, 500, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (3, N'Cua Hấp', N'mon-hap/cua-hap', N'', N'CuaHap.jpg', 80000, 65000, 1, 50, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (4, N'Gà Hấp Hành', N'mon-hap/ga-hap-hanh', N'', N'GaHapHanh.jpg', 150000, 140000, 1, 50, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (5, N'Gà Hấp Muối', N'mon-hap/ga-hap-muoi', N'', N'GaHapMuoi.jpg', 150000, 140000, 1, 40, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (6, N'Nghêu Hấp Thái', N'mon-hap/ngheu-hap-thai', N'', N'NgheuHapThai.jpg', 70000, 60000, 1, 50, 4, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (7, N'Bắp Xào Bơ', N'mon-xao/bap-xao-bo', N'', N'BapXaoBo.jpg', 20000, 15000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (8, N'Lươn Xào Lăn', N'mon-xao/luon-xao-lan', N'', N'LuonXaoLan.jpg', 150000, 140000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (9, N'Mì Xào Bò', N'mon-xao/mi-xao-bo', N'', N'MyXaoBo.jpg', 40000, 35000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (10, N'Mì Xào Hải Sản', N'mon-xao/mi-xao-hai-san', N'', N'MyXaoHaiSan.jpg', 40000, 35000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (11, N'Mì Xào Trứng', N'mon-xao/mi-xao-trung', N'', N'MyXaoTrung.jpg', 30000, 25000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (12, N'Nui Xào Trứng', N'mon-xao/mi-xao-trung', N'', N'NuiXaoTrung.jpg', 30000, 25000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (13, N'Nui Xào Bò', N'mon-xao/nui-xao-bo', N'', N'NuiXaoBo.jpg', 40000, 35000, 1, 60, 5, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (14, N'Cơm Chiên Dương Châu', N'mon-chien/com-chien-duong-chau', N'', N'ComChienDuongChau.jpg', 40000, 35000, 1, 60, 6, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (15, N'Cơm Chiên Xúc Xích', N'mon-chien/com-chien-xuc-xich', N'', N'ComChienXucXich.jpg', 40000, 35000, 1, 60, 6, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (16, N'Cơm Gà Xối Mỡ', N'mon-chien/com-ga-xoi-mo', N'', N'ComChienXucXich.jpg', 50000, 40000, 1, 80, 6, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (17, N'Giò Heo Chiên Giòn', N'mon-chien/gio-heo-chien-gion', N'', N'GioHeoChienGion.jpg', 50000, 40000, 1, 80, 6, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (18, N'Bạch Tuộc Nướng', N'mon-nuong/bach-tuoc-nuong', N'', N'BachTuocNuong.jpg', 50000, 45000, 1, 50, 7, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (19, N'Ba Rọi Nướng', N'mon-nuong/ba-roi-nuong', N'', N'BaRoiNuong.jpg', 50000, 45000, 1, 50, 7, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (20, N'Bò Nướng Lụi', N'mon-nuong/bo-nuong-lui', N'', N'BoNuongLui.jpg', 50000, 45000, 1, 50, 7, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (21, N'Cá Sapa Nướng', N'mon-nuong/ca-sapa-nuong', N'', N'CaSapaNuong.jpg', 50000, 45000, 1, 80, 7, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (22, N'Đùi Gà Quay', N'mon-nuong/dui-ga-quay', N'', N'DuiGaQuay.jpg', 50000, 45000, 1, 80, 7, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (23, N'Phở Bò', N'mon-nuoc/dui-ga-quay', N'', N'PhoBo.jpg', 40000, 35000, 1, 80, 8, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (24, N'Mì Sủi Cảo', N'mon-nuoc/mi-sui-cao', N'', N'MySuiCao.jpg', 40000, 35000, 1, 80, 8, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (25, N'Mì Vit Tiem', N'mon-nuoc/mi-vit-tiem', N'', N'MyVitTiem.jpg', 40000, 35000, 1, 80, 8, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (26, N'Súp Cua', N'mon-nuoc/sup-cua', N'', N'SupCua.jpg', 40000, 35000, 1, 80, 8, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (27, N'CocaCola', N'do-uong-dong-chai/cocacola', N'', N'CocaCola.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (28, N'Pepsi', N'do-uong-dong-chai/pepsi', N'', N'Pepsi.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (29, N'Mirinda Soda Kem', N'do-uong-dong-chai/mirinda-soda-kem', N'', N'MirindaSodaKem.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (30, N'Mirinda Cam', N'do-uong-dong-chai/mirinda-cam', N'', N'MirindaCam.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (31, N'Mirinda Sá Xị', N'do-uong-dong-chai/mirinda-sa-xi', N'', N'MirindaSaxi.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (32, N'Bò Húc', N'do-uong-dong-chai/bo-huc', N'', N'BoHuc.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (33, N'Sting Dâu', N'do-uong-dong-chai/sting-dau', N'', N'StingDau.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (34, N'Sting Vàng', N'do-uong-dong-chai/sting-vang', N'', N'StingVang.jpg', 15000, 10000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (35, N'Heniken', N'do-uong-dong-chai/heniken', N'', N'Heniken.jpg', 20000, 15000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (36, N'Tiger Nâu', N'do-uong-dong-chai/tiger-nau', N'', N'TigerNau.jpg', 20000, 15000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (37, N'Tiger Bạc', N'do-uong-dong-chai/tiger-bac', N'', N'TigerBac.jpg', 20000, 15000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (38, N'Monster', N'do-uong-dong-chai/monster', N'', N'Monster.jpg', 40000, 35000, 1, 500, 9, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (39, N'Nước Ép Cam', N'do-uong-tu-lam/nuoc-ep-cam', N'', N'CamEp.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (40, N'Nước Ép Ổi', N'do-uong-tu-lam/nuoc-ep-oi', N'', N'OiEp.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (41, N'Nước Ép Chanh', N'do-uong-tu-lam/nuoc-ep-chanh', N'', N'ChanhEp.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (42, N'Nước Ép Carot', N'do-uong-tu-lam/nuoc-ep-carot', N'', N'CarotEp.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (43, N'Nước Ép Cà Chua', N'do-uong-tu-lam/nuoc-ep-ca-chua', N'', N'CaChuaEp.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (44, N'Trà Sữa', N'do-uong-tu-lam/tra-sua', N'', N'TraSua.jpg', 20000, 15000, 1, 500, 10, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (45, N'Chè Sâm Bổ Lượng', N'che/che-sam-bo-luong', N'', N'CheSamBoLuong.jpg', 15000, 10000, 1, 500, 11, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (46, N'Chè Thái', N'che/che-thai', N'', N'CheThai.jpg', 15000, 10000, 1, 500, 11, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (47, N'Chè Long Nhản', N'che/che-long-nhan', N'', N'CheLongNhan.jpg', 15000, 10000, 1, 500, 11, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (48, N'Chè Khúc Bạch', N'che/che-khuc-bach', N'', N'CheKhucBach.jpg', 15000, 10000, 1, 500, 11, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (49, N'Trái Cây Tô', N'trai-cay/trai-cay-to', N'', N'TraiCayTo.jpg', 20000, 15000, 1, 500, 13, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (50, N'Su Kem', N'banh/su-kem', N'', N'SuKem.jpg', 15000, 10000, 1, 500, 12, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (51, N'Donut', N'banh/donut', N'', N'Donut.jpg', 15000, 10000, 1, 500, 12, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [SeoTitle], [Description], [ProductImage], [Price], [PromotionPrice], [IncludeVAT], [Quantity], [CategoryID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status], [ViewCounts]) VALUES (52, N'Bông Lan Trứng Muối', N'banh/bong-lan-trung-muoi', N'', N'BongLanTrungMuoi.jpg', 15000, 10000, 1, 500, 12, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1, 20)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (1, N'Đồ Ăn', N'do-an', NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (2, N'Đồ Uống', N'do-uong', NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (3, N'Tráng Miệng', N'trang-mieng', NULL, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (4, N'Món Hấp', N'mon-hap', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (5, N'Món Xào', N'mon-xao', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (6, N'Món Chiên', N'mon-chien', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (7, N'Món Nướng', N'mon-nuong', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (8, N'Món Nước', N'mon-nuoc', 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (9, N'Đồ Uống Đóng Chai', N'do-uong-dong-chai', 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (10, N'Đồ Uống Tự Làm', N'do-uong-tu-lam', 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (11, N'Chè', N'che', 3, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (12, N'Bánh', N'banh', 3, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[ProductCategory] ([CategoryID], [Name], [MetaTitle], [ParentID], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (13, N'Trái Cây', N'trai-cay', 3, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 2, CAST(N'2019-10-14 00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (0, N'')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Super Admin')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Admin')
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Role])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD FOREIGN KEY([ParentID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[ProductCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD FOREIGN KEY([ParentID])
REFERENCES [dbo].[ProductCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
USE [master]
GO
ALTER DATABASE [OrderFood] SET  READ_WRITE 
GO
