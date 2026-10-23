CREATE DATABASE Venta_Vehiculos;
GO

USE Venta_Vehiculos;
GO

-- Tabla Cliente

CREATE TABLE Cliente (
    Cliente_Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, -- PK
    Nombre VARCHAR(20) NOT NULL,
    Apellido1 VARCHAR(20) NOT NULL,
    Apellido2 VARCHAR(20) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    FechaRegistro DATETIME NOT NULL,
    Estado BIT NOT NULL
);
GO

-- Catalogo Marca

CREATE TABLE Marca (
    Marca_Id INT IDENTITY(1,1) PRIMARY KEY, -- PK
    Nombre VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Catalogo Tipo Vehiculo

CREATE TABLE Tipo_Vehiculo (
    Tipo_Vehiculo_Id INT IDENTITY(1,1) PRIMARY KEY, -- PK
    Nombre VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Tabla Vehiculo

CREATE TABLE Vehiculo (
    Vehiculo_Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    Marca_Id INT NOT NULL, -- FK
    Tipo_Vehiculo_Id INT NOT NULL, -- FK
    Modelo VARCHAR(20) NOT NULL,
    Anio SMALLINT NOT NULL, -- SMALLINT permite guardar directamente el año, por ejemplo 2022
    Kilometraje INT NOT NULL,
    Precio DECIMAL(12,2) NOT NULL,
    Descripcion VARCHAR(300) NOT NULL,

    FOREIGN KEY (Marca_Id)
        REFERENCES Marca(Marca_Id),

    FOREIGN KEY (Tipo_Vehiculo_Id)
        REFERENCES Tipo_Vehiculo(Tipo_Vehiculo_Id)
);
GO

-- Tabla Publicacion

CREATE TABLE Publicacion (
    Publicacion_Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    Usuario_Id INT NOT NULL, -- FK
    Vehiculo_Id INT NOT NULL, -- FK
    Fecha_Publicacion DATETIME NOT NULL,
    Estado_Publicacion BIT NOT NULL,
    Titulo VARCHAR(50) NOT NULL,

    FOREIGN KEY (Usuario_Id)
        REFERENCES Cliente(Cliente_Id),

    FOREIGN KEY (Vehiculo_Id)
        REFERENCES Vehiculo(Vehiculo_Id)
);
GO

-- Tabla Fotografias

CREATE TABLE Fotografias (
    Fotografia_Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    Publicacion_Id INT NOT NULL, -- FK
    Ruta_Fotografia VARCHAR(500) NOT NULL,

    FOREIGN KEY (Publicacion_Id)
        REFERENCES Publicacion(Publicacion_Id)
);
GO

-- Consulta de confirmacion de datos

SELECT * FROM Cliente;
SELECT * FROM Marca;
SELECT * FROM Tipo_Vehiculo;
SELECT * FROM Vehiculo;
SELECT * FROM Publicacion;
SELECT * FROM Fotografias;