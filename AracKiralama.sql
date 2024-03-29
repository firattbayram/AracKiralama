USE [master]
GO
/****** Object:  Database [AracKiralama]    Script Date: 30.05.2021 19:24:10 ******/
CREATE DATABASE [AracKiralama]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AracKiralama', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AracKiralama.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AracKiralama_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AracKiralama_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AracKiralama] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AracKiralama].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AracKiralama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AracKiralama] SET ARITHABORT OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AracKiralama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AracKiralama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AracKiralama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AracKiralama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AracKiralama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AracKiralama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AracKiralama] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AracKiralama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AracKiralama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AracKiralama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AracKiralama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AracKiralama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AracKiralama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AracKiralama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AracKiralama] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AracKiralama] SET  MULTI_USER 
GO
ALTER DATABASE [AracKiralama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AracKiralama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AracKiralama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AracKiralama] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AracKiralama] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AracKiralama] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AracKiralama] SET QUERY_STORE = OFF
GO
USE [AracKiralama]
GO
/****** Object:  Table [dbo].[AracBilgiler]    Script Date: 30.05.2021 19:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracBilgiler](
	[AracPlaka] [nvarchar](50) NOT NULL,
	[AracMarka] [nvarchar](50) NOT NULL,
	[AracModel] [nvarchar](50) NOT NULL,
	[AracModelYil] [nvarchar](50) NOT NULL,
	[AracRenk] [nvarchar](50) NOT NULL,
	[AracKm] [nvarchar](50) NOT NULL,
	[AracYakit] [nvarchar](50) NOT NULL,
	[AracKiraFiyat] [int] NOT NULL,
	[AracResim] [nvarchar](500) NULL,
	[AracTarih] [nvarchar](50) NOT NULL,
	[AracDurumu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AracBilgiler] PRIMARY KEY CLUSTERED 
(
	[AracPlaka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AracSozlesme]    Script Date: 30.05.2021 19:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracSozlesme](
	[AracPlaka] [nvarchar](50) NOT NULL,
	[MusteriTc] [char](11) NOT NULL,
	[AracKiraSuresi] [nvarchar](50) NOT NULL,
	[AracKiraFiyat] [nvarchar](50) NOT NULL,
	[AracVerisTarihi] [nvarchar](500) NOT NULL,
	[TeslimDurumu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriUyelik]    Script Date: 30.05.2021 19:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriUyelik](
	[MusteriTc] [char](11) NOT NULL,
	[MusteriAdSoyad] [nvarchar](75) NOT NULL,
	[MusterıSifre] [nvarchar](20) NOT NULL,
	[MusteriCepTel] [char](11) NOT NULL,
	[MusteriMail] [nvarchar](40) NOT NULL,
	[MusteriEhliyet] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_MusteriUyelik] PRIMARY KEY CLUSTERED 
(
	[MusteriTc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YetkiliBilgiler]    Script Date: 30.05.2021 19:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YetkiliBilgiler](
	[YetkiliKullaniciAdi] [nvarchar](50) NULL,
	[YetkiliSifre] [nvarchar](50) NULL,
	[YetkiliTcKimlik] [char](11) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AracBilgiler] ([AracPlaka], [AracMarka], [AracModel], [AracModelYil], [AracRenk], [AracKm], [AracYakit], [AracKiraFiyat], [AracResim], [AracTarih], [AracDurumu]) VALUES (N'34AJ8745', N'Renault', N'Megane', N'2020', N'BEYAZ', N'5400', N'Dizel', 190, N'C:\Users\Toshiba\Desktop\Araç Listesi\megane.png', N'4.05.2021 12:18:23', N'BOŞ')
INSERT [dbo].[AracBilgiler] ([AracPlaka], [AracMarka], [AracModel], [AracModelYil], [AracRenk], [AracKm], [AracYakit], [AracKiraFiyat], [AracResim], [AracTarih], [AracDurumu]) VALUES (N'34AP5847', N'Opel', N'Astra', N'2019', N'BEYAZ', N'4580', N'Benzin', 185, N'C:\Users\Toshiba\Desktop\Araç Listesi\astra.png', N'4.05.2021 13:19:12', N'BOŞ')
INSERT [dbo].[AracBilgiler] ([AracPlaka], [AracMarka], [AracModel], [AracModelYil], [AracRenk], [AracKm], [AracYakit], [AracKiraFiyat], [AracResim], [AracTarih], [AracDurumu]) VALUES (N'34CPL152', N'Renault', N'Clio', N'2019', N'BEYAZ', N'5845', N'Dizel', 145, N'C:\Users\Toshiba\Desktop\Araç Listesi\clio.png', N'4.05.2021 12:18:59', N'BOŞ')
INSERT [dbo].[AracBilgiler] ([AracPlaka], [AracMarka], [AracModel], [AracModelYil], [AracRenk], [AracKm], [AracYakit], [AracKiraFiyat], [AracResim], [AracTarih], [AracDurumu]) VALUES (N'34KA7718', N'Fiat', N'Egea', N'2019', N'BEYAZ', N'5800', N'Dizel', 200, N'C:\Users\Toshiba\Desktop\Araç Listesi\egea.png', N'4.05.2021 12:15:44', N'BOŞ')
INSERT [dbo].[AracBilgiler] ([AracPlaka], [AracMarka], [AracModel], [AracModelYil], [AracRenk], [AracKm], [AracYakit], [AracKiraFiyat], [AracResim], [AracTarih], [AracDurumu]) VALUES (N'34PA4417', N'Renault', N'Clio', N'2018', N'TURUNCU', N'5000', N'Dizel', 150, N'C:\Users\Toshiba\Desktop\Araç Listesi\clioturuncu.png', N'4.05.2021 12:08:22', N'BOŞ')
GO
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'11031151272', N'Erva Bayram', N'1', N'05531640327', N'iboooouas@gmail.com', N'B1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'13123132141', N'Ayşe Koçovalı', N'9785', N'05455123123', N'cukur@hotmail.com', N'A2')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'15454674897', N'Hakan Arslan', N'2', N'04545645454', N'deneme@gmail.com', N'A1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'27827878278', N'Beyza Nur Atila', N'654454545', N'05847894564', N'beyzacik@gmail.com', N'F')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'32114564457', N'Cem Beyaz', N'25798', N'05458895131', N'cemcem@hotmail.com', N'D1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'43825443126', N'Fırat Bayram', N'1', N'05438482066', N'firatbayram19y@gmail.com', N'B1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'44444444444', N'Hamdi Pınar', N'6', N'05487897987', N'selam@hotmail.com', N'A1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'45678678678', N'Adem Büyük', N'adem123', N'05482645216', N'adem@gmail.com', N'M')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'54565479878', N'Fatma Gözcü', N'164', N'05497897878', N'fatma@gmail.com', N'M1')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'66666666666', N'Cemre Özsoy', N'50', N'05657489878', N'cemrecikben@gmail.com', N'B')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'78797465498', N'Sıdkı Tülen', N'3', N'05685465449', N'denemecanim@gmail.com', N'BE')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'78978713144', N'Sergen Yalçın', N'1903', N'05487845679', N'sergen@gmail.com', N'B2')
INSERT [dbo].[MusteriUyelik] ([MusteriTc], [MusteriAdSoyad], [MusterıSifre], [MusteriCepTel], [MusteriMail], [MusteriEhliyet]) VALUES (N'78978787877', N'Şirin Yangın', N'69784', N'05785878841', N'sirin@gmail.com', N'D1')
GO
INSERT [dbo].[YetkiliBilgiler] ([YetkiliKullaniciAdi], [YetkiliSifre], [YetkiliTcKimlik]) VALUES (N'admin', N'1', N'12345678910')
GO
ALTER TABLE [dbo].[AracSozlesme]  WITH CHECK ADD  CONSTRAINT [FK_AracSozlesme_AracBilgiler] FOREIGN KEY([AracPlaka])
REFERENCES [dbo].[AracBilgiler] ([AracPlaka])
GO
ALTER TABLE [dbo].[AracSozlesme] CHECK CONSTRAINT [FK_AracSozlesme_AracBilgiler]
GO
ALTER TABLE [dbo].[AracSozlesme]  WITH CHECK ADD  CONSTRAINT [FK_AracSozlesme_MusteriUyelik] FOREIGN KEY([MusteriTc])
REFERENCES [dbo].[MusteriUyelik] ([MusteriTc])
GO
ALTER TABLE [dbo].[AracSozlesme] CHECK CONSTRAINT [FK_AracSozlesme_MusteriUyelik]
GO
USE [master]
GO
ALTER DATABASE [AracKiralama] SET  READ_WRITE 
GO
