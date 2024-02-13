CREATE DATABASE PROYECTO_POO_KENDALL
GO

USE PROYECTO_POO_KENDALL
GO

--Creacion de tablas--

CREATE TABLE Usuarios (
	IdUsuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre_usuario VARCHAR(30) NOT NULL,
	Contraseña_usuario VARCHAR(30) NOT NULL,
	Papel VARCHAR(30) NOT NULL
);

CREATE TABLE Bitacora (
	IdBitacora INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL,
	Hora TIME NOT NULL,
	Movimiento VARCHAR(150) NOT NULL
);

CREATE TABLE Pacientes (
	IdPaciente INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CedulaP VARCHAR(30) NOT NULL,
	NombreCompletoP VARCHAR(100) NOT NULL,
	TelefonoP VARCHAR(30) NOT NULL,
	CorreoElecP VARCHAR(100) NOT NULL,
	NacionalidadP VARCHAR(30),
	DireccionP VARCHAR(150) NOT NULL
);

CREATE TABLE Funcionarios (
  IdFuncionario VARCHAR(30) PRIMARY KEY NOT NULL,
  CedulaF VARCHAR(30) NOT NULL,
  NombreCompletoF VARCHAR(100) NOT NULL,
  TelefonoF VARCHAR(30) NOT NULL,
  CorreoElecF VARCHAR(100) NOT NULL,
  NacionalidadF VARCHAR(30) NOT NULL,
  DireccionF VARCHAR(150) NOT NULL,
  PuestoTrabajaF VARCHAR(50) NOT NULL,
);


CREATE TABLE Especialidad (
  IdEspecialista VARCHAR(30) PRIMARY KEY NOT NULL,
  CedulaE VARCHAR(30) NOT NULL,
  NombreCompletoE VARCHAR(100) NOT NULL,
  TelefonoE VARCHAR(30) NOT NULL,
  CorreoElecE VARCHAR(100) NOT NULL,
  NacionalidadE VARCHAR(30) NOT NULL,
  DireccionE VARCHAR(150) NOT NULL,
  NombreEspecialidad VARCHAR(50) NOT NULL
);


CREATE TABLE Historial_Clinico (
  IDHistorial INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdPaciente INT NOT NULL,
  IDdiagnostico INT NOT NULL,
  IDmedicamento INT NOT NULL
);

CREATE TABLE Diagnosticos (
  IDdiagnostico INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdEspecialista VARCHAR(30) NOT NULL,
  FechaRealizacion DATETIME NOT NULL,
  Resultados VARCHAR(150) NOT NULL
);


CREATE TABLE Medicamentos (
  IDmedicamento INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  NombreMed VARCHAR(30) NOT NULL,
  Descripcion VARCHAR(150) NOT NULL,
  Instrucciones VARCHAR(150)
);

CREATE TABLE Pagos (
  IDfactura INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdPaciente INT NOT NULL,
  IdFuncionario VARCHAR(30),
  Monto DECIMAL(10,2) NOT NULL,
  FechaPago DATE NOT NULL,
  TipoPago VARCHAR(30) NOT NULL
);

CREATE TABLE Citas (
  IDcita INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IDAgendaEspecialista INT NOT NULL,
  IdFuncionario VARCHAR(30),
  IdPaciente INT NOT NULL,
);

CREATE TABLE AgendaEspecialista (
  IDAgendaEspecialista INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IDEspecialista VARCHAR(30) NOT NULL,
  HoraInicio TIME NOT NULL,
  HoraFinal TIME NOT NULL,
  FechaCita DATE NOT NULL
);

CREATE TABLE CitasWeb (
  IDcitaWeb INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IDAgendaEspecialista INT NOT NULL,
  IdPaciente INT NOT NULL,
  HoraInico TIME NOT NULL,
  Fecha DATE NOT NULL
);

INSERT INTO Pacientes (CedulaP, NombreCompletoP, TelefonoP, CorreoElecP, NacionalidadP, DireccionP)
VALUES
    ('123456789', 'Juan Perez', '555-1234', 'juanperez@example.com', 'Dominicana', 'Calle 123, Ciudad'),
    ('987654321', 'Maria Lopez', '555-5678', 'marialopez@example.com', 'Mexicana', 'Avenida 456, Ciudad'),
    ('567891234', 'Pedro Ramirez', '555-4321', 'pedroramirez@example.com', 'Colombiana', 'Carretera 789, Ciudad'),
    ('432198765', 'Ana Martinez', '555-8765', 'anamartinez@example.com', 'Española', 'Avenida 987, Ciudad'),
    ('876543219', 'Luisa Herrera', '555-2109', 'luisaherrera@example.com', 'Venezolana', 'Calle 654, Ciudad');


INSERT INTO Especialidad (IdEspecialista, CedulaE, NombreCompletoE, TelefonoE, CorreoElecE, NacionalidadE, DireccionE, NombreEspecialidad)
VALUES
    ('ES0001', '1234567890', 'John Doe', '1234567890', 'correo1@example.com', 'Nacionalidad 1', 'Dirección 1', 'Pediatría'),
    ('ES0002', '2345678901', 'Jane Smith', '2345678901', 'correo2@example.com', 'Nacionalidad 2', 'Dirección 2', 'Ginecología'),
    ('ES0003', '3456789012', 'Michael Johnson', '3456789012', 'correo3@example.com', 'Nacionalidad 3', 'Dirección 3', 'Cardiología'),
    ('ES0004', '4567890123', 'Emily Davis', '4567890123', 'correo4@example.com', 'Nacionalidad 4', 'Dirección 4', 'Dermatología'),
    ('ES0005', '5678901234', 'David Wilson', '5678901234', 'correo5@example.com', 'Nacionalidad 5', 'Dirección 5', 'Cardiología'),
    ('ES0006', '6789012345', 'Sophia Thompson', '6789012345', 'correo6@example.com', 'Nacionalidad 6', 'Dirección 6', 'Oftalmología'),
    ('ES0007', '7890123456', 'Oliver Martinez', '7890123456', 'correo7@example.com', 'Nacionalidad 7', 'Dirección 7', 'Odontología'),
    ('ES0008', '8901234567', 'Emma Taylor', '8901234567', 'correo8@example.com', 'Nacionalidad 8', 'Dirección 8', 'Pediatría'),
    ('ES0009', '9012345678', 'Noah Johnson', '9012345678', 'correo9@example.com', 'Nacionalidad 9', 'Dirección 9', 'Ginecología'),
    ('ES0010', '0123456789', 'Ava Anderson', '0123456789', 'correo10@example.com', 'Nacionalidad 10', 'Dirección 10', 'Dermatología');


INSERT INTO AgendaEspecialista (IDEspecialista, HoraInicio, HoraFinal, FechaCita)
VALUES
    ('ES0001', '09:00:00', '11:00:00', '2023-06-01'),
    ('ES0002', '10:30:00', '12:30:00', '2023-06-02'),
    ('ES0003', '13:00:00', '15:00:00', '2023-06-03'),
    ('ES0004', '14:30:00', '16:30:00', '2023-06-04'),
    ('ES0005', '16:00:00', '18:00:00', '2023-06-05'),
    ('ES0006', '09:30:00', '11:30:00', '2023-06-06'),
    ('ES0007', '11:00:00', '13:00:00', '2023-06-07'),
    ('ES0008', '12:30:00', '14:30:00', '2023-06-08'),
    ('ES0009', '14:00:00', '16:00:00', '2023-06-09'),
    ('ES0010', '15:30:00', '17:30:00', '2023-06-10');

--Relaciones

ALTER TABLE Diagnosticos
    ADD CONSTRAINT FK_Especialista_Diagnostico FOREIGN KEY (IDEspecialista)
    REFERENCES Especialidad(IDEspecialista)

ALTER TABLE Historial_Clinico
    ADD CONSTRAINT FK_Historial_Diagnostico FOREIGN KEY (IDdiagnostico)
    REFERENCES Diagnosticos(IDdiagnostico)

ALTER TABLE Historial_Clinico
    ADD CONSTRAINT FK_Historial_Medicamentos FOREIGN KEY (IDmedicamento)
    REFERENCES Medicamentos(IDmedicamento)

ALTER TABLE Historial_Clinico
    ADD CONSTRAINT FK_Historial_Pacientes FOREIGN KEY (IdPaciente)
    REFERENCES Pacientes(IdPaciente)

ALTER TABLE Pagos
    ADD CONSTRAINT FK_Pagos_Pacientes FOREIGN KEY (IdPaciente)
    REFERENCES Pacientes(IdPaciente)

ALTER TABLE Pagos
    ADD CONSTRAINT FK_Pagos_Funcionario FOREIGN KEY (IdFuncionario)
    REFERENCES Funcionarios(IdFuncionario)

ALTER TABLE Citas
    ADD CONSTRAINT FK_Citas_Funcionario FOREIGN KEY (IdFuncionario)
    REFERENCES Funcionarios(IdFuncionario)

ALTER TABLE Citas
    ADD CONSTRAINT FK_Citas_Paciente FOREIGN KEY (IdPaciente)
    REFERENCES Pacientes(IdPaciente)

ALTER TABLE AgendaEspecialista
    ADD CONSTRAINT FK_AgendaEspecialista_Especialidad FOREIGN KEY (IDEspecialista)
    REFERENCES Especialidad(IDEspecialista)

ALTER TABLE Citas
    ADD CONSTRAINT FK_Citas_AgendaEspecialista FOREIGN KEY (IDAgendaEspecialista)
    REFERENCES AgendaEspecialista(IDAgendaEspecialista)

ALTER TABLE CitasWeb
    ADD CONSTRAINT FK_CitaWeb_AgendaEspecialista FOREIGN KEY (IDAgendaEspecialista)
    REFERENCES AgendaEspecialista(IDAgendaEspecialista)

ALTER TABLE CitasWeb
    ADD CONSTRAINT FK_CitaWeb_Paciente FOREIGN KEY (IdPaciente)
    REFERENCES Pacientes(IdPaciente)

--Proceso almacenado para agendar CitasWeb y verificar 
GO
CREATE OR ALTER PROCEDURE AgendarCitaWeb
    @IDAgendaEspecialista INT,
    @IdPaciente INT,
    @HoraInicioCita TIME,
    @FechaCita DATE,
    @Resultado VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM AgendaEspecialista
        WHERE IDAgendaEspecialista = @IDAgendaEspecialista
            AND HoraInicio <= @HoraInicioCita
            AND HoraFinal >= DATEADD(minute, 30, @HoraInicioCita)
            AND FechaCita = @FechaCita
    )
    BEGIN
        IF NOT EXISTS (
            SELECT 1
            FROM CitasWeb
            WHERE IDAgendaEspecialista = @IDAgendaEspecialista
                AND HoraInico <= @HoraInicioCita
                AND DATEADD(minute, 30, HoraInico) >= @HoraInicioCita
                AND Fecha = @FechaCita
        )
        BEGIN
            INSERT INTO CitasWeb (IDAgendaEspecialista, IdPaciente, HoraInico, Fecha)
            VALUES (
                @IDAgendaEspecialista,
                @IdPaciente,
                @HoraInicioCita,
                @FechaCita
            );
            SET @Resultado = 'La cita se ha agendado correctamente.';
			RETURN 1;
        END
        ELSE
        BEGIN
            SET @Resultado = 'Ya hay una cita agendada en el horario solicitado.';
			RETURN 0;
        END
    END
    ELSE
    BEGIN
        SET @Resultado = 'No hay una agenda disponible en el horario solicitado.';
		RETURN 0;
    END
END

--Proceso para agendar una cita 

go
CREATE PROCEDURE RegistrarCita
    @idEspecialista VARCHAR(30),
    @horaInicio TIME,
    @horaFinal TIME,
    @fechaCita DATE,
    @mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar disponibilidad de horarios
    IF EXISTS (
        SELECT 1
        FROM AgendaEspecialista
        WHERE IDEspecialista = @idEspecialista
            AND FechaCita = @fechaCita
            AND ((HoraInicio <= @horaInicio AND HoraFinal >= @horaInicio)
                OR (HoraInicio <= @horaFinal AND HoraFinal >= @horaFinal)
                OR (HoraInicio >= @horaInicio AND HoraFinal <= @horaFinal))
    )
    BEGIN
        -- Horario no disponible, mostrar mensaje de error o realizar alguna acción necesaria
        SET @mensaje = 'El especialista no está disponible en el horario seleccionado.';
        RETURN;
    END
    ELSE
    BEGIN
        -- Registrar la cita
        INSERT INTO AgendaEspecialista (IDEspecialista, HoraInicio, HoraFinal, FechaCita)
        VALUES (@idEspecialista, @horaInicio, @horaFinal, @fechaCita);

        -- Mostrar mensaje de éxito o realizar alguna acción necesaria
        SET @mensaje = 'Cita registrada exitosamente.';
        RETURN;
    END
END

go
CREATE PROCEDURE IngresarCita
    @IDAgendaEspecialista INT,
    @IdFuncionario VARCHAR(30),
    @IdPaciente INT,
    @mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar disponibilidad de horarios
    IF EXISTS (
        SELECT 1
        FROM Citas
        WHERE IdPaciente = @IdPaciente
    )
    BEGIN
        -- El paciente ya tiene una cita en la misma agenda, mostrar mensaje de error o realizar alguna acción necesaria
        SET @mensaje = 'El paciente ya tiene una cita en la misma agenda.';
        RETURN;
    END
    ELSE
    BEGIN
        -- Registrar la cita
        INSERT INTO Citas (IDAgendaEspecialista, IdFuncionario, IdPaciente)
        VALUES (@IDAgendaEspecialista, @IdFuncionario, @IdPaciente);

        -- Mostrar mensaje de éxito o realizar alguna acción necesaria
        SET @mensaje = 'Cita registrada correctamente.';
        RETURN;
    END
END

--TRIGGERS que registran cada cambio que se hace en la base de datos en una tabla bitacora
-- Trigger para la tabla "Pacientes"

GO
CREATE TRIGGER Pacientes_TRIGGER
ON Pacientes
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Pacientes'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Pacientes'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Pacientes'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Funcionarios"

GO
CREATE TRIGGER Funcionarios_TRIGGER
ON Funcionarios
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Funcionarios'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Funcionarios'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Funcionarios'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Especialidad"
GO
CREATE TRIGGER Especialidad_TRIGGER
ON Especialidad
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Especialidad'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Especialidad'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Especialidad'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Historial_Clinico"
GO
CREATE TRIGGER Historial_Clinico_TRIGGER
ON Historial_Clinico
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Historial_Clinico'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Historial_Clinico'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Historial_Clinico'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Diagnosticos"
GO
CREATE TRIGGER Diagnosticos_TRIGGER
ON Diagnosticos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Diagnosticos'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Diagnosticos'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Diagnosticos'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Medicamentos"
GO
CREATE TRIGGER Medicamentos_TRIGGER
ON Medicamentos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Medicamentos'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Medicamentos' 
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Medicamentos'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Pagos"
GO
CREATE TRIGGER Pagos_TRIGGER
ON Pagos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Pagos'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Pagos'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Pagos'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "Citas"
GO
CREATE TRIGGER Citas_TRIGGER
ON Citas
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en Citas'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en Citas'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en Citas'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END

-- Trigger para la tabla "AgendaEspecialista"
GO
CREATE TRIGGER AgendaEspecialista_TRIGGER
ON AgendaEspecialista
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  DECLARE @Movimiento VARCHAR(150)
  SET @Movimiento = 
    CASE 
      WHEN EXISTS(SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted) THEN 'Actualización en AgendaEspecialista'
      WHEN EXISTS(SELECT * FROM inserted) THEN 'Inserción en AgendaEspecialista'
      WHEN EXISTS(SELECT * FROM deleted) THEN 'Eliminación en AgendaEspecialista'
    END

  INSERT INTO Bitacora (Fecha, Hora, Movimiento)
  VALUES (CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()), @Movimiento)
END


--CRUDS--
-- Procedimiento almacenado para insertar un nuevo usuario
GO
CREATE PROCEDURE InsertarUsuario
    @Nombre_usuario VARCHAR(30),
    @Contraseña_usuario VARCHAR(30),
    @Papel VARCHAR(30)
AS
BEGIN
    INSERT INTO Usuarios (Nombre_usuario, Contraseña_usuario, Papel)
    VALUES (@Nombre_usuario, @Contraseña_usuario, @Papel);
END;

-- Procedimiento almacenado para leer todos los usuarios
GO
CREATE PROCEDURE LeerUsuarios
AS
BEGIN
    SELECT * FROM Usuarios;
END;

-- Procedimiento almacenado para leer un usuario por su IdUsuario
GO
CREATE PROCEDURE LeerUsuarioPorId
    @IdUsuario INT
AS
BEGIN
    SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario;
END;

-- Procedimiento almacenado para actualizar un usuario por su IdUsuario
GO
CREATE PROCEDURE ActualizarUsuario
    @IdUsuario INT,
    @Nombre_usuario VARCHAR(30),
    @Contraseña_usuario VARCHAR(30),
    @Papel VARCHAR(30)
AS
BEGIN
    UPDATE Usuarios
    SET Nombre_usuario = @Nombre_usuario, Contraseña_usuario = @Contraseña_usuario, Papel = @Papel
    WHERE IdUsuario = @IdUsuario;
END;

-- Procedimiento almacenado para eliminar un usuario por su IdUsuario
GO
CREATE PROCEDURE EliminarUsuario
    @IdUsuario INT
AS
BEGIN
    DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario;
END;

-- Procedimiento almacenado para insertar un nuevo registro en la bitácora
GO
CREATE PROCEDURE InsertarRegistroBitacora
    @Fecha DATE,
    @Hora TIME,
    @Movimiento VARCHAR(150)
AS
BEGIN
    INSERT INTO Bitacora (Fecha, Hora, Movimiento)
    VALUES (@Fecha, @Hora, @Movimiento);
END;

-- Procedimiento almacenado para leer todos los registros de la bitácora
GO
CREATE PROCEDURE LeerRegistrosBitacora
AS
BEGIN
    SELECT * FROM Bitacora;
END;

-- Procedimiento almacenado para leer un registro de la bitácora por su IdBitacora
GO
CREATE PROCEDURE LeerRegistroBitacoraPorId
    @IdBitacora INT
AS
BEGIN
    SELECT * FROM Bitacora WHERE IdBitacora = @IdBitacora;
END;

-- Procedimiento almacenado para actualizar un registro de la bitácora por su IdBitacora
GO
CREATE PROCEDURE ActualizarRegistroBitacora
    @IdBitacora INT,
    @Fecha DATE,
    @Hora TIME,
    @Movimiento VARCHAR(150)
AS
BEGIN
    UPDATE Bitacora
    SET Fecha = @Fecha, Hora = @Hora, Movimiento = @Movimiento
    WHERE IdBitacora = @IdBitacora;
END;

-- Procedimiento almacenado para eliminar un registro de la bitácora por su IdBitacora
GO
CREATE PROCEDURE EliminarRegistroBitacora
    @IdBitacora INT
AS
BEGIN
    DELETE FROM Bitacora WHERE IdBitacora = @IdBitacora;
END;

-- Procedimiento almacenado para insertar un nuevo paciente
GO
CREATE OR ALTER PROCEDURE InsertarPaciente
	@CedulaP VARCHAR(30),
	@NombreCompletoP VARCHAR(100),
	@TelefonoP VARCHAR(30),
	@CorreoElecP VARCHAR(100),
	@NacionalidadP VARCHAR(30),
	@DireccionP VARCHAR(150),
	@ID INT OUTPUT,
	@Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM Pacientes WHERE CedulaP = @CedulaP)
	BEGIN
		-- La cédula ya existe, devolver valor -1 y mensaje de error
		SET @ID = -1
		SET @Mensaje = 'La cédula ya ha sido ingresada.'
		RETURN
	END

	INSERT INTO Pacientes (CedulaP, NombreCompletoP, TelefonoP, CorreoElecP, NacionalidadP, DireccionP)
	VALUES (@CedulaP, @NombreCompletoP, @TelefonoP, @CorreoElecP, @NacionalidadP, @DireccionP)

	SET @ID = SCOPE_IDENTITY()
	SET @Mensaje = 'Paciente insertado exitosamente.'
END



-- Procedimiento almacenado para leer todos los pacientes
GO
CREATE PROCEDURE LeerPacientes
AS
BEGIN
    SELECT * FROM Pacientes;
END;

-- Procedimiento almacenado para leer un paciente por su IdPaciente
GO
CREATE PROCEDURE LeerPacientePorId
    @IdPaciente INT
AS
BEGIN
    SELECT * FROM Pacientes WHERE IdPaciente = @IdPaciente;
END;

-- Procedimiento almacenado para actualizar un paciente por su IdPaciente
GO
CREATE PROCEDURE ActualizarPaciente
    @IdPaciente INT,
    @CedulaP VARCHAR(30),
    @NombreCompletoP VARCHAR(100),
    @TelefonoP VARCHAR(30),
    @CorreoElecP VARCHAR(100),
    @NacionalidadP VARCHAR(30),
    @DireccionP VARCHAR(150)
AS
BEGIN
    UPDATE Pacientes
    SET CedulaP = @CedulaP, NombreCompletoP = @NombreCompletoP, TelefonoP = @TelefonoP,
        CorreoElecP = @CorreoElecP, NacionalidadP = @NacionalidadP, DireccionP = @DireccionP
    WHERE IdPaciente = @IdPaciente;
END;

-- Procedimiento almacenado para eliminar un paciente por su IdPaciente
GO

CREATE OR ALTER PROCEDURE ELIMINAR_PACIENTE02 
	@ID_PACIENTE INT,
	@msj VARCHAR(100) OUT
AS 
BEGIN 
	IF (NOT EXISTS (SELECT * FROM Pacientes WHERE IdPaciente = @ID_PACIENTE))
	BEGIN
		SET @msj = 'El paciente no existe'
		RETURN 0
	END
	ELSE IF (EXISTS (SELECT * FROM CitasWeb WHERE IdPaciente = @ID_PACIENTE))
	BEGIN
		SET @msj = 'El paciente tiene citas pendientes, no se puede eliminar.'
		RETURN 0
	END
	ELSE
	BEGIN
		DELETE FROM Pacientes WHERE IdPaciente = @ID_PACIENTE
		SET @msj = 'Paciente eliminado'
		RETURN 0
	END
END 

GO
-- Procedimiento almacenado para insertar un nuevo funcionario
CREATE PROCEDURE InsertarFuncionario
    @IdFuncionario VARCHAR(30),
    @CedulaF VARCHAR(30),
    @NombreCompletoF VARCHAR(100),
    @TelefonoF VARCHAR(30),
    @CorreoElecF VARCHAR(100),
    @NacionalidadF VARCHAR(30),
    @DireccionF VARCHAR(150),
    @PuestoTrabajaF VARCHAR(50)
AS
BEGIN
    INSERT INTO Funcionarios (IdFuncionario, CedulaF, NombreCompletoF, TelefonoF, CorreoElecF, NacionalidadF, DireccionF, PuestoTrabajaF)
    VALUES (@IdFuncionario, @CedulaF, @NombreCompletoF, @TelefonoF, @CorreoElecF, @NacionalidadF, @DireccionF, @PuestoTrabajaF);
END;

-- Procedimiento almacenado para leer todos los funcionarios
GO
CREATE PROCEDURE LeerFuncionarios
AS
BEGIN
    SELECT * FROM Funcionarios;
END;

-- Procedimiento almacenado para leer un funcionario por su IdFuncionario
GO
CREATE PROCEDURE LeerFuncionarioPorId
    @IdFuncionario VARCHAR(30)
AS
BEGIN
    SELECT * FROM Funcionarios WHERE IdFuncionario = @IdFuncionario;
END;

-- Procedimiento almacenado para actualizar un funcionario por su IdFuncionario
GO
CREATE PROCEDURE ActualizarFuncionario
    @IdFuncionario VARCHAR(30),
    @CedulaF VARCHAR(30),
    @NombreCompletoF VARCHAR(100),
    @TelefonoF VARCHAR(30),
    @CorreoElecF VARCHAR(100),
    @NacionalidadF VARCHAR(30),
    @DireccionF VARCHAR(150),
    @PuestoTrabajaF VARCHAR(50)
AS
BEGIN
    UPDATE Funcionarios
    SET CedulaF = @CedulaF, NombreCompletoF = @NombreCompletoF, TelefonoF = @TelefonoF,
        CorreoElecF = @CorreoElecF, NacionalidadF = @NacionalidadF, DireccionF = @DireccionF, PuestoTrabajaF = @PuestoTrabajaF
    WHERE IdFuncionario = @IdFuncionario;
END;

-- Procedimiento almacenado para eliminar un funcionario por su IdFuncionario
GO
CREATE PROCEDURE EliminarFuncionario
    @IdFuncionario VARCHAR(30)
AS
BEGIN
    DELETE FROM Funcionarios WHERE IdFuncionario = @IdFuncionario;
END;


-- Procedimiento almacenado para insertar una nueva especialidad
GO
CREATE PROCEDURE InsertarEspecialidad
    @IdEspecialista VARCHAR(30),
    @CedulaE VARCHAR(30),
    @NombreCompletoE VARCHAR(100),
    @TelefonoE VARCHAR(30),
    @CorreoElecE VARCHAR(100),
    @NacionalidadE VARCHAR(30),
    @DireccionE VARCHAR(150),
    @NombreEspecialidad VARCHAR(50)
AS
BEGIN
    INSERT INTO Especialidad (IdEspecialista, CedulaE, NombreCompletoE, TelefonoE, CorreoElecE, NacionalidadE, DireccionE, NombreEspecialidad)
    VALUES (@IdEspecialista, @CedulaE, @NombreCompletoE, @TelefonoE, @CorreoElecE, @NacionalidadE, @DireccionE, @NombreEspecialidad);
END;

-- Procedimiento almacenado para leer todas las especialidades
GO
CREATE PROCEDURE LeerEspecialidades
AS
BEGIN
    SELECT * FROM Especialidad;
END;

-- Procedimiento almacenado para leer una especialidad por su IdEspecialista
GO
CREATE PROCEDURE LeerEspecialidadPorId
    @IdEspecialista VARCHAR(30)
AS
BEGIN
    SELECT * FROM Especialidad WHERE IdEspecialista = @IdEspecialista;
END;

-- Procedimiento almacenado para actualizar una especialidad por su IdEspecialista
GO
CREATE PROCEDURE ActualizarEspecialidad
    @IdEspecialista VARCHAR(30),
    @CedulaE VARCHAR(30),
    @NombreCompletoE VARCHAR(100),
    @TelefonoE VARCHAR(30),
    @CorreoElecE VARCHAR(100),
    @NacionalidadE VARCHAR(30),
    @DireccionE VARCHAR(150),
    @NombreEspecialidad VARCHAR(50)
AS
BEGIN
    UPDATE Especialidad
    SET CedulaE = @CedulaE, NombreCompletoE = @NombreCompletoE, TelefonoE = @TelefonoE,
        CorreoElecE = @CorreoElecE, NacionalidadE = @NacionalidadE, DireccionE = @DireccionE, NombreEspecialidad = @NombreEspecialidad
    WHERE IdEspecialista = @IdEspecialista;
END;

-- Procedimiento almacenado para eliminar una especialidad por su IdEspecialista
GO
CREATE PROCEDURE EliminarEspecialidad
    @IdEspecialista VARCHAR(30)
AS
BEGIN
    DELETE FROM Especialidad WHERE IdEspecialista = @IdEspecialista;
END;

-- Procedimiento almacenado para insertar un nuevo diagnóstico
GO
CREATE PROCEDURE InsertarDiagnostico
    @IdEspecialista VARCHAR(30),
    @FechaRealizacion DATETIME,
    @Resultados VARCHAR(150)
AS
BEGIN
    INSERT INTO Diagnosticos (IdEspecialista, FechaRealizacion, Resultados)
    VALUES (@IdEspecialista, @FechaRealizacion, @Resultados);
END;

-- Procedimiento almacenado para leer todos los diagnósticos
GO
CREATE PROCEDURE LeerDiagnosticos
AS
BEGIN
    SELECT * FROM Diagnosticos;
END;

-- Procedimiento almacenado para leer un diagnóstico por su IDdiagnostico
GO
CREATE PROCEDURE LeerDiagnosticoPorId
    @IDdiagnostico INT
AS
BEGIN
    SELECT * FROM Diagnosticos WHERE IDdiagnostico = @IDdiagnostico;
END;

-- Procedimiento almacenado para actualizar un diagnóstico por su IDdiagnostico
GO
CREATE PROCEDURE ActualizarDiagnostico
    @IDdiagnostico INT,
    @IdEspecialista VARCHAR(30),
    @FechaRealizacion DATETIME,
    @Resultados VARCHAR(150)
AS
BEGIN
    UPDATE Diagnosticos
    SET IdEspecialista = @IdEspecialista, FechaRealizacion = @FechaRealizacion, Resultados = @Resultados
    WHERE IDdiagnostico = @IDdiagnostico;
END;

-- Procedimiento almacenado para eliminar un diagnóstico por su IDdiagnostico
GO
CREATE PROCEDURE EliminarDiagnostico
    @IDdiagnostico INT
AS
BEGIN
    DELETE FROM Diagnosticos WHERE IDdiagnostico = @IDdiagnostico;
END;

-- Procedimiento almacenado para insertar un nuevo medicamento
GO
CREATE PROCEDURE InsertarMedicamento
    @NombreMed VARCHAR(30),
    @Descripcion VARCHAR(150),
    @Instrucciones VARCHAR(150)
AS
BEGIN
    INSERT INTO Medicamentos (NombreMed, Descripcion, Instrucciones)
    VALUES (@NombreMed, @Descripcion, @Instrucciones);
END;

-- Procedimiento almacenado para leer todos los medicamentos
GO
CREATE PROCEDURE LeerMedicamentos
AS
BEGIN
    SELECT * FROM Medicamentos;
END;

-- Procedimiento almacenado para leer un medicamento por su IDmedicamento
GO
CREATE PROCEDURE LeerMedicamentoPorId
    @IDmedicamento INT
AS
BEGIN
    SELECT * FROM Medicamentos WHERE IDmedicamento = @IDmedicamento;
END;

-- Procedimiento almacenado para actualizar un medicamento por su IDmedicamento
GO
CREATE PROCEDURE ActualizarMedicamento
    @IDmedicamento INT,
    @NombreMed VARCHAR(30),
    @Descripcion VARCHAR(150),
    @Instrucciones VARCHAR(150)
AS
BEGIN
    UPDATE Medicamentos
    SET NombreMed = @NombreMed, Descripcion = @Descripcion, Instrucciones = @Instrucciones
    WHERE IDmedicamento = @IDmedicamento;
END;

-- Procedimiento almacenado para eliminar un medicamento por su IDmedicamento
GO
CREATE PROCEDURE EliminarMedicamento
    @IDmedicamento INT
AS
BEGIN
    DELETE FROM Medicamentos WHERE IDmedicamento = @IDmedicamento;
END;

-- Procedimiento almacenado para insertar un nuevo pago
GO
CREATE PROCEDURE InsertarPago
    @IdPaciente INT,
    @IdFuncionario VARCHAR(30),
    @Monto DECIMAL(10, 2),
    @FechaPago DATE,
    @TipoPago VARCHAR(30)
AS
BEGIN
    INSERT INTO Pagos (IdPaciente, IdFuncionario, Monto, FechaPago, TipoPago)
    VALUES (@IdPaciente, @IdFuncionario, @Monto, @FechaPago, @TipoPago);
END;

-- Procedimiento almacenado para leer todos los pagos
GO
CREATE PROCEDURE LeerPagos
AS
BEGIN
    SELECT * FROM Pagos;
END;

-- Procedimiento almacenado para leer un pago por su IDfactura
GO
CREATE PROCEDURE LeerPagoPorId
    @IDfactura INT
AS
BEGIN
    SELECT * FROM Pagos WHERE IDfactura = @IDfactura;
END;

-- Procedimiento almacenado para actualizar un pago por su IDfactura
GO
CREATE PROCEDURE ActualizarPago
    @IDfactura INT,
    @IdPaciente INT,
    @IdFuncionario VARCHAR(30),
    @Monto DECIMAL(10, 2),
    @FechaPago DATE,
    @TipoPago VARCHAR(30)
AS
BEGIN
    UPDATE Pagos
    SET IdPaciente = @IdPaciente, IdFuncionario = @IdFuncionario, Monto = @Monto,
        FechaPago = @FechaPago, TipoPago = @TipoPago
    WHERE IDfactura = @IDfactura;
END;

-- Procedimiento almacenado para eliminar un pago por su IDfactura
GO
CREATE PROCEDURE EliminarPago
    @IDfactura INT
AS
BEGIN
    DELETE FROM Pagos WHERE IDfactura = @IDfactura;
END;

-- Procedimiento almacenado para insertar una nueva cita
GO
CREATE PROCEDURE InsertarCita
    @IDAgendaEspecialista INT,
    @IdFuncionario VARCHAR(30),
    @IdPaciente INT
AS
BEGIN
    INSERT INTO Citas (IDAgendaEspecialista, IdFuncionario, IdPaciente)
    VALUES (@IDAgendaEspecialista, @IdFuncionario, @IdPaciente);
END;

-- Procedimiento almacenado para leer todas las citas
GO
CREATE PROCEDURE LeerCitas
AS
BEGIN
    SELECT * FROM Citas;
END;

-- Procedimiento almacenado para leer una cita por su IDcita
GO
CREATE PROCEDURE LeerCitaPorId
    @IDcita INT
AS
BEGIN
    SELECT * FROM Citas WHERE IDcita = @IDcita;
END;

-- Procedimiento almacenado para actualizar una cita por su IDcita
GO
CREATE PROCEDURE ActualizarCita
    @IDcita INT,
    @IDAgendaEspecialista INT,
    @IdFuncionario VARCHAR(30),
    @IdPaciente INT
AS
BEGIN
    UPDATE Citas
    SET IDAgendaEspecialista = @IDAgendaEspecialista, IdFuncionario = @IdFuncionario, IdPaciente = @IdPaciente
    WHERE IDcita = @IDcita;
END;

-- Procedimiento almacenado para eliminar una cita por su IDcita
GO
CREATE PROCEDURE EliminarCita
    @IDcita INT
AS
BEGIN
    DELETE FROM Citas WHERE IDcita = @IDcita;
END;

-- Procedimiento almacenado para insertar una nueva agenda de especialista
GO
CREATE PROCEDURE InsertarAgendaEspecialista
    @IDEspecialista VARCHAR(30),
    @HoraInicio TIME,
    @HoraFinal TIME,
    @FechaCita DATE
AS
BEGIN
    INSERT INTO AgendaEspecialista (IDEspecialista, HoraInicio, HoraFinal, FechaCita)
    VALUES (@IDEspecialista, @HoraInicio, @HoraFinal, @FechaCita);
END;

-- Procedimiento almacenado para leer todas las agendas de especialista
GO
CREATE PROCEDURE LeerAgendasEspecialista
AS
BEGIN
    SELECT * FROM AgendaEspecialista;
END;

-- Procedimiento almacenado para leer una agenda de especialista por su IDAgendaEspecialista
GO
CREATE PROCEDURE LeerAgendaEspecialistaPorId
    @IDAgendaEspecialista INT
AS
BEGIN
    SELECT * FROM AgendaEspecialista WHERE IDAgendaEspecialista = @IDAgendaEspecialista;
END;

-- Procedimiento almacenado para actualizar una agenda de especialista por su IDAgendaEspecialista
GO
CREATE PROCEDURE ActualizarAgendaEspecialista
    @IDAgendaEspecialista INT,
    @IDEspecialista VARCHAR(30),
    @HoraInicio TIME,
    @HoraFinal TIME,
    @FechaCita DATE
AS
BEGIN
    UPDATE AgendaEspecialista
    SET IDEspecialista = @IDEspecialista, HoraInicio = @HoraInicio, HoraFinal = @HoraFinal, FechaCita = @FechaCita
    WHERE IDAgendaEspecialista = @IDAgendaEspecialista;
END;

-- Procedimiento almacenado para eliminar una agenda de especialista por su IDAgendaEspecialista
GO
CREATE PROCEDURE EliminarAgendaEspecialista
    @IDAgendaEspecialista INT
AS
BEGIN
    DELETE FROM AgendaEspecialista WHERE IDAgendaEspecialista = @IDAgendaEspecialista;
END;
