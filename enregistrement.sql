USE [master]
GO
/****** Object:  Database [ENREGISTREMENTS]    Script Date: 15/02/2014 17:44:00 ******/
CREATE DATABASE [ENREGISTREMENTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ENREGISTREMENTS', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ENREGISTREMENTS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ENREGISTREMENTS_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ENREGISTREMENTS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ENREGISTREMENTS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ENREGISTREMENTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ENREGISTREMENTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ENREGISTREMENTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ENREGISTREMENTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ENREGISTREMENTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ENREGISTREMENTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ENREGISTREMENTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ENREGISTREMENTS] SET  MULTI_USER 
GO
ALTER DATABASE [ENREGISTREMENTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ENREGISTREMENTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ENREGISTREMENTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ENREGISTREMENTS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ENREGISTREMENTS]
GO
/****** Object:  Schema [test]    Script Date: 15/02/2014 17:44:00 ******/
CREATE SCHEMA [test]
GO
/****** Object:  StoredProcedure [dbo].[enregistrerHotel]    Script Date: 15/02/2014 17:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Enregistre un hotel>
-- =============================================
CREATE PROCEDURE [dbo].[enregistrerHotel]
	@ID int,
	@NOMUSER varchar(50),
	@PRENOMUSER varchar(50),
	@ADRESSEUSER varchar(50),
	@CPUSER int,
	@VILLEUSER varchar(50),
	@PAYSUSER varchar(50),
	@COMPTEUSER varchar(50),
	@NOMHOTEL varchar(50),
	@ADRESSEHOTEL varchar(50),
	@CPHOTEL varchar(50),
	@VILLEHOTEL varchar(50),
	@PAYSHOTEL varchar(50),
	@DATEARRIVEEHOTEL date,
	@DUREESEJOUR int,
	@PRIXHOTEL int
AS
BEGIN
	INSERT INTO CMDHOTELS (id,nomUser,prenomUser,adresseUser,cpUser,villeUser,paysUser,compteUser,nomHotel,adresseHotel,cpHotel,villeHotel,paysHotel,dateArriveeHotel,dureeSejour,prixHotel)
	VALUES (@ID,@NOMUSER,@PRENOMUSER,@ADRESSEUSER,@CPUSER,@VILLEUSER,@PAYSUSER,@COMPTEUSER,@NOMHOTEL,@ADRESSEHOTEL,@CPHOTEL,@VILLEHOTEL,@PAYSHOTEL,@DATEARRIVEEHOTEL,@DUREESEJOUR,@PRIXHOTEL)
END

GO
/****** Object:  StoredProcedure [dbo].[enregistrerVol]    Script Date: 15/02/2014 17:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Carguebro>
-- Create date: <06/02/2014>
-- Description:	<Enregistre un vol>
-- =============================================
CREATE PROCEDURE [dbo].[enregistrerVol]
	@ID int,
	@NOMUSER varchar(50),
	@PRENOMUSER varchar(50),
	@ADRESSEUSER varchar(50),
	@CPUSER int,
	@VILLEUSER varchar(50),
	@PAYSUSER varchar(50),
	@COMPTEUSER varchar(50),
	@VILLEDEPARTVOL varchar(50),
	@PAYSDEPARTVOL varchar(50),
	@VILLEDESTINATIONVOL varchar(50),
	@PAYSDESTINATIONVOL varchar(50),
	@DATEDEPARTVOL date,
	@PRIXVOL int
AS
BEGIN
	INSERT INTO CMDVOLS (id,nomUser,prenomUser,adresseUser,cpUser,villeUser,paysUser,compteUser,villeDepartVol,paysDepartVol,villeDestinationVol,paysDestinationVol,dateDepartVol,prixVol)
	VALUES (@ID,@NOMUSER,@PRENOMUSER,@ADRESSEUSER,@CPUSER,@VILLEUSER,@PAYSUSER,@COMPTEUSER,@VILLEDEPARTVOL,@PAYSDEPARTVOL,@VILLEDESTINATIONVOL,@PAYSDESTINATIONVOL,@DATEDEPARTVOL,@PRIXVOL)
END

GO
/****** Object:  Table [dbo].[CMDHOTELS]    Script Date: 15/02/2014 17:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CMDHOTELS](
	[id] [numeric](18, 0) NOT NULL,
	[nomUser] [varchar](50) NULL,
	[prenomUser] [varchar](50) NULL,
	[adresseUser] [varchar](50) NULL,
	[cpUser] [int] NULL,
	[villeUser] [varchar](50) NULL,
	[paysUser] [varchar](50) NULL,
	[compteUser] [varchar](50) NULL,
	[nomHotel] [varchar](50) NULL,
	[adresseHotel] [varchar](50) NULL,
	[cpHotel] [int] NULL,
	[villeHotel] [varchar](50) NULL,
	[paysHotel] [varchar](50) NULL,
	[dateArriveeHotel] [date] NULL,
	[dureeSejour] [int] NULL,
	[prixHotel] [int] NULL,
 CONSTRAINT [PK_CMDHOTELS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CMDVOLS]    Script Date: 15/02/2014 17:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CMDVOLS](
	[id] [numeric](18, 0) NOT NULL,
	[nomUser] [varchar](50) NULL,
	[prenomUser] [varchar](50) NULL,
	[adresseUser] [varchar](50) NULL,
	[cpUser] [int] NULL,
	[villeUser] [varchar](50) NULL,
	[paysUser] [varchar](50) NULL,
	[compteUser] [varchar](50) NULL,
	[villeDepartVol] [varchar](50) NULL,
	[paysDepartVol] [varchar](50) NULL,
	[villeDestinationVol] [varchar](50) NULL,
	[paysDestinationVol] [varchar](50) NULL,
	[dateDepartVol] [date] NULL,
	[prixVol] [int] NULL,
 CONSTRAINT [PK_CMDVOLS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [ENREGISTREMENTS] SET  READ_WRITE 
GO
