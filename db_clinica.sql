USE [master]
GO
/****** Object:  Database [db_clinica]    Script Date: 30/08/2023 19:57:21 ******/
CREATE DATABASE [db_clinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_clinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_clinica.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_clinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_clinica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_clinica] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_clinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_clinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_clinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_clinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_clinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_clinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_clinica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_clinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_clinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_clinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_clinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_clinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_clinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_clinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_clinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_clinica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_clinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_clinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_clinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_clinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_clinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_clinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_clinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_clinica] SET RECOVERY FULL 
GO
ALTER DATABASE [db_clinica] SET  MULTI_USER 
GO
ALTER DATABASE [db_clinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_clinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_clinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_clinica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_clinica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_clinica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_clinica', N'ON'
GO
ALTER DATABASE [db_clinica] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_clinica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_clinica]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[animal]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](54) NOT NULL,
	[observacoes] [text] NULL,
	[id_especie] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[cor] [varchar](50) NULL,
	[numero_identificacao] [varchar](50) NULL,
	[data_nascimento] [date] NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cargo]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [text] NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](54) NOT NULL,
	[id_endereco] [int] NOT NULL,
	[cpf] [varchar](11) NOT NULL,
	[status] [bit] NOT NULL,
	[telefone] [varchar](15) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[rg] [varchar](15) NULL,
	[dataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataCompra] [datetime] NOT NULL,
	[IdFornecedor] [int] NOT NULL,
	[IdProduto] [int] NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[Cancelada] [bit] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_dbo.compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NOT NULL,
	[observacoes] [text] NULL,
	[id_animal] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_funcionario] [int] NOT NULL,
	[id_venda] [int] NULL,
	[status] [bit] NOT NULL,
	[id_servico] [int] NULL,
	[servico_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[endereco]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[endereco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[endereco] [varchar](100) NOT NULL,
	[estado] [varchar](30) NOT NULL,
	[cidade] [varchar](30) NOT NULL,
	[cep] [varchar](8) NOT NULL,
	[referencia] [text] NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[especie]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[especie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exame]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exame](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[resultado] [text] NULL,
	[id_consulta] [int] NOT NULL,
	[cancelado] [bit] NOT NULL,
	[data] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formas_pagamento]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formas_pagamento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](54) NOT NULL,
	[descricao] [text] NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[CNPJ] [nvarchar](14) NOT NULL,
	[Endereco] [nvarchar](100) NULL,
	[Telefone] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[dataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.fornecedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedors]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[CNPJ] [varchar](15) NULL,
	[Telefone] [varchar](15) NULL,
	[Endereco] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cargo] [int] NOT NULL,
	[nome] [varchar](54) NOT NULL,
	[salario] [decimal](10, 2) NOT NULL,
	[email] [varchar](64) NOT NULL,
	[login] [varchar](54) NOT NULL,
	[senha] [varchar](54) NOT NULL,
	[data_criacao] [date] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FuncionarioPermissaos]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuncionarioPermissaos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PodeAcessarCliente] [bit] NOT NULL,
	[PodeAcessarClinica] [bit] NOT NULL,
	[PodeAcessarFornecedores] [bit] NOT NULL,
	[PodeAcessarProdutos] [bit] NOT NULL,
	[PodeAcessarRelatorios] [bit] NOT NULL,
	[PodeAcessarFuncionarios] [bit] NOT NULL,
	[FuncionarioId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.FuncionarioPermissaos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_venda]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_venda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantidade] [int] NOT NULL,
	[valor_unitario] [decimal](10, 2) NOT NULL,
	[id_produto] [int] NOT NULL,
	[id_venda] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicacao]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicacao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[dosagem] [varchar](100) NOT NULL,
	[id_consulta] [int] NOT NULL,
	[lote] [varchar](54) NOT NULL,
	[validade] [date] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagamentos]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[valor] [decimal](10, 2) NOT NULL,
	[data_pagamento] [date] NOT NULL,
	[id_forma_pagamento] [int] NOT NULL,
	[parcelado] [bit] NOT NULL,
	[numero_parcelas] [int] NULL,
	[data_vencimento] [date] NULL,
	[id_venda] [int] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagamentos_parcelados]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagamentos_parcelados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero_parcelas] [int] NULL,
	[valor_parcela] [decimal](10, 2) NULL,
	[data_vencimento] [date] NULL,
	[id_pagamento] [int] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[preco] [decimal](10, 2) NOT NULL,
	[preco_custo] [decimal](10, 2) NOT NULL,
	[quantidade] [int] NOT NULL,
	[codigo] [varchar](255) NULL,
	[status] [bit] NOT NULL,
	[fornecedorId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicos]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](255) NULL,
	[Valor] [decimal](10, 2) NULL,
	[TipoProfissionalID] [int] NULL,
	[MedidaReferencia] [nvarchar](50) NULL,
	[FuncionarioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposProfissionais]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposProfissionais](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 30/08/2023 19:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data_venda] [datetime] NOT NULL,
	[valor_total] [decimal](10, 2) NOT NULL,
	[id_funcionario] [int] NOT NULL,
	[desconto] [decimal](10, 2) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_IdFornecedor]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_IdFornecedor] ON [dbo].[compra]
(
	[IdFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_IdProduto]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_IdProduto] ON [dbo].[compra]
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_servico_ID]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_servico_ID] ON [dbo].[consulta]
(
	[servico_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FuncionarioId]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_FuncionarioId] ON [dbo].[FuncionarioPermissaos]
(
	[FuncionarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_fornecedorId]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_fornecedorId] ON [dbo].[produto]
(
	[fornecedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FuncionarioID]    Script Date: 30/08/2023 19:57:21 ******/
CREATE NONCLUSTERED INDEX [IX_FuncionarioID] ON [dbo].[Servicos]
(
	[FuncionarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[animal] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[cargo] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [dataCadastro]
GO
ALTER TABLE [dbo].[compra] ADD  DEFAULT ((0)) FOR [Quantidade]
GO
ALTER TABLE [dbo].[consulta] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[endereco] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[especie] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[exame] ADD  DEFAULT ((0)) FOR [cancelado]
GO
ALTER TABLE [dbo].[formas_pagamento] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT ('1900-01-01T00:00:00.000') FOR [dataCadastro]
GO
ALTER TABLE [dbo].[funcionario] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[medicacao] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[produto] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[venda] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([id_especie])
REFERENCES [dbo].[especie] ([id])
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([id_endereco])
REFERENCES [dbo].[endereco] ([id])
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_dbo.compra_dbo.fornecedor_IdFornecedor] FOREIGN KEY([IdFornecedor])
REFERENCES [dbo].[fornecedor] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_dbo.compra_dbo.fornecedor_IdFornecedor]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_dbo.compra_dbo.produto_IdProduto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[produto] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_dbo.compra_dbo.produto_IdProduto]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_animal])
REFERENCES [dbo].[animal] ([id])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[funcionario] ([id])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [FK_dbo.consulta_dbo.Servicos_servico_ID] FOREIGN KEY([servico_ID])
REFERENCES [dbo].[Servicos] ([ID])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [FK_dbo.consulta_dbo.Servicos_servico_ID]
GO
ALTER TABLE [dbo].[exame]  WITH CHECK ADD FOREIGN KEY([id_consulta])
REFERENCES [dbo].[consulta] ([id])
GO
ALTER TABLE [dbo].[funcionario]  WITH CHECK ADD FOREIGN KEY([id_cargo])
REFERENCES [dbo].[cargo] ([id])
GO
ALTER TABLE [dbo].[FuncionarioPermissaos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.FuncionarioPermissaos_dbo.funcionario_FuncionarioId] FOREIGN KEY([FuncionarioId])
REFERENCES [dbo].[funcionario] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FuncionarioPermissaos] CHECK CONSTRAINT [FK_dbo.FuncionarioPermissaos_dbo.funcionario_FuncionarioId]
GO
ALTER TABLE [dbo].[item_venda]  WITH CHECK ADD FOREIGN KEY([id_produto])
REFERENCES [dbo].[produto] ([id])
GO
ALTER TABLE [dbo].[item_venda]  WITH CHECK ADD FOREIGN KEY([id_venda])
REFERENCES [dbo].[venda] ([id])
GO
ALTER TABLE [dbo].[medicacao]  WITH CHECK ADD FOREIGN KEY([id_consulta])
REFERENCES [dbo].[consulta] ([id])
GO
ALTER TABLE [dbo].[pagamentos]  WITH CHECK ADD FOREIGN KEY([id_forma_pagamento])
REFERENCES [dbo].[formas_pagamento] ([id])
GO
ALTER TABLE [dbo].[pagamentos_parcelados]  WITH CHECK ADD FOREIGN KEY([id_pagamento])
REFERENCES [dbo].[pagamentos] ([id])
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [FK_dbo.produto_dbo.fornecedor_fornecedorId] FOREIGN KEY([fornecedorId])
REFERENCES [dbo].[fornecedor] ([Id])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [FK_dbo.produto_dbo.fornecedor_fornecedorId]
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD FOREIGN KEY([TipoProfissionalID])
REFERENCES [dbo].[TiposProfissionais] ([ID])
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Servicos_dbo.funcionario_FuncionarioID] FOREIGN KEY([FuncionarioID])
REFERENCES [dbo].[funcionario] ([id])
GO
ALTER TABLE [dbo].[Servicos] CHECK CONSTRAINT [FK_dbo.Servicos_dbo.funcionario_FuncionarioID]
GO
USE [master]
GO
ALTER DATABASE [db_clinica] SET  READ_WRITE 
GO
