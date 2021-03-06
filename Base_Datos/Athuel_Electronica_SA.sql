USE [Athuel_Electronica_SA]
GO
/****** Object:  Table [dbo].[ciudad]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ciudad](
	[codCiudad] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codCiudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca](
	[codmarca] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codmarca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formularios]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[formularios](
	[codFormulario] [int] IDENTITY(1,1) NOT NULL,
	[nombreFormulario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codFormulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[turnos_trabajo]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turnos_trabajo](
	[codTurno] [bigint] IDENTITY(1,1) NOT NULL,
	[horarioInicio] [time](7) NOT NULL,
	[horarioFin] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codTurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos_productos]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_productos](
	[codTipoProd] [varchar](40) NOT NULL,
	[nombre] [varchar](40) NULL,
	[descripcion] [text] NULL,
	[tiempoGarantia] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[codTipoProd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[codTipodoc] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codTipodoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[puestos_trabajo]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puestos_trabajo](
	[codPuesto] [bigint] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[codPuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[cuit] [bigint] NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
	[fechaInicioAct] [varchar](50) NULL,
	[tipoProveedor] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[permisos]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[codFormulario] [int] NOT NULL,
	[codPuesto] [bigint] NOT NULL,
 CONSTRAINT [pk_permisos] PRIMARY KEY CLUSTERED 
(
	[codFormulario] ASC,
	[codPuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[codTipoProd] [varchar](40) NOT NULL,
	[codProd] [bigint] NOT NULL,
	[codmarca] [bigint] NOT NULL,
	[descripcion] [text] NULL,
	[modelo] [varchar](60) NULL,
	[fechaFabricacion] [varchar](50) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_Producto] PRIMARY KEY CLUSTERED 
(
	[codTipoProd] ASC,
	[codProd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contacto]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contacto](
	[codTipodoc] [bigint] NOT NULL,
	[numeroDocumento] [bigint] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[telefono] [bigint] NULL,
	[mail] [text] NULL,
 CONSTRAINT [pk_Contacto] PRIMARY KEY CLUSTERED 
(
	[codTipodoc] ASC,
	[numeroDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[barrio]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[barrio](
	[codBarrio] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codCiudad] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codBarrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[legajo] [bigint] IDENTITY(1,1) NOT NULL,
	[codTipodoc] [bigint] NOT NULL,
	[numeroDocumento] [bigint] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[calle] [text] NOT NULL,
	[nroCalle] [bigint] NOT NULL,
	[piso] [bigint] NULL,
	[dpto] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fechaIngreso] [varchar](50) NOT NULL,
	[fechaNacimiento] [varchar](50) NOT NULL,
	[codBarrio] [bigint] NOT NULL,
	[telefono] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[composicionProducto]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[composicionProducto](
	[codTipoProdFinal] [varchar](40) NOT NULL,
	[codProdFinal] [bigint] NOT NULL,
	[orden] [int] NOT NULL,
	[codTipoProdPar] [varchar](40) NOT NULL,
	[codProdPar] [bigint] NOT NULL,
	[descripcion_paso] [text] NULL,
	[fecha] [varchar](50) NOT NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_ComposicionProducto] PRIMARY KEY CLUSTERED 
(
	[codTipoProdFinal] ASC,
	[codProdFinal] ASC,
	[orden] ASC,
	[fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[productoXproveedor]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productoXproveedor](
	[codTipoProd] [varchar](40) NOT NULL,
	[cuit] [bigint] NOT NULL,
	[codTipodocCont] [bigint] NOT NULL,
	[numeroDocumentoCont] [bigint] NOT NULL,
 CONSTRAINT [pk_productoXproveedor] PRIMARY KEY CLUSTERED 
(
	[codTipoProd] ASC,
	[cuit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[legajo] [bigint] NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[pregunta_control] [varchar](80) NULL,
	[respuesta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[planificacion]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planificacion](
	[codigo] [bigint] IDENTITY(1,1) NOT NULL,
	[legajo] [bigint] NOT NULL,
	[codturno] [bigint] NOT NULL,
	[semana] [bigint] NOT NULL,
	[año] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleadoXpuesto]    Script Date: 11/03/2018 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleadoXpuesto](
	[legajo] [bigint] NOT NULL,
	[codPuesto] [bigint] NOT NULL,
	[fechaDesde] [varchar](50) NOT NULL,
	[legajoJefe] [bigint] NULL,
 CONSTRAINT [pk_empleadoXpuesto] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC,
	[codPuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [fk_permisos_formulario]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[permisos]  WITH CHECK ADD  CONSTRAINT [fk_permisos_formulario] FOREIGN KEY([codFormulario])
REFERENCES [dbo].[formularios] ([codFormulario])
GO
ALTER TABLE [dbo].[permisos] CHECK CONSTRAINT [fk_permisos_formulario]
GO
/****** Object:  ForeignKey [fk_permisos_puestos_trabajo]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[permisos]  WITH CHECK ADD  CONSTRAINT [fk_permisos_puestos_trabajo] FOREIGN KEY([codPuesto])
REFERENCES [dbo].[puestos_trabajo] ([codPuesto])
GO
ALTER TABLE [dbo].[permisos] CHECK CONSTRAINT [fk_permisos_puestos_trabajo]
GO
/****** Object:  ForeignKey [fk_Producto_codigo_marca]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [fk_Producto_codigo_marca] FOREIGN KEY([codmarca])
REFERENCES [dbo].[marca] ([codmarca])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [fk_Producto_codigo_marca]
GO
/****** Object:  ForeignKey [fk_Producto_Codigo_producto]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [fk_Producto_Codigo_producto] FOREIGN KEY([codTipoProd])
REFERENCES [dbo].[tipos_productos] ([codTipoProd])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [fk_Producto_Codigo_producto]
GO
/****** Object:  ForeignKey [fk_Contacto_Codigo_Documento]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[contacto]  WITH CHECK ADD  CONSTRAINT [fk_Contacto_Codigo_Documento] FOREIGN KEY([codTipodoc])
REFERENCES [dbo].[tipo_documento] ([codTipodoc])
GO
ALTER TABLE [dbo].[contacto] CHECK CONSTRAINT [fk_Contacto_Codigo_Documento]
GO
/****** Object:  ForeignKey [fk_barrio_codigo_marca]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[barrio]  WITH CHECK ADD  CONSTRAINT [fk_barrio_codigo_marca] FOREIGN KEY([codCiudad])
REFERENCES [dbo].[ciudad] ([codCiudad])
GO
ALTER TABLE [dbo].[barrio] CHECK CONSTRAINT [fk_barrio_codigo_marca]
GO
/****** Object:  ForeignKey [fk_empleado_Codigo_Documento]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [fk_empleado_Codigo_Documento] FOREIGN KEY([codTipodoc])
REFERENCES [dbo].[tipo_documento] ([codTipodoc])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [fk_empleado_Codigo_Documento]
GO
/****** Object:  ForeignKey [fk_empleado_codigo_marca]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [fk_empleado_codigo_marca] FOREIGN KEY([codBarrio])
REFERENCES [dbo].[barrio] ([codBarrio])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [fk_empleado_codigo_marca]
GO
/****** Object:  ForeignKey [fk_composicionProducto_producto_final]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[composicionProducto]  WITH CHECK ADD  CONSTRAINT [fk_composicionProducto_producto_final] FOREIGN KEY([codTipoProdFinal], [codProdFinal])
REFERENCES [dbo].[producto] ([codTipoProd], [codProd])
GO
ALTER TABLE [dbo].[composicionProducto] CHECK CONSTRAINT [fk_composicionProducto_producto_final]
GO
/****** Object:  ForeignKey [fk_composicionProducto_producto_parcial]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[composicionProducto]  WITH CHECK ADD  CONSTRAINT [fk_composicionProducto_producto_parcial] FOREIGN KEY([codTipoProdPar], [codProdPar])
REFERENCES [dbo].[producto] ([codTipoProd], [codProd])
GO
ALTER TABLE [dbo].[composicionProducto] CHECK CONSTRAINT [fk_composicionProducto_producto_parcial]
GO
/****** Object:  ForeignKey [fk_productoXproveedor_Contacto]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[productoXproveedor]  WITH CHECK ADD  CONSTRAINT [fk_productoXproveedor_Contacto] FOREIGN KEY([codTipodocCont], [numeroDocumentoCont])
REFERENCES [dbo].[contacto] ([codTipodoc], [numeroDocumento])
GO
ALTER TABLE [dbo].[productoXproveedor] CHECK CONSTRAINT [fk_productoXproveedor_Contacto]
GO
/****** Object:  ForeignKey [fk_productoXproveedor_Producto]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[productoXproveedor]  WITH CHECK ADD  CONSTRAINT [fk_productoXproveedor_Producto] FOREIGN KEY([codTipoProd])
REFERENCES [dbo].[tipos_productos] ([codTipoProd])
GO
ALTER TABLE [dbo].[productoXproveedor] CHECK CONSTRAINT [fk_productoXproveedor_Producto]
GO
/****** Object:  ForeignKey [fk_productoXproveedor_Proveedor]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[productoXproveedor]  WITH CHECK ADD  CONSTRAINT [fk_productoXproveedor_Proveedor] FOREIGN KEY([cuit])
REFERENCES [dbo].[proveedor] ([cuit])
GO
ALTER TABLE [dbo].[productoXproveedor] CHECK CONSTRAINT [fk_productoXproveedor_Proveedor]
GO
/****** Object:  ForeignKey [fk_usuario_legajo]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_usuario_legajo] FOREIGN KEY([legajo])
REFERENCES [dbo].[empleado] ([legajo])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_usuario_legajo]
GO
/****** Object:  ForeignKey [fk_planificacion_codigo_turno]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[planificacion]  WITH CHECK ADD  CONSTRAINT [fk_planificacion_codigo_turno] FOREIGN KEY([codturno])
REFERENCES [dbo].[turnos_trabajo] ([codTurno])
GO
ALTER TABLE [dbo].[planificacion] CHECK CONSTRAINT [fk_planificacion_codigo_turno]
GO
/****** Object:  ForeignKey [fk_planificacion_legajo]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[planificacion]  WITH CHECK ADD  CONSTRAINT [fk_planificacion_legajo] FOREIGN KEY([legajo])
REFERENCES [dbo].[empleado] ([legajo])
GO
ALTER TABLE [dbo].[planificacion] CHECK CONSTRAINT [fk_planificacion_legajo]
GO
/****** Object:  ForeignKey [fk_empleadoXpuesto_codigo_puesto]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[empleadoXpuesto]  WITH CHECK ADD  CONSTRAINT [fk_empleadoXpuesto_codigo_puesto] FOREIGN KEY([codPuesto])
REFERENCES [dbo].[puestos_trabajo] ([codPuesto])
GO
ALTER TABLE [dbo].[empleadoXpuesto] CHECK CONSTRAINT [fk_empleadoXpuesto_codigo_puesto]
GO
/****** Object:  ForeignKey [fk_empleadoXpuesto_legajo]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[empleadoXpuesto]  WITH CHECK ADD  CONSTRAINT [fk_empleadoXpuesto_legajo] FOREIGN KEY([legajo])
REFERENCES [dbo].[empleado] ([legajo])
GO
ALTER TABLE [dbo].[empleadoXpuesto] CHECK CONSTRAINT [fk_empleadoXpuesto_legajo]
GO
/****** Object:  ForeignKey [fk_empleadoXpuesto_legajo_Jefe]    Script Date: 11/03/2018 19:12:05 ******/
ALTER TABLE [dbo].[empleadoXpuesto]  WITH CHECK ADD  CONSTRAINT [fk_empleadoXpuesto_legajo_Jefe] FOREIGN KEY([legajoJefe])
REFERENCES [dbo].[empleado] ([legajo])
GO
ALTER TABLE [dbo].[empleadoXpuesto] CHECK CONSTRAINT [fk_empleadoXpuesto_legajo_Jefe]
GO
