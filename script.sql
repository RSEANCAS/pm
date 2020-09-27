USE [dbPM]
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividad](
	[CodigoActividad] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[CodigoActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[CodigoArea] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[CodigoArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banco](
	[CodigoBanco] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Banco] PRIMARY KEY CLUSTERED 
(
	[CodigoBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoletaVenta]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoletaVenta](
	[CodigoBoletaVenta] [int] NOT NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[FechaHoraVencimiento] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[DireccionCliente] [varchar](100) NULL,
	[NombrePaisCliente] [varchar](50) NULL,
	[NombreDepartamentoCliente] [varchar](50) NULL,
	[NombreProvinciaCliente] [varchar](50) NULL,
	[CodigoDistritoCliente] [int] NULL,
	[NombreDistritoCliente] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[CodigoSerieGuiaRemision] [int] NULL,
	[NroComprobanteGuiaRemision] [int] NULL,
	[TotalOperacionGravada] [decimal](18, 2) NULL,
	[TotalOperacionInafecta] [decimal](18, 2) NULL,
	[TotalOperacionExonerada] [decimal](18, 2) NULL,
	[TotalOperacionExportacion] [decimal](18, 2) NULL,
	[TotalOperacionGratuita] [decimal](18, 2) NULL,
	[TotalValorVenta] [decimal](18, 2) NULL,
	[TotalIgv] [decimal](18, 2) NULL,
	[TotalIsc] [decimal](18, 2) NULL,
	[TotalOtrosCargos] [decimal](18, 2) NULL,
	[TotalOtrosTributos] [decimal](18, 2) NULL,
	[TotalIcbper] [decimal](18, 2) NULL,
	[TotalDescuentoDetallado] [decimal](18, 2) NULL,
	[TotalPorcentajeDescuentoGlobal] [decimal](18, 2) NULL,
	[TotalDescuentoGlobal] [decimal](18, 2) NULL,
	[TotalPrecioVenta] [decimal](18, 2) NULL,
	[TotalImporte] [decimal](18, 2) NULL,
	[TotalPercepcion] [decimal](18, 2) NULL,
	[TotalPagar] [decimal](18, 2) NULL,
	[FlagEmitido] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_BoletaVenta] PRIMARY KEY CLUSTERED 
(
	[CodigoBoletaVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoletaVentaDetalle]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoletaVentaDetalle](
	[CodigoBoletaVenta] [int] NULL,
	[CodigoBoletaVentaDetalle] [int] NULL,
	[CodigoProducto] [int] NULL,
	[CodigoProductoIndividual] [int] NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Detalle] [varchar](max) NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[TipoCalculo] [int] NULL,
	[ValorUnitario] [decimal](18, 2) NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
	[ValorVenta] [decimal](18, 2) NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[Igv] [decimal](18, 2) NULL,
	[Isc] [decimal](18, 2) NULL,
	[TipoDescuento] [int] NULL,
	[PorcentajeDescuento] [decimal](18, 2) NULL,
	[Descuento] [decimal](18, 2) NULL,
	[OtrosCargos] [decimal](18, 2) NULL,
	[OtrosTributos] [decimal](18, 2) NULL,
	[BaseImponible] [decimal](18, 2) NULL,
	[Importe] [decimal](18, 2) NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[CodigoCliente] [int] NOT NULL,
	[CodigoTipoDocumentoIdentidad] [int] NULL,
	[NroDocumentoIdentidad] [varchar](20) NULL,
	[Nombres] [varchar](100) NULL,
	[Direccion] [varchar](100) NULL,
	[CodigoDistrito] [int] NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](100) NULL,
	[CodigoActividadPrincipal] [int] NULL,
	[Contacto] [varchar](100) NULL,
	[AreaContacto] [varchar](100) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobanteCompra]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobanteCompra](
	[CodigoComprobanteCompra] [int] NULL,
	[FechaHoraRegistro] [datetime] NULL,
	[FechaCompra] [date] NULL,
	[CodigoTipoComprobante] [int] NULL,
	[Serie] [varchar](4) NULL,
	[Numero] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizacion]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizacion](
	[CodigoCotizacion] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[CodigoMoneda] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[CodigoDepartamento] [int] NOT NULL,
	[CodigoPais] [int] NULL,
	[CodigoUbigeo] [varchar](2) NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[CodigoDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[CodigoDistrito] [int] NOT NULL,
	[CodigoProvincia] [int] NULL,
	[CodigoUbigeo] [varchar](6) NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED 
(
	[CodigoDistrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[CodigoFacturaVenta] [int] NOT NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[FechaHoraVencimiento] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[DireccionCliente] [varchar](100) NULL,
	[NombrePaisCliente] [varchar](50) NULL,
	[NombreDepartamentoCliente] [varchar](50) NULL,
	[NombreProvinciaCliente] [varchar](50) NULL,
	[CodigoDistritoCliente] [int] NULL,
	[NombreDistritoCliente] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[CodigoMetodoPago] [int] NULL,
	[CantidadLetrasCredito] [int] NULL,
	[CodigoSerieGuiaRemision] [int] NULL,
	[NroComprobanteGuiaRemision] [int] NULL,
	[TotalOperacionGravada] [decimal](18, 2) NULL,
	[TotalOperacionInafecta] [decimal](18, 2) NULL,
	[TotalOperacionExonerada] [decimal](18, 2) NULL,
	[TotalOperacionExportacion] [decimal](18, 2) NULL,
	[TotalOperacionGratuita] [decimal](18, 2) NULL,
	[TotalValorVenta] [decimal](18, 2) NULL,
	[TotalIgv] [decimal](18, 2) NULL,
	[TotalIsc] [decimal](18, 2) NULL,
	[TotalOtrosCargos] [decimal](18, 2) NULL,
	[TotalOtrosTributos] [decimal](18, 2) NULL,
	[TotalIcbper] [decimal](18, 2) NULL,
	[TotalDescuentoDetallado] [decimal](18, 2) NULL,
	[TotalPorcentajeDescuentoGlobal] [decimal](18, 2) NULL,
	[TotalDescuentoGlobal] [decimal](18, 2) NULL,
	[TotalPrecioVenta] [decimal](18, 2) NULL,
	[TotalImporte] [decimal](18, 2) NULL,
	[TotalPercepcion] [decimal](18, 2) NULL,
	[TotalPagar] [decimal](18, 2) NULL,
	[FlagEmitido] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_FacturaVenta] PRIMARY KEY CLUSTERED 
(
	[CodigoFacturaVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVentaDetalle]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVentaDetalle](
	[CodigoFacturaVenta] [int] NULL,
	[CodigoFacturaVentaDetalle] [int] NULL,
	[CodigoProducto] [int] NULL,
	[CodigoProductoIndividual] [int] NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Detalle] [varchar](max) NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[TipoCalculo] [int] NULL,
	[ValorUnitario] [decimal](18, 2) NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
	[ValorVenta] [decimal](18, 2) NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[Igv] [decimal](18, 2) NULL,
	[Isc] [decimal](18, 2) NULL,
	[TipoDescuento] [int] NULL,
	[PorcentajeDescuento] [decimal](18, 2) NULL,
	[Descuento] [decimal](18, 2) NULL,
	[OtrosCargos] [decimal](18, 2) NULL,
	[OtrosTributos] [decimal](18, 2) NULL,
	[BaseImponible] [decimal](18, 2) NULL,
	[Importe] [decimal](18, 2) NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuiaRemision]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuiaRemision](
	[CodigoGuiaRemision] [int] NOT NULL,
	[CodigoTipoComprobante] [int] NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[FechaHoraTraslado] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[DireccionCliente] [varchar](100) NULL,
	[NombrePaisCliente] [varchar](50) NULL,
	[NombreDepartamentoCliente] [varchar](50) NULL,
	[NombreProvinciaCliente] [varchar](50) NULL,
	[CodigoDistritoCliente] [int] NULL,
	[NombreDistritoCliente] [varchar](50) NULL,
	[CodigoMotivoTraslado] [int] NULL,
	[CodigoTransportista] [int] NULL,
	[DireccionTransportista] [varchar](100) NULL,
	[NombrePaisTransportista] [varchar](50) NULL,
	[NombreDepartamentoTransportista] [varchar](50) NULL,
	[NombreProvinciaTransportista] [varchar](50) NULL,
	[CodigoDistritoTransportista] [int] NULL,
	[NombreDistritoTransportista] [varchar](50) NULL,
	[MarcaVehiculoTransportista] [varchar](50) NULL,
	[PlacaVehiculoTransportista] [varchar](50) NULL,
	[LicenciaConducirTransportista] [varchar](50) NULL,
	[FlagEmitido] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_GuiaRemision] PRIMARY KEY CLUSTERED 
(
	[CodigoGuiaRemision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuiaRemisionDetalle]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuiaRemisionDetalle](
	[CodigoGuiaRemision] [int] NOT NULL,
	[CodigoGuiaRemisionDetalle] [int] NULL,
	[CodigoProducto] [int] NULL,
	[CodigoProductoIndividual] [int] NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Detalle] [varchar](max) NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[CodigoUnidadMedidaPeso] [int] NULL,
	[Peso] [decimal](18, 2) NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Letra]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Letra](
	[CodigoLetra] [int] NOT NULL,
	[Numero] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Dias] [int] NULL,
	[CodigoTipoComprobanteRef] [int] NULL,
	[CodigoSerieRef] [int] NULL,
	[NumeroRef] [int] NULL,
	[CodigoSerieGuia] [int] NULL,
	[NumeroGuia] [int] NULL,
	[CodigoCliente] [int] NULL,
	[CodigoBanco] [int] NULL,
	[CodigoUnicoBanco] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[Monto] [decimal](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[FlagCancelado] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Letra] PRIMARY KEY CLUSTERED 
(
	[CodigoLetra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[CodigoMenu] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Formulario] [varchar](50) NULL,
	[CodigoMenuPadre] [int] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[CodigoMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotivoTraslado]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotivoTraslado](
	[CodigoMotivoTraslado] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_MotivoTraslado] PRIMARY KEY CLUSTERED 
(
	[CodigoMotivoTraslado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[CodigoPais] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Nacionalidad] [varchar](50) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[CodigoPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[CodigoPerfil] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[CodigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilMenu]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilMenu](
	[CodigoPerfil] [int] NOT NULL,
	[CodigoMenu] [int] NOT NULL,
 CONSTRAINT [PK_PerfilMenu] PRIMARY KEY CLUSTERED 
(
	[CodigoPerfil] ASC,
	[CodigoMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[CodigoPersonal] [int] NOT NULL,
	[CodigoTipoDocumentoIdentidad] [int] NULL,
	[NroDocumentoIdentidad] [varchar](20) NULL,
	[Nombres] [varchar](100) NULL,
	[Correo] [varchar](50) NULL,
	[CodigoArea] [int] NULL,
	[FlagActivo] [bit] NULL,
	[Estado] [int] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[CodigoPersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[CodigoProducto] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[ValorCompra] [decimal](18, 2) NULL,
	[ValorVenta] [decimal](18, 2) NULL,
	[DescuentoMaximo] [decimal](18, 2) NULL,
	[Color] [varchar](20) NULL,
	[MetrajeTotal] [decimal](18, 2) NULL,
	[Estado] [int] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[CodigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoIndividual]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoIndividual](
	[CodigoProductoIndividual] [int] NOT NULL,
	[CodigoBarra] [varchar](50) NULL,
	[CodigoProducto] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Metraje] [decimal](18, 2) NULL,
	[Peso] [decimal](18, 2) NULL,
	[CodigoInicial] [int] NULL,
	[Rollo] [decimal](18, 2) NULL,
	[Bulto] [decimal](18, 2) NULL,
	[Color] [varchar](50) NULL,
	[CodigoProveedor] [int] NULL,
	[CodigoBarraProveedor] [varchar](50) NULL,
	[FechaEntrada] [datetime] NULL,
	[CodigoPersonalInspeccion] [int] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [nchar](10) NULL,
 CONSTRAINT [PK_ProductoIndividual] PRIMARY KEY CLUSTERED 
(
	[CodigoProductoIndividual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[CodigoProveedor] [int] NOT NULL,
	[CodigoTipoDocumentoIdentidad] [int] NULL,
	[NroDocumentoIdentidad] [varchar](20) NULL,
	[Nombres] [varchar](100) NULL,
	[Direccion] [varchar](100) NULL,
	[CodigoDistrito] [int] NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Contacto] [varchar](100) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[CodigoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[CodigoProvincia] [int] NOT NULL,
	[CodigoDepartamento] [int] NULL,
	[CodigoUbigeo] [varchar](4) NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[CodigoProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serie]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serie](
	[CodigoSerie] [int] NOT NULL,
	[CodigoTipoComprobante] [int] NULL,
	[Serial] [varchar](4) NULL,
	[ValorInicial] [int] NULL,
	[ValorFinal] [int] NULL,
	[ValorActual] [int] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Serie] PRIMARY KEY CLUSTERED 
(
	[CodigoSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoComprobante]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoComprobante](
	[CodigoTipoComprobante] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[CodigoTipoDocumento] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[ValorInicial] [int] NULL,
	[ValorFinal] [int] NULL,
	[ValorActual] [int] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentoIdentidad]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentoIdentidad](
	[CodigoTipoDocumentoIdentidad] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[CantidadCaracteres] [int] NULL,
 CONSTRAINT [PK_TipoDocumentoIdentidad] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoDocumentoIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[CodigoUnidadMedida] [int] NOT NULL,
	[Descripcion] [varchar](300) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [nchar](10) NULL,
 CONSTRAINT [PK_UnidadMedida] PRIMARY KEY CLUSTERED 
(
	[CodigoUnidadMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[CodigoUsuario] [int] NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Contraseña] [varbinary](20) NULL,
	[CodigoPersonal] [int] NULL,
	[FlagCambiarContraseña] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 27/09/2020 04:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPerfil](
	[CodigoUsuario] [int] NOT NULL,
	[CodigoPerfil] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPerfil] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC,
	[CodigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Actividad] ([CodigoActividad], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'BODEGA', 1, N'AUTO', CAST(N'2020-08-06T22:15:23.773' AS DateTime), NULL, NULL)
INSERT [dbo].[Area] ([CodigoArea], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'Sistemas', 1, N'AUTO', CAST(N'2020-08-05T01:41:14.250' AS DateTime), NULL, NULL)
INSERT [dbo].[Banco] ([CodigoBanco], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'BCP', 1, NULL, CAST(N'2020-09-21T22:27:52.663' AS DateTime), NULL, NULL)
INSERT [dbo].[Banco] ([CodigoBanco], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'BBVA', 1, NULL, CAST(N'2020-09-21T22:27:59.050' AS DateTime), NULL, NULL)
INSERT [dbo].[BoletaVenta] ([CodigoBoletaVenta], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraVencimiento], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMoneda], [CodigoSerieGuiaRemision], [NroComprobanteGuiaRemision], [TotalOperacionGravada], [TotalOperacionInafecta], [TotalOperacionExonerada], [TotalOperacionExportacion], [TotalOperacionGratuita], [TotalValorVenta], [TotalIgv], [TotalIsc], [TotalOtrosCargos], [TotalOtrosTributos], [TotalIcbper], [TotalDescuentoDetallado], [TotalPorcentajeDescuentoGlobal], [TotalDescuentoGlobal], [TotalPrecioVenta], [TotalImporte], [TotalPercepcion], [TotalPagar], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, 1, CAST(N'2020-09-10T23:36:36.897' AS DateTime), CAST(N'2020-09-10T23:36:36.893' AS DateTime), 1, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10', N'Perú', N'Lima', N'Lima', 1315, N'Surquillo', 1, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(169.49 AS Decimal(18, 2)), CAST(30.51 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL, CAST(N'2020-09-10T23:37:37.320' AS DateTime), NULL, NULL)
INSERT [dbo].[BoletaVentaDetalle] ([CodigoBoletaVenta], [CodigoBoletaVentaDetalle], [CodigoProducto], [CodigoProductoIndividual], [CodigoUnidadMedida], [Detalle], [Cantidad], [TipoCalculo], [ValorUnitario], [PrecioUnitario], [ValorVenta], [PrecioVenta], [Igv], [Isc], [TipoDescuento], [PorcentajeDescuento], [Descuento], [OtrosCargos], [OtrosTributos], [BaseImponible], [Importe], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, 1, 1, 456, N'ROLLO TELA ESPECIAL', CAST(10.00 AS Decimal(18, 2)), 1, CAST(16.95 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(169.49 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(30.51 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(169.49 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), 0, NULL, CAST(N'2020-09-10T23:38:20.767' AS DateTime), NULL, NULL)
INSERT [dbo].[Cliente] ([CodigoCliente], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Direccion], [CodigoDistrito], [Correo], [Telefono], [CodigoActividadPrincipal], [Contacto], [AreaContacto], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, N'71228362', N'RONALD JULINHO SEANCAS BARRETO', N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10', 1315, N'ronald.jsb@hotmail.com', N'954762805', NULL, N'RONALD SEANCAS', N'SISTEMAS-TI', 1, N'AUTO', CAST(N'2020-08-06T22:19:20.400' AS DateTime), NULL, CAST(N'2020-09-04T00:32:18.203' AS DateTime))
INSERT [dbo].[Cliente] ([CodigoCliente], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Direccion], [CodigoDistrito], [Correo], [Telefono], [CodigoActividadPrincipal], [Contacto], [AreaContacto], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, 1, N'07264120', N'ZORAIDA PAOLA BARRETO GONZALES', N'CLL. IGNACIO SEMINARIO 950 ZN C - SJM', 1307, N'zoraida.barreto@gmail.com', N'951362655', NULL, N'ZORAIDA', N'RRHH', 1, NULL, CAST(N'2020-08-07T03:33:52.963' AS DateTime), NULL, NULL)
INSERT [dbo].[Cliente] ([CodigoCliente], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Direccion], [CodigoDistrito], [Correo], [Telefono], [CodigoActividadPrincipal], [Contacto], [AreaContacto], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, 2, N'10712283624', N'RONALD JULINHO SEANCAS BARRETO', N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10 - SURQUILLO', 1307, N'rseancas@gmail.com', N'954762805', 1, N'RONALD SEANCAS', N'SISTEMAS', 1, NULL, CAST(N'2020-08-07T03:39:58.947' AS DateTime), NULL, CAST(N'2020-08-07T17:29:52.233' AS DateTime))
INSERT [dbo].[Cliente] ([CodigoCliente], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Direccion], [CodigoDistrito], [Correo], [Telefono], [CodigoActividadPrincipal], [Contacto], [AreaContacto], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, 1, N'07289099', N'JOHN EDUARDO SEANCAS BARRETO', N'CLL. IGNACIO SEMINARIO 950 ZN C - SJM', 1307, N'edu_sb@hotmail.com', N'989894891', 1, N'JOHN SEANCAS', N'SISTEMAS', 0, NULL, CAST(N'2020-08-10T16:40:14.843' AS DateTime), NULL, CAST(N'2020-08-10T16:41:44.530' AS DateTime))
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (1, 145, N'01', N'Amazonas')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (2, 145, N'02', N'Áncash')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (3, 145, N'03', N'Apurímac')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (4, 145, N'04', N'Arequipa')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (5, 145, N'05', N'Ayacucho')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (6, 145, N'06', N'Cajamarca')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (7, 145, N'07', N'Callao')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (8, 145, N'08', N'Cusco')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (9, 145, N'09', N'Huancavelica')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (10, 145, N'10', N'Huánuco')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (11, 145, N'11', N'Ica')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (12, 145, N'12', N'Junín')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (13, 145, N'13', N'La Libertad')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (14, 145, N'14', N'Lambayeque')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (15, 145, N'15', N'Lima')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (16, 145, N'16', N'Loreto')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (17, 145, N'17', N'Madre de Dios')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (18, 145, N'18', N'Moquegua')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (19, 145, N'19', N'Pasco')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (20, 145, N'20', N'Piura')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (21, 145, N'21', N'Puno')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (22, 145, N'22', N'San Martín')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (23, 145, N'23', N'Tacna')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (24, 145, N'24', N'Tumbes')
INSERT [dbo].[Departamento] ([CodigoDepartamento], [CodigoPais], [CodigoUbigeo], [Nombre]) VALUES (25, 145, N'25', N'Ucayali')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1, 1, N'010101', N'Chachapoyas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (2, 1, N'010102', N'Asunción')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (3, 1, N'010103', N'Balsas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (4, 1, N'010104', N'Cheto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (5, 1, N'010105', N'Chiliquin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (6, 1, N'010106', N'Chuquibamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (7, 1, N'010107', N'Granada')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (8, 1, N'010108', N'Huancas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (9, 1, N'010109', N'La Jalca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (10, 1, N'010110', N'Leimebamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (11, 1, N'010111', N'Levanto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (12, 1, N'010112', N'Magdalena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (13, 1, N'010113', N'Mariscal Castilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (14, 1, N'010114', N'Molinopampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (15, 1, N'010115', N'Montevideo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (16, 1, N'010116', N'Olleros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (17, 1, N'010117', N'Quinjalca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (18, 1, N'010118', N'San Francisco de Daguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (19, 1, N'010119', N'San Isidro de Maino')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (20, 1, N'010120', N'Soloco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (21, 1, N'010121', N'Sonche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (22, 2, N'010201', N'Bagua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (23, 2, N'010202', N'Aramango')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (24, 2, N'010203', N'Copallin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (25, 2, N'010204', N'El Parco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (26, 2, N'010205', N'Imaza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (27, 2, N'010206', N'La Peca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (28, 3, N'010301', N'Jumbilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (29, 3, N'010302', N'Chisquilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (30, 3, N'010303', N'Churuja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (31, 3, N'010304', N'Corosha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (32, 3, N'010305', N'Cuispes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (33, 3, N'010306', N'Florida')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (34, 3, N'010307', N'Jazan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (35, 3, N'010308', N'Recta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (36, 3, N'010309', N'San Carlos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (37, 3, N'010310', N'Shipasbamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (38, 3, N'010311', N'Valera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (39, 3, N'010312', N'Yambrasbamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (40, 4, N'010401', N'Nieva')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (41, 4, N'010402', N'El Cenepa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (42, 4, N'010403', N'Río Santiago')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (43, 5, N'010501', N'Lamud')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (44, 5, N'010502', N'Camporredondo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (45, 5, N'010503', N'Cocabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (46, 5, N'010504', N'Colcamar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (47, 5, N'010505', N'Conila')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (48, 5, N'010506', N'Inguilpata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (49, 5, N'010507', N'Longuita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (50, 5, N'010508', N'Lonya Chico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (51, 5, N'010509', N'Luya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (52, 5, N'010510', N'Luya Viejo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (53, 5, N'010511', N'María')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (54, 5, N'010512', N'Ocalli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (55, 5, N'010513', N'Ocumal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (56, 5, N'010514', N'Pisuquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (57, 5, N'010515', N'Providencia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (58, 5, N'010516', N'San Cristóbal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (59, 5, N'010517', N'San Francisco de Yeso')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (60, 5, N'010518', N'San Jerónimo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (61, 5, N'010519', N'San Juan de Lopecancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (62, 5, N'010520', N'Santa Catalina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (63, 5, N'010521', N'Santo Tomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (64, 5, N'010522', N'Tingo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (65, 5, N'010523', N'Trita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (66, 6, N'010601', N'San Nicolás')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (67, 6, N'010602', N'Chirimoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (68, 6, N'010603', N'Cochamal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (69, 6, N'010604', N'Huambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (70, 6, N'010605', N'Limabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (71, 6, N'010606', N'Longar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (72, 6, N'010607', N'Mariscal Benavides')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (73, 6, N'010608', N'Milpuc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (74, 6, N'010609', N'Omia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (75, 6, N'010610', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (76, 6, N'010611', N'Totora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (77, 6, N'010612', N'Vista Alegre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (78, 7, N'010701', N'Bagua Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (79, 7, N'010702', N'Cajaruro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (80, 7, N'010703', N'Cumba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (81, 7, N'010704', N'El Milagro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (82, 7, N'010705', N'Jamalca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (83, 7, N'010706', N'Lonya Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (84, 7, N'010707', N'Yamon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (85, 8, N'020101', N'Huaraz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (86, 8, N'020102', N'Cochabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (87, 8, N'020103', N'Colcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (88, 8, N'020104', N'Huanchay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (89, 8, N'020105', N'Independencia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (90, 8, N'020106', N'Jangas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (91, 8, N'020107', N'La Libertad')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (92, 8, N'020108', N'Olleros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (93, 8, N'020109', N'Pampas Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (94, 8, N'020110', N'Pariacoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (95, 8, N'020111', N'Pira')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (96, 8, N'020112', N'Tarica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (97, 9, N'020201', N'Aija')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (98, 9, N'020202', N'Coris')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (99, 9, N'020203', N'Huacllan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (100, 9, N'020204', N'La Merced')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (101, 9, N'020205', N'Succha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (102, 10, N'020301', N'Llamellin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (103, 10, N'020302', N'Aczo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (104, 10, N'020303', N'Chaccho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (105, 10, N'020304', N'Chingas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (106, 10, N'020305', N'Mirgas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (107, 10, N'020306', N'San Juan de Rontoy')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (108, 11, N'020401', N'Chacas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (109, 11, N'020402', N'Acochaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (110, 12, N'020501', N'Chiquian')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (111, 12, N'020502', N'Abelardo Pardo Lezameta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (112, 12, N'020503', N'Antonio Raymondi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (113, 12, N'020504', N'Aquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (114, 12, N'020505', N'Cajacay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (115, 12, N'020506', N'Canis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (116, 12, N'020507', N'Colquioc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (117, 12, N'020508', N'Huallanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (118, 12, N'020509', N'Huasta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (119, 12, N'020510', N'Huayllacayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (120, 12, N'020511', N'La Primavera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (121, 12, N'020512', N'Mangas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (122, 12, N'020513', N'Pacllon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (123, 12, N'020514', N'San Miguel de Corpanqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (124, 12, N'020515', N'Ticllos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (125, 13, N'020601', N'Carhuaz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (126, 13, N'020602', N'Acopampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (127, 13, N'020603', N'Amashca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (128, 13, N'020604', N'Anta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (129, 13, N'020605', N'Ataquero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (130, 13, N'020606', N'Marcara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (131, 13, N'020607', N'Pariahuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (132, 13, N'020608', N'San Miguel de Aco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (133, 13, N'020609', N'Shilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (134, 13, N'020610', N'Tinco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (135, 13, N'020611', N'Yungar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (136, 14, N'020701', N'San Luis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (137, 14, N'020702', N'San Nicolás')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (138, 14, N'020703', N'Yauya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (139, 15, N'020801', N'Casma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (140, 15, N'020802', N'Buena Vista Alta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (141, 15, N'020803', N'Comandante Noel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (142, 15, N'020804', N'Yautan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (143, 16, N'020901', N'Corongo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (144, 16, N'020902', N'Aco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (145, 16, N'020903', N'Bambas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (146, 16, N'020904', N'Cusca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (147, 16, N'020905', N'La Pampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (148, 16, N'020906', N'Yanac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (149, 16, N'020907', N'Yupan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (150, 17, N'021001', N'Huari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (151, 17, N'021002', N'Anra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (152, 17, N'021003', N'Cajay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (153, 17, N'021004', N'Chavin de Huantar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (154, 17, N'021005', N'Huacachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (155, 17, N'021006', N'Huacchis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (156, 17, N'021007', N'Huachis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (157, 17, N'021008', N'Huantar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (158, 17, N'021009', N'Masin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (159, 17, N'021010', N'Paucas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (160, 17, N'021011', N'Ponto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (161, 17, N'021012', N'Rahuapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (162, 17, N'021013', N'Rapayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (163, 17, N'021014', N'San Marcos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (164, 17, N'021015', N'San Pedro de Chana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (165, 17, N'021016', N'Uco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (166, 18, N'021101', N'Huarmey')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (167, 18, N'021102', N'Cochapeti')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (168, 18, N'021103', N'Culebras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (169, 18, N'021104', N'Huayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (170, 18, N'021105', N'Malvas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (171, 19, N'021201', N'Caraz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (172, 19, N'021202', N'Huallanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (173, 19, N'021203', N'Huata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (174, 19, N'021204', N'Huaylas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (175, 19, N'021205', N'Mato')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (176, 19, N'021206', N'Pamparomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (177, 19, N'021207', N'Pueblo Libre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (178, 19, N'021208', N'Santa Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (179, 19, N'021209', N'Santo Toribio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (180, 19, N'021210', N'Yuracmarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (181, 20, N'021301', N'Piscobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (182, 20, N'021302', N'Casca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (183, 20, N'021303', N'Eleazar Guzmán Barron')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (184, 20, N'021304', N'Fidel Olivas Escudero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (185, 20, N'021305', N'Llama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (186, 20, N'021306', N'Llumpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (187, 20, N'021307', N'Lucma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (188, 20, N'021308', N'Musga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (189, 21, N'021401', N'Ocros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (190, 21, N'021402', N'Acas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (191, 21, N'021403', N'Cajamarquilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (192, 21, N'021404', N'Carhuapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (193, 21, N'021405', N'Cochas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (194, 21, N'021406', N'Congas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (195, 21, N'021407', N'Llipa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (196, 21, N'021408', N'San Cristóbal de Rajan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (197, 21, N'021409', N'San Pedro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (198, 21, N'021410', N'Santiago de Chilcas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (199, 22, N'021501', N'Cabana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (200, 22, N'021502', N'Bolognesi')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (201, 22, N'021503', N'Conchucos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (202, 22, N'021504', N'Huacaschuque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (203, 22, N'021505', N'Huandoval')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (204, 22, N'021506', N'Lacabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (205, 22, N'021507', N'Llapo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (206, 22, N'021508', N'Pallasca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (207, 22, N'021509', N'Pampas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (208, 22, N'021510', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (209, 22, N'021511', N'Tauca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (210, 23, N'021601', N'Pomabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (211, 23, N'021602', N'Huayllan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (212, 23, N'021603', N'Parobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (213, 23, N'021604', N'Quinuabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (214, 24, N'021701', N'Recuay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (215, 24, N'021702', N'Catac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (216, 24, N'021703', N'Cotaparaco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (217, 24, N'021704', N'Huayllapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (218, 24, N'021705', N'Llacllin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (219, 24, N'021706', N'Marca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (220, 24, N'021707', N'Pampas Chico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (221, 24, N'021708', N'Pararin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (222, 24, N'021709', N'Tapacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (223, 24, N'021710', N'Ticapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (224, 25, N'021801', N'Chimbote')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (225, 25, N'021802', N'Cáceres del Perú')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (226, 25, N'021803', N'Coishco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (227, 25, N'021804', N'Macate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (228, 25, N'021805', N'Moro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (229, 25, N'021806', N'Nepeña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (230, 25, N'021807', N'Samanco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (231, 25, N'021808', N'Santa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (232, 25, N'021809', N'Nuevo Chimbote')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (233, 26, N'021901', N'Sihuas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (234, 26, N'021902', N'Acobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (235, 26, N'021903', N'Alfonso Ugarte')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (236, 26, N'021904', N'Cashapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (237, 26, N'021905', N'Chingalpo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (238, 26, N'021906', N'Huayllabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (239, 26, N'021907', N'Quiches')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (240, 26, N'021908', N'Ragash')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (241, 26, N'021909', N'San Juan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (242, 26, N'021910', N'Sicsibamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (243, 27, N'022001', N'Yungay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (244, 27, N'022002', N'Cascapara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (245, 27, N'022003', N'Mancos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (246, 27, N'022004', N'Matacoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (247, 27, N'022005', N'Quillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (248, 27, N'022006', N'Ranrahirca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (249, 27, N'022007', N'Shupluy')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (250, 27, N'022008', N'Yanama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (251, 28, N'030101', N'Abancay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (252, 28, N'030102', N'Chacoche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (253, 28, N'030103', N'Circa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (254, 28, N'030104', N'Curahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (255, 28, N'030105', N'Huanipaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (256, 28, N'030106', N'Lambrama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (257, 28, N'030107', N'Pichirhua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (258, 28, N'030108', N'San Pedro de Cachora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (259, 28, N'030109', N'Tamburco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (260, 29, N'030201', N'Andahuaylas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (261, 29, N'030202', N'Andarapa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (262, 29, N'030203', N'Chiara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (263, 29, N'030204', N'Huancarama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (264, 29, N'030205', N'Huancaray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (265, 29, N'030206', N'Huayana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (266, 29, N'030207', N'Kishuara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (267, 29, N'030208', N'Pacobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (268, 29, N'030209', N'Pacucha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (269, 29, N'030210', N'Pampachiri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (270, 29, N'030211', N'Pomacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (271, 29, N'030212', N'San Antonio de Cachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (272, 29, N'030213', N'San Jerónimo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (273, 29, N'030214', N'San Miguel de Chaccrampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (274, 29, N'030215', N'Santa María de Chicmo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (275, 29, N'030216', N'Talavera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (276, 29, N'030217', N'Tumay Huaraca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (277, 29, N'030218', N'Turpo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (278, 29, N'030219', N'Kaquiabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (279, 29, N'030220', N'José María Arguedas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (280, 30, N'030301', N'Antabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (281, 30, N'030302', N'El Oro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (282, 30, N'030303', N'Huaquirca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (283, 30, N'030304', N'Juan Espinoza Medrano')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (284, 30, N'030305', N'Oropesa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (285, 30, N'030306', N'Pachaconas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (286, 30, N'030307', N'Sabaino')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (287, 31, N'030401', N'Chalhuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (288, 31, N'030402', N'Capaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (289, 31, N'030403', N'Caraybamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (290, 31, N'030404', N'Chapimarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (291, 31, N'030405', N'Colcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (292, 31, N'030406', N'Cotaruse')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (293, 31, N'030407', N'Ihuayllo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (294, 31, N'030408', N'Justo Apu Sahuaraura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (295, 31, N'030409', N'Lucre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (296, 31, N'030410', N'Pocohuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (297, 31, N'030411', N'San Juan de Chacña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (298, 31, N'030412', N'Sañayca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (299, 31, N'030413', N'Soraya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (300, 31, N'030414', N'Tapairihua')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (301, 31, N'030415', N'Tintay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (302, 31, N'030416', N'Toraya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (303, 31, N'030417', N'Yanaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (304, 32, N'030501', N'Tambobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (305, 32, N'030502', N'Cotabambas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (306, 32, N'030503', N'Coyllurqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (307, 32, N'030504', N'Haquira')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (308, 32, N'030505', N'Mara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (309, 32, N'030506', N'Challhuahuacho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (310, 33, N'030601', N'Chincheros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (311, 33, N'030602', N'Anco_Huallo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (312, 33, N'030603', N'Cocharcas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (313, 33, N'030604', N'Huaccana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (314, 33, N'030605', N'Ocobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (315, 33, N'030606', N'Ongoy')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (316, 33, N'030607', N'Uranmarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (317, 33, N'030608', N'Ranracancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (318, 33, N'030609', N'Rocchacc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (319, 33, N'030610', N'El Porvenir')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (320, 34, N'030701', N'Chuquibambilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (321, 34, N'030702', N'Curpahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (322, 34, N'030703', N'Gamarra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (323, 34, N'030704', N'Huayllati')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (324, 34, N'030705', N'Mamara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (325, 34, N'030706', N'Micaela Bastidas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (326, 34, N'030707', N'Pataypampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (327, 34, N'030708', N'Progreso')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (328, 34, N'030709', N'San Antonio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (329, 34, N'030710', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (330, 34, N'030711', N'Turpay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (331, 34, N'030712', N'Vilcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (332, 34, N'030713', N'Virundo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (333, 34, N'030714', N'Curasco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (334, 35, N'040101', N'Arequipa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (335, 35, N'040102', N'Alto Selva Alegre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (336, 35, N'040103', N'Cayma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (337, 35, N'040104', N'Cerro Colorado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (338, 35, N'040105', N'Characato')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (339, 35, N'040106', N'Chiguata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (340, 35, N'040107', N'Jacobo Hunter')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (341, 35, N'040108', N'La Joya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (342, 35, N'040109', N'Mariano Melgar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (343, 35, N'040110', N'Miraflores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (344, 35, N'040111', N'Mollebaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (345, 35, N'040112', N'Paucarpata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (346, 35, N'040113', N'Pocsi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (347, 35, N'040114', N'Polobaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (348, 35, N'040115', N'Quequeña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (349, 35, N'040116', N'Sabandia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (350, 35, N'040117', N'Sachaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (351, 35, N'040118', N'San Juan de Siguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (352, 35, N'040119', N'San Juan de Tarucani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (353, 35, N'040120', N'Santa Isabel de Siguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (354, 35, N'040121', N'Santa Rita de Siguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (355, 35, N'040122', N'Socabaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (356, 35, N'040123', N'Tiabaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (357, 35, N'040124', N'Uchumayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (358, 35, N'040125', N'Vitor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (359, 35, N'040126', N'Yanahuara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (360, 35, N'040127', N'Yarabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (361, 35, N'040128', N'Yura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (362, 35, N'040129', N'José Luis Bustamante Y Rivero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (363, 36, N'040201', N'Camaná')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (364, 36, N'040202', N'José María Quimper')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (365, 36, N'040203', N'Mariano Nicolás Valcárcel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (366, 36, N'040204', N'Mariscal Cáceres')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (367, 36, N'040205', N'Nicolás de Pierola')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (368, 36, N'040206', N'Ocoña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (369, 36, N'040207', N'Quilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (370, 36, N'040208', N'Samuel Pastor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (371, 37, N'040301', N'Caravelí')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (372, 37, N'040302', N'Acarí')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (373, 37, N'040303', N'Atico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (374, 37, N'040304', N'Atiquipa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (375, 37, N'040305', N'Bella Unión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (376, 37, N'040306', N'Cahuacho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (377, 37, N'040307', N'Chala')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (378, 37, N'040308', N'Chaparra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (379, 37, N'040309', N'Huanuhuanu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (380, 37, N'040310', N'Jaqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (381, 37, N'040311', N'Lomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (382, 37, N'040312', N'Quicacha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (383, 37, N'040313', N'Yauca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (384, 38, N'040401', N'Aplao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (385, 38, N'040402', N'Andagua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (386, 38, N'040403', N'Ayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (387, 38, N'040404', N'Chachas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (388, 38, N'040405', N'Chilcaymarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (389, 38, N'040406', N'Choco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (390, 38, N'040407', N'Huancarqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (391, 38, N'040408', N'Machaguay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (392, 38, N'040409', N'Orcopampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (393, 38, N'040410', N'Pampacolca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (394, 38, N'040411', N'Tipan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (395, 38, N'040412', N'Uñon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (396, 38, N'040413', N'Uraca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (397, 38, N'040414', N'Viraco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (398, 39, N'040501', N'Chivay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (399, 39, N'040502', N'Achoma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (400, 39, N'040503', N'Cabanaconde')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (401, 39, N'040504', N'Callalli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (402, 39, N'040505', N'Caylloma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (403, 39, N'040506', N'Coporaque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (404, 39, N'040507', N'Huambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (405, 39, N'040508', N'Huanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (406, 39, N'040509', N'Ichupampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (407, 39, N'040510', N'Lari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (408, 39, N'040511', N'Lluta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (409, 39, N'040512', N'Maca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (410, 39, N'040513', N'Madrigal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (411, 39, N'040514', N'San Antonio de Chuca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (412, 39, N'040515', N'Sibayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (413, 39, N'040516', N'Tapay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (414, 39, N'040517', N'Tisco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (415, 39, N'040518', N'Tuti')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (416, 39, N'040519', N'Yanque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (417, 39, N'040520', N'Majes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (418, 40, N'040601', N'Chuquibamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (419, 40, N'040602', N'Andaray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (420, 40, N'040603', N'Cayarani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (421, 40, N'040604', N'Chichas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (422, 40, N'040605', N'Iray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (423, 40, N'040606', N'Río Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (424, 40, N'040607', N'Salamanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (425, 40, N'040608', N'Yanaquihua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (426, 41, N'040701', N'Mollendo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (427, 41, N'040702', N'Cocachacra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (428, 41, N'040703', N'Dean Valdivia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (429, 41, N'040704', N'Islay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (430, 41, N'040705', N'Mejia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (431, 41, N'040706', N'Punta de Bombón')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (432, 42, N'040801', N'Cotahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (433, 42, N'040802', N'Alca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (434, 42, N'040803', N'Charcana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (435, 42, N'040804', N'Huaynacotas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (436, 42, N'040805', N'Pampamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (437, 42, N'040806', N'Puyca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (438, 42, N'040807', N'Quechualla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (439, 42, N'040808', N'Sayla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (440, 42, N'040809', N'Tauria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (441, 42, N'040810', N'Tomepampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (442, 42, N'040811', N'Toro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (443, 43, N'050101', N'Ayacucho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (444, 43, N'050102', N'Acocro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (445, 43, N'050103', N'Acos Vinchos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (446, 43, N'050104', N'Carmen Alto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (447, 43, N'050105', N'Chiara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (448, 43, N'050106', N'Ocros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (449, 43, N'050107', N'Pacaycasa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (450, 43, N'050108', N'Quinua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (451, 43, N'050109', N'San José de Ticllas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (452, 43, N'050110', N'San Juan Bautista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (453, 43, N'050111', N'Santiago de Pischa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (454, 43, N'050112', N'Socos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (455, 43, N'050113', N'Tambillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (456, 43, N'050114', N'Vinchos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (457, 43, N'050115', N'Jesús Nazareno')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (458, 43, N'050116', N'Andrés Avelino Cáceres Dorregaray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (459, 44, N'050201', N'Cangallo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (460, 44, N'050202', N'Chuschi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (461, 44, N'050203', N'Los Morochucos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (462, 44, N'050204', N'María Parado de Bellido')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (463, 44, N'050205', N'Paras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (464, 44, N'050206', N'Totos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (465, 45, N'050301', N'Sancos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (466, 45, N'050302', N'Carapo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (467, 45, N'050303', N'Sacsamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (468, 45, N'050304', N'Santiago de Lucanamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (469, 46, N'050401', N'Huanta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (470, 46, N'050402', N'Ayahuanco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (471, 46, N'050403', N'Huamanguilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (472, 46, N'050404', N'Iguain')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (473, 46, N'050405', N'Luricocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (474, 46, N'050406', N'Santillana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (475, 46, N'050407', N'Sivia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (476, 46, N'050408', N'Llochegua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (477, 46, N'050409', N'Canayre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (478, 46, N'050410', N'Uchuraccay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (479, 46, N'050411', N'Pucacolpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (480, 46, N'050412', N'Chaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (481, 47, N'050501', N'San Miguel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (482, 47, N'050502', N'Anco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (483, 47, N'050503', N'Ayna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (484, 47, N'050504', N'Chilcas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (485, 47, N'050505', N'Chungui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (486, 47, N'050506', N'Luis Carranza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (487, 47, N'050507', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (488, 47, N'050508', N'Tambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (489, 47, N'050509', N'Samugari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (490, 47, N'050510', N'Anchihuay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (491, 48, N'050601', N'Puquio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (492, 48, N'050602', N'Aucara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (493, 48, N'050603', N'Cabana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (494, 48, N'050604', N'Carmen Salcedo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (495, 48, N'050605', N'Chaviña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (496, 48, N'050606', N'Chipao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (497, 48, N'050607', N'Huac-Huas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (498, 48, N'050608', N'Laramate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (499, 48, N'050609', N'Leoncio Prado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (500, 48, N'050610', N'Llauta')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (501, 48, N'050611', N'Lucanas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (502, 48, N'050612', N'Ocaña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (503, 48, N'050613', N'Otoca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (504, 48, N'050614', N'Saisa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (505, 48, N'050615', N'San Cristóbal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (506, 48, N'050616', N'San Juan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (507, 48, N'050617', N'San Pedro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (508, 48, N'050618', N'San Pedro de Palco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (509, 48, N'050619', N'Sancos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (510, 48, N'050620', N'Santa Ana de Huaycahuacho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (511, 48, N'050621', N'Santa Lucia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (512, 49, N'050701', N'Coracora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (513, 49, N'050702', N'Chumpi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (514, 49, N'050703', N'Coronel Castañeda')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (515, 49, N'050704', N'Pacapausa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (516, 49, N'050705', N'Pullo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (517, 49, N'050706', N'Puyusca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (518, 49, N'050707', N'San Francisco de Ravacayco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (519, 49, N'050708', N'Upahuacho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (520, 50, N'050801', N'Pausa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (521, 50, N'050802', N'Colta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (522, 50, N'050803', N'Corculla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (523, 50, N'050804', N'Lampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (524, 50, N'050805', N'Marcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (525, 50, N'050806', N'Oyolo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (526, 50, N'050807', N'Pararca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (527, 50, N'050808', N'San Javier de Alpabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (528, 50, N'050809', N'San José de Ushua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (529, 50, N'050810', N'Sara Sara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (530, 51, N'050901', N'Querobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (531, 51, N'050902', N'Belén')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (532, 51, N'050903', N'Chalcos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (533, 51, N'050904', N'Chilcayoc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (534, 51, N'050905', N'Huacaña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (535, 51, N'050906', N'Morcolla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (536, 51, N'050907', N'Paico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (537, 51, N'050908', N'San Pedro de Larcay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (538, 51, N'050909', N'San Salvador de Quije')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (539, 51, N'050910', N'Santiago de Paucaray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (540, 51, N'050911', N'Soras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (541, 52, N'051001', N'Huancapi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (542, 52, N'051002', N'Alcamenca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (543, 52, N'051003', N'Apongo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (544, 52, N'051004', N'Asquipata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (545, 52, N'051005', N'Canaria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (546, 52, N'051006', N'Cayara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (547, 52, N'051007', N'Colca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (548, 52, N'051008', N'Huamanquiquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (549, 52, N'051009', N'Huancaraylla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (550, 52, N'051010', N'Huaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (551, 52, N'051011', N'Sarhua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (552, 52, N'051012', N'Vilcanchos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (553, 53, N'051101', N'Vilcas Huaman')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (554, 53, N'051102', N'Accomarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (555, 53, N'051103', N'Carhuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (556, 53, N'051104', N'Concepción')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (557, 53, N'051105', N'Huambalpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (558, 53, N'051106', N'Independencia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (559, 53, N'051107', N'Saurama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (560, 53, N'051108', N'Vischongo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (561, 54, N'060101', N'Cajamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (562, 54, N'060102', N'Asunción')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (563, 54, N'060103', N'Chetilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (564, 54, N'060104', N'Cospan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (565, 54, N'060105', N'Encañada')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (566, 54, N'060106', N'Jesús')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (567, 54, N'060107', N'Llacanora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (568, 54, N'060108', N'Los Baños del Inca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (569, 54, N'060109', N'Magdalena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (570, 54, N'060110', N'Matara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (571, 54, N'060111', N'Namora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (572, 54, N'060112', N'San Juan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (573, 55, N'060201', N'Cajabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (574, 55, N'060202', N'Cachachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (575, 55, N'060203', N'Condebamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (576, 55, N'060204', N'Sitacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (577, 56, N'060301', N'Celendín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (578, 56, N'060302', N'Chumuch')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (579, 56, N'060303', N'Cortegana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (580, 56, N'060304', N'Huasmin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (581, 56, N'060305', N'Jorge Chávez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (582, 56, N'060306', N'José Gálvez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (583, 56, N'060307', N'Miguel Iglesias')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (584, 56, N'060308', N'Oxamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (585, 56, N'060309', N'Sorochuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (586, 56, N'060310', N'Sucre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (587, 56, N'060311', N'Utco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (588, 56, N'060312', N'La Libertad de Pallan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (589, 57, N'060401', N'Chota')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (590, 57, N'060402', N'Anguia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (591, 57, N'060403', N'Chadin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (592, 57, N'060404', N'Chiguirip')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (593, 57, N'060405', N'Chimban')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (594, 57, N'060406', N'Choropampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (595, 57, N'060407', N'Cochabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (596, 57, N'060408', N'Conchan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (597, 57, N'060409', N'Huambos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (598, 57, N'060410', N'Lajas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (599, 57, N'060411', N'Llama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (600, 57, N'060412', N'Miracosta')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (601, 57, N'060413', N'Paccha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (602, 57, N'060414', N'Pion')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (603, 57, N'060415', N'Querocoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (604, 57, N'060416', N'San Juan de Licupis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (605, 57, N'060417', N'Tacabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (606, 57, N'060418', N'Tocmoche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (607, 57, N'060419', N'Chalamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (608, 58, N'060501', N'Contumaza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (609, 58, N'060502', N'Chilete')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (610, 58, N'060503', N'Cupisnique')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (611, 58, N'060504', N'Guzmango')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (612, 58, N'060505', N'San Benito')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (613, 58, N'060506', N'Santa Cruz de Toledo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (614, 58, N'060507', N'Tantarica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (615, 58, N'060508', N'Yonan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (616, 59, N'060601', N'Cutervo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (617, 59, N'060602', N'Callayuc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (618, 59, N'060603', N'Choros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (619, 59, N'060604', N'Cujillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (620, 59, N'060605', N'La Ramada')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (621, 59, N'060606', N'Pimpingos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (622, 59, N'060607', N'Querocotillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (623, 59, N'060608', N'San Andrés de Cutervo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (624, 59, N'060609', N'San Juan de Cutervo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (625, 59, N'060610', N'San Luis de Lucma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (626, 59, N'060611', N'Santa Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (627, 59, N'060612', N'Santo Domingo de la Capilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (628, 59, N'060613', N'Santo Tomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (629, 59, N'060614', N'Socota')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (630, 59, N'060615', N'Toribio Casanova')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (631, 60, N'060701', N'Bambamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (632, 60, N'060702', N'Chugur')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (633, 60, N'060703', N'Hualgayoc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (634, 61, N'060801', N'Jaén')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (635, 61, N'060802', N'Bellavista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (636, 61, N'060803', N'Chontali')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (637, 61, N'060804', N'Colasay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (638, 61, N'060805', N'Huabal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (639, 61, N'060806', N'Las Pirias')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (640, 61, N'060807', N'Pomahuaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (641, 61, N'060808', N'Pucara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (642, 61, N'060809', N'Sallique')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (643, 61, N'060810', N'San Felipe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (644, 61, N'060811', N'San José del Alto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (645, 61, N'060812', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (646, 62, N'060901', N'San Ignacio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (647, 62, N'060902', N'Chirinos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (648, 62, N'060903', N'Huarango')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (649, 62, N'060904', N'La Coipa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (650, 62, N'060905', N'Namballe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (651, 62, N'060906', N'San José de Lourdes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (652, 62, N'060907', N'Tabaconas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (653, 63, N'061001', N'Pedro Gálvez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (654, 63, N'061002', N'Chancay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (655, 63, N'061003', N'Eduardo Villanueva')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (656, 63, N'061004', N'Gregorio Pita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (657, 63, N'061005', N'Ichocan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (658, 63, N'061006', N'José Manuel Quiroz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (659, 63, N'061007', N'José Sabogal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (660, 64, N'061101', N'San Miguel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (661, 64, N'061102', N'Bolívar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (662, 64, N'061103', N'Calquis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (663, 64, N'061104', N'Catilluc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (664, 64, N'061105', N'El Prado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (665, 64, N'061106', N'La Florida')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (666, 64, N'061107', N'Llapa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (667, 64, N'061108', N'Nanchoc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (668, 64, N'061109', N'Niepos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (669, 64, N'061110', N'San Gregorio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (670, 64, N'061111', N'San Silvestre de Cochan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (671, 64, N'061112', N'Tongod')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (672, 64, N'061113', N'Unión Agua Blanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (673, 65, N'061201', N'San Pablo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (674, 65, N'061202', N'San Bernardino')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (675, 65, N'061203', N'San Luis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (676, 65, N'061204', N'Tumbaden')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (677, 66, N'061301', N'Santa Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (678, 66, N'061302', N'Andabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (679, 66, N'061303', N'Catache')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (680, 66, N'061304', N'Chancaybaños')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (681, 66, N'061305', N'La Esperanza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (682, 66, N'061306', N'Ninabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (683, 66, N'061307', N'Pulan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (684, 66, N'061308', N'Saucepampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (685, 66, N'061309', N'Sexi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (686, 66, N'061310', N'Uticyacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (687, 66, N'061311', N'Yauyucan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (688, 67, N'070101', N'Callao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (689, 67, N'070102', N'Bellavista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (690, 67, N'070103', N'Carmen de la Legua Reynoso')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (691, 67, N'070104', N'La Perla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (692, 67, N'070105', N'La Punta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (693, 67, N'070106', N'Ventanilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (694, 67, N'070107', N'Mi Perú')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (695, 68, N'080101', N'Cusco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (696, 68, N'080102', N'Ccorca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (697, 68, N'080103', N'Poroy')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (698, 68, N'080104', N'San Jerónimo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (699, 68, N'080105', N'San Sebastian')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (700, 68, N'080106', N'Santiago')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (701, 68, N'080107', N'Saylla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (702, 68, N'080108', N'Wanchaq')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (703, 69, N'080201', N'Acomayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (704, 69, N'080202', N'Acopia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (705, 69, N'080203', N'Acos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (706, 69, N'080204', N'Mosoc Llacta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (707, 69, N'080205', N'Pomacanchi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (708, 69, N'080206', N'Rondocan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (709, 69, N'080207', N'Sangarara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (710, 70, N'080301', N'Anta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (711, 70, N'080302', N'Ancahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (712, 70, N'080303', N'Cachimayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (713, 70, N'080304', N'Chinchaypujio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (714, 70, N'080305', N'Huarocondo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (715, 70, N'080306', N'Limatambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (716, 70, N'080307', N'Mollepata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (717, 70, N'080308', N'Pucyura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (718, 70, N'080309', N'Zurite')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (719, 71, N'080401', N'Calca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (720, 71, N'080402', N'Coya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (721, 71, N'080403', N'Lamay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (722, 71, N'080404', N'Lares')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (723, 71, N'080405', N'Pisac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (724, 71, N'080406', N'San Salvador')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (725, 71, N'080407', N'Taray')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (726, 71, N'080408', N'Yanatile')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (727, 72, N'080501', N'Yanaoca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (728, 72, N'080502', N'Checca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (729, 72, N'080503', N'Kunturkanki')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (730, 72, N'080504', N'Langui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (731, 72, N'080505', N'Layo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (732, 72, N'080506', N'Pampamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (733, 72, N'080507', N'Quehue')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (734, 72, N'080508', N'Tupac Amaru')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (735, 73, N'080601', N'Sicuani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (736, 73, N'080602', N'Checacupe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (737, 73, N'080603', N'Combapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (738, 73, N'080604', N'Marangani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (739, 73, N'080605', N'Pitumarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (740, 73, N'080606', N'San Pablo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (741, 73, N'080607', N'San Pedro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (742, 73, N'080608', N'Tinta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (743, 74, N'080701', N'Santo Tomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (744, 74, N'080702', N'Capacmarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (745, 74, N'080703', N'Chamaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (746, 74, N'080704', N'Colquemarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (747, 74, N'080705', N'Livitaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (748, 74, N'080706', N'Llusco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (749, 74, N'080707', N'Quiñota')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (750, 74, N'080708', N'Velille')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (751, 75, N'080801', N'Espinar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (752, 75, N'080802', N'Condoroma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (753, 75, N'080803', N'Coporaque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (754, 75, N'080804', N'Ocoruro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (755, 75, N'080805', N'Pallpata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (756, 75, N'080806', N'Pichigua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (757, 75, N'080807', N'Suyckutambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (758, 75, N'080808', N'Alto Pichigua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (759, 76, N'080901', N'Santa Ana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (760, 76, N'080902', N'Echarate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (761, 76, N'080903', N'Huayopata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (762, 76, N'080904', N'Maranura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (763, 76, N'080905', N'Ocobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (764, 76, N'080906', N'Quellouno')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (765, 76, N'080907', N'Kimbiri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (766, 76, N'080908', N'Santa Teresa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (767, 76, N'080909', N'Vilcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (768, 76, N'080910', N'Pichari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (769, 76, N'080911', N'Inkawasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (770, 76, N'080912', N'Villa Virgen')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (771, 76, N'080913', N'Villa Kintiarina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (772, 77, N'081001', N'Paruro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (773, 77, N'081002', N'Accha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (774, 77, N'081003', N'Ccapi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (775, 77, N'081004', N'Colcha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (776, 77, N'081005', N'Huanoquite')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (777, 77, N'081006', N'Omacha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (778, 77, N'081007', N'Paccaritambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (779, 77, N'081008', N'Pillpinto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (780, 77, N'081009', N'Yaurisque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (781, 78, N'081101', N'Paucartambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (782, 78, N'081102', N'Caicay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (783, 78, N'081103', N'Challabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (784, 78, N'081104', N'Colquepata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (785, 78, N'081105', N'Huancarani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (786, 78, N'081106', N'Kosñipata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (787, 79, N'081201', N'Urcos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (788, 79, N'081202', N'Andahuaylillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (789, 79, N'081203', N'Camanti')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (790, 79, N'081204', N'Ccarhuayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (791, 79, N'081205', N'Ccatca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (792, 79, N'081206', N'Cusipata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (793, 79, N'081207', N'Huaro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (794, 79, N'081208', N'Lucre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (795, 79, N'081209', N'Marcapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (796, 79, N'081210', N'Ocongate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (797, 79, N'081211', N'Oropesa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (798, 79, N'081212', N'Quiquijana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (799, 80, N'081301', N'Urubamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (800, 80, N'081302', N'Chinchero')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (801, 80, N'081303', N'Huayllabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (802, 80, N'081304', N'Machupicchu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (803, 80, N'081305', N'Maras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (804, 80, N'081306', N'Ollantaytambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (805, 80, N'081307', N'Yucay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (806, 81, N'090101', N'Huancavelica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (807, 81, N'090102', N'Acobambilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (808, 81, N'090103', N'Acoria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (809, 81, N'090104', N'Conayca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (810, 81, N'090105', N'Cuenca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (811, 81, N'090106', N'Huachocolpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (812, 81, N'090107', N'Huayllahuara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (813, 81, N'090108', N'Izcuchaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (814, 81, N'090109', N'Laria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (815, 81, N'090110', N'Manta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (816, 81, N'090111', N'Mariscal Cáceres')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (817, 81, N'090112', N'Moya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (818, 81, N'090113', N'Nuevo Occoro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (819, 81, N'090114', N'Palca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (820, 81, N'090115', N'Pilchaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (821, 81, N'090116', N'Vilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (822, 81, N'090117', N'Yauli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (823, 81, N'090118', N'Ascensión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (824, 81, N'090119', N'Huando')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (825, 82, N'090201', N'Acobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (826, 82, N'090202', N'Andabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (827, 82, N'090203', N'Anta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (828, 82, N'090204', N'Caja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (829, 82, N'090205', N'Marcas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (830, 82, N'090206', N'Paucara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (831, 82, N'090207', N'Pomacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (832, 82, N'090208', N'Rosario')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (833, 83, N'090301', N'Lircay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (834, 83, N'090302', N'Anchonga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (835, 83, N'090303', N'Callanmarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (836, 83, N'090304', N'Ccochaccasa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (837, 83, N'090305', N'Chincho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (838, 83, N'090306', N'Congalla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (839, 83, N'090307', N'Huanca-Huanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (840, 83, N'090308', N'Huayllay Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (841, 83, N'090309', N'Julcamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (842, 83, N'090310', N'San Antonio de Antaparco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (843, 83, N'090311', N'Santo Tomas de Pata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (844, 83, N'090312', N'Secclla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (845, 84, N'090401', N'Castrovirreyna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (846, 84, N'090402', N'Arma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (847, 84, N'090403', N'Aurahua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (848, 84, N'090404', N'Capillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (849, 84, N'090405', N'Chupamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (850, 84, N'090406', N'Cocas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (851, 84, N'090407', N'Huachos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (852, 84, N'090408', N'Huamatambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (853, 84, N'090409', N'Mollepampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (854, 84, N'090410', N'San Juan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (855, 84, N'090411', N'Santa Ana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (856, 84, N'090412', N'Tantara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (857, 84, N'090413', N'Ticrapo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (858, 85, N'090501', N'Churcampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (859, 85, N'090502', N'Anco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (860, 85, N'090503', N'Chinchihuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (861, 85, N'090504', N'El Carmen')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (862, 85, N'090505', N'La Merced')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (863, 85, N'090506', N'Locroja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (864, 85, N'090507', N'Paucarbamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (865, 85, N'090508', N'San Miguel de Mayocc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (866, 85, N'090509', N'San Pedro de Coris')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (867, 85, N'090510', N'Pachamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (868, 85, N'090511', N'Cosme')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (869, 86, N'090601', N'Huaytara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (870, 86, N'090602', N'Ayavi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (871, 86, N'090603', N'Córdova')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (872, 86, N'090604', N'Huayacundo Arma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (873, 86, N'090605', N'Laramarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (874, 86, N'090606', N'Ocoyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (875, 86, N'090607', N'Pilpichaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (876, 86, N'090608', N'Querco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (877, 86, N'090609', N'Quito-Arma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (878, 86, N'090610', N'San Antonio de Cusicancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (879, 86, N'090611', N'San Francisco de Sangayaico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (880, 86, N'090612', N'San Isidro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (881, 86, N'090613', N'Santiago de Chocorvos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (882, 86, N'090614', N'Santiago de Quirahuara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (883, 86, N'090615', N'Santo Domingo de Capillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (884, 86, N'090616', N'Tambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (885, 87, N'090701', N'Pampas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (886, 87, N'090702', N'Acostambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (887, 87, N'090703', N'Acraquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (888, 87, N'090704', N'Ahuaycha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (889, 87, N'090705', N'Colcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (890, 87, N'090706', N'Daniel Hernández')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (891, 87, N'090707', N'Huachocolpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (892, 87, N'090709', N'Huaribamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (893, 87, N'090710', N'Ñahuimpuquio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (894, 87, N'090711', N'Pazos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (895, 87, N'090713', N'Quishuar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (896, 87, N'090714', N'Salcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (897, 87, N'090715', N'Salcahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (898, 87, N'090716', N'San Marcos de Rocchac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (899, 87, N'090717', N'Surcubamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (900, 87, N'090718', N'Tintay Puncu')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (901, 87, N'090719', N'Quichuas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (902, 87, N'090720', N'Andaymarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (903, 87, N'090721', N'Roble')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (904, 87, N'090722', N'Pichos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (905, 88, N'100101', N'Huanuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (906, 88, N'100102', N'Amarilis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (907, 88, N'100103', N'Chinchao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (908, 88, N'100104', N'Churubamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (909, 88, N'100105', N'Margos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (910, 88, N'100106', N'Quisqui (Kichki)')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (911, 88, N'100107', N'San Francisco de Cayran')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (912, 88, N'100108', N'San Pedro de Chaulan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (913, 88, N'100109', N'Santa María del Valle')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (914, 88, N'100110', N'Yarumayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (915, 88, N'100111', N'Pillco Marca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (916, 88, N'100112', N'Yacus')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (917, 88, N'100113', N'San Pablo de Pillao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (918, 89, N'100201', N'Ambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (919, 89, N'100202', N'Cayna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (920, 89, N'100203', N'Colpas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (921, 89, N'100204', N'Conchamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (922, 89, N'100205', N'Huacar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (923, 89, N'100206', N'San Francisco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (924, 89, N'100207', N'San Rafael')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (925, 89, N'100208', N'Tomay Kichwa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (926, 90, N'100301', N'La Unión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (927, 90, N'100307', N'Chuquis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (928, 90, N'100311', N'Marías')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (929, 90, N'100313', N'Pachas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (930, 90, N'100316', N'Quivilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (931, 90, N'100317', N'Ripan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (932, 90, N'100321', N'Shunqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (933, 90, N'100322', N'Sillapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (934, 90, N'100323', N'Yanas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (935, 91, N'100401', N'Huacaybamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (936, 91, N'100402', N'Canchabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (937, 91, N'100403', N'Cochabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (938, 91, N'100404', N'Pinra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (939, 92, N'100501', N'Llata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (940, 92, N'100502', N'Arancay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (941, 92, N'100503', N'Chavín de Pariarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (942, 92, N'100504', N'Jacas Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (943, 92, N'100505', N'Jircan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (944, 92, N'100506', N'Miraflores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (945, 92, N'100507', N'Monzón')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (946, 92, N'100508', N'Punchao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (947, 92, N'100509', N'Puños')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (948, 92, N'100510', N'Singa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (949, 92, N'100511', N'Tantamayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (950, 93, N'100601', N'Rupa-Rupa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (951, 93, N'100602', N'Daniel Alomía Robles')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (952, 93, N'100603', N'Hermílio Valdizan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (953, 93, N'100604', N'José Crespo y Castillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (954, 93, N'100605', N'Luyando')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (955, 93, N'100606', N'Mariano Damaso Beraun')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (956, 93, N'100607', N'Pucayacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (957, 93, N'100608', N'Castillo Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (958, 94, N'100701', N'Huacrachuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (959, 94, N'100702', N'Cholon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (960, 94, N'100703', N'San Buenaventura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (961, 94, N'100704', N'La Morada')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (962, 94, N'100705', N'Santa Rosa de Alto Yanajanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (963, 95, N'100801', N'Panao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (964, 95, N'100802', N'Chaglla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (965, 95, N'100803', N'Molino')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (966, 95, N'100804', N'Umari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (967, 96, N'100901', N'Puerto Inca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (968, 96, N'100902', N'Codo del Pozuzo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (969, 96, N'100903', N'Honoria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (970, 96, N'100904', N'Tournavista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (971, 96, N'100905', N'Yuyapichis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (972, 97, N'101001', N'Jesús')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (973, 97, N'101002', N'Baños')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (974, 97, N'101003', N'Jivia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (975, 97, N'101004', N'Queropalca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (976, 97, N'101005', N'Rondos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (977, 97, N'101006', N'San Francisco de Asís')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (978, 97, N'101007', N'San Miguel de Cauri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (979, 98, N'101101', N'Chavinillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (980, 98, N'101102', N'Cahuac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (981, 98, N'101103', N'Chacabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (982, 98, N'101104', N'Aparicio Pomares')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (983, 98, N'101105', N'Jacas Chico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (984, 98, N'101106', N'Obas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (985, 98, N'101107', N'Pampamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (986, 98, N'101108', N'Choras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (987, 99, N'110101', N'Ica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (988, 99, N'110102', N'La Tinguiña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (989, 99, N'110103', N'Los Aquijes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (990, 99, N'110104', N'Ocucaje')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (991, 99, N'110105', N'Pachacutec')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (992, 99, N'110106', N'Parcona')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (993, 99, N'110107', N'Pueblo Nuevo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (994, 99, N'110108', N'Salas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (995, 99, N'110109', N'San José de Los Molinos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (996, 99, N'110110', N'San Juan Bautista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (997, 99, N'110111', N'Santiago')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (998, 99, N'110112', N'Subtanjalla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (999, 99, N'110113', N'Tate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1000, 99, N'110114', N'Yauca del Rosario')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1001, 100, N'110201', N'Chincha Alta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1002, 100, N'110202', N'Alto Laran')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1003, 100, N'110203', N'Chavin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1004, 100, N'110204', N'Chincha Baja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1005, 100, N'110205', N'El Carmen')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1006, 100, N'110206', N'Grocio Prado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1007, 100, N'110207', N'Pueblo Nuevo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1008, 100, N'110208', N'San Juan de Yanac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1009, 100, N'110209', N'San Pedro de Huacarpana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1010, 100, N'110210', N'Sunampe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1011, 100, N'110211', N'Tambo de Mora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1012, 101, N'110301', N'Nasca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1013, 101, N'110302', N'Changuillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1014, 101, N'110303', N'El Ingenio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1015, 101, N'110304', N'Marcona')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1016, 101, N'110305', N'Vista Alegre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1017, 102, N'110401', N'Palpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1018, 102, N'110402', N'Llipata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1019, 102, N'110403', N'Río Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1020, 102, N'110404', N'Santa Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1021, 102, N'110405', N'Tibillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1022, 103, N'110501', N'Pisco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1023, 103, N'110502', N'Huancano')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1024, 103, N'110503', N'Humay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1025, 103, N'110504', N'Independencia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1026, 103, N'110505', N'Paracas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1027, 103, N'110506', N'San Andrés')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1028, 103, N'110507', N'San Clemente')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1029, 103, N'110508', N'Tupac Amaru Inca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1030, 104, N'120101', N'Huancayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1031, 104, N'120104', N'Carhuacallanga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1032, 104, N'120105', N'Chacapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1033, 104, N'120106', N'Chicche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1034, 104, N'120107', N'Chilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1035, 104, N'120108', N'Chongos Alto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1036, 104, N'120111', N'Chupuro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1037, 104, N'120112', N'Colca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1038, 104, N'120113', N'Cullhuas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1039, 104, N'120114', N'El Tambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1040, 104, N'120116', N'Huacrapuquio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1041, 104, N'120117', N'Hualhuas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1042, 104, N'120119', N'Huancan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1043, 104, N'120120', N'Huasicancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1044, 104, N'120121', N'Huayucachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1045, 104, N'120122', N'Ingenio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1046, 104, N'120124', N'Pariahuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1047, 104, N'120125', N'Pilcomayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1048, 104, N'120126', N'Pucara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1049, 104, N'120127', N'Quichuay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1050, 104, N'120128', N'Quilcas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1051, 104, N'120129', N'San Agustín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1052, 104, N'120130', N'San Jerónimo de Tunan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1053, 104, N'120132', N'Saño')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1054, 104, N'120133', N'Sapallanga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1055, 104, N'120134', N'Sicaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1056, 104, N'120135', N'Santo Domingo de Acobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1057, 104, N'120136', N'Viques')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1058, 105, N'120201', N'Concepción')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1059, 105, N'120202', N'Aco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1060, 105, N'120203', N'Andamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1061, 105, N'120204', N'Chambara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1062, 105, N'120205', N'Cochas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1063, 105, N'120206', N'Comas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1064, 105, N'120207', N'Heroínas Toledo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1065, 105, N'120208', N'Manzanares')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1066, 105, N'120209', N'Mariscal Castilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1067, 105, N'120210', N'Matahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1068, 105, N'120211', N'Mito')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1069, 105, N'120212', N'Nueve de Julio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1070, 105, N'120213', N'Orcotuna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1071, 105, N'120214', N'San José de Quero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1072, 105, N'120215', N'Santa Rosa de Ocopa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1073, 106, N'120301', N'Chanchamayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1074, 106, N'120302', N'Perene')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1075, 106, N'120303', N'Pichanaqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1076, 106, N'120304', N'San Luis de Shuaro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1077, 106, N'120305', N'San Ramón')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1078, 106, N'120306', N'Vitoc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1079, 107, N'120401', N'Jauja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1080, 107, N'120402', N'Acolla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1081, 107, N'120403', N'Apata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1082, 107, N'120404', N'Ataura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1083, 107, N'120405', N'Canchayllo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1084, 107, N'120406', N'Curicaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1085, 107, N'120407', N'El Mantaro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1086, 107, N'120408', N'Huamali')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1087, 107, N'120409', N'Huaripampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1088, 107, N'120410', N'Huertas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1089, 107, N'120411', N'Janjaillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1090, 107, N'120412', N'Julcán')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1091, 107, N'120413', N'Leonor Ordóñez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1092, 107, N'120414', N'Llocllapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1093, 107, N'120415', N'Marco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1094, 107, N'120416', N'Masma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1095, 107, N'120417', N'Masma Chicche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1096, 107, N'120418', N'Molinos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1097, 107, N'120419', N'Monobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1098, 107, N'120420', N'Muqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1099, 107, N'120421', N'Muquiyauyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1100, 107, N'120422', N'Paca')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1101, 107, N'120423', N'Paccha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1102, 107, N'120424', N'Pancan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1103, 107, N'120425', N'Parco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1104, 107, N'120426', N'Pomacancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1105, 107, N'120427', N'Ricran')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1106, 107, N'120428', N'San Lorenzo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1107, 107, N'120429', N'San Pedro de Chunan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1108, 107, N'120430', N'Sausa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1109, 107, N'120431', N'Sincos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1110, 107, N'120432', N'Tunan Marca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1111, 107, N'120433', N'Yauli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1112, 107, N'120434', N'Yauyos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1113, 108, N'120501', N'Junin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1114, 108, N'120502', N'Carhuamayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1115, 108, N'120503', N'Ondores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1116, 108, N'120504', N'Ulcumayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1117, 109, N'120601', N'Satipo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1118, 109, N'120602', N'Coviriali')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1119, 109, N'120603', N'Llaylla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1120, 109, N'120604', N'Mazamari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1121, 109, N'120605', N'Pampa Hermosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1122, 109, N'120606', N'Pangoa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1123, 109, N'120607', N'Río Negro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1124, 109, N'120608', N'Río Tambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1125, 109, N'120609', N'Vizcatan del Ene')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1126, 110, N'120701', N'Tarma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1127, 110, N'120702', N'Acobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1128, 110, N'120703', N'Huaricolca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1129, 110, N'120704', N'Huasahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1130, 110, N'120705', N'La Unión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1131, 110, N'120706', N'Palca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1132, 110, N'120707', N'Palcamayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1133, 110, N'120708', N'San Pedro de Cajas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1134, 110, N'120709', N'Tapo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1135, 111, N'120801', N'La Oroya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1136, 111, N'120802', N'Chacapalpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1137, 111, N'120803', N'Huay-Huay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1138, 111, N'120804', N'Marcapomacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1139, 111, N'120805', N'Morococha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1140, 111, N'120806', N'Paccha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1141, 111, N'120807', N'Santa Bárbara de Carhuacayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1142, 111, N'120808', N'Santa Rosa de Sacco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1143, 111, N'120809', N'Suitucancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1144, 111, N'120810', N'Yauli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1145, 112, N'120901', N'Chupaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1146, 112, N'120902', N'Ahuac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1147, 112, N'120903', N'Chongos Bajo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1148, 112, N'120904', N'Huachac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1149, 112, N'120905', N'Huamancaca Chico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1150, 112, N'120906', N'San Juan de Iscos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1151, 112, N'120907', N'San Juan de Jarpa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1152, 112, N'120908', N'Tres de Diciembre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1153, 112, N'120909', N'Yanacancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1154, 113, N'130101', N'Trujillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1155, 113, N'130102', N'El Porvenir')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1156, 113, N'130103', N'Florencia de Mora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1157, 113, N'130104', N'Huanchaco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1158, 113, N'130105', N'La Esperanza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1159, 113, N'130106', N'Laredo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1160, 113, N'130107', N'Moche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1161, 113, N'130108', N'Poroto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1162, 113, N'130109', N'Salaverry')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1163, 113, N'130110', N'Simbal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1164, 113, N'130111', N'Victor Larco Herrera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1165, 114, N'130201', N'Ascope')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1166, 114, N'130202', N'Chicama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1167, 114, N'130203', N'Chocope')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1168, 114, N'130204', N'Magdalena de Cao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1169, 114, N'130205', N'Paijan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1170, 114, N'130206', N'Rázuri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1171, 114, N'130207', N'Santiago de Cao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1172, 114, N'130208', N'Casa Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1173, 115, N'130301', N'Bolívar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1174, 115, N'130302', N'Bambamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1175, 115, N'130303', N'Condormarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1176, 115, N'130304', N'Longotea')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1177, 115, N'130305', N'Uchumarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1178, 115, N'130306', N'Ucuncha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1179, 116, N'130401', N'Chepen')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1180, 116, N'130402', N'Pacanga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1181, 116, N'130403', N'Pueblo Nuevo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1182, 117, N'130501', N'Julcan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1183, 117, N'130502', N'Calamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1184, 117, N'130503', N'Carabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1185, 117, N'130504', N'Huaso')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1186, 118, N'130601', N'Otuzco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1187, 118, N'130602', N'Agallpampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1188, 118, N'130604', N'Charat')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1189, 118, N'130605', N'Huaranchal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1190, 118, N'130606', N'La Cuesta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1191, 118, N'130608', N'Mache')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1192, 118, N'130610', N'Paranday')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1193, 118, N'130611', N'Salpo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1194, 118, N'130613', N'Sinsicap')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1195, 118, N'130614', N'Usquil')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1196, 119, N'130701', N'San Pedro de Lloc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1197, 119, N'130702', N'Guadalupe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1198, 119, N'130703', N'Jequetepeque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1199, 119, N'130704', N'Pacasmayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1200, 119, N'130705', N'San José')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1201, 120, N'130801', N'Tayabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1202, 120, N'130802', N'Buldibuyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1203, 120, N'130803', N'Chillia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1204, 120, N'130804', N'Huancaspata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1205, 120, N'130805', N'Huaylillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1206, 120, N'130806', N'Huayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1207, 120, N'130807', N'Ongon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1208, 120, N'130808', N'Parcoy')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1209, 120, N'130809', N'Pataz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1210, 120, N'130810', N'Pias')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1211, 120, N'130811', N'Santiago de Challas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1212, 120, N'130812', N'Taurija')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1213, 120, N'130813', N'Urpay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1214, 121, N'130901', N'Huamachuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1215, 121, N'130902', N'Chugay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1216, 121, N'130903', N'Cochorco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1217, 121, N'130904', N'Curgos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1218, 121, N'130905', N'Marcabal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1219, 121, N'130906', N'Sanagoran')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1220, 121, N'130907', N'Sarin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1221, 121, N'130908', N'Sartimbamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1222, 122, N'131001', N'Santiago de Chuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1223, 122, N'131002', N'Angasmarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1224, 122, N'131003', N'Cachicadan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1225, 122, N'131004', N'Mollebamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1226, 122, N'131005', N'Mollepata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1227, 122, N'131006', N'Quiruvilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1228, 122, N'131007', N'Santa Cruz de Chuca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1229, 122, N'131008', N'Sitabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1230, 123, N'131101', N'Cascas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1231, 123, N'131102', N'Lucma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1232, 123, N'131103', N'Marmot')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1233, 123, N'131104', N'Sayapullo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1234, 124, N'131201', N'Viru')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1235, 124, N'131202', N'Chao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1236, 124, N'131203', N'Guadalupito')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1237, 125, N'140101', N'Chiclayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1238, 125, N'140102', N'Chongoyape')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1239, 125, N'140103', N'Eten')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1240, 125, N'140104', N'Eten Puerto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1241, 125, N'140105', N'José Leonardo Ortiz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1242, 125, N'140106', N'La Victoria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1243, 125, N'140107', N'Lagunas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1244, 125, N'140108', N'Monsefu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1245, 125, N'140109', N'Nueva Arica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1246, 125, N'140110', N'Oyotun')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1247, 125, N'140111', N'Picsi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1248, 125, N'140112', N'Pimentel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1249, 125, N'140113', N'Reque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1250, 125, N'140114', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1251, 125, N'140115', N'Saña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1252, 125, N'140116', N'Cayalti')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1253, 125, N'140117', N'Patapo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1254, 125, N'140118', N'Pomalca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1255, 125, N'140119', N'Pucala')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1256, 125, N'140120', N'Tuman')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1257, 126, N'140201', N'Ferreñafe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1258, 126, N'140202', N'Cañaris')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1259, 126, N'140203', N'Incahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1260, 126, N'140204', N'Manuel Antonio Mesones Muro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1261, 126, N'140205', N'Pitipo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1262, 126, N'140206', N'Pueblo Nuevo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1263, 127, N'140301', N'Lambayeque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1264, 127, N'140302', N'Chochope')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1265, 127, N'140303', N'Illimo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1266, 127, N'140304', N'Jayanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1267, 127, N'140305', N'Mochumi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1268, 127, N'140306', N'Morrope')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1269, 127, N'140307', N'Motupe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1270, 127, N'140308', N'Olmos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1271, 127, N'140309', N'Pacora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1272, 127, N'140310', N'Salas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1273, 127, N'140311', N'San José')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1274, 127, N'140312', N'Tucume')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1275, 128, N'150101', N'Lima')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1276, 128, N'150102', N'Ancón')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1277, 128, N'150103', N'Ate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1278, 128, N'150104', N'Barranco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1279, 128, N'150105', N'Breña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1280, 128, N'150106', N'Carabayllo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1281, 128, N'150107', N'Chaclacayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1282, 128, N'150108', N'Chorrillos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1283, 128, N'150109', N'Cieneguilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1284, 128, N'150110', N'Comas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1285, 128, N'150111', N'El Agustino')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1286, 128, N'150112', N'Independencia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1287, 128, N'150113', N'Jesús María')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1288, 128, N'150114', N'La Molina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1289, 128, N'150115', N'La Victoria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1290, 128, N'150116', N'Lince')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1291, 128, N'150117', N'Los Olivos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1292, 128, N'150118', N'Lurigancho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1293, 128, N'150119', N'Lurin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1294, 128, N'150120', N'Magdalena del Mar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1295, 128, N'150121', N'Pueblo Libre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1296, 128, N'150122', N'Miraflores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1297, 128, N'150123', N'Pachacamac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1298, 128, N'150124', N'Pucusana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1299, 128, N'150125', N'Puente Piedra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1300, 128, N'150126', N'Punta Hermosa')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1301, 128, N'150127', N'Punta Negra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1302, 128, N'150128', N'Rímac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1303, 128, N'150129', N'San Bartolo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1304, 128, N'150130', N'San Borja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1305, 128, N'150131', N'San Isidro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1306, 128, N'150132', N'San Juan de Lurigancho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1307, 128, N'150133', N'San Juan de Miraflores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1308, 128, N'150134', N'San Luis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1309, 128, N'150135', N'San Martín de Porres')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1310, 128, N'150136', N'San Miguel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1311, 128, N'150137', N'Santa Anita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1312, 128, N'150138', N'Santa María del Mar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1313, 128, N'150139', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1314, 128, N'150140', N'Santiago de Surco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1315, 128, N'150141', N'Surquillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1316, 128, N'150142', N'Villa El Salvador')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1317, 128, N'150143', N'Villa María del Triunfo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1318, 129, N'150201', N'Barranca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1319, 129, N'150202', N'Paramonga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1320, 129, N'150203', N'Pativilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1321, 129, N'150204', N'Supe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1322, 129, N'150205', N'Supe Puerto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1323, 130, N'150301', N'Cajatambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1324, 130, N'150302', N'Copa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1325, 130, N'150303', N'Gorgor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1326, 130, N'150304', N'Huancapon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1327, 130, N'150305', N'Manas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1328, 131, N'150401', N'Canta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1329, 131, N'150402', N'Arahuay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1330, 131, N'150403', N'Huamantanga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1331, 131, N'150404', N'Huaros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1332, 131, N'150405', N'Lachaqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1333, 131, N'150406', N'San Buenaventura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1334, 131, N'150407', N'Santa Rosa de Quives')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1335, 132, N'150501', N'San Vicente de Cañete')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1336, 132, N'150502', N'Asia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1337, 132, N'150503', N'Calango')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1338, 132, N'150504', N'Cerro Azul')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1339, 132, N'150505', N'Chilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1340, 132, N'150506', N'Coayllo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1341, 132, N'150507', N'Imperial')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1342, 132, N'150508', N'Lunahuana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1343, 132, N'150509', N'Mala')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1344, 132, N'150510', N'Nuevo Imperial')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1345, 132, N'150511', N'Pacaran')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1346, 132, N'150512', N'Quilmana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1347, 132, N'150513', N'San Antonio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1348, 132, N'150514', N'San Luis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1349, 132, N'150515', N'Santa Cruz de Flores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1350, 132, N'150516', N'Zúñiga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1351, 133, N'150601', N'Huaral')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1352, 133, N'150602', N'Atavillos Alto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1353, 133, N'150603', N'Atavillos Bajo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1354, 133, N'150604', N'Aucallama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1355, 133, N'150605', N'Chancay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1356, 133, N'150606', N'Ihuari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1357, 133, N'150607', N'Lampian')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1358, 133, N'150608', N'Pacaraos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1359, 133, N'150609', N'San Miguel de Acos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1360, 133, N'150610', N'Santa Cruz de Andamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1361, 133, N'150611', N'Sumbilca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1362, 133, N'150612', N'Veintisiete de Noviembre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1363, 134, N'150701', N'Matucana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1364, 134, N'150702', N'Antioquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1365, 134, N'150703', N'Callahuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1366, 134, N'150704', N'Carampoma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1367, 134, N'150705', N'Chicla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1368, 134, N'150706', N'Cuenca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1369, 134, N'150707', N'Huachupampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1370, 134, N'150708', N'Huanza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1371, 134, N'150709', N'Huarochiri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1372, 134, N'150710', N'Lahuaytambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1373, 134, N'150711', N'Langa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1374, 134, N'150712', N'Laraos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1375, 134, N'150713', N'Mariatana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1376, 134, N'150714', N'Ricardo Palma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1377, 134, N'150715', N'San Andrés de Tupicocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1378, 134, N'150716', N'San Antonio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1379, 134, N'150717', N'San Bartolomé')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1380, 134, N'150718', N'San Damian')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1381, 134, N'150719', N'San Juan de Iris')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1382, 134, N'150720', N'San Juan de Tantaranche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1383, 134, N'150721', N'San Lorenzo de Quinti')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1384, 134, N'150722', N'San Mateo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1385, 134, N'150723', N'San Mateo de Otao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1386, 134, N'150724', N'San Pedro de Casta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1387, 134, N'150725', N'San Pedro de Huancayre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1388, 134, N'150726', N'Sangallaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1389, 134, N'150727', N'Santa Cruz de Cocachacra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1390, 134, N'150728', N'Santa Eulalia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1391, 134, N'150729', N'Santiago de Anchucaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1392, 134, N'150730', N'Santiago de Tuna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1393, 134, N'150731', N'Santo Domingo de Los Olleros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1394, 134, N'150732', N'Surco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1395, 135, N'150801', N'Huacho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1396, 135, N'150802', N'Ambar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1397, 135, N'150803', N'Caleta de Carquin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1398, 135, N'150804', N'Checras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1399, 135, N'150805', N'Hualmay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1400, 135, N'150806', N'Huaura')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1401, 135, N'150807', N'Leoncio Prado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1402, 135, N'150808', N'Paccho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1403, 135, N'150809', N'Santa Leonor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1404, 135, N'150810', N'Santa María')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1405, 135, N'150811', N'Sayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1406, 135, N'150812', N'Vegueta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1407, 136, N'150901', N'Oyon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1408, 136, N'150902', N'Andajes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1409, 136, N'150903', N'Caujul')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1410, 136, N'150904', N'Cochamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1411, 136, N'150905', N'Navan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1412, 136, N'150906', N'Pachangara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1413, 137, N'151001', N'Yauyos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1414, 137, N'151002', N'Alis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1415, 137, N'151003', N'Allauca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1416, 137, N'151004', N'Ayaviri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1417, 137, N'151005', N'Azángaro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1418, 137, N'151006', N'Cacra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1419, 137, N'151007', N'Carania')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1420, 137, N'151008', N'Catahuasi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1421, 137, N'151009', N'Chocos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1422, 137, N'151010', N'Cochas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1423, 137, N'151011', N'Colonia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1424, 137, N'151012', N'Hongos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1425, 137, N'151013', N'Huampara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1426, 137, N'151014', N'Huancaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1427, 137, N'151015', N'Huangascar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1428, 137, N'151016', N'Huantan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1429, 137, N'151017', N'Huañec')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1430, 137, N'151018', N'Laraos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1431, 137, N'151019', N'Lincha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1432, 137, N'151020', N'Madean')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1433, 137, N'151021', N'Miraflores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1434, 137, N'151022', N'Omas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1435, 137, N'151023', N'Putinza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1436, 137, N'151024', N'Quinches')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1437, 137, N'151025', N'Quinocay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1438, 137, N'151026', N'San Joaquín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1439, 137, N'151027', N'San Pedro de Pilas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1440, 137, N'151028', N'Tanta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1441, 137, N'151029', N'Tauripampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1442, 137, N'151030', N'Tomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1443, 137, N'151031', N'Tupe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1444, 137, N'151032', N'Viñac')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1445, 137, N'151033', N'Vitis')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1446, 138, N'160101', N'Iquitos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1447, 138, N'160102', N'Alto Nanay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1448, 138, N'160103', N'Fernando Lores')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1449, 138, N'160104', N'Indiana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1450, 138, N'160105', N'Las Amazonas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1451, 138, N'160106', N'Mazan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1452, 138, N'160107', N'Napo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1453, 138, N'160108', N'Punchana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1454, 138, N'160110', N'Torres Causana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1455, 138, N'160112', N'Belén')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1456, 138, N'160113', N'San Juan Bautista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1457, 139, N'160201', N'Yurimaguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1458, 139, N'160202', N'Balsapuerto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1459, 139, N'160205', N'Jeberos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1460, 139, N'160206', N'Lagunas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1461, 139, N'160210', N'Santa Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1462, 139, N'160211', N'Teniente Cesar López Rojas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1463, 140, N'160301', N'Nauta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1464, 140, N'160302', N'Parinari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1465, 140, N'160303', N'Tigre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1466, 140, N'160304', N'Trompeteros')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1467, 140, N'160305', N'Urarinas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1468, 141, N'160401', N'Ramón Castilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1469, 141, N'160402', N'Pebas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1470, 141, N'160403', N'Yavari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1471, 141, N'160404', N'San Pablo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1472, 142, N'160501', N'Requena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1473, 142, N'160502', N'Alto Tapiche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1474, 142, N'160503', N'Capelo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1475, 142, N'160504', N'Emilio San Martín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1476, 142, N'160505', N'Maquia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1477, 142, N'160506', N'Puinahua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1478, 142, N'160507', N'Saquena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1479, 142, N'160508', N'Soplin')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1480, 142, N'160509', N'Tapiche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1481, 142, N'160510', N'Jenaro Herrera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1482, 142, N'160511', N'Yaquerana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1483, 143, N'160601', N'Contamana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1484, 143, N'160602', N'Inahuaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1485, 143, N'160603', N'Padre Márquez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1486, 143, N'160604', N'Pampa Hermosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1487, 143, N'160605', N'Sarayacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1488, 143, N'160606', N'Vargas Guerra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1489, 144, N'160701', N'Barranca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1490, 144, N'160702', N'Cahuapanas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1491, 144, N'160703', N'Manseriche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1492, 144, N'160704', N'Morona')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1493, 144, N'160705', N'Pastaza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1494, 144, N'160706', N'Andoas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1495, 145, N'160801', N'Putumayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1496, 145, N'160802', N'Rosa Panduro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1497, 145, N'160803', N'Teniente Manuel Clavero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1498, 145, N'160804', N'Yaguas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1499, 146, N'170101', N'Tambopata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1500, 146, N'170102', N'Inambari')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1501, 146, N'170103', N'Las Piedras')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1502, 146, N'170104', N'Laberinto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1503, 147, N'170201', N'Manu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1504, 147, N'170202', N'Fitzcarrald')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1505, 147, N'170203', N'Madre de Dios')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1506, 147, N'170204', N'Huepetuhe')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1507, 148, N'170301', N'Iñapari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1508, 148, N'170302', N'Iberia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1509, 148, N'170303', N'Tahuamanu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1510, 149, N'180101', N'Moquegua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1511, 149, N'180102', N'Carumas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1512, 149, N'180103', N'Cuchumbaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1513, 149, N'180104', N'Samegua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1514, 149, N'180105', N'San Cristóbal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1515, 149, N'180106', N'Torata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1516, 150, N'180201', N'Omate')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1517, 150, N'180202', N'Chojata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1518, 150, N'180203', N'Coalaque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1519, 150, N'180204', N'Ichuña')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1520, 150, N'180205', N'La Capilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1521, 150, N'180206', N'Lloque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1522, 150, N'180207', N'Matalaque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1523, 150, N'180208', N'Puquina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1524, 150, N'180209', N'Quinistaquillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1525, 150, N'180210', N'Ubinas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1526, 150, N'180211', N'Yunga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1527, 151, N'180301', N'Ilo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1528, 151, N'180302', N'El Algarrobal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1529, 151, N'180303', N'Pacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1530, 152, N'190101', N'Chaupimarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1531, 152, N'190102', N'Huachon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1532, 152, N'190103', N'Huariaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1533, 152, N'190104', N'Huayllay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1534, 152, N'190105', N'Ninacaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1535, 152, N'190106', N'Pallanchacra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1536, 152, N'190107', N'Paucartambo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1537, 152, N'190108', N'San Francisco de Asís de Yarusyacan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1538, 152, N'190109', N'Simon Bolívar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1539, 152, N'190110', N'Ticlacayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1540, 152, N'190111', N'Tinyahuarco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1541, 152, N'190112', N'Vicco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1542, 152, N'190113', N'Yanacancha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1543, 153, N'190201', N'Yanahuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1544, 153, N'190202', N'Chacayan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1545, 153, N'190203', N'Goyllarisquizga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1546, 153, N'190204', N'Paucar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1547, 153, N'190205', N'San Pedro de Pillao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1548, 153, N'190206', N'Santa Ana de Tusi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1549, 153, N'190207', N'Tapuc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1550, 153, N'190208', N'Vilcabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1551, 154, N'190301', N'Oxapampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1552, 154, N'190302', N'Chontabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1553, 154, N'190303', N'Huancabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1554, 154, N'190304', N'Palcazu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1555, 154, N'190305', N'Pozuzo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1556, 154, N'190306', N'Puerto Bermúdez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1557, 154, N'190307', N'Villa Rica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1558, 154, N'190308', N'Constitución')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1559, 155, N'200101', N'Piura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1560, 155, N'200104', N'Castilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1561, 155, N'200105', N'Catacaos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1562, 155, N'200107', N'Cura Mori')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1563, 155, N'200108', N'El Tallan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1564, 155, N'200109', N'La Arena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1565, 155, N'200110', N'La Unión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1566, 155, N'200111', N'Las Lomas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1567, 155, N'200114', N'Tambo Grande')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1568, 155, N'200115', N'Veintiseis de Octubre')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1569, 156, N'200201', N'Ayabaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1570, 156, N'200202', N'Frias')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1571, 156, N'200203', N'Jilili')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1572, 156, N'200204', N'Lagunas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1573, 156, N'200205', N'Montero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1574, 156, N'200206', N'Pacaipampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1575, 156, N'200207', N'Paimas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1576, 156, N'200208', N'Sapillica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1577, 156, N'200209', N'Sicchez')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1578, 156, N'200210', N'Suyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1579, 157, N'200301', N'Huancabamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1580, 157, N'200302', N'Canchaque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1581, 157, N'200303', N'El Carmen de la Frontera')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1582, 157, N'200304', N'Huarmaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1583, 157, N'200305', N'Lalaquiz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1584, 157, N'200306', N'San Miguel de El Faique')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1585, 157, N'200307', N'Sondor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1586, 157, N'200308', N'Sondorillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1587, 158, N'200401', N'Chulucanas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1588, 158, N'200402', N'Buenos Aires')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1589, 158, N'200403', N'Chalaco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1590, 158, N'200404', N'La Matanza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1591, 158, N'200405', N'Morropon')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1592, 158, N'200406', N'Salitral')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1593, 158, N'200407', N'San Juan de Bigote')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1594, 158, N'200408', N'Santa Catalina de Mossa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1595, 158, N'200409', N'Santo Domingo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1596, 158, N'200410', N'Yamango')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1597, 159, N'200501', N'Paita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1598, 159, N'200502', N'Amotape')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1599, 159, N'200503', N'Arenal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1600, 159, N'200504', N'Colan')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1601, 159, N'200505', N'La Huaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1602, 159, N'200506', N'Tamarindo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1603, 159, N'200507', N'Vichayal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1604, 160, N'200601', N'Sullana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1605, 160, N'200602', N'Bellavista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1606, 160, N'200603', N'Ignacio Escudero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1607, 160, N'200604', N'Lancones')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1608, 160, N'200605', N'Marcavelica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1609, 160, N'200606', N'Miguel Checa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1610, 160, N'200607', N'Querecotillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1611, 160, N'200608', N'Salitral')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1612, 161, N'200701', N'Pariñas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1613, 161, N'200702', N'El Alto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1614, 161, N'200703', N'La Brea')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1615, 161, N'200704', N'Lobitos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1616, 161, N'200705', N'Los Organos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1617, 161, N'200706', N'Mancora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1618, 162, N'200801', N'Sechura')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1619, 162, N'200802', N'Bellavista de la Unión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1620, 162, N'200803', N'Bernal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1621, 162, N'200804', N'Cristo Nos Valga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1622, 162, N'200805', N'Vice')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1623, 162, N'200806', N'Rinconada Llicuar')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1624, 163, N'210101', N'Puno')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1625, 163, N'210102', N'Acora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1626, 163, N'210103', N'Amantani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1627, 163, N'210104', N'Atuncolla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1628, 163, N'210105', N'Capachica')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1629, 163, N'210106', N'Chucuito')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1630, 163, N'210107', N'Coata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1631, 163, N'210108', N'Huata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1632, 163, N'210109', N'Mañazo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1633, 163, N'210110', N'Paucarcolla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1634, 163, N'210111', N'Pichacani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1635, 163, N'210112', N'Plateria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1636, 163, N'210113', N'San Antonio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1637, 163, N'210114', N'Tiquillaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1638, 163, N'210115', N'Vilque')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1639, 164, N'210201', N'Azángaro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1640, 164, N'210202', N'Achaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1641, 164, N'210203', N'Arapa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1642, 164, N'210204', N'Asillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1643, 164, N'210205', N'Caminaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1644, 164, N'210206', N'Chupa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1645, 164, N'210207', N'José Domingo Choquehuanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1646, 164, N'210208', N'Muñani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1647, 164, N'210209', N'Potoni')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1648, 164, N'210210', N'Saman')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1649, 164, N'210211', N'San Anton')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1650, 164, N'210212', N'San José')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1651, 164, N'210213', N'San Juan de Salinas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1652, 164, N'210214', N'Santiago de Pupuja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1653, 164, N'210215', N'Tirapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1654, 165, N'210301', N'Macusani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1655, 165, N'210302', N'Ajoyani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1656, 165, N'210303', N'Ayapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1657, 165, N'210304', N'Coasa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1658, 165, N'210305', N'Corani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1659, 165, N'210306', N'Crucero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1660, 165, N'210307', N'Ituata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1661, 165, N'210308', N'Ollachea')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1662, 165, N'210309', N'San Gaban')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1663, 165, N'210310', N'Usicayos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1664, 166, N'210401', N'Juli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1665, 166, N'210402', N'Desaguadero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1666, 166, N'210403', N'Huacullani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1667, 166, N'210404', N'Kelluyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1668, 166, N'210405', N'Pisacoma')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1669, 166, N'210406', N'Pomata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1670, 166, N'210407', N'Zepita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1671, 167, N'210501', N'Ilave')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1672, 167, N'210502', N'Capazo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1673, 167, N'210503', N'Pilcuyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1674, 167, N'210504', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1675, 167, N'210505', N'Conduriri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1676, 168, N'210601', N'Huancane')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1677, 168, N'210602', N'Cojata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1678, 168, N'210603', N'Huatasani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1679, 168, N'210604', N'Inchupalla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1680, 168, N'210605', N'Pusi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1681, 168, N'210606', N'Rosaspata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1682, 168, N'210607', N'Taraco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1683, 168, N'210608', N'Vilque Chico')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1684, 169, N'210701', N'Lampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1685, 169, N'210702', N'Cabanilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1686, 169, N'210703', N'Calapuja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1687, 169, N'210704', N'Nicasio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1688, 169, N'210705', N'Ocuviri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1689, 169, N'210706', N'Palca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1690, 169, N'210707', N'Paratia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1691, 169, N'210708', N'Pucara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1692, 169, N'210709', N'Santa Lucia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1693, 169, N'210710', N'Vilavila')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1694, 170, N'210801', N'Ayaviri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1695, 170, N'210802', N'Antauta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1696, 170, N'210803', N'Cupi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1697, 170, N'210804', N'Llalli')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1698, 170, N'210805', N'Macari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1699, 170, N'210806', N'Nuñoa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1700, 170, N'210807', N'Orurillo')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1701, 170, N'210808', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1702, 170, N'210809', N'Umachiri')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1703, 171, N'210901', N'Moho')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1704, 171, N'210902', N'Conima')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1705, 171, N'210903', N'Huayrapata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1706, 171, N'210904', N'Tilali')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1707, 172, N'211001', N'Putina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1708, 172, N'211002', N'Ananea')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1709, 172, N'211003', N'Pedro Vilca Apaza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1710, 172, N'211004', N'Quilcapuncu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1711, 172, N'211005', N'Sina')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1712, 173, N'211101', N'Juliaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1713, 173, N'211102', N'Cabana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1714, 173, N'211103', N'Cabanillas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1715, 173, N'211104', N'Caracoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1716, 174, N'211201', N'Sandia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1717, 174, N'211202', N'Cuyocuyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1718, 174, N'211203', N'Limbani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1719, 174, N'211204', N'Patambuco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1720, 174, N'211205', N'Phara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1721, 174, N'211206', N'Quiaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1722, 174, N'211207', N'San Juan del Oro')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1723, 174, N'211208', N'Yanahuaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1724, 174, N'211209', N'Alto Inambari')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1725, 174, N'211210', N'San Pedro de Putina Punco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1726, 175, N'211301', N'Yunguyo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1727, 175, N'211302', N'Anapia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1728, 175, N'211303', N'Copani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1729, 175, N'211304', N'Cuturapi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1730, 175, N'211305', N'Ollaraya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1731, 175, N'211306', N'Tinicachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1732, 175, N'211307', N'Unicachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1733, 176, N'220101', N'Moyobamba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1734, 176, N'220102', N'Calzada')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1735, 176, N'220103', N'Habana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1736, 176, N'220104', N'Jepelacio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1737, 176, N'220105', N'Soritor')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1738, 176, N'220106', N'Yantalo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1739, 177, N'220201', N'Bellavista')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1740, 177, N'220202', N'Alto Biavo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1741, 177, N'220203', N'Bajo Biavo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1742, 177, N'220204', N'Huallaga')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1743, 177, N'220205', N'San Pablo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1744, 177, N'220206', N'San Rafael')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1745, 178, N'220301', N'San José de Sisa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1746, 178, N'220302', N'Agua Blanca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1747, 178, N'220303', N'San Martín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1748, 178, N'220304', N'Santa Rosa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1749, 178, N'220305', N'Shatoja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1750, 179, N'220401', N'Saposoa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1751, 179, N'220402', N'Alto Saposoa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1752, 179, N'220403', N'El Eslabón')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1753, 179, N'220404', N'Piscoyacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1754, 179, N'220405', N'Sacanche')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1755, 179, N'220406', N'Tingo de Saposoa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1756, 180, N'220501', N'Lamas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1757, 180, N'220502', N'Alonso de Alvarado')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1758, 180, N'220503', N'Barranquita')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1759, 180, N'220504', N'Caynarachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1760, 180, N'220505', N'Cuñumbuqui')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1761, 180, N'220506', N'Pinto Recodo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1762, 180, N'220507', N'Rumisapa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1763, 180, N'220508', N'San Roque de Cumbaza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1764, 180, N'220509', N'Shanao')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1765, 180, N'220510', N'Tabalosos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1766, 180, N'220511', N'Zapatero')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1767, 181, N'220601', N'Juanjuí')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1768, 181, N'220602', N'Campanilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1769, 181, N'220603', N'Huicungo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1770, 181, N'220604', N'Pachiza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1771, 181, N'220605', N'Pajarillo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1772, 182, N'220701', N'Picota')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1773, 182, N'220702', N'Buenos Aires')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1774, 182, N'220703', N'Caspisapa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1775, 182, N'220704', N'Pilluana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1776, 182, N'220705', N'Pucacaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1777, 182, N'220706', N'San Cristóbal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1778, 182, N'220707', N'San Hilarión')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1779, 182, N'220708', N'Shamboyacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1780, 182, N'220709', N'Tingo de Ponasa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1781, 182, N'220710', N'Tres Unidos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1782, 183, N'220801', N'Rioja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1783, 183, N'220802', N'Awajun')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1784, 183, N'220803', N'Elías Soplin Vargas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1785, 183, N'220804', N'Nueva Cajamarca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1786, 183, N'220805', N'Pardo Miguel')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1787, 183, N'220806', N'Posic')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1788, 183, N'220807', N'San Fernando')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1789, 183, N'220808', N'Yorongos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1790, 183, N'220809', N'Yuracyacu')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1791, 184, N'220901', N'Tarapoto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1792, 184, N'220902', N'Alberto Leveau')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1793, 184, N'220903', N'Cacatachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1794, 184, N'220904', N'Chazuta')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1795, 184, N'220905', N'Chipurana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1796, 184, N'220906', N'El Porvenir')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1797, 184, N'220907', N'Huimbayoc')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1798, 184, N'220908', N'Juan Guerra')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1799, 184, N'220909', N'La Banda de Shilcayo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1800, 184, N'220910', N'Morales')
GO
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1801, 184, N'220911', N'Papaplaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1802, 184, N'220912', N'San Antonio')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1803, 184, N'220913', N'Sauce')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1804, 184, N'220914', N'Shapaja')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1805, 185, N'221001', N'Tocache')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1806, 185, N'221002', N'Nuevo Progreso')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1807, 185, N'221003', N'Polvora')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1808, 185, N'221004', N'Shunte')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1809, 185, N'221005', N'Uchiza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1810, 186, N'230101', N'Tacna')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1811, 186, N'230102', N'Alto de la Alianza')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1812, 186, N'230103', N'Calana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1813, 186, N'230104', N'Ciudad Nueva')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1814, 186, N'230105', N'Inclan')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1815, 186, N'230106', N'Pachia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1816, 186, N'230107', N'Palca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1817, 186, N'230108', N'Pocollay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1818, 186, N'230109', N'Sama')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1819, 186, N'230110', N'Coronel Gregorio Albarracín Lanchipa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1820, 186, N'230111', N'La Yarada los Palos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1821, 187, N'230201', N'Candarave')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1822, 187, N'230202', N'Cairani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1823, 187, N'230203', N'Camilaca')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1824, 187, N'230204', N'Curibaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1825, 187, N'230205', N'Huanuara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1826, 187, N'230206', N'Quilahuani')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1827, 188, N'230301', N'Locumba')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1828, 188, N'230302', N'Ilabaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1829, 188, N'230303', N'Ite')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1830, 189, N'230401', N'Tarata')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1831, 189, N'230402', N'Héroes Albarracín')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1832, 189, N'230403', N'Estique')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1833, 189, N'230404', N'Estique-Pampa')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1834, 189, N'230405', N'Sitajara')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1835, 189, N'230406', N'Susapaya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1836, 189, N'230407', N'Tarucachi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1837, 189, N'230408', N'Ticaco')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1838, 190, N'240101', N'Tumbes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1839, 190, N'240102', N'Corrales')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1840, 190, N'240103', N'La Cruz')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1841, 190, N'240104', N'Pampas de Hospital')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1842, 190, N'240105', N'San Jacinto')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1843, 190, N'240106', N'San Juan de la Virgen')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1844, 191, N'240201', N'Zorritos')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1845, 191, N'240202', N'Casitas')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1846, 191, N'240203', N'Canoas de Punta Sal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1847, 192, N'240301', N'Zarumilla')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1848, 192, N'240302', N'Aguas Verdes')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1849, 192, N'240303', N'Matapalo')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1850, 192, N'240304', N'Papayal')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1851, 193, N'250101', N'Calleria')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1852, 193, N'250102', N'Campoverde')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1853, 193, N'250103', N'Iparia')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1854, 193, N'250104', N'Masisea')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1855, 193, N'250105', N'Yarinacocha')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1856, 193, N'250106', N'Nueva Requena')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1857, 193, N'250107', N'Manantay')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1858, 194, N'250201', N'Raymondi')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1859, 194, N'250202', N'Sepahua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1860, 194, N'250203', N'Tahuania')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1861, 194, N'250204', N'Yurua')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1862, 195, N'250301', N'Padre Abad')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1863, 195, N'250302', N'Irazola')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1864, 195, N'250303', N'Curimana')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1865, 195, N'250304', N'Neshuya')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1866, 195, N'250305', N'Alexander Von Humboldt')
INSERT [dbo].[Distrito] ([CodigoDistrito], [CodigoProvincia], [CodigoUbigeo], [Nombre]) VALUES (1867, 196, N'250401', N'Purus')
INSERT [dbo].[FacturaVenta] ([CodigoFacturaVenta], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraVencimiento], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMoneda], [CodigoMetodoPago], [CantidadLetrasCredito], [CodigoSerieGuiaRemision], [NroComprobanteGuiaRemision], [TotalOperacionGravada], [TotalOperacionInafecta], [TotalOperacionExonerada], [TotalOperacionExportacion], [TotalOperacionGratuita], [TotalValorVenta], [TotalIgv], [TotalIsc], [TotalOtrosCargos], [TotalOtrosTributos], [TotalIcbper], [TotalDescuentoDetallado], [TotalPorcentajeDescuentoGlobal], [TotalDescuentoGlobal], [TotalPrecioVenta], [TotalImporte], [TotalPercepcion], [TotalPagar], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 2, 1, CAST(N'2020-09-11T02:19:32.177' AS DateTime), CAST(N'2020-09-11T02:19:32.170' AS DateTime), 3, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10 - SURQUILLO', N'Perú', N'Lima', N'Lima', 1307, N'San Juan de Miraflores', 1, NULL, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(22.88 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL, CAST(N'2020-09-11T02:20:48.450' AS DateTime), NULL, NULL)
INSERT [dbo].[FacturaVenta] ([CodigoFacturaVenta], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraVencimiento], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMoneda], [CodigoMetodoPago], [CantidadLetrasCredito], [CodigoSerieGuiaRemision], [NroComprobanteGuiaRemision], [TotalOperacionGravada], [TotalOperacionInafecta], [TotalOperacionExonerada], [TotalOperacionExportacion], [TotalOperacionGratuita], [TotalValorVenta], [TotalIgv], [TotalIsc], [TotalOtrosCargos], [TotalOtrosTributos], [TotalIcbper], [TotalDescuentoDetallado], [TotalPorcentajeDescuentoGlobal], [TotalDescuentoGlobal], [TotalPrecioVenta], [TotalImporte], [TotalPercepcion], [TotalPagar], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, 2, 2, CAST(N'2020-09-11T02:19:32.177' AS DateTime), CAST(N'2020-09-11T02:19:32.170' AS DateTime), 3, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10 - SURQUILLO', N'Perú', N'Lima', N'Lima', 1307, N'San Juan de Miraflores', 1, NULL, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(22.88 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL, CAST(N'2020-09-11T02:25:10.423' AS DateTime), NULL, NULL)
INSERT [dbo].[FacturaVenta] ([CodigoFacturaVenta], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraVencimiento], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMoneda], [CodigoMetodoPago], [CantidadLetrasCredito], [CodigoSerieGuiaRemision], [NroComprobanteGuiaRemision], [TotalOperacionGravada], [TotalOperacionInafecta], [TotalOperacionExonerada], [TotalOperacionExportacion], [TotalOperacionGratuita], [TotalValorVenta], [TotalIgv], [TotalIsc], [TotalOtrosCargos], [TotalOtrosTributos], [TotalIcbper], [TotalDescuentoDetallado], [TotalPorcentajeDescuentoGlobal], [TotalDescuentoGlobal], [TotalPrecioVenta], [TotalImporte], [TotalPercepcion], [TotalPagar], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, 2, 3, CAST(N'2020-09-11T02:19:32.177' AS DateTime), CAST(N'2020-09-11T02:19:32.170' AS DateTime), 3, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10 - SURQUILLO', N'Perú', N'Lima', N'Lima', 1307, N'San Juan de Miraflores', 1, NULL, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(254.24 AS Decimal(18, 2)), CAST(45.76 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL, CAST(N'2020-09-11T02:27:25.840' AS DateTime), NULL, CAST(N'2020-09-11T04:59:16.870' AS DateTime))
INSERT [dbo].[FacturaVenta] ([CodigoFacturaVenta], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraVencimiento], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMoneda], [CodigoMetodoPago], [CantidadLetrasCredito], [CodigoSerieGuiaRemision], [NroComprobanteGuiaRemision], [TotalOperacionGravada], [TotalOperacionInafecta], [TotalOperacionExonerada], [TotalOperacionExportacion], [TotalOperacionGratuita], [TotalValorVenta], [TotalIgv], [TotalIsc], [TotalOtrosCargos], [TotalOtrosTributos], [TotalIcbper], [TotalDescuentoDetallado], [TotalPorcentajeDescuentoGlobal], [TotalDescuentoGlobal], [TotalPrecioVenta], [TotalImporte], [TotalPercepcion], [TotalPagar], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, 2, 4, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2020-09-21T21:40:18.557' AS DateTime), 3, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10 - SURQUILLO', N'Perú', N'Lima', N'Lima', 1307, N'San Juan de Miraflores', 1, 2, 5, NULL, NULL, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(171.61 AS Decimal(18, 2)), CAST(30.89 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(202.50 AS Decimal(18, 2)), CAST(202.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL, CAST(N'2020-09-21T21:41:47.017' AS DateTime), NULL, CAST(N'2020-09-22T01:56:50.690' AS DateTime))
INSERT [dbo].[FacturaVentaDetalle] ([CodigoFacturaVenta], [CodigoFacturaVentaDetalle], [CodigoProducto], [CodigoProductoIndividual], [CodigoUnidadMedida], [Detalle], [Cantidad], [TipoCalculo], [ValorUnitario], [PrecioUnitario], [ValorVenta], [PrecioVenta], [Igv], [Isc], [TipoDescuento], [PorcentajeDescuento], [Descuento], [OtrosCargos], [OtrosTributos], [BaseImponible], [Importe], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, 1, 1, 1, 456, N'ROLLO TELA ESPECIAL', CAST(20.00 AS Decimal(18, 2)), 2, CAST(12.71 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(254.24 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(45.76 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(254.24 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), 0, NULL, CAST(N'2020-09-11T04:59:16.937' AS DateTime), NULL, NULL)
INSERT [dbo].[FacturaVentaDetalle] ([CodigoFacturaVenta], [CodigoFacturaVentaDetalle], [CodigoProducto], [CodigoProductoIndividual], [CodigoUnidadMedida], [Detalle], [Cantidad], [TipoCalculo], [ValorUnitario], [PrecioUnitario], [ValorVenta], [PrecioVenta], [Igv], [Isc], [TipoDescuento], [PorcentajeDescuento], [Descuento], [OtrosCargos], [OtrosTributos], [BaseImponible], [Importe], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, 2, 1, 1, 1975, N'ROLLO TELA ESPECIAL', CAST(13.50 AS Decimal(18, 2)), 0, CAST(12.71 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(171.61 AS Decimal(18, 2)), CAST(202.50 AS Decimal(18, 2)), CAST(30.89 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(171.61 AS Decimal(18, 2)), CAST(202.50 AS Decimal(18, 2)), 0, NULL, CAST(N'2020-09-21T21:41:48.760' AS DateTime), NULL, CAST(N'2020-09-22T01:56:50.717' AS DateTime))
INSERT [dbo].[GuiaRemision] ([CodigoGuiaRemision], [CodigoTipoComprobante], [CodigoSerie], [NroComprobante], [FechaHoraEmision], [FechaHoraTraslado], [CodigoCliente], [DireccionCliente], [NombrePaisCliente], [NombreDepartamentoCliente], [NombreProvinciaCliente], [CodigoDistritoCliente], [NombreDistritoCliente], [CodigoMotivoTraslado], [CodigoTransportista], [DireccionTransportista], [NombrePaisTransportista], [NombreDepartamentoTransportista], [NombreProvinciaTransportista], [CodigoDistritoTransportista], [NombreDistritoTransportista], [MarcaVehiculoTransportista], [PlacaVehiculoTransportista], [LicenciaConducirTransportista], [FlagEmitido], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 5, 3, 1, CAST(N'2020-09-25T07:48:02.423' AS DateTime), CAST(N'2020-09-25T07:48:02.423' AS DateTime), 1, N'AA.HH. LUIS REBAZA CORDOVA MZ. B LT. 10', N'Perú', N'Lima', N'Lima', 1315, N'Surquillo', 1, 1, N'CLL. IGNACIO SEMINARIO 950 ZN C - SJM', N'Perú', N'Lima', N'Lima', 1307, N'San Juan de Miraflores', N'sadsad', N'daddsad', N'sadsa', 0, 1, NULL, CAST(N'2020-09-25T07:49:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[GuiaRemisionDetalle] ([CodigoGuiaRemision], [CodigoGuiaRemisionDetalle], [CodigoProducto], [CodigoProductoIndividual], [CodigoUnidadMedida], [Detalle], [Cantidad], [CodigoUnidadMedidaPeso], [Peso], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, 1, 1, 1975, N'ROLLO TELA ESPECIAL', CAST(12.00 AS Decimal(18, 2)), 29, CAST(80.00 AS Decimal(18, 2)), 0, NULL, CAST(N'2020-09-25T07:50:12.610' AS DateTime), NULL, NULL)
INSERT [dbo].[Letra] ([CodigoLetra], [Numero], [FechaHoraEmision], [FechaVencimiento], [Dias], [CodigoTipoComprobanteRef], [CodigoSerieRef], [NumeroRef], [CodigoSerieGuia], [NumeroGuia], [CodigoCliente], [CodigoBanco], [CodigoUnicoBanco], [CodigoMoneda], [Monto], [Estado], [FlagCancelado], [FlagActivo], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 20, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2020-09-21T00:00:00.000' AS DateTime), 30, 2, 2, 4, 0, 0, 3, 0, NULL, 1, CAST(40.50 AS Decimal(18, 2)), NULL, 0, 1, 0, NULL, CAST(N'2020-09-22T01:56:50.750' AS DateTime), NULL, NULL)
INSERT [dbo].[Letra] ([CodigoLetra], [Numero], [FechaHoraEmision], [FechaVencimiento], [Dias], [CodigoTipoComprobanteRef], [CodigoSerieRef], [NumeroRef], [CodigoSerieGuia], [NumeroGuia], [CodigoCliente], [CodigoBanco], [CodigoUnicoBanco], [CodigoMoneda], [Monto], [Estado], [FlagCancelado], [FlagActivo], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, 21, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2020-10-21T00:00:00.000' AS DateTime), 30, 2, 2, 4, 0, 0, 3, 0, NULL, 1, CAST(40.50 AS Decimal(18, 2)), NULL, 0, 1, 0, NULL, CAST(N'2020-09-22T01:56:50.750' AS DateTime), NULL, NULL)
INSERT [dbo].[Letra] ([CodigoLetra], [Numero], [FechaHoraEmision], [FechaVencimiento], [Dias], [CodigoTipoComprobanteRef], [CodigoSerieRef], [NumeroRef], [CodigoSerieGuia], [NumeroGuia], [CodigoCliente], [CodigoBanco], [CodigoUnicoBanco], [CodigoMoneda], [Monto], [Estado], [FlagCancelado], [FlagActivo], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, 22, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2020-11-21T00:00:00.000' AS DateTime), 31, 2, 2, 4, 0, 0, 3, 0, NULL, 1, CAST(40.50 AS Decimal(18, 2)), NULL, 0, 1, 0, NULL, CAST(N'2020-09-22T01:56:50.757' AS DateTime), NULL, NULL)
INSERT [dbo].[Letra] ([CodigoLetra], [Numero], [FechaHoraEmision], [FechaVencimiento], [Dias], [CodigoTipoComprobanteRef], [CodigoSerieRef], [NumeroRef], [CodigoSerieGuia], [NumeroGuia], [CodigoCliente], [CodigoBanco], [CodigoUnicoBanco], [CodigoMoneda], [Monto], [Estado], [FlagCancelado], [FlagActivo], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, 23, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2020-12-21T00:00:00.000' AS DateTime), 30, 2, 2, 4, 0, 0, 3, 0, NULL, 1, CAST(40.50 AS Decimal(18, 2)), NULL, 0, 1, 0, NULL, CAST(N'2020-09-22T01:56:50.757' AS DateTime), NULL, NULL)
INSERT [dbo].[Letra] ([CodigoLetra], [Numero], [FechaHoraEmision], [FechaVencimiento], [Dias], [CodigoTipoComprobanteRef], [CodigoSerieRef], [NumeroRef], [CodigoSerieGuia], [NumeroGuia], [CodigoCliente], [CodigoBanco], [CodigoUnicoBanco], [CodigoMoneda], [Monto], [Estado], [FlagCancelado], [FlagActivo], [FlagEliminado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (5, 24, CAST(N'2020-09-21T21:40:18.557' AS DateTime), CAST(N'2021-01-21T00:00:00.000' AS DateTime), 31, 2, 2, 4, 0, 0, 3, 0, NULL, 1, CAST(40.50 AS Decimal(18, 2)), NULL, 0, 1, 0, NULL, CAST(N'2020-09-22T01:56:50.760' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'Ventas', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'Compras', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, N'Almacén', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, N'Clientes', N'pm.app.FrmCliente', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (5, N'Proveedores', N'pm.app.FrmProveedor', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (6, N'Productos', N'pm.app.FrmProducto', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (7, N'Configuración', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (8, N'Áreas', N'pm.app.FrmArea', 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (9, N'Actividades', N'pm.app.FrmActividad', 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (10, N'Unidades de Medida', N'pm.app.FrmUnidadMedida', 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (11, N'Sistema', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (12, N'Menúes', N'pm.app.FrmMenu', 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (13, N'Perfiles', N'pm.app.FrmPerfil', 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (14, N'Usuarios', N'pm.app.FrmUsuario', 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (15, N'Productos Individuales', N'pm.app.FrmProductoIndividual', 3, 1, NULL, CAST(N'2020-08-18T05:48:44.103' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (16, N'Personal', N'pm.app.FrmPersonal', 7, 1, NULL, CAST(N'2020-08-21T00:41:08.473' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (17, N'Factura', N'pm.app.FrmFacturaVenta', 1, 1, NULL, CAST(N'2020-08-23T00:35:39.933' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (18, N'Boleta', N'pm.app.FrmBoletaVenta', 1, 1, NULL, CAST(N'2020-08-23T00:36:05.127' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (19, N'Nota de crédito', N'pm.app.FrmNotaCreditoVenta', 1, 1, NULL, CAST(N'2020-08-23T00:37:34.743' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (20, N'Nota de débito', N'pm.app.FrmNotaDebitoVenta', 1, 1, NULL, CAST(N'2020-08-23T00:37:55.493' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (21, N'Guía de remisión', N'pm.app.FrmGuiaRemisionVenta', 1, 0, NULL, CAST(N'2020-08-23T00:40:08.613' AS DateTime), NULL, CAST(N'2020-09-25T05:20:45.570' AS DateTime))
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (22, N'Serie', N'pm.app.FrmSerie', 7, 1, NULL, CAST(N'2020-09-03T20:14:59.317' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (23, N'Banco', N'pm.app.FrmBanco', 7, 1, NULL, CAST(N'2020-09-21T22:23:48.270' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (24, N'Motivo Traslado', N'pm.app.FrmMotivoTraslado', 7, 1, NULL, CAST(N'2020-09-23T21:29:56.747' AS DateTime), NULL, NULL)
INSERT [dbo].[Menu] ([CodigoMenu], [Nombre], [Formulario], [CodigoMenuPadre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (25, N'Guía Remisión', N'pm.app.FrmGuiaRemision', 1, 1, NULL, CAST(N'2020-09-25T05:09:34.643' AS DateTime), NULL, NULL)
INSERT [dbo].[MotivoTraslado] ([CodigoMotivoTraslado], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'Venta', 1, NULL, CAST(N'2020-09-23T21:31:11.557' AS DateTime), NULL, NULL)
INSERT [dbo].[MotivoTraslado] ([CodigoMotivoTraslado], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'Compra', 1, NULL, CAST(N'2020-09-23T21:31:16.713' AS DateTime), NULL, NULL)
INSERT [dbo].[MotivoTraslado] ([CodigoMotivoTraslado], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, N'Consignación', 1, NULL, CAST(N'2020-09-23T21:31:35.973' AS DateTime), NULL, NULL)
INSERT [dbo].[MotivoTraslado] ([CodigoMotivoTraslado], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, N'Venta con entrega a terceros', 1, NULL, CAST(N'2020-09-23T21:32:22.353' AS DateTime), NULL, NULL)
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (1, N'Afganistán', N'AFGANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (2, N'Albania', N'ALBANESA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (3, N'Alemania', N'ALEMANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (4, N'Andorra', N'ANDORRANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (5, N'Angola', N'ANGOLEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (6, N'AntiguayBarbuda', N'ANTIGUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (7, N'ArabiaSaudita', N'SAUDÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (8, N'Argelia', N'ARGELINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (9, N'Argentina', N'ARGENTINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (10, N'Armenia', N'ARMENIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (11, N'Aruba', N'ARUBEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (12, N'Australia', N'AUSTRALIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (13, N'Austria', N'AUSTRIACA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (14, N'Azerbaiyán', N'AZERBAIYANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (15, N'Bahamas', N'BAHAMEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (16, N'Bangladés', N'BANGLADESÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (17, N'Barbados', N'BARBADENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (18, N'Baréin', N'BAREINÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (19, N'Bélgica', N'BELGA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (20, N'Belice', N'BELICEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (21, N'Benín', N'BENINÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (22, N'Bielorrusia', N'BIELORRUSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (23, N'Birmania', N'BIRMANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (24, N'Bolivia', N'BOLIVIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (25, N'BosniayHerzegovina', N'BOSNIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (26, N'Botsuana', N'BOTSUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (27, N'Brasil', N'BRASILEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (28, N'Brunéi', N'BRUNEANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (29, N'Bulgaria', N'BÚLGARA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (30, N'BurkinaFaso', N'BURKINÉS')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (31, N'Burundi', N'BURUNDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (32, N'Bután', N'BUTANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (33, N'CaboVerde', N'CABOVERDIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (34, N'Camboya', N'CAMBOYANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (35, N'Camerún', N'CAMERUNESA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (36, N'Canadá', N'CANADIENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (37, N'Catar', N'CATARÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (38, N'Chad', N'CHADIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (39, N'Chile', N'CHILENA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (40, N'China', N'CHINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (41, N'Chipre', N'CHIPRIOTA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (42, N'CiudaddelVaticano', N'VATICANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (43, N'Colombia', N'COLOMBIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (44, N'Comoras', N'COMORENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (45, N'CoreadelNorte', N'NORCOREANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (46, N'CoreadelSur', N'SURCOREANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (47, N'CostadeMarfil', N'MARFILEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (48, N'CostaRica', N'COSTARRICENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (49, N'Croacia', N'CROATA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (50, N'Cuba', N'CUBANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (51, N'Dinamarca', N'DANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (52, N'Dominica', N'DOMINIQUÉS')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (53, N'Ecuador', N'ECUATORIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (54, N'Egipto', N'EGIPCIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (55, N'ElSalvador', N'SALVADOREÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (56, N'EmiratosÁrabesUnidos', N'EMIRATÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (57, N'Eritrea', N'ERITREA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (58, N'Eslovaquia', N'ESLOVACA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (59, N'Eslovenia', N'ESLOVENA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (60, N'España', N'ESPAÑOLA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (61, N'EstadosUnidos', N'ESTADOUNIDENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (62, N'Estonia', N'ESTONIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (63, N'Etiopía', N'ETÍOPE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (64, N'Filipinas', N'FILIPINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (65, N'Finlandia', N'FINLANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (66, N'Fiyi', N'FIYIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (67, N'Francia', N'FRANCÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (68, N'Gabón', N'GABONÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (69, N'Gambia', N'GAMBIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (70, N'Georgia', N'GEORGIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (71, N'Gibraltar', N'GIBRALTAREÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (72, N'Ghana', N'GHANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (73, N'Granada', N'GRANADINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (74, N'Grecia', N'GRIEGA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (75, N'Groenlandia', N'GROENLANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (76, N'Guatemala', N'GUATEMALTECA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (77, N'Guineaecuatorial', N'ECUATOGUINEANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (78, N'Guinea', N'GUINEANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (79, N'Guinea-Bisáu', N'GUINEANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (80, N'Guyana', N'GUYANESA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (81, N'Haití', N'HAITIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (82, N'Honduras', N'HONDUREÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (83, N'Hungría', N'HÚNGARA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (84, N'India', N'HINDÚ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (85, N'Indonesia', N'INDONESIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (86, N'Irak', N'IRAQUÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (87, N'Irán', N'IRANÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (88, N'Irlanda', N'IRLANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (89, N'Islandia', N'ISLANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (90, N'IslasCook', N'COOKIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (91, N'IslasMarshall', N'MARSHALÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (92, N'IslasSalomón', N'SALOMONENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (93, N'Israel', N'ISRAELÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (94, N'Italia', N'ITALIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (95, N'Jamaica', N'JAMAIQUINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (96, N'Japón', N'JAPONÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (97, N'Jordania', N'JORDANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (98, N'Kazajistán', N'KAZAJA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (99, N'Kenia', N'KENIATA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (100, N'Kirguistán', N'KIRGUISA')
GO
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (101, N'Kiribati', N'KIRIBATIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (102, N'Kuwait', N'KUWAITÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (103, N'Laos', N'LAOSIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (104, N'Lesoto', N'LESOTENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (105, N'Letonia', N'LETÓNA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (106, N'Líbano', N'LIBANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (107, N'Liberia', N'LIBERIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (108, N'Libia', N'LIBIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (109, N'Liechtenstein', N'LIECHTENSTEINIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (110, N'Lituania', N'LITUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (111, N'Luxemburgo', N'LUXEMBURGUÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (112, N'Madagascar', N'MALGACHE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (113, N'Malasia', N'MALASIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (114, N'Malaui', N'MALAUÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (115, N'Maldivas', N'MALDIVA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (116, N'Malí', N'MALIENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (117, N'Malta', N'MALTÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (118, N'Marruecos', N'MARROQUÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (119, N'Martinica', N'MARTINIQUÉS')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (120, N'Mauricio', N'MAURICIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (121, N'Mauritania', N'MAURITANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (122, N'México', N'MEXICANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (123, N'Micronesia', N'MICRONESIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (124, N'Moldavia', N'MOLDAVA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (125, N'Mónaco', N'MONEGASCA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (126, N'Mongolia', N'MONGOLA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (127, N'Montenegro', N'MONTENEGRINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (128, N'Mozambique', N'MOZAMBIQUEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (129, N'Namibia', N'NAMIBIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (130, N'Nauru', N'NAURUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (131, N'Nepal', N'NEPALÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (132, N'Nicaragua', N'NICARAGÜENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (133, N'Níger', N'NIGERINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (134, N'Nigeria', N'NIGERIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (135, N'Noruega', N'NORUEGA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (136, N'NuevaZelanda', N'NEOZELANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (137, N'Omán', N'OMANÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (138, N'PaísesBajos', N'NEERLANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (139, N'Pakistán', N'PAKISTANÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (140, N'Palaos', N'PALAUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (141, N'Palestina', N'PALESTINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (142, N'Panamá', N'PANAMEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (143, N'PapúaNuevaGuinea', N'PAPÚ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (144, N'Paraguay', N'PARAGUAYA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (145, N'Perú', N'PERUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (146, N'Polonia', N'POLACA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (147, N'Portugal', N'PORTUGUÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (148, N'PuertoRico', N'PUERTORRIQUEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (149, N'ReinoUnido', N'BRITÁNICA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (150, N'RepúblicaCentroafricana', N'CENTROAFRICANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (151, N'RepúblicaCheca', N'CHECA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (152, N'RepúblicadeMacedonia', N'MACEDONIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (153, N'RepúblicadelCongo', N'CONGOLEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (154, N'RepúblicaDemocráticadelCongo', N'CONGOLEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (155, N'RepúblicaDominicana', N'DOMINICANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (156, N'RepúblicaSudafricana', N'SUDAFRICANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (157, N'Ruanda', N'RUANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (158, N'Rumanía', N'RUMANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (159, N'Rusia', N'RUSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (160, N'Samoa', N'SAMOANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (161, N'SanCristóbalyNieves', N'CRISTOBALEÑA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (162, N'SanMarino', N'SANMARINENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (163, N'SanVicenteylasGranadinas', N'SANVICENTINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (164, N'SantaLucía', N'SANTALUCENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (165, N'SantoToméyPríncipe', N'SANTOTOMENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (166, N'Senegal', N'SENEGALÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (167, N'Serbia', N'SERBIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (168, N'Seychelles', N'SEYCHELLENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (169, N'SierraLeona', N'SIERRALEONÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (170, N'Singapur', N'SINGAPURENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (171, N'Siria', N'SIRIA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (172, N'Somalia', N'SOMALÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (173, N'SriLanka', N'CEILANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (174, N'Suazilandia', N'SUAZI')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (175, N'SudándelSur', N'SURSUDANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (176, N'Sudán', N'SUDANÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (177, N'Suecia', N'SUECA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (178, N'Suiza', N'SUIZA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (179, N'Surinam', N'SURINAMESA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (180, N'Tailandia', N'TAILANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (181, N'Tanzania', N'TANZANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (182, N'Tayikistán', N'TAYIKA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (183, N'TimorOriental', N'TIMORENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (184, N'Togo', N'TOGOLÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (185, N'Tonga', N'TONGANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (186, N'TrinidadyTobago', N'TRINITENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (187, N'Túnez', N'TUNECINA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (188, N'Turkmenistán', N'TURCOMANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (189, N'Turquía', N'TURCA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (190, N'Tuvalu', N'TUVALUANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (191, N'Ucrania', N'UCRANIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (192, N'Uganda', N'UGANDÉSA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (193, N'Uruguay', N'URUGUAYA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (194, N'Uzbekistán', N'UZBEKA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (195, N'Vanuatu', N'VANUATUENSE')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (196, N'Venezuela', N'VENEZOLANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (197, N'Vietnam', N'VIETNAMITA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (198, N'Yemen', N'YEMENÍ')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (199, N'Yibuti', N'YIBUTIANA')
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (200, N'Zambia', N'ZAMBIANA')
GO
INSERT [dbo].[Pais] ([CodigoPais], [Nombre], [Nacionalidad]) VALUES (201, N'Zimbabue', N'ZIMBABUENSE')
INSERT [dbo].[Perfil] ([CodigoPerfil], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'Administrador', 1, N'AUTO', CAST(N'2020-08-05T03:00:07.763' AS DateTime), NULL, CAST(N'2020-09-25T05:09:54.327' AS DateTime))
INSERT [dbo].[Perfil] ([CodigoPerfil], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'Operador de Compra', 1, N'AUTO', CAST(N'2020-08-05T05:02:08.790' AS DateTime), NULL, NULL)
INSERT [dbo].[Perfil] ([CodigoPerfil], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, N'Operador de Venta', 1, N'AUTO', CAST(N'2020-08-05T05:02:18.423' AS DateTime), NULL, NULL)
INSERT [dbo].[Perfil] ([CodigoPerfil], [Nombre], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, N'Operador de Sistemas', 1, NULL, CAST(N'2020-08-18T04:36:31.407' AS DateTime), NULL, CAST(N'2020-08-18T10:43:16.587' AS DateTime))
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 1)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 2)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 3)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 4)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 5)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 6)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 7)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 8)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 9)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 10)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 11)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 12)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 13)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 14)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 15)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 16)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 17)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 18)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 19)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 20)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 21)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 22)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 23)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 24)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (1, 25)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 1)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 2)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 3)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 4)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 5)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (2, 6)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 1)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 2)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 3)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 4)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 5)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (3, 6)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (4, 11)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (4, 12)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (4, 13)
INSERT [dbo].[PerfilMenu] ([CodigoPerfil], [CodigoMenu]) VALUES (4, 14)
INSERT [dbo].[Personal] ([CodigoPersonal], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Correo], [CodigoArea], [FlagActivo], [Estado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, N'71228362', N'RONALD JULINHO SEANCAS BARRETO', N'ronald.jsb@hotmail.com', 1, 1, 1, N'AUTO', CAST(N'2020-08-05T01:43:07.300' AS DateTime), NULL, NULL)
INSERT [dbo].[Personal] ([CodigoPersonal], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Correo], [CodigoArea], [FlagActivo], [Estado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, 1, N'07264120', N'ZORAIDA PAOLA BARRETO GONZALES', N'zoraida.gonzales@gmail.com', 1, 1, 1, NULL, CAST(N'2020-08-21T00:52:03.570' AS DateTime), NULL, NULL)
INSERT [dbo].[Producto] ([CodigoProducto], [Nombre], [CodigoUnidadMedida], [Cantidad], [ValorCompra], [ValorVenta], [DescuentoMaximo], [Color], [MetrajeTotal], [Estado], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'ROLLO TELA', 1975, CAST(10.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), N'ROJO', CAST(1000.00 AS Decimal(18, 2)), 1, NULL, CAST(N'2020-08-16T17:43:04.067' AS DateTime), NULL, NULL)
INSERT [dbo].[ProductoIndividual] ([CodigoProductoIndividual], [CodigoBarra], [CodigoProducto], [Nombre], [CodigoUnidadMedida], [Metraje], [Peso], [CodigoInicial], [Rollo], [Bulto], [Color], [CodigoProveedor], [CodigoBarraProveedor], [FechaEntrada], [CodigoPersonalInspeccion], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'123456', 1, N'ROLLO TELA ESPECIAL', 1975, CAST(12.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), 123456, CAST(12.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), N'ROJo', 1, N'123456', CAST(N'2020-08-22T23:34:07.200' AS DateTime), 1, NULL, CAST(N'2020-08-22T23:36:24.153' AS DateTime), NULL, NULL)
INSERT [dbo].[Proveedor] ([CodigoProveedor], [CodigoTipoDocumentoIdentidad], [NroDocumentoIdentidad], [Nombres], [Direccion], [CodigoDistrito], [Correo], [Telefono], [Contacto], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 2, N'10712283624', N'RONALD JULINHO SEANCAS BARRETO', N'CLL. IGNACIO SEMINARIO 950 ZN C - SJM', 1307, N'ronald.jsb@hotmail.com', N'954762805', N'RONALD SEANCAS', 1, NULL, CAST(N'2020-08-10T08:51:23.827' AS DateTime), NULL, CAST(N'2020-08-10T09:02:17.943' AS DateTime))
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (1, 1, N'0101', N'Chachapoyas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (2, 1, N'0102', N'Bagua')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (3, 1, N'0103', N'Bongará')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (4, 1, N'0104', N'Condorcanqui')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (5, 1, N'0105', N'Luya')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (6, 1, N'0106', N'Rodríguez de Mendoza')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (7, 1, N'0107', N'Utcubamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (8, 2, N'0201', N'Huaraz')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (9, 2, N'0202', N'Aija')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (10, 2, N'0203', N'Antonio Raymondi')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (11, 2, N'0204', N'Asunción')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (12, 2, N'0205', N'Bolognesi')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (13, 2, N'0206', N'Carhuaz')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (14, 2, N'0207', N'Carlos Fermín Fitzcarrald')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (15, 2, N'0208', N'Casma')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (16, 2, N'0209', N'Corongo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (17, 2, N'0210', N'Huari')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (18, 2, N'0211', N'Huarmey')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (19, 2, N'0212', N'Huaylas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (20, 2, N'0213', N'Mariscal Luzuriaga')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (21, 2, N'0214', N'Ocros')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (22, 2, N'0215', N'Pallasca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (23, 2, N'0216', N'Pomabamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (24, 2, N'0217', N'Recuay')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (25, 2, N'0218', N'Santa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (26, 2, N'0219', N'Sihuas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (27, 2, N'0220', N'Yungay')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (28, 3, N'0301', N'Abancay')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (29, 3, N'0302', N'Andahuaylas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (30, 3, N'0303', N'Antabamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (31, 3, N'0304', N'Aymaraes')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (32, 3, N'0305', N'Cotabambas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (33, 3, N'0306', N'Chincheros')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (34, 3, N'0307', N'Grau')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (35, 4, N'0401', N'Arequipa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (36, 4, N'0402', N'Camaná')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (37, 4, N'0403', N'Caravelí')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (38, 4, N'0404', N'Castilla')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (39, 4, N'0405', N'Caylloma')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (40, 4, N'0406', N'Condesuyos')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (41, 4, N'0407', N'Islay')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (42, 4, N'0408', N'La Uniòn')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (43, 5, N'0501', N'Huamanga')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (44, 5, N'0502', N'Cangallo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (45, 5, N'0503', N'Huanca Sancos')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (46, 5, N'0504', N'Huanta')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (47, 5, N'0505', N'La Mar')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (48, 5, N'0506', N'Lucanas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (49, 5, N'0507', N'Parinacochas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (50, 5, N'0508', N'Pàucar del Sara Sara')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (51, 5, N'0509', N'Sucre')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (52, 5, N'0510', N'Víctor Fajardo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (53, 5, N'0511', N'Vilcas Huamán')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (54, 6, N'0601', N'Cajamarca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (55, 6, N'0602', N'Cajabamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (56, 6, N'0603', N'Celendín')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (57, 6, N'0604', N'Chota')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (58, 6, N'0605', N'Contumazá')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (59, 6, N'0606', N'Cutervo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (60, 6, N'0607', N'Hualgayoc')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (61, 6, N'0608', N'Jaén')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (62, 6, N'0609', N'San Ignacio')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (63, 6, N'0610', N'San Marcos')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (64, 6, N'0611', N'San Miguel')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (65, 6, N'0612', N'San Pablo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (66, 6, N'0613', N'Santa Cruz')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (67, 7, N'0701', N'Prov. Const. del Callao')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (68, 8, N'0801', N'Cusco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (69, 8, N'0802', N'Acomayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (70, 8, N'0803', N'Anta')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (71, 8, N'0804', N'Calca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (72, 8, N'0805', N'Canas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (73, 8, N'0806', N'Canchis')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (74, 8, N'0807', N'Chumbivilcas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (75, 8, N'0808', N'Espinar')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (76, 8, N'0809', N'La Convención')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (77, 8, N'0810', N'Paruro')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (78, 8, N'0811', N'Paucartambo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (79, 8, N'0812', N'Quispicanchi')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (80, 8, N'0813', N'Urubamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (81, 9, N'0901', N'Huancavelica')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (82, 9, N'0902', N'Acobamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (83, 9, N'0903', N'Angaraes')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (84, 9, N'0904', N'Castrovirreyna')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (85, 9, N'0905', N'Churcampa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (86, 9, N'0906', N'Huaytará')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (87, 9, N'0907', N'Tayacaja')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (88, 10, N'1001', N'Huánuco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (89, 10, N'1002', N'Ambo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (90, 10, N'1003', N'Dos de Mayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (91, 10, N'1004', N'Huacaybamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (92, 10, N'1005', N'Huamalíes')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (93, 10, N'1006', N'Leoncio Prado')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (94, 10, N'1007', N'Marañón')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (95, 10, N'1008', N'Pachitea')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (96, 10, N'1009', N'Puerto Inca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (97, 10, N'1010', N'Lauricocha')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (98, 10, N'1011', N'Yarowilca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (99, 11, N'1101', N'Ica')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (100, 11, N'1102', N'Chincha')
GO
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (101, 11, N'1103', N'Nasca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (102, 11, N'1104', N'Palpa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (103, 11, N'1105', N'Pisco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (104, 12, N'1201', N'Huancayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (105, 12, N'1202', N'Concepción')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (106, 12, N'1203', N'Chanchamayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (107, 12, N'1204', N'Jauja')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (108, 12, N'1205', N'Junín')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (109, 12, N'1206', N'Satipo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (110, 12, N'1207', N'Tarma')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (111, 12, N'1208', N'Yauli')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (112, 12, N'1209', N'Chupaca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (113, 13, N'1301', N'Trujillo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (114, 13, N'1302', N'Ascope')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (115, 13, N'1303', N'Bolívar')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (116, 13, N'1304', N'Chepén')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (117, 13, N'1305', N'Julcán')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (118, 13, N'1306', N'Otuzco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (119, 13, N'1307', N'Pacasmayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (120, 13, N'1308', N'Pataz')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (121, 13, N'1309', N'Sánchez Carrión')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (122, 13, N'1310', N'Santiago de Chuco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (123, 13, N'1311', N'Gran Chimú')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (124, 13, N'1312', N'Virú')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (125, 14, N'1401', N'Chiclayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (126, 14, N'1402', N'Ferreñafe')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (127, 14, N'1403', N'Lambayeque')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (128, 15, N'1501', N'Lima')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (129, 15, N'1502', N'Barranca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (130, 15, N'1503', N'Cajatambo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (131, 15, N'1504', N'Canta')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (132, 15, N'1505', N'Cañete')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (133, 15, N'1506', N'Huaral')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (134, 15, N'1507', N'Huarochirí')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (135, 15, N'1508', N'Huaura')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (136, 15, N'1509', N'Oyón')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (137, 15, N'1510', N'Yauyos')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (138, 16, N'1601', N'Maynas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (139, 16, N'1602', N'Alto Amazonas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (140, 16, N'1603', N'Loreto')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (141, 16, N'1604', N'Mariscal Ramón Castilla')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (142, 16, N'1605', N'Requena')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (143, 16, N'1606', N'Ucayali')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (144, 16, N'1607', N'Datem del Marañón')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (145, 16, N'1608', N'Putumayo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (146, 17, N'1701', N'Tambopata')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (147, 17, N'1702', N'Manu')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (148, 17, N'1703', N'Tahuamanu')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (149, 18, N'1801', N'Mariscal Nieto')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (150, 18, N'1802', N'General Sánchez Cerro')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (151, 18, N'1803', N'Ilo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (152, 19, N'1901', N'Pasco')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (153, 19, N'1902', N'Daniel Alcides Carrión')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (154, 19, N'1903', N'Oxapampa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (155, 20, N'2001', N'Piura')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (156, 20, N'2002', N'Ayabaca')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (157, 20, N'2003', N'Huancabamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (158, 20, N'2004', N'Morropón')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (159, 20, N'2005', N'Paita')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (160, 20, N'2006', N'Sullana')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (161, 20, N'2007', N'Talara')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (162, 20, N'2008', N'Sechura')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (163, 21, N'2101', N'Puno')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (164, 21, N'2102', N'Azángaro')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (165, 21, N'2103', N'Carabaya')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (166, 21, N'2104', N'Chucuito')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (167, 21, N'2105', N'El Collao')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (168, 21, N'2106', N'Huancané')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (169, 21, N'2107', N'Lampa')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (170, 21, N'2108', N'Melgar')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (171, 21, N'2109', N'Moho')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (172, 21, N'2110', N'San Antonio de Putina')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (173, 21, N'2111', N'San Román')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (174, 21, N'2112', N'Sandia')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (175, 21, N'2113', N'Yunguyo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (176, 22, N'2201', N'Moyobamba')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (177, 22, N'2202', N'Bellavista')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (178, 22, N'2203', N'El Dorado')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (179, 22, N'2204', N'Huallaga')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (180, 22, N'2205', N'Lamas')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (181, 22, N'2206', N'Mariscal Cáceres')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (182, 22, N'2207', N'Picota')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (183, 22, N'2208', N'Rioja')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (184, 22, N'2209', N'San Martín')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (185, 22, N'2210', N'Tocache')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (186, 23, N'2301', N'Tacna')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (187, 23, N'2302', N'Candarave')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (188, 23, N'2303', N'Jorge Basadre')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (189, 23, N'2304', N'Tarata')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (190, 24, N'2401', N'Tumbes')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (191, 24, N'2402', N'Contralmirante Villar')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (192, 24, N'2403', N'Zarumilla')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (193, 25, N'2501', N'Coronel Portillo')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (194, 25, N'2502', N'Atalaya')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (195, 25, N'2503', N'Padre Abad')
INSERT [dbo].[Provincia] ([CodigoProvincia], [CodigoDepartamento], [CodigoUbigeo], [Nombre]) VALUES (196, 25, N'2504', N'Purús')
INSERT [dbo].[Serie] ([CodigoSerie], [CodigoTipoComprobante], [Serial], [ValorInicial], [ValorFinal], [ValorActual], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, 1, N'B001', 0, 99999999, 1, 1, NULL, CAST(N'2020-09-03T21:14:53.560' AS DateTime), NULL, CAST(N'2020-09-11T02:13:37.860' AS DateTime))
INSERT [dbo].[Serie] ([CodigoSerie], [CodigoTipoComprobante], [Serial], [ValorInicial], [ValorFinal], [ValorActual], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, 2, N'F001', 0, 99999999, 4, 1, NULL, CAST(N'2020-09-11T02:12:00.930' AS DateTime), NULL, CAST(N'2020-09-21T21:41:47.017' AS DateTime))
INSERT [dbo].[Serie] ([CodigoSerie], [CodigoTipoComprobante], [Serial], [ValorInicial], [ValorFinal], [ValorActual], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, 5, N'GR01', 0, 99999999, 1, 1, NULL, CAST(N'2020-09-25T05:25:59.727' AS DateTime), NULL, CAST(N'2020-09-25T07:49:26.600' AS DateTime))
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (1, N'Boleta')
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (2, N'Factura')
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (3, N'Nota de Crédito')
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (4, N'Nota de Débito')
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (5, N'Guía Remisión Remitente')
INSERT [dbo].[TipoComprobante] ([CodigoTipoComprobante], [Nombre]) VALUES (6, N'Guía Remisión Transportista')
INSERT [dbo].[TipoDocumento] ([CodigoTipoDocumento], [Nombre], [ValorInicial], [ValorFinal], [ValorActual], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'Letra', 0, 99999999, 24, N'auto', CAST(N'2020-09-21T00:52:50.090' AS DateTime), NULL, CAST(N'2020-09-22T01:56:50.760' AS DateTime))
INSERT [dbo].[TipoDocumentoIdentidad] ([CodigoTipoDocumentoIdentidad], [Descripcion], [CantidadCaracteres]) VALUES (1, N'DNI', 8)
INSERT [dbo].[TipoDocumentoIdentidad] ([CodigoTipoDocumentoIdentidad], [Descripcion], [CantidadCaracteres]) VALUES (2, N'RUC', 11)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'ascensor', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'pequeño aerosol', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, N'mucho calor', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (4, N'grupo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (5, N'atuendo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (6, N'racionar', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (7, N'Disparo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (8, N'palo, militar', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (9, N'ciento quince tambor kg', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (10, N'cientos de tambor lb', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (11, N'galón cincuenta y cinco tambor (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (12, N'camión cisterna', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (13, N'contenedor de veinte pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (14, N'contenedor de pie cuarenta', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (15, N'decilitro por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (16, N'gramo por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (17, N'libra teórico', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (18, N'gramo por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (19, N'tonelada real', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (20, N'tonelada teórica', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (21, N'kilogramo por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (22, N'libras por mil pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (23, N'día caballos de potencia por tonelada métrica seca de aire', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (24, N'volumen de capturas', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (25, N'kilogramo por tonelada métrica seca de aire', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (26, N'kilopascales metro cuadrado por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (27, N'kilopascales por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (28, N'mililitro por segundo centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (29, N'pie cúbico por minuto por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (30, N'onzas por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (31, N'onzas por pie cuadrado por 0,01inch', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (32, N'mililitro por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (33, N'mililitro por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:24.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (34, N'bolsa de súper mayor', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (35, N'bolsa a granel Fivehundred kg', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (36, N'bolsa a granel threehundred kg', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (37, N'bolsa a granel cincuenta libras', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (38, N'bolsa de cincuenta libras', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (39, N'carga de la cabina mayor', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (40, N'kilogramo teórico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (41, N'tonelada teórica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (42, N'sitas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (43, N'malla', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.013' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (44, N'kilogramo neto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.013' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (45, N'parte por millón', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.013' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (46, N'por ciento en peso', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.013' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (47, N'parte por mil millones (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.013' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (48, N'por ciento por 1000 horas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (49, N'tasa de fracaso en el tiempo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (50, N'libra por pulgada cuadrada, de calibre', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (51, N'Oersted', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (52, N'escala específica de prueba', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (53, N'voltiamperio por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (54, N'vatios por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (55, N'tum amperios por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (56, N'milipascales', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (57, N'gauss', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (58, N'mili pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (59, N'kilogauss', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (60, N'libra por pulgada cuadrada absoluta', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (61, N'Enrique', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (62, N'kilopound-fuerza por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (63, N'pie-libra fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (64, N'libras por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (65, N'equilibrio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (66, N'segundo universales Saybold', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.023' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (67, N'Stokes', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.023' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (68, N'calorías por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.023' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (69, N'calorías por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.027' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (70, N'unidad de rizo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.027' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (71, N'veinte mil galones tankcar (EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.027' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (72, N'diez mil galones tankcar (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.027' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (73, N'kg tambor diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.030' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (74, N'tambor quince kg', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.030' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (75, N'millas de coche', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.030' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (76, N'recuento de coche', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.030' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (77, N'recuento locomotora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.030' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (78, N'vagón de cola recuento', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.033' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (79, N'coche vacío', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.033' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (80, N'tren millas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.033' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (81, N'el uso de combustible galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.037' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (82, N'vagón de cola millas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.037' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (83, N'tipo de interés fijo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.037' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (84, N'tonelada millas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.037' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (85, N'millas locomotora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.040' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (86, N'recuento total de coche', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.040' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (87, N'millas total de automóviles', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.040' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (88, N'cuarto de milla', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.040' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (89, N'radián por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.040' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (90, N'radián por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (91, N'Roentgen', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (92, N'voltios de CA.', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (93, N'voltios DC', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (94, N'unidad térmica Británica (tabla internacional) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (95, N'centímetro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (96, N'pie cúbico por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (97, N'pies cúbicos por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (98, N'centímetro por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (99, N'decibel', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (100, N'kilobyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (101, N'kilobecquerel', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (102, N'kilocurie', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (103, N'megagramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (104, N'megagramo por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (105, N'compartimiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (106, N'metros por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (107, N'miliroentgen', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (108, N'milivoltios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (109, N'megajulio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (110, N'manmonth', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (111, N'libra por libra de producto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.053' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (112, N'libra por pieza de producto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.053' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (113, N'kilogramo por kilogramo de producto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.053' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (114, N'kilogramo por pieza de producto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (115, N'bobina', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (116, N'gorra', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (117, N'centistokes', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (118, N'paquete de veinte', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (119, N'microlitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (120, N'micrómetros (micras)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (121, N'miliamperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (122, N'megabyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (123, N'miligramo por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (124, N'megabequerelios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (125, N'microfaradios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (126, N'newton por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (127, N'oz pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (128, N'pies oz', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (129, N'picofaradios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (130, N'libra por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (131, N'tonelada (US) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (132, N'kiloliter por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (133, N'barril (US) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.093' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (134, N'lote', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.093' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (135, N'galón (US) por mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.093' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (136, N'MMPCS / día', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (137, N'libras por mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (138, N'bomba', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (139, N'etapa', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (140, N'pies cúbicos estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (141, N'caballos de potencia hidráulica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (142, N'contar por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (143, N'nivel sísmica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (144, N'línea sísmica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (145, N'15 ° C calorías', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.103' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (146, N'amperio metro cuadrado por segundo joule', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.103' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (147, N'angstrom', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.103' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (148, N'unidad astronómica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.107' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (149, N'attojoule', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (150, N'granero', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (151, N'granero por electronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (152, N'granero por estereorradián electronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (153, N'granero por estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (154, N'becquerel por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (155, N'becquerel por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.113' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (156, N'amperios por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.113' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (157, N'unidad térmica Británica (tabla internacional) por segundo grado Rankine pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.113' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (158, N'Unidad térmica británica (tabla internacional) por libra grado Rankine', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.113' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (159, N'unidad térmica Británica (tabla internacional) por segundo Rankine grado pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.113' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (160, N'Unidad térmica británica (tabla internacional) por hora Rankine pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.117' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (161, N'candelas por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.117' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (162, N'Vapeur cheval', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.117' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (163, N'Coulomb metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.117' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (164, N'Coulomb metros al cuadrado por voltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.120' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (165, N'culombio por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.127' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (166, N'culombio por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.130' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (167, N'amperios por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (168, N'culombio por milímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (169, N'culombio por segundo kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (170, N'coulomb por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (171, N'culombio por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (172, N'culombio por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (173, N'culombio por milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (174, N'centímetro cúbico por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (175, N'decímetro cúbico por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (176, N'metro cúbico por Coulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (177, N'metro cúbico por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (178, N'amperios por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (179, N'metro cúbico por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (180, N'amperios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (181, N'curie por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (182, N'tonelaje de peso muerto', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (183, N'decalitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (184, N'decámetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (185, N'decitex', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (186, N'Rankine', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (187, N'negador', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (188, N'amperios metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (189, N'segundo dinas por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (190, N'segundo dinas por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (191, N'segundo dinas por centímetro a la quinta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (192, N'electronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (193, N'electronvolt por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (194, N'electronvolt metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (195, N'electronvolt metro cuadrado por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (196, N'ergio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (197, N'erg por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (198, N'la cobertura de nubes 8-parte', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (199, N'amperio por metro cuadrado kelvin cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (200, N'erg por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.300' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (201, N'erg por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (202, N'erg por gramo segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (203, N'erg por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (204, N'erg por segundo centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (205, N'erg por segundo centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (206, N'erg centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (207, N'erg centímetro cuadrado por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.347' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (208, N'ExaJoule', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.347' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (209, N'faradios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.353' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (210, N'amperios por milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.357' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (211, N'femtojoule', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (212, N'femtometro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (213, N'pie por segundo cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.363' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (214, N'pie-libra fuerza por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.363' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (215, N'tonelada de carga', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (216, N'galón', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (217, N'Gaussian CGS (centímetro-Gram-segundo sistema) unidad de desplazamiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (218, N'CGS de Gauss (centímetro-gramo-segundo sistema) unidad de corriente eléctrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.390' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (219, N'CGS de Gauss (centímetro-gramo-segundo sistema) unidad de carga eléctrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.390' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (220, N'segundo amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.393' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (221, N'CGS de Gauss (centímetro-gramo-segundo sistema) Unidad de intensidad de campo eléctrico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.400' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (222, N'Gaussian CGS (centímetro-Gram-segundo sistema) unidad de polarización eléctrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.410' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (223, N'CGS de Gauss (centímetro-gramo-segundo sistema) Unidad de potencial eléctrico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.410' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (224, N'CGS de Gauss (centímetro-gramo-segundo sistema) unidad de magnetización', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.413' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (225, N'gigacoulomb por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (226, N'gigaelectronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (227, N'gigahercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (228, N'gigaohmio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.443' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (229, N'metros gigaohmio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.443' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (230, N'gigapascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (231, N'Velocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (232, N'gigavatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (233, N'gon', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (234, N'gramo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (235, N'gramo por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (236, N'gris', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (237, N'gris por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (238, N'hectopascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (239, N'henry por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.510' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (240, N'poco', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.513' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (241, N'pelota', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.517' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (242, N'paquete a granel', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.520' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (243, N'acre', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.523' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (244, N'actividad', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.527' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (245, N'byte', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.527' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (246, N'amperios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (247, N'minuto adicional', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (248, N'minuto y medio por llamada', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (249, N'policía', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (250, N'braza', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (251, N'línea de acceso', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (252, N'ampolla', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (253, N'amperio-hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (254, N'amperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (255, N'año', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.537' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (256, N'solamente libra de aluminio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.543' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (257, N'oz troy o oz boticario', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.547' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (258, N'factor anti-hemofílico unidad (AHF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (259, N'supositorio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (260, N'son', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.557' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (261, N'surtido', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.557' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (262, N'grado alcohólico másico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.557' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (263, N'grado alcohólico volumétrico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.560' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (264, N'atmósfera estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.560' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (265, N'ambiente técnico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.560' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (266, N'cápsula', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.560' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (267, N'vial lleno de polvo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.570' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (268, N'American Wire Gauge', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.577' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (269, N'montaje', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.577' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (270, N'Unidad térmica británica (tabla internacional) por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (271, N'BTU por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (272, N'barril (US) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.613' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (273, N'bits por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (274, N'julio por kilogramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (275, N'julios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.647' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (276, N'julios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (277, N'julios por metro a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.657' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (278, N'joule por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.660' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (279, N'joule por mol kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.660' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (280, N'crédito', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.660' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (281, N'segundo julios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.667' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (282, N'dígito', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.667' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (283, N'litera', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.670' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (284, N'metro cuadrado julio por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.677' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (285, N'Kelvin por vatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.680' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (286, N'kiloamperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.687' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (287, N'kiloamperios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.690' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (288, N'kiloamperios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.690' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (289, N'kilobecquerel por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.713' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (290, N'kilocoulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.720' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (291, N'kilocoulomb por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.723' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (292, N'kilocoulomb por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.730' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (293, N'kiloelectronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.733' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (294, N'libra de bateo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.737' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (295, N'gibibit', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.740' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (296, N'metros kilogramo por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.743' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (297, N'kilogramo metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (298, N'metros kilogramo cuadrado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (299, N'kilogramo por decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.753' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (300, N'kilogramo por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.757' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (301, N'calorías (termoquímico) por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.757' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (302, N'kilogramo-fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.757' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (303, N'metros kilogramo-fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.757' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (304, N'metros kilogramo-fuerza por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.793' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (305, N'barril, imperial', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.800' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (306, N'kilogramo-fuerza por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.810' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (307, N'kilojulios por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.813' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (308, N'kilojulios por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.820' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (309, N'kilojulios por kilogramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.823' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (310, N'kilojulios por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.827' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (311, N'kilomol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.833' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (312, N'kilomol por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.847' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (313, N'kilonewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.850' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (314, N'kilonewton metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.853' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (315, N'kiloohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (316, N'palanquilla', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.860' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (317, N'metros kiloohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.867' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (318, N'Kilopond', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.870' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (319, N'kilosecond', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.900' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (320, N'kilosiemens', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.907' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (321, N'kilosiemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.910' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (322, N'kilovoltios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.923' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (323, N'kiloweber por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.960' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (324, N'año luz', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.963' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (325, N'litros por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (326, N'lumen hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (327, N'bollo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (328, N'lumen por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (329, N'lumen por vatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (330, N'lumen segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (331, N'lux hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (332, N'segundo lux', 1, N'AUTO', CAST(N'2020-08-11T01:11:25.990' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (333, N'Maxwell', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (334, N'megaampere por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.110' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (335, N'megabecquerel por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.120' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (336, N'gigabit', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.120' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (337, N'megacoulomb por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.123' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (338, N'ciclo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.127' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (339, N'megacoulomb por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (340, N'megaelectronvolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (341, N'megagramo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (342, N'meganewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (343, N'metros meganewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (344, N'megaohmio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (345, N'metros megaohmio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (346, N'megasiemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (347, N'megavoltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (348, N'megavolt por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (349, N'julios por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (350, N'gigabit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (351, N'metro cuadrado recíproco segundos recíprocos', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (352, N'pulgadas por pie lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (353, N'metros a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (354, N'microamperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (355, N'MICROBAR', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (356, N'microculombios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (357, N'microculombios por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (358, N'microculombios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (359, N'microfaradios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (360, N'napa', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (361, N'microhenrio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (362, N'microhenrio por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (363, N'micronewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (364, N'metros micronewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (365, N'microohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (366, N'metros microohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (367, N'micropascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.340' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (368, N'microradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.350' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (369, N'microsegundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.353' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (370, N'microsiemens', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.357' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (371, N'Bar [unidad de presión]', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (372, N'caja de base', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (373, N'tablero', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.383' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (374, N'haz', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.390' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (375, N'pie tablar', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.407' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (376, N'bolso', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.410' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (377, N'cepillo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.413' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (378, N'potencia al freno', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.417' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (379, N'mil millones (EUR)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.420' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (380, N'Cubeta', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.423' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (381, N'cesta', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.423' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (382, N'bala', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (383, N'barril seco (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (384, N'barril (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.447' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (385, N'botella', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (386, N'cientos de pies bordo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.517' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (387, N'latidos por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.520' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (388, N'becquerel', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.527' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (389, N'Bar [unidad de embalaje]', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (390, N'tornillo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.537' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (391, N'unidad térmica Británica (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.540' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (392, N'bushel (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.547' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (393, N'bushel (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (394, N'peso base de', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.557' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (395, N'caja', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.560' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (396, N'millones de BTU', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.563' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (397, N'llamada', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.570' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (398, N'compuesto libra producto (peso total)', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.570' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (399, N'millifarad', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.573' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (400, N'miligales', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.587' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (401, N'miligramo por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.587' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (402, N'miligray', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (403, N'milihenrio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (404, N'millijoule', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (405, N'milímetro por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (406, N'milímetro cuadrado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (407, N'milimol', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.590' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (408, N'mol por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (409, N'carset', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (410, N'milinewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (411, N'kibibit', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (412, N'milinewton por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (413, N'metros miliohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (414, N'milipascales segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (415, N'milirradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (416, N'milisegundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (417, N'millisiemens', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (418, N'milisievert', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (419, N'militeslas', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.597' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (420, N'microvoltios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (421, N'milivoltios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (422, N'milivatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (423, N'milivatios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (424, N'milliweber', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (425, N'Topo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (426, N'mol por decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (427, N'mol por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.600' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (428, N'kilobits', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (429, N'mol por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (430, N'nA', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (431, N'partido de carga', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (432, N'nanocoulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (433, N'nanofaradios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.607' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (434, N'nanofaradios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (435, N'nanohenry', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.643' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (436, N'nanohenry por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (437, N'nanómetros', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.670' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (438, N'metros nanoohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.693' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (439, N'nanosegundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.697' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (440, N'nanotesla', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.707' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (441, N'nanoWatt', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.717' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (442, N'costo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.717' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (443, N'neper', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.717' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (444, N'neper por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.720' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (445, N'Picómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.720' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (446, N'segunda metros newton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.747' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (447, N'newton metro cuadrado por kilogramo cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (448, N'newton por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.753' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (449, N'newton por milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.757' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (450, N'segundo newton', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.763' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (451, N'newton segundo por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.777' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (452, N'octava', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.780' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (453, N'célula', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.803' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (454, N'centímetro ohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.810' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (455, N'ohmímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.827' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (456, N'uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.830' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (457, N'parsec', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.847' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (458, N'por kelvin Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.850' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (459, N'pascal segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.853' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (460, N'segundos pascal por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (461, N'segundos pascal por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.860' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (462, N'petajulio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.863' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (463, N'phon', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.870' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (464, N'centipoises', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.873' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (465, N'micromicroamperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.887' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (466, N'picocoulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.900' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (467, N'picofaradios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.907' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (468, N'picohenry', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.910' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (469, N'kilobits por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.913' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (470, N'picowatt', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.920' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (471, N'picowatt por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.923' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (472, N'Gage libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (473, N'libra fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (474, N'kilovoltios horas amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (475, N'millicoulomb por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (476, N'rad', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (477, N'radián', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (478, N'metro cuadrado radián por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.987' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (479, N'metro cuadrado radián por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.990' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (480, N'radianes por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:26.997' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (481, N'recíproco Angstrom', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.007' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (482, N'metro cúbico de reciprocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.010' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (483, N'recíproco metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.017' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (484, N'voltios de electrones recíproca por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.027' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (485, N'recíproco Henry', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.047' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (486, N'grupo bobina', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.060' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (487, N'julios por metro cúbico de reciprocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.060' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (488, N'kelvin recíproco o kelvin a la potencia menos uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.063' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (489, N'metros recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.063' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (490, N'metro cuadrado recíproco', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.063' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (491, N'minutos recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.067' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (492, N'topo recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.070' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (493, N'recíproco Pascal o Pascal a la potencia menos uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (494, N'segundo recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (495, N'recíproco segundo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (496, N'recíproco segundo por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.087' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (497, N'lata', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (498, N'la capacidad de carga en toneladas métricas', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (499, N'candela', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.093' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (500, N'grado Celsius', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.097' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (501, N'cien', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (502, N'tarjeta', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (503, N'centigramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (504, N'envase', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (505, N'cono', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (506, N'conector', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (507, N'coulomb por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (508, N'bobina', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (509, N'cientos de licencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (510, N'centilitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (511, N'centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (512, N'centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (513, N'centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (514, N'cientos de paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.350' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (515, N'cental (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (516, N'garrafón', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (517, N'culombio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (518, N'cartucho', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (519, N'caja', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.383' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (520, N'caso', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.383' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (521, N'caja de cartón', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.417' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (522, N'gramo de contenido', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.420' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (523, N'quilate métrico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (524, N'tonelada de contenido (métrica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (525, N'taza', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (526, N'curie', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (527, N'cubrir', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (528, N'cien libras (CWT) / quintal (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (529, N'quintal (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.443' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (530, N'cilindro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.443' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (531, N'combo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.447' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (532, N'kilovatio hora por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.447' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (533, N'muchos [unidad de peso]', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (534, N'segundo recíproca por estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (535, N'siemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (536, N'mebibit', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (537, N'siemens metro cuadrado por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.450' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (538, N'sievert', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (539, N'mil yardas lineales', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (540, N'sone', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (541, N'centímetro cuadrado por erg', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (542, N'centímetro cuadrado por estereorradián erg', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (543, N'kelvin metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (544, N'kelvin metro cuadrado por vatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.453' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (545, N'recíproco segundo por metro cuadrado estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (546, N'metro cuadrado por Joule', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (547, N'metro cuadrado por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (548, N'metro cuadrado por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (549, N'gramo pluma (proteína)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (550, N'metro cuadrado por estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (551, N'metro cuadrado por estereorradián julios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (552, N'metro cuadrado por segundo voltios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (553, N'estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (554, N'sifón', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (555, N'terahercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (556, N'terajulio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (557, N'teravatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (558, N'teravatios hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (559, N'tesla', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (560, N'Texas', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (561, N'calorías (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (562, N'megabit', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (563, N'calorías (termoquímico) por gramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (564, N'calorías (termoquímico) por segundo kelvin centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (565, N'calorías (termoquímico) por segundo kelvin centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.510' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (566, N'miles de litros', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (567, N'tonelada por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.540' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (568, N'año tropical', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.553' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (569, N'unidad de masa atómica unificada', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (570, N'var', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (571, N'voltios cuadrado por kelvin cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (572, N'voltios - amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (573, N'voltios por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.637' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (574, N'voltios por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.637' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (575, N'milivoltios por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.643' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (576, N'kilogramo por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.643' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (577, N'voltios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.643' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (578, N'voltios por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.647' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (579, N'vatios por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (580, N'vatios por kelvin metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (581, N'vatios por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (582, N'vatio por metro cuadrado kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.650' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (583, N'vatio por metro cuadrado kelvin a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.653' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (584, N'watt por estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.653' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (585, N'vatios por metro cuadrado estereorradián', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.657' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (586, N'weber por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.657' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (587, N'roentgen por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.673' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (588, N'weber por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.677' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (589, N'minuto [Unidad de ángulo]', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.677' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (590, N'segundos [Unidad de ángulo]', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.697' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (591, N'libro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.710' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (592, N'bloquear', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.713' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (593, N'redondo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.720' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (594, N'casete', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.720' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (595, N'dólar por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.740' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (596, N'número de palabras', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.747' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (597, N'pulgada a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.747' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (598, N'emparedado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.783' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (599, N'calorías (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.783' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (600, N'calorías (tabla internacional) por segundo kelvin centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.787' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (601, N'calorías (tabla internacional) por segundo kelvin centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.787' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (602, N'metro cuadrado julios', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.787' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (603, N'kilogramo por mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.787' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (604, N'calorías (tabla internacional) por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.790' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (605, N'calorías (tabla internacional) por gramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.790' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (606, N'megacoulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.810' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (607, N'megajoule por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.830' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (608, N'haz', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.830' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (609, N'puntuación Draize', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.837' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (610, N'microvatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.837' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (611, N'microteslas', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.837' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (612, N'microvoltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.840' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (613, N'metros milinewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.840' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (614, N'microvatio por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.843' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (615, N'millicoulomb', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.847' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (616, N'milimoles por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.850' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (617, N'millicoulomb por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.850' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (618, N'millicoulomb por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.853' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (619, N'dinas por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (620, N'metro cúbico (neto)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (621, N'movimiento rápido del ojo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (622, N'banda', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.857' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (623, N'segundo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.860' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (624, N'segundos por radián metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.860' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (625, N'joule por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.883' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (626, N'bruto libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.887' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (627, N'pallet de carga / unidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.887' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (628, N'libra de masa', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.893' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (629, N'manga', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.893' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (630, N'decare', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.900' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (631, N'diez días', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.903' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (632, N'día', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.907' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (633, N'libra seca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.910' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (634, N'disco (disco)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.913' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (635, N'grado [Unidad de ángulo]', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.920' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (636, N'acuerdo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.927' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (637, N'década', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.930' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (638, N'decigramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.930' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (639, N'dispensador', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (640, N'decagramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (641, N'decilitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (642, N'decametre cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (643, N'decímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (644, N'kiloliter norma', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (645, N'decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (646, N'decímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.937' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (647, N'metros decinewton', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.940' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (648, N'docenas de piezas', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.940' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (649, N'docenas de pares', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.943' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (650, N'peso de desplazamiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.943' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (651, N'registro de datos', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.943' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (652, N'tambor', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (653, N'dram (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (654, N'dram (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (655, N'docena de rollo', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (656, N'dracma (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (657, N'monitor', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.947' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (658, N'tonelada seca', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.950' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (659, N'decitonelada', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.950' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (660, N'dina', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.950' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (661, N'peso de veinte-cuatro granos', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.950' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (662, N'dinas por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.950' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (663, N'libro de directorio', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.953' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (664, N'docena', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.953' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (665, N'docena de paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.953' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (666, N'Newton por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.953' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (667, N'megavatio hora por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:27.953' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (668, N'megavatios por hercio', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.000' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (669, N'miliamperios hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.000' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (670, N'día de grado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.000' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (671, N'gigacaloría', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.000' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (672, N'Mille', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.000' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (673, N'kilocaloría (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.003' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (674, N'kilocaloría (termoquímico) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.003' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (675, N'millones de Btu (IT) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.003' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (676, N'pie cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.003' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (677, N'tonelada por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (678, N'silbido', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (679, N'cinturón', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.020' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (680, N'megabit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.037' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (681, N'Comparte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.043' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (682, N'TUE', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.050' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (683, N'neumático', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.053' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (684, N'unidad activa', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.057' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (685, N'dosis', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.060' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (686, N'tonelada seca de aire', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.063' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (687, N'remolque', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.070' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (688, N'hebra', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.070' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (689, N'metro cuadrado por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.077' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (690, N'litros por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.080' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (691, N'por mil pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.083' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (692, N'gigabyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.090' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (693, N'terabyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (694, N'petabyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (695, N'pixel', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.123' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (696, N'megapíxeles', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.127' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (697, N'puntos por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.130' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (698, N'kilo bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.130' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (699, N'parte por cien mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (700, N'kilogramo-fuerza por milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.137' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (701, N'kilogramo-fuerza por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (702, N'julios por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (703, N'metros kilogramo-fuerza por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (704, N'miliohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (705, N'kilovatio hora por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (706, N'kilovatio hora por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (707, N'unidad de servicio', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (708, N'día de trabajo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (709, N'tonelada métrica de largo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (710, N'unidad de contabilidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (711, N'trabajo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (712, N'pies de ejecución', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (713, N'prueba', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (714, N'viaje', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (715, N'utilizar', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (716, N'bien', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (717, N'zona', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (718, N'exabit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (719, N'exbibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (720, N'pebibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (721, N'tebibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (722, N'gibibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (723, N'mebibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (724, N'kibibyte', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (725, N'exbibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (726, N'exbibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (727, N'exbibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (728, N'gigabyte por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (729, N'gibibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (730, N'gibibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (731, N'gibibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (732, N'kibibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (733, N'kibibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (734, N'kibibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (735, N'mebibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.373' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (736, N'mebibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (737, N'mebibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.400' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (738, N'petabit', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (739, N'petabit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (740, N'pebibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (741, N'pebibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (742, N'pebibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.477' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (743, N'terabits', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.507' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (744, N'terabit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.520' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (745, N'tebibit por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (746, N'tebibit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.533' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (747, N'tebibit por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.567' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (748, N'bits por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.570' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (749, N'bits por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (750, N'centímetro recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.640' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (751, N'día recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:28.670' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (752, N'decímetro cúbico por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.097' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (753, N'kilogramo por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (754, N'kilomol por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.100' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (755, N'mol por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (756, N'grado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (757, N'milímetro por cada grado Celsius metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (758, N'Grado Celsius por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (759, N'por barra hectopascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (760, N'cada', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (761, N'casilla de correo electrónico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (762, N'cada uno por mes', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (763, N'once paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (764, N'galón equivalente', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (765, N'sobre', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (766, N'bit por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (767, N'kelvin por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (768, N'kilopascales por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (769, N'milibares por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (770, N'por barra megapascales', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (771, N'aplomo por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (772, N'por barra Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (773, N'miliamperios por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (774, N'miles de pies cúbicos por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (775, N'kelvin por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.333' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (776, N'kelvin por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.333' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (777, N'kelvin por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.333' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (778, N'babosa', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.333' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (779, N'gramo por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.337' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (780, N'kilogramo por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.337' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (781, N'miligramo por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.337' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (782, N'libra fuerza por pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.340' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (783, N'kilogramo centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.340' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (784, N'kilogramo milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.340' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (785, N'libra pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.343' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (786, N'libra fuerza pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.343' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (787, N'pie-libra fuerza por amperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.347' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (788, N'gramo por decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.347' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (789, N'kilogramo por kilomol', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.350' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (790, N'gramo por hertz', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.350' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (791, N'gramo por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.350' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (792, N'gramo por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.353' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (793, N'gramo por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.353' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (794, N'gramo por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.353' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (795, N'kilogramo por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.357' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (796, N'kilogramo por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.357' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (797, N'miligramo por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (798, N'miligramo por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (799, N'miligramo por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.360' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (800, N'gramo por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.360' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (801, N'gramo por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.363' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (802, N'gramo por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.363' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (803, N'gramo por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (804, N'kilogramo por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (805, N'kilogramo por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.367' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (806, N'kilogramo por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (807, N'kilogramo por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (808, N'miligramo por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (809, N'miligramo por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (810, N'miligramo por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.370' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (811, N'miligramo por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.373' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (812, N'newton por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.373' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (813, N'libra-fuerza por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (814, N'varilla de [unidad de distancia]', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (815, N'micrómetro por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (816, N'centímetro por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.377' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (817, N'metro por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (818, N'milímetro por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (819, N'miliohm por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (820, N'ohmios por milla (milla terrestre)', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.380' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (821, N'ohmios por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.383' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (822, N'miliamperios por libra-fuerza por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.387' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (823, N'barra de reciprocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.393' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (824, N'miliamperios por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.400' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (825, N'Grado Celsius por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.403' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (826, N'kelvin por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.407' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (827, N'gramo por día de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.423' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (828, N'gramo por hora bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (829, N'gramo por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (830, N'gramo por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (831, N'kilogramo por día bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (832, N'kilogramo por hora bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.427' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (833, N'kilogramo por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (834, N'kilogramo por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (835, N'miligramo por día bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (836, N'miligramo por bar hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (837, N'miligramo por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (838, N'miligramo por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (839, N'gramo por bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (840, N'miligramo por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (841, N'miliamperios por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.430' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (842, N'segundos pascal por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (843, N'pulgada de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (844, N'pulgadas de mercurio', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (845, N'caballos de potencia del agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (846, N'bar por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (847, N'hectopascal por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.433' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (848, N'kilopascales por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (849, N'milibares por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (850, N'megapascales por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (851, N'aplomo por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.437' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (852, N'voltio por minuto litros', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (853, N'centímetro newton', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (854, N'newton metro por grado', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (855, N'fibra por centímetro cúbico de aire', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (856, N'newton metro por amperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (857, N'bar litros por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (858, N'bar metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.440' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (859, N'litros hectopascal por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (860, N'hectopascal metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (861, N'litros milibares por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.510' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (862, N'milibares metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (863, N'litros megapascales por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (864, N'megapascales metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (865, N'litros pascal por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (866, N'grados Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (867, N'faradio', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.663' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (868, N'campo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.663' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (869, N'metros de fibra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.663' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (870, N'mil pies cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.663' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (871, N'millones de partículas por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.667' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (872, N'pie de pista', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.700' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (873, N'centenar de metros cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.707' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (874, N'parche transdérmico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.710' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (875, N'micromol', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.713' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (876, N'fallas en el tiempo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.727' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (877, N'tonelada de escamas', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.727' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (878, N'millones de pies cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.730' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (879, N'pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.737' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (880, N'libras por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.743' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (881, N'pies por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (882, N'pie por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (883, N'pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (884, N'pie cubico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.750' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (885, N'pascal metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.763' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (886, N'centímetro por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.767' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (887, N'metros por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.770' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (888, N'milímetro por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.777' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (889, N'pulgada cuadrada por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.780' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (890, N'metro cuadrado por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.783' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (891, N'Stokes por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.800' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (892, N'gramo por centímetro cúbico bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.800' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (893, N'gramo por decímetro cúbico bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.803' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (894, N'gramo por litro bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.803' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (895, N'gramo por metro cúbico bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.807' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (896, N'gramo por mililitro bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.810' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (897, N'kilogramo por bar centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.813' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (898, N'kilogramo por litro bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.820' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (899, N'kilogramo por metro cúbico bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.827' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (900, N'metro newton por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.827' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (901, N'US galón por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.827' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (902, N'pie-libra fuerza por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.830' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (903, N'copa [unidad de volumen]', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.837' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (904, N'picotear', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.853' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (905, N'cucharada (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.860' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (906, N'cucharadita (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.867' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (907, N'estéreo', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.880' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (908, N'centímetro cúbico por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.897' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (909, N'litros por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:29.907' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (910, N'metro cúbico por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (911, N'galones por minuto Imperial', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (912, N'mililitro por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.457' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (913, N'kilogramo por centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (914, N'onza (avoirdupois) por yarda cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (915, N'gramo por centímetro cúbico kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (916, N'gramo por kelvin decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (917, N'gramo por litro kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.460' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (918, N'gramo por kelvin metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (919, N'gramo por mililitro kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (920, N'kilogramo por kelvin centímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (921, N'kilogramo por litro kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.463' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (922, N'kilogramo por kelvin metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.467' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (923, N'metro cuadrado por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.467' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (924, N'microsiemens por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.467' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (925, N'microsiemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.467' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (926, N'nanosiemens por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.467' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (927, N'nanosiemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.470' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (928, N'Stokes por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.470' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (929, N'centímetro cúbico por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.470' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (930, N'centímetro cúbico por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.470' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (931, N'centímetro cúbico por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.470' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (932, N'galón (US) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (933, N'litros por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (934, N'metros cúbicos por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.473' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (935, N'metro cúbico por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.477' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (936, N'mililitros por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.477' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (937, N'mililitro por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.477' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (938, N'pulgadas cúbicas por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.477' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (939, N'pulgadas cúbicas por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (940, N'pulgadas cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (941, N'miliamperios por minuto litros', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (942, N'voltios por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.480' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (943, N'centímetro cúbico por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.483' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (944, N'centímetro cúbico por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.483' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (945, N'centímetro cúbico por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (946, N'centímetro cúbico por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (947, N'litros por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (948, N'litros por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.487' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (949, N'litros por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (950, N'litros por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (951, N'metros cúbicos por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (952, N'hoja de microfichas', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (953, N'metro cúbico por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (954, N'metro cúbico por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.490' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (955, N'metro cúbico por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.493' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (956, N'mililitros por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.493' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (957, N'mililitro por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.493' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (958, N'mililitro por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.497' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (959, N'mililitro por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.497' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (960, N'milímetro a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.497' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (961, N'centímetro cúbico por día bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (962, N'centímetro cúbico por barra hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (963, N'centímetro cúbico por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (964, N'centímetro cúbico por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (965, N'litros por barra día', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.500' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (966, N'litros por barra hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.503' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (967, N'litros por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.503' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (968, N'litros por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.513' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (969, N'metros cúbicos por día de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.517' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (970, N'metros cúbicos por hora bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.520' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (971, N'metro cúbico por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (972, N'metro cúbico por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.530' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (973, N'mililitro por bar de día', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (974, N'mililitro por bar hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (975, N'mililitro por minuto bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (976, N'mililitro por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (977, N'centímetro cúbico por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.550' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (978, N'litros por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.563' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (979, N'metro cúbico por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.580' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (980, N'mililitro por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.583' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (981, N'microhenrio por kiloohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (982, N'microhenrio por ohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.593' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (983, N'galón por día (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (984, N'gigabecquerel', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (985, N'gramo por 100 gramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.603' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (986, N'barril bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.607' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (987, N'gramo, peso seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.607' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (988, N'libra por galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.607' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (989, N'gramo por metro (gramo por 100 centímetros)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.610' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (990, N'gramo de isótopo fisionable', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.610' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (991, N'gran bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.610' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (992, N'medio galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.610' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (993, N'Gill (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.613' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (994, N'gramo, incluyendo envase', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.613' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (995, N'Gill (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.617' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (996, N'gramo, incluyendo embalaje interior', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.617' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (997, N'gramo por mililitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.617' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (998, N'gramo por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.617' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (999, N'gramo por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1000, N'galón seco (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1001, N'galón (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1002, N'galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1003, N'gramo por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1004, N'galón bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1005, N'miligramo por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1006, N'miligramo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.620' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1007, N'microgramos por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1008, N'gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1009, N'grano', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1010, N'bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1011, N'tonelada de registro bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1012, N'tonelada bruta', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1013, N'gigajoule', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1014, N'galones por mil pies cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.623' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1015, N'gigavatios hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1016, N'patio bruto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1017, N'sistema Gage', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1018, N'Henry por kiloohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1019, N'Henry por ohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1020, N'milihenrio por kiloohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1021, N'milihenrio por ohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1022, N'pascal segundos bar por', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1023, N'microbecquerel', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.627' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1024, N'recíproco años', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1025, N'media página - electrónica', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1026, N'hora recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1027, N'meses recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1028, N'Grado Celsius por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1029, N'Grado Celsius por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1030, N'Grado Celsius por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1031, N'centímetro cuadrado por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1032, N'decametre cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1033, N'hectómetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.630' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1034, N'hectómetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1035, N'medio litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1036, N'kilómetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.633' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1037, N'blanco', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.637' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1038, N'voltios pulgada cuadrada por cada libra fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.777' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1039, N'voltios por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.800' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1040, N'voltios por microsegundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.817' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1041, N'por ciento por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.817' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1042, N'ohmios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.820' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1043, N'grado por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.823' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1044, N'microfaradios por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.830' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1045, N'microgramo por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.837' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1046, N'micrómetro cuadrado (micrómetros cuadrados)', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.840' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1047, N'amperio por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.847' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1048, N'amperios al cuadrado segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.847' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1049, N'faradio por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.877' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1050, N'metros hertz', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.890' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1051, N'metro Kelvin por vatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.893' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1052, N'megaohmio por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.910' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1053, N'megaohmios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.910' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1054, N'megaampere', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.927' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1055, N'kilómetro megahercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.930' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1056, N'newton por amperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.930' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1057, N'vatímetro Newton a la potencia menos 0,5', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1058, N'Pascal por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1059, N'siemens por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.933' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1060, N'TeraOhm', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.963' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1061, N'segundo voltios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.963' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1062, N'voltio por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1063, N'vatios por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1064, N'attofarad', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1065, N'centímetro por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.967' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1066, N'centímetro cúbico recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1067, N'decibelios por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1068, N'decibeles por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1069, N'kilogramo por bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.970' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1070, N'kilogramo por kelvin decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1071, N'kilogramo por bar decímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.973' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1072, N'kilogramo por segundo metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1073, N'pulgada por dos radiante pi', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1074, N'metros por segundo voltios', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.977' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1075, N'newton por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1076, N'metro cúbico por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1077, N'millisiemens por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1078, N'milivoltios por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1079, N'miligramo por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1080, N'miligramo por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1081, N'mililitros por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1082, N'milímetro por año', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.980' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1083, N'milímetro por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.983' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1084, N'milimol por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.983' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1085, N'picopascal por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.983' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1086, N'picosegundos', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.983' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1087, N'por ciento por mes', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.983' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1088, N'por ciento por hectobar', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.987' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1089, N'por ciento por decakelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.987' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1090, N'vatios por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.987' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1091, N'decapascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.990' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1092, N'gramo por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:30.993' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1093, N'módulo de ancho', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.130' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1094, N'centímetro convencional de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1095, N'de calibre francés', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1096, N'unidad de rack', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1097, N'milímetro por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1098, N'punto grande', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1099, N'litros por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1100, N'gramo milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.133' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1101, N'semana recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1102, N'trozo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1103, N'kilómetro megaohmio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1104, N'por ciento por ohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1105, N'por ciento por cada grado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1106, N'por ciento por mil diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1107, N'ciento por cien mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.137' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1108, N'ciento por cien', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1109, N'ciento por mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1110, N'por ciento por voltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1111, N'ciento por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1112, N'por ciento por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1113, N'por ciento por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1114, N'madeja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1115, N'hectárea', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1116, N'hectobar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1117, N'cientos de cajas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1118, N'cientos de recuento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1119, N'media docena', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1120, N'cien kilogramos, peso seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1121, N'centésima parte de un quilate', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1122, N'cabeza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.140' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1123, N'cientos de pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1124, N'hectogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1125, N'cientos de pies cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1126, N'cientos de hoja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1127, N'cientos de unidad internacional', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1128, N'caballos de potencia métrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1129, N'cientos de kilogramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1130, N'kilogramo cien, la masa neta', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1131, N'cien pies (lineal)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1132, N'hectolitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1133, N'millas por hora (estatuto millas)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1134, N'millones de metros cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1135, N'hectómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1136, N'milímetro convencional de mercurio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1137, N'onza troy cien', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1138, N'milímetro convencional de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1139, N'hectolitro de alcohol puro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1140, N'cientos de pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.143' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1141, N'media hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1142, N'hertz', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1143, N'hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1144, N'cientos de yardas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1145, N'pulgadas libra (libra pulgadas)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1146, N'contar por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1147, N'persona', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1148, N'pulgadas de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1149, N'columna pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1150, N'pulgada por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1151, N'impresión', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1152, N'pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1153, N'pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1154, N'pulgada cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1155, N'póliza de seguros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1156, N'grado de azúcar internacional', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1157, N'contar por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1158, N'pulgada por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.147' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1159, N'unidad internacional por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1160, N'pulgada por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1161, N'por ciento por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1162, N'por mil por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1163, N'grados API', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1164, N'grado Baume (escala de origen)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1165, N'grado Baume (pesado EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1166, N'grado Baume (luz de EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1167, N'grado Balling', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1168, N'grado Brix', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1169, N'grado Fahrenheit horas pie cuadrado por unidad térmica Británica (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1170, N'julio por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1171, N'grados Fahrenheit por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1172, N'por barra grados Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1173, N'grados Fahrenheit cuadrada horas pies por unidad térmica británica (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1174, N'grados Fahrenheit por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1175, N'grados Fahrenheit por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1176, N'grados Fahrenheit por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1177, N'grados Fahrenheit recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1178, N'grado Oechsle', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1179, N'Rankine por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.150' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1180, N'Rankine por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1181, N'Rankine por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1182, N'grado Twaddell', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1183, N'micropoise', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1184, N'microgramo por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1185, N'microgramos por metro cúbico kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1186, N'microgramos por metro cúbico de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1187, N'microlitros por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1188, N'baudios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1189, N'unidad térmica Británica (media)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1190, N'unidad térmica (tabla internacional) británica pie por grado Fahrenheit horas pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1191, N'unidad térmica (tabla internacional) pulgada británica por grado hora pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1192, N'unidad térmica (tabla internacional) pulgada británica por segundo grado pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1193, N'Unidad térmica británica (tabla internacional) por grado Fahrenheit libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1194, N'unidad térmica Británica (tabla internacional) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1195, N'unidad térmica Británica (tabla internacional) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1196, N'unidad térmica (termoquímico) pie British por grado hora pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1197, N'unidad térmica Británica (termoquímico) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.153' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1198, N'unidad térmica (termoquímico) pulgada británica por grado hora pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1199, N'unidad térmica Británica (termoquímico) pulgada por segundo grado pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1200, N'unidad térmica Británica (termoquímico) por grado Fahrenheit libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1201, N'unidad térmica Británica (termoquímico) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1202, N'unidad térmica Británica (termoquímico) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1203, N'Coulomb metro cuadrado por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1204, N'megabaudios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1205, N'segundo vatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1206, N'barra por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1207, N'barril (UK petróleo)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1208, N'barril (UK petróleo) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1209, N'barril (UK petróleo) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1210, N'barril (UK petróleo) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1211, N'barril (UK petróleo) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1212, N'barril (petróleo EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1213, N'barril (petróleo EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1214, N'bushel (Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1215, N'bushel (Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.157' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1216, N'bushel (Reino Unido) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1217, N'bushel (Reino Unido) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1218, N'bushel (seco EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1219, N'bushel (seco EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1220, N'bushel (seco EE.UU.) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1221, N'bushel (seco EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1222, N'metros centinewtons', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1223, N'centipoises por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1224, N'centipoises por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1225, N'calorías (media)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1226, N'calorías (tabla internacional) por gramo grados centígrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1227, N'calorías (termoquímico) por centímetro segundo grado Celsius', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1228, N'calorías (termoquímico) por gramo grado Celsius', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1229, N'calorías (termoquímico) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1230, N'calorías (termoquímico) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1231, N'clo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1232, N'centímetro por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1233, N'centímetro por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1234, N'centímetro cúbico por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1235, N'centímetro de mercurio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1236, N'decímetro cúbico por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1237, N'decímetro cúbico por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1238, N'decímetro cúbico por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1239, N'decímetro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.160' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1240, N'centímetro dina', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1241, N'oz (líquido Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1242, N'oz (líquido Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1243, N'oz (líquido Reino Unido) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1244, N'oz (líquido UK) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1245, N'oz (líquido EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1246, N'jumbo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1247, N'joule por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1248, N'jarra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1249, N'megajoule por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1250, N'megajulios por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1251, N'conjunto de tuberías', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1252, N'articulación', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1253, N'joule', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1254, N'centenar de medidor de', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1255, N'tarro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1256, N'número de joyas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1257, N'la demanda de kilovatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.163' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1258, N'oz (líquido EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1259, N'oz (líquido EE.UU.) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1260, N'oz (líquido EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1261, N'pie por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1262, N'pie por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1263, N'pie-libra fuerza por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1264, N'pie-libra fuerza por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1265, N'pie por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1266, N'pie por segundo grados Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1267, N'pie por segundo psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1268, N'kilovoltios amperios demanda reactiva', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1269, N'pie cúbico recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1270, N'pie cúbico por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1271, N'pies cúbicos por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.167' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1272, N'pie cúbico por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1273, N'pie de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1274, N'pie de mercurio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1275, N'galón (Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1276, N'galón (Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1277, N'galón (Reino Unido) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1278, N'kilovoltios amperios hora reactiva', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1279, N'galón (líquido EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1280, N'gram-fuerza por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1281, N'Gill (Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1282, N'Gill (Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1283, N'Gill (Reino Unido) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1284, N'Gill (Reino Unido) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1285, N'Gill (EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.170' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1286, N'Gill (US) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1287, N'Gill (US) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1288, N'Gill (US) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1289, N'aceleración de la caída libre', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1290, N'grano por galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1291, N'caballos de fuerza (caldera)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1292, N'caballos de fuerza (eléctrica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1293, N'pulgadas por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1294, N'pulgada por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1295, N'pulgada por segundo grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1296, N'pulgada por segundo psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1297, N'pulgada cúbica recíproco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1298, N'kilovoltios amperios (reactivo)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1299, N'kilobaud', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1300, N'kilocaloría (media)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1301, N'kilocaloría (tabla internacional) por hora grados centígrados metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1302, N'kilocaloría (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.173' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1303, N'kilocaloría (termoquímico) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1304, N'kilocaloría (termoquímico) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1305, N'kilomol por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1306, N'kilomol por kelvin metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1307, N'kiloliter', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1308, N'kilomol por barra metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1309, N'kilomol por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1310, N'litros por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1311, N'litros de reciprocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1312, N'libra (avoirdupois) por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1313, N'libra (avoirdupois) pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1314, N'libra (avoirdupois) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.177' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1315, N'libra por hora pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1316, N'libra por segundo pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1317, N'libra (avoirdupois) por grado Fahrenheit pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1318, N'libra (avoirdupois) por pie cúbico psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1319, N'libra (avoirdupois) por galón (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1320, N'libra (avoirdupois) por grado Fahrenheit hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1321, N'libra (avoirdupois) por hora psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1322, N'libra (avoirdupois) por cúbico grado pulgadas Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1323, N'libra (avoirdupois) por cúbico psi pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1324, N'libra (avoirdupois) por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1325, N'libra (avoirdupois) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1326, N'libra (avoirdupois) por grado minutos Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1327, N'libra (avoirdupois) por minuto psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1328, N'libra (avoirdupois) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1329, N'libra (avoirdupois) por segundo grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1330, N'libra (avoirdupois) por segundo psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1331, N'libras por yarda cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1332, N'libra fuerza por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1333, N'libra fuerza por metro cuadrado grado pulgadas Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1334, N'psi pulgada cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1335, N'litros psi por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1336, N'psi metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1337, N'psi yarda cúbica por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1338, N'segundo libra fuerza por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.180' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1339, N'segundo libra por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1340, N'psi recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1341, N'cuarto (líquido UK) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1342, N'cuarto (líquido UK) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1343, N'cuarto (líquido UK) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1344, N'cuarto (líquido UK) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1345, N'cuarto (líquido EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1346, N'cuarto (líquido EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1347, N'pastel', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1348, N'katal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1349, N'kilocharacter', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1350, N'kilobar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1351, N'kilogramo de cloruro de colina', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1352, N'kilogramo decimal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.183' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1353, N'kilogramo peso neto escurrido', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1354, N'kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1355, N'kilopacket', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1356, N'barrilete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1357, N'kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1358, N'kilogramo por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1359, N'kilogramo de peróxido de hidrógeno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1360, N'kilohercio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1361, N'kilogramo por milímetro de anchura', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1362, N'kilogramo, incluyendo envase', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1363, N'kilogramo, incluyendo embalaje interior', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1364, N'kilosegment', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1365, N'kilojulios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1366, N'kilogramo por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1367, N'porcentaje de material seco láctico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1368, N'kilolux', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1369, N'kilogramo de metilamina', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1370, N'kilómetro por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1371, N'kilometro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1372, N'kilogramo por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1373, N'kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1374, N'kilogramo de nitrógeno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.187' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1375, N'kilonewton por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1376, N'kilogramo sustancia llamada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1377, N'nudo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1378, N'milliequivalence potasa cáustica por gramo de producto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1379, N'kilopascales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1380, N'kilogramo de hidróxido de potasio (potasa cáustica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1381, N'kilogramo de óxido de potasio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1382, N'kilogramo de pentóxido de fósforo (anhídrido fosfórico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1383, N'kiloroentgen', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1384, N'mil libras por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1385, N'kilogramo de sustancia 90% seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1386, N'kilogramo de hidróxido de sodio (soda cáustica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1387, N'equipo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1388, N'kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1389, N'kilotones', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1390, N'kilogramo de uranio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1391, N'kilovoltios - amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1392, N'kilovar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1393, N'kilovoltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1394, N'kilogramo por milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1395, N'kilovatio hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1396, N'kilovatio años', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1397, N'Kilovatio hora por metro cúbico normalizado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1398, N'kilogramo de trióxido de tungsteno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1399, N'Kilovatio hora por metro cúbico estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.190' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1400, N'kilovatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1401, N'mililitro por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1402, N'cuarto (líquido EE.UU.) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1403, N'cuarto (líquido EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1404, N'metros por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1405, N'metros por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1406, N'cuadrada hora metros grados centígrados por kilocaloría (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1407, N'segundo milipascales por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1408, N'milipascales segundo bar por', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1409, N'miligramo por metro cúbico kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1410, N'miligramo por metro cúbico de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1411, N'mililitro por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1412, N'litros por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1413, N'milímetro cúbico de reciprocidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1414, N'milímetro cúbico por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1415, N'mol por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1416, N'mol por kilogramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.193' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1417, N'mol por kilogramo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1418, N'mol por litro kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1419, N'mol por litro bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1420, N'mol por kelvin metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1421, N'mol por bar metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1422, N'mol por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1423, N'hombres aequivalent miliroentgen', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1424, N'nanogramos por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1425, N'oz (avoirdupois) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1426, N'oz (avoirdupois) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1427, N'oz (avoirdupois) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1428, N'oz (avoirdupois) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1429, N'onza (avoirdupois) por galón (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1430, N'oz (avoirdupois) por galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1431, N'oz (avoirdupois) por pulgada cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1432, N'oz (avoirdupois) -force', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1433, N'oz (avoirdupois) pulgada -force', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1434, N'picosiemens por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.197' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1435, N'Peck (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1436, N'Peck (Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1437, N'Peck (Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1438, N'Peck (Reino Unido) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1439, N'Peck (Reino Unido) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1440, N'Peck (seco EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1441, N'Peck (seco EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1442, N'Peck (seco EE.UU.) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1443, N'Peck (seco EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1444, N'psi por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1445, N'pinta (Reino Unido) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1446, N'pinta (Reino Unido) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1447, N'pinta (Reino Unido) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1448, N'pinta (Reino Unido) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1449, N'pinta (líquido EE.UU.) por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1450, N'pinta (líquido EE.UU.) por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1451, N'pinta (líquido EE.UU.) por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1452, N'pinta (líquido EE.UU.) por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1453, N'pinta (seco EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1454, N'cuarto (seco EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1455, N'babosa por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1456, N'babosa por segundo pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1457, N'babosa por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1458, N'babosa por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.200' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1459, N'babosa por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1460, N'babosa por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1461, N'tonelada por kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1462, N'tonelada por barra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1463, N'tonelada por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1464, N'tonelada por día kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1465, N'tonelada por día de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1466, N'tonelada por kelvin hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1467, N'tonelada por hora bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1468, N'tonelada por metro cúbico kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1469, N'tonelada por metro cúbico de barras', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1470, N'tonelada por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1471, N'tonelada por kelvin minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1472, N'tonelada por barra minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1473, N'tonelada por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1474, N'tonelada por segundo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1475, N'tonelada por segundo bar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1476, N'tonelada (envío Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.203' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1477, N'tonelada larga por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1478, N'tonelada (envío de los EEUU)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1479, N'tonelada corta por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1480, N'tonelada corta por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1481, N'tonelada corta por grado Fahrenheit hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1482, N'tonelada corta por psi hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1483, N'tonelada corta por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1484, N'tonelada (Reino Unido larga) por yarda cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1485, N'tonelada (abreviatura de EE.UU.) por yarda cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1486, N'tonelada-fuerza (abreviatura de Estados Unidos)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1487, N'año común', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1488, N'año sideral', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1489, N'yardas por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1490, N'yardas por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1491, N'libra por pulgada cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.207' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1492, N'lactosa exceso de porcentaje', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1493, N'libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1494, N'Troy libra (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1495, N'centímetro lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1496, N'litros por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1497, N'Lite', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1498, N'hoja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1499, N'pie lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1500, N'horas de trabajo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1501, N'pulgada lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1502, N'aerosol grande', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1503, N'enlace', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1504, N'metro lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1505, N'longitud', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1506, N'muchos [unidad de adquisición]', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1507, N'libra líquido', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1508, N'litro de alcohol puro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1509, N'capa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1510, N'Suma global', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1511, N'tonelada (Reino Unido) o tonelada larga (EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1512, N'litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1513, N'tonelada métrica, aceite lubricante', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1514, N'lumen', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1515, N'lux', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1516, N'yarda linear por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1517, N'yarda linear', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1518, N'cinta magnética', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.210' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1519, N'miligramo por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1520, N'yarda cúbica recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1521, N'yarda cúbica por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1522, N'yardas cúbicas por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1523, N'yardas cúbicas por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1524, N'yarda cúbica por psi', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1525, N'yardas cúbicas por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1526, N'yardas cúbicas por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1527, N'metros kilohercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1528, N'metros gigahercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1529, N'Beaufort', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1530, N'megakelvin recíproco o megakelvin a la potencia menos uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1531, N'recíproco kilovoltios - amperios hora recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1532, N'mililitros por metro cuadrado minutos centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1533, N'Newton por centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1534, N'kilómetro ohmios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1535, N'por ciento por grado Celsius', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1536, N'gigaohmio por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.213' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1537, N'metros megahercios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1538, N'kilogramo por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1539, N'recíproco voltios - amperios segundo recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1540, N'kilogramo por kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1541, N'segundos pascal por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1542, N'milimol por litro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1543, N'newton metro por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1544, N'milivoltios - amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1545, N'mes de 30 días', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1546, N'real / 360', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1547, N'kilómetro por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1548, N'centímetro por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1549, N'valor monetario', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1550, N'yardas por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1551, N'milímetro por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1552, N'milla (milla terrestre) por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1553, N'mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.217' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1554, N'revolución', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1555, N'grado [Unidad de ángulo] por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1556, N'revolución por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1557, N'circulares MIL', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1558, N'milla cuadrada (basado en el pie encuesta EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1559, N'cadena (basado en el pie encuesta EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1560, N'microcurie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1561, N'Furlong', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1562, N'pie (encuesta EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1563, N'millas (basado en el pie encuesta EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1564, N'metro por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1565, N'metro por radiante', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1566, N'sacudir', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1567, N'millas por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1568, N'millas por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1569, N'metros por segundo pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1570, N'metros por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1571, N'pulgada por año', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1572, N'kilómetro por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1573, N'pulgada por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1574, N'yardas por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1575, N'yardas por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1576, N'yardas por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1577, N'acre-pie (basado en el pie encuesta EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.220' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1578, N'espinal (128 ft3)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1579, N'milla cúbica (Ley del Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1580, N'micro pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1581, N'tonelada, regístrese', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1582, N'metro cúbico por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1583, N'bel', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1584, N'kilogramo por metro cúbico pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1585, N'kilogramo por pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1586, N'kilopound fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1587, N'poundal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1588, N'metros kilogramo por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1589, N'estanque', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1590, N'pie cuadrado por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1591, N'Stokes por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1592, N'centímetro cuadrado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.223' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1593, N'metro cuadrado por segundo pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1594, N'negador', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1595, N'libras por yarda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1596, N'tonelada, ensayo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1597, N'pfund', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1598, N'kilogramo por segundo pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1599, N'toneladas por mes', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1600, N'toneladas por año', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1601, N'millones de Btu por pie cúbico 1000', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1602, N'kilopound por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1603, N'libra por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1604, N'pie-libra fuerza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1605, N'newton metro por radián', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1606, N'kilogramo metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.227' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1607, N'pies poundal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1608, N'pulgadas poundal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1609, N'dina metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1610, N'centímetro kilogramo por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1611, N'gramo centímetro por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1612, N'máquina por unidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1613, N'Megavolt amperio hora reactiva', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1614, N'megalitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1615, N'megámetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1616, N'megavar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1617, N'megavatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1618, N'miles de ladrillo estándar equivalente', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1619, N'Junta mil pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1620, N'milibares', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1621, N'microgramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1622, N'milicurie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1623, N'secar al aire tonelada métrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1624, N'miligramos por pie cuadrado por cada lado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.230' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1625, N'miligramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1626, N'megahercio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1627, N'milla cuadrada (milla terrestre)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1628, N'mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1629, N'minuto [unidad de tiempo]', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1630, N'millón', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1631, N'millones de unidades internacionales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1632, N'miligramo por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1633, N'mil millones', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1634, N'mililitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.233' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1635, N'milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1636, N'milímetro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1637, N'milímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1638, N'kilogramo, peso seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1639, N'mes', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1640, N'megapascales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1641, N'mil metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1642, N'metros cúbicos por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1643, N'metro cúbico por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1644, N'metro por segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1645, N'estera', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1646, N'metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1647, N'Metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.237' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1648, N'metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1649, N'metros por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1650, N'número de multiplicadores', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1651, N'megavolt - amperios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1652, N'megavatio hora (1000 kW.h)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1653, N'pluma de calorías', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1654, N'pies libra por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1655, N'libra pulgada por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1656, N'Pferdestaerke', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1657, N'centímetro de mercurio (0 ºC)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1658, N'centímetro de agua (4 ºC)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1659, N'pie de agua (39,2 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1660, N'pulgadas de mercurio (32 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1661, N'pulgadas de mercurio (60 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1662, N'pulgadas de agua (39,2 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1663, N'pulgada de agua (60 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1664, N'número de líneas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1665, N'kip por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1666, N'poundal por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1667, N'oz (avoirdupois) por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1668, N'metro convencional de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1669, N'gramo por milímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1670, N'libras por yarda cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1671, N'poundal por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1672, N'pie a la cuarta potencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1673, N'decímetro cúbico por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1674, N'pies cúbicos por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1675, N'punto de impresión', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1676, N'pulgadas cúbicas por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1677, N'kilonewton por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1678, N'poundal por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1679, N'libra-fuerza por yarda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1680, N'segundo poundal por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1681, N'aplomo por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1682, N'newton segundo por metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.243' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1683, N'kilogramo por segundo metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1684, N'kilogramo por metro minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1685, N'kilogramo por día metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1686, N'kilogramo por hora metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1687, N'gramo por centímetro segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1688, N'segundo poundal por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1689, N'libras por pie minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1690, N'libra por día pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1691, N'metro cúbico por segundo pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1692, N'poundal pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1693, N'poundal pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1694, N'vatios por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.247' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1695, N'watt por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1696, N'Unidad térmica británica (tabla internacional) por metro cuadrado horas pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1697, N'unidad térmica Británica (termoquímico) por metro cuadrado horas pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1698, N'unidad térmica Británica (termoquímico) por pie cuadrado minutos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1699, N'unidad térmica Británica (tabla internacional) por segundo pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1700, N'unidad térmica Británica (termoquímico) por segundo pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1701, N'unidad térmica Británica (tabla internacional) por metro cuadrado segundo pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1702, N'calorías (termoquímico) por metro cuadrado minutos centímetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1703, N'calorías (termoquímico) por segundo centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1704, N'Unidad térmica británica (tabla internacional) por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1705, N'unidad térmica Británica (termoquímico) por pie cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1706, N'Unidad térmica británica (tabla internacional) por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1707, N'unidad térmica Británica (termoquímico) por grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1708, N'Unidad térmica británica (tabla internacional) por Rankine grado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1709, N'unidad térmica Británica (termoquímico) por Rankine grado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1710, N'unidad térmica Británica (termoquímico) por grado libra Rankine', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1711, N'kilocaloría (tabla internacional) por gramo kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1712, N'unidad térmica británica (39 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1713, N'unidad térmica británica (59 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1714, N'unidad térmica británica (60 ºF)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1715, N'de calorías (20 ºC)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1716, N'quad (1015 BtuIT)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1717, N'therm (CE)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1718, N'therm (EE.UU.)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1719, N'unidad térmica Británica (termoquímico) por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1720, N'Unidad térmica británica (tabla internacional) por pie cuadrado grados Fahrenheit hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1721, N'unidad térmica Británica (termoquímico) por grado hora pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1722, N'Unidad térmica británica (tabla internacional) por pie cuadrado segundo grado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1723, N'unidad térmica Británica (termoquímico) por segundo grado pie cuadrado Fahrenheit', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1724, N'kilovatio por metro cuadrado kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1725, N'kelvin por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1726, N'vatios por metro grados centígrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1727, N'kilovatio por metro kelvin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1728, N'kilovatios por metro grados centígrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1729, N'metros por cada grado Celsius metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1730, N'grados Fahrenheit hora por unidad térmica británica (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1731, N'grado Fahrenheit hora por unidad térmica Británica (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1732, N'grados Fahrenheit segundo por unidad térmica británica (tabla internacional)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.253' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1733, N'grado Fahrenheit segundo por unidad térmica Británica (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1734, N'grado Fahrenheit cuadrado horas pie por unidad térmica Británica (tabla internacional) pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1735, N'grado Fahrenheit horas pie cuadrado por unidad térmica Británica pulgadas (termoquímico)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1736, N'kilofarad', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1737, N'Joule recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1738, N'picosiemens', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1739, N'amperio por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1740, N'franklin', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1741, N'amperios hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1742, N'Biot', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1743, N'Gilbert', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1744, N'voltio por Pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1745, N'picovolt', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1746, N'miligramo por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1747, N'número de artículos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1748, N'barcaza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1749, N'número de bobinas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1750, N'coche', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.257' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1751, N'número de celdas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1752, N'cilindro de red', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1753, N'litros netos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1754, N'newton', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1755, N'mensaje', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1756, N'galones netos (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1757, N'mensaje de hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1758, N'galón imperial neta', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1759, N'nulo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1760, N'número de unidades internacionales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1761, N'número de pantallas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1762, N'carga', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1763, N'metro cúbico normalizado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1764, N'milla nautica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1765, N'número de paquetes', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1766, N'entrenar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1767, N'número de parcelas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1768, N'número de pares', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1769, N'número de piezas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1770, N'mho', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1771, N'micromho', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1772, N'número de rollos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1773, N'tonelada neta', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1774, N'tonelada de registro neto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.260' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1775, N'newton metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1776, N'vehículo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1777, N'parte por mil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1778, N'libra por tonelada métrica de aire seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1779, N'panel', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1780, N'agotamiento del ozono equivalente', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1781, N'SAO gramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1782, N'SAO Kilogramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1783, N'SAO Miligramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1784, N'ohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1785, N'onzas por yarda cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1786, N'oz (avoirdupois)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1787, N'Dos paquetes', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1788, N'oscilaciones por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1789, N'hora extra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1790, N'av oz', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1791, N'onza de líquido (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1792, N'onza líquida (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.263' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1793, N'Página - electrónica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1794, N'por ciento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1795, N'culombio por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1796, N'kiloweber', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1797, N'gama', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1798, N'kilotesla', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1799, N'joule por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1800, N'joule por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1801, N'joule por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1802, N'julios por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1803, N'kilojulios por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1804, N'kilojulios por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1805, N'libras por pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1806, N'kilojulios por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1807, N'kilojulios por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1808, N'nanoohm', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1809, N'ohm circular-mil por pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1810, N'kilohenry', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.267' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1811, N'lumen por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1812, N'foto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1813, N'vela de pie', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1814, N'candela por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1815, N'footlambert', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1816, N'tres paquetes', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1817, N'Lambert', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1818, N'stilb', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1819, N'candelas por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1820, N'kilocandela', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1821, N'Intensidad lumínica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1822, N'Hefner-Kerze', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1823, N'vela internacional', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1824, N'Unidad térmica británica (tabla internacional) por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1825, N'unidad térmica Británica (termoquímico) por pie cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1826, N'calorías (termoquímico) por centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1827, N'paquete de cuatro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1828, N'Langley', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1829, N'década (logarítmica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1830, N'pascal segundo al cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1831, N'bel por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1832, N'libra mol', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1833, N'mol libra por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1834, N'libra mol por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1835, N'kilomol por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1836, N'libra mol por libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1837, N'newton metro cuadrado por amperio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1838, N'paquete de cinco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1839, N'metros de weber', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1840, N'mol por kilogramo pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1841, N'mol por pascal metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1842, N'unidad polar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1843, N'miligray por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1844, N'MicroGray por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1845, N'nanogray por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1846, N'gris por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1847, N'miligray por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1848, N'MicroGray por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1849, N'paquete de seis', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1850, N'nanogray por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1851, N'por hora gris', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1852, N'miligray por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.273' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1853, N'MicroGray por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1854, N'nanogray por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1855, N'Sievert por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1856, N'milisievert por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1857, N'microsievert por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1858, N'nanosievert por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1859, N'rem por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1860, N'paquete de siete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1861, N'Sievert por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1862, N'milisievert por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1863, N'microsievert por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1864, N'nanosievert por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1865, N'Sievert por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1866, N'millisievert por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1867, N'microsievert por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1868, N'nanosievert por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1869, N'pulgada cuadrada recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1870, N'metro cuadrado pascal por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.277' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1871, N'paquete de ocho', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1872, N'por metro milipascales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1873, N'kilopascales por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1874, N'por metro hectopascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1875, N'atmósfera estándar por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1876, N'ambiente técnica por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1877, N'torr por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1878, N'psi por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1879, N'metro cúbico por segundo metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1880, N'RHE', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1881, N'pie-libra fuerza por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1882, N'paquete de nueve', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1883, N'libra fuerza por pulgada pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1884, N'perm (0 ºC)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1885, N'perm (23 ºC)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1886, N'bytes por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1887, N'kilobytes por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1888, N'megabyte por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1889, N'voltios recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1890, N'Radian recíproca', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1891, N'Pascal a la suma de potencias de números estequiométricos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1892, N'mol por metro cubiv a la suma de potencias de números estequiométricas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1893, N'paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1894, N'pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.280' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1895, N'par pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1896, N'almohadilla', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1897, N'libra equivale', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1898, N'palet (ascensor)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1899, N'litro de prueba', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1900, N'plato', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1901, N'galón prueba', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1902, N'tono', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1903, N'paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.283' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1904, N'cubo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1905, N'grado Plato', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1906, N'porcentaje libra', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1907, N'nasa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1908, N'libra por pulgada de longitud', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1909, N'página por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1910, N'par', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1911, N'libra por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1912, N'pinta (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1913, N'pinta seco (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1914, N'pinta (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1915, N'pinta líquido (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1916, N'parte', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.287' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1917, N'bandeja / bandeja de paquete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1918, N'media pinta (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1919, N'libra por pulgada de anchura', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1920, N'Peck seco (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1921, N'Peck seco (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1922, N'julio por tesla', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1923, N'Erlang', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1924, N'octeto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1925, N'octeto por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1926, N'Shannon', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1927, N'Hartley', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1928, N'unidad natural de la información', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1929, N'Shannon por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1930, N'hartley por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1931, N'unidad natural de información por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1932, N'segundos por kilogramm', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1933, N'watt metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1934, N'segundo por metro cúbico radián', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1935, N'Weber a la potencia menos uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.290' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1936, N'recíproco pulgadas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1937, N'dioptría', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1938, N'uno por uno', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1939, N'newton metro por metro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1940, N'kilogramo por metro cuadrado segundos pascal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1941, N'microgramo por hectogram', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1942, N'pH (potencial de hidrógeno)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1943, N'kilojulios por gramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1944, N'femtolitro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1945, N'picolitros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1946, N'nanolitros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1947, N'megavatios por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1948, N'metro cuadrado por metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1949, N'metros cúbicos estándar por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1950, N'metros cúbicos estándar por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.293' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1951, N'Normalizado metros cúbicos por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1952, N'Normalizado metros cúbicos por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1953, N'Joule por metro cúbico normalizado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1954, N'Joule por metro cúbico estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1955, N'comida', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1956, N'Página - facsímil', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1957, N'trimestre (de un año)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1958, N'Página - copia impresa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1959, N'trimestre docena', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1960, N'un cuarto de hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1961, N'trimestre kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1962, N'mano de papel', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1963, N'cuarto (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1964, N'cuarto seco (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1965, N'cuarto (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.297' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1966, N'cuarto líquido (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1967, N'trimestre (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1968, N'pica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1969, N'caloría', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1970, N'miles de metros cúbicos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1971, N'estante', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1972, N'varilla', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1973, N'anillo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1974, N'correr o hacer funcionar hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1975, N'rollo de medida métrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1976, N'carrete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1977, N'resma', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1978, N'resma medida métrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1979, N'rodar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1980, N'habitación', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1981, N'libra por resma', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1982, N'revoluciones por minuto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1983, N'revoluciones por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1984, N'Reiniciar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1985, N'ingresos por tonelada millas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.300' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1986, N'correr', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1987, N'pie cuadrado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1988, N'metro cuadrado por segundo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1989, N'sesenta cuartos de pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1990, N'sesión', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1991, N'unidad de almacenamiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1992, N'unidad estándar de publicidad', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1993, N'saco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.303' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1994, N'medio año (6 meses)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1995, N'Puntuación', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1996, N'escrúpulo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1997, N'libra sólida', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1998, N'sección', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1999, N'segundos [unidad de tiempo]', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2000, N'conjunto', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2001, N'segmento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2002, N'tonelada de envío', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2003, N'Siemens', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2004, N'camión cisterna dividida', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.307' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2005, N'hoja de deslizamiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2006, N'metro cúbico estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2007, N'milla (milla terrestre)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2008, N'barra cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2009, N'carrete', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2010, N'paquete de estante', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2011, N'cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2012, N'cuadrado, material para techos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2013, N'tira', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2014, N'hoja de medida métrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2015, N'corta estándar (7200 coincidencias)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2016, N'sábana', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2017, N'palo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2018, N'piedra (Reino Unido)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2019, N'palo, el cigarrillo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2020, N'litros estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2021, N'tonelada (EE.UU.) o tonelada corta (UK / US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2022, N'Paja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2023, N'patinar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2024, N'madeja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2025, N'envío', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2026, N'jeringuilla', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2027, N'línea de telecomunicaciones en el servicio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2028, N'bruto mil libras', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.310' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2029, N'miles de piezas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2030, N'miles de bolsa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2031, N'miles de carcasa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2032, N'mil galón (US)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2033, N'mil impresiones', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2034, N'mil pulgada lineal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2035, N'pie cúbico décimo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2036, N'kiloamperios horas (mil horas amperio)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2037, N'índice de acidez total', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2038, N'camión', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2039, N'termia', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2040, N'totalizador', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2041, N'yarda cuadrada de diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2042, N'mil pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2043, N'tonelada métrica, incluyendo contenedores', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2044, N'tonelada métrica, incluyendo embalaje interior', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2045, N'mil centímetro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2046, N'tanque, rectangular', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2047, N'tonelada-kilómetro', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2048, N'mil pies (lineal)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2049, N'kilogramo de carne importada, menos despojos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2050, N'estaño', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2051, N'tonelada (tonelada métrica)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2052, N'paquete de diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2053, N'dientes por pulgada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2054, N'par de diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2055, N'mil pies', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2056, N'miles de metros cúbicos por día', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2057, N'pie cuadrado de diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2058, N'billones (EUR)', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2059, N'mil pies cuadrados', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2060, N'tonelada de sustancia 90% seco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2061, N'tonelada de vapor por hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2062, N'conjunto de diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2063, N'mil metros lineales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2064, N'diez mil palos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.317' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2065, N'tubo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2066, N'miles de kilogramos', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2067, N'miles de hoja', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2068, N'tanque, cilíndrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2069, N'tratamiento', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2070, N'tableta', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2071, N'torr', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2072, N'línea de telecomunicaciones en el servicio normal', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2073, N'puerto de telecomunicaciones', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2074, N'minuto diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2075, N'décima hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2076, N'por el uso de las telecomunicaciones de línea media', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2077, N'diez mil yardas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2078, N'millones de unidades', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2079, N'voltios - amperios por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2080, N'frasco', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2081, N'voltio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2082, N'por ciento en volumen', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2083, N'abultar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2084, N'visitar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2085, N'kilo húmeda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2086, N'dos semanas', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2087, N'vatios por kilogramo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2088, N'libra húmeda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2089, N'cable', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.320' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2090, N'tonelada húmeda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2091, N'weber', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2092, N'semana', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2093, N'galón', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2094, N'rueda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2095, N'vatios hora', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2096, N'peso por pulgada cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2097, N'meses de trabajo', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2098, N'envolver', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2099, N'estándar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2100, N'vatio', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2101, N'mililitro de agua', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2102, N'cadena de Gunter', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2103, N'yarda cuadrada', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2104, N'Yarda cúbica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2105, N'cientos de yardas lineales', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2106, N'yarda', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.323' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2107, N'yardas diez', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2108, N'aerofurgoneta', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2109, N'contenedor colgante', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2110, N'cofre', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2111, N'barril', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2112, N'pipa', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2113, N'arrastrar', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2114, N'punto de conferencia', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2115, N'línea de ágata página de noticias', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2116, N'página', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2117, N'mutuamente definido', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2118, N'Semana metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2119, N'Semana metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2120, N'Semana metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.327' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2121, N'Semana pieza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2122, N'Día metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2123, N'Día Metro Cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2124, N'Día metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2125, N'Día pieza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2126, N'Mes metros', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2127, N'Mes metro cuadrado', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2128, N'Mes metro cúbico', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2129, N'Mes pieza', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2130, N'decibelios vatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2131, N'-Decibelios milivatios', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2132, N'Formazina unidad nefelométrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[UnidadMedida] ([CodigoUnidadMedida], [Descripcion], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2133, N'unidad de turbidez nefelométrica', 1, N'AUTO', CAST(N'2020-08-11T01:11:31.330' AS DateTime), NULL, NULL)
INSERT [dbo].[Usuario] ([CodigoUsuario], [Nombre], [Contraseña], [CodigoPersonal], [FlagCambiarContraseña], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (1, N'ADMIN', 0xD6A84D38CBBF6BE58EAAC869413AEBA2, 1, NULL, 1, NULL, NULL, NULL, CAST(N'2020-09-12T00:05:58.590' AS DateTime))
INSERT [dbo].[Usuario] ([CodigoUsuario], [Nombre], [Contraseña], [CodigoPersonal], [FlagCambiarContraseña], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (2, N'JSEANCAS', 0xF82C99547B29F9384C268481E6807057, 1, NULL, 1, NULL, CAST(N'2020-08-20T23:24:35.097' AS DateTime), NULL, NULL)
INSERT [dbo].[Usuario] ([CodigoUsuario], [Nombre], [Contraseña], [CodigoPersonal], [FlagCambiarContraseña], [FlagActivo], [UsuarioGraba], [FechaGraba], [UsuarioModi], [FechaModi]) VALUES (3, N'RSEANCAS', 0xF82C99547B29F9384C268481E6807057, 1, NULL, 1, NULL, CAST(N'2020-08-20T23:44:49.250' AS DateTime), NULL, NULL)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (1, 1)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (1, 2)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (1, 3)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (1, 4)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (2, 1)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (2, 2)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (2, 3)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (2, 4)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (3, 2)
INSERT [dbo].[UsuarioPerfil] ([CodigoUsuario], [CodigoPerfil]) VALUES (3, 3)
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Actividad] FOREIGN KEY([CodigoActividadPrincipal])
REFERENCES [dbo].[Actividad] ([CodigoActividad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Actividad]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoDocumentoIdentidad] FOREIGN KEY([CodigoTipoDocumentoIdentidad])
REFERENCES [dbo].[TipoDocumentoIdentidad] ([CodigoTipoDocumentoIdentidad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_TipoDocumentoIdentidad]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Menu] FOREIGN KEY([CodigoMenuPadre])
REFERENCES [dbo].[Menu] ([CodigoMenu])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Menu]
GO
ALTER TABLE [dbo].[PerfilMenu]  WITH CHECK ADD  CONSTRAINT [FK_PerfilMenu_Menu] FOREIGN KEY([CodigoMenu])
REFERENCES [dbo].[Menu] ([CodigoMenu])
GO
ALTER TABLE [dbo].[PerfilMenu] CHECK CONSTRAINT [FK_PerfilMenu_Menu]
GO
ALTER TABLE [dbo].[PerfilMenu]  WITH CHECK ADD  CONSTRAINT [FK_PerfilMenu_Perfil] FOREIGN KEY([CodigoPerfil])
REFERENCES [dbo].[Perfil] ([CodigoPerfil])
GO
ALTER TABLE [dbo].[PerfilMenu] CHECK CONSTRAINT [FK_PerfilMenu_Perfil]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Area] FOREIGN KEY([CodigoArea])
REFERENCES [dbo].[Area] ([CodigoArea])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Area]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_TipoDocumentoIdentidad] FOREIGN KEY([CodigoTipoDocumentoIdentidad])
REFERENCES [dbo].[TipoDocumentoIdentidad] ([CodigoTipoDocumentoIdentidad])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_TipoDocumentoIdentidad]
GO
ALTER TABLE [dbo].[ProductoIndividual]  WITH CHECK ADD  CONSTRAINT [FK_ProductoIndividual_Personal] FOREIGN KEY([CodigoPersonalInspeccion])
REFERENCES [dbo].[Personal] ([CodigoPersonal])
GO
ALTER TABLE [dbo].[ProductoIndividual] CHECK CONSTRAINT [FK_ProductoIndividual_Personal]
GO
ALTER TABLE [dbo].[ProductoIndividual]  WITH CHECK ADD  CONSTRAINT [FK_ProductoIndividual_Producto] FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[Producto] ([CodigoProducto])
GO
ALTER TABLE [dbo].[ProductoIndividual] CHECK CONSTRAINT [FK_ProductoIndividual_Producto]
GO
ALTER TABLE [dbo].[ProductoIndividual]  WITH CHECK ADD  CONSTRAINT [FK_ProductoIndividual_UnidadMedida] FOREIGN KEY([CodigoUnidadMedida])
REFERENCES [dbo].[UnidadMedida] ([CodigoUnidadMedida])
GO
ALTER TABLE [dbo].[ProductoIndividual] CHECK CONSTRAINT [FK_ProductoIndividual_UnidadMedida]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_TipoDocumentoIdentidad] FOREIGN KEY([CodigoTipoDocumentoIdentidad])
REFERENCES [dbo].[TipoDocumentoIdentidad] ([CodigoTipoDocumentoIdentidad])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_TipoDocumentoIdentidad]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Personal] FOREIGN KEY([CodigoPersonal])
REFERENCES [dbo].[Personal] ([CodigoPersonal])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Personal]
GO
ALTER TABLE [dbo].[UsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPerfil_Perfil] FOREIGN KEY([CodigoPerfil])
REFERENCES [dbo].[Perfil] ([CodigoPerfil])
GO
ALTER TABLE [dbo].[UsuarioPerfil] CHECK CONSTRAINT [FK_UsuarioPerfil_Perfil]
GO
ALTER TABLE [dbo].[UsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPerfil_Usuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[Usuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[UsuarioPerfil] CHECK CONSTRAINT [FK_UsuarioPerfil_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_buscar]
@nombre varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by a.Nombre) as int) [Fila],
	a.CodigoActividad,
	a.Nombre,
	a.FlagActivo
	from
	Actividad a
	where
	(a.Nombre like '%' + isnull(@nombre, '') + '%') and
	a.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_cambiar_flagactivo]
@codigoActividad int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Actividad set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoActividad = @codigoActividad
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_existe]
@codigoActividad int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Actividad where Nombre = @nombre and CodigoActividad != isnull(@codigoActividad, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_guardar]
@codigoActividad int,
@nombre varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoActividad = (select CodigoActividad from Actividad where CodigoActividad = @codigoActividad)

	if @codigoActividad is null
	begin
		select @codigoActividad = isnull(max(CodigoActividad), 0) + 1 from Actividad

		insert into Actividad
		(CodigoActividad, Nombre, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoActividad, @nombre, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Actividad set
		Nombre = @nombre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoActividad = @codigoActividad
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_listar_combo]
as
begin
	select
	a.CodigoActividad,
	a.Nombre
	from
	Actividad a
	where
	a.FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actividad_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actividad_obtener]
@codigoActividad int
as
begin
	select
	a.CodigoActividad,
	a.Nombre,
	a.FlagActivo
	from
	Actividad a
	where
	a.CodigoActividad = @codigoActividad
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_area_buscar]
@nombre varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by a.Nombre) as int) [Fila],
	a.CodigoArea,
	a.Nombre,
	a.FlagActivo
	from
	Area a
	where
	(a.Nombre like '%' + isnull(@nombre, '') + '%') and
	a.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_area_cambiar_flagactivo]
@codigoArea int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Area set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoArea = @codigoArea
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_area_existe]
@codigoArea int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Area where Nombre = @nombre and CodigoArea != isnull(@codigoArea, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_area_guardar]
@codigoArea int,
@nombre varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoArea = (select CodigoArea from Area where CodigoArea = @codigoArea)

	if @codigoArea is null
	begin
		select @codigoArea = isnull(max(CodigoArea), 0) + 1 from Area

		insert into Area
		(CodigoArea, Nombre, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoArea, @nombre, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Area set
		Nombre = @nombre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoArea = @codigoArea
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_area_listar_combo]
as
begin
	select
	a.CodigoArea,
	a.Nombre,
	a.FlagActivo
	from
	Area a
	where FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_area_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_area_obtener]
@codigoArea int
as
begin
	select
	a.CodigoArea,
	a.Nombre,
	a.FlagActivo
	from
	Area a
	where
	a.CodigoArea = @codigoArea
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_buscar]
@nombre varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by a.Nombre) as int) [Fila],
	a.CodigoBanco,
	a.Nombre,
	a.FlagActivo
	from
	Banco a
	where
	(a.Nombre like '%' + isnull(@nombre, '') + '%') and
	a.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_cambiar_flagactivo]
@codigoBanco int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Banco set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoBanco = @codigoBanco
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_existe]
@codigoBanco int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Banco where Nombre = @nombre and CodigoBanco != isnull(@codigoBanco, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_guardar]
@codigoBanco int,
@nombre varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoBanco = (select CodigoBanco from Banco where CodigoBanco = @codigoBanco)

	if @codigoBanco is null
	begin
		select @codigoBanco = isnull(max(CodigoBanco), 0) + 1 from Banco

		insert into Banco
		(CodigoBanco, Nombre, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoBanco, @nombre, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Banco set
		Nombre = @nombre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoBanco = @codigoBanco
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_listar_combo]
as
begin
	select
	a.CodigoBanco,
	a.Nombre,
	a.FlagActivo
	from
	Banco a
	where FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_banco_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_banco_obtener]
@codigoBanco int
as
begin
	select
	a.CodigoBanco,
	a.Nombre,
	a.FlagActivo
	from
	Banco a
	where
	a.CodigoBanco = @codigoBanco
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventa_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@codigoSerie int,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by bv.CodigoBoletaVenta desc) as int) [Fila],
	bv.CodigoBoletaVenta,
	bv.FechaHoraEmision,
	bv.FechaHoraVencimiento,
	bv.CodigoSerie,
	s.Serial [SerialSerie],
	bv.NroComprobante,
	bv.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	bv.CodigoMoneda,
	bv.TotalImporte,
	bv.FlagEmitido,
	bv.FlagActivo
	from
	BoletaVenta bv inner join
	Serie s on bv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on bv.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad
	where
	(cast(bv.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(bv.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(bv.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(bv.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(bv.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventa_guardar]
@codigoBoletaVenta int out,
@codigoSerie int,
@nroComprobante int out,
@fechaHoraEmision datetime,
@fechaHoraVencimiento datetime,
@codigoCliente int,
@direccionCliente varchar(100),
@nombrePaisCliente varchar(50),
@nombreDepartamentoCliente varchar(50),
@nombreProvinciaCliente varchar(50),
@nombreDistritoCliente varchar(50),
@codigoDistritoCliente int,
@codigoMoneda int,
@totalOperacionGravada decimal(18, 2),
@totalOperacionInafecta decimal(18, 2),
@totalOperacionExonerada decimal(18, 2),
@totalOperacionExportacion decimal(18, 2),
@totalOperacionGratuita decimal(18, 2),
@totalValorVenta decimal(18, 2),
@totalIgv decimal(18, 2),
@totalIsc decimal(18, 2),
@totalOtrosCargos decimal(18, 2),
@totalOtrosTributos decimal(18, 2),
@totalIcbper decimal(18, 2),
@totalDescuentoDetallado decimal(18, 2),
@totalPorcentajeDescuentoGlobal decimal(18, 2),
@totalDescuentoGlobal decimal(18, 2),
@totalPrecioVenta decimal(18, 2),
@totalImporte decimal(18, 2),
@totalPercepcion decimal(18, 2),
@totalPagar decimal(18, 2),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoBoletaVenta = (select CodigoBoletaVenta from BoletaVenta where CodigoBoletaVenta = @codigoBoletaVenta)

	if @codigoBoletaVenta is null
	begin
		select @codigoBoletaVenta = isnull(max(CodigoBoletaVenta), 0) + 1 from BoletaVenta
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into BoletaVenta
		(CodigoBoletaVenta, CodigoSerie, NroComprobante, FechaHoraEmision, FechaHoraVencimiento,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoBoletaVenta, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraVencimiento,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@totalOperacionGravada, @totalOperacionInafecta, @totalOperacionExonerada, @totalOperacionExportacion,
		@totalOperacionGratuita, @totalValorVenta, @totalIgv, @totalIsc, @totalOtrosCargos, @totalOtrosTributos,
		@totalIcbper, @totalDescuentoDetallado, @totalPorcentajeDescuentoGlobal, @totalDescuentoGlobal,
		@totalPrecioVenta, @totalImporte, @totalPercepcion, @totalPagar, @flagEmitido, 1,
		@usuarioModi, getdate())

		exec usp_serie_aumentarvaloractual @codigoSerie, @usuarioModi
	end
	else
	begin
		update BoletaVenta set
		CodigoSerie = @codigoSerie,
		FechaHoraEmision = @fechaHoraEmision,
		FechaHoraVencimiento = @fechaHoraVencimiento,
		CodigoCliente = @codigoCliente,
		DireccionCliente = @direccionCliente,
		NombrePaisCliente = @nombrePaisCliente,
		NombreDepartamentoCliente = @nombreDepartamentoCliente,
		NombreProvinciaCliente = @nombreProvinciaCliente,
		CodigoDistritoCliente = @codigoDistritoCliente,
		NombreDistritoCliente = @nombreDistritoCliente,
		CodigoMoneda = @codigoMoneda,
		TotalOperacionGravada = @totalOperacionGravada,
		TotalOperacionInafecta = @totalOperacionInafecta,
		TotalOperacionExonerada = @totalOperacionExonerada,
		TotalOperacionExportacion = @totalOperacionExportacion,
		TotalOperacionGratuita = @totalOperacionGratuita,
		TotalValorVenta = @totalValorVenta,
		TotalIgv = @totalIgv,
		TotalIsc = @totalIsc,
		TotalOtrosCargos = @totalOtrosCargos,
		TotalOtrosTributos = @totalOtrosTributos,
		TotalIcbper = @totalIcbper,
		TotalDescuentoDetallado = @totalDescuentoDetallado,
		TotalPorcentajeDescuentoGlobal = @totalPorcentajeDescuentoGlobal,
		TotalDescuentoGlobal = @totalDescuentoGlobal,
		TotalPrecioVenta = @totalPrecioVenta,
		TotalImporte = @totalImporte,
		TotalPercepcion = @totalPercepcion,
		TotalPagar = @totalPagar,
		FlagEmitido = @flagEmitido,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoBoletaVenta = @codigoBoletaVenta
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventa_obtener]
@codigoBoletaVenta int
as
begin
	select
	bv.CodigoBoletaVenta,
	bv.CodigoSerie,
	bv.NroComprobante,
	bv.FechaHoraEmision,
	bv.FechaHoraVencimiento,
	bv.CodigoCliente,
	bv.DireccionCliente,
	bv.NombrePaisCliente,
	bv.NombreDepartamentoCliente,
	bv.NombreProvinciaCliente,
	bv.CodigoDistritoCliente,
	bv.NombreDistritoCliente,
	bv.CodigoMoneda,
	bv.TotalOperacionGravada,
	bv.TotalOperacionInafecta,
	bv.TotalOperacionExonerada,
	bv.TotalOperacionExportacion,
	bv.TotalOperacionGratuita,
	bv.TotalValorVenta,
	bv.TotalIgv,
	bv.TotalIsc,
	bv.TotalOtrosCargos,
	bv.TotalOtrosTributos,
	bv.TotalIcbper,
	bv.TotalDescuentoDetallado,
	bv.TotalPorcentajeDescuentoGlobal,
	bv.TotalDescuentoGlobal,
	bv.TotalPrecioVenta,
	bv.TotalImporte,
	bv.TotalPercepcion,
	bv.TotalPagar,
	bv.FlagEmitido,
	bv.FlagActivo
	from
	BoletaVenta bv
	where
	bv.CodigoBoletaVenta = @codigoBoletaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_eliminar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_boletaventadetalle_eliminar]
@codigoBoletaVentaDetalle int,
@usuarioModi varchar(20)
as
begin
	update BoletaVentaDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoBoletaVentaDetalle = @codigoBoletaVentaDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventadetalle_guardar]
@codigoBoletaVenta int,
@codigoBoletaVentaDetalle int out,
@codigoProducto int,
@codigoProductoIndividual int,
@codigoUnidadMedida int,
@detalle varchar(max),
@cantidad decimal(18, 2),
@tipoCalculo int,
@valorUnitario decimal(18, 2),
@precioUnitario decimal(18, 2),
@valorVenta decimal(18, 2),
@precioVenta decimal(18, 2),
@igv decimal(18, 2),
@isc decimal(18, 2),
@tipoDescuento int,
@porcentajeDescuento decimal(18, 2),
@descuento decimal(18, 2),
@otrosCargos decimal(18, 2),
@otrosTributos decimal(18, 2),
@baseImponible decimal(18, 2),
@importe decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoBoletaVentaDetalle = (select CodigoBoletaVentaDetalle from BoletaVentaDetalle where CodigoBoletaVentaDetalle = @codigoBoletaVentaDetalle)

	if @codigoBoletaVentaDetalle is null
	begin
		select @codigoBoletaVentaDetalle = isnull(max(CodigoBoletaVentaDetalle), 0) + 1 from BoletaVentaDetalle

		insert into BoletaVentaDetalle
		(CodigoBoletaVenta, CodigoBoletaVentaDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, TipoCalculo, ValorUnitario, PrecioUnitario, ValorVenta, PrecioVenta,
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe, FlagEliminado,
		UsuarioGraba, FechaGraba)
		values
		(@codigoBoletaVenta, @codigoBoletaVentaDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 0,
		@usuarioModi, getdate())
	end
	else
	begin
		update BoletaVentaDetalle set
		CodigoProducto = @codigoProducto,
		CodigoProductoIndividual = @codigoProductoIndividual,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Detalle = @detalle,
		Cantidad = @cantidad,
		TipoCalculo = @tipoCalculo,
		ValorUnitario = @valorUnitario,
		PrecioUnitario = @precioUnitario,
		ValorVenta = @valorVenta,
		PrecioVenta = @precioVenta,
		Igv = @igv,
		Isc = @isc,
		TipoDescuento = @tipoDescuento,
		PorcentajeDescuento = @porcentajeDescuento,
		Descuento = @descuento,
		OtrosCargos = @otrosCargos,
		OtrosTributos = @otrosTributos,
		BaseImponible = @baseImponible,
		Importe = @importe,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoBoletaVentaDetalle = @codigoBoletaVentaDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_listar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventadetalle_listar]
@codigoBoletaVenta int
as
begin
	select
	cast(row_number() over(order by bvd.CodigoBoletaVentaDetalle desc) as int) [Fila],
	bvd.CodigoBoletaVenta,
	bvd.CodigoBoletaVentaDetalle,
	bvd.CodigoProducto,
	p.Nombre [NombreProducto],
	bvd.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	bvd.CodigoUnidadMedida,
	bvd.Detalle,
	bvd.Cantidad,
	bvd.ValorUnitario,
	bvd.PrecioUnitario,
	bvd.ValorVenta,
	bvd.PrecioVenta,
	bvd.Igv,
	bvd.Isc,
	bvd.PorcentajeDescuento,
	bvd.Descuento,
	bvd.OtrosCargos,
	bvd.OtrosTributos,
	bvd.BaseImponible,
	bvd.Importe,
	bvd.FlagEliminado
	from
	BoletaVentaDetalle bvd inner join
	Producto p on bvd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on bvd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	CodigoBoletaVenta = @codigoBoletaVenta and
	FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cliente_buscar]
@nroDocumentoIdentidad varchar(20),
@nombres varchar(100),
@direccion varchar(100),
@correo varchar(50),
@contacto varchar(100),
@areaContacto varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by c.Nombres) as int) [Fila],
	c.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad,
	tdi.Descripcion [DescripcionTipoDocumentoIdentidad],
	c.NroDocumentoIdentidad,
	c.Nombres,
	c.Direccion,
	c.CodigoDistrito,
	d.CodigoUbigeo [CodigoUbigeoDistrito],
	d.Nombre [NombreDistrito],
	d.CodigoProvincia,
	p.CodigoUbigeo [CodigoUbigeoProvincia],
	p.Nombre [NombreProvincia],
	p.CodigoDepartamento,
	de.CodigoUbigeo [CodigoUbigeoDepartamento],
	de.Nombre [NombreDepartamento],
	de.CodigoPais,
	pa.Nombre [NombrePais],
	c.Correo,
	c.Telefono,
	c.CodigoActividadPrincipal,
	a.Nombre [NombreActividadPrincipal],
	a.FlagActivo [FlagActivoActividadPrincipal],
	c.Contacto,
	c.AreaContacto,
	c.FlagActivo
	from
	Cliente c inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad left join
	Actividad a on c.CodigoActividadPrincipal = a.CodigoActividad inner join
	Distrito d on c.CodigoDistrito = d.CodigoDistrito inner join
	Provincia p on d.CodigoProvincia = p.CodigoProvincia inner join
	Departamento de on p.CodigoDepartamento = de.CodigoDepartamento inner join
	Pais pa on de.CodigoPais = pa.CodigoPais
	where
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidad, '') + '%') and
	(c.Nombres like '%' + isnull(@nombres, '') + '%') and
	(c.Direccion like '%' + isnull(@direccion, '') + '%') and
	(c.Correo like '%' + isnull(@correo, '') + '%') and
	(c.Contacto like '%' + isnull(@contacto, '') + '%') and
	(c.AreaContacto like '%' + isnull(@areaContacto, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_cliente_cambiar_flagactivo]
@codigoCliente int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Cliente set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoCliente = @codigoCliente
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cliente_existe]
@codigoCliente int,
@nroDocumentoIdentidad varchar(20)
as
begin
	select cast(count(1) as bit) from Cliente where NroDocumentoIdentidad = @nroDocumentoIdentidad and CodigoCliente != isnull(@codigoCliente, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cliente_guardar]
@codigoCliente int,
@codigoTipoDocumentoIdentidad int,
@nroDocumentoIdentidad varchar(20),
@nombres varchar(100),
@direccion varchar(100),
@codigoDistrito int,
@correo varchar(50),
@telefono varchar(100),
@contacto varchar(100),
@areaContacto varchar(100),
@codigoActividadPrincipal int,
@usuarioModi varchar(20)
as
begin
	set @codigoCliente = (select CodigoCliente from Cliente where CodigoCliente = @codigoCliente)

	if @codigoCliente is null
	begin
		select @codigoCliente = isnull(max(CodigoCliente), 0) + 1 from Cliente

		insert into Cliente
		(CodigoCliente, CodigoTipoDocumentoIdentidad, NroDocumentoIdentidad, Nombres, Direccion, CodigoDistrito, Correo, Telefono, Contacto, AreaContacto, CodigoActividadPrincipal, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@CodigoCliente, @CodigoTipoDocumentoIdentidad, @NroDocumentoIdentidad, @Nombres, @Direccion, @codigoDistrito, @Correo, @Telefono, @Contacto, @AreaContacto, @CodigoActividadPrincipal, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Cliente set
		CodigoTipoDocumentoIdentidad = @codigoTipoDocumentoIdentidad,
		NroDocumentoIdentidad = @nroDocumentoIdentidad,
		Nombres = @nombres,
		Direccion = @direccion,
		CodigoDistrito = @codigoDistrito,
		Correo = @correo,
		Telefono = @telefono,
		Contacto = @contacto,
		AreaContacto = @areaContacto,
		CodigoActividadPrincipal = @codigoActividadPrincipal,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoCliente = @codigoCliente
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cliente_obtener]
@codigoCliente int
as
begin
	select
	c.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad,
	c.NroDocumentoIdentidad,
	c.Nombres,
	c.Direccion,
	c.CodigoDistrito,
	d.CodigoUbigeo [CodigoUbigeoDistrito],
	d.Nombre [NombreDistrito],
	d.CodigoProvincia,
	p.CodigoUbigeo [CodigoUbigeoProvincia],
	p.Nombre [NombreProvincia],
	p.CodigoDepartamento,
	de.CodigoUbigeo [CodigoUbigeoDepartamento],
	de.Nombre [NombreDepartamento],
	de.CodigoPais,
	pa.Nombre [NombrePais],
	c.Correo,
	c.Telefono,
	c.Contacto,
	c.AreaContacto,
	c.CodigoActividadPrincipal
	from
	Cliente c inner join
	Distrito d on c.CodigoDistrito = d.CodigoDistrito inner join
	Provincia p on d.CodigoProvincia = p.CodigoProvincia inner join
	Departamento de on p.CodigoDepartamento = de.CodigoDepartamento inner join
	Pais pa on de.CodigoPais = pa.CodigoPais
	where
	c.CodigoCliente = @codigoCliente
end
GO
/****** Object:  StoredProcedure [dbo].[usp_departamento_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_departamento_listar_combo]
as
begin
	select
	d.CodigoDepartamento,
	d.CodigoPais,
	d.CodigoUbigeo,
	d.Nombre
	from Departamento d
end
GO
/****** Object:  StoredProcedure [dbo].[usp_distrito_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_distrito_listar_combo]
as
begin
	select
	d.CodigoDistrito,
	d.CodigoProvincia,
	d.CodigoUbigeo,
	d.Nombre
	from Distrito d
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventa_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@codigoSerie int,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by fv.CodigoFacturaVenta desc) as int) [Fila],
	fv.CodigoFacturaVenta,
	fv.FechaHoraEmision,
	fv.FechaHoraVencimiento,
	fv.CodigoSerie,
	s.Serial [SerialSerie],
	fv.NroComprobante,
	fv.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	fv.CodigoMoneda,
	fv.TotalImporte,
	fv.FlagEmitido,
	fv.FlagActivo
	from
	FacturaVenta fv inner join
	Serie s on fv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on fv.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad
	where
	(cast(fv.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(fv.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(fv.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(fv.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(fv.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventa_guardar]
@codigoFacturaVenta int out,
@codigoSerie int,
@nroComprobante int out,
@fechaHoraEmision datetime,
@fechaHoraVencimiento datetime,
@codigoCliente int,
@direccionCliente varchar(100),
@nombrePaisCliente varchar(50),
@nombreDepartamentoCliente varchar(50),
@nombreProvinciaCliente varchar(50),
@nombreDistritoCliente varchar(50),
@codigoDistritoCliente int,
@codigoMoneda int,
@codigoMetodoPago int,
@cantidadLetrasCredito int,
@totalOperacionGravada decimal(18, 2),
@totalOperacionInafecta decimal(18, 2),
@totalOperacionExonerada decimal(18, 2),
@totalOperacionExportacion decimal(18, 2),
@totalOperacionGratuita decimal(18, 2),
@totalValorVenta decimal(18, 2),
@totalIgv decimal(18, 2),
@totalIsc decimal(18, 2),
@totalOtrosCargos decimal(18, 2),
@totalOtrosTributos decimal(18, 2),
@totalIcbper decimal(18, 2),
@totalDescuentoDetallado decimal(18, 2),
@totalPorcentajeDescuentoGlobal decimal(18, 2),
@totalDescuentoGlobal decimal(18, 2),
@totalPrecioVenta decimal(18, 2),
@totalImporte decimal(18, 2),
@totalPercepcion decimal(18, 2),
@totalPagar decimal(18, 2),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoFacturaVenta = (select CodigoFacturaVenta from FacturaVenta where CodigoFacturaVenta = @codigoFacturaVenta)

	if @codigoFacturaVenta is null
	begin
		select @codigoFacturaVenta = isnull(max(CodigoFacturaVenta), 0) + 1 from FacturaVenta
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into FacturaVenta
		(CodigoFacturaVenta, CodigoSerie, NroComprobante, FechaHoraEmision, FechaHoraVencimiento,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		CodigoMetodoPago, CantidadLetrasCredito,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoFacturaVenta, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraVencimiento,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@codigoMetodoPago, @cantidadLetrasCredito,
		@totalOperacionGravada, @totalOperacionInafecta, @totalOperacionExonerada, @totalOperacionExportacion,
		@totalOperacionGratuita, @totalValorVenta, @totalIgv, @totalIsc, @totalOtrosCargos, @totalOtrosTributos,
		@totalIcbper, @totalDescuentoDetallado, @totalPorcentajeDescuentoGlobal, @totalDescuentoGlobal,
		@totalPrecioVenta, @totalImporte, @totalPercepcion, @totalPagar, @flagEmitido, 1,
		@usuarioModi, getdate())

		exec usp_serie_aumentarvaloractual @codigoSerie, @usuarioModi
	end
	else
	begin
		update FacturaVenta set
		CodigoSerie = @codigoSerie,
		FechaHoraEmision = @fechaHoraEmision,
		FechaHoraVencimiento = @fechaHoraVencimiento,
		CodigoCliente = @codigoCliente,
		DireccionCliente = @direccionCliente,
		NombrePaisCliente = @nombrePaisCliente,
		NombreDepartamentoCliente = @nombreDepartamentoCliente,
		NombreProvinciaCliente = @nombreProvinciaCliente,
		CodigoDistritoCliente = @codigoDistritoCliente,
		NombreDistritoCliente = @nombreDistritoCliente,
		CodigoMoneda = @codigoMoneda,
		CodigoMetodoPago = @codigoMetodoPago,
		CantidadLetrasCredito = @cantidadLetrasCredito,
		TotalOperacionGravada = @totalOperacionGravada,
		TotalOperacionInafecta = @totalOperacionInafecta,
		TotalOperacionExonerada = @totalOperacionExonerada,
		TotalOperacionExportacion = @totalOperacionExportacion,
		TotalOperacionGratuita = @totalOperacionGratuita,
		TotalValorVenta = @totalValorVenta,
		TotalIgv = @totalIgv,
		TotalIsc = @totalIsc,
		TotalOtrosCargos = @totalOtrosCargos,
		TotalOtrosTributos = @totalOtrosTributos,
		TotalIcbper = @totalIcbper,
		TotalDescuentoDetallado = @totalDescuentoDetallado,
		TotalPorcentajeDescuentoGlobal = @totalPorcentajeDescuentoGlobal,
		TotalDescuentoGlobal = @totalDescuentoGlobal,
		TotalPrecioVenta = @totalPrecioVenta,
		TotalImporte = @totalImporte,
		TotalPercepcion = @totalPercepcion,
		TotalPagar = @totalPagar,
		FlagEmitido = @flagEmitido,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoFacturaVenta = @codigoFacturaVenta
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventa_obtener]
@codigoFacturaVenta int
as
begin
	select
	bv.CodigoFacturaVenta,
	bv.CodigoSerie,
	bv.NroComprobante,
	bv.FechaHoraEmision,
	bv.FechaHoraVencimiento,
	bv.CodigoCliente,
	bv.DireccionCliente,
	bv.NombrePaisCliente,
	bv.NombreDepartamentoCliente,
	bv.NombreProvinciaCliente,
	bv.CodigoDistritoCliente,
	bv.NombreDistritoCliente,
	bv.CodigoMoneda,
	bv.CodigoMetodoPago,
	bv.CantidadLetrasCredito,
	bv.TotalOperacionGravada,
	bv.TotalOperacionInafecta,
	bv.TotalOperacionExonerada,
	bv.TotalOperacionExportacion,
	bv.TotalOperacionGratuita,
	bv.TotalValorVenta,
	bv.TotalIgv,
	bv.TotalIsc,
	bv.TotalOtrosCargos,
	bv.TotalOtrosTributos,
	bv.TotalIcbper,
	bv.TotalDescuentoDetallado,
	bv.TotalPorcentajeDescuentoGlobal,
	bv.TotalDescuentoGlobal,
	bv.TotalPrecioVenta,
	bv.TotalImporte,
	bv.TotalPercepcion,
	bv.TotalPagar,
	bv.FlagEmitido,
	bv.FlagActivo
	from
	FacturaVenta bv
	where
	bv.CodigoFacturaVenta = @codigoFacturaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_eliminar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_facturaventadetalle_eliminar]
@codigoFacturaVentaDetalle int,
@usuarioModi varchar(20)
as
begin
	update FacturaVentaDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoFacturaVentaDetalle = @codigoFacturaVentaDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventadetalle_guardar]
@codigoFacturaVenta int,
@codigoFacturaVentaDetalle int out,
@codigoProducto int,
@codigoProductoIndividual int,
@codigoUnidadMedida int,
@detalle varchar(max),
@cantidad decimal(18, 2),
@tipoCalculo int,
@valorUnitario decimal(18, 2),
@precioUnitario decimal(18, 2),
@valorVenta decimal(18, 2),
@precioVenta decimal(18, 2),
@igv decimal(18, 2),
@isc decimal(18, 2),
@tipoDescuento int,
@porcentajeDescuento decimal(18, 2),
@descuento decimal(18, 2),
@otrosCargos decimal(18, 2),
@otrosTributos decimal(18, 2),
@baseImponible decimal(18, 2),
@importe decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoFacturaVentaDetalle = (select CodigoFacturaVentaDetalle from FacturaVentaDetalle where CodigoFacturaVentaDetalle = @codigoFacturaVentaDetalle)

	if @codigoFacturaVentaDetalle is null
	begin
		select @codigoFacturaVentaDetalle = isnull(max(CodigoFacturaVentaDetalle), 0) + 1 from FacturaVentaDetalle

		insert into FacturaVentaDetalle
		(CodigoFacturaVenta, CodigoFacturaVentaDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, TipoCalculo, ValorUnitario, PrecioUnitario, ValorVenta, PrecioVenta,
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe, FlagEliminado,
		UsuarioGraba, FechaGraba)
		values
		(@codigoFacturaVenta, @codigoFacturaVentaDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 0,
		@usuarioModi, getdate())
	end
	else
	begin
		update FacturaVentaDetalle set
		CodigoProducto = @codigoProducto,
		CodigoProductoIndividual = @codigoProductoIndividual,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Detalle = @detalle,
		Cantidad = @cantidad,
		TipoCalculo = @tipoCalculo,
		ValorUnitario = @valorUnitario,
		PrecioUnitario = @precioUnitario,
		ValorVenta = @valorVenta,
		PrecioVenta = @precioVenta,
		Igv = @igv,
		Isc = @isc,
		TipoDescuento = @tipoDescuento,
		PorcentajeDescuento = @porcentajeDescuento,
		Descuento = @descuento,
		OtrosCargos = @otrosCargos,
		OtrosTributos = @otrosTributos,
		BaseImponible = @baseImponible,
		Importe = @importe,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoFacturaVentaDetalle = @codigoFacturaVentaDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_listar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventadetalle_listar]
@codigoFacturaVenta int
as
begin
	select
	cast(row_number() over(order by fvd.CodigoFacturaVentaDetalle desc) as int) [Fila],
	fvd.CodigoFacturaVenta,
	fvd.CodigoFacturaVentaDetalle,
	fvd.CodigoProducto,
	p.Nombre [NombreProducto],
	fvd.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	fvd.CodigoUnidadMedida,
	fvd.Detalle,
	fvd.Cantidad,
	fvd.ValorUnitario,
	fvd.PrecioUnitario,
	fvd.ValorVenta,
	fvd.PrecioVenta,
	fvd.Igv,
	fvd.Isc,
	fvd.PorcentajeDescuento,
	fvd.Descuento,
	fvd.OtrosCargos,
	fvd.OtrosTributos,
	fvd.BaseImponible,
	fvd.Importe,
	fvd.FlagEliminado
	from
	FacturaVentaDetalle fvd inner join
	Producto p on fvd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on fvd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	CodigoFacturaVenta = @codigoFacturaVenta and
	FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_guiaremision_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@codigoSerie int,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by gr.CodigoGuiaRemision desc) as int) [Fila],
	gr.CodigoGuiaRemision,
	gr.FechaHoraEmision,
	gr.FechaHoraTraslado,
	gr.CodigoTipoComprobante,
	tc.Nombre [NombreTipoComprobante],
	gr.CodigoSerie,
	s.Serial [SerialSerie],
	gr.NroComprobante,
	gr.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdic.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	gr.CodigoMotivoTraslado,
	mt.Descripcion [DescripcionMotivoTraslado],
	gr.CodigoTransportista,
	p.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadTransportista],
	tdip.Descripcion [DescripcionTipoDocumentoIdentidadTransportista],
	p.NroDocumentoIdentidad [NroDocumentoIdentidadTransportista],
	p.Nombres [NombresTransportista],
	p.FlagActivo [FlagActivoTransportista],
	gr.MarcaVehiculoTransportista,
	gr.PlacaVehiculoTransportista,
	gr.LicenciaConducirTransportista,
	gr.FlagEmitido,
	gr.FlagActivo
	from
	GuiaRemision gr inner join
	TipoComprobante tc on gr.CodigoTipoComprobante = tc.CodigoTipoComprobante inner join
	Serie s on gr.CodigoSerie = s.CodigoSerie inner join
	Cliente c on gr.CodigoCliente = c.CodigoCliente inner join
	Proveedor p on gr.CodigoTransportista = p.CodigoProveedor inner join
	MotivoTraslado mt on gr.CodigoMotivoTraslado = mt.CodigoMotivoTraslado inner join
	TipoDocumentoIdentidad tdic on c.CodigoTipoDocumentoIdentidad = tdic.CodigoTipoDocumentoIdentidad inner join
	TipoDocumentoIdentidad tdip on p.CodigoTipoDocumentoIdentidad = tdip.CodigoTipoDocumentoIdentidad
	where
	(cast(gr.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(gr.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(gr.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(gr.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(gr.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_guiaremision_guardar]
@codigoGuiaRemision int out,
@codigoTipoComprobante int,
@codigoSerie int,
@nroComprobante int out,
@fechaHoraEmision datetime,
@fechaHoraTraslado datetime,
@codigoCliente int,
@direccionCliente varchar(100),
@nombrePaisCliente varchar(50),
@nombreDepartamentoCliente varchar(50),
@nombreProvinciaCliente varchar(50),
@nombreDistritoCliente varchar(50),
@codigoDistritoCliente int,
@codigoMotivoTraslado int,
@codigoTransportista int,
@direccionTransportista varchar(100),
@nombrePaisTransportista varchar(50),
@nombreDepartamentoTransportista varchar(50),
@nombreProvinciaTransportista varchar(50),
@nombreDistritoTransportista varchar(50),
@codigoDistritoTransportista int,
@marcaVehiculoTransportista varchar(50),
@placaVehiculoTransportista varchar(50),
@licenciaConducirTransportista varchar(50),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoGuiaRemision = (select CodigoGuiaRemision from GuiaRemision where CodigoGuiaRemision = @codigoGuiaRemision)

	if @codigoGuiaRemision is null
	begin
		select @codigoGuiaRemision = isnull(max(CodigoGuiaRemision), 0) + 1 from GuiaRemision
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into GuiaRemision
		(CodigoGuiaRemision, CodigoTipoComprobante, CodigoSerie, NroComprobante, FechaHoraEmision, FechaHoraTraslado,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMotivoTraslado,
		CodigoTransportista, DireccionTransportista, NombrePaisTransportista, NombreDepartamentoTransportista,
		NombreProvinciaTransportista, CodigoDistritoTransportista, NombreDistritoTransportista,
		MarcaVehiculoTransportista, PlacaVehiculoTransportista, LicenciaConducirTransportista,
		FlagEmitido, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoGuiaRemision, @codigoTipoComprobante, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraTraslado,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMotivoTraslado,
		@codigoTransportista, @direccionTransportista, @nombrePaisTransportista, @nombreDepartamentoTransportista,
		@nombreProvinciaTransportista, @codigoDistritoTransportista, @nombreDistritoTransportista,
		@marcaVehiculoTransportista, @placaVehiculoTransportista, @licenciaConducirTransportista,
		@flagEmitido, 1, @usuarioModi, getdate())

		exec usp_serie_aumentarvaloractual @codigoSerie, @usuarioModi
	end
	else
	begin
		update GuiaRemision set
		FechaHoraEmision = @fechaHoraEmision,
		FechaHoraTraslado = @fechaHoraTraslado,
		CodigoCliente = @codigoCliente,
		DireccionCliente = @direccionCliente,
		NombrePaisCliente = @nombrePaisCliente,
		NombreDepartamentoCliente = @nombreDepartamentoCliente,
		NombreProvinciaCliente = @nombreProvinciaCliente,
		CodigoDistritoCliente = @codigoDistritoCliente,
		NombreDistritoCliente = @nombreDistritoCliente,
		CodigoMotivoTraslado = @codigoMotivoTraslado,
		CodigoTransportista = @codigoTransportista,
		DireccionTransportista = @direccionTransportista,
		NombrePaisTransportista = @nombrePaisTransportista,
		NombreDepartamentoTransportista = @nombreDepartamentoTransportista,
		NombreProvinciaTransportista = @nombreProvinciaTransportista,
		CodigoDistritoTransportista = @codigoDistritoTransportista,
		NombreDistritoTransportista = @nombreDistritoTransportista,
		MarcaVehiculoTransportista = @marcaVehiculoTransportista,
		PlacaVehiculoTransportista = @placaVehiculoTransportista,
		LicenciaConducirTransportista = @licenciaConducirTransportista,
		FlagEmitido = @flagEmitido,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoGuiaRemision = @codigoGuiaRemision
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_guiaremision_obtener]
@codigoGuiaRemision int
as
begin
	select
	gr.CodigoGuiaRemision,
	gr.CodigoTipoComprobante,
	gr.CodigoSerie,
	gr.NroComprobante,
	gr.FechaHoraEmision,
	gr.FechaHoraTraslado,
	gr.CodigoCliente,
	gr.DireccionCliente,
	gr.NombrePaisCliente,
	gr.NombreDepartamentoCliente,
	gr.NombreProvinciaCliente,
	gr.CodigoDistritoCliente,
	gr.NombreDistritoCliente,
	gr.CodigoMotivoTraslado,
	gr.CodigoTransportista,
	gr.DireccionTransportista,
	gr.NombrePaisTransportista,
	gr.NombreDepartamentoTransportista,
	gr.NombreProvinciaTransportista,
	gr.CodigoDistritoTransportista,
	gr.NombreDistritoTransportista,
	gr.MarcaVehiculoTransportista,
	gr.PlacaVehiculoTransportista,
	gr.LicenciaConducirTransportista,
	gr.FlagEmitido,
	gr.FlagActivo
	from
	GuiaRemision gr
	where
	gr.CodigoGuiaRemision = @codigoGuiaRemision
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_eliminar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_guiaremisiondetalle_eliminar]
@codigoGuiaRemisionDetalle int,
@usuarioModi varchar(20)
as
begin
	update GuiaRemisionDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoGuiaRemisionDetalle = @codigoGuiaRemisionDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_guiaremisiondetalle_guardar]
@codigoGuiaRemision int,
@codigoGuiaRemisionDetalle int out,
@codigoProducto int,
@codigoProductoIndividual int,
@codigoUnidadMedida int,
@detalle varchar(max),
@cantidad decimal(18, 2),
@codigoUnidadMedidaPeso int,
@peso decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoGuiaRemisionDetalle = (select CodigoGuiaRemisionDetalle from GuiaRemisionDetalle where CodigoGuiaRemisionDetalle = @codigoGuiaRemisionDetalle)

	if @codigoGuiaRemisionDetalle is null
	begin
		select @codigoGuiaRemisionDetalle = isnull(max(CodigoGuiaRemisionDetalle), 0) + 1 from GuiaRemisionDetalle

		insert into GuiaRemisionDetalle
		(CodigoGuiaRemision, CodigoGuiaRemisionDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, CodigoUnidadMedidaPeso, Peso, FlagEliminado,
		UsuarioGraba, FechaGraba)
		values
		(@codigoGuiaRemision, @codigoGuiaRemisionDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @codigoUnidadMedidaPeso, @peso, 0,
		@usuarioModi, getdate())
	end
	else
	begin
		update GuiaRemisionDetalle set
		CodigoProducto = @codigoProducto,
		CodigoProductoIndividual = @codigoProductoIndividual,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Detalle = @detalle,
		Cantidad = @cantidad,
		CodigoUnidadMedidaPeso = @codigoUnidadMedidaPeso,
		Peso = @peso,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoGuiaRemisionDetalle = @codigoGuiaRemisionDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_listar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_guiaremisiondetalle_listar]
@codigoGuiaRemision int
as
begin
	select
	cast(row_number() over(order by grd.CodigoGuiaRemisionDetalle desc) as int) [Fila],
	grd.CodigoGuiaRemision,
	grd.CodigoGuiaRemisionDetalle,
	grd.CodigoProducto,
	p.Nombre [NombreProducto],
	grd.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	grd.CodigoUnidadMedida,
	grd.Detalle,
	grd.Cantidad,
	grd.CodigoUnidadMedidaPeso,
	grd.Peso,
	grd.FlagEliminado
	from
	GuiaRemisionDetalle grd inner join
	Producto p on grd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on grd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	CodigoGuiaRemision = @codigoGuiaRemision and
	FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_eliminar_x_ref]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_eliminar_x_ref]
@codigoTipoComprobanteRef int,
@codigoSerieRef int,
@numeroRef int,
@usuarioModi varchar(20)
as
begin
	update Letra set
	FlagActivo = 0,
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoTipoComprobanteRef = @codigoTipoComprobanteRef and
	CodigoSerieRef = @codigoSerieRef and
	NumeroRef = @numeroRef
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_guardar]
@codigoLetra int out,
@numero int out,
@fechaHoraEmision datetime,
@fechaVencimiento date,
@dias int,
@codigoTipoComprobanteRef int,
@codigoSerieRef int,
@numeroRef int,
@codigoSerieGuia int,
@numeroGuia int,
@codigoCliente int,
@codigoBanco int,
@codigoUnicoBanco varchar(50),
@codigoMoneda int,
@monto decimal(18, 2),
@estado varchar(50),
@flagCancelado bit,
@usuarioModi varchar(20)
as
begin
	set @codigoLetra = (select CodigoLetra from Letra where CodigoLetra = @codigoLetra)

	if @codigoLetra is null
	begin
		select @codigoLetra = isnull(max(CodigoLetra), 0) + 1 from Letra
		select @numero = isnull(ValorActual, 0) + 1 from TipoDocumento where CodigoTipoDocumento = 1

		insert into Letra
		(CodigoLetra, Numero, FechaHoraEmision, FechaVencimiento, Dias,
		CodigoTipoComprobanteRef, CodigoSerieRef, NumeroRef, CodigoSerieGuia, NumeroGuia,
		CodigoCliente, CodigoBanco, CodigoUnicoBanco, CodigoMoneda, Monto, Estado, FlagCancelado,
		FlagActivo, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoLetra, @numero, @fechaHoraEmision, @fechaVencimiento, @dias,
		@codigoTipoComprobanteRef, @codigoSerieRef, @numeroRef, @codigoSerieGuia, @numeroGuia,
		@codigoCliente, @codigoBanco, @codigoUnicoBanco, @codigoMoneda, @monto, @estado, @flagCancelado,
		1, 0, @usuarioModi, getdate())

		exec [dbo].[usp_tipodocumento_aumentarvaloractual] 1, @usuarioModi
	end
	else
	begin
		update Letra set
		FechaHoraEmision = @fechaHoraEmision,
		FechaVencimiento = @fechaVencimiento,
		Dias = @dias,
		CodigoTipoComprobanteRef = @codigoTipoComprobanteRef,
		CodigoSerieRef = @codigoSerieRef,
		NumeroRef = @numeroRef,
		CodigoSerieGuia = @codigoSerieGuia,
		NumeroGuia = @numeroGuia,
		CodigoCliente = @codigoCliente,
		CodigoBanco = @codigoBanco,
		CodigoUnicoBanco = @codigoUnicoBanco,
		CodigoMoneda = @codigoMoneda,
		Monto = @monto,
		Estado = @estado,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where CodigoLetra = @codigoLetra
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_listar_x_ref]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_listar_x_ref]
@codigoTipoComprobanteRef int,
@codigoSerieRef int,
@numeroRef int
as
begin
	select
	cast(row_number() over(order by CodigoLetra) as int) [Fila],
	l.CodigoLetra,
	l.Numero,
	l.FechaHoraEmision,
	l.FechaVencimiento,
	l.Dias,
	l.CodigoTipoComprobanteRef,
	l.CodigoSerieRef,
	l.NumeroRef,
	l.CodigoSerieGuia,
	l.NumeroGuia,
	l.CodigoCliente,
	l.CodigoBanco,
	l.CodigoUnicoBanco,
	l.CodigoMoneda,
	l.Monto,
	l.Estado,
	l.FlagCancelado
	from Letra l
	where
	l.CodigoTipoComprobanteRef = @codigoTipoComprobanteRef and
	l.CodigoSerieRef = @codigoSerieRef and
	l.NumeroRef = @numeroRef and
	l.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_menu_buscar]
@nombre varchar(50),
@formulario varchar(50),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by m.Nombre) as int) [Fila],
	m.CodigoMenu,
	m.Nombre,
	m.Formulario,
	m.CodigoMenuPadre,
	mp.Nombre [NombreMenuPadre],
	m.FlagActivo
	from
	Menu m left join
	Menu mp on m.CodigoMenuPadre = mp.CodigoMenu
	where
	(m.Nombre like '%' + isnull(@nombre, '') + '%') and
	(isnull(m.Formulario, '') like '%' + isnull(@formulario, '') + '%') and
	m.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_menu_cambiar_flagactivo]
@codigoMenu int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Menu set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoMenu = @codigoMenu
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_menu_existe]
@codigoMenu int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Menu where Nombre = @nombre and CodigoMenu != isnull(@codigoMenu, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_menu_guardar]
@codigoMenu int,
@nombre varchar(50),
@formulario varchar(50),
@codigoMenuPadre int,
@usuarioModi varchar(20)
as
begin
	set @codigoMenu = (select CodigoMenu from Menu where CodigoMenu = @codigoMenu)

	if @codigoMenu is null
	begin
		select @codigoMenu = isnull(max(CodigoMenu), 0) + 1 from Menu

		insert into Menu
		(CodigoMenu, Nombre, Formulario, CodigoMenuPadre, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoMenu, @nombre, @formulario, @codigoMenuPadre, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Menu set
		Nombre = @nombre,
		Formulario = @formulario,
		@codigoMenuPadre = @codigoMenuPadre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoMenu = @codigoMenu
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_combo_menupadre]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_menu_listar_combo_menupadre]
@codigoMenu int
as
begin
	select
	m.CodigoMenu,
	m.Nombre,
	m.Formulario,
	m.CodigoMenuPadre
	from Menu m
	where m.CodigoMenu != @codigoMenu or @codigoMenu is null
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_default_x_perfil]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_menu_listar_default_x_perfil]
@codigoPerfil int
as
begin
	select
	m.CodigoMenu,
	m.Nombre,
	m.Formulario,
	m.CodigoMenuPadre,
	cast(case when pm.CodigoPerfil is null then 0 else 1 end as bit) [Check]
	from Menu m left join
	PerfilMenu pm on m.CodigoMenu = pm.CodigoMenu and pm.CodigoPerfil = @codigoPerfil
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_x_perfil]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_menu_listar_x_perfil]
@codigoPerfil int
as
begin
	select
	m.CodigoMenu,
	m.Nombre,
	m.Formulario,
	m.CodigoMenuPadre
	from Menu m
	inner join PerfilMenu pm on m.CodigoMenu = pm.CodigoMenu
	where
	pm.CodigoPerfil = @codigoPerfil and
	m.FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_menu_obtener]
@codigoMenu int
as
begin
	select
	m.CodigoMenu,
	m.Nombre,
	m.Formulario,
	m.CodigoMenuPadre,
	m.FlagActivo
	from
	Menu m
	where
	m.CodigoMenu = @codigoMenu
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_buscar]
@descripcion varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by mt.Descripcion) as int) [Fila],
	mt.CodigoMotivoTraslado,
	mt.Descripcion,
	mt.FlagActivo
	from
	MotivoTraslado mt
	where
	(mt.Descripcion like '%' + isnull(@descripcion, '') + '%') and
	mt.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_cambiar_flagactivo]
@codigoMotivoTraslado int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update MotivoTraslado set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoMotivoTraslado = @codigoMotivoTraslado
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_existe]
@codigoMotivoTraslado int,
@descripcion varchar(50)
as
begin
	select cast(count(1) as bit) from MotivoTraslado where Descripcion = @descripcion and CodigoMotivoTraslado != isnull(@codigoMotivoTraslado, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_guardar]
@codigoMotivoTraslado int,
@descripcion varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoMotivoTraslado = (select CodigoMotivoTraslado from MotivoTraslado where CodigoMotivoTraslado = @codigoMotivoTraslado)

	if @codigoMotivoTraslado is null
	begin
		select @codigoMotivoTraslado = isnull(max(CodigoMotivoTraslado), 0) + 1 from MotivoTraslado

		insert into MotivoTraslado
		(CodigoMotivoTraslado, Descripcion, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoMotivoTraslado, @descripcion, 1, @usuarioModi, getdate())
	end
	else
	begin
		update MotivoTraslado set
		Descripcion = @descripcion,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoMotivoTraslado = @codigoMotivoTraslado
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_listar_combo]
as
begin
	select
	mt.CodigoMotivoTraslado,
	mt.Descripcion,
	mt.FlagActivo
	from
	MotivoTraslado mt
	where FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivotraslado_obtener]
@codigoMotivoTraslado int
as
begin
	select
	mt.CodigoMotivoTraslado,
	mt.Descripcion,
	mt.FlagActivo
	from
	MotivoTraslado mt
	where
	mt.CodigoMotivoTraslado = @codigoMotivoTraslado
end
GO
/****** Object:  StoredProcedure [dbo].[usp_pais_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_pais_listar_combo]
as
begin
	select
	p.CodigoPais,
	p.Nombre,
	p.Nacionalidad
	from Pais p
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_buscar]
@nombre varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by p.Nombre) as int) [Fila],
	p.CodigoPerfil,
	p.Nombre,
	p.FlagActivo
	from
	Perfil p
	where
	(p.Nombre like '%' + isnull(@nombre, '') + '%') and
	p.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_cambiar_flagactivo]
@codigoPerfil int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Perfil set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoPerfil = @codigoPerfil
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_existe]
@codigoPerfil int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Perfil where Nombre = @nombre and CodigoPerfil != isnull(@codigoPerfil, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_perfil_guardar]
@codigoPerfil int out,
@nombre varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoPerfil = (select CodigoPerfil from Perfil where CodigoPerfil = @codigoPerfil)

	if @codigoPerfil is null
	begin
		select @codigoPerfil = isnull(max(CodigoPerfil), 0) + 1 from Perfil

		insert into Perfil
		(CodigoPerfil, Nombre, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoPerfil, @nombre, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Perfil set
		Nombre = @nombre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoPerfil = @codigoPerfil
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_listar_default_x_usuario]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_listar_default_x_usuario]
@codigoUsuario int
as
begin
	select
	p.CodigoPerfil,
	p.Nombre,
	p.FlagActivo,
	cast(case when up.CodigoUsuario is null then 0 else 1 end as bit) [Check]
	from Perfil p left join
	UsuarioPerfil up on p.CodigoPerfil = up.CodigoPerfil and up.CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_listar_x_usuario]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_listar_x_usuario]
@codigoUsuario int
as
begin
	select
	p.CodigoPerfil,
	p.Nombre,
	p.FlagActivo
	from Perfil p
	inner join UsuarioPerfil up on p.CodigoPerfil = up.CodigoPerfil
	where up.CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfil_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfil_obtener]
@codigoPerfil int
as
begin
	select
	p.CodigoPerfil,
	p.Nombre,
	p.FlagActivo
	from
	Perfil p
	where
	p.CodigoPerfil = @codigoPerfil
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfilmenu_eliminar_x_perfil]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfilmenu_eliminar_x_perfil]
@codigoPerfil int
as
begin
	delete from PerfilMenu where CodigoPerfil = @codigoPerfil
end
GO
/****** Object:  StoredProcedure [dbo].[usp_perfilmenu_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_perfilmenu_guardar]
@codigoPerfil int,
@codigoMenu int
as
begin
	insert into PerfilMenu
	(CodigoPerfil, CodigoMenu)
	values
	(@codigoPerfil, @codigoMenu)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_buscar]
@nroDocumentoIdentidad varchar(20),
@nombres varchar(50),
@correo varchar(50),
@nombreArea varchar(50),
@flagActivo bit,
@estado int
as
begin
	select
	cast(row_number() over(order by p.Nombres) as int) [Fila],
	p.CodigoPersonal,
	p.CodigoTipoDocumentoIdentidad,
	tdi.Descripcion [DescripcionTipoDocumentoIdentidad],
	p.NroDocumentoIdentidad,
	p.Nombres,
	p.Correo,
	p.CodigoArea,
	a.Nombre [NombreArea],
	a.FlagActivo [FlagActivoArea],
	p.FlagActivo,
	p.Estado
	from
	Personal p inner join
	TipoDocumentoIdentidad tdi on p.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	Area a on p.CodigoArea = a.CodigoArea
	where
	p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidad, '') + '%' and
	p.Nombres like '%' + isnull(@nombres, '') + '%' and
	p.Correo like '%' + isnull(@correo, '') + '%' and
	a.Nombre like '%' + isnull(@nombreArea, '') + '%' and
	p.FlagActivo = @flagActivo and
	(p.Estado = @estado or @estado is null)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_cambiar_estado]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_cambiar_estado]
@codigoPersonal int,
@estado bit,
@usuarioModi varchar(20)
as
begin
	update Personal set
	Estado = @estado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoPersonal = @codigoPersonal
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_cambiar_flagactivo]
@codigoPersonal int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Personal set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoPersonal = @codigoPersonal
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_existe]
@codigoPersonal int,
@nroDocumentoIdentidad varchar(20)
as
begin
	select cast(count(1) as bit) from Personal where NroDocumentoIdentidad = @nroDocumentoIdentidad and CodigoPersonal != isnull(@codigoPersonal, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_guardar]
@codigoPersonal int,
@codigoTipoDocumentoIdentidad int,
@nroDocumentoIdentidad varchar(20),
@nombres varchar(100),
@correo varchar(50),
@codigoArea int,
@estado int,
@usuarioModi varchar(20)
as
begin
	set @codigoPersonal = (select CodigoPersonal from Personal where CodigoPersonal = @codigoPersonal)

	if @codigoPersonal is null
	begin
		select @codigoPersonal = isnull(max(CodigoPersonal), 0) + 1 from Personal

		insert into Personal
		(CodigoPersonal, CodigoTipoDocumentoIdentidad, NroDocumentoIdentidad, Nombres, Correo, CodigoArea, FlagActivo, Estado, UsuarioGraba, FechaGraba)
		values
		(@CodigoPersonal, @codigoTipoDocumentoIdentidad, @nroDocumentoIdentidad, @nombres, @correo, @codigoArea, 1, @estado, @usuarioModi, getdate())
	end
	else
	begin
		update Personal set
		CodigoTipoDocumentoIdentidad = @codigoTipoDocumentoIdentidad,
		NroDocumentoIdentidad = @nroDocumentoIdentidad,
		Nombres = @nombres,
		Correo = @correo,
		CodigoArea = @codigoArea,
		Estado = @estado,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoPersonal = @codigoPersonal
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_personal_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_personal_obtener]
@codigoPersonal int
as
begin
	select
	p.CodigoPersonal,
	p.CodigoTipoDocumentoIdentidad,
	p.NroDocumentoIdentidad,
	p.Nombres,
	p.Correo,
	p.CodigoArea,
	p.FlagActivo,
	p.Estado
	from Personal p
	where p.CodigoPersonal = @codigoPersonal
end
GO
/****** Object:  StoredProcedure [dbo].[usp_producto_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_producto_buscar]
@codigoProducto int,
@nombre varchar(50),
@color varchar(20),
@estado int
as
begin
	select
	cast(row_number() over(order by p.Nombre) as int) [Fila],
	p.CodigoProducto,
	p.Nombre,
	p.CodigoUnidadMedida,
	um.Descripcion [DescripcionUnidadMedida],
	um.FlagActivo [FlagActivoUnidadMedida],
	p.Cantidad,
	p.ValorCompra,
	p.ValorVenta,
	p.DescuentoMaximo,
	p.Color,
	p.MetrajeTotal,
	p.Estado
	from
	Producto p inner join
	UnidadMedida um on p.CodigoUnidadMedida = um.CodigoUnidadMedida
	where
	(p.CodigoProducto = @codigoProducto or @codigoProducto is null) and
	p.Nombre like '%' + isnull(@nombre, '') + '%' and
	p.Color like '%' + isnull(@color, '') + '%' and
	(p.Estado = @estado or @estado is null)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_producto_cambiar_estado]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_producto_cambiar_estado]
@codigoProducto int,
@estado bit,
@usuarioModi varchar(20)
as
begin
	update Producto set
	Estado = @estado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoProducto = @codigoProducto
end
GO
/****** Object:  StoredProcedure [dbo].[usp_producto_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_producto_existe]
@codigoProducto int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Producto where Nombre = @nombre and CodigoProducto != isnull(@codigoProducto, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_producto_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_producto_guardar]
@codigoProducto int,
@nombre varchar(50),
@codigoUnidadMedida int,
@cantidad decimal(18, 2),
@valorCompra decimal(18, 2),
@valorVenta decimal(18, 2),
@descuentoMaximo decimal(18, 2),
@color varchar(20),
@metrajeTotal decimal(18, 2),
@estado int,
@usuarioModi varchar(20)
as
begin
	set @codigoProducto = (select CodigoProducto from Producto where CodigoProducto = @codigoProducto)

	if @codigoProducto is null
	begin
		select @codigoProducto = isnull(max(CodigoProducto), 0) + 1 from Producto

		insert into Producto
		(CodigoProducto, Nombre, CodigoUnidadMedida, Cantidad, ValorCompra, ValorVenta, DescuentoMaximo, Color, MetrajeTotal, Estado, UsuarioGraba, FechaGraba)
		values
		(@CodigoProducto, @nombre, @codigoUnidadMedida, @cantidad, @valorCompra, @valorVenta, @descuentoMaximo, @color, @metrajeTotal, @estado, @usuarioModi, getdate())
	end
	else
	begin
		update Producto set
		Nombre = @nombre,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Cantidad = @cantidad,
		ValorCompra = @valorCompra,
		ValorVenta = @valorVenta,
		DescuentoMaximo = @descuentoMaximo,
		Color = @color,
		MetrajeTotal = @metrajeTotal,
		Estado = @estado,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoProducto = @codigoProducto
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_producto_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_producto_obtener]
@codigoProducto int
as
begin
	select
	c.CodigoProducto,
	c.Nombre,
	c.CodigoUnidadMedida,
	c.Cantidad,
	c.ValorCompra,
	c.ValorVenta,
	c.DescuentoMaximo,
	c.Color,
	c.MetrajeTotal,
	c.Estado
	from
	Producto c
	where
	c.CodigoProducto = @codigoProducto
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_buscar]
@codigoProductoIndividual int,
@codigoBarra varchar(50),
@codigoProducto int,
@nombre varchar(50),
@codigoInicial varchar(50),
@color varchar(20),
@nroDocumentoIdentidadProveedor varchar(20),
@nombresProveedor varchar(100),
@fechaEntradaDesde date,
@fechaEntradaHasta date,
@nroDocumentoIdentidadPersonaInspeccion varchar(20),
@nombresPersonalInspeccion varchar(100)
as
begin
	select
	cast(row_number() over(order by p.Nombre) as int) [Fila],
	[pi].CodigoProductoIndividual,
	[pi].CodigoBarra,
	[pi].CodigoProducto,
	[pi].Nombre,
	[pi].CodigoUnidadMedida,
	um.Descripcion [DescripcionUnidadMedida],
	um.FlagActivo [FlagActivoUnidadMedida],
	[pi].Metraje,
	[pi].Peso,
	[pi].CodigoInicial,
	[pi].Rollo,
	[pi].Bulto,
	[pi].Color,
	[pi].CodigoProveedor,
	prov.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadProveedor],
	prov.NroDocumentoIdentidad [NroDocumentoIdentidadProveedor],
	prov.Nombres [NombresProveedor],
	prov.Direccion [DireccionProveedor],
	prov.CodigoDistrito [CodigoDistritoProveedor],
	prov.Correo [CorreoProveedor],
	prov.Telefono [TelefonoProveedor],
	prov.Contacto [ContactoProveedor],
	prov.FlagActivo [FlagActivoProveedor],
	[pi].CodigoBarraProveedor,
	[pi].FechaEntrada,
	[pi].CodigoPersonalInspeccion,
	[per].CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadPersonalInspeccion],
	[per].NroDocumentoIdentidad [NroDocumentoIdentidadPersonalInspeccion],
	[per].Nombres [NombresPersonalInspeccion],
	[per].Correo [CorreoPersonalInspeccion],
	[per].CodigoArea [CodigoAreaPersonalInspeccion],
	[per].FlagActivo [FlagActivoPersonalInspeccion],
	[per].Estado [EstadoPersonalInspeccion]
	from
	ProductoIndividual [pi] inner join
	Producto p on [pi].CodigoProducto = p.CodigoProducto inner join
	UnidadMedida um on [pi].CodigoUnidadMedida = um.CodigoUnidadMedida inner join
	Proveedor prov on [pi].CodigoProveedor = prov.CodigoProveedor inner join
	Personal per on [pi].CodigoPersonalInspeccion = per.CodigoPersonal
	where
	([pi].CodigoProductoIndividual = @codigoProductoIndividual or @codigoProductoIndividual is null) and
	[pi].CodigoBarra like '%' + isnull(@codigoBarra, '') + '%' and
	([pi].CodigoProducto = @codigoProducto or @codigoProducto is null) and
	[pi].Nombre like '%' + isnull(@nombre, '') + '%' and
	[pi].CodigoInicial like '%' + isnull(@codigoInicial, '') + '%' and
	[pi].Color like '%' + isnull(@color, '') + '%' and
	[prov].NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadProveedor, '') + '%' and
	[prov].Nombres like '%' + isnull(@nombresProveedor, '') + '%' and
	(cast([pi].FechaEntrada as date) between @fechaEntradaDesde and @fechaEntradaHasta or (@fechaEntradaDesde is null and @fechaEntradaHasta is null)) and
	[per].NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonaInspeccion, '') + '%' and
	[per].Nombres like '%' + isnull(@nombresPersonalInspeccion, '') + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_existe]
@codigoProductoIndividual int,
@codigoBarra varchar(50),
@nombre varchar(50),
@flagCodigoBarraExiste bit out,
@flagNombreExiste bit out
as
begin
	select @flagCodigoBarraExiste = cast(count(1) as bit) from ProductoIndividual where CodigoBarra = @codigoBarra and CodigoProductoIndividual != isnull(@codigoProductoIndividual, 0)
	select @flagNombreExiste = cast(count(1) as bit) from ProductoIndividual where Nombre = @nombre and CodigoProductoIndividual != isnull(@codigoProductoIndividual, 0)

	select cast(case when @flagCodigoBarraExiste = 0 and @flagNombreExiste = 0 then 0 else 1 end as bit)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_productoindividual_guardar]
@codigoProductoIndividual int,
@codigoBarra varchar(50),
@codigoProducto int,
@nombre varchar(50),
@codigoUnidadMedida int,
@metraje decimal(18, 2),
@peso decimal(18, 2),
@codigoInicial varchar(50),
@rollo decimal(18, 2),
@bulto decimal(18, 2),
@color varchar(20),
@codigoProveedor int,
@codigoBarraProveedor varchar(50),
@fechaEntrada datetime,
@codigoPersonalInspeccion int,
@usuarioModi varchar(20)
as
begin
	set @codigoProductoIndividual = (select CodigoProductoIndividual from ProductoIndividual where CodigoProductoIndividual = @codigoProductoIndividual)

	if @codigoProductoIndividual is null
	begin
		select @codigoProductoIndividual = isnull(max(CodigoProductoIndividual), 0) + 1 from ProductoIndividual

		insert into ProductoIndividual
		(CodigoProductoIndividual, CodigoBarra, CodigoProducto, Nombre, CodigoUnidadMedida, Metraje, Peso, CodigoInicial, Rollo, Bulto, Color, CodigoProveedor, CodigoBarraProveedor, FechaEntrada, CodigoPersonalInspeccion, UsuarioGraba, FechaGraba)
		values
		(@CodigoProductoIndividual, @codigoBarra, @codigoProducto, @nombre, @codigoUnidadMedida, @metraje, @peso, @codigoInicial, @rollo, @bulto, @color, @codigoProveedor, @codigoBarraProveedor, @fechaEntrada, @codigoPersonalInspeccion, @usuarioModi, getdate())
	end
	else
	begin
		update ProductoIndividual set
		CodigoBarra = @codigoBarra,
		CodigoProducto = @codigoProducto,
		Nombre = @nombre,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Metraje = @metraje,
		Peso = @peso,
		CodigoInicial = @codigoInicial,
		Rollo = @rollo,
		Bulto = @bulto,
		Color = @color,
		CodigoProveedor = @codigoProveedor,
		CodigoBarraProveedor = @codigoBarraProveedor,
		FechaEntrada = @fechaEntrada,
		CodigoPersonalInspeccion = @codigoPersonalInspeccion,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoProductoIndividual = @codigoProductoIndividual
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_productoindividual_obtener]
@codigoProductoIndividual int
as
begin
	select
	c.CodigoProductoIndividual,
	c.CodigoBarra,
	c.CodigoProducto,
	c.Nombre,
	c.CodigoUnidadMedida,
	c.Metraje,
	c.Peso,
	c.CodigoInicial,
	c.Rollo,
	c.Bulto,
	c.Color,
	c.CodigoProveedor,
	c.CodigoBarraProveedor,
	c.FechaEntrada,
	c.CodigoPersonalInspeccion
	from
	ProductoIndividual c
	where
	c.CodigoProductoIndividual = @codigoProductoIndividual
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_proveedor_buscar]
@nroDocumentoIdentidad varchar(20),
@nombres varchar(100),
@direccion varchar(100),
@correo varchar(50),
@contacto varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by p.Nombres) as int) [Fila],
	p.CodigoProveedor,
	p.CodigoTipoDocumentoIdentidad,
	tdi.Descripcion [DescripcionTipoDocumentoIdentidad],
	p.NroDocumentoIdentidad,
	p.Nombres,
	p.Direccion,
	p.CodigoDistrito,
	d.CodigoUbigeo [CodigoUbigeoDistrito],
	d.Nombre [NombreDistrito],
	d.CodigoProvincia,
	pr.CodigoUbigeo [CodigoUbigeoProvincia],
	pr.Nombre [NombreProvincia],
	pr.CodigoDepartamento,
	de.CodigoUbigeo [CodigoUbigeoDepartamento],
	de.Nombre [NombreDepartamento],
	de.CodigoPais,
	pa.Nombre [NombrePais],
	p.Correo,
	p.Telefono,
	p.Contacto,
	p.FlagActivo
	from
	Proveedor p inner join
	TipoDocumentoIdentidad tdi on p.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	Distrito d on p.CodigoDistrito = d.CodigoDistrito inner join
	Provincia pr on d.CodigoProvincia = pr.CodigoProvincia inner join
	Departamento de on pr.CodigoDepartamento = de.CodigoDepartamento inner join
	Pais pa on de.CodigoPais = pa.CodigoPais
	where
	p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidad, '') + '%' and
	p.Nombres like '%' + isnull(@nombres, '') + '%' and
	p.Direccion like '%' + isnull(@direccion, '') + '%' and
	p.Correo like '%' + isnull(@correo, '') + '%' and
	p.Contacto like '%' + isnull(@contacto, '') + '%' and
	p.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_proveedor_cambiar_flagactivo]
@codigoProveedor int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Proveedor set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoProveedor = @codigoProveedor
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_proveedor_existe]
@codigoProveedor int,
@nroDocumentoIdentidad varchar(20)
as
begin
	select cast(count(1) as bit) from Proveedor where NroDocumentoIdentidad = @nroDocumentoIdentidad and CodigoProveedor != isnull(@codigoProveedor, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_proveedor_guardar]
@codigoProveedor int,
@codigoTipoDocumentoIdentidad int,
@nroDocumentoIdentidad varchar(20),
@nombres varchar(100),
@direccion varchar(100),
@codigoDistrito int,
@correo varchar(50),
@telefono varchar(100),
@contacto varchar(100),
@usuarioModi varchar(20)
as
begin
	select * from Proveedor
	set @codigoProveedor = (select CodigoProveedor from Proveedor where CodigoProveedor = @codigoProveedor)

	if @codigoProveedor is null
	begin
		select @codigoProveedor = isnull(max(CodigoProveedor), 0) + 1 from Proveedor

		insert into Proveedor
		(CodigoProveedor, CodigoTipoDocumentoIdentidad, NroDocumentoIdentidad, Nombres, Direccion, CodigoDistrito, Correo, Telefono, Contacto, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoProveedor, @CodigoTipoDocumentoIdentidad, @NroDocumentoIdentidad, @Nombres, @Direccion, @codigoDistrito, @Correo, @Telefono, @Contacto, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Proveedor set
		CodigoTipoDocumentoIdentidad = @codigoTipoDocumentoIdentidad,
		NroDocumentoIdentidad = @nroDocumentoIdentidad,
		Nombres = @nombres,
		Direccion = @direccion,
		CodigoDistrito = @codigoDistrito,
		Correo = @correo,
		Telefono = @telefono,
		Contacto = @contacto,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoProveedor = @codigoProveedor
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_proveedor_obtener]
@codigoProveedor int
as
begin
	select
	p.CodigoProveedor,
	p.CodigoTipoDocumentoIdentidad,
	p.NroDocumentoIdentidad,
	p.Nombres,
	p.Direccion,
	p.CodigoDistrito,
	d.CodigoUbigeo [CodigoUbigeoDistrito],
	d.Nombre [NombreDistrito],
	d.CodigoProvincia,
	pr.CodigoUbigeo [CodigoUbigeoProvincia],
	pr.Nombre [NombreProvincia],
	pr.CodigoDepartamento,
	de.CodigoUbigeo [CodigoUbigeoDepartamento],
	de.Nombre [NombreDepartamento],
	de.CodigoPais,
	pa.Nombre [NombrePais],
	p.Correo,
	p.Telefono,
	p.Contacto
	from
	Proveedor p inner join
	Distrito d on p.CodigoDistrito = d.CodigoDistrito inner join
	Provincia pr on d.CodigoProvincia = pr.CodigoProvincia inner join
	Departamento de on pr.CodigoDepartamento = de.CodigoDepartamento inner join
	Pais pa on de.CodigoPais = pa.CodigoPais
	where
	p.CodigoProveedor = @codigoProveedor
end
GO
/****** Object:  StoredProcedure [dbo].[usp_provincia_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_provincia_listar_combo]
as
begin
	select
	p.CodigoProvincia,
	p.CodigoDepartamento,
	p.CodigoUbigeo,
	p.Nombre
	from Provincia p
end
GO
/****** Object:  StoredProcedure [dbo].[usp_query_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_query_buscar]
@table varchar(max),
@columns varchar(max),
@columnsFilter varchar(max)
as
begin
	declare @query nvarchar(max)

	set @query = N'select ' + @columns + ' from ' + @table + ' where ' + @columnsFilter

	exec(@query)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_aumentarvaloractual]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_serie_aumentarvaloractual]
@codigoSerie int,
@usuarioModi varchar(20)
as
begin
	update Serie set
	ValorActual += 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoSerie = @codigoSerie
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_serie_buscar]
@serial varchar(100),
@codigoTipoComprobante int,
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by s.Serial) as int) [Fila],
	s.CodigoSerie,
	s.CodigoTipoComprobante,
	tc.Nombre [NombreTipoComprobante],
	s.Serial,
	s.ValorInicial,
	s.ValorFinal,
	s.ValorActual,
	s.FlagActivo
	from
	Serie s inner join
	TipoComprobante tc on s.CodigoTipoComprobante = tc.CodigoTipoComprobante
	where
	(s.CodigoTipoComprobante = @codigoTipoComprobante or @codigoTipoComprobante is null) and
	(s.Serial like '%' + isnull(@serial, '') + '%') and
	s.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_serie_cambiar_flagactivo]
@codigoSerie int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Serie set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoSerie = @codigoSerie
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_serie_existe]
@codigoSerie int,
@codigoTipoComprobante int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Serie where Serial = @nombre and CodigoTipoComprobante = @codigoTipoComprobante and CodigoSerie != isnull(@codigoSerie, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_serie_guardar]
@codigoSerie int,
@codigoTipoComprobante int,
@serial varchar(50),
@valorInicial int,
@valorFinal int,
@valorActual int,
@usuarioModi varchar(20)
as
begin
	set @codigoSerie = (select CodigoSerie from Serie where CodigoSerie = @codigoSerie)

	if @codigoSerie is null
	begin
		select @codigoSerie = isnull(max(CodigoSerie), 0) + 1 from Serie

		insert into Serie
		(CodigoSerie, CodigoTipoComprobante, Serial, ValorInicial, ValorFinal, ValorActual, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoSerie, @codigoTipoComprobante, @serial, @valorInicial, @valorFinal, @valorActual, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Serie set
		Serial = @serial,
		ValorInicial = @valorInicial,
		ValorFinal = @valorFinal,
		ValorActual = @valorActual,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoSerie = @codigoSerie
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_serie_listar_combo]
@codigoTipoComprobante int
as
begin
	select
	s.CodigoSerie,
	s.CodigoTipoComprobante,
	s.Serial,
	s.ValorInicial,
	s.ValorFinal,
	s.ValorActual,
	s.FlagActivo
	from Serie s
	where
	s.FlagActivo = 1 and
	s.CodigoTipoComprobante = @codigoTipoComprobante
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_serie_obtener]
@codigoSerie int
as
begin
	select
	s.CodigoSerie,
	s.CodigoTipoComprobante,
	s.Serial,
	s.ValorInicial,
	s.ValorFinal,
	s.ValorActual,
	s.FlagActivo
	from
	Serie s
	where
	s.CodigoSerie = @codigoSerie
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocomprobante_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipocomprobante_listar_combo]
as
begin
	select
	tc.CodigoTipoComprobante,
	tc.Nombre
	from
	TipoComprobante tc
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipodocumento_aumentarvaloractual]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipodocumento_aumentarvaloractual]
@codigoTipoDocumento int,
@usuarioModi varchar(20)
as
begin
	update TipoDocumento set
	ValorActual += 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoTipoDocumento = @codigoTipoDocumento
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipodocumentoidentidad_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_tipodocumentoidentidad_listar_combo]
as
begin
	select
	tdi.CodigoTipoDocumentoIdentidad,
	tdi.Descripcion,
	tdi.CantidadCaracteres
	from
	TipoDocumentoIdentidad tdi
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_buscar]
@descripcion varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by um.Descripcion) as int) [Fila],
	um.CodigoUnidadMedida,
	um.Descripcion,
	um.FlagActivo
	from
	UnidadMedida um
	where
	(um.Descripcion like '%' + isnull(@descripcion, '') + '%') and
	um.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_cambiar_flagactivo]
@codigoUnidadMedida int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update UnidadMedida set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoUnidadMedida = @codigoUnidadMedida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_existe]
@codigoUnidadMedida int,
@descripcion varchar(50)
as
begin
	select cast(count(1) as bit) from UnidadMedida where Descripcion = @descripcion and CodigoUnidadMedida != isnull(@codigoUnidadMedida, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_guardar]
@codigoUnidadMedida int,
@descripcion varchar(50),
@usuarioModi varchar(20)
as
begin
	set @codigoUnidadMedida = (select CodigoUnidadMedida from UnidadMedida where CodigoUnidadMedida = @codigoUnidadMedida)

	if @codigoUnidadMedida is null
	begin
		select @codigoUnidadMedida = isnull(max(CodigoUnidadMedida), 0) + 1 from UnidadMedida

		insert into UnidadMedida
		(CodigoUnidadMedida, Descripcion, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoUnidadMedida, @descripcion, 1, @usuarioModi, getdate())
	end
	else
	begin
		update UnidadMedida set
		Descripcion = @descripcion,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoUnidadMedida = @codigoUnidadMedida
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_listar_combo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_listar_combo]
as
begin
	select
	um.CodigoUnidadMedida,
	um.Descripcion,
	um.FlagActivo
	from UnidadMedida um
	where
	um.FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_unidadmedida_obtener]
@codigoUnidadMedida int
as
begin
	select
	a.CodigoUnidadMedida,
	a.Descripcion,
	a.FlagActivo
	from
	UnidadMedida a
	where
	a.CodigoUnidadMedida = @codigoUnidadMedida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_buscar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_usuario_buscar]
@nombre varchar(20),
@nroDocumentoIdentidadPersonal varchar(20),
@nombresPersonal varchar(100),
@correoPersonal varchar(50),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by u.Nombre) as int) [Fila],
	u.CodigoUsuario,
	u.Nombre,
	u.CodigoPersonal,
	p.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadPersonal],
	p.NroDocumentoIdentidad [NroDocumentoIdentidadPersonal],
	p.Nombres [NombresPersonal],
	p.Correo [CorreoPersonal],
	p.CodigoArea [CodigoAreaPersonal],
	p.FlagActivo [FlagActivoPersonal],
	p.Estado [EstadoPersonal],
	u.FlagCambiarContraseña,
	u.FlagActivo
	from
	Usuario u inner join
	Personal p on u.CodigoPersonal = p.CodigoPersonal
	where
	(u.Nombre like '%' + isnull(@nombre, '') + '%') and
	(p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonal, '') + '%') and
	(p.Nombres like '%' + isnull(@nombresPersonal, '') + '%') and
	(p.Correo like '%' + isnull(@correoPersonal, '') + '%') and
	u.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_cambiar_flagactivo]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_usuario_cambiar_flagactivo]
@codigoUsuario int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update Usuario set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_cambiar_flagcambiarcontraseña]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_usuario_cambiar_flagcambiarcontraseña]
@codigoUsuario int,
@contraseña varbinary(20),
@flagCambiarContraseña bit,
@usuarioModi varchar(20)
as
begin
	update Usuario set
	Contraseña = @contraseña,
	FlagCambiarContraseña = @flagCambiarContraseña,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_existe]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_usuario_existe]
@codigoUsuario int,
@nombre varchar(50)
as
begin
	select cast(count(1) as bit) from Usuario where Nombre = @nombre and CodigoUsuario != isnull(@codigoUsuario, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_usuario_guardar]
@codigoUsuario int out,
@nombre varchar(20),
@contraseña varbinary(20),
@codigoPersonal int,
@usuarioModi varchar(20)
as
begin
	set @codigoUsuario = (select CodigoUsuario from Usuario where CodigoUsuario = @codigoUsuario)

	if @codigoUsuario is null
	begin
		select @codigoUsuario = isnull(max(CodigoUsuario), 0) + 1 from Usuario

		insert into Usuario
		(CodigoUsuario, Nombre, Contraseña, CodigoPersonal, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoUsuario, @nombre, @contraseña, @codigoPersonal, 1, @usuarioModi, getdate())
	end
	else
	begin
		update Usuario set
		Nombre = @nombre,
		CodigoPersonal = @codigoPersonal,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoUsuario = @codigoUsuario
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_obtener]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_usuario_obtener]
@codigoUsuario int
as
begin
	select
	u.CodigoUsuario,
	u.Nombre,
	u.Contraseña,
	u.CodigoPersonal,
	u.FlagCambiarContraseña
	from
	Usuario u
	where
	u.CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_obtener_x_nombre]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_usuario_obtener_x_nombre]
@nombre varchar(20)
as
begin
	select
	u.CodigoUsuario,
	u.Nombre,
	u.Contraseña,
	u.CodigoPersonal,
	u.FlagCambiarContraseña,
	u.FlagActivo
	from Usuario u
	where u.Nombre = @nombre
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuarioperfil_eliminar_x_usuario]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_usuarioperfil_eliminar_x_usuario]
@codigoUsuario int
as
begin
	delete from UsuarioPerfil where CodigoUsuario = @codigoUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuarioperfil_guardar]    Script Date: 27/09/2020 04:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_usuarioperfil_guardar]
@codigoUsuario int,
@codigoPerfil int
as
begin
	insert into UsuarioPerfil
	(CodigoUsuario, CodigoPerfil)
	values
	(@codigoUsuario, @codigoPerfil)
end
GO
