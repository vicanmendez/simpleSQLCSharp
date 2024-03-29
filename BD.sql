USE [master]
GO
/****** Object:  Database [turnos]    Script Date: 13/6/2019 12:43:42 ******/
CREATE DATABASE [turnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'turnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\turnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'turnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\turnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [turnos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [turnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [turnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [turnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [turnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [turnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [turnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [turnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [turnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [turnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [turnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [turnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [turnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [turnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [turnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [turnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [turnos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [turnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [turnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [turnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [turnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [turnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [turnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [turnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [turnos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [turnos] SET  MULTI_USER 
GO
ALTER DATABASE [turnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [turnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [turnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [turnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [turnos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [turnos] SET QUERY_STORE = OFF
GO
USE [turnos]
GO
/****** Object:  Table [dbo].[TURNO]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNO](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[tipoTurno] [varchar](50) NULL,
	[lugar] [varchar](100) NULL,
	[horafecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[verConsultasPorNombre]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verConsultasPorNombre] @nombre varchar(50), @tipo varchar(50)
AS
	select * FROM TURNO WHERE nombreCliente = @nombre AND tipoTurno=@tipo;
GO
/****** Object:  StoredProcedure [dbo].[verListaTurnos]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verListaTurnos] AS
SELECT * FROM TURNO
GO
/****** Object:  StoredProcedure [dbo].[verTurnosDeHoy]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verTurnosDeHoy] AS
--el método CONVERT(varchar(largo), DATETIME, formato) nos retorna la fecha en el formato pedido
--en este caso, consulta todos los turnos cuya "horafecha" es la fecha de hoy
--en este caso, "110" es "dd-mm-aaaa"
SELECT * FROM TURNO WHERE (convert(varchar(10),TURNO.horafecha, 110)) = (convert(varchar(10), getdate(), 110))
GO
/****** Object:  StoredProcedure [dbo].[verTurnosPorId]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verTurnosPorId] @id int
AS
SELECT * FROM TURNO WHERE idTurno=@id;
GO
/****** Object:  StoredProcedure [dbo].[verTurnosPorNombre]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verTurnosPorNombre] @nombre varchar(50)
AS
	select * FROM TURNO WHERE nombreCliente = @nombre;
GO
/****** Object:  StoredProcedure [dbo].[verTurnosPorTipo]    Script Date: 13/6/2019 12:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verTurnosPorTipo] @tipo varchar(50)
AS
	SELECT * FROM TURNO WHERE tipoTurno = @tipo ORDER BY horafecha DESC;
GO
USE [master]
GO
ALTER DATABASE [turnos] SET  READ_WRITE 
GO
