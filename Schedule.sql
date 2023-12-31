USE [master]
GO
/****** Object:  Database [Schedule]    Script Date: 23.12.2023 1:56:37 ******/
CREATE DATABASE [Schedule]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Schedule', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.BARDAK\MSSQL\DATA\Schedule.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Schedule_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.BARDAK\MSSQL\DATA\Schedule_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Schedule] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Schedule].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Schedule] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Schedule] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Schedule] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Schedule] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Schedule] SET ARITHABORT OFF 
GO
ALTER DATABASE [Schedule] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Schedule] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Schedule] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Schedule] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Schedule] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Schedule] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Schedule] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Schedule] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Schedule] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Schedule] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Schedule] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Schedule] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Schedule] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Schedule] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Schedule] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Schedule] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Schedule] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Schedule] SET RECOVERY FULL 
GO
ALTER DATABASE [Schedule] SET  MULTI_USER 
GO
ALTER DATABASE [Schedule] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Schedule] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Schedule] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Schedule] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Schedule] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Schedule] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Schedule', N'ON'
GO
ALTER DATABASE [Schedule] SET QUERY_STORE = ON
GO
ALTER DATABASE [Schedule] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Schedule]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 23.12.2023 1:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[DataId] [int] IDENTITY(1,1) NOT NULL,
	[Product] [nvarchar](300) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[DataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 23.12.2023 1:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
	[DataD] [int] NOT NULL,
	[Number] [nvarchar](150) NULL,
	[UserD] [int] NOT NULL,
	[SatusD] [int] NOT NULL,
	[Comment] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 23.12.2023 1:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.12.2023 1:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](150) NULL,
	[Password] [nvarchar](150) NULL,
	[LocationPicture] [nvarchar](150) NULL,
	[Name] [nvarchar](150) NULL,
	[Root] [int] NULL,
	[DepartamentName] [nvarchar](150) NULL,
	[AdminName] [nvarchar](150) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([DataId], [Product]) VALUES (1, N'Тетрадь')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (2, N'Блокнот')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (3, N'Ручка')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (4, N'Точилка')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (5, N'Краска для принтера')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (6, N'Вода')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (7, N'Стерка')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (8, N'Компьютер')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (9, N'Стол')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (10, N'Стул')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (11, N'Монитор')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (12, N'Мышка')
INSERT [dbo].[Product] ([DataId], [Product]) VALUES (13, N'Клавиатура')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Request] ON 

INSERT [dbo].[Request] ([RequestId], [DataD], [Number], [UserD], [SatusD], [Comment]) VALUES (2, 2, N'23', 2, 2, N'wdqdwqd')
INSERT [dbo].[Request] ([RequestId], [DataD], [Number], [UserD], [SatusD], [Comment]) VALUES (3, 3, N'2', 3, 3, N'dwqdqdwqd')
INSERT [dbo].[Request] ([RequestId], [DataD], [Number], [UserD], [SatusD], [Comment]) VALUES (4, 4, N'5', 4, 1, N'qwdqdqw')
INSERT [dbo].[Request] ([RequestId], [DataD], [Number], [UserD], [SatusD], [Comment]) VALUES (6, 5, N'123', 1, 1, N'123')
SET IDENTITY_INSERT [dbo].[Request] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (1, N'На рассмотрении')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (2, N'Утвержден')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (3, N'Отказан')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (4, N'Переоформлен')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Login], [Password], [LocationPicture], [Name], [Root], [DepartamentName], [AdminName]) VALUES (1, N'admin', N'admin', N'C:\Users\user\Desktop\SchedulePlan\SchedulePlan\Image\admin1.png', N'Денис', 1, N'Менеджер', N'Виталий')
INSERT [dbo].[Users] ([UserId], [Login], [Password], [LocationPicture], [Name], [Root], [DepartamentName], [AdminName]) VALUES (2, N'admin1', N'admin1', N'C:\Users\user\Desktop\SchedulePlan\SchedulePlan\Image\admin2.png', N'Виталий', 1, N'Администратор', N'Виталий')
INSERT [dbo].[Users] ([UserId], [Login], [Password], [LocationPicture], [Name], [Root], [DepartamentName], [AdminName]) VALUES (3, N'admin2', N'admin3', N'C:\Users\user\Desktop\SchedulePlan\SchedulePlan\Image\admin3.png', N'Анастасия', 1, N'Менеджер', N'Виталий')
INSERT [dbo].[Users] ([UserId], [Login], [Password], [LocationPicture], [Name], [Root], [DepartamentName], [AdminName]) VALUES (4, N'admin4', N'admin4', N'C:\Users\user\Desktop\SchedulePlan\SchedulePlan\Image\admin4.png', N'Глеб', 3, N'Бухгалтерия', N'Глеб')
INSERT [dbo].[Users] ([UserId], [Login], [Password], [LocationPicture], [Name], [Root], [DepartamentName], [AdminName]) VALUES (5, N'123', N'123', NULL, N'123', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Product] FOREIGN KEY([DataD])
REFERENCES [dbo].[Product] ([DataId])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Product]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Status] FOREIGN KEY([SatusD])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Status]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Users] FOREIGN KEY([UserD])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Users]
GO
USE [master]
GO
ALTER DATABASE [Schedule] SET  READ_WRITE 
GO
