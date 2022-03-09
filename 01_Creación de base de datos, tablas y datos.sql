DROP DATABASE IF EXISTS DbJorgeMarco;
CREATE DATABASE DbJorgeMarco
GO
USE DbJorgeMarco;


CREATE TABLE Pais (
  Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Activo BIT NOT NULL
);

CREATE TABLE Tipo (
  Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Activo BIT NOT NULL
);

CREATE TABLE Cliente (
  Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  IdPais INT FOREIGN KEY REFERENCES Pais(Id) NOT NULL,
  IdTipo INT FOREIGN KEY REFERENCES Tipo(Id) NOT NULL,	--Este campo lo hago Entero para poder darle escalabilidad a futuro, podría ser un BIT tranquilamente.
  Activo BIT NOT NULL
);


INSERT INTO Pais VALUES('Estados Unidos', 1);
INSERT INTO Pais VALUES('Puerto Rico', 1);
INSERT INTO Pais VALUES('Otros', 1);

INSERT INTO Tipo VALUES ('Individuo', 1);
INSERT INTO Tipo VALUES ('Compañía', 1);