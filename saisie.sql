USE [master]
GO
/****** Object:  Database [SAISIE]    Script Date: 10/02/2014 17:44:03 ******/
CREATE DATABASE [SAISIE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VOLS', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\VOLS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VOLS_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\VOLS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SAISIE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAISIE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAISIE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SAISIE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SAISIE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SAISIE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SAISIE] SET ARITHABORT OFF 
GO
ALTER DATABASE [SAISIE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SAISIE] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SAISIE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SAISIE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SAISIE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SAISIE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SAISIE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SAISIE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SAISIE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SAISIE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SAISIE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SAISIE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SAISIE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SAISIE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SAISIE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SAISIE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SAISIE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SAISIE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SAISIE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SAISIE] SET  MULTI_USER 
GO
ALTER DATABASE [SAISIE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SAISIE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SAISIE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SAISIE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SAISIE]
GO
/****** Object:  User [test]    Script Date: 10/02/2014 17:44:03 ******/
CREATE USER [test] FOR LOGIN [benjamin] WITH DEFAULT_SCHEMA=[test]
GO
/****** Object:  Schema [test]    Script Date: 10/02/2014 17:44:03 ******/
CREATE SCHEMA [test]
GO
/****** Object:  StoredProcedure [dbo].[dureeHotel]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[listeDateVol]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Retourne la liste des vols>
-- =============================================
CREATE PROCEDURE [dbo].[listeDateVol]
	@DEPART varchar(50),
	@ARRIVEE varchar(50)
AS
BEGIN
	SELECT VOLS.dateDepartVol FROM VOLS WHERE VOLS.villeDepartVol = @DEPART AND VOLS.villeDestinationVol = @ARRIVEE
END

GO
/****** Object:  StoredProcedure [dbo].[listeHotel]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Retourne la liste des hotels à partir de la destination d'un vol>
-- =============================================
CREATE PROCEDURE [dbo].[listeHotel]
	@ARRIVEE varchar(50),
	@DUREE int,
	@DATE date
AS
BEGIN
	SELECT HOTELS.nomHotel, HOTELS.adresseHotel, HOTELS.cpHotel, HOTELS.villeHotel, HOTELS.paysHotel, HOTELS.prixHotel, HOTELS.etoileHotel, HOTELS.dateArriveeHotel FROM HOTELS WHERE HOTELS.villeHotel = @ARRIVEE 
	AND dureeSejour = @DUREE
	AND dateArriveeHotel = @DATE
END

GO
/****** Object:  StoredProcedure [dbo].[listeVilleArrivee]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Retourne la liste des villes de depart possible.
-- =============================================
CREATE PROCEDURE [dbo].[listeVilleArrivee]
	@DEPART varchar(50)
AS
BEGIN
	SELECT VOLS.villeDestinationVol FROM VOLS WHERE VOLS.villeDepartVol = @DEPART
END
GO
/****** Object:  StoredProcedure [dbo].[listeVilleDepart]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Retourne la liste des villes de depart possible.
-- =============================================
CREATE PROCEDURE [dbo].[listeVilleDepart]
AS
BEGIN
	SELECT VOLS.villeDepartVol FROM VOLS
END
GO
/****** Object:  StoredProcedure [dbo].[listeVol]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Retourne la liste des vols>
-- =============================================
CREATE PROCEDURE [dbo].[listeVol]
	@DEPART varchar(50),
	@ARRIVEE varchar(50),
	@DATE date
AS
BEGIN
	SELECT VOLS.villeDepartVol, VOLS.paysDepartVol, VOLS.villeDestinationVol, VOLS.paysDestinationVol, VOLS.dateDepartVol, VOLS.prixVol
	FROM VOLS 
	WHERE VOLS.villeDepartVol= @DEPART 
	AND VOLS.villeDestinationVol = @ARRIVEE 
	AND VOLS.dateDepartVol= @DATE
END

GO
/****** Object:  Table [dbo].[HOTELS]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOTELS](
	[id] [numeric](18, 0) NOT NULL,
	[nomHotel] [varchar](50) NULL,
	[adresseHotel] [varchar](50) NULL,
	[cpHotel] [int] NULL,
	[villeHotel] [varchar](50) NULL,
	[paysHotel] [varchar](50) NULL,
	[dateArriveeHotel] [datetime] NULL,
	[dureeSejour] [int] NULL,
	[prixHotel] [int] NULL,
	[etoileHotel] [int] NULL,
 CONSTRAINT [PK_HOTELS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VOLS]    Script Date: 10/02/2014 17:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VOLS](
	[id] [numeric](18, 0) NOT NULL,
	[villeDepartVol] [varchar](50) NULL,
	[paysDepartVol] [varchar](50) NULL,
	[villeDestinationVol] [varchar](50) NULL,
	[paysDestinationVol] [varchar](50) NULL,
	[dateDepartVol] [datetime] NULL,
	[prixVol] [int] NULL,
 CONSTRAINT [PK_VOLS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [SAISIE] SET  READ_WRITE 
GO
