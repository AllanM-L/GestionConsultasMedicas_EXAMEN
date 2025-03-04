USE [master]
GO
/****** Object:  Database [GestionConsultasMedicas]    Script Date: 07/02/2025 16:52:36 ******/
CREATE DATABASE [GestionConsultasMedicas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionConsultasMedicas', FILENAME = N'C:\SQLDatos\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionConsultasMedicas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionConsultasMedicas_log', FILENAME = N'C:\SQLDatos\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionConsultasMedicas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GestionConsultasMedicas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionConsultasMedicas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionConsultasMedicas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GestionConsultasMedicas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionConsultasMedicas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionConsultasMedicas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestionConsultasMedicas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionConsultasMedicas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionConsultasMedicas] SET  MULTI_USER 
GO
ALTER DATABASE [GestionConsultasMedicas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionConsultasMedicas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionConsultasMedicas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionConsultasMedicas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionConsultasMedicas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionConsultasMedicas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionConsultasMedicas] SET QUERY_STORE = ON
GO
ALTER DATABASE [GestionConsultasMedicas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GestionConsultasMedicas]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 07/02/2025 16:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Paciente] [int] NULL,
	[ID_Medico] [int] NULL,
	[Fecha] [datetime] NULL,
	[Diagnostico] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 07/02/2025 16:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Especialidad] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 07/02/2025 16:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Edad] [int] NULL,
	[Telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Consultas] ON 

INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (2, 1, 6, CAST(N'2025-08-21T13:49:47.000' AS DateTime), N'Fiebre')
INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (3, 1, 6, CAST(N'2025-04-21T14:27:28.000' AS DateTime), N'Fiebre')
INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (5, 1, 7, CAST(N'2024-09-27T15:31:36.000' AS DateTime), N'Depresion ')
INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (6, 1, 7, CAST(N'2025-02-28T15:39:27.000' AS DateTime), N'Higado Graso')
INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (8, 1, 7, CAST(N'2025-02-07T16:01:22.690' AS DateTime), N'Estres')
INSERT [dbo].[Consultas] ([ID], [ID_Paciente], [ID_Medico], [Fecha], [Diagnostico]) VALUES (10, 1, 6, CAST(N'2026-02-12T16:44:52.000' AS DateTime), N'Diarrea')
SET IDENTITY_INSERT [dbo].[Consultas] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicos] ON 

INSERT [dbo].[Medicos] ([ID], [Nombre], [Especialidad]) VALUES (6, N'Maria Andrea', N'Cirujano')
INSERT [dbo].[Medicos] ([ID], [Nombre], [Especialidad]) VALUES (7, N'Jose Carlos', N'Psicologo')
SET IDENTITY_INSERT [dbo].[Medicos] OFF
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([ID], [Nombre], [Edad], [Telefono]) VALUES (1, N'Allan Manzanillas', 19, N'0990647515')
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[Medicos] ([ID])
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[Pacientes] ([ID])
GO
USE [master]
GO
ALTER DATABASE [GestionConsultasMedicas] SET  READ_WRITE 
GO
