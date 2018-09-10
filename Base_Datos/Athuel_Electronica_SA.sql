-- La base de datos de debe crear con el nombre del archivo para qeu funcione: Athuel_Electronica_SA
use Athuel_Electronica_SA

create table tipos_productos 
(
codTipoProd varchar (40) primary key not null,
nombre varchar (40),
descripcion text,
tiempoGarantia bigint

)




create table proveedor
(
cuit bigint primary key not null,
rasonSocial varchar (50) not null,
fechaInicioAct datetime,
tipoProvedor char (1) not null
)




create table ciudad
(
codCiudad bigint identity (1,1) primary key not null,
nombre varchar (50) not null
)




create table marca
(
codmarca bigint identity (1,1) primary key not null,
nombre varchar (50) not null
)




create table tipo_documento
(
codTipodoc bigint identity (1,1) primary key not null,
nombre varchar (30) not null
)



create table puestos_trabajo
(
codPuesto bigint primary key not null,
nombre varchar (50) not null,
descripcion text
)



create table turnos_trabajo
(
codTurno bigint primary key not null,
horarioInicio time not null,
horarioFin time not null
)




create table producto
(
codTipoProd varchar (40) not null,
codProd bigint not null,
codmarca bigint not null,
descripcion text,
modelo varchar (60),
fechaFabricacion datetime,
cantidad int,

CONSTRAINT fk_Producto_Codigo_producto FOREIGN KEY (codTipoProd) REFERENCES tipos_productos(codTipoProd),
CONSTRAINT fk_Producto_codigo_marca FOREIGN KEY (codmarca) REFERENCES marca(codmarca)
)

ALTER TABLE producto ADD CONSTRAINT pk_Producto PRIMARY KEY (codTipoProd,codProd)




create table contacto
(
codTipodoc bigint not null,
numeroDocumento bigint not null,
nombre varchar (50) not null,
apellido varchar (50) not null,
telefono bigint,
mail text,

CONSTRAINT fk_Contacto_Codigo_Documento FOREIGN KEY (codTipodoc) REFERENCES tipo_documento(codTipodoc)
)

ALTER TABLE contacto ADD CONSTRAINT pk_Contacto PRIMARY KEY (codTipodoc,numeroDocumento)




create table productoXproveedor
(
codTipoProd varchar (40) not null,
codProd bigint not null,
cuit bigint not null,
codTipodocCont bigint not null,
numeroDocumentoCont bigint not null,

CONSTRAINT fk_productoXproveedor_Producto FOREIGN KEY (codTipoProd,codProd) REFERENCES producto(codTipoProd,codProd),
CONSTRAINT fk_productoXproveedor_Proveedor FOREIGN KEY (cuit) REFERENCES proveedor(cuit),
CONSTRAINT fk_productoXproveedor_Contacto FOREIGN KEY (codTipodocCont,numeroDocumentoCont) REFERENCES contacto(codTipodoc,numeroDocumento)
)

ALTER TABLE productoXproveedor ADD CONSTRAINT pk_productoXproveedor PRIMARY KEY (codTipoProd,codProd,cuit)





create table composicionProducto
(
codTipoProdFinal varchar (40) not null,
codProdFinal bigint not null,
orden int not null,
codTipoProdPar varchar (40) not null,
codProdPar bigint not null,
descripcion_paso text,
fecha datetime not null,
cantidad int,

CONSTRAINT fk_composicionProducto_producto_parcial FOREIGN KEY (codTipoProdPar,codProdPar) REFERENCES producto(codTipoProd,codProd),
CONSTRAINT fk_composicionProducto_producto_final FOREIGN KEY (codTipoProdFinal,codProdFinal) REFERENCES producto(codTipoProd,codProd)
)

ALTER TABLE composicionProducto ADD CONSTRAINT pk_ComposicionProducto PRIMARY KEY (codTipoProdPar,codProdPar,codTipoProdFinal,codProdFinal,orden)






create table barrio
(
codBarrio bigint identity (1,1) primary key not null,
nombre varchar (50) not null,
codCiudad bigint not null,

CONSTRAINT fk_barrio_codigo_marca FOREIGN KEY (codCiudad) REFERENCES ciudad(codCiudad)
)





create table empleado
(
legajo bigint identity (1,1) primary key not null,
codTipodoc bigint not null,
numeroDocumento bigint not null,
nombre varchar (50) not null,
apellido varchar (50) not null,
calle text not null,
fechaIngreso datetime not null,
fechaNacimiento datetime not null,
codBarrio bigint not null,

CONSTRAINT fk_empleado_codigo_marca FOREIGN KEY (codBarrio) REFERENCES barrio(codBarrio),
CONSTRAINT fk_empleado_Codigo_Documento FOREIGN KEY (codTipodoc) REFERENCES tipo_documento(codTipodoc)
)


create table telefonoXempleado
(
codArea bigint not null,
numero bigint not null,
legajo bigint not null,
estado char

CONSTRAINT fk_telefonoXempleado_legajo FOREIGN KEY (legajo) REFERENCES empleado(legajo)
)

ALTER TABLE telefonoXempleado ADD CONSTRAINT pk_telefonoXempleado PRIMARY KEY (codArea,numero,legajo)




create table empleadoXpuesto
(
legajo bigint not null,
codPuesto bigint not null,
fechaDesde datetime not null,
legajoJefe bigint,

CONSTRAINT fk_empleadoXpeusto_legajo FOREIGN KEY (legajo) REFERENCES empleado(legajo),
CONSTRAINT fk_empleadoXpeusto_legajo_Jefe FOREIGN KEY (legajoJefe) REFERENCES empleado(legajo),
CONSTRAINT fk_empleadoXpeusto_codigo_puesto FOREIGN KEY (codPuesto) REFERENCES puestos_trabajo(codPuesto)
)

ALTER TABLE empleadoXpuesto ADD CONSTRAINT pk_empleadoXpuesto PRIMARY KEY (legajo,codPuesto)





create table usuario
(
legajo bigint primary key not null,
nombreUsuario varchar(50) not null,
contrase�a varchar (50) not null,

CONSTRAINT fk_usuario_legajo FOREIGN KEY (legajo) REFERENCES empleado(legajo)
)




create table planificacion
(
legajo bigint not null,
codturno bigint not null,
semana bigint not null,
a�o bigint not null,

CONSTRAINT fk_planificacion_legajo FOREIGN KEY (legajo) REFERENCES empleado(legajo),
CONSTRAINT fk_planificacion_codigo_turno FOREIGN KEY (codturno) REFERENCES turnos_trabajo(codturno)
)

ALTER TABLE planificacion ADD CONSTRAINT pk_planificacion PRIMARY KEY (legajo,codturno)




CREATE TABLE formularios
(
codFormulario int IDENTITY(1,1) primary key NOT NULL,
nombreFormulario varchar(50) NOT NULL
)





CREATE TABLE perfiles
(
codPerfil int IDENTITY(1,1) primary key NOT NULL,
nombrePerfil varchar(50) NOT NULL
)




CREATE TABLE permisos
(
codFormulario int NOT NULL,
codPerfil int NOT NULL,

CONSTRAINT fk_permisos_formulario FOREIGN KEY (codFormulario) REFERENCES formularios (codFormulario),
CONSTRAINT fk_permisos_perfil FOREIGN KEY (codPerfil) REFERENCES perfiles(codPerfil)
)

ALTER TABLE permisos ADD CONSTRAINT pk_permisos PRIMARY KEY (codFormulario,codPerfil)





-- Carga de Datos INSERT {Tabla} (nombre columnas) VALUES (datos columnas)


INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A001', 'Heladera', NULL, 12)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A002', 'Microondas', NULL, 8)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A003', 'TV LED Smart', NULL, 18)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A004', 'Tel�fono Celular', NULL, 6)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A005', 'Aire Acondicionado', NULL, 12)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A006', 'Notebook', NULL, 10)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A007', 'Tablets ', NULL, 5)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A008', 'Netbook', NULL, 10)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A009', 'Televisores LCD', NULL, 24)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A010', 'Monitores LED', NULL, 18)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A011', 'Computadoras', NULL, 10)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A012', 'C�maras digitales', NULL, 8)
INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia) VALUES ('A013', 'Decodificadores de TV', NULL, 3)


INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30684125792,'Samsung S.A.', 1938-03-01,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30714731382,'Lenovo S.R.L.', 1984-11-01,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30708278552,'Bangh� S.A.', 2006-04-03,'N')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30540088213,'Garbarino S.A.', 1951-01-01,'N')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30503612891,'BGH S.A.', 1913-01-01,'N')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30642617555,'Newsan S.A.', 1991-09-18,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30679928879,'Sony S.A.', 1946-05-07,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30714809373,'HP S.R.L.', 1939-04-07,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30525649691,'Kodak S.A.',1889-03-17,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30711247986,'Motorola S.A.', 1928-09-25,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30522041153,'Alcatel S.A.', 2004-08-12,'E')
INSERT proveedor (cuit, rasonSocial, fechaInicioAct, tipoProvedor) VALUES (30685889397,'DirecTV S.A.', 1990-02-20,'E')


INSERT ciudad (nombre) VALUES ('Ushuaia')
INSERT ciudad (nombre) VALUES ('R�o Grande')
INSERT ciudad (nombre) VALUES ('Tolhuin')
INSERT ciudad (nombre) VALUES ('San Sebastian')



INSERT marca (nombre) VALUES ('Samsung')
INSERT marca (nombre) VALUES ('Motorola')
INSERT marca (nombre) VALUES ('Alcatel')
INSERT marca (nombre) VALUES ('Kodak')
INSERT marca (nombre) VALUES ('Sony')
INSERT marca (nombre) VALUES ('HP')
INSERT marca (nombre) VALUES ('Atma')
INSERT marca (nombre) VALUES ('Sanyo')
INSERT marca (nombre) VALUES ('Philco')
INSERT marca (nombre) VALUES ('Noblex')
INSERT marca (nombre) VALUES ('BGH')
INSERT marca (nombre) VALUES ('Tradarsa')
INSERT marca (nombre) VALUES ('Siam')
INSERT marca (nombre) VALUES ('Sansei')
INSERT marca (nombre) VALUES ('NewSanfood')
INSERT marca (nombre) VALUES ('Drean')
INSERT marca (nombre) VALUES ('Huawei')
INSERT marca (nombre) VALUES ('Philips')
INSERT marca (nombre) VALUES ('Electrolux')
INSERT marca (nombre) VALUES ('Whirlpool')
INSERT marca (nombre) VALUES ('Gafa')
INSERT marca (nombre) VALUES ('Bangh�')
INSERT marca (nombre) VALUES ('Lenovo')


INSERT tipo_documento (nombre) VALUES ('DNI')
INSERT tipo_documento (nombre) VALUES ('Libretas de Enrolamiento')
INSERT tipo_documento (nombre) VALUES ('Libretas C�vicas')


INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (1, 'Operario linea de Ensamblaje', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (2, 'Gerente de piso', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (3, 'Gerente de Linea', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (4, 'Gerente General', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (5, 'Fabricante', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (6, 'Encargado de Stock', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (7, 'Acomodadores', NULL)
INSERT puestos_trabajo (codPuesto, nombre, descripcion) VALUES (8, 'Guardia', NULL)


INSERT turnos_trabajo (codTurno, horarioInicio, horarioFin) VALUES (1, '06:00:00', '14:00:00')
INSERT turnos_trabajo (codTurno, horarioInicio, horarioFin) VALUES (2, '14:00:00', '22:00:00')

INSERT barrio(nombre, codCiudad) VALUES ('R�o Pipo', 1)
INSERT barrio(nombre, codCiudad) VALUES ('Bella Vista', 1)
INSERT barrio(nombre, codCiudad) VALUES ('General Manuel Belgrano', 1)
INSERT barrio(nombre, codCiudad) VALUES ('Los Andes', 1)
INSERT barrio(nombre, codCiudad) VALUES ('Monte Gallinero', 1)
INSERT barrio(nombre, codCiudad) VALUES ('Cabo Pe�a', 2)
INSERT barrio(nombre, codCiudad) VALUES ('Don Bosco', 2)
INSERT barrio(nombre, codCiudad) VALUES ('15 de Octubre', 2)
INSERT barrio(nombre, codCiudad) VALUES ('Alem', 2)
INSERT barrio(nombre, codCiudad) VALUES ('Almafuerte', 2)