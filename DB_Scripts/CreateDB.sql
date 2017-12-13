USE [master]
GO

/****** Object:  Database [Maa]    Script Date: 12/13/2017 8:27:51 PM ******/
CREATE DATABASE [Maa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'maa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\maa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'maa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\maa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Maa] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Maa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Maa] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Maa] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Maa] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Maa] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Maa] SET ARITHABORT OFF 
GO

ALTER DATABASE [Maa] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Maa] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Maa] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Maa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Maa] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Maa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Maa] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Maa] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Maa] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Maa] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Maa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Maa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Maa] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Maa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Maa] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Maa] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Maa] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Maa] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Maa] SET  MULTI_USER 
GO

ALTER DATABASE [Maa] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Maa] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Maa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Maa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Maa] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Maa] SET QUERY_STORE = OFF
GO

USE [Maa]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Maa] SET  READ_WRITE 
GO

