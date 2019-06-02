----USE [master]
----GO
----/****** Object:  Database [FarmaPopTec]    Script Date: 01/06/2019 23:00:50 ******/
----CREATE DATABASE [FarmaPopTec]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'FarmaPopTec', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FarmaPopTec.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'FarmaPopTec_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FarmaPopTec_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
--GO
--ALTER DATABASE [FarmaPopTec] SET COMPATIBILITY_LEVEL = 140
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [FarmaPopTec].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [FarmaPopTec] SET ANSI_NULL_DEFAULT OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET ANSI_NULLS OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET ANSI_PADDING OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET ANSI_WARNINGS OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET ARITHABORT OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET AUTO_CLOSE OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET AUTO_SHRINK OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET AUTO_UPDATE_STATISTICS ON 
--GO
--ALTER DATABASE [FarmaPopTec] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET CURSOR_DEFAULT  GLOBAL 
--GO
--ALTER DATABASE [FarmaPopTec] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET NUMERIC_ROUNDABORT OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET QUOTED_IDENTIFIER OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET RECURSIVE_TRIGGERS OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET  DISABLE_BROKER 
--GO
--ALTER DATABASE [FarmaPopTec] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET TRUSTWORTHY OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET PARAMETERIZATION SIMPLE 
--GO
--ALTER DATABASE [FarmaPopTec] SET READ_COMMITTED_SNAPSHOT OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET HONOR_BROKER_PRIORITY OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET RECOVERY FULL 
--GO
--ALTER DATABASE [FarmaPopTec] SET  MULTI_USER 
--GO
--ALTER DATABASE [FarmaPopTec] SET PAGE_VERIFY CHECKSUM  
--GO
--ALTER DATABASE [FarmaPopTec] SET DB_CHAINING OFF 
--GO
--ALTER DATABASE [FarmaPopTec] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO
--ALTER DATABASE [FarmaPopTec] SET TARGET_RECOVERY_TIME = 60 SECONDS 
--GO
--ALTER DATABASE [FarmaPopTec] SET DELAYED_DURABILITY = DISABLED 
--GO
--EXEC sys.sp_db_vardecimal_storage_format N'FarmaPopTec', N'ON'
--GO
--ALTER DATABASE [FarmaPopTec] SET QUERY_STORE = OFF
--GO
--USE [FarmaPopTec]
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
--GO
--ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
--GO
--ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
--GO
--USE [FarmaPopTec]
--GO
--/****** Object:  User [FarmaPopTec]    Script Date: 01/06/2019 23:00:50 ******/
--CREATE USER [FarmaPopTec] FOR LOGIN [FarmaPopTec] WITH DEFAULT_SCHEMA=[dbo]
--GO
--ALTER ROLE [db_datareader] ADD MEMBER [FarmaPopTec]
--GO
--ALTER ROLE [db_datawriter] ADD MEMBER [FarmaPopTec]
--GO
--ALTER ROLE [db_denydatawriter] ADD MEMBER [FarmaPopTec]
--GO
--/****** Object:  Table [dbo].[Cliente]    Script Date: 01/06/2019 23:00:51 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Cliente](
--	[cpfCliente] [varchar](11) NOT NULL,
--	[nomeCliente] [varchar](50) NOT NULL,
--	[emailCliente] [varchar](50) NULL,
--	[telCliente] [varchar](14) NULL,
-- CONSTRAINT [PK__Cliente__9DA3A5B8AC1D299E] PRIMARY KEY CLUSTERED 
--(
--	[cpfCliente] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Compra]    Script Date: 01/06/2019 23:00:51 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Compra](
--	[numCompra] [int] IDENTITY(1000,1) NOT NULL,
--	[dataCompra] [datetime] NOT NULL,
--	[codFuncionario] [int] NOT NULL,
--	[cnpj] [varchar](14) NOT NULL,
--PRIMARY KEY CLUSTERED 
--(
--	[numCompra] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Compra_Produto]    Script Date: 01/06/2019 23:00:51 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Compra_Produto](
--	[qtdCompra] [int] NOT NULL,
--	[valorTotal] [float] NOT NULL,
--	[validade] [date] NOT NULL,
--	[statusProduto]  AS (datediff(day,[validade],getdate())),
--	[codProduto] [int] NOT NULL,
--	[numCompra] [int] NOT NULL
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Fornecedor]    Script Date: 01/06/2019 23:00:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Fornecedor](
--	[cnpj] [varchar](14) NOT NULL,
--	[nomeFornecedor] [varchar](50) NOT NULL,
--PRIMARY KEY CLUSTERED 
--(
--	[cnpj] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Funcionario]    Script Date: 01/06/2019 23:00:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Funcionario](
--	[codFuncionario] [int] IDENTITY(1000,1) NOT NULL,
--	[cpfFuncionario] [varchar](11) NOT NULL,
--	[senhaUsuario] [varchar](6) NOT NULL,
--	[funcaoFuncionario] [varchar](20) NOT NULL,
--	[nomeFuncionario] [varchar](50) NOT NULL,
-- CONSTRAINT [PK__Funciona__D72C6D17F84FBF0C] PRIMARY KEY CLUSTERED 
--(
--	[codFuncionario] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Produto]    Script Date: 01/06/2019 23:00:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Produto](
--	[codProduto] [int] IDENTITY(1000,1) NOT NULL,
--	[saldoProduto] [int] NOT NULL,
--	[dataFabricacao] [date] NOT NULL,
--	[nomeProduto] [varchar](50) NOT NULL,
--	[precoProduto] [float] NOT NULL,
--	[statusProduto] [int] NULL,
-- CONSTRAINT [PK__Produto__E7B140B655F7CD31] PRIMARY KEY CLUSTERED 
--(
--	[codProduto] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Venda]    Script Date: 01/06/2019 23:00:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Venda](
--	[numVenda] [int] IDENTITY(1000,1) NOT NULL,
--	[dataVenda] [datetime] NOT NULL,
--	[cpfCliente] [varchar](11) NULL,
--	[codFuncionario] [int] NOT NULL,
--PRIMARY KEY CLUSTERED 
--(
--	[numVenda] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--/****** Object:  Table [dbo].[Venda_Produto]    Script Date: 01/06/2019 23:00:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Venda_Produto](
--	[qtd] [int] NOT NULL,
--	[preco] [float] NOT NULL,
--	[codProduto] [int] NOT NULL,
--	[numVenda] [int] NOT NULL
--) ON [PRIMARY]
--GO
--ALTER TABLE [dbo].[Produto] ADD  CONSTRAINT [DF__Produto__statusP__160F4887]  DEFAULT ('1') FOR [statusProduto]
--GO
--ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([cnpj])
--REFERENCES [dbo].[Fornecedor] ([cnpj])
--GO
--ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK__Compra__codFunci__52593CB8] FOREIGN KEY([codFuncionario])
--REFERENCES [dbo].[Funcionario] ([codFuncionario])
--GO
--ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK__Compra__codFunci__52593CB8]
--GO
--ALTER TABLE [dbo].[Compra_Produto]  WITH CHECK ADD  CONSTRAINT [FK__Compra_Pr__codPr__59FA5E80] FOREIGN KEY([codProduto])
--REFERENCES [dbo].[Produto] ([codProduto])
--GO
--ALTER TABLE [dbo].[Compra_Produto] CHECK CONSTRAINT [FK__Compra_Pr__codPr__59FA5E80]
--GO
--ALTER TABLE [dbo].[Compra_Produto]  WITH CHECK ADD FOREIGN KEY([numCompra])
--REFERENCES [dbo].[Compra] ([numCompra])
--GO
--ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__codFuncio__5BE2A6F2] FOREIGN KEY([codFuncionario])
--REFERENCES [dbo].[Funcionario] ([codFuncionario])
--GO
--ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__codFuncio__5BE2A6F2]
--GO
--ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__cpfClient__4BAC3F29] FOREIGN KEY([cpfCliente])
--REFERENCES [dbo].[Cliente] ([cpfCliente])
--GO
--ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__cpfClient__4BAC3F29]
--GO
--ALTER TABLE [dbo].[Venda_Produto]  WITH CHECK ADD  CONSTRAINT [FK__Venda_Pro__codPr__571DF1D5] FOREIGN KEY([codProduto])
--REFERENCES [dbo].[Produto] ([codProduto])
--GO
--ALTER TABLE [dbo].[Venda_Produto] CHECK CONSTRAINT [FK__Venda_Pro__codPr__571DF1D5]
--GO
--ALTER TABLE [dbo].[Venda_Produto]  WITH CHECK ADD FOREIGN KEY([numVenda])
--REFERENCES [dbo].[Venda] ([numVenda])
--GO
--USE [master]
--GO
--ALTER DATABASE [FarmaPopTec] SET  READ_WRITE 
--GO
----use farmapoptec
--select * from Funcionario

INSERT INTO Funcionario
      (cpfFuncionario,senhaUsuario,funcaoFuncionario,nomeFuncionario)
values
      ('70478642458','123456','Gerente','Matheus Soeldner')