USE [dbPM]
GO
/****** Object:  UserDefinedFunction [dbo].[CantidadConLetra]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CantidadConLetra]
(
    @valor decimal(18,2),
	@moneda varchar(max)
)
RETURNS Varchar(max)
AS
BEGIN
    DECLARE @ImpLetra Varchar(180)
        DECLARE @lnEntero INT,
                        @lcRetorno VARCHAR(512),
                        @lnTerna INT,
                        @lcMiles VARCHAR(512),
                        @lcCadena VARCHAR(512),
                        @lnUnidades INT,
                        @lnDecenas INT,
                        @lnCentenas INT,
                        @lnFraccion INT
        SELECT  @lnEntero = CAST(@valor AS INT),
                        @lnFraccion = (@valor - @lnEntero) * 100,
                        @lcRetorno = '',
                        @lnTerna = 1
  WHILE @lnEntero > 0
  BEGIN /* WHILE */
            -- Recorro terna por terna
            SELECT @lcCadena = ''
            SELECT @lnUnidades = @lnEntero % 10
            SELECT @lnEntero = CAST(@lnEntero/10 AS INT)
            SELECT @lnDecenas = @lnEntero % 10
            SELECT @lnEntero = CAST(@lnEntero/10 AS INT)
            SELECT @lnCentenas = @lnEntero % 10
            SELECT @lnEntero = CAST(@lnEntero/10 AS INT)
            -- Analizo las unidades
            SELECT @lcCadena =
            CASE /* UNIDADES */
              WHEN @lnUnidades = 1 THEN 'UN ' + @lcCadena
              WHEN @lnUnidades = 2 THEN 'DOS ' + @lcCadena
              WHEN @lnUnidades = 3 THEN 'TRES ' + @lcCadena
              WHEN @lnUnidades = 4 THEN 'CUATRO ' + @lcCadena
              WHEN @lnUnidades = 5 THEN 'CINCO ' + @lcCadena
              WHEN @lnUnidades = 6 THEN 'SEIS ' + @lcCadena
              WHEN @lnUnidades = 7 THEN 'SIETE ' + @lcCadena
              WHEN @lnUnidades = 8 THEN 'OCHO ' + @lcCadena
              WHEN @lnUnidades = 9 THEN 'NUEVE ' + @lcCadena
              ELSE @lcCadena
            END /* UNIDADES */
            -- Analizo las decenas
            SELECT @lcCadena =
            CASE /* DECENAS */
              WHEN @lnDecenas = 1 THEN
                CASE @lnUnidades
                  WHEN 0 THEN 'DIEZ '
                  WHEN 1 THEN 'ONCE '
                  WHEN 2 THEN 'DOCE '
                  WHEN 3 THEN 'TRECE '
                  WHEN 4 THEN 'CATORCE '
                  WHEN 5 THEN 'QUINCE '
                  WHEN 6 THEN 'DIECISÉIS '
                  WHEN 7 THEN 'DIECISIETE '
                  WHEN 8 THEN 'DIECIOCHO '
                  WHEN 9 THEN 'DIECINUEVE '
                END
              WHEN @lnDecenas = 2 THEN
              CASE @lnUnidades
                WHEN 0 THEN 'VEINTE '
                ELSE 'VEINTI' + @lcCadena
              END
              WHEN @lnDecenas = 3 THEN
              CASE @lnUnidades
                WHEN 0 THEN 'TREINTA '
                ELSE 'TREINTA Y ' + @lcCadena
              END
              WHEN @lnDecenas = 4 THEN
                CASE @lnUnidades
                    WHEN 0 THEN 'CUARENTA'
                    ELSE 'CUARENTA Y ' + @lcCadena
                END
              WHEN @lnDecenas = 5 THEN
                CASE @lnUnidades
                    WHEN 0 THEN 'CINCUENTA '
                    ELSE 'CINCUENTA Y ' + @lcCadena
                END
              WHEN @lnDecenas = 6 THEN
                CASE @lnUnidades
                    WHEN 0 THEN 'SESENTA '
                    ELSE 'SESENTA Y ' + @lcCadena
                END
              WHEN @lnDecenas = 7 THEN
                 CASE @lnUnidades
                    WHEN 0 THEN 'SETENTA '
                    ELSE 'SETENTA Y ' + @lcCadena
                 END
              WHEN @lnDecenas = 8 THEN
                CASE @lnUnidades
                    WHEN 0 THEN 'OCHENTA '
                    ELSE  'OCHENTA Y ' + @lcCadena
                END
              WHEN @lnDecenas = 9 THEN
                CASE @lnUnidades
                    WHEN 0 THEN 'NOVENTA '
                    ELSE 'NOVENTA Y ' + @lcCadena
                END
              ELSE @lcCadena
            END /* DECENAS */
            -- Analizo las centenas
            SELECT @lcCadena =
            CASE /* CENTENAS */
              WHEN @lnCentenas = 1 THEN 'CIENTO ' + @lcCadena
              WHEN @lnCentenas = 2 THEN 'DOSCIENTOS ' + @lcCadena
              WHEN @lnCentenas = 3 THEN 'TRESCIENTOS ' + @lcCadena
              WHEN @lnCentenas = 4 THEN 'CUATROCIENTOS ' + @lcCadena
              WHEN @lnCentenas = 5 THEN 'QUINIENTOS ' + @lcCadena
              WHEN @lnCentenas = 6 THEN 'SEISCIENTOS ' + @lcCadena
              WHEN @lnCentenas = 7 THEN 'SETECIENTOS ' + @lcCadena
              WHEN @lnCentenas = 8 THEN 'OCHOCIENTOS ' + @lcCadena
              WHEN @lnCentenas = 9 THEN 'NOVECIENTOS ' + @lcCadena
              ELSE @lcCadena
            END /* CENTENAS */
            -- Analizo la terna
            SELECT @lcCadena =
            CASE /* TERNA */
              WHEN @lnTerna = 1 THEN @lcCadena
              WHEN @lnTerna = 2 THEN @lcCadena + 'MIL '
              WHEN @lnTerna = 3 THEN @lcCadena + 'MILLONES '
              WHEN @lnTerna = 4 THEN @lcCadena + 'MIL '
              ELSE ''
            END /* TERNA */
            -- Armo el retorno terna a terna
            SELECT @lcRetorno = @lcCadena  + @lcRetorno
            SELECT @lnTerna = @lnTerna + 1
   END /* WHILE */
   IF @lnTerna = 1
       SELECT @lcRetorno = 'CERO'
   DECLARE @sFraccion VARCHAR(15)
   SET @sFraccion = '00' + LTRIM(CAST(@lnFraccion AS varchar))
   SELECT @ImpLetra = RTRIM(@lcRetorno) + ' CON ' + SUBSTRING(@sFraccion,LEN(@sFraccion)-1,2) + '/100 ' + @moneda

   RETURN @ImpLetra
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_obtener_codigoletrainicial]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_obtener_codigoletrainicial]
(
	@codigoLetraPadre int
) returns int
as
begin
	declare @codigoLetraInicial int

	while @codigoLetraPadre is not null
	begin
		set @codigoLetraInicial = @codigoLetraPadre

		set @codigoLetraPadre = (select CodigoLetraPadre from Letra where CodigoLetra = @codigoLetraPadre)
	end

	return @codigoLetraInicial
end
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[AfectacionIgv]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AfectacionIgv](
	[CodigoAfectacionIgv] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CodigoSunat] [varchar](2) NULL,
 CONSTRAINT [PK_AfectacionIgv] PRIMARY KEY CLUSTERED 
(
	[CodigoAfectacionIgv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[Banco]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[BoletaVenta]    Script Date: 28/01/2021 23:32:43 ******/
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
	[CodigoGuiaRemision] [int] NULL,
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
	[CodigoCotizacion] [int] NULL,
	[Hash] [varchar](max) NULL,
	[CodigoRptaSunat] [varchar](max) NULL,
	[DescripcionRptaSunat] [varchar](max) NULL,
	[FlagCancelado] [bit] NULL,
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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoletaVentaDetalle]    Script Date: 28/01/2021 23:32:43 ******/
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
	[CodigoAfectacionIgv] [int] NULL,
	[Igv] [decimal](18, 2) NULL,
	[Isc] [decimal](18, 2) NULL,
	[TipoDescuento] [int] NULL,
	[PorcentajeDescuento] [decimal](18, 2) NULL,
	[Descuento] [decimal](18, 2) NULL,
	[OtrosCargos] [decimal](18, 2) NULL,
	[OtrosTributos] [decimal](18, 2) NULL,
	[BaseImponible] [decimal](18, 2) NULL,
	[Importe] [decimal](18, 2) NULL,
	[CodigoGuiaRemision] [int] NULL,
	[CodigoGuiaRemisionDetalle] [int] NULL,
	[CodigoCotizacion] [int] NULL,
	[CodigoCotizacionDetalle] [int] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[ComprobanteCompra]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobanteCompra](
	[CodigoComprobanteCompra] [int] NOT NULL,
	[FechaHoraRegistro] [datetime] NULL,
	[FechaCompra] [date] NULL,
	[CodigoTipoComprobante] [int] NULL,
	[Serie] [varchar](4) NULL,
	[Numero] [int] NULL,
	[CodigoProveedor] [int] NULL,
	[SerieGuia] [varchar](4) NULL,
	[NumeroGuia] [int] NULL,
	[TotalImporte] [decimal](18, 2) NULL,
	[FlagCompleto] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_ComprobanteCompra] PRIMARY KEY CLUSTERED 
(
	[CodigoComprobanteCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobanteCompraDetalle]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobanteCompraDetalle](
	[CodigoComprobanteCompra] [int] NULL,
	[CodigoComprobanteCompraDetalle] [int] NOT NULL,
	[CodigoProducto] [int] NULL,
	[Detalle] [varchar](max) NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
	[ImporteTotal] [decimal](18, 2) NULL,
	[FlagCompleto] [bit] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [nchar](10) NULL,
 CONSTRAINT [PK_ComprobanteCompraDetalle] PRIMARY KEY CLUSTERED 
(
	[CodigoComprobanteCompraDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobantePago]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobantePago](
	[CodigoComprobantePago] [int] NOT NULL,
	[FechaHoraPago] [datetime] NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[CodigoMoneda] [int] NULL,
	[CodigoCliente] [int] NULL,
	[Descripcion] [varchar](100) NULL,
	[Monto] [decimal](18, 2) NULL,
	[FlagAnulado] [bit] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_ComprobantePago] PRIMARY KEY CLUSTERED 
(
	[CodigoComprobantePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobantePagoDetalle]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobantePagoDetalle](
	[CodigoComprobantePagoDetalle] [int] NOT NULL,
	[CodigoComprobantePago] [int] NULL,
	[CodigoTipoDocumentoPago] [int] NULL,
	[CodigoDocumentoPago] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[Monto] [decimal](18, 2) NULL,
	[Mora] [decimal](18, 2) NULL,
	[Protesto] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[MontoPagar] [decimal](18, 2) NULL,
	[MoraPagar] [decimal](18, 2) NULL,
	[ProtestoPagar] [decimal](18, 2) NULL,
	[ImportePagar] [decimal](18, 2) NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_ComprobantePagoDetalle] PRIMARY KEY CLUSTERED 
(
	[CodigoComprobantePagoDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfiguracionValor]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfiguracionValor](
	[CodigoUsuario] [int] NULL,
	[CodigoTransportistaGuiaRemision] [int] NULL,
	[CodigoTipoComprobanteGuiaRemision] [int] NULL,
	[RutaFacturacionElectronica] [varchar](max) NULL,
	[RutaCertificado] [varchar](max) NULL,
	[ContraseñaCertificado] [varchar](max) NULL,
	[UsuarioSOL] [varchar](max) NULL,
	[ContraseñaSOL] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlBusqueda]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlBusqueda](
	[CodigoControlBusqueda] [int] NULL,
	[Formulario] [varchar](50) NULL,
	[Control] [varchar](50) NULL,
	[FromTables] [varchar](max) NULL,
	[WhereMain] [varchar](max) NULL,
	[TituloFormulario] [varchar](50) NULL,
	[TipoObjeto] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlBusquedaColumna]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlBusquedaColumna](
	[CodigoControlBusquedaColumna] [int] NOT NULL,
	[CodigoControlBusqueda] [int] NULL,
	[CampoBD] [varchar](50) NULL,
	[NombreAtributo] [varchar](50) NULL,
	[Titulo] [varchar](50) NULL,
	[Formato] [varchar](50) NULL,
	[EsVisible] [bit] NULL,
	[TipoColumna] [varchar](50) NULL,
	[EsFiltro] [bit] NULL,
	[Ancho] [int] NULL,
 CONSTRAINT [PK_ControlBusquedaColumna] PRIMARY KEY CLUSTERED 
(
	[CodigoControlBusquedaColumna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizacion]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizacion](
	[CodigoCotizacion] [int] NOT NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[NroPedido] [varchar](50) NULL,
	[CodigoCliente] [int] NULL,
	[CodigoVendedor] [int] NULL,
	[CodigoSupervisor] [int] NULL,
	[CodigoMoneda] [int] NULL,
	[TotalImporte] [decimal](18, 2) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_Cotizacion] PRIMARY KEY CLUSTERED 
(
	[CodigoCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CotizacionDetalle]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CotizacionDetalle](
	[CodigoCotizacion] [int] NOT NULL,
	[CodigoCotizacionDetalle] [int] NOT NULL,
	[CodigoProducto] [int] NULL,
	[CodigoProductoIndividual] [int] NULL,
	[Detalle] [varchar](max) NULL,
	[CodigoUnidadMedida] [int] NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
	[Importe] [decimal](18, 2) NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_CotizacionDetalle] PRIMARY KEY CLUSTERED 
(
	[CodigoCotizacionDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[Distrito]    Script Date: 28/01/2021 23:32:43 ******/
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
/****** Object:  Table [dbo].[EmpresaTipoOperacionVenta]    Script Date: 28/01/2021 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaTipoOperacionVenta](
	[EmpresaId] [int] NOT NULL,
	[TipoOperacionVentaId] [int] NOT NULL,
 CONSTRAINT [PK_EmpresaTipoOperacionVenta] PRIMARY KEY CLUSTERED 
(
	[EmpresaId] ASC,
	[TipoOperacionVentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 28/01/2021 23:32:43 ******/
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
	[CodigoGuiaRemision] [int] NULL,
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
	[CodigoCotizacion] [int] NULL,
	[Hash] [varchar](max) NULL,
	[CodigoRptaSunat] [varchar](max) NULL,
	[DescripcionRptaSunat] [varchar](max) NULL,
	[FlagCancelado] [bit] NULL,
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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVentaDetalle]    Script Date: 28/01/2021 23:32:44 ******/
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
	[CodigoAfectacionIgv] [int] NULL,
	[Igv] [decimal](18, 2) NULL,
	[Isc] [decimal](18, 2) NULL,
	[TipoDescuento] [int] NULL,
	[PorcentajeDescuento] [decimal](18, 2) NULL,
	[Descuento] [decimal](18, 2) NULL,
	[OtrosCargos] [decimal](18, 2) NULL,
	[OtrosTributos] [decimal](18, 2) NULL,
	[BaseImponible] [decimal](18, 2) NULL,
	[Importe] [decimal](18, 2) NULL,
	[CodigoGuiaRemision] [int] NULL,
	[CodigoGuiaRemisionDetalle] [int] NULL,
	[CodigoCotizacion] [int] NULL,
	[CodigoCotizacionDetalle] [int] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuiaRemision]    Script Date: 28/01/2021 23:32:44 ******/
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
	[CodigoCotizacion] [int] NULL,
	[Hash] [varchar](max) NULL,
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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuiaRemisionDetalle]    Script Date: 28/01/2021 23:32:44 ******/
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
	[CodigoCotizacion] [int] NULL,
	[CodigoCotizacionDetalle] [int] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Letra]    Script Date: 28/01/2021 23:32:44 ******/
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
	[CodigoComprobanteRef] [int] NULL,
	[CodigoGuiaRemision] [int] NULL,
	[CodigoCliente] [int] NULL,
	[CodigoBanco] [int] NULL,
	[CodigoUnicoBanco] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[Monto] [decimal](18, 2) NULL,
	[Mora] [decimal](18, 2) NULL,
	[Protesto] [decimal](18, 2) NULL,
	[Estado] [int] NULL,
	[CodigoLetraInicial] [int] NULL,
	[CodigoLetraPadre] [int] NULL,
	[FlagAval] [bit] NULL,
	[CodigoAval] [int] NULL,
	[DireccionAval] [varchar](100) NULL,
	[NombrePaisAval] [varchar](50) NULL,
	[NombreDepartamentoAval] [varchar](50) NULL,
	[NombreProvinciaAval] [varchar](50) NULL,
	[CodigoDistritoAval] [int] NULL,
	[NombreDistritoAval] [varchar](50) NULL,
	[Observacion] [varchar](max) NULL,
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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Moneda]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moneda](
	[CodigoMoneda] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Simbolo] [varchar](50) NULL,
	[CodigoSunat] [varchar](3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotivoNota]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotivoNota](
	[CodigoMotivoNota] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[CodigoTipoComprobante] [int] NULL,
	[CodigoSunat] [varchar](2) NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_MotivoNota] PRIMARY KEY CLUSTERED 
(
	[CodigoMotivoNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotivoTraslado]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[NotaCredito]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaCredito](
	[CodigoNotaCredito] [int] NOT NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[DireccionCliente] [varchar](100) NULL,
	[NombrePaisCliente] [varchar](50) NULL,
	[NombreDepartamentoCliente] [varchar](50) NULL,
	[NombreProvinciaCliente] [varchar](50) NULL,
	[CodigoDistritoCliente] [int] NULL,
	[NombreDistritoCliente] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[CodigoMotivoNota] [int] NULL,
	[CodigoTipoComprobanteRef] [int] NULL,
	[CodigoComprobanteRef] [int] NULL,
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
	[Hash] [varchar](max) NULL,
	[CodigoRptaSunat] [varchar](max) NULL,
	[DescripcionRptaSunat] [varchar](max) NULL,
	[FlagEmitido] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaCreditoDetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaCreditoDetalle](
	[CodigoNotaCredito] [int] NULL,
	[CodigoNotaCreditoDetalle] [int] NULL,
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
	[CodigoTipoComprobanteRef] [int] NULL,
	[CodigoComprobanteRef] [int] NULL,
	[CodigoComprobanteDetalleRef] [int] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaDebito]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaDebito](
	[CodigoNotaDebito] [int] NOT NULL,
	[CodigoSerie] [int] NULL,
	[NroComprobante] [int] NULL,
	[FechaHoraEmision] [datetime] NULL,
	[CodigoCliente] [int] NULL,
	[DireccionCliente] [varchar](100) NULL,
	[NombrePaisCliente] [varchar](50) NULL,
	[NombreDepartamentoCliente] [varchar](50) NULL,
	[NombreProvinciaCliente] [varchar](50) NULL,
	[CodigoDistritoCliente] [int] NULL,
	[NombreDistritoCliente] [varchar](50) NULL,
	[CodigoMoneda] [int] NULL,
	[CodigoMotivoNota] [int] NULL,
	[CodigoTipoComprobanteRef] [int] NULL,
	[CodigoComprobanteRef] [int] NULL,
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
	[Hash] [varchar](max) NULL,
	[CodigoRptaSunat] [varchar](max) NULL,
	[DescripcionRptaSunat] [varchar](max) NULL,
	[FlagEmitido] [bit] NULL,
	[FlagActivo] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaDebitoDetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaDebitoDetalle](
	[CodigoNotaDebito] [int] NULL,
	[CodigoNotaDebitoDetalle] [int] NULL,
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
	[CodigoTipoComprobanteRef] [int] NULL,
	[CodigoComprobanteRef] [int] NULL,
	[CodigoComprobanteDetalleRef] [int] NULL,
	[FlagEliminado] [bit] NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Perfil]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[PerfilMenu]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Personal]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[ProductoIndividual]    Script Date: 28/01/2021 23:32:44 ******/
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
	[CodigoUnidadMedidaPeso] [int] NULL,
	[Peso] [decimal](18, 2) NULL,
	[CodigoInicial] [int] NULL,
	[Rollo] [decimal](18, 2) NULL,
	[Bulto] [decimal](18, 2) NULL,
	[Color] [varchar](50) NULL,
	[CodigoProveedor] [int] NULL,
	[CodigoBarraProveedor] [varchar](50) NULL,
	[FechaEntrada] [datetime] NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[PrecioCompra] [decimal](18, 2) NULL,
	[CodigoPersonalInspeccion] [int] NULL,
	[CodigoComprobanteCompra] [int] NULL,
	[CodigoComprobanteCompraDetalle] [int] NULL,
	[FlagActivo] [bit] NULL,
	[FlagEliminado] [bit] NULL,
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Provincia]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[Serie]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[TipoCambio]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCambio](
	[CodigoTipoCambio] [int] NOT NULL,
	[FechaCambio] [date] NULL,
	[ValorCompra] [decimal](18, 2) NULL,
	[ValorVenta] [decimal](18, 2) NULL,
	[UsuarioGraba] [varchar](20) NULL,
	[FechaGraba] [datetime] NULL,
	[UsuarioModi] [varchar](20) NULL,
	[FechaModi] [datetime] NULL,
 CONSTRAINT [PK_TipoCambio] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoCambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoComprobante]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoComprobante](
	[CodigoTipoComprobante] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[CodigoSunat] [varchar](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[TipoDocumentoIdentidad]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentoIdentidad](
	[CodigoTipoDocumentoIdentidad] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[CantidadCaracteres] [int] NULL,
	[CodigoSunat] [varchar](2) NULL,
 CONSTRAINT [PK_TipoDocumentoIdentidad] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoDocumentoIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentoPago]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentoPago](
	[CodigoTipoDocumentoPago] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumentoPago] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoDocumentoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoOperacionVenta]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoOperacionVenta](
	[TipoOperacionVentaId] [int] NOT NULL,
	[Nombre] [varchar](100) NULL,
	[CodigoSunat] [varchar](2) NULL,
 CONSTRAINT [PK_TipoOperacionVenta] PRIMARY KEY CLUSTERED 
(
	[TipoOperacionVentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[CodigoUnidadMedida] [int] NOT NULL,
	[Descripcion] [varchar](300) NULL,
	[CodigoSunat] [varchar](3) NULL,
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_actividad_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_area_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_banco_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
	bv.CodigoGuiaRemision,
	gr.CodigoTipoComprobante [CodigoTipoComprobanteGuiaRemision],
	tc.Nombre [NombreTipoComprobanteGuiaRemision],
	gr.CodigoSerie [CodigoSerieGuiaRemision],
	sgr.Serial [SerialSerieGuiaRemision],
	gr.NroComprobante [NroComprobanteGuiaRemision],
	gr.FechaHoraEmision [FechaHoraEmisionGuiaRemision],
	bv.CodigoCotizacion,
	co.NroComprobante [NroComprobanteCotizacion],
	co.NroPedido [NroPedidoCotizacion],
	co.FechaHoraEmision [FechaHoraEmisionCotizacion],
	bv.FlagEmitido,
	bv.FlagActivo
	from
	BoletaVenta bv inner join
	Serie s on bv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on bv.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad left join
	GuiaRemision gr on bv.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
	TipoComprobante tc on gr.CodigoTipoComprobante = tc.CodigoTipoComprobante left join
	Serie sgr on gr.CodigoSerie = sgr.CodigoSerie left join
	Cotizacion co on bv.CodigoCotizacion = co.CodigoCotizacion
	where
	(cast(bv.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(bv.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(bv.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(bv.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(bv.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
@totalEnLetras nvarchar(max) out,
@codigoGuiaRemision int,
@codigoCotizacion int,
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoBoletaVenta = (select CodigoBoletaVenta from BoletaVenta where CodigoBoletaVenta = @codigoBoletaVenta)

	declare @nombreMoneda varchar(max) = (select Nombre from Moneda where CodigoMoneda = @codigoMoneda)
	
	set @totalEnLetras = dbo.CantidadConLetra(@totalImporte, @nombreMoneda)

	if @codigoBoletaVenta is null
	begin
		select @codigoBoletaVenta = isnull(max(CodigoBoletaVenta), 0) + 1 from BoletaVenta
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into BoletaVenta
		(CodigoBoletaVenta, CodigoSerie, NroComprobante, FechaHoraEmision, FechaHoraVencimiento,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		CodigoGuiaRemision, CodigoCotizacion,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoBoletaVenta, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraVencimiento,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@codigoGuiaRemision, @codigoCotizacion,
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
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_guardar_emision]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_boletaventa_guardar_emision]
@codigoBoletaVenta int,
@hash varchar(max),
@codigoRptaSunat varchar(max),
@descripcionRptaSunat varchar(max),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	update BoletaVenta set
	[Hash] = @hash,
	CodigoRptaSunat = @codigoRptaSunat,
	DescripcionRptaSunat = @descripcionRptaSunat,
	FlagEmitido = @flagEmitido,
	FechaModi = getdate(),
	UsuarioModi = @usuarioModi
	where
	CodigoBoletaVenta = @codigoBoletaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_boletaventa_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
@codigoGuiaRemision int,
@codigoGuiaRemisionDetalle int,
@codigoCotizacion int,
@codigoCotizacionDetalle int,
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
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe,
		CodigoGuiaRemision, CodigoGuiaRemisionDetalle, CodigoCotizacion, CodigoCotizacionDetalle,
		FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoBoletaVenta, @codigoBoletaVentaDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 
		@codigoGuiaRemision, @codigoGuiaRemisionDetalle, @codigoCotizacion, @codigoCotizacionDetalle,
		0, @usuarioModi, getdate())
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
/****** Object:  StoredProcedure [dbo].[usp_boletaventadetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
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
	bvd.CodigoBoletaVenta = @codigoBoletaVenta and
	bvd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cliente_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_cliente_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_cliente_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_cliente_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_cliente_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompra_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantecompra_buscar]
@fechaCompraDesde date,
@fechaCompraHasta date,
@serie varchar(4),
@numero varchar(8),
@nroDocumentoIdentidadProveedor varchar(20),
@nombresProveedor varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by cc.CodigoComprobanteCompra desc) as int) [Fila],
	cc.CodigoComprobanteCompra,
	cc.FechaHoraRegistro,
	cc.FechaCompra,
	cc.CodigoTipoComprobante,
	tc.Nombre [NombreTipoComprobante],
	cc.CodigoComprobanteCompra,
	cc.Serie,
	cc.Numero,
	cc.CodigoProveedor,
	p.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadProveedor],
	tdip.Descripcion [DescripcionTipoDocumentoIdentidadProveedor],
	p.NroDocumentoIdentidad [NroDocumentoIdentidadProveedor],
	p.Nombres [NombresProveedor],
	p.FlagActivo [FlagActivoProveedor],
	cc.SerieGuia,
	cc.NumeroGuia,
	cc.TotalImporte,
	cc.FlagCompleto,
	cc.FlagActivo
	from
	ComprobanteCompra cc inner join
	TipoComprobante tc on cc.CodigoTipoComprobante = tc.CodigoTipoComprobante inner join
	Proveedor p on cc.CodigoProveedor = p.CodigoProveedor inner join
	TipoDocumentoIdentidad tdip on p.CodigoTipoDocumentoIdentidad = tdip.CodigoTipoDocumentoIdentidad
	where
	(cast(cc.FechaCompra as date) between @fechaCompraDesde and @fechaCompraHasta or (cast(cc.FechaCompra as date) >= @fechaCompraDesde and @fechaCompraDesde is not null and @fechaCompraHasta is null) or (cast(cc.FechaCompra as date) <= @fechaCompraHasta and @fechaCompraHasta is not null and @fechaCompraDesde is null) or (@fechaCompraDesde is null and @fechaCompraHasta is null)) and
	(cc.Serie like '%' + isnull(@serie, '') + '%') and
	(right('00000000' + rtrim(cc.Numero), 8) like '%' + isnull(@numero, '') + '%') and
	(p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadProveedor, '') + '%') and
	(p.Nombres like '%' + isnull(@nombresProveedor, '') + '%') and
	cc.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompra_cambiar_flaganulado]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_comprobantecompra_cambiar_flaganulado]
@codigoComprobantePago int,
@flagAnulado bit,
@usuarioModi varchar(20)
as
begin
	update ComprobantePago set
	FlagAnulado = @flagAnulado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoComprobantePago = @codigoComprobantePago
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompra_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantecompra_guardar]
@codigoComprobanteCompra int out,
@fechaHoraRegistro datetime,
@fechaCompra datetime,
@codigoTipoComprobante int,
@serie varchar(4),
@numero int,
@codigoProveedor int,
@serieGuia varchar(4),
@numeroGuia int,
@totalImporte decimal(18, 2),
@flagCompleto bit,
@usuarioModi varchar(20)
as
begin
	set @codigoComprobanteCompra = (select CodigoComprobanteCompra from ComprobanteCompra where CodigoComprobanteCompra = @codigoComprobanteCompra)

	if @codigoComprobanteCompra is null
	begin
		select @codigoComprobanteCompra = isnull(max(CodigoComprobanteCompra), 0) + 1 from ComprobanteCompra

		insert into ComprobanteCompra
		(CodigoComprobanteCompra, FechaHoraRegistro, FechaCompra, CodigoTipoComprobante, Serie, Numero,
		CodigoProveedor, SerieGuia, NumeroGuia, TotalImporte, FlagCompleto, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoComprobanteCompra, @fechaHoraRegistro, @fechaCompra, @codigoTipoComprobante, @serie, @numero,
		@codigoProveedor, @serieGuia, @numeroGuia, @totalImporte, @flagCompleto, 1, @usuarioModi, getdate())
	end
	else
	begin
		update ComprobanteCompra set
		FechaCompra = @fechaCompra,
		CodigoTipoComprobante = @codigoComprobanteCompra,
		Serie = @serie,
		Numero = @numero,
		CodigoProveedor = @codigoProveedor,
		SerieGuia = @serieGuia,
		NumeroGuia = @numeroGuia,
		TotalImporte = @totalImporte,
		FlagCompleto = @flagCompleto,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoComprobanteCompra = @codigoComprobanteCompra
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompra_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantecompra_obtener]
@codigoComprobanteCompra int
as
begin
	select
	cc.CodigoComprobanteCompra,
	cc.FechaHoraRegistro,
	cc.FechaCompra,
	cc.CodigoTipoComprobante,
	cc.Serie,
	cc.Numero,
	cc.CodigoProveedor,
	cc.SerieGuia,
	cc.NumeroGuia,
	cc.TotalImporte,
	cc.FlagCompleto,
	cc.FlagActivo
	from
	ComprobanteCompra cc
	where
	cc.CodigoComprobanteCompra = @codigoComprobanteCompra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompradetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_comprobantecompradetalle_eliminar]
@codigoComprobanteCompraDetalle int,
@usuarioModi varchar(20)
as
begin
	update ComprobanteCompraDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoComprobanteCompraDetalle = @codigoComprobanteCompraDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompradetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantecompradetalle_guardar]
@codigoComprobanteCompra int,
@codigoComprobanteCompraDetalle int out,
@codigoProducto int,
@detalle varchar(max),
@cantidad int,
@precioUnitario decimal(18, 2),
@importeTotal decimal(18, 2),
@flagCompleto bit,
@usuarioModi varchar(20)
as
begin
	set @codigoComprobanteCompraDetalle = (select CodigoComprobanteCompraDetalle from ComprobanteCompraDetalle where CodigoComprobanteCompraDetalle = @codigoComprobanteCompraDetalle)

	if @codigoComprobanteCompraDetalle is null
	begin
		select @codigoComprobanteCompraDetalle = isnull(max(CodigoComprobanteCompraDetalle), 0) + 1 from ComprobanteCompraDetalle

		insert into ComprobanteCompraDetalle
		(CodigoComprobanteCompra, CodigoComprobanteCompraDetalle, CodigoProducto,
		Detalle, Cantidad, PrecioUnitario, ImporteTotal, FlagCompleto, FlagEliminado,
		UsuarioGraba, FechaGraba)
		values
		(@codigoComprobanteCompra, @codigoComprobanteCompraDetalle, @codigoProducto,
		@detalle, @cantidad, @precioUnitario, @importeTotal, @flagCompleto, 0,
		@usuarioModi, getdate())
	end
	else
	begin
		update ComprobanteCompraDetalle set
		Detalle = @detalle,
		Cantidad = @cantidad,
		PrecioUnitario = @precioUnitario,
		ImporteTotal = @importeTotal,
		FlagCompleto = @flagCompleto,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoComprobanteCompraDetalle = @codigoComprobanteCompraDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantecompradetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantecompradetalle_listar]
@codigoComprobanteCompra int
as
begin
	select
	cast(row_number() over(order by ccd.CodigoComprobanteCompraDetalle desc) as int) [Fila],
	ccd.CodigoComprobanteCompra,
	ccd.CodigoComprobanteCompraDetalle,
	ccd.CodigoProducto,
	ccd.Detalle,
	ccd.Cantidad,
	ccd.PrecioUnitario,
	ccd.ImporteTotal,
	ccd.FlagCompleto,
	ccd.FlagEliminado
	from
	ComprobanteCompraDetalle ccd
	where
	ccd.CodigoComprobanteCompra = @codigoComprobanteCompra and
	ccd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepago_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantepago_buscar]
@fechaPagoDesde date,
@fechaPagoHasta date,
@codigoSerie int,
@nroComprobante varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagAnulado bit
as
begin
	select
	cast(row_number() over(order by cp.FechaHoraPago) as int) [Fila],
	cp.CodigoComprobantePago,
	cp.FechaHoraPago,
	cp.CodigoSerie,
	s.Serial [SerialSerie],
	cp.NroComprobante,
	cp.CodigoMoneda,
	cp.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	cp.Descripcion,
	cp.Monto,
	cp.FlagAnulado,
	cp.FlagEliminado
	from
	ComprobantePago cp inner join
	Serie s on cp.CodigoSerie = s.CodigoSerie inner join
	Cliente c on cp.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad
	where
	(
		(cast(cp.FechaHoraPago as date) between @fechaPagoDesde and @fechaPagoHasta and @fechaPagoDesde is not null and @fechaPagoHasta is not null) or
		(cast(cp.FechaHoraPago as date) <= @fechaPagoHasta and @fechaPagoDesde is null and @fechaPagoHasta is not null) or
		(cast(cp.FechaHoraPago as date) >= @fechaPagoDesde and @fechaPagoHasta is null and @fechaPagoDesde is not null) or
		(@fechaPagoDesde is null and @fechaPagoHasta is null)
	) and
	(cp.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(cp.NroComprobante), 8) like '%' + isnull(@nroComprobante, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	cp.FlagAnulado = @flagAnulado
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepago_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantepago_guardar]
@codigoComprobantePago int out,
@fechaHoraPago datetime,
@codigoSerie int,
@nroComprobante int out,
@codigoMoneda int,
@codigoCliente int,
@descripcion varchar(100),
@monto decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoComprobantePago = (select CodigoComprobantePago from ComprobantePago where CodigoComprobantePago = @codigoComprobantePago)

	if @codigoComprobantePago is null
	begin
		select @codigoComprobantePago = isnull(max(CodigoComprobantePago), 0) + 1 from ComprobantePago
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into ComprobantePago
		(CodigoComprobantePago, FechaHoraPago, CodigoSerie, NroComprobante, CodigoMoneda, CodigoCliente, Descripcion, Monto, FlagAnulado, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoComprobantePago, @fechaHoraPago, @codigoSerie, @nroComprobante, @codigoMoneda, @codigoCliente, @descripcion, @monto, 0, 0, @usuarioModi, getdate())
	end
	else
	begin
		update ComprobantePago set
		FechaHoraPago = @fechaHoraPago,
		CodigoMoneda = @codigoMoneda,
		CodigoCliente = @codigoCliente,
		Descripcion = @descripcion,
		Monto = @monto,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoComprobantePago = @codigoComprobantePago
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepago_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantepago_obtener]
@codigoComprobantePago int
as
begin
	select
	cp.CodigoComprobantePago,
	cp.CodigoSerie,
	cp.NroComprobante,
	cp.FechaHoraPago,
	cp.CodigoMoneda,
	cp.CodigoCliente,
	cp.Descripcion,
	cp.Monto,
	cp.FlagAnulado,
	cp.FlagEliminado
	from
	ComprobantePago cp
	where
	cp.CodigoComprobantePago = @codigoComprobantePago
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepagodetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_comprobantepagodetalle_eliminar]
@codigoComprobantePagoDetalle int,
@usuarioModi varchar(20)
as
begin
	update ComprobantePagoDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoComprobantePagoDetalle = @codigoComprobantePagoDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepagodetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_comprobantepagodetalle_guardar]
@codigoComprobantePago int,
@codigoComprobantePagoDetalle int out,
@codigoTipoDocumentoPago int,
@codigoDocumentoPago int,
@descripcion varchar(50),
@monto decimal(18, 2),
@mora decimal(18, 2),
@protesto decimal(18, 2),
@total decimal(18, 2),
@importePagar decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoComprobantePagoDetalle = (select CodigoComprobantePagoDetalle from ComprobantePagoDetalle where CodigoComprobantePagoDetalle = @codigoComprobantePagoDetalle)

	if @codigoComprobantePagoDetalle is null
	begin
		select @codigoComprobantePagoDetalle = isnull(max(CodigoComprobantePagoDetalle), 0) + 1 from ComprobantePagoDetalle

		insert into ComprobantePagoDetalle
		(CodigoComprobantePago, CodigoComprobantePagoDetalle, CodigoTipoDocumentoPago, CodigoDocumentoPago,
		Descripcion, Monto, Mora, Protesto, Total, ImportePagar, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoComprobantePago, @codigoComprobantePagoDetalle, @codigoTipoDocumentoPago, @codigoDocumentoPago,
		@descripcion, @monto, @mora, @protesto, @total, @importePagar, 0, @usuarioModi, getdate())
	end
	else
	begin
		update ComprobantePagoDetalle set
		CodigoTipoDocumentoPago = @codigoTipoDocumentoPago,
		CodigoDocumentoPago = @codigoDocumentoPago,
		Descripcion = @descripcion,
		Monto = @monto,
		Mora = @mora,
		Protesto = @protesto,
		Total = @total,
		ImportePagar = @importePagar,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoComprobantePagoDetalle = @codigoComprobantePagoDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_comprobantepagodetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_comprobantepagodetalle_listar]
@codigoComprobantePago int
as
begin
	declare @tbl as table (
		Fila int,
		CodigoComprobantePago int,
		CodigoComprobantePagoDetalle int,
		CodigoTipoDocumentoPago int,
		CodigoDocumentoPago int,
		Monto decimal(18, 2),
		Mora decimal(18, 2),
		Protesto decimal(18, 2),
		Total decimal(18, 2),
		FlagEliminado bit
	)

	insert into @tbl
	(Fila, CodigoComprobantePago, CodigoComprobantePagoDetalle, CodigoTipoDocumentoPago, CodigoDocumentoPago,
	Monto, Mora, Protesto, Total, FlagEliminado)
	select
	cast(row_number() over(order by cpd.CodigoComprobantePagoDetalle desc) as int) [Fila],
	cpd.CodigoComprobantePago,
	cpd.CodigoComprobantePagoDetalle,
	cpd.CodigoTipoDocumentoPago,
	cpd.CodigoDocumentoPago,
	cpd.Monto,
	cpd.Mora,
	cpd.Protesto,
	cpd.Total,
	cpd.FlagEliminado
	from
	ComprobantePagoDetalle cpd inner join
	TipoDocumentoPago tdp on cpd.CodigoTipoDocumentoPago = tdp.CodigoTipoDocumentoPago inner join
	FacturaVenta fv on cpd.CodigoComprobantePago = fv.CodigoFacturaVenta
	where
	cpd.CodigoTipoDocumentoPago = 1 and
	cpd.CodigoComprobantePago = @codigoComprobantePago and
	cpd.FlagEliminado = 0

	insert into @tbl
	(Fila, CodigoComprobantePago, CodigoComprobantePagoDetalle, CodigoTipoDocumentoPago, CodigoDocumentoPago,
	Monto, Mora, Protesto, Total, FlagEliminado)
	select
	cast(row_number() over(order by cpd.CodigoComprobantePagoDetalle desc) as int) [Fila],
	cpd.CodigoComprobantePago,
	cpd.CodigoComprobantePagoDetalle,
	cpd.CodigoTipoDocumentoPago,
	cpd.CodigoDocumentoPago,
	cpd.Monto,
	cpd.Mora,
	cpd.Protesto,
	cpd.Total,
	cpd.FlagEliminado
	from
	ComprobantePagoDetalle cpd inner join
	TipoDocumentoPago tdp on cpd.CodigoTipoDocumentoPago = tdp.CodigoTipoDocumentoPago inner join
	FacturaVenta fv on cpd.CodigoComprobantePago = fv.CodigoFacturaVenta
	where
	cpd.CodigoTipoDocumentoPago = 1 and
	cpd.CodigoComprobantePago = @codigoComprobantePago and
	cpd.FlagEliminado = 0

	select * from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[usp_configuracionvalor_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_configuracionvalor_guardar]
@codigoUsuario int,
@codigoTransportistaGuiaRemision int,
@codigoTipoComprobanteGuiaRemision int,
@rutaFacturacionElectronica varchar(max),
@rutaCertificado varchar(max),
@contraseñaCertificado varchar(max),
@usuarioSOL varchar(max),
@contraseñaSOL varchar(max)
as
begin
	if (select count(1) from ConfiguracionValor) = 0
	begin
		insert into ConfiguracionValor
		(CodigoUsuario, CodigoTransportistaGuiaRemision, CodigoTipoComprobanteGuiaRemision, RutaFacturacionElectronica, RutaCertificado, ContraseñaCertificado, UsuarioSOL, ContraseñaSOL)
		values
		(@codigoUsuario, @codigoTransportistaGuiaRemision, @codigoTipoComprobanteGuiaRemision, @rutaFacturacionElectronica, @rutaCertificado, @contraseñaCertificado, @usuarioSOL, @contraseñaSOL)
	end
	else
	begin
		update ConfiguracionValor set
		CodigoTransportistaGuiaRemision = @codigoTransportistaGuiaRemision,
		CodigoTipoComprobanteGuiaRemision = @codigoTipoComprobanteGuiaRemision,
		RutaFacturacionElectronica = @rutaFacturacionElectronica,
		RutaCertificado = @rutaCertificado,
		ContraseñaCertificado = @contraseñaCertificado,
		UsuarioSOL = @usuarioSOL,
		ContraseñaSOL = @contraseñaSOL
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_configuracionvalor_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_configuracionvalor_obtener]
as
begin
	select
	CodigoUsuario,
	CodigoTipoComprobanteGuiaRemision,
	CodigoTransportistaGuiaRemision,
	RutaFacturacionElectronica,
	RutaCertificado,
	ContraseñaCertificado,
	UsuarioSOL,
	ContraseñaSOL
	from
	ConfiguracionValor
end
GO
/****** Object:  StoredProcedure [dbo].[usp_controlbusqueda_obtener_x_formulariocontrol]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_controlbusqueda_obtener_x_formulariocontrol]
@formulario varchar(50),
@control varchar(50)
as
begin
	select
	CodigoControlBusqueda, Formulario, [Control], FromTables, WhereMain, TituloFormulario, TipoObjeto
	from
	ControlBusqueda cb
	where
	cb.Formulario = @formulario and
	cb.[Control] = @control
end
GO
/****** Object:  StoredProcedure [dbo].[usp_controlbusquedacolumna_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_controlbusquedacolumna_listar]
@codigoControlBusqueda int
as
begin
	select
	CodigoControlBusquedaColumna, CodigoControlBusqueda, CampoBD, NombreAtributo, Titulo, Formato, EsVisible, TipoColumna, EsFiltro, Ancho
	from
	ControlBusquedaColumna cbc
	where
	cbc.CodigoControlBusqueda = @codigoControlBusqueda
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizacion_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cotizacion_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by co.CodigoCotizacion desc) as int) [Fila],
	co.CodigoCotizacion,
	co.FechaHoraEmision,
	co.NroComprobante,
	co.NroPedido,
	co.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdic.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	co.CodigoVendedor,
	p.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadVendedor],
	tdip.Descripcion [DescripcionTipoDocumentoIdentidadVendedor],
	p.NroDocumentoIdentidad [NroDocumentoIdentidadVendedor],
	p.Nombres [NombresVendedor],
	p.FlagActivo [FlagActivoVendedor],
	co.CodigoSupervisor,
	s.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadSupervisor],
	tdis.Descripcion [DescripcionTipoDocumentoIdentidadSupervisor],
	s.NroDocumentoIdentidad [NroDocumentoIdentidadSupervisor],
	s.Nombres [NombresSupervisor],
	s.FlagActivo [FlagActivoSupervisor],
	co.CodigoMoneda,
	co.TotalImporte,
	co.FlagActivo
	from
	Cotizacion co inner join
	Cliente c on co.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdic on c.CodigoTipoDocumentoIdentidad = tdic.CodigoTipoDocumentoIdentidad inner join
	Personal p on co.CodigoVendedor = p.CodigoPersonal inner join
	TipoDocumentoIdentidad tdip on p.CodigoTipoDocumentoIdentidad = tdip.CodigoTipoDocumentoIdentidad left join
	Personal s on co.CodigoSupervisor = s.CodigoPersonal left join
	TipoDocumentoIdentidad tdis on s.CodigoTipoDocumentoIdentidad = tdis.CodigoTipoDocumentoIdentidad
	where
	(cast(co.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(co.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(co.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(right('00000000' + rtrim(co.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizacion_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cotizacion_guardar]
@codigoCotizacion int out,
@nroComprobante int out,
@fechaHoraEmision datetime,
@nroPedido varchar(50),
@codigoCliente int,
@codigoVendedor int,
@codigoSupervisor int,
@codigoMoneda int,
@totalImporte decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoCotizacion = (select CodigoCotizacion from Cotizacion where CodigoCotizacion = @codigoCotizacion)

	if @codigoCotizacion is null
	begin
		select @codigoCotizacion = isnull(max(CodigoCotizacion), 0) + 1 from Cotizacion
		select @nroComprobante = isnull(ValorActual, 0) + 1 from TipoDocumento where CodigoTipoDocumento = 2

		insert into Cotizacion
		(CodigoCotizacion, NroComprobante, FechaHoraEmision, NroPedido,
		CodigoCliente, CodigoVendedor, CodigoSupervisor, CodigoMoneda, TotalImporte, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoCotizacion, @nroComprobante, @fechaHoraEmision, @nroPedido,
		@codigoCliente, @codigoVendedor, @codigoSupervisor, @codigoMoneda, @totalImporte, 1,
		@usuarioModi, getdate())

		exec usp_tipodocumento_aumentarvaloractual 2, @usuarioModi
	end
	else
	begin
		update Cotizacion set
		FechaHoraEmision = @fechaHoraEmision,
		NroPedido = @nroPedido,
		CodigoCliente = @codigoCliente,
		CodigoVendedor = @codigoVendedor,
		CodigoSupervisor = @codigoSupervisor,
		CodigoMoneda = @codigoMoneda,
		TotalImporte = @totalImporte,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoCotizacion = @codigoCotizacion
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizacion_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cotizacion_obtener]
@codigoCotizacion int
as
begin
	select
	co.CodigoCotizacion,
	co.NroComprobante,
	co.FechaHoraEmision,
	co.NroPedido,
	co.CodigoCliente,
	co.CodigoVendedor,
	co.CodigoSupervisor,
	co.CodigoMoneda,
	co.TotalImporte,
	co.FlagActivo
	from
	Cotizacion co
	where
	co.CodigoCotizacion = @codigoCotizacion
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizaciondetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_cotizaciondetalle_eliminar]
@codigoCotizacionDetalle int,
@usuarioModi varchar(20)
as
begin
	update CotizacionDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoCotizacionDetalle = @codigoCotizacionDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizaciondetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cotizaciondetalle_guardar]
@codigoCotizacion int,
@codigoCotizacionDetalle int out,
@codigoProducto int,
@codigoProductoIndividual int,
@detalle varchar(max),
@codigoUnidadMedida int,
@cantidad decimal(18, 2),
@precioUnitario decimal(18, 2),
@importe decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoCotizacionDetalle = (select CodigoCotizacionDetalle from CotizacionDetalle where CodigoCotizacionDetalle = @codigoCotizacionDetalle)

	if @codigoCotizacionDetalle is null
	begin
		select @codigoCotizacionDetalle = isnull(max(CodigoCotizacionDetalle), 0) + 1 from CotizacionDetalle

		insert into CotizacionDetalle
		(CodigoCotizacion, CodigoCotizacionDetalle, CodigoProducto, CodigoProductoIndividual,
		Detalle, CodigoUnidadMedida, Cantidad, PrecioUnitario, Importe, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoCotizacion, @codigoCotizacionDetalle, @codigoProducto, @codigoProductoIndividual,
		@detalle, @codigoUnidadMedida, @cantidad, @precioUnitario, @importe, 0, @usuarioModi, getdate())
	end
	else
	begin
		update CotizacionDetalle set
		CodigoProducto = @codigoProducto,
		CodigoProductoIndividual = @codigoProductoIndividual,
		Detalle = @detalle,
		Cantidad = @cantidad,
		PrecioUnitario = @precioUnitario,
		Importe = @importe,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoCotizacionDetalle = @codigoCotizacionDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_cotizaciondetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_cotizaciondetalle_listar]
@codigoCotizacion int
as
begin
	select
	cast(row_number() over(order by cod.CodigoCotizacionDetalle desc) as int) [Fila],
	cod.CodigoCotizacion,
	cod.CodigoCotizacionDetalle,
	cod.CodigoProducto,
	p.Nombre [NombreProducto],
	cod.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	cod.Detalle,
	cod.CodigoUnidadMedida,
	cod.Cantidad,
	cod.PrecioUnitario,
	cod.Importe,
	cod.FlagEliminado
	from
	CotizacionDetalle cod inner join
	Producto p on cod.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on cod.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	cod.CodigoCotizacion = @codigoCotizacion and
	cod.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_departamento_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_distrito_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
	fv.CodigoGuiaRemision,
	gr.CodigoTipoComprobante [CodigoTipoComprobanteGuiaRemision],
	tc.Nombre [NombreTipoComprobanteGuiaRemision],
	gr.CodigoSerie [CodigoSerieGuiaRemision],
	sgr.Serial [SerialSerieGuiaRemision],
	gr.NroComprobante [NroComprobanteGuiaRemision],
	gr.FechaHoraEmision [FechaHoraEmisionGuiaRemision],
	fv.CodigoCotizacion,
	co.NroComprobante [NroComprobanteCotizacion],
	co.NroPedido [NroPedidoCotizacion],
	co.FechaHoraEmision [FechaHoraEmisionCotizacion],
	fv.FlagEmitido,
	fv.FlagActivo
	from
	FacturaVenta fv inner join
	Serie s on fv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on fv.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad left join
	GuiaRemision gr on fv.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
	TipoComprobante tc on gr.CodigoTipoComprobante = tc.CodigoTipoComprobante left join
	Serie sgr on gr.CodigoSerie = sgr.CodigoSerie left join
	Cotizacion co on fv.CodigoCotizacion = co.CodigoCotizacion
	where
	(cast(fv.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(fv.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(fv.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(fv.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(fv.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	fv.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_cambiar_flagcancelado]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_facturaventa_cambiar_flagcancelado]
@codigoFacturaVenta int,
@flagCancelado bit,
@usuarioModi varchar(20)
as
begin
	update FacturaVenta set
	FlagCancelado = @flagCancelado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoFacturaVenta = @codigoFacturaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
@totalEnLetras nvarchar(max) out,
@codigoGuiaRemision int,
@codigoCotizacion int,
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoFacturaVenta = (select CodigoFacturaVenta from FacturaVenta where CodigoFacturaVenta = @codigoFacturaVenta)

	declare @nombreMoneda varchar(max) = (select Nombre from Moneda where CodigoMoneda = @codigoMoneda)
	
	set @totalEnLetras = dbo.CantidadConLetra(@totalImporte, @nombreMoneda)
	
	if @codigoFacturaVenta is null
	begin
		select @codigoFacturaVenta = isnull(max(CodigoFacturaVenta), 0) + 1 from FacturaVenta
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into FacturaVenta
		(CodigoFacturaVenta, CodigoSerie, NroComprobante, FechaHoraEmision, FechaHoraVencimiento,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		CodigoMetodoPago, CantidadLetrasCredito, CodigoGuiaRemision, CodigoCotizacion,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoFacturaVenta, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraVencimiento,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@codigoMetodoPago, @cantidadLetrasCredito, @codigoGuiaRemision, @codigoCotizacion,
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
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_guardar_emision]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_facturaventa_guardar_emision]
@codigoFacturaVenta int,
@hash varchar(max),
@codigoRptaSunat varchar(max),
@descripcionRptaSunat varchar(max),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	update FacturaVenta set
	[Hash] = @hash,
	CodigoRptaSunat = @codigoRptaSunat,
	DescripcionRptaSunat = @descripcionRptaSunat,
	FlagEmitido = @flagEmitido,
	FechaModi = getdate(),
	UsuarioModi = @usuarioModi
	where
	CodigoFacturaVenta = @codigoFacturaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_facturaventa_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
@codigoGuiaRemision int,
@codigoGuiaRemisionDetalle int,
@codigoCotizacion int,
@codigoCotizacionDetalle int,
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
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe,
		CodigoGuiaRemision, CodigoGuiaRemisionDetalle, CodigoCotizacion, CodigoCotizacionDetalle,
		FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoFacturaVenta, @codigoFacturaVentaDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 
		@codigoGuiaRemision, @codigoGuiaRemisionDetalle, @codigoCotizacion, @codigoCotizacionDetalle,
		0, @usuarioModi, getdate())
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
/****** Object:  StoredProcedure [dbo].[usp_facturaventadetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
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
	fvd.CodigoFacturaVenta = @codigoFacturaVenta and
	fvd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_boletaventa]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_formato_boletaventa]
@codigoBoletaVenta int
as
begin
	select
	s.Serial [Serie],
	bv.NroComprobante [Correlativo],
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	c.Nombres [NombresCompletoCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Direccion [DireccionCliente],
	null [CondicionPago],
	c.Telefono [TelefonoCliente],
	'Veh. Marca y Placa: ' + gr.MarcaVehiculoTransportista + ' N°: ' + gr.PlacaVehiculoTransportista [AgenciaTransporte],
	bv.FechaHoraEmision [FechaEmision],
	bv.FechaHoraVencimiento [FechaVencimiento],
	tc.ValorVenta [TipoCambio],
	co.NroPedido [NroPedido],
	right('00000000' + cast(gr.NroComprobante as varchar(max)), 8) [NroGuia],
	null [OrdenCompra],
	bv.TotalOperacionGravada [TotalGravada],
	bv.TotalIgv [TotalIGV],
	bv.TotalPagar,
	bv.TotalImporte,
	dbo.CantidadConLetra(bv.TotalImporte, m.Nombre) TotalEnLetras,
	bv.[Hash]
	from
	BoletaVenta bv inner join
	Moneda m on bv.CodigoMoneda = m.CodigoMoneda inner join
	Serie s on bv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on bv.CodigoCliente = c.CodigoCliente left join
	TipoCambio tc on cast(bv.FechaHoraEmision as date) = tc.FechaCambio left join
	GuiaRemision gr on bv.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
	Cotizacion co on bv.CodigoCotizacion = co.CodigoCotizacion
	where
	bv.CodigoBoletaVenta = @codigoBoletaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_boletaventadetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_formato_boletaventadetalle]
@codigoBoletaVenta int
as
begin
	select
	[pi].CodigoBarra [Codigo],
	bvd.Detalle [Articulo],
	bvd.Cantidad,
	bvd.PrecioUnitario [Precio],
	bvd.Importe
	from BoletaVentaDetalle bvd inner join
	ProductoIndividual [pi] on bvd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	bvd.CodigoBoletaVenta = @codigoBoletaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_facturaventa]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_formato_facturaventa]
@codigoFacturaVenta int
as
begin
	select
	s.Serial [Serie],
	fv.NroComprobante [Correlativo],
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	c.Nombres [NombresCompletoCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Direccion [DireccionCliente],
	case 
	when fv.CodigoMetodoPago = 2 then 'L/' + cast(fv.CantidadLetrasCredito as varchar(max))
	else null
	end [CondicionPago],
	c.Telefono [TelefonoCliente],
	'Veh. Marca y Placa: ' + gr.MarcaVehiculoTransportista + ' N°: ' + gr.PlacaVehiculoTransportista [AgenciaTransporte],
	fv.FechaHoraEmision [FechaEmision],
	fv.FechaHoraVencimiento [FechaVencimiento],
	tc.ValorVenta [TipoCambio],
	co.NroPedido [NroPedido],
	--sgr.Serial + '-'+ right('00000000' + cast(gr.NroComprobante as varchar(max)), 8) [NroGuia],
	right('00000000' + cast(gr.NroComprobante as varchar(max)), 8) [NroGuia],
	null [OrdenCompra],
	fv.TotalOperacionGravada [TotalGravada],
	fv.TotalIgv [TotalIGV],
	fv.TotalPagar,
	fv.TotalImporte,
	dbo.CantidadConLetra(fv.TotalImporte, m.Nombre) TotalEnLetras,
	fv.[Hash]
	from
	FacturaVenta fv inner join
	Moneda m on fv.CodigoMoneda = m.CodigoMoneda inner join
	Serie s on fv.CodigoSerie = s.CodigoSerie inner join
	Cliente c on fv.CodigoCliente = c.CodigoCliente left join
	TipoCambio tc on cast(fv.FechaHoraEmision as date) = tc.FechaCambio left join
	GuiaRemision gr on fv.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
	--Serie sgr on gr.CodigoSerie = sgr.CodigoSerie left join
	Cotizacion co on fv.CodigoCotizacion = co.CodigoCotizacion
	where
	fv.CodigoFacturaVenta = @codigoFacturaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_facturaventadetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_formato_facturaventadetalle]
@codigoFacturaVenta int
as
begin
	select
	[pi].CodigoBarra [Codigo],
	fvd.Detalle [Articulo],
	fvd.Cantidad,
	fvd.PrecioUnitario [Precio],
	fvd.Importe
	from FacturaVentaDetalle fvd inner join
	ProductoIndividual [pi] on fvd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	fvd.CodigoFacturaVenta = @codigoFacturaVenta
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_letra_masivo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_formato_letra_masivo]
@codigosLetra varchar(max)
as
begin
	select
	l.Numero [Numero],
	fv.FechaHoraEmision [FechaGiro],
	fv.NombreProvinciaCliente [LugarGiro],
	l.FechaVencimiento [FechaVencimiento],
	l.CodigoMoneda [CodigoMoneda],
	l.Monto [Importe],
	dbo.CantidadConLetra(l.Monto, m.Nombre) [ImporteEnLetras],
	c.NroDocumentoIdentidad [RucCliente],
	c.Nombres [NombresCliente],
	c.Direccion [DireccionCliente],
	--fv.NombreDistritoCliente [NombreDistritoCliente],
	fv.NombreProvinciaCliente [LocalidadCliente],
	c.Telefono [TelefonoCliente],
	a.NroDocumentoIdentidad [NroDocIdentidadAval],
	a.Nombres [NombresAval],
	a.Direccion [DireccionAval],
	l.NombreProvinciaAval [LocalidadAval],
	a.Telefono [TelefonoAval]
	from
	Letra l inner join
	FacturaVenta fv on l.CodigoTipoComprobanteRef = 2 and l.CodigoComprobanteRef = fv.CodigoFacturaVenta inner join
	Cliente c on l.CodigoCliente = c.CodigoCliente inner join
	Moneda m on l.CodigoMoneda = m.CodigoMoneda left join
	Cliente a on l.CodigoAval = a.CodigoCliente
	where l.CodigoLetra in (select [value] from string_split(@codigosLetra, ','))
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_notacredito]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_formato_notacredito]
@codigoNotaCredito int
as
begin
	declare @tbl as table (
		Serie varchar(4),
		Correlativo int,
		FechaEmision datetime,
		CodigoTipoDocumentoIdentidadCliente int,
		NroDocumentoIdentidadCliente varchar(20),
		NombresCompletoCliente varchar(max),
		DireccionCliente varchar(max),
		CodigoTipoComprobanteRef int,
		TipoComprobanteRef varchar(50),
		CodigoComprobanteRef int,
		SerieRef varchar(4),
		CorrelativoRef int,
		FechaEmisionRef datetime,
		NombreMoneda varchar(50),
		SimboloMoneda varchar(10),
		Motivo varchar(max),
		TotalGravada decimal(18, 6),
		TotalIgv decimal(18, 6),
		TotalPagar decimal(18, 6),
		TotalImporte decimal(18, 6),
		TotalEnLetras varchar(max),
		[Hash] varchar(max)
	)

	insert into @tbl
	(Serie, Correlativo, FechaEmision,
	CodigoTipoDocumentoIdentidadCliente, NroDocumentoIdentidadCliente, NombresCompletoCliente, DireccionCliente,
	CodigoTipoComprobanteRef, TipoComprobanteRef, CodigoComprobanteRef, NombreMoneda, SimboloMoneda, Motivo,
	TotalGravada, TotalIgv, TotalPagar, TotalImporte, TotalEnLetras, [Hash]
	)
	select
	s.Serial [Serie],
	nc.NroComprobante [Correlativo],
	nc.FechaHoraEmision [FechaEmision],
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCompletoCliente],
	c.Direccion [DireccionCliente],
	nc.CodigoTipoComprobanteRef,
	tc.Nombre [TipoComprobanteRef],
	nc.CodigoComprobanteRef,
	m.Nombre [NombreMoneda],
	m.Simbolo [SimboloMoneda],
	mn.Descripcion [Motivo],
	nc.TotalOperacionGravada [TotalGravada],
	nc.TotalIgv [TotalIGV],
	nc.TotalPagar,
	nc.TotalImporte,
	dbo.CantidadConLetra(nc.TotalImporte, m.Nombre) TotalEnLetras,
	nc.[Hash]
	from
	NotaCredito nc inner join
	Moneda m on nc.CodigoMoneda = m.CodigoMoneda inner join
	Serie s on nc.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nc.CodigoCliente = c.CodigoCliente inner join
	TipoComprobante tc on nc.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	MotivoNota mn on nc.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nc.CodigoNotaCredito = @codigoNotaCredito

	declare @cantidad int = (select count(1) from @tbl)

	if @cantidad > 0
	begin
		declare @codigoTipoComprobanteRef int = (select CodigoTipoComprobanteRef from @tbl)
		declare @codigoComprobanteRef int = (select CodigoComprobanteRef from @tbl)

		declare @serieRef varchar(4), @correlativoRef int, @fechaEmisionRef datetime
		if @codigoTipoComprobanteRef = 1
		begin
			select
			@serieRef = s.Serial,
			@correlativoRef = bv.NroComprobante,
			@fechaEmisionRef = bv.FechaHoraEmision
			from
			BoletaVenta bv inner join
			Serie s on bv.CodigoSerie = s.CodigoSerie
			where
			bv.CodigoBoletaVenta = @codigoComprobanteRef

			update @tbl set
			SerieRef = @serieRef,
			CorrelativoRef = @correlativoRef,
			FechaEmisionRef = @fechaEmisionRef
		end
		else if @codigoTipoComprobanteRef = 2
		begin
			select
			@serieRef = s.Serial,
			@correlativoRef = fv.NroComprobante,
			@fechaEmisionRef = fv.FechaHoraEmision
			from
			FacturaVenta fv inner join
			Serie s on fv.CodigoSerie = s.CodigoSerie
			where
			fv.CodigoFacturaVenta = @codigoComprobanteRef

			update @tbl set
			SerieRef = @serieRef,
			CorrelativoRef = @correlativoRef,
			FechaEmisionRef = @fechaEmisionRef
		end
	end

	select * from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_notacreditodetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_formato_notacreditodetalle]
@codigoNotaCredito int
as
begin
	select
	[pi].CodigoBarra [Codigo],
	ncd.Detalle [Articulo],
	ncd.Cantidad,
	ncd.PrecioUnitario [Precio],
	ncd.Importe
	from NotaCreditoDetalle ncd inner join
	ProductoIndividual [pi] on ncd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	ncd.CodigoNotaCredito = @codigoNotaCredito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_notadebito]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_formato_notadebito]
@codigoNotaDebito int
as
begin
	declare @tbl as table (
		Serie varchar(4),
		Correlativo int,
		FechaEmision datetime,
		CodigoTipoDocumentoIdentidadCliente int,
		NroDocumentoIdentidadCliente varchar(20),
		NombresCompletoCliente varchar(max),
		DireccionCliente varchar(max),
		CodigoTipoComprobanteRef int,
		TipoComprobanteRef varchar(50),
		CodigoComprobanteRef int,
		SerieRef varchar(4),
		CorrelativoRef int,
		FechaEmisionRef datetime,
		NombreMoneda varchar(50),
		SimboloMoneda varchar(10),
		Motivo varchar(max),
		TotalGravada decimal(18, 6),
		TotalIgv decimal(18, 6),
		TotalPagar decimal(18, 6),
		TotalImporte decimal(18, 6),
		TotalEnLetras varchar(max),
		[Hash] varchar(max)
	)

	insert into @tbl
	(Serie, Correlativo, FechaEmision,
	CodigoTipoDocumentoIdentidadCliente, NroDocumentoIdentidadCliente, NombresCompletoCliente, DireccionCliente,
	CodigoTipoComprobanteRef, TipoComprobanteRef, CodigoComprobanteRef, NombreMoneda, SimboloMoneda, Motivo,
	TotalGravada, TotalIgv, TotalPagar, TotalImporte, TotalEnLetras, [Hash]
	)
	select
	s.Serial [Serie],
	nd.NroComprobante [Correlativo],
	nd.FechaHoraEmision [FechaEmision],
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCompletoCliente],
	c.Direccion [DireccionCliente],
	nd.CodigoTipoComprobanteRef,
	tc.Nombre [TipoComprobanteRef],
	nd.CodigoComprobanteRef,
	m.Nombre [NombreMoneda],
	m.Simbolo [SimboloMoneda],
	mn.Descripcion [Motivo],
	nd.TotalOperacionGravada [TotalGravada],
	nd.TotalIgv [TotalIGV],
	nd.TotalPagar,
	nd.TotalImporte,
	dbo.CantidadConLetra(nd.TotalImporte, m.Nombre) TotalEnLetras,
	nd.[Hash]
	from
	NotaDebito nd inner join
	Moneda m on nd.CodigoMoneda = m.CodigoMoneda inner join
	Serie s on nd.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nd.CodigoCliente = c.CodigoCliente inner join
	TipoComprobante tc on nd.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	MotivoNota mn on nd.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nd.CodigoNotaDebito = @codigoNotaDebito

	declare @cantidad int = (select count(1) from @tbl)

	if @cantidad > 0
	begin
		declare @codigoTipoComprobanteRef int = (select CodigoTipoComprobanteRef from @tbl)
		declare @codigoComprobanteRef int = (select CodigoComprobanteRef from @tbl)

		declare @serieRef varchar(4), @correlativoRef int, @fechaEmisionRef datetime
		if @codigoTipoComprobanteRef = 1
		begin
			select
			@serieRef = s.Serial,
			@correlativoRef = bv.NroComprobante,
			@fechaEmisionRef = bv.FechaHoraEmision
			from
			BoletaVenta bv inner join
			Serie s on bv.CodigoSerie = s.CodigoSerie
			where
			bv.CodigoBoletaVenta = @codigoComprobanteRef

			update @tbl set
			SerieRef = @serieRef,
			CorrelativoRef = @correlativoRef,
			FechaEmisionRef = @fechaEmisionRef
		end
		else if @codigoTipoComprobanteRef = 2
		begin
			select
			@serieRef = s.Serial,
			@correlativoRef = fv.NroComprobante,
			@fechaEmisionRef = fv.FechaHoraEmision
			from
			FacturaVenta fv inner join
			Serie s on fv.CodigoSerie = s.CodigoSerie
			where
			fv.CodigoFacturaVenta = @codigoComprobanteRef

			update @tbl set
			SerieRef = @serieRef,
			CorrelativoRef = @correlativoRef,
			FechaEmisionRef = @fechaEmisionRef
		end
	end

	select * from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[usp_formato_notadebitodetalle]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_formato_notadebitodetalle]
@codigoNotaDebito int
as
begin
	select
	[pi].CodigoBarra [Codigo],
	ndd.Detalle [Articulo],
	ndd.Cantidad,
	ndd.PrecioUnitario [Precio],
	ndd.Importe
	from NotaDebitoDetalle ndd inner join
	ProductoIndividual [pi] on ndd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	ndd.CodigoNotaDebito = @codigoNotaDebito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
	gr.CodigoCotizacion,
	co.NroComprobante [NroComprobanteCotizacion],
	co.NroPedido [NroPedidoCotizacion],
	co.FechaHoraEmision [FechaHoraEmisionCotizacion],
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
	TipoDocumentoIdentidad tdip on p.CodigoTipoDocumentoIdentidad = tdip.CodigoTipoDocumentoIdentidad left join
	Cotizacion co on gr.CodigoCotizacion = co.CodigoCotizacion
	where
	(cast(gr.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(gr.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(gr.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(gr.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(gr.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_guiaremision_guardar]
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
@codigoCotizacion int,
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
		CodigoCotizacion,
		FlagEmitido, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoGuiaRemision, @codigoTipoComprobante, @codigoSerie, @nroComprobante, @fechaHoraEmision, @fechaHoraTraslado,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMotivoTraslado,
		@codigoTransportista, @direccionTransportista, @nombrePaisTransportista, @nombreDepartamentoTransportista,
		@nombreProvinciaTransportista, @codigoDistritoTransportista, @nombreDistritoTransportista,
		@marcaVehiculoTransportista, @placaVehiculoTransportista, @licenciaConducirTransportista,
		@codigoCotizacion,
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
/****** Object:  StoredProcedure [dbo].[usp_guiaremision_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_guiaremision_obtener]
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
	gr.CodigoCotizacion,
	gr.FlagEmitido,
	gr.FlagActivo
	from
	GuiaRemision gr
	where
	gr.CodigoGuiaRemision = @codigoGuiaRemision
end
GO
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_guiaremisiondetalle_guardar]
@codigoGuiaRemision int,
@codigoGuiaRemisionDetalle int out,
@codigoProducto int,
@codigoProductoIndividual int,
@codigoUnidadMedida int,
@detalle varchar(max),
@cantidad decimal(18, 2),
@codigoUnidadMedidaPeso int,
@peso decimal(18, 2),
@codigoCotizacion int,
@codigoCotizacionDetalle int,
@usuarioModi varchar(20)
as
begin
	set @codigoGuiaRemisionDetalle = (select CodigoGuiaRemisionDetalle from GuiaRemisionDetalle where CodigoGuiaRemisionDetalle = @codigoGuiaRemisionDetalle)

	if @codigoGuiaRemisionDetalle is null
	begin
		select @codigoGuiaRemisionDetalle = isnull(max(CodigoGuiaRemisionDetalle), 0) + 1 from GuiaRemisionDetalle

		insert into GuiaRemisionDetalle
		(CodigoGuiaRemision, CodigoGuiaRemisionDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, CodigoUnidadMedidaPeso, Peso,
		CodigoCotizacion, CodigoCotizacionDetalle,
		FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoGuiaRemision, @codigoGuiaRemisionDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @codigoUnidadMedidaPeso, @peso,
		@codigoCotizacion, @codigoCotizacionDetalle,
		0, @usuarioModi, getdate())
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
/****** Object:  StoredProcedure [dbo].[usp_guiaremisiondetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_guiaremisiondetalle_listar]
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
	grd.CodigoCotizacion,
	grd.CodigoCotizacionDetalle,
	grd.FlagEliminado
	from
	GuiaRemisionDetalle grd inner join
	Producto p on grd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on grd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	grd.CodigoGuiaRemision = @codigoGuiaRemision and
	grd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_asignarbanco]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_asignarbanco]
@codigoLetra int,
@codigoBanco int,
@codigoUnicoBanco varchar(50),
@usuarioModi varchar(20)
as
begin
	update Letra set
	CodigoBanco = @codigoBanco,
	CodigoUnicoBanco = @codigoUnicoBanco,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_asignarmora]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_asignarmora]
@codigoLetra int,
@mora decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	update Letra set
	Mora = @mora,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_asignarobservacion]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_asignarobservacion]
@codigoLetra int,
@observacion varchar(max),
@usuarioModi varchar(20)
as
begin
	update Letra set
	Observacion = @observacion,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_asignarprotesto]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_asignarprotesto]
@codigoLetra int,
@protesto decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	update Letra set
	Protesto = @protesto,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@estado int,
@flagCancelado bit,
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by l.CodigoLetra desc) as int) [Fila],
	l.CodigoLetra,
	l.Numero,
	l.FechaHoraEmision,
	l.FechaVencimiento,
	l.Dias,
	l.CodigoTipoComprobanteRef,
	t.Nombre [NombreTipoComprobanteRef],
	l.CodigoComprobanteRef,
	fv.CodigoSerie [CodigoSerieComprobanteRef],
	sfv.Serial [SerialSerieComprobanteRef],
	fv.NroComprobante [NroComprobanteComprobanteRef],
	l.CodigoGuiaRemision,
	gr.CodigoSerie [CodigoSerieGuiaRemision],
	sgr.Serial [SerialSerieGuiaRemision],
	gr.NroComprobante [NroComprobanteGuiaRemision],
	l.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdic.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	l.CodigoUnicoBanco,
	l.CodigoBanco,
	b.Nombre [NombreBanco],
	l.CodigoMoneda,
	l.Monto,
	l.Mora,
	l.Protesto,
	l.Estado,
	l.CodigoLetraPadre,
	lp.Numero [NumeroLetraPadre],
	lp.Monto [MontoLetraPadre],
	lp.Mora [MoraLetraPadre],
	lp.Protesto [ProtestoLetraPadre],
	l.CodigoLetraInicial,
	li.Numero [NumeroLetraInicial],
	li.Monto [MontoLetraInicial],
	li.Mora [MoraLetraInicial],
	li.Protesto [ProtestoLetraInicial],
	l.FlagCancelado,
	l.FlagActivo
	from
	Letra l inner join
	TipoComprobante t on l.CodigoTipoComprobanteRef = t.CodigoTipoComprobante inner join
	Cliente c on l.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdic on c.CodigoTipoDocumentoIdentidad = tdic.CodigoTipoDocumentoIdentidad inner join
	FacturaVenta fv on l.CodigoComprobanteRef = fv.CodigoFacturaVenta inner join
	Serie sfv on fv.CodigoSerie = sfv.CodigoSerie left join
	GuiaRemision gr on l.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
	Serie sgr on gr.CodigoSerie = sgr.CodigoSerie left join
	Banco b on l.CodigoBanco = b.CodigoBanco left join
	Letra li on l.CodigoLetraInicial = li.CodigoLetra left join
	Letra lp on l.CodigoLetraPadre = lp.CodigoLetra
	where
	(cast(l.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(l.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(l.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(
		(right('00000000' + rtrim(l.Numero), 8) like '%' + isnull(@numero, '') + '%') or
		(isnull(right('00000000' + rtrim(li.Numero), 8), 0) like '%' + isnull(@numero, '') + '%')
	) and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	(l.Estado = @estado or @estado is null) and
	l.FlagCancelado = @flagCancelado and
	l.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_cambiar_estado]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_cambiar_estado]
@codigoLetra int,
@estado int,
@usuarioModi varchar(20)
as
begin
	update Letra set
	Estado = @estado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_cambiar_flagcancelado]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_cambiar_flagcancelado]
@codigoLetra int,
@flagCancelado bit,
@usuarioModi varchar(20)
as
begin
	update Letra set
	FlagCancelado = @flagCancelado,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_eliminar_x_ref]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_eliminar_x_ref]
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int,
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
	CodigoComprobanteRef = @codigoComprobanteRef
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_existe_codigounicobanco]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_existe_codigounicobanco]
@codigoBanco int,
@codigoUnicoBanco varchar(50),
@codigoLetra int
as
begin
	select cast(count(1) as bit) from Letra where CodigoBanco = @codigoBanco and CodigoUnicoBanco = @codigoUnicoBanco and CodigoLetra != @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
@codigoComprobanteRef int,
@codigoGuiaRemision int,
@codigoCliente int,
@codigoBanco int,
@codigoUnicoBanco varchar(50),
@codigoMoneda int,
@monto decimal(18, 2),
@mora decimal(18, 2),
@protesto decimal(18, 2),
@estado varchar(50),
@codigoLetraPadre int,
@codigoLetraInicial int,
@flagAval bit,
@codigoAval int,
@direccionAval varchar(100),
@nombrePaisAval varchar(50),
@nombreDepartamentoAval varchar(50),
@nombreProvinciaAval varchar(50),
@nombreDistritoAval varchar(50),
@codigoDistritoAval int,
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
		CodigoTipoComprobanteRef, CodigoComprobanteRef, CodigoGuiaRemision,
		CodigoCliente, CodigoBanco, CodigoUnicoBanco, CodigoMoneda, 
		Monto, Mora, Protesto, Estado, CodigoLetraPadre, CodigoLetraInicial,
		FlagAval, CodigoAval, DireccionAval, NombrePaisAval, NombreDepartamentoAval,
		NombreProvinciaAval, CodigoDistritoAval, NombreDistritoAval, FlagCancelado,
		FlagActivo, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoLetra, @numero, @fechaHoraEmision, @fechaVencimiento, @dias,
		@codigoTipoComprobanteRef, @codigoComprobanteRef, @codigoGuiaRemision,
		@codigoCliente, @codigoBanco, @codigoUnicoBanco, @codigoMoneda,
		@monto, @mora, @protesto, @estado, @codigoLetraPadre, @codigoLetraInicial,
		@flagAval, @codigoAval, @direccionAval, @nombrePaisAval, @nombreDepartamentoAval,
		@nombreProvinciaAval, @codigoDistritoAval, @nombreDistritoAval, @flagCancelado,
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
		CodigoComprobanteRef = @codigoComprobanteRef,
		CodigoGuiaRemision = @codigoGuiaRemision,
		CodigoCliente = @codigoCliente,
		CodigoBanco = @codigoBanco,
		CodigoUnicoBanco = @codigoUnicoBanco,
		CodigoMoneda = @codigoMoneda,
		Monto = @monto,
		Estado = @estado,
		CodigoLetraPadre = @codigoLetraPadre,
		CodigoLetraInicial = @codigoLetraInicial,
		FlagAval = @flagAval,
		CodigoAval = @codigoAval,
		DireccionAval = @direccionAval,
		NombrePaisAval = @nombrePaisAval,
		NombreDepartamentoAval = @nombreDepartamentoAval,
		NombreProvinciaAval = @nombreProvinciaAval,
		CodigoDistritoAval = @codigoDistritoAval,
		NombreDistritoAval = @nombreDistritoAval,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where CodigoLetra = @codigoLetra
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_listar_x_codigoletrainicial]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_letra_listar_x_codigoletrainicial]
@codigoLetraInicial int
as
begin
	select
	l.CodigoLetra,
	l.Numero,
	l.FechaHoraEmision,
	l.FechaVencimiento,
	l.Dias,
	l.CodigoTipoComprobanteRef,
	l.CodigoComprobanteRef,
	l.CodigoGuiaRemision,
	l.CodigoCliente,
	l.CodigoBanco,
	l.CodigoUnicoBanco,
	l.CodigoMoneda,
	l.Monto,
	l.Mora,
	l.Protesto,
	l.Estado,
	l.CodigoLetraPadre,
	l.CodigoLetraInicial,
	l.FlagAval,
	l.DireccionAval,
	l.NombrePaisAval,
	l.NombreDepartamentoAval,
	l.NombreProvinciaAval,
	l.NombreDistritoAval,
	l.FlagCancelado,
	l.FlagActivo
	from
	Letra l
	where
	l.CodigoLetra = @codigoLetraInicial or l.CodigoLetraInicial = @codigoLetraInicial
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_listar_x_ref]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_listar_x_ref]
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int
as
begin
	declare @letra table (
	Fila int,
	CodigoLetra int,
	Numero int,
	FechaHoraEmision datetime,
	FechaVencimiento date,
	Dias int,
	CodigoTipoComprobanteRef int,
	CodigoSerieComprobanteRef int,
	SerialSerieComprobanteRef int,
	NroComprobanteComprobanteRef int,
	CodigoSerieGuiaRemision int,
	SerialSerieGuiaRemision int,
	NroComprobanteGuiaRemision int,
	CodigoCliente int,
	CodigoBanco int,
	CodigoUnicoBanco int,
	CodigoMoneda int,
	Monto decimal(18, 2),
	Estado int,
	FlagCancelado bit)

	if @codigoTipoComprobanteRef = 1
	begin
		insert into @letra
		select
		cast(row_number() over(order by CodigoLetra) as int) [Fila],
		l.CodigoLetra,
		l.Numero,
		l.FechaHoraEmision,
		l.FechaVencimiento,
		l.Dias,
		l.CodigoTipoComprobanteRef,
		b.CodigoSerie [CodigoSerieComprobanteRef],
		sb.Serial [SerialSerieComprobanteRef],
		b.NroComprobante [NroComprobanteComprobanteRef],
		gr.CodigoSerie [CodigoSerieGuiaRemision],
		sgr.Serial [SerialSerieGuiaRemision],
		gr.NroComprobante [NroComprobanteGuiaRemision],
		l.CodigoCliente,
		l.CodigoBanco,
		l.CodigoUnicoBanco,
		l.CodigoMoneda,
		l.Monto,
		l.Estado,
		l.FlagCancelado
		from
		Letra l inner join
		BoletaVenta b on l.CodigoComprobanteRef	 = b.CodigoBoletaVenta inner join
		Serie sb on b.CodigoSerie = sb.CodigoSerie left join
		GuiaRemision gr on l.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
		Serie sgr on gr.CodigoSerie = sgr.CodigoSerie
		where
		l.CodigoTipoComprobanteRef = @codigoTipoComprobanteRef and
		l.CodigoComprobanteRef = @codigoComprobanteRef and
		l.FlagEliminado = 0
	end
	
	if @codigoTipoComprobanteRef = 2
	begin
		insert into @letra
		select
		cast(row_number() over(order by CodigoLetra) as int) [Fila],
		l.CodigoLetra,
		l.Numero,
		l.FechaHoraEmision,
		l.FechaVencimiento,
		l.Dias,
		l.CodigoTipoComprobanteRef,
		f.CodigoSerie [CodigoSerieComprobanteRef],
		sf.Serial [SerialSerieComprobanteRef],
		f.NroComprobante [NroComprobanteComprobanteRef],
		gr.CodigoSerie [CodigoSerieGuiaRemision],
		sgr.Serial [SerialSerieGuiaRemision],
		gr.NroComprobante [NroComprobanteGuiaRemision],
		l.CodigoCliente,
		l.CodigoBanco,
		l.CodigoUnicoBanco,
		l.CodigoMoneda,
		l.Monto,
		l.Estado,
		l.FlagCancelado
		from
		Letra l inner join
		FacturaVenta f on l.CodigoComprobanteRef = f.CodigoFacturaVenta left join
		Serie sf on f.CodigoSerie = sf.CodigoSerie left join
		GuiaRemision gr on l.CodigoGuiaRemision = gr.CodigoGuiaRemision left join
		Serie sgr on gr.CodigoSerie = sgr.CodigoSerie
		where
		l.CodigoTipoComprobanteRef = @codigoTipoComprobanteRef and
		l.CodigoComprobanteRef = @codigoComprobanteRef and
		l.FlagEliminado = 0
	end

	select * from @letra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_letra_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_letra_obtener]
@codigoLetra int
as
begin
	select
	l.CodigoLetra,
	l.Numero,
	l.FechaHoraEmision,
	l.FechaVencimiento,
	l.Dias,
	l.CodigoTipoComprobanteRef,
	l.CodigoComprobanteRef,
	l.CodigoGuiaRemision,
	l.CodigoCliente,
	l.CodigoBanco,
	l.CodigoUnicoBanco,
	l.CodigoMoneda,
	l.Monto,
	l.Mora,
	l.Protesto,
	l.Estado,
	l.CodigoLetraPadre,
	l.CodigoLetraInicial,
	l.FlagAval,
	l.DireccionAval,
	l.NombrePaisAval,
	l.NombreDepartamentoAval,
	l.NombreProvinciaAval,
	l.NombreDistritoAval,
	l.FlagCancelado,
	l.FlagActivo
	from
	Letra l
	where
	l.CodigoLetra = @codigoLetra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_menu_guardar]
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
		CodigoMenuPadre = @codigoMenuPadre,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoMenu = @codigoMenu
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_combo_menupadre]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_default_x_perfil]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_listar_x_perfil]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_menu_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivonota_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivonota_buscar]
@descripcion varchar(100),
@flagActivo bit
as
begin
	select
	cast(row_number() over(order by mn.Descripcion) as int) [Fila],
	mn.CodigoMotivoNota,
	mn.Descripcion,
	mn.CodigoTipoComprobante,
	tc.Nombre [NombreTipoComprobante],
	mn.FlagActivo
	from
	MotivoNota mn inner join
	TipoComprobante tc on mn.CodigoTipoComprobante = tc.CodigoTipoComprobante
	where
	(mn.Descripcion like '%' + isnull(@descripcion, '') + '%') and
	mn.FlagActivo = @flagActivo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivonota_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivonota_cambiar_flagactivo]
@codigoMotivoNota int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update MotivoNota set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoMotivoNota = @codigoMotivoNota
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivonota_existe]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivonota_existe]
@codigoMotivoNota int,
@descripcion varchar(50),
@codigoTipoComprobante int
as
begin
	select cast(count(1) as bit) from MotivoNota where Descripcion = @descripcion and CodigoTipoComprobante = @codigoTipoComprobante and CodigoMotivoNota != isnull(@codigoMotivoNota, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivonota_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivonota_guardar]
@codigoMotivoNota int,
@descripcion varchar(50),
@codigoTipoComprobante int,
@usuarioModi varchar(20)
as
begin
	set @codigoMotivoNota = (select CodigoMotivoNota from MotivoNota where CodigoMotivoNota = @codigoMotivoNota)

	if @codigoMotivoNota is null
	begin
		select @codigoMotivoNota = isnull(max(CodigoMotivoNota), 0) + 1 from MotivoNota

		insert into MotivoNota
		(CodigoMotivoNota, Descripcion, CodigoTipoComprobante, FlagActivo, UsuarioGraba, FechaGraba)
		values
		(@codigoMotivoNota, @descripcion, @codigoTipoComprobante, 1, @usuarioModi, getdate())
	end
	else
	begin
		update MotivoNota set
		Descripcion = @descripcion,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoMotivoNota = @codigoMotivoNota
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivonota_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_motivonota_listar_combo]
@codigoTipoComprobante int
as
begin
	select
	mn.CodigoMotivoNota,
	mn.Descripcion,
	mn.CodigoTipoComprobante,
	mn.CodigoSunat,
	mn.FlagActivo
	from
	MotivoNota mn
	where FlagActivo = 1
	and mn.CodigoTipoComprobante = @codigoTipoComprobante
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivonota_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_motivonota_obtener]
@codigoMotivoNota int
as
begin
	select
	mn.CodigoMotivoNota,
	mn.Descripcion,
	mn.CodigoTipoComprobante,
	mn.FlagActivo
	from
	MotivoNota mn
	where
	mn.CodigoMotivoNota = @codigoMotivoNota
end
GO
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_motivotraslado_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_notacredito_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notacredito_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@codigoSerie int,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	declare @tmp  table(
		Fila int,
		CodigoNotaCredito int,
		FechaHoraEmision datetime,
		CodigoSerie int,
		SerialSerie varchar(4),
		NroComprobante int,
		CodigoCliente int,
		CodigoTipoDocumentoIdentidadCliente int,
		DescripcionTipoDocumentoIdentidadCliente varchar(50),
		NroDocumentoIdentidadCliente varchar(20),
		NombresCliente varchar(100),
		FlagActivoCliente bit,
		CodigoMotivoNota int,
		DescripcionMotivoNota varchar(50),
		CodigoMoneda int,
		TotalImporte decimal(18, 2),
		CodigoTipoComprobanteRef int,
		NombreTipoComprobanteRef varchar(50),
		CodigoComprobanteRef int,
		CodigoSerieComprobanteRef int,
		SerialSerieComprobanteRef varchar(4),
		NroComprobanteComprobanteRef int,
		FechaHoraEmisionComprobanteRef datetime,
		FlagEmitido bit,
		FlagActivo bit
	)

	--INSERT NOTA DE CRÉDITO DE FACTURA
	insert into @tmp
	(Fila, CodigoNotaCredito, FechaHoraEmision, CodigoSerie, SerialSerie, NroComprobante,
	CodigoCliente, CodigoTipoDocumentoIdentidadCliente, DescripcionTipoDocumentoIdentidadCliente,
	NroDocumentoIdentidadCliente, NombresCliente, FlagActivoCliente, CodigoMotivoNota, DescripcionMotivoNota,
	CodigoMoneda, TotalImporte, CodigoTipoComprobanteRef, NombreTipoComprobanteRef, CodigoComprobanteRef,
	CodigoSerieComprobanteRef, SerialSerieComprobanteRef, NroComprobanteComprobanteRef,
	FechaHoraEmisionComprobanteRef, FlagEmitido, FlagActivo)
	select
	cast(row_number() over(order by nc.CodigoNotaCredito desc) as int) [Fila],
	nc.CodigoNotaCredito,
	nc.FechaHoraEmision,
	nc.CodigoSerie,
	s.Serial [SerialSerie],
	nc.NroComprobante,
	nc.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	nc.CodigoMotivoNota,
	mn.Descripcion [DescripcionMotivoNota],
	nc.CodigoMoneda,
	nc.TotalImporte,
	nc.CodigoTipoComprobanteRef,
	tc.Nombre [NombreTipoComprobanteRef],
	nc.CodigoComprobanteRef,
	fv.CodigoSerie [CodigoSerieComprobanteRef],
	sfv.Serial [SerialSerieComprobanteRef],
	fv.NroComprobante [NroComprobanteComprobanteRef],
	fv.FechaHoraEmision [FechaHoraEmisionComprobanteRef],
	nc.FlagEmitido,
	nc.FlagActivo
	from
	NotaCredito nc inner join
	Serie s on nc.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nc.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	TipoComprobante tc on nc.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	FacturaVenta fv on nc.CodigoComprobanteRef = fv.CodigoFacturaVenta inner join
	Serie sfv on fv.CodigoSerie = sfv.CodigoSerie inner join
	MotivoNota mn on nc.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nc.CodigoTipoComprobanteRef = 2 and
	(cast(nc.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(nc.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(nc.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(nc.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(nc.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo

	--INSERT NOTA DE CRÉDITO DE BOLETA
	insert into @tmp
	(Fila, CodigoNotaCredito, FechaHoraEmision, CodigoSerie, SerialSerie, NroComprobante,
	CodigoCliente, CodigoTipoDocumentoIdentidadCliente, DescripcionTipoDocumentoIdentidadCliente,
	NroDocumentoIdentidadCliente, NombresCliente, FlagActivoCliente, CodigoMotivoNota, DescripcionMotivoNota,
	CodigoMoneda, TotalImporte, CodigoTipoComprobanteRef, NombreTipoComprobanteRef, CodigoComprobanteRef,
	CodigoSerieComprobanteRef, SerialSerieComprobanteRef, NroComprobanteComprobanteRef,
	FechaHoraEmisionComprobanteRef, FlagEmitido, FlagActivo)
	select
	cast(row_number() over(order by nc.CodigoNotaCredito desc) as int) [Fila],
	nc.CodigoNotaCredito,
	nc.FechaHoraEmision,
	nc.CodigoSerie,
	s.Serial [SerialSerie],
	nc.NroComprobante,
	nc.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	nc.CodigoMotivoNota,
	mn.Descripcion [DescripcionMotivoNota],
	nc.CodigoMoneda,
	nc.TotalImporte,
	nc.CodigoTipoComprobanteRef,
	tc.Nombre [NombreTipoComprobanteRef],
	nc.CodigoComprobanteRef,
	bv.CodigoSerie [CodigoSerieComprobanteRef],
	sbv.Serial [SerialSerieComprobanteRef],
	bv.NroComprobante [NroComprobanteComprobanteRef],
	bv.FechaHoraEmision [FechaHoraEmisionComprobanteRef],
	nc.FlagEmitido,
	nc.FlagActivo
	from
	NotaCredito nc inner join
	Serie s on nc.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nc.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	TipoComprobante tc on nc.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	BoletaVenta bv on nc.CodigoComprobanteRef = bv.CodigoBoletaVenta inner join
	Serie sbv on bv.CodigoSerie = sbv.CodigoSerie inner join
	MotivoNota mn on nc.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nc.CodigoTipoComprobanteRef = 1 and
	(cast(nc.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(nc.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(nc.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(nc.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(nc.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo

	select * from @tmp
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacredito_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notacredito_guardar]
@codigoNotaCredito int out,
@codigoSerie int,
@nroComprobante int out,
@fechaHoraEmision datetime,
@codigoCliente int,
@direccionCliente varchar(100),
@nombrePaisCliente varchar(50),
@nombreDepartamentoCliente varchar(50),
@nombreProvinciaCliente varchar(50),
@nombreDistritoCliente varchar(50),
@codigoDistritoCliente int,
@codigoMoneda int,
@codigoMotivoNota int,
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int,
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
@totalEnLetras nvarchar(max) out,
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoNotaCredito = (select CodigoNotaCredito from NotaCredito where CodigoNotaCredito = @codigoNotaCredito)

	declare @nombreMoneda varchar(max) = (select Nombre from Moneda where CodigoMoneda = @codigoMoneda)
	
	set @totalEnLetras = dbo.CantidadConLetra(@totalImporte, @nombreMoneda)

	if @codigoNotaCredito is null
	begin
		select @codigoNotaCredito = isnull(max(CodigoNotaCredito), 0) + 1 from NotaCredito
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into NotaCredito
		(CodigoNotaCredito, CodigoSerie, NroComprobante, FechaHoraEmision,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		CodigoMotivoNota, CodigoTipoComprobanteRef, CodigoComprobanteRef,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoNotaCredito, @codigoSerie, @nroComprobante, @fechaHoraEmision,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@codigoMotivoNota, @codigoTipoComprobanteRef, @codigoComprobanteRef,
		@totalOperacionGravada, @totalOperacionInafecta, @totalOperacionExonerada, @totalOperacionExportacion,
		@totalOperacionGratuita, @totalValorVenta, @totalIgv, @totalIsc, @totalOtrosCargos, @totalOtrosTributos,
		@totalIcbper, @totalDescuentoDetallado, @totalPorcentajeDescuentoGlobal, @totalDescuentoGlobal,
		@totalPrecioVenta, @totalImporte, @totalPercepcion, @totalPagar, @flagEmitido, 1,
		@usuarioModi, getdate())

		exec usp_serie_aumentarvaloractual @codigoSerie, @usuarioModi
	end
	else
	begin
		update NotaCredito set
		CodigoSerie = @codigoSerie,
		FechaHoraEmision = @fechaHoraEmision,
		CodigoCliente = @codigoCliente,
		DireccionCliente = @direccionCliente,
		NombrePaisCliente = @nombrePaisCliente,
		NombreDepartamentoCliente = @nombreDepartamentoCliente,
		NombreProvinciaCliente = @nombreProvinciaCliente,
		CodigoDistritoCliente = @codigoDistritoCliente,
		NombreDistritoCliente = @nombreDistritoCliente,
		CodigoMoneda = @codigoMoneda,
		CodigoMotivoNota = @codigoMotivoNota,
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
		CodigoNotaCredito = @codigoNotaCredito
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacredito_guardar_emision]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notacredito_guardar_emision]
@codigoNotaCredito int,
@hash varchar(max),
@codigoRptaSunat varchar(max),
@descripcionRptaSunat varchar(max),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	update NotaCredito set
	[Hash] = @hash,
	CodigoRptaSunat = @codigoRptaSunat,
	DescripcionRptaSunat = @descripcionRptaSunat,
	FlagEmitido = @flagEmitido,
	FechaModi = getdate(),
	UsuarioModi = @usuarioModi
	where
	CodigoNotaCredito = @codigoNotaCredito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacredito_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notacredito_obtener]
@codigoNotaCredito int
as
begin
	select
	nc.CodigoNotaCredito,
	nc.CodigoSerie,
	nc.NroComprobante,
	nc.FechaHoraEmision,
	nc.CodigoCliente,
	nc.DireccionCliente,
	nc.NombrePaisCliente,
	nc.NombreDepartamentoCliente,
	nc.NombreProvinciaCliente,
	nc.CodigoDistritoCliente,
	nc.NombreDistritoCliente,
	nc.CodigoMoneda,
	nc.CodigoMotivoNota,
	nc.CodigoTipoComprobanteRef,
	nc.CodigoComprobanteRef,
	nc.TotalOperacionGravada,
	nc.TotalOperacionInafecta,
	nc.TotalOperacionExonerada,
	nc.TotalOperacionExportacion,
	nc.TotalOperacionGratuita,
	nc.TotalValorVenta,
	nc.TotalIgv,
	nc.TotalIsc,
	nc.TotalOtrosCargos,
	nc.TotalOtrosTributos,
	nc.TotalIcbper,
	nc.TotalDescuentoDetallado,
	nc.TotalPorcentajeDescuentoGlobal,
	nc.TotalDescuentoGlobal,
	nc.TotalPrecioVenta,
	nc.TotalImporte,
	nc.TotalPercepcion,
	nc.TotalPagar,
	nc.FlagEmitido,
	nc.FlagActivo
	from
	NotaCredito nc
	where
	nc.CodigoNotaCredito = @codigoNotaCredito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacreditodetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notacreditodetalle_eliminar]
@codigoNotaCreditoDetalle int,
@usuarioModi varchar(20)
as
begin
	update NotaCreditoDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoNotaCreditoDetalle = @codigoNotaCreditoDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacreditodetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notacreditodetalle_guardar]
@codigoNotaCredito int,
@codigoNotaCreditoDetalle int out,
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
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int,
@codigoComprobanteDetalleRef int,
@usuarioModi varchar(20)
as
begin
	set @codigoNotaCreditoDetalle = (select CodigoNotaCreditoDetalle from NotaCreditoDetalle where CodigoNotaCreditoDetalle = @codigoNotaCreditoDetalle)

	if @codigoNotaCreditoDetalle is null
	begin
		select @codigoNotaCreditoDetalle = isnull(max(CodigoNotaCreditoDetalle), 0) + 1 from NotaCreditoDetalle

		insert into NotaCreditoDetalle
		(CodigoNotaCredito, CodigoNotaCreditoDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, TipoCalculo, ValorUnitario, PrecioUnitario, ValorVenta, PrecioVenta,
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe,
		CodigoTipoComprobanteRef, CodigoComprobanteRef, CodigoComprobanteDetalleRef,
		FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoNotaCredito, @codigoNotaCreditoDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 
		@codigoTipoComprobanteRef, @codigoComprobanteRef, @codigoComprobanteDetalleRef,
		0, @usuarioModi, getdate())
	end
	else
	begin
		update NotaCreditoDetalle set
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
		CodigoNotaCreditoDetalle = @codigoNotaCreditoDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notacreditodetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notacreditodetalle_listar]
@codigoNotaCredito int
as
begin
	select
	cast(row_number() over(order by ncd.CodigoNotaCreditoDetalle desc) as int) [Fila],
	ncd.CodigoNotaCredito,
	ncd.CodigoNotaCreditoDetalle,
	ncd.CodigoProducto,
	p.Nombre [NombreProducto],
	ncd.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	ncd.CodigoUnidadMedida,
	ncd.Detalle,
	ncd.Cantidad,
	ncd.ValorUnitario,
	ncd.PrecioUnitario,
	ncd.ValorVenta,
	ncd.PrecioVenta,
	ncd.Igv,
	ncd.Isc,
	ncd.PorcentajeDescuento,
	ncd.Descuento,
	ncd.OtrosCargos,
	ncd.OtrosTributos,
	ncd.BaseImponible,
	ncd.Importe,
	ncd.CodigoTipoComprobanteRef,
	ncd.CodigoComprobanteRef,
	ncd.CodigoComprobanteDetalleRef,
	ncd.FlagEliminado
	from
	NotaCreditoDetalle ncd inner join
	Producto p on ncd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on ncd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	ncd.CodigoNotaCredito = @codigoNotaCredito and
	ncd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebito_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notadebito_buscar]
@fechaEmisionDesde date,
@fechaEmisionHasta date,
@codigoSerie int,
@numero varchar(8),
@nroDocumentoIdentidadCliente varchar(20),
@nombresCliente varchar(100),
@flagActivo bit
as
begin
	declare @tmp  table(
		Fila int,
		CodigoNotaDebito int,
		FechaHoraEmision datetime,
		CodigoSerie int,
		SerialSerie varchar(4),
		NroComprobante int,
		CodigoCliente int,
		CodigoTipoDocumentoIdentidadCliente int,
		DescripcionTipoDocumentoIdentidadCliente varchar(50),
		NroDocumentoIdentidadCliente varchar(20),
		NombresCliente varchar(100),
		FlagActivoCliente bit,
		CodigoMotivoNota int,
		DescripcionMotivoNota varchar(50),
		CodigoMoneda int,
		TotalImporte decimal(18, 2),
		CodigoTipoComprobanteRef int,
		NombreTipoComprobanteRef varchar(50),
		CodigoComprobanteRef int,
		CodigoSerieComprobanteRef int,
		SerialSerieComprobanteRef varchar(4),
		NroComprobanteComprobanteRef int,
		FechaHoraEmisionComprobanteRef datetime,
		FlagEmitido bit,
		FlagActivo bit
	)

	--INSERT NOTA DE DÉBITO DE FACTURA
	insert into @tmp
	(Fila, CodigoNotaDebito, FechaHoraEmision, CodigoSerie, SerialSerie, NroComprobante,
	CodigoCliente, CodigoTipoDocumentoIdentidadCliente, DescripcionTipoDocumentoIdentidadCliente,
	NroDocumentoIdentidadCliente, NombresCliente, FlagActivoCliente, CodigoMotivoNota, DescripcionMotivoNota,
	CodigoMoneda, TotalImporte, CodigoTipoComprobanteRef, NombreTipoComprobanteRef, CodigoComprobanteRef,
	CodigoSerieComprobanteRef, SerialSerieComprobanteRef, NroComprobanteComprobanteRef,
	FechaHoraEmisionComprobanteRef, FlagEmitido, FlagActivo)
	select
	cast(row_number() over(order by nd.CodigoNotaDebito desc) as int) [Fila],
	nd.CodigoNotaDebito,
	nd.FechaHoraEmision,
	nd.CodigoSerie,
	s.Serial [SerialSerie],
	nd.NroComprobante,
	nd.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	nd.CodigoMotivoNota,
	mn.Descripcion [DescripcionMotivoNota],
	nd.CodigoMoneda,
	nd.TotalImporte,
	nd.CodigoTipoComprobanteRef,
	tc.Nombre [NombreTipoComprobanteRef],
	nd.CodigoComprobanteRef,
	fv.CodigoSerie [CodigoSerieComprobanteRef],
	sfv.Serial [SerialSerieComprobanteRef],
	fv.NroComprobante [NroComprobanteComprobanteRef],
	fv.FechaHoraEmision [FechaHoraEmisionComprobanteRef],
	nd.FlagEmitido,
	nd.FlagActivo
	from
	NotaDebito nd inner join
	Serie s on nd.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nd.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	TipoComprobante tc on nd.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	FacturaVenta fv on nd.CodigoComprobanteRef = fv.CodigoFacturaVenta inner join
	Serie sfv on fv.CodigoSerie = sfv.CodigoSerie inner join
	MotivoNota mn on nd.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nd.CodigoTipoComprobanteRef = 2 and
	(cast(nd.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(nd.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(nd.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(nd.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(nd.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo

	--INSERT NOTA DE DÉBITO DE BOLETA
	insert into @tmp
	(Fila, CodigoNotaDebito, FechaHoraEmision, CodigoSerie, SerialSerie, NroComprobante,
	CodigoCliente, CodigoTipoDocumentoIdentidadCliente, DescripcionTipoDocumentoIdentidadCliente,
	NroDocumentoIdentidadCliente, NombresCliente, FlagActivoCliente, CodigoMotivoNota, DescripcionMotivoNota,
	CodigoMoneda, TotalImporte, CodigoTipoComprobanteRef, NombreTipoComprobanteRef, CodigoComprobanteRef,
	CodigoSerieComprobanteRef, SerialSerieComprobanteRef, NroComprobanteComprobanteRef,
	FechaHoraEmisionComprobanteRef, FlagEmitido, FlagActivo)
	select
	cast(row_number() over(order by nd.CodigoNotaDebito desc) as int) [Fila],
	nd.CodigoNotaDebito,
	nd.FechaHoraEmision,
	nd.CodigoSerie,
	s.Serial [SerialSerie],
	nd.NroComprobante,
	nd.CodigoCliente,
	c.CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadCliente],
	tdi.Descripcion [DescripcionTipoDocumentoIdentidadCliente],
	c.NroDocumentoIdentidad [NroDocumentoIdentidadCliente],
	c.Nombres [NombresCliente],
	c.FlagActivo [FlagActivoCliente],
	nd.CodigoMotivoNota,
	mn.Descripcion [DescripcionMotivoNota],
	nd.CodigoMoneda,
	nd.TotalImporte,
	nd.CodigoTipoComprobanteRef,
	tc.Nombre [NombreTipoComprobanteRef],
	nd.CodigoComprobanteRef,
	bv.CodigoSerie [CodigoSerieComprobanteRef],
	sbv.Serial [SerialSerieComprobanteRef],
	bv.NroComprobante [NroComprobanteComprobanteRef],
	bv.FechaHoraEmision [FechaHoraEmisionComprobanteRef],
	nd.FlagEmitido,
	nd.FlagActivo
	from
	NotaDebito nd inner join
	Serie s on nd.CodigoSerie = s.CodigoSerie inner join
	Cliente c on nd.CodigoCliente = c.CodigoCliente inner join
	TipoDocumentoIdentidad tdi on c.CodigoTipoDocumentoIdentidad = tdi.CodigoTipoDocumentoIdentidad inner join
	TipoComprobante tc on nd.CodigoTipoComprobanteRef = tc.CodigoTipoComprobante inner join
	BoletaVenta bv on nd.CodigoComprobanteRef = bv.CodigoBoletaVenta inner join
	Serie sbv on bv.CodigoSerie = sbv.CodigoSerie inner join
	MotivoNota mn on nd.CodigoMotivoNota = mn.CodigoMotivoNota
	where
	nd.CodigoTipoComprobanteRef = 1 and
	(cast(nd.FechaHoraEmision as date) between @fechaEmisionDesde and @fechaEmisionHasta or (cast(nd.FechaHoraEmision as date) >= @fechaEmisionDesde and @fechaEmisionDesde is not null and @fechaEmisionHasta is null) or (cast(nd.FechaHoraEmision as date) <= @fechaEmisionHasta and @fechaEmisionHasta is not null and @fechaEmisionDesde is null) or (@fechaEmisionDesde is null and @fechaEmisionHasta is null)) and
	(nd.CodigoSerie = @codigoSerie or @codigoSerie is null) and
	(right('00000000' + rtrim(nd.NroComprobante), 8) like '%' + isnull(@numero, '') + '%') and
	(c.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadCliente, '') + '%') and
	(c.Nombres like '%' + isnull(@nombresCliente, '') + '%') and
	c.FlagActivo = @flagActivo

	select * from @tmp
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebito_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notadebito_guardar]
@codigoNotaDebito int out,
@codigoSerie int,
@nroComprobante int out,
@fechaHoraEmision datetime,
@codigoCliente int,
@direccionCliente varchar(100),
@nombrePaisCliente varchar(50),
@nombreDepartamentoCliente varchar(50),
@nombreProvinciaCliente varchar(50),
@nombreDistritoCliente varchar(50),
@codigoDistritoCliente int,
@codigoMoneda int,
@codigoMotivoNota int,
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int,
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
@totalEnLetras nvarchar(max) out,
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	set @codigoNotaDebito = (select CodigoNotaDebito from NotaDebito where CodigoNotaDebito = @codigoNotaDebito)

	declare @nombreMoneda varchar(max) = (select Nombre from Moneda where CodigoMoneda = @codigoMoneda)
	
	set @totalEnLetras = dbo.CantidadConLetra(@totalImporte, @nombreMoneda)

	if @codigoNotaDebito is null
	begin
		select @codigoNotaDebito = isnull(max(CodigoNotaDebito), 0) + 1 from NotaDebito
		select @nroComprobante = isnull(ValorActual, 0) + 1 from Serie where CodigoSerie = @codigoSerie

		insert into NotaDebito
		(CodigoNotaDebito, CodigoSerie, NroComprobante, FechaHoraEmision,
		CodigoCliente, DireccionCliente, NombrePaisCliente, NombreDepartamentoCliente,
		NombreProvinciaCliente, CodigoDistritoCliente, NombreDistritoCliente, CodigoMoneda,
		CodigoMotivoNota, CodigoTipoComprobanteRef, CodigoComprobanteRef,
		TotalOperacionGravada, TotalOperacionInafecta, TotalOperacionExonerada, TotalOperacionExportacion,
		TotalOperacionGratuita, TotalValorVenta, TotalIgv, TotalIsc, TotalOtrosCargos, TotalOtrosTributos,
		TotalIcbper, TotalDescuentoDetallado, TotalPorcentajeDescuentoGlobal, TotalDescuentoGlobal,
		TotalPrecioVenta, TotalImporte, TotalPercepcion, TotalPagar, FlagEmitido, FlagActivo,
		UsuarioGraba, FechaGraba)
		values
		(@codigoNotaDebito, @codigoSerie, @nroComprobante, @fechaHoraEmision,
		@codigoCliente, @direccionCliente, @nombrePaisCliente, @nombreDepartamentoCliente,
		@nombreProvinciaCliente, @codigoDistritoCliente, @nombreDistritoCliente, @codigoMoneda,
		@codigoMotivoNota, @codigoTipoComprobanteRef, @codigoComprobanteRef,
		@totalOperacionGravada, @totalOperacionInafecta, @totalOperacionExonerada, @totalOperacionExportacion,
		@totalOperacionGratuita, @totalValorVenta, @totalIgv, @totalIsc, @totalOtrosCargos, @totalOtrosTributos,
		@totalIcbper, @totalDescuentoDetallado, @totalPorcentajeDescuentoGlobal, @totalDescuentoGlobal,
		@totalPrecioVenta, @totalImporte, @totalPercepcion, @totalPagar, @flagEmitido, 1,
		@usuarioModi, getdate())

		exec usp_serie_aumentarvaloractual @codigoSerie, @usuarioModi
	end
	else
	begin
		update NotaDebito set
		CodigoSerie = @codigoSerie,
		FechaHoraEmision = @fechaHoraEmision,
		CodigoCliente = @codigoCliente,
		DireccionCliente = @direccionCliente,
		NombrePaisCliente = @nombrePaisCliente,
		NombreDepartamentoCliente = @nombreDepartamentoCliente,
		NombreProvinciaCliente = @nombreProvinciaCliente,
		CodigoDistritoCliente = @codigoDistritoCliente,
		NombreDistritoCliente = @nombreDistritoCliente,
		CodigoMoneda = @codigoMoneda,
		CodigoMotivoNota = @codigoMotivoNota,
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
		CodigoNotaDebito = @codigoNotaDebito
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebito_guardar_emision]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notadebito_guardar_emision]
@codigoNotaDebito int,
@hash varchar(max),
@codigoRptaSunat varchar(max),
@descripcionRptaSunat varchar(max),
@flagEmitido bit,
@usuarioModi varchar(20)
as
begin
	update NotaDebito set
	[Hash] = @hash,
	CodigoRptaSunat = @codigoRptaSunat,
	DescripcionRptaSunat = @descripcionRptaSunat,
	FlagEmitido = @flagEmitido,
	FechaModi = getdate(),
	UsuarioModi = @usuarioModi
	where
	CodigoNotaDebito = @codigoNotaDebito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebito_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notadebito_obtener]
@codigoNotaDebito int
as
begin
	select
	nd.CodigoNotaDebito,
	nd.CodigoSerie,
	nd.NroComprobante,
	nd.FechaHoraEmision,
	nd.CodigoCliente,
	nd.DireccionCliente,
	nd.NombrePaisCliente,
	nd.NombreDepartamentoCliente,
	nd.NombreProvinciaCliente,
	nd.CodigoDistritoCliente,
	nd.NombreDistritoCliente,
	nd.CodigoMoneda,
	nd.CodigoMotivoNota,
	nd.CodigoTipoComprobanteRef,
	nd.CodigoComprobanteRef,
	nd.TotalOperacionGravada,
	nd.TotalOperacionInafecta,
	nd.TotalOperacionExonerada,
	nd.TotalOperacionExportacion,
	nd.TotalOperacionGratuita,
	nd.TotalValorVenta,
	nd.TotalIgv,
	nd.TotalIsc,
	nd.TotalOtrosCargos,
	nd.TotalOtrosTributos,
	nd.TotalIcbper,
	nd.TotalDescuentoDetallado,
	nd.TotalPorcentajeDescuentoGlobal,
	nd.TotalDescuentoGlobal,
	nd.TotalPrecioVenta,
	nd.TotalImporte,
	nd.TotalPercepcion,
	nd.TotalPagar,
	nd.FlagEmitido,
	nd.FlagActivo
	from
	NotaDebito nd
	where
	nd.CodigoNotaDebito = @codigoNotaDebito
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebitodetalle_eliminar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notadebitodetalle_eliminar]
@codigoNotaDebitoDetalle int,
@usuarioModi varchar(20)
as
begin
	update NotaDebitoDetalle set
	FlagEliminado = 1,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoNotaDebitoDetalle = @codigoNotaDebitoDetalle
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebitodetalle_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_notadebitodetalle_guardar]
@codigoNotaDebito int,
@codigoNotaDebitoDetalle int out,
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
@codigoTipoComprobanteRef int,
@codigoComprobanteRef int,
@codigoComprobanteDetalleRef int,
@usuarioModi varchar(20)
as
begin
	set @codigoNotaDebitoDetalle = (select CodigoNotaDebitoDetalle from NotaDebitoDetalle where CodigoNotaDebitoDetalle = @codigoNotaDebitoDetalle)

	if @codigoNotaDebitoDetalle is null
	begin
		select @codigoNotaDebitoDetalle = isnull(max(CodigoNotaDebitoDetalle), 0) + 1 from NotaDebitoDetalle

		insert into NotaDebitoDetalle
		(CodigoNotaDebito, CodigoNotaDebitoDetalle, CodigoProducto, CodigoProductoIndividual,
		CodigoUnidadMedida, Detalle, Cantidad, TipoCalculo, ValorUnitario, PrecioUnitario, ValorVenta, PrecioVenta,
		Igv, Isc, TipoDescuento, PorcentajeDescuento, Descuento, OtrosCargos, OtrosTributos, BaseImponible, Importe,
		CodigoTipoComprobanteRef, CodigoComprobanteRef, CodigoComprobanteDetalleRef,
		FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@codigoNotaDebito, @codigoNotaDebitoDetalle, @codigoProducto, @codigoProductoIndividual,
		@codigoUnidadMedida, @detalle, @cantidad, @tipoCalculo, @valorUnitario, @precioUnitario, @valorVenta, @precioVenta,
		@igv, @isc, @tipoDescuento, @porcentajeDescuento, @descuento, @otrosCargos, @otrosTributos, @baseImponible, @importe, 
		@codigoTipoComprobanteRef, @codigoComprobanteRef, @codigoComprobanteDetalleRef,
		0, @usuarioModi, getdate())
	end
	else
	begin
		update NotaDebitoDetalle set
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
		CodigoNotaDebitoDetalle = @codigoNotaDebitoDetalle
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_notadebitodetalle_listar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_notadebitodetalle_listar]
@codigoNotaDebito int
as
begin
	select
	cast(row_number() over(order by ndd.CodigoNotaDebitoDetalle desc) as int) [Fila],
	ndd.CodigoNotaDebito,
	ndd.CodigoNotaDebitoDetalle,
	ndd.CodigoProducto,
	p.Nombre [NombreProducto],
	ndd.CodigoProductoIndividual,
	[pi].Nombre [NombreProductoIndividual],
	ndd.CodigoUnidadMedida,
	ndd.Detalle,
	ndd.Cantidad,
	ndd.ValorUnitario,
	ndd.PrecioUnitario,
	ndd.ValorVenta,
	ndd.PrecioVenta,
	ndd.Igv,
	ndd.Isc,
	ndd.PorcentajeDescuento,
	ndd.Descuento,
	ndd.OtrosCargos,
	ndd.OtrosTributos,
	ndd.BaseImponible,
	ndd.Importe,
	ndd.CodigoTipoComprobanteRef,
	ndd.CodigoComprobanteRef,
	ndd.CodigoComprobanteDetalleRef,
	ndd.FlagEliminado
	from
	NotaDebitoDetalle ndd inner join
	Producto p on ndd.CodigoProducto = p.CodigoProducto inner join
	ProductoIndividual [pi] on ndd.CodigoProductoIndividual = [pi].CodigoProductoIndividual
	where
	ndd.CodigoNotaDebito = @codigoNotaDebito and
	ndd.FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_pais_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_listar_default_x_usuario]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_listar_x_usuario]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfil_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfilmenu_eliminar_x_perfil]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_perfilmenu_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_cambiar_estado]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_personal_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_producto_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_producto_cambiar_estado]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_producto_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_producto_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_producto_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
	[pi].CodigoUnidadMedidaPeso,
	ump.Descripcion [DescripcionUnidadMedidaPeso],
	ump.FlagActivo [FlagActivoUnidadMedidaPeso],
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
	[per].Estado [EstadoPersonalInspeccion],
	[pi].FlagEliminado
	from
	ProductoIndividual [pi] inner join
	Producto p on [pi].CodigoProducto = p.CodigoProducto inner join
	UnidadMedida um on [pi].CodigoUnidadMedida = um.CodigoUnidadMedida inner join
	UnidadMedida ump on [pi].CodigoUnidadMedidaPeso = ump.CodigoUnidadMedida inner join
	Proveedor prov on [pi].CodigoProveedor = prov.CodigoProveedor inner join
	Personal per on [pi].CodigoPersonalInspeccion = per.CodigoPersonal
	where
	([pi].CodigoProductoIndividual = @codigoProductoIndividual or @codigoProductoIndividual is null) and
	isnull([pi].CodigoBarra, '') like '%' + isnull(@codigoBarra, '') + '%' and
	([pi].CodigoProducto = @codigoProducto or @codigoProducto is null) and
	[pi].Nombre like '%' + isnull(@nombre, '') + '%' and
	isnull([pi].CodigoInicial, '') like '%' + isnull(@codigoInicial, '') + '%' and
	[pi].Color like '%' + isnull(@color, '') + '%' and
	[prov].NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadProveedor, '') + '%' and
	[prov].Nombres like '%' + isnull(@nombresProveedor, '') + '%' and
	(cast([pi].FechaEntrada as date) between @fechaEntradaDesde and @fechaEntradaHasta or (@fechaEntradaDesde is null and @fechaEntradaHasta is null)) and
	[per].NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonaInspeccion, '') + '%' and
	[per].Nombres like '%' + isnull(@nombresPersonalInspeccion, '') + '%' and
	[pi].FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_productoindividual_cambiar_flagactivo]
@codigoProductoIndividual int,
@flagActivo bit,
@usuarioModi varchar(20)
as
begin
	update ProductoIndividual set
	FlagActivo = @flagActivo,
	UsuarioModi = @usuarioModi,
	FechaModi = getdate()
	where
	CodigoProductoIndividual = @codigoProductoIndividual
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_guardar]
@codigoProductoIndividual int out,
@codigoBarra varchar(50),
@codigoProducto int,
@nombre varchar(50),
@codigoUnidadMedida int,
@metraje decimal(18, 2),
@codigoUnidadMedidaPeso int,
@peso decimal(18, 2),
@codigoInicial varchar(50),
@rollo decimal(18, 2),
@bulto decimal(18, 2),
@color varchar(20),
@codigoProveedor int,
@codigoBarraProveedor varchar(50),
@fechaEntrada datetime,
@precioVenta decimal(18, 2),
@precioCompra decimal(18, 2),
@codigoPersonalInspeccion int,
@codigoComprobanteCompra int,
@codigoComprobanteCompraDetalle int,
@usuarioModi varchar(20)
as
begin
	set @codigoProductoIndividual = (select CodigoProductoIndividual from ProductoIndividual where CodigoProductoIndividual = @codigoProductoIndividual)

	if @codigoProductoIndividual is null
	begin
		select @codigoProductoIndividual = isnull(max(CodigoProductoIndividual), 0) + 1 from ProductoIndividual

		insert into ProductoIndividual
		(CodigoProductoIndividual, CodigoBarra, CodigoProducto, Nombre, CodigoUnidadMedida, Metraje, CodigoUnidadMedidaPeso, Peso, CodigoInicial, Rollo, Bulto, Color, CodigoProveedor, CodigoBarraProveedor, FechaEntrada, PrecioVenta, PrecioCompra, CodigoPersonalInspeccion, CodigoComprobanteCompra, CodigoComprobanteCompraDetalle, FlagActivo, FlagEliminado, UsuarioGraba, FechaGraba)
		values
		(@CodigoProductoIndividual, @codigoBarra, @codigoProducto, @nombre, @codigoUnidadMedida, @metraje, @codigoUnidadMedidaPeso, @peso, @codigoInicial, @rollo, @bulto, @color, @codigoProveedor, @codigoBarraProveedor, @fechaEntrada, @precioVenta, @precioCompra, @codigoPersonalInspeccion, @codigoComprobanteCompra, @codigoComprobanteCompraDetalle, 1, 0, @usuarioModi, getdate())
	end
	else
	begin
		update ProductoIndividual set
		CodigoBarra = @codigoBarra,
		CodigoProducto = @codigoProducto,
		Nombre = @nombre,
		CodigoUnidadMedida = @codigoUnidadMedida,
		Metraje = @metraje,
		CodigoUnidadMedidaPeso = @codigoUnidadMedidaPeso,
		Peso = @peso,
		CodigoInicial = @codigoInicial,
		Rollo = @rollo,
		Bulto = @bulto,
		Color = @color,
		CodigoProveedor = @codigoProveedor,
		CodigoBarraProveedor = @codigoBarraProveedor,
		FechaEntrada = @fechaEntrada,
		PrecioVenta = @precioVenta,
		PrecioCompra = @precioCompra,
		CodigoPersonalInspeccion = @codigoPersonalInspeccion,
		CodigoComprobanteCompra = @codigoComprobanteCompra,
		CodigoComprobanteCompraDetalle = @codigoComprobanteCompraDetalle,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoProductoIndividual = @codigoProductoIndividual
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_listar_x_comprobantecompra]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_listar_x_comprobantecompra]
@codigoComprobanteCompra int
as
begin
	select
	cast(row_number() over(order by p.Nombre) as int) [Fila],
	[pi].CodigoProductoIndividual,
	[pi].CodigoBarra,
	[pi].CodigoProducto,
	[pi].Nombre,
	[pi].CodigoUnidadMedida,
	[um].Descripcion [DescripcionUnidadMedida],
	[um].FlagActivo [FlagActivoUnidadMedida],
	[pi].Metraje,
	[pi].CodigoUnidadMedidaPeso,
	ump.Descripcion [DescripcionUnidadMedidaPeso],
	ump.FlagActivo [FlagActivoUnidadMedidaPeso],
	[pi].Peso,
	[pi].CodigoInicial,
	[pi].Rollo,
	[pi].Bulto,
	[pi].Color,
	[pi].CodigoProveedor,
	[prov].CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadProveedor],
	[prov].NroDocumentoIdentidad [NroDocumentoIdentidadProveedor],
	[prov].Nombres [NombresProveedor],
	[prov].Direccion [DireccionProveedor],
	[prov].CodigoDistrito [CodigoDistritoProveedor],
	[prov].Correo [CorreoProveedor],
	[prov].Telefono [TelefonoProveedor],
	[prov].Contacto [ContactoProveedor],
	[prov].FlagActivo [FlagActivoProveedor],
	[pi].CodigoBarraProveedor,
	[pi].FechaEntrada,
	[pi].PrecioCompra,
	[pi].PrecioVenta,
	[pi].CodigoPersonalInspeccion,
	[per].CodigoTipoDocumentoIdentidad [CodigoTipoDocumentoIdentidadPersonalInspeccion],
	[per].NroDocumentoIdentidad [NroDocumentoIdentidadPersonalInspeccion],
	[per].Nombres [NombresPersonalInspeccion],
	[per].Correo [CorreoPersonalInspeccion],
	[per].CodigoArea [CodigoAreaPersonalInspeccion],
	[per].FlagActivo [FlagActivoPersonalInspeccion],
	[per].Estado [EstadoPersonalInspeccion],
	[pi].CodigoComprobanteCompra,
	[pi].CodigoComprobanteCompraDetalle,
	[pi].FlagEliminado
	from
	ProductoIndividual [pi] inner join
	Producto p on [pi].CodigoProducto = p.CodigoProducto inner join
	UnidadMedida um on [pi].CodigoUnidadMedida = um.CodigoUnidadMedida inner join
	UnidadMedida ump on [pi].CodigoUnidadMedidaPeso = ump.CodigoUnidadMedida inner join
	Proveedor prov on [pi].CodigoProveedor = prov.CodigoProveedor inner join
	Personal per on [pi].CodigoPersonalInspeccion = per.CodigoPersonal
	where
	[pi].CodigoComprobanteCompra = @codigoComprobanteCompra and
	[pi].FlagEliminado = 0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_obtener]
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
	c.CodigoUnidadMedidaPeso,
	c.Peso,
	c.CodigoInicial,
	c.Rollo,
	c.Bulto,
	c.Color,
	c.CodigoProveedor,
	c.CodigoBarraProveedor,
	c.FechaEntrada,
	c.PrecioVenta,
	c.PrecioCompra,
	c.CodigoPersonalInspeccion,
	c.CodigoComprobanteCompra,
	c.CodigoComprobanteCompraDetalle
	from
	ProductoIndividual c
	where
	c.CodigoProductoIndividual = @codigoProductoIndividual
end
GO
/****** Object:  StoredProcedure [dbo].[usp_productoindividual_regenerar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_productoindividual_regenerar]
@codigoProductoIndividual int,
@cantidad int,
@usuarioModi varchar(20)
as
begin
	declare @metraje decimal(18, 2)

	select
	@metraje = Metraje
	from ProductoIndividual
	where
	CodigoProductoIndividual = @codigoProductoIndividual

	if(@cantidad < @metraje)
	begin
		declare @nuevoCodigoProductoIndividual int

		select @nuevoCodigoProductoIndividual = isnull(max(CodigoProductoIndividual), 0) + 1 from ProductoIndividual

		insert into ProductoIndividual
		(CodigoProductoIndividual, CodigoProducto, Nombre, CodigoUnidadMedida, Metraje,
		CodigoUnidadMedidaPeso,
		CodigoInicial, Color, CodigoProveedor, CodigoBarraProveedor, FechaEntrada,
		PrecioVenta, PrecioCompra, CodigoPersonalInspeccion,
		CodigoComprobanteCompra, CodigoComprobanteCompraDetalle,
		FlagActivo, FlagEliminado, UsuarioGraba, FechaGraba)
		select
		@nuevoCodigoProductoIndividual, CodigoProducto, Nombre, CodigoUnidadMedida, @metraje - @cantidad,
		CodigoUnidadMedidaPeso,
		CodigoProductoIndividual, Color, CodigoProveedor, CodigoBarraProveedor, FechaEntrada,
		PrecioVenta, PrecioCompra, CodigoPersonalInspeccion,
		CodigoComprobanteCompra, CodigoComprobanteCompraDetalle,
		FlagActivo, FlagEliminado, @usuarioModi, getdate()
		from ProductoIndividual
		where
		CodigoProductoIndividual = @codigoProductoIndividual
	end

	exec usp_productoindividual_cambiar_flagactivo @codigoProductoIndividual, 0, @usuarioModi
end
GO
/****** Object:  StoredProcedure [dbo].[usp_proveedor_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_proveedor_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_proveedor_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_proveedor_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_proveedor_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_provincia_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_query_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_query_buscar]
@table varchar(max),
@columns varchar(max),
@columnsFilter varchar(max),
@where varchar(max)
as
begin
	declare @query nvarchar(max)

	set @query =	N'select * from (' + 
					'select ' +
					@columns + 
					' from ' + 
					@table + 
					' where ' +
					@where +
					') a ' +
					' where ' + @columnsFilter

	exec(@query)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_reporte_comision]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_reporte_comision]
@fechaDesde date,
@fechaHasta date,
@nroDocumentoIdentidadPersonal varchar(20),
@nombresPersonal varchar(100)
as
begin
	declare @tmp table(
		NombrePersonal varchar(100),
		TipoPersonal varchar(100),
		PorcentajeComision decimal(18, 2),
		CantidadVentas int,
		TotalVentasSinIgv decimal(18, 6),
		TotalVentasConIgv decimal(18, 6)
	)

	insert into @tmp
	(NombrePersonal, TipoPersonal, PorcentajeComision, CantidadVentas, TotalVentasSinIgv, TotalVentasConIgv)
	select
	p.Nombres [NombrePersonal],
	'Vendedor' [TipoPersonal],
	case when s.Nombres is null then 3 else 2 end [PorcentajeComision],
	count(1) [CantidadVentas],
	sum(fv.TotalValorVenta) [TotalVentasSinIgv],
	sum(fv.TotalImporte) [TotalVentasConIgv]
	from
	FacturaVenta fv inner join
	Cotizacion c on fv.CodigoCotizacion = c.CodigoCotizacion inner join
	Personal p on c.CodigoVendedor = p.CodigoPersonal left join
	Personal s on c.CodigoSupervisor = s.CodigoPersonal
	where
	cast(fv.FechaHoraEmision as date) between @fechaDesde and @fechaHasta and
	p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonal, '') + '%' and
	p.Nombres like '%' + isnull(@nombresPersonal, '') + '%'
	group by
	p.Nombres, s.Nombres, case when s.Nombres is null then 3 else 2 end

	insert into @tmp
	(NombrePersonal, TipoPersonal, PorcentajeComision, CantidadVentas, TotalVentasSinIgv, TotalVentasConIgv)
	select
	s.Nombres [NombrePersonal],
	'Supervisor' [TipoPersonal],
	2 [PorcentajeComision],
	count(1) [CantidadVentas],
	sum(fv.TotalValorVenta) [TotalVentasSinIgv],
	sum(fv.TotalImporte) [TotalVentasConIgv]
	from
	FacturaVenta fv inner join
	Cotizacion c on fv.CodigoCotizacion = c.CodigoCotizacion inner join
	Personal s on c.CodigoSupervisor = s.CodigoPersonal
	where
	cast(fv.FechaHoraEmision as date) between @fechaDesde and @fechaHasta and
	s.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonal, '') + '%' and
	s.Nombres like '%' + isnull(@nombresPersonal, '') + '%'
	group by
	s.Nombres

	insert into @tmp
	(NombrePersonal, TipoPersonal, PorcentajeComision, CantidadVentas, TotalVentasSinIgv, TotalVentasConIgv)
	select
	p.Nombres [NombrePersonal],
	'Vendedor' [TipoPersonal],
	case when s.Nombres is null then 3 else 2 end [PorcentajeComision],
	count(1) [CantidadVentas],
	sum(bv.TotalValorVenta) [TotalVentasSinIgv],
	sum(bv.TotalImporte) [TotalVentasConIgv]
	from
	BoletaVenta bv inner join
	Cotizacion c on bv.CodigoCotizacion = c.CodigoCotizacion inner join
	Personal p on c.CodigoVendedor = p.CodigoPersonal left join
	Personal s on c.CodigoSupervisor = s.CodigoPersonal
	where
	cast(bv.FechaHoraEmision as date) between @fechaDesde and @fechaHasta and
	p.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonal, '') + '%' and
	p.Nombres like '%' + isnull(@nombresPersonal, '') + '%'
	group by
	p.Nombres, s.Nombres, case when s.Nombres is null then 3 else 2 end

	insert into @tmp
	(NombrePersonal, TipoPersonal, PorcentajeComision, CantidadVentas, TotalVentasSinIgv, TotalVentasConIgv)
	select
	s.Nombres [NombrePersonal],
	'Supervisor' [TipoPersonal],
	2 [Comision],
	count(1) [CantidadVentas],
	sum(bv.TotalValorVenta) [TotalVentasSinIgv],
	sum(bv.TotalImporte) [TotalVentasConIgv]
	from
	BoletaVenta bv inner join
	Cotizacion c on bv.CodigoCotizacion = c.CodigoCotizacion inner join
	Personal s on c.CodigoSupervisor = s.CodigoPersonal
	where
	cast(bv.FechaHoraEmision as date) between @fechaDesde and @fechaHasta and
	s.NroDocumentoIdentidad like '%' + isnull(@nroDocumentoIdentidadPersonal, '') + '%' and
	s.Nombres like '%' + isnull(@nombresPersonal, '') + '%'
	group by
	s.Nombres

	select
	t.NombrePersonal,
	t.TipoPersonal,
	t.PorcentajeComision,
	sum(t.CantidadVentas) [CantidadVentas],
	sum(t.TotalVentasSinIgv) [TotalVentasSinIgv],
	sum(t.TotalVentasConIgv) [TotalVentasConIgv],
	cast(sum(TotalVentasSinIgv * (PorcentajeComision / 100)) as decimal(18, 6)) [TotalComision]
	from
	@tmp t
	group by
	NombrePersonal,
	TipoPersonal,
	PorcentajeComision
end
GO
/****** Object:  StoredProcedure [dbo].[usp_serie_aumentarvaloractual]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_serie_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_tipocambio_buscar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_tipocambio_buscar]
@fechaCambioDesde date,
@fechaCambioHasta date
as
begin
	select
	cast(row_number() over(order by tc.FechaCambio) as int) [Fila],
	tc.CodigoTipoCambio,
	tc.FechaCambio,
	tc.ValorCompra,
	tc.ValorVenta
	from
	TipoCambio tc
	where
	(tc.FechaCambio between @fechaCambioDesde and @fechaCambioHasta and @fechaCambioDesde is not null and @fechaCambioHasta is not null) or
	(tc.FechaCambio <= @fechaCambioHasta and @fechaCambioDesde is null and @fechaCambioHasta is not null) or
	(tc.FechaCambio >= @fechaCambioDesde and @fechaCambioHasta is null and @fechaCambioDesde is not null) or
	(@fechaCambioDesde is null and @fechaCambioHasta is null)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocambio_existe]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipocambio_existe]
@codigoTipoCambio int,
@fechaCambio date
as
begin
	select cast(count(1) as bit) from TipoCambio where FechaCambio = @fechaCambio and CodigoTipoCambio != isnull(@codigoTipoCambio, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocambio_guardar]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_tipocambio_guardar]
@codigoTipoCambio int,
@fechaCambio date,
@valorCompra decimal(18, 2),
@valorVenta decimal(18, 2),
@usuarioModi varchar(20)
as
begin
	set @codigoTipoCambio = (select CodigoTipoCambio from TipoCambio where CodigoTipoCambio = @codigoTipoCambio)

	if @codigoTipoCambio is null
	begin
		select @codigoTipoCambio = isnull(max(CodigoTipoCambio), 0) + 1 from TipoCambio

		insert into TipoCambio
		(CodigoTipoCambio, FechaCambio, ValorCompra, ValorVenta, UsuarioGraba, FechaGraba)
		values
		(@codigoTipoCambio, @fechaCambio, @valorCompra, @valorVenta, @usuarioModi, getdate())
	end
	else
	begin
		update TipoCambio set
		FechaCambio = @fechaCambio,
		ValorCompra = @valorCompra,
		ValorVenta = @valorVenta,
		UsuarioModi = @usuarioModi,
		FechaModi = getdate()
		where
		CodigoTipoCambio = @codigoTipoCambio
	end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocambio_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipocambio_obtener]
@codigoTipoCambio int
as
begin
	select
	tc.CodigoTipoCambio,
	tc.FechaCambio,
	tc.ValorCompra,
	tc.ValorVenta
	from
	TipoCambio tc
	where
	tc.CodigoTipoCambio = @codigoTipoCambio
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocambio_obtener_x_fechacambio]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipocambio_obtener_x_fechacambio]
@fechaCambio date
as
begin
	select
	tc.CodigoTipoCambio,
	tc.FechaCambio,
	tc.ValorCompra,
	tc.ValorVenta
	from
	TipoCambio tc
	where
	tc.FechaCambio = @fechaCambio
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipocomprobante_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_tipocomprobante_listar_combo]
as
begin
	select
	tc.CodigoTipoComprobante,
	tc.Nombre,
	tc.CodigoSunat
	from
	TipoComprobante tc
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tipodocumento_aumentarvaloractual]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_tipodocumentoidentidad_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_tipooperacionventa_listar_x_empresa]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_tipooperacionventa_listar_x_empresa]
@empresaId int
as
begin
	select
	tov.TipoOperacionVentaId,
	tov.Nombre,
	tov.CodigoSunat
	from
	EmpresaTipoOperacionVenta etov inner join
	TipoOperacionVenta tov on etov.TipoOperacionVentaId = tov.TipoOperacionVentaId
	where
	etov.EmpresaId = @empresaId
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_listar_combo]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_unidadmedida_listar_combo]
as
begin
	select
	um.CodigoUnidadMedida,
	um.Descripcion,
	um.CodigoSunat,
	um.FlagActivo
	from UnidadMedida um
	where
	um.FlagActivo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_unidadmedida_obtener]    Script Date: 28/01/2021 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_unidadmedida_obtener]
@codigoUnidadMedida int
as
begin
	select
	a.CodigoUnidadMedida,
	a.Descripcion,
	a.CodigoSunat,
	a.FlagActivo
	from
	UnidadMedida a
	where
	a.CodigoUnidadMedida = @codigoUnidadMedida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_usuario_buscar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_cambiar_flagactivo]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_cambiar_flagcambiarcontraseña]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_existe]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_obtener]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuario_obtener_x_nombre]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuarioperfil_eliminar_x_usuario]    Script Date: 28/01/2021 23:32:44 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_usuarioperfil_guardar]    Script Date: 28/01/2021 23:32:44 ******/
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
