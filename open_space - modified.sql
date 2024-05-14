USE master; -- Cambia al contexto de la base de datos maestra antes de ejecutar la instrucción de eliminación de la base de datos
GO

IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'open_space_comarcal')
BEGIN
    ALTER DATABASE open_space_comarcal SET SINGLE_USER WITH ROLLBACK IMMEDIATE; -- Pone la base de datos en modo de usuario único para cerrar todas las conexiones
    DROP DATABASE open_space_comarcal; -- Elimina la base de datos si existe
END
GO

CREATE DATABASE open_space_comarcal; -- Crea la base de datos open_space
GO

USE open_space_comarcal; -- Cambia al contexto de la base de datos open_space
GO

CREATE TABLE empresa (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	cif VARCHAR(20) NOT NULL,
    siglas VARCHAR(10) NOT NULL,
    nombre VARCHAR(70) NOT NULL,
	telefono VARCHAR(20),
	email VARCHAR(70),
	persona_contacto VARCHAR(70),
	notas VARCHAR(1000)
);

CREATE TABLE curso (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    codigo VARCHAR(50) NOT NULL,
    siglas VARCHAR(10) NOT NULL,
    nombre VARCHAR(100) NOT NULL
);

CREATE TABLE instancia (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    id_curso INT NOT NULL,
    fecha_inicio DATE,
    fecha_fin DATE,
    diploma VARCHAR(300),
    FOREIGN KEY (id_curso) REFERENCES curso(id)
);

CREATE TABLE alumno (
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    dni_nie_pasp VARCHAR(12) NOT NULL,
    apellidos VARCHAR(80) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    telefono VARCHAR(20),
	email VARCHAR(50),
	fecha_registro DATE,
	id_empresa INT,
	notas VARCHAR(1000),
	FOREIGN KEY (id_empresa) REFERENCES empresa(id),
);

CREATE TABLE inscripcion (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    id_alumno INT NOT NULL,
    id_instancia INT NOT NULL,
	id_empresa INT,
    fecha_inscripcion DATE,
	fecha_expedicion DATE,
    apto BIT,
	cod_factura VARCHAR(70),
	FOREIGN KEY (id_empresa) REFERENCES empresa(id),
    FOREIGN KEY (id_alumno) REFERENCES alumno(id),
    FOREIGN KEY (id_instancia) REFERENCES instancia(id)
);
GO

CREATE TRIGGER trg_InsertInscripcion
ON inscripcion
AFTER INSERT
AS
BEGIN
    UPDATE inscripcion
    SET id_empresa = (SELECT id_empresa FROM alumno WHERE id = inserted.id_alumno)
    FROM inserted
    WHERE inscripcion.id = inserted.id;
END;
GO

CREATE TRIGGER trg_UpdateInscripcion
ON alumno
AFTER UPDATE
AS
BEGIN
    IF UPDATE(id_empresa)  -- Solo actúa si id_empresa ha sido actualizado
    BEGIN
        UPDATE inscripcion
        SET id_empresa = inserted.id_empresa
        FROM inserted
        WHERE inscripcion.id_alumno = inserted.id;
    END
END;
GO

CREATE TRIGGER trg_UpdateInscripcionNull
ON alumno
AFTER UPDATE
AS
BEGIN
    IF UPDATE(id_empresa)  -- Solo actúa si id_empresa ha sido actualizado
    BEGIN
        UPDATE inscripcion
        SET id_empresa = NULL
        FROM inserted
        WHERE inscripcion.id_alumno = inserted.id AND inserted.id_empresa IS NULL;
    END
END;
GO


