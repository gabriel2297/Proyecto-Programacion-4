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

CREATE TABLE ORDENES (
	ID_ORDEN INT IDENTITY(1,1), 
	NOMBRE_ORDEN VARCHAR(50),
	CANTIDAD_PRODUCTOS INT,
	ID_PRODUCTO INT,
	ID_MESERO INT,
	ID_MESA INT,
	PRIMARY KEY (ID_ORDEN),
	FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTOS(ID_PRODUCTO),
	FOREIGN KEY (ID_MESERO) REFERENCES MESEROS(ID_MESERO),
	FOREIGN KEY (ID_MESA) REFERENCES MESAS(ID_MESA)
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