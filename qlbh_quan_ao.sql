USE [master]
GO

/****** Object:  Database [QLBH_QA]    Script Date: 08/05/2024 9:13:51 PM ******/
CREATE DATABASE [QLBH_QA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_QA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\QLBH_QA.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_QA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\QLBH_QA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_QA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLBH_QA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLBH_QA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLBH_QA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLBH_QA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLBH_QA] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLBH_QA] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLBH_QA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLBH_QA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLBH_QA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLBH_QA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLBH_QA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLBH_QA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLBH_QA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLBH_QA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLBH_QA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QLBH_QA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLBH_QA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLBH_QA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLBH_QA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLBH_QA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLBH_QA] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLBH_QA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLBH_QA] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QLBH_QA] SET  MULTI_USER 
GO

ALTER DATABASE [QLBH_QA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLBH_QA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLBH_QA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLBH_QA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLBH_QA] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLBH_QA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [QLBH_QA] SET QUERY_STORE = ON
GO

ALTER DATABASE [QLBH_QA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [QLBH_QA] SET  READ_WRITE 
GO

