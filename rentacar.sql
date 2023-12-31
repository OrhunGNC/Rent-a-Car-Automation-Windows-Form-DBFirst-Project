USE [master]
GO
/****** Object:  Database [RentaCar]    Script Date: 16.08.2023 21:54:09 ******/
CREATE DATABASE [RentaCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentaCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RentaCar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentaCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RentaCar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RentaCar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentaCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentaCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentaCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentaCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentaCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentaCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentaCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentaCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentaCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentaCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentaCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentaCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentaCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentaCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentaCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentaCar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentaCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentaCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentaCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentaCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentaCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentaCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentaCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentaCar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentaCar] SET  MULTI_USER 
GO
ALTER DATABASE [RentaCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentaCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentaCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentaCar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentaCar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentaCar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RentaCar] SET QUERY_STORE = ON
GO
ALTER DATABASE [RentaCar] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RentaCar]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 16.08.2023 21:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[branchID] [int] IDENTITY(1,1) NOT NULL,
	[branchName] [varchar](50) NULL,
	[branchEmployeeCount] [int] NULL,
	[branchSalary] [money] NULL,
	[carStock] [int] NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[branchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 16.08.2023 21:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerNameSurname] [varchar](50) NULL,
	[customerPhone] [varchar](11) NULL,
	[customerAge] [int] NULL,
	[customerBudget] [money] NULL,
	[customerDownPayment] [money] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 16.08.2023 21:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[personelID] [int] IDENTITY(1,1) NOT NULL,
	[personelNameSurname] [varchar](50) NULL,
	[personelPhone] [varchar](11) NULL,
	[personelTitle] [varchar](50) NULL,
	[personelMail] [varchar](50) NULL,
	[personelWage] [money] NULL,
	[branchID] [int] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[personelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 16.08.2023 21:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[vehicleID] [int] IDENTITY(1,1) NOT NULL,
	[vehiclePrice] [money] NULL,
	[vehicleNumberPlate] [int] NULL,
	[vehicleBrand] [varchar](50) NULL,
	[vehicleModel] [varchar](50) NULL,
	[vehicleYear] [varchar](50) NULL,
	[vehicleMotor] [varchar](50) NULL,
	[vehiclePackage] [varchar](50) NULL,
	[vehicleColor] [varchar](50) NULL,
	[vehicleGear] [varchar](50) NULL,
	[customerID] [int] NULL,
	[branchID] [int] NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[vehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Branch] ON 

INSERT [dbo].[Branch] ([branchID], [branchName], [branchEmployeeCount], [branchSalary], [carStock]) VALUES (1, N'Atasehir', 30, 2500000.0000, 30)
INSERT [dbo].[Branch] ([branchID], [branchName], [branchEmployeeCount], [branchSalary], [carStock]) VALUES (2, N'Besiktas', 25, 1500000.0000, 25)
INSERT [dbo].[Branch] ([branchID], [branchName], [branchEmployeeCount], [branchSalary], [carStock]) VALUES (3, N'Kurtköy', 20, 1500000.0000, 25)
SET IDENTITY_INSERT [dbo].[Branch] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([customerID], [customerNameSurname], [customerPhone], [customerAge], [customerBudget], [customerDownPayment]) VALUES (1, N'orhun', N'0555', 22, 25000.0000, 2500.0000)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([personelID], [personelNameSurname], [personelPhone], [personelTitle], [personelMail], [personelWage], [branchID]) VALUES (1, N'orhun gença', N'0555', N'CEO', N'orhun@gmail.com', 125000.0000, 1)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Branch] FOREIGN KEY([branchID])
REFERENCES [dbo].[Branch] ([branchID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Branch]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Branch] FOREIGN KEY([branchID])
REFERENCES [dbo].[Branch] ([branchID])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Branch]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Customers] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customers] ([customerID])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Customers]
GO
USE [master]
GO
ALTER DATABASE [RentaCar] SET  READ_WRITE 
GO
