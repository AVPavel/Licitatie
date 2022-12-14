USE [master]
GO
/****** Object:  Database [Licitatie]    Script Date: 10/21/2022 9:48:58 PM ******/
CREATE DATABASE [Licitatie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Licitatie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Licitatie.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Licitatie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Licitatie_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Licitatie] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Licitatie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Licitatie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Licitatie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Licitatie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Licitatie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Licitatie] SET ARITHABORT OFF 
GO
ALTER DATABASE [Licitatie] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Licitatie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Licitatie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Licitatie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Licitatie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Licitatie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Licitatie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Licitatie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Licitatie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Licitatie] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Licitatie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Licitatie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Licitatie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Licitatie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Licitatie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Licitatie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Licitatie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Licitatie] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Licitatie] SET  MULTI_USER 
GO
ALTER DATABASE [Licitatie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Licitatie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Licitatie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Licitatie] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Licitatie] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Licitatie]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/21/2022 9:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[name] [varchar](20) NULL,
	[id] [int] NULL,
	[available] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/21/2022 9:48:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[username] [varchar](20) NULL,
	[PassW] [varchar](20) NULL,
	[administrator] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Licitatie] SET  READ_WRITE 
GO
