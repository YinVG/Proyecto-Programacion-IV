CREATE DATABASE Venta_Vehiculos;
GO

USE Venta_Vehiculos;
GO

-- Tabla Cliente

CREATE TABLE Cliente (
    ClienteId INT PRIMARY KEY IDENTITY(1,1) NOT NULL, -- PK
    RolId INT NOT NULL, -- FK
    Nombre VARCHAR(20) NOT NULL,
    Apellido1 VARCHAR(20) NOT NULL,
    Apellido2 VARCHAR(20) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    FechaRegistro DATETIME NOT NULL,
    Estado BIT NOT NULL,

    FOREIGN KEY (RolId) 
        REFERENCES Rol(RolId)
);
GO

-- Catalogo Marca

CREATE TABLE Marca (
    MarcaId INT IDENTITY(1,1) PRIMARY KEY, -- PK
    Nombre VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Catalogo Tipo Vehiculo

CREATE TABLE TipoVehiculo (
    TipoVehiculoId INT IDENTITY(1,1) PRIMARY KEY, -- PK
    Nombre VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Catalogo Rol
CREATE TABLE Rol (
    RolId INT IDENTITY(1,1) PRIMARY KEY, --PK
    Descripcion VARCHAR(50) NOT NULL UNIQUE
);
GO


-- Tabla Vehiculo

CREATE TABLE Vehiculo (
    VehiculoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    MarcaId INT NOT NULL, -- FK
    TipoVehiculoId INT NOT NULL, -- FK
    Modelo VARCHAR(20) NOT NULL,
    Anio SMALLINT NOT NULL, -- SMALLINT permite guardar directamente el año, por ejemplo 2022
    Kilometraje INT NOT NULL,
    Precio DECIMAL(12,2) NOT NULL,
    Descripcion VARCHAR(300) NOT NULL,

    FOREIGN KEY (MarcaId)
        REFERENCES Marca(MarcaId),

    FOREIGN KEY (TipoVehiculoId)
        REFERENCES TipoVehiculo(TipoVehiculoId)
);
GO

-- Tabla Publicacion

CREATE TABLE Publicacion (
    PublicacionId INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    ClienteId INT NOT NULL, -- FK
    VehiculoId INT NOT NULL, -- FK
    FechaPublicacion DATETIME NOT NULL,
    EstadoPublicacion BIT NOT NULL,
    Titulo VARCHAR(50) NOT NULL,

    FOREIGN KEY (ClienteId)
        REFERENCES Cliente(ClienteId),

    FOREIGN KEY (VehiculoId)
        REFERENCES Vehiculo(VehiculoId)
);
GO

-- Tabla Fotografia

CREATE TABLE Fotografia (
    FotografiaId INT IDENTITY(1,1) PRIMARY KEY NOT NULL, -- PK
    PublicacionId INT NOT NULL, -- FK
    RutaFotografia VARCHAR(500) NOT NULL,

    FOREIGN KEY (PublicacionId)
        REFERENCES Publicacion(PublicacionId)
);
GO

-- Consulta de confirmacion de datos

SELECT * FROM Cliente;
SELECT * FROM Marca;
SELECT * FROM TipoVehiculo;
SELECT * FROM Vehiculo;
SELECT * FROM Publicacion;
SELECT * FROM Fotografia;
