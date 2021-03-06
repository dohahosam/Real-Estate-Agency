USE [master]
GO
/****** Object:  Database [REA]    Script Date: 5/7/2019 11:32:39 AM ******/
CREATE DATABASE [REA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'REA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\REA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'REA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\REA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [REA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [REA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [REA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [REA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [REA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [REA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [REA] SET ARITHABORT OFF 
GO
ALTER DATABASE [REA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [REA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [REA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [REA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [REA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [REA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [REA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [REA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [REA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [REA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [REA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [REA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [REA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [REA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [REA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [REA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [REA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [REA] SET RECOVERY FULL 
GO
ALTER DATABASE [REA] SET  MULTI_USER 
GO
ALTER DATABASE [REA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [REA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [REA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [REA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [REA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [REA] SET QUERY_STORE = OFF
GO
USE [REA]
GO
/****** Object:  Table [dbo].[AgentArea]    Script Date: 5/7/2019 11:32:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgentArea](
	[AgentUsername] [varchar](50) NOT NULL,
	[AreaID] [int] NOT NULL,
 CONSTRAINT [PK_AgentArea] PRIMARY KEY CLUSTERED 
(
	[AgentUsername] ASC,
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bed]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bed](
	[Housing#] [int] NOT NULL,
	[Room#] [int] NOT NULL,
	[Bed#] [int] IDENTITY(1,1) NOT NULL,
	[Availability] [bit] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Bed] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC,
	[Room#] ASC,
	[Bed#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedRent]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedRent](
	[Housing#] [int] NOT NULL,
	[Room#] [int] NOT NULL,
	[Bed#] [int] NOT NULL,
	[RentalStartDate] [datetime] NOT NULL,
	[RentalEndDate] [datetime] NOT NULL,
	[RenterUsername] [varchar](50) NOT NULL,
	[RentalPrice] [int] NOT NULL,
 CONSTRAINT [PK_BedRent] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC,
	[Room#] ASC,
	[Bed#] ASC,
	[RentalStartDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Username] [varchar](50) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[MInit] [varchar](1) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Gender] [char](10) NULL,
	[BirthDate] [datetime] NULL,
	[Phone#] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Username] [varchar](50) NOT NULL,
	[SSN] [int] NOT NULL,
	[AveragRating] [decimal](18, 0) NULL,
	[FName] [varchar](50) NOT NULL,
	[MInit] [varchar](1) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[BirthDate] [datetime] NULL,
	[Phone#] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[ManagerUsername] [varchar](50) NULL,
	[Privilege] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Housing]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Housing](
	[Housing#] [int] IDENTITY(1,1) NOT NULL,
	[OwnerUsername] [varchar](50) NOT NULL,
	[AreaID] [int] NOT NULL,
	[Availability] [bit] NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[RentersGender] [varchar](50) NULL,
	[Price] [int] NULL,
	[NoOfBeds] [int] NULL,
	[NoOfRooms] [int] NULL,
	[RentDurationInMonths] [int] NULL,
	[Furnished] [bit] NULL,
	[RentalType] [varchar](50) NULL,
	[NaturalGas] [bit] NULL,
	[InternetConnection] [bit] NULL,
	[AirConditioned] [bit] NULL,
	[Extra] [varchar](max) NULL,
 CONSTRAINT [PK_Housing] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HousingRent]    Script Date: 5/7/2019 11:32:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HousingRent](
	[Housing#] [int] NOT NULL,
	[RentalStartDate] [datetime] NOT NULL,
	[RenterUsername] [varchar](50) NULL,
	[RentalEndDate] [datetime] NULL,
	[RentalPrice] [int] NULL,
 CONSTRAINT [PK_HousingRent] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC,
	[RentalStartDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerArea]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerArea](
	[ManagerUsername] [varchar](50) NOT NULL,
	[AreaID] [int] NOT NULL,
 CONSTRAINT [PK_ManagerArea] PRIMARY KEY CLUSTERED 
(
	[ManagerUsername] ASC,
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Privilege]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privilege](
	[Privilige] [varchar](1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Privilege] PRIMARY KEY CLUSTERED 
(
	[Privilige] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RateAgent]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RateAgent](
	[CustomerUsername] [varchar](50) NOT NULL,
	[AgentUsername] [varchar](50) NOT NULL,
	[Rating] [decimal](4, 0) NOT NULL,
	[RatingDate] [datetime] NOT NULL,
 CONSTRAINT [PK_RateAgent] PRIMARY KEY CLUSTERED 
(
	[CustomerUsername] ASC,
	[AgentUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Housing#] [int] NOT NULL,
	[Room#] [int] IDENTITY(1,1) NOT NULL,
	[NoOfBeds] [int] NULL,
	[Availability] [bit] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC,
	[Room#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomRent]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomRent](
	[Housing#] [int] NOT NULL,
	[Room#] [int] NOT NULL,
	[RentalStartDate] [datetime] NOT NULL,
	[RentalEndDate] [datetime] NULL,
	[RenterUsername] [varchar](50) NULL,
	[RentalPrice] [int] NULL,
 CONSTRAINT [PK_RoomRent] PRIMARY KEY CLUSTERED 
(
	[Housing#] ASC,
	[Room#] ASC,
	[RentalStartDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Privilege] [varchar](1) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Areas] ON 

INSERT [dbo].[Areas] ([ID], [Name]) VALUES (1, N'1st district')
INSERT [dbo].[Areas] ([ID], [Name]) VALUES (2, N'2nd district')
INSERT [dbo].[Areas] ([ID], [Name]) VALUES (3, N'7th district')
INSERT [dbo].[Areas] ([ID], [Name]) VALUES (4, N'Alaswany')
INSERT [dbo].[Areas] ([ID], [Name]) VALUES (5, N'Fardoos')
SET IDENTITY_INSERT [dbo].[Areas] OFF
INSERT [dbo].[Customer] ([Username], [FName], [MInit], [LName], [Gender], [BirthDate], [Phone#]) VALUES (N'ahmedahmed', N'ahmed', N'a', N'ahmed', N'm         ', CAST(N'1905-06-04T00:00:00.000' AS DateTime), 10)
INSERT [dbo].[Customer] ([Username], [FName], [MInit], [LName], [Gender], [BirthDate], [Phone#]) VALUES (N'bosbos', N'ahmed', N'a', N'ahmed', N'm         ', CAST(N'1905-06-04T00:00:00.000' AS DateTime), 10)
INSERT [dbo].[Customer] ([Username], [FName], [MInit], [LName], [Gender], [BirthDate], [Phone#]) VALUES (N'tiger15', N'tiger', N'a', N'roar', N'f         ', CAST(N'1905-06-04T00:00:00.000' AS DateTime), 10)
SET IDENTITY_INSERT [dbo].[Housing] ON 

INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (1, N'bosbos', 2, 1, N'asddf', N'f', 1253, 3, 3, 15, 1, N'Room', 1, 1, 1, N'   ')
INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (2, N'bosbos', 1, 1, N'the', N'f', 1253, 3, 3, 15, 1, N'House', 1, 1, 1, N'   ')
INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (3, N'tiger15', 1, 1, N'the', N'f', 1253, 3, 3, 15, 1, N'House', 1, 1, 1, N'   ')
INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (4, N'tiger15', 1, 1, N'the', N'f', 1253, 3, 3, 15, 1, N'House', 1, 1, 1, N'   ')
INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (5, N'tiger15', 4, 0, N'aswany', N'f', 1253, 3, 3, 15, 1, N'House', 1, 1, 1, N'   ')
INSERT [dbo].[Housing] ([Housing#], [OwnerUsername], [AreaID], [Availability], [Address], [RentersGender], [Price], [NoOfBeds], [NoOfRooms], [RentDurationInMonths], [Furnished], [RentalType], [NaturalGas], [InternetConnection], [AirConditioned], [Extra]) VALUES (6, N'bosbos', 1, 1, N'aaa', N'f', 150, 5, 5, 6, 1, N'House', 1, 1, 0, N'hhh')
SET IDENTITY_INSERT [dbo].[Housing] OFF
INSERT [dbo].[HousingRent] ([Housing#], [RentalStartDate], [RenterUsername], [RentalEndDate], [RentalPrice]) VALUES (5, CAST(N'2019-05-07T05:32:08.130' AS DateTime), N'bosbos', CAST(N'2020-05-07T05:32:08.000' AS DateTime), 600)
INSERT [dbo].[Privilege] ([Privilige], [Role]) VALUES (N'A', N'Agent')
INSERT [dbo].[Privilege] ([Privilige], [Role]) VALUES (N'C', N'Customer')
INSERT [dbo].[Privilege] ([Privilige], [Role]) VALUES (N'M', N'manager')
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Housing#], [Room#], [NoOfBeds], [Availability], [Price]) VALUES (1, 1, 2, 1, 200)
INSERT [dbo].[Room] ([Housing#], [Room#], [NoOfBeds], [Availability], [Price]) VALUES (1, 3, 3, 1, 500)
SET IDENTITY_INSERT [dbo].[Room] OFF
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'3la2', N'alaa@gmail.com', N'shaba7', N'A')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'A', N'I', N'ali', N'A')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'ahmedahmed', N'ahmed@gmail.com', N'ahmed', N'C')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'Aj', N'I', N'ali', N'A')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'Ali', N'ali', N'ali', N'A')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'AsmaaAsmaa', N'Asmaa@gmail.com', N'ohoh', N'M')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'bosbos', N'bosy@gmail.com', N'bosybosy', N'C')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'doha', N'doha@gmail.com', N'wow', N'M')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'sayed11', N'sayed@gmail.com', N'1152011', N'A')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'sfoREAlma', N'salma@gmail.com', N'no98', N'M')
INSERT [dbo].[User] ([Username], [EmailAddress], [Password], [Privilege]) VALUES (N'tiger15', N'tiger15@gmail.com', N'2345', N'C')
ALTER TABLE [dbo].[Housing] ADD  CONSTRAINT [DF_Housing_Availability]  DEFAULT ((1)) FOR [Availability]
GO
ALTER TABLE [dbo].[AgentArea]  WITH CHECK ADD  CONSTRAINT [FK_AgentArea_Areas] FOREIGN KEY([AreaID])
REFERENCES [dbo].[Areas] ([ID])
GO
ALTER TABLE [dbo].[AgentArea] CHECK CONSTRAINT [FK_AgentArea_Areas]
GO
ALTER TABLE [dbo].[AgentArea]  WITH CHECK ADD  CONSTRAINT [FK_AgentArea_Employee] FOREIGN KEY([AgentUsername])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[AgentArea] CHECK CONSTRAINT [FK_AgentArea_Employee]
GO
ALTER TABLE [dbo].[Bed]  WITH CHECK ADD  CONSTRAINT [FK_Bed_Room] FOREIGN KEY([Housing#], [Room#])
REFERENCES [dbo].[Room] ([Housing#], [Room#])
GO
ALTER TABLE [dbo].[Bed] CHECK CONSTRAINT [FK_Bed_Room]
GO
ALTER TABLE [dbo].[BedRent]  WITH CHECK ADD  CONSTRAINT [FK_BedRent_Bed] FOREIGN KEY([Housing#], [Room#], [Bed#])
REFERENCES [dbo].[Bed] ([Housing#], [Room#], [Bed#])
GO
ALTER TABLE [dbo].[BedRent] CHECK CONSTRAINT [FK_BedRent_Bed]
GO
ALTER TABLE [dbo].[BedRent]  WITH CHECK ADD  CONSTRAINT [FK_BedRent_Customer] FOREIGN KEY([RenterUsername])
REFERENCES [dbo].[Customer] ([Username])
GO
ALTER TABLE [dbo].[BedRent] CHECK CONSTRAINT [FK_BedRent_Customer]
GO
ALTER TABLE [dbo].[Customer]  WITH NOCHECK ADD  CONSTRAINT [FK_Customer_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_User]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([ManagerUsername])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_User]
GO
ALTER TABLE [dbo].[Housing]  WITH CHECK ADD  CONSTRAINT [FK_Housing_Areas] FOREIGN KEY([AreaID])
REFERENCES [dbo].[Areas] ([ID])
GO
ALTER TABLE [dbo].[Housing] CHECK CONSTRAINT [FK_Housing_Areas]
GO
ALTER TABLE [dbo].[Housing]  WITH CHECK ADD  CONSTRAINT [FK_Housing_Customer] FOREIGN KEY([OwnerUsername])
REFERENCES [dbo].[Customer] ([Username])
GO
ALTER TABLE [dbo].[Housing] CHECK CONSTRAINT [FK_Housing_Customer]
GO
ALTER TABLE [dbo].[HousingRent]  WITH CHECK ADD  CONSTRAINT [FK_HousingRent_Customer] FOREIGN KEY([RenterUsername])
REFERENCES [dbo].[Customer] ([Username])
GO
ALTER TABLE [dbo].[HousingRent] CHECK CONSTRAINT [FK_HousingRent_Customer]
GO
ALTER TABLE [dbo].[HousingRent]  WITH CHECK ADD  CONSTRAINT [FK_HousingRent_Housing] FOREIGN KEY([Housing#])
REFERENCES [dbo].[Housing] ([Housing#])
GO
ALTER TABLE [dbo].[HousingRent] CHECK CONSTRAINT [FK_HousingRent_Housing]
GO
ALTER TABLE [dbo].[ManagerArea]  WITH CHECK ADD  CONSTRAINT [FK_ManagerArea_Areas] FOREIGN KEY([AreaID])
REFERENCES [dbo].[Areas] ([ID])
GO
ALTER TABLE [dbo].[ManagerArea] CHECK CONSTRAINT [FK_ManagerArea_Areas]
GO
ALTER TABLE [dbo].[ManagerArea]  WITH CHECK ADD  CONSTRAINT [FK_ManagerArea_Employee] FOREIGN KEY([ManagerUsername])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[ManagerArea] CHECK CONSTRAINT [FK_ManagerArea_Employee]
GO
ALTER TABLE [dbo].[RateAgent]  WITH CHECK ADD  CONSTRAINT [FK_RateAgent_Customer] FOREIGN KEY([CustomerUsername])
REFERENCES [dbo].[Customer] ([Username])
GO
ALTER TABLE [dbo].[RateAgent] CHECK CONSTRAINT [FK_RateAgent_Customer]
GO
ALTER TABLE [dbo].[RateAgent]  WITH CHECK ADD  CONSTRAINT [FK_RateAgent_Employee] FOREIGN KEY([AgentUsername])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[RateAgent] CHECK CONSTRAINT [FK_RateAgent_Employee]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Housing] FOREIGN KEY([Housing#])
REFERENCES [dbo].[Housing] ([Housing#])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Housing]
GO
ALTER TABLE [dbo].[RoomRent]  WITH CHECK ADD  CONSTRAINT [FK_RoomRent_Customer] FOREIGN KEY([RenterUsername])
REFERENCES [dbo].[Customer] ([Username])
GO
ALTER TABLE [dbo].[RoomRent] CHECK CONSTRAINT [FK_RoomRent_Customer]
GO
ALTER TABLE [dbo].[RoomRent]  WITH CHECK ADD  CONSTRAINT [FK_RoomRent_Room] FOREIGN KEY([Housing#], [Room#])
REFERENCES [dbo].[Room] ([Housing#], [Room#])
GO
ALTER TABLE [dbo].[RoomRent] CHECK CONSTRAINT [FK_RoomRent_Room]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Privilege] FOREIGN KEY([Privilege])
REFERENCES [dbo].[Privilege] ([Privilige])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Privilege]
GO
/****** Object:  StoredProcedure [dbo].[AddNewCustomer]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewCustomer]
@Username varchar(50),
@EmailAddress varchar(50),
@Password varchar(50),
@Privilege varchar(1),
@FName varchar(50),
@MInit varchar(1),
@LName varchar(50),
@Gender char(10),
@BirthDate datetime,
@Phone# int

AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO [dbo].[User]
	values (@Username , @EmailAddress , @Password , @Privilege)
	INSERT INTO [dbo].[Customer] 
	values (@Username, @FName, @MInit, @LName, @Gender, @BirthDate, @Phone#)

END
GO
/****** Object:  StoredProcedure [dbo].[AgentByPhone]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[AgentByPhone]
@phone# int

AS
BEGIN
Select Username, FName, MInit, LName
From Employee
Where Privilege = 'A' and Phone#=@phone#
End
GO
/****** Object:  StoredProcedure [dbo].[AgentPhone]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgentPhone]
@AreaID int
AS
Begin
Select Employee.Phone#
From AgentArea,Employee
where AgentArea.AgentUsername=Employee.Username And AgentArea.AreaID=@AreaID
End
GO
/****** Object:  StoredProcedure [dbo].[BedAvailability]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BedAvailability]
@Bed# int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Bed]
	SET Availability = 0 
	WHERE Bed# = @Bed#
END
GO
/****** Object:  StoredProcedure [dbo].[calAvgRating]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[calAvgRating]
@AgentUser varchar(50),
@AvgRating decimal
As
Begin
Update dbo.Employee
Set AveragRating=@AvgRating
where Username=@AgentUser

End
GO
/****** Object:  StoredProcedure [dbo].[deleteEmp]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteEmp]
@Username varchar(50)

As
Begin

Delete from [dbo].[AgentArea]
where [dbo].[AgentArea].AgentUsername=@Username

Delete from [dbo].[ManagerArea]
where [dbo].[ManagerArea].ManagerUsername=@Username

Delete from Employee
where Employee.Username=@Username

Delete from [dbo].[User]
where [dbo].[User].Username=@Username

Delete from [dbo].[AgentArea]
where [dbo].[AgentArea].AgentUsername=@Username
End
GO
/****** Object:  StoredProcedure [dbo].[getAllAreas]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllAreas]
AS
BEGIN
	
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT name,ID from Areas
END
GO
/****** Object:  StoredProcedure [dbo].[GetAreaID]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAreaID]
	
	@AreaName varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

SELECT ID 
	FROM Areas
	WHERE Name = @AreaName
END
GO
/****** Object:  StoredProcedure [dbo].[getEmployee]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getEmployee]
@Username varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select *
	from dbo.[User]as U, Employee
	where U.Username=Employee.Username and U.Username=@Username
End
GO
/****** Object:  StoredProcedure [dbo].[getManagers]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getManagers]
AS
BEGIN
	SET NOCOUNT ON;

	Select U.Username
	from [dbo].[User] as U
	where U.Privilege='M'
END
GO
/****** Object:  StoredProcedure [dbo].[getPrivileges]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPrivileges]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from Privilege
END
GO
/****** Object:  StoredProcedure [dbo].[HouseAvailability]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HouseAvailability]
@Housing# int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Housing]
	SET Availability = 0 
	WHERE Housing# = @Housing#
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAgentArea]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertAgentArea]
@Username varchar(50),
@AreaID int

As
Begin
insert into [dbo].AgentArea
values (@Username, @AreaID)

End
GO
/****** Object:  StoredProcedure [dbo].[InsertBed]    Script Date: 5/7/2019 11:32:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertBed]
	-- Add the parameters for the stored procedure here
		@OwnerUsername varchar(50), @AreaID int, @Address varchar(MAX), @RentersGender varchar(50),
	@price int, @Type varchar(50), @Floor# int, @AreaInMeters int, @NoOfBeds int, @NoOfFloors int, @NoOfRooms int,
	@RentDuration int, @Furnished bit,  @RentalType varchar(50), @Cooker bit, @Fridge bit, @Garage bit, @Elevator bit, 
	@TV bit, @NaturalGas bit, @InternetConnection bit, @WashingMachine bit, @AirConditioned bit, @Extra varchar(MAX), @Availibility bit, @RNumberOfBeds int, @RAvailibiluty bit, @RPrice int,
	@BPrice int, @BAvailibilty bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
INSERT INTO Housing(OwnerUsername,AreaID,Availability,Address,RentersGender,Price,Type,Floor#,AreaInMeters,NoOfBeds,NoOfFloors,NoOfRooms,RentDurationInMonths,Furnished,RentalType,Cooker,Fridge,Garage,Elevator,TV,NaturalGas,InternetConnection,WashingMachine,AirConditioned,Extra)
Values (@OwnerUsername,@AreaID,@Availibility,@Address,@RentersGender,@price,@Type,@Floor#,@AreaInMeters, @NoOfBeds,@NoOfFloors,@NoOfRooms,@RentDuration,
@Furnished, @RentalType,@Cooker,@Fridge,@Garage,@Elevator,@TV,@NaturalGas,@InternetConnection,@WashingMachine,@AirConditioned,@Extra)

INSERT INTO Room(NoOfBeds,Availability,Price)
Values(@RNumberOfBeds,@RAvailibiluty,@RPrice)

INSERT INTO Bed(Availability,Price)
Values(@BAvailibilty,@BPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertEmp]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertEmp]
@Username varchar(50),
@EmailAddress varchar(50), @Password varchar(50), @Privilege Varchar(1), @SSN int,
@AverageRating varchar(50), @FName varchar(50), @Minit varchar(1), @LName varchar(50),
@Gender varchar(1), @Birthdate date, @Phone# int, @salary int, @ManagerUser varchar(50) 
AS
BEGIN
	SET NOCOUNT ON;

    insert into [dbo].[User]
	values (@Username, @EmailAddress, @Password, @Privilege)

	insert into [dbo].[Employee]
	values (@Username, @SSN, @AverageRating, @FName, @Minit,@LName, @Gender, @Birthdate, @Phone#, @salary, @ManagerUser, @Privilege)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertHouse]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertHouse] 
	-- Add the parameters for the stored procedure here
	@OwnerUsername varchar(50), @AreaID int, @Address varchar(MAX), @RentersGender varchar(50),
	@price int,  @NoOfBeds int,  @NoOfRooms int,
	@RentDuration int, @Furnished bit,  @RentalType varchar(50), @NaturalGas bit, @InternetConnection bit,  @AirConditioned bit, @Extra varchar(MAX), @Availibility bit 
AS
BEGIN
	
	SET NOCOUNT ON;


INSERT INTO Housing(OwnerUsername,AreaID,Availability,Address,RentersGender,Price,NoOfBeds,NoOfRooms,RentDurationInMonths,Furnished,RentalType,NaturalGas,InternetConnection,AirConditioned,Extra)
Values (@OwnerUsername,@AreaID,@Availibility,@Address,@RentersGender,@price, @NoOfBeds,@NoOfRooms,@RentDuration,
@Furnished, @RentalType,@NaturalGas,@InternetConnection,@AirConditioned,@Extra)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertManagerArea]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertManagerArea]
@Username varchar(50),
@AreaID int

As
Begin
insert into [dbo].ManagerArea
values (@Username, @AreaID)

End
GO
/****** Object:  StoredProcedure [dbo].[InsertRoom]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertRoom] 
	-- Add the parameters for the stored procedure here
		@OwnerUsername varchar(50), @AreaID int, @Address varchar(MAX), @RentersGender varchar(50),
	@price int, @Type varchar(50), @Floor# int, @AreaInMeters int, @NoOfBeds int, @NoOfFloors int, @NoOfRooms int,
	@RentDuration int, @Furnished bit,  @RentalType varchar(50), @Cooker bit, @Fridge bit, @Garage bit, @Elevator bit, 
	@TV bit, @NaturalGas bit, @InternetConnection bit, @WashingMachine bit, @AirConditioned bit, @Extra varchar(MAX), @Availibility bit, @RNumberOfBeds int, @RAvailibiluty bit, @RPrice int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Housing(OwnerUsername,AreaID,Availability,Address,RentersGender,Price,Type,Floor#,AreaInMeters,NoOfBeds,NoOfFloors,NoOfRooms,RentDurationInMonths,Furnished,RentalType,Cooker,Fridge,Garage,Elevator,TV,NaturalGas,InternetConnection,WashingMachine,AirConditioned,Extra)
Values (@OwnerUsername,@AreaID,@Availibility,@Address,@RentersGender,@price,@Type,@Floor#,@AreaInMeters, @NoOfBeds,@NoOfFloors,@NoOfRooms,@RentDuration,
@Furnished, @RentalType,@Cooker,@Fridge,@Garage,@Elevator,@TV,@NaturalGas,@InternetConnection,@WashingMachine,@AirConditioned,@Extra)

INSERT INTO Room(NoOfBeds,Availability,Price)
Values(@RNumberOfBeds,@RAvailibiluty,@RPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login]
@Username varchar(50),
@Password varchar(50)
AS 
BEGIN

SELECT Privilege
FROM [User]

WHERE Username = @Username AND [Password] = @Password

END
GO
/****** Object:  StoredProcedure [dbo].[RateCount]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RateCount]
@AgentUsername varchar(50)

AS
BEGIN

SET NOCOUNT ON;
SELECT COUNT(*)
FROM RateAgent
WHERE AgentUsername= @AgentUsername

END 
GO
/****** Object:  StoredProcedure [dbo].[RateSum]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RateSum]
@AgentUsername varchar(50)

AS
BEGIN

SET NOCOUNT ON;
SELECT SUM (Rating)
FROM RateAgent
WHERE AgentUsername= @AgentUsername

END 
GO
/****** Object:  StoredProcedure [dbo].[RatingAgent]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[RatingAgent]
@CustomerUser varchar(50),@AgentUser varchar(50),@Rating decimal, @RatingDate Datetime
AS
BEGIN
Insert into RateAgent
Values (@CustomerUser, @AgentUser, @Rating, @RatingDate)
END
GO
/****** Object:  StoredProcedure [dbo].[RentBed]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RentBed]
@Housing# int,
@Room# int,
@Bed# int,
@RentalStartDate datetime,
@RentalEndDate datetime,
@RenterUsername varchar(50),
@RentalPrice int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[BedRent]
	values (@Housing#, @Room#, @Bed#,@RentalStartDate, @RentalEndDate, @RenterUsername, @RentalPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[RentHouse]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RentHouse]
@Housing# int,
@RentalStartDate datetime,
@RenterUsername varchar(50),
@RentalEndDate datetime,
@RentalPrice int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[HousingRent]
	values (@Housing# ,@RentalStartDate, @RenterUsername,@RentalEndDate,@RentalPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[RentRoom]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RentRoom]
@Housing# int,
@Room# int,
@RentalStartDate datetime,
@RentalEndDate datetime,
@RenterUsername varchar(50),
@RentalPrice int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[RoomRent]
	values (@Housing#, @Room#, @RentalStartDate, @RentalEndDate, @RenterUsername, @RentalPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[RoomAvailability]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RoomAvailability]
@Room# int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Room]
	SET Availability = 0 
	WHERE Room# = @Room#
END
GO
/****** Object:  StoredProcedure [dbo].[ViewBed]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewBed]
@AreaID int

AS
BEGIN

SET NOCOUNT ON;
SELECT *
FROM Housing, Room, Bed
WHERE  Room.Room# = Bed.Room# AND Housing.Housing# = Room.Housing# AND Housing.AreaID = @AreaID 


END
GO
/****** Object:  StoredProcedure [dbo].[ViewHouse]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ViewHouse]
@AreaID int
AS
BEGIN

SET NOCOUNT ON;
SELECT *
FROM Housing
WHERE AreaID = @AreaID And RentalType='house'

END
GO
/****** Object:  StoredProcedure [dbo].[ViewRoom]    Script Date: 5/7/2019 11:32:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewRoom]
@AreaID int

AS
BEGIN

SET NOCOUNT ON;
SELECT *
FROM  Housing,Room
WHERE Housing.Housing# = Room.Housing# AND Housing.AreaID = @AreaID 

END
GO
USE [master]
GO
ALTER DATABASE [REA] SET  READ_WRITE 
GO
