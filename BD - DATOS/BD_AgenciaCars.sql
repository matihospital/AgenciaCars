CREATE TABLE PAISES
(idPais INT,
descripcion VARCHAR(50) NOT NULL,
CONSTRAINT pais_pk PRIMARY KEY (idPais))

CREATE TABLE PROVINCIAS
(idProvincia INT,
descripcion VARCHAR(50),
idPais INT NOT NULL,
CONSTRAINT provincia_pk PRIMARY KEY (idProvincia),
CONSTRAINT pais_provincias_fk FOREIGN KEY (idPais) REFERENCES PAISES(idPais))

CREATE TABLE LOCALIDADES
(idLocalidad INT,
idProvincia INT NOT NULL,
descripcion VARCHAR(50),
CONSTRAINT localidad_pk PRIMARY KEY (idLocalidad),
CONSTRAINT provincia_localidades_fk FOREIGN KEY (idProvincia) REFERENCES PROVINCIAS(idProvincia))

CREATE TABLE TIPOS_DOCUMENTOS
(idTipoDoc INT,
descripcion VARCHAR(50),
CONSTRAINT tipoDoc_pk PRIMARY KEY (idTipoDoc))

CREATE TABLE ESTADOS
(idEstado INT,
descripcion VARCHAR(50),
CONSTRAINT estado_pk PRIMARY KEY (idEstado))

CREATE TABLE CLIENTES
(idCliente INT,
idTipoDoc INT NOT NULL,
nroDoc INT NOT NULL,
apellido VARCHAR(50),
nombre VARCHAR(50),
calle VARCHAR(50),
nro INT,
telefono INT,
email VARCHAR(50),
idLocalidad INT NOT NULL,
CONSTRAINT cliente_pk PRIMARY KEY (idCliente),
CONSTRAINT localidad_clientes_fk FOREIGN KEY (idLocalidad) REFERENCES LOCALIDADES(idLocalidad),
CONSTRAINT tipoDoc_clientes_fk FOREIGN KEY (idTipoDoc) REFERENCES TIPOS_DOCUMENTOS(idTipoDoc))

CREATE TABLE PROVEEDORES
(idProveedor INT,
idTipoDoc INT NOT NULL,
nroDoc INT NOT NULL,
apellido VARCHAR(50),
nombre VARCHAR(50),
calle VARCHAR(50),
nro INT,
telefono INT,
email VARCHAR(50),
idLocalidad INT NOT NULL,
CONSTRAINT proveedor_pk PRIMARY KEY (idProveedor),
CONSTRAINT localidad_proveedores_fk FOREIGN KEY (idLocalidad) REFERENCES LOCALIDADES(idLocalidad))

CREATE TABLE VENDEDORES
(idVendedor INT,
idTipoDoc INT NOT NULL,
nroDoc INT NOT NULL,
apellido VARCHAR(50),
nombre VARCHAR(50),
calle VARCHAR(50),
nro INT,
telefono INT,
email VARCHAR(50),
idLocalidad INT NOT NULL,
idEstado INT NOT NULL,
CONSTRAINT vendedor_pk PRIMARY KEY (idVendedor),
CONSTRAINT localidad_vendedores_fk FOREIGN KEY (idLocalidad) REFERENCES LOCALIDADES(idLocalidad),
CONSTRAINT estado_proveedores_fk FOREIGN KEY (idEstado) REFERENCES ESTADOS(idEstado))

CREATE TABLE MARCAS
(idMarca INT,
descripcion VARCHAR(150),
idPais INT NOT NULL,
idEstado INT NOT NULL,
CONSTRAINT marca_pk PRIMARY KEY (idMarca),
CONSTRAINT pais_marcas_fk FOREIGN KEY (idPais) REFERENCES PAISES(idPais),
CONSTRAINT estado_marcas_fk FOREIGN KEY (idEstado) REFERENCES ESTADOS(idEstado))

CREATE TABLE MODELOS
(idModelo INT,
idMarca INT NOT NULL,
descripcion VARCHAR(150),
idEstado INT NOT NULL,
CONSTRAINT modelo_pk PRIMARY KEY (idModelo),
CONSTRAINT marca_modelo_fk FOREIGN KEY (idMarca) REFERENCES MARCAS(idMarca),
CONSTRAINT estado_modelos_fk FOREIGN KEY (idEstado) REFERENCES ESTADOS(idEstado))


CREATE TABLE PRODUCTOS
(idProducto INT,
descripcion VARCHAR(100),
anio INT,
idModelo INT,
color VARCHAR(50),
precio FLOAT,
idProveedor INT,
idPais INT,
idEstado INT,
CONSTRAINT producto_pk PRIMARY KEY (idProducto),
CONSTRAINT modelo_productos_fk FOREIGN KEY (idModelo) REFERENCES MODELOS(idModelo),
CONSTRAINT proveedor_productos_fk FOREIGN KEY (idProveedor) REFERENCES PROVEEDORES(idProveedor),
CONSTRAINT pais_productos_fk FOREIGN KEY (idPais) REFERENCES PAISES(idPais),
CONSTRAINT precio_productos_ck CHECK (precio>0),
CONSTRAINT estado_productos_fk FOREIGN KEY (idEstado) REFERENCES ESTADOS(idEstado))


CREATE TABLE FACTURAS
(idFactura INT,
tipoComprobante VARCHAR(1) NOT NULL,
ptoVenta INT,
nroFactura INT,
fecha DATE,
idCliente INT,
idProveedor INT,
total FLOAT,
descripcion VARCHAR(150),
idEstado INT NOT NULL,
CONSTRAINT factura_pk PRIMARY KEY (idFactura),
CONSTRAINT cliente_facturas_fk FOREIGN KEY (idCliente) REFERENCES CLIENTES(idCliente),
CONSTRAINT proveedor_facturas_fk FOREIGN KEY (idProveedor) REFERENCES PROVEEDORES(idProveedor),
CONSTRAINT total_facturas_ck CHECK (total > 0),
CONSTRAINT tipoComprobante_facturas_ck CHECK (tipoComprobante IN ('C','V') ),
CONSTRAINT estado_factura_fk FOREIGN KEY (idEstado) REFERENCES ESTADOS(idEstado))

CREATE TABLE FACTURASDET
(orden INT,
idFactura INT NOT NULL,
idProducto INT NOT NULL, 
cantidad INT,
precioUnitario FLOAT,
CONSTRAINT facturasdet_pk PRIMARY KEY (orden, idFactura),
CONSTRAINT factura_facturasdet_fk FOREIGN KEY (idFactura) REFERENCES FACTURAS (idFactura),
CONSTRAINT producto_facturasdet_fk FOREIGN KEY (idProducto) REFERENCES PRODUCTOS(idProducto),
CONSTRAINT cantidad_facturasdet_ck CHECK (cantidad > 0),
CONSTRAINT precioUnitario_facturasdet_ck CHECK (precioUnitario > 0))


CREATE TABLE STOCK
(idStock INT,
idProducto INT NOT NULL, 
cantidad INT,
CONSTRAINT stock_pk PRIMARY KEY (idStock),
CONSTRAINT producto_stock_fk FOREIGN KEY (idProducto) REFERENCES PRODUCTOS(idProducto),
CONSTRAINT cantidad_stock_ck CHECK (cantidad > 0))

