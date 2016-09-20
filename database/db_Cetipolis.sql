USE [master]
GO
/****** Object:  Database [db_Cetipolis]    Script Date: 09/19/2016 18:58:21 ******/
CREATE DATABASE [db_Cetipolis] ON  PRIMARY 
( NAME = N'db_Cetipolis', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\db_Cetipolis.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_Cetipolis_log', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\db_Cetipolis_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_Cetipolis] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Cetipolis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Cetipolis] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [db_Cetipolis] SET ANSI_NULLS OFF
GO
ALTER DATABASE [db_Cetipolis] SET ANSI_PADDING OFF
GO
ALTER DATABASE [db_Cetipolis] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [db_Cetipolis] SET ARITHABORT OFF
GO
ALTER DATABASE [db_Cetipolis] SET AUTO_CLOSE ON
GO
ALTER DATABASE [db_Cetipolis] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [db_Cetipolis] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [db_Cetipolis] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [db_Cetipolis] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [db_Cetipolis] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [db_Cetipolis] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [db_Cetipolis] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [db_Cetipolis] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [db_Cetipolis] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [db_Cetipolis] SET  ENABLE_BROKER
GO
ALTER DATABASE [db_Cetipolis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [db_Cetipolis] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [db_Cetipolis] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [db_Cetipolis] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [db_Cetipolis] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [db_Cetipolis] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [db_Cetipolis] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [db_Cetipolis] SET  READ_WRITE
GO
ALTER DATABASE [db_Cetipolis] SET RECOVERY SIMPLE
GO
ALTER DATABASE [db_Cetipolis] SET  MULTI_USER
GO
ALTER DATABASE [db_Cetipolis] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [db_Cetipolis] SET DB_CHAINING OFF
GO
USE [db_Cetipolis]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 09/19/2016 18:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] NULL,
	[name] [varchar](20) NULL,
	[lastName] [varchar](20) NULL,
	[username] [varchar](20) NULL,
	[password] [char](64) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Employees] ([id], [name], [lastName], [username], [password]) VALUES (1, N'José Miguel', N'Padilla Villalvazo', N'Miguel', N'df71d746e5dfc2e8d88acff6aa71f00db0ee91043710787e45e663a264ba6d33')
INSERT [dbo].[Employees] ([id], [name], [lastName], [username], [password]) VALUES (2, N'David', N'Berrospe Ramirez', N'David', N'1eecc37ba03d09d3e99f213639d508db012715221cdc32a0414f1330ddbf2315')
INSERT [dbo].[Employees] ([id], [name], [lastName], [username], [password]) VALUES (3, N'Bernardo', N'Valdovinos Uribe', N'Bernardo', N'50e426cd436a236813743a537aeb85449086dd58f77ca1501defd426379579fe')
INSERT [dbo].[Employees] ([id], [name], [lastName], [username], [password]) VALUES (4, N'Adrián Alejandro', N'Dávalos Sánchez', N'Adrian', N'2b9c15d844f5d2be0f37e575e06cba1035fa3c669f879e935a8349c84d990b2c')
INSERT [dbo].[Employees] ([id], [name], [lastName], [username], [password]) VALUES (5, N'Juan José', N'Carvajal Muñoz', N'Juan', N'c0facbdb74f720f3c31ca30edcf0ddd51a6bad71c693c8b9a4a73a94959bc482')
