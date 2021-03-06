USE [master]
GO
/****** Object:  Database [DeviceManagement]    Script Date: 11/11/2020 9:55:39 AM ******/
CREATE DATABASE [DeviceManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeviceManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DeviceManagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DeviceManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DeviceManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DeviceManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeviceManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeviceManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeviceManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeviceManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeviceManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeviceManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeviceManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeviceManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeviceManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeviceManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeviceManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeviceManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeviceManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeviceManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeviceManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeviceManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeviceManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeviceManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeviceManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeviceManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeviceManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeviceManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeviceManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeviceManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeviceManagement] SET  MULTI_USER 
GO
ALTER DATABASE [DeviceManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeviceManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeviceManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeviceManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DeviceManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DeviceManagement]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDevice]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDevice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](300) NULL,
	[categoryId] [int] NULL,
	[image] [image] NULL,
	[boughtDate] [date] NULL,
	[warrantyDate] [date] NULL,
	[roomId] [int] NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_tblDevice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRequest]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRequest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[requestDate] [date] NOT NULL,
	[requestDescription] [nvarchar](300) NULL,
	[startDate] [date] NULL,
	[finishDate] [date] NULL,
	[repairDescription] [nvarchar](300) NULL,
	[userId] [int] NOT NULL,
	[deviceId] [int] NOT NULL,
	[workerId] [int] NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_tblRequest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_tblRoom] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 11/11/2020 9:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[roleId] [int] NOT NULL,
	[roomId] [int] NULL,
	[statusId] [int] NOT NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblCategory]  WITH CHECK ADD  CONSTRAINT [FK_tblCategory_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([id])
GO
ALTER TABLE [dbo].[tblCategory] CHECK CONSTRAINT [FK_tblCategory_tblStatus]
GO
ALTER TABLE [dbo].[tblDevice]  WITH CHECK ADD  CONSTRAINT [FK_tblDevice_tblCategory] FOREIGN KEY([categoryId])
REFERENCES [dbo].[tblCategory] ([id])
GO
ALTER TABLE [dbo].[tblDevice] CHECK CONSTRAINT [FK_tblDevice_tblCategory]
GO
ALTER TABLE [dbo].[tblDevice]  WITH CHECK ADD  CONSTRAINT [FK_tblDevice_tblRoom] FOREIGN KEY([roomId])
REFERENCES [dbo].[tblRoom] ([id])
GO
ALTER TABLE [dbo].[tblDevice] CHECK CONSTRAINT [FK_tblDevice_tblRoom]
GO
ALTER TABLE [dbo].[tblDevice]  WITH CHECK ADD  CONSTRAINT [FK_tblDevice_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([id])
GO
ALTER TABLE [dbo].[tblDevice] CHECK CONSTRAINT [FK_tblDevice_tblStatus]
GO
ALTER TABLE [dbo].[tblRequest]  WITH CHECK ADD  CONSTRAINT [FK_tblRequest_tblDevice] FOREIGN KEY([deviceId])
REFERENCES [dbo].[tblDevice] ([id])
GO
ALTER TABLE [dbo].[tblRequest] CHECK CONSTRAINT [FK_tblRequest_tblDevice]
GO
ALTER TABLE [dbo].[tblRequest]  WITH CHECK ADD  CONSTRAINT [FK_tblRequest_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([id])
GO
ALTER TABLE [dbo].[tblRequest] CHECK CONSTRAINT [FK_tblRequest_tblStatus]
GO
ALTER TABLE [dbo].[tblRequest]  WITH CHECK ADD  CONSTRAINT [FK_tblRequest_tblUser] FOREIGN KEY([userId])
REFERENCES [dbo].[tblUser] ([id])
GO
ALTER TABLE [dbo].[tblRequest] CHECK CONSTRAINT [FK_tblRequest_tblUser]
GO
ALTER TABLE [dbo].[tblRequest]  WITH CHECK ADD  CONSTRAINT [FK_tblRequest_tblUser_Worker] FOREIGN KEY([workerId])
REFERENCES [dbo].[tblUser] ([id])
GO
ALTER TABLE [dbo].[tblRequest] CHECK CONSTRAINT [FK_tblRequest_tblUser_Worker]
GO
ALTER TABLE [dbo].[tblRoom]  WITH CHECK ADD  CONSTRAINT [FK_tblRoom_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([id])
GO
ALTER TABLE [dbo].[tblRoom] CHECK CONSTRAINT [FK_tblRoom_tblStatus]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblRole] FOREIGN KEY([roleId])
REFERENCES [dbo].[tblRole] ([id])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblRole]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblRoom] FOREIGN KEY([roomId])
REFERENCES [dbo].[tblRoom] ([id])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblRoom]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([id])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblStatus]
GO
USE [master]
GO
ALTER DATABASE [DeviceManagement] SET  READ_WRITE 
GO
/****** Insert:  default record in table User    Script Date: 11/11/2020 9:55:39 AM ******/
USE [DeviceManagement]
GO
INSERT [dbo].[tblUser] ([id], [username], [password], [roleId], [roomId], [statusId]) VALUES (1, N'admin', N'000000', 1, NULL, 1)


