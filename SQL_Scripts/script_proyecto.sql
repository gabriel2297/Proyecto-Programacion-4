/* CREACION DE BASE DE DATOS */
USE MASTER
GO

CREATE DATABASE PROIV
ON PRIMARY (NAME = 'PROIV', FILENAME = 'C:\BD_Proyecto\PROIV.mdf', size=1000MB, FILEGROWTH=25%)
LOG ON (NAME = 'PROIVLOG', FILENAME = 'C:\BD_Proyecto\PROIVLOG.ldf', size=500MB, FILEGROWTH=25%)
GO

USE PROIV
GO

/* CREACION DE TABLAS */
CREATE TABLE EXTRAS (
	ID_EXTRA INT IDENTITY(1,1),
	NOMBRE_EXTRA VARCHAR(50),
	PRECIO_EXTRA MONEY
	PRIMARY KEY (ID_EXTRA)
);

CREATE TABLE CATEGORIAS (
	ID_CATEGORIA INT IDENTITY(1,1),
	NOMBRE_CATEGORIA VARCHAR(50),
	DESCRIPCION VARCHAR(50)
	PRIMARY KEY (ID_CATEGORIA)
);

CREATE TABLE PRODUCTOS (
	ID_PRODUCTO INT IDENTITY(1,1),
	NOMBRE_PRODUCTO VARCHAR(40),
	PRECIO_PRODUCTO MONEY,
	CANTIDAD_VENTAS INT,
	ID_EXTRA INT,
	ID_CATEGORIA INT,
	PRIMARY KEY (ID_PRODUCTO),
	FOREIGN KEY (ID_EXTRA) REFERENCES EXTRAS(ID_EXTRA),
	FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIAS(ID_CATEGORIA)
);

CREATE TABLE MESEROS (
	ID_MESERO INT IDENTITY(1,1),
	NOMBRE_MESERO VARCHAR(50),
	PRIMARY KEY (ID_MESERO)
);

CREATE TABLE ESTADO_MESAS(
	ID_ESTADO INT IDENTITY(1,1),
	ESTADO VARCHAR(20) UNIQUE,
	PRIMARY KEY (ID_ESTADO)
);

CREATE TABLE MESAS (
	ID_MESA INT IDENTITY(1,1),
	CAPACIDAD INT,
	ID_ESTADO INT,
    PRIMARY KEY (ID_MESA),
	FOREIGN KEY (ID_ESTADO) REFERENCES ESTADO_MESAS(ID_ESTADO)
);

/* ver cual es el nombre del constraint del foreign key de id_producto para la tabla ordenes con el siguiente comando */

select CONSTRAINT_NAME
from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
where TABLE_NAME = 'ORDENES';

CREATE TABLE ORDENES (
	ID_ORDEN INT IDENTITY(1,1), 
	NOMBRE_ORDEN VARCHAR(50),
	ID_MESERO INT,
	ID_MESA INT,
	PRIMARY KEY (ID_ORDEN),
	FOREIGN KEY (ID_MESERO) REFERENCES MESEROS(ID_MESERO),
	FOREIGN KEY (ID_MESA) REFERENCES MESAS(ID_MESA)
);


/* eliminar ese constraint con el comando de abajo, el FK_ORDENES_ID_PROD se saca del comando de arriba (el select) */
ALTER TABLE ORDENES DROP CONSTRAINT FK__ORDENES__ID_PROD__46E78A0C;
ALTER TABLE ORDENES DROP COLUMN ID_PRODUCTO;
ALTER TABLE ORDENES DROP COLUMN CANTIDAD_PRODUCTOS;

CREATE TABLE PRODUCTO_X_ORDEN (
	ID_PRODUCTO INT NOT NULL, 
	ID_ORDEN INT NOT NULL,
	CANTIDAD_PRODUCTO INT NOT NULL,
	PRIMARY KEY (ID_PRODUCTO, ID_ORDEN),
	FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTOS(ID_PRODUCTO),
	FOREIGN KEY (ID_ORDEN) REFERENCES ORDENES(ID_ORDEN)
);

CREATE TABLE FACTURAS (
	ID_FACTURA INT IDENTITY(1,1),
 	PRECIO_UNIDAD MONEY,
	PRECIO_TOTAL MONEY,
	METODO_PAGO VARCHAR(20),
	MENSAJE VARCHAR(60),
	NOMBRE_CAJERO VARCHAR(50),
	TOTAL_CANCELADO MONEY,
	VUELTO AS PRECIO_TOTAL-TOTAL_CANCELADO,
	FECHA DATE,
	ID_ORDEN INT,
	PRIMARY KEY (ID_FACTURA),
	FOREIGN KEY (ID_ORDEN) REFERENCES ORDENES(ID_ORDEN)
);



/* INSERTAR DATOS DE PRUEBA */
	
-- extras
INSERT INTO extras (nombre_extra, precio_extra) VALUES('Extra queso', 100);
INSERT INTO extras (nombre_extra, precio_extra) VALUES('Extra jamon', 300);
INSERT INTO extras (nombre_extra, precio_extra) VALUES('Extra huevo', 400);
INSERT INTO extras (nombre_extra, precio_extra) VALUES('Extra tocineta', 500);

-- estados de mesa
INSERT INTO estado_mesas (estado) VALUES ('Reservada');
INSERT INTO estado_mesas (estado) VALUES ('Disponible');

-- mesas
INSERT INTO mesas (capacidad, id_estado) VALUES (5, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (7, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (4, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (2, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (2, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (4, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (5, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (8, 1);
INSERT INTO mesas (capacidad, id_estado) VALUES (5, 1);

-- meseros
INSERT INTO meseros (nombre_mesero) VALUES ('Juan Rodriguez');
INSERT INTO meseros (nombre_mesero) VALUES ('Max Hernandez');
INSERT INTO meseros (nombre_mesero) VALUES ('Ernesto Valverde');
INSERT INTO meseros (nombre_mesero) VALUES ('Lucia Villanueva');
INSERT INTO meseros (nombre_mesero) VALUES ('Andrea Ramirez');

-- productos
INSERT INTO productos (nombre_producto, precio_producto) VALUES ('Arroz con pollo', 1000);
INSERT INTO productos (nombre_producto, precio_producto) VALUES ('Gallo pinto', 1500);
INSERT INTO productos (nombre_producto, precio_producto) VALUES ('Arroz con leche', 2000);
INSERT INTO productos (nombre_producto, precio_producto) VALUES ('Pollo empanizado', 2500);
INSERT INTO productos (nombre_producto, precio_producto) VALUES ('Salmon', 4000);

-- ordenes
INSERT INTO ordenes (nombre_orden, id_mesero, id_mesa) VALUES ('Gabriel', 1, 1);
INSERT INTO ordenes (nombre_orden, id_mesero, id_mesa) VALUES ('Juan', 2, 3);
INSERT INTO ordenes (nombre_orden, id_mesero, id_mesa) VALUES ('Luis', 3, 2);
INSERT INTO ordenes (nombre_orden, id_mesero, id_mesa) VALUES ('Pedro', 4, 5);

-- productos en la orden
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (4, 1, 3);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (8, 1, 1);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (6, 1, 3);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (5, 3, 3);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (6, 3, 1);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (7, 3, 1);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (1, 2, 2);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (2, 2, 1);
INSERT INTO producto_x_orden (id_producto, id_orden, cantidad_producto) VALUES (6, 2, 3);


--FACTURACION
INSERT INTO FACTURAS (PRECIO_UNIDAD,PRECIO_TOTAL,METODO_PAGO,MENSAJE,NOMBRE_CAJERO,TOTAL_CANCELADO,FECHA,ID_ORDEN) 
VALUES(10000,10000,'Efectivo','Gracias por su compra','Andrea Ramirez',12000,GETDATE(),1);
INSERT INTO FACTURAS (PRECIO_UNIDAD,PRECIO_TOTAL,METODO_PAGO,MENSAJE,NOMBRE_CAJERO,TOTAL_CANCELADO,FECHA,ID_ORDEN) 
VALUES(20000,20000,'Tarjeta de Credito','Gracias por su compra','Randall Herrera',20000,GETDATE(),1);
