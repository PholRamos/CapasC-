
--CREAR BASE DE DATOS
create database DB_Clinica
on primary
(
	name=DB_Clinica_Data,
	filename='E:\SENATI\PlanSesion20204-1\ING-SOFT-SEMESTRE-IV\2-LP-3\ProyectoLP\DB\DB_Clinica_Data.mdf',
	size=5mb,
	maxsize=unlimited,
	filegrowth=10%
)
log on
(
	name=DB_Clinica_Log,
	filename='E:\SENATI\PlanSesion20204-1\ING-SOFT-SEMESTRE-IV\2-LP-3\ProyectoLP\DB\DB_Clinica_log.ldf',
	size=5mb,
	maxsize=unlimited,
	filegrowth=10%
)

USE DB_Clinica

------------------------------------------------------------
--CREAR TABLAS

CREATE TABLE EECC
(
	EECCCodigo tinyint identity primary key not null,
	EECCDescripcion varchar(10)
)

INSERT EECC VALUES ('Soltero'),('Casado'),
('Viudo'),('Divorciado')

select * from EECC

CREATE TABLE Genero
(
	GeneroCCodigo tinyint identity primary key not null,
	GeneroDescripcion varchar(9)
)

insert Genero values ('Femenino'),('Masculino')

select * from Genero

create table Paciente
(
	PacienteCodigo varchar(8) primary key not null,
	PacienteNombre varchar(30),
	PacienteApellido varchar(50),
	PacienteDireccion varchar(150),
	PacienteTelefono int,
	PacienteNacimiento date,
	EECCCodigo tinyint foreign key(EECCCodigo) references EECC,
	GeneroCCodigo tinyint foreign key(GeneroCCodigo) references Genero
)

create table HHCC
(
	HHCCCodigo int identity (10000,2) primary key not null,
	HHCCFecha datetime,
	PacienteCodigo varchar(8) foreign key (PacienteCodigo) references Paciente
)

create table Especialidad
(
	EspecialidadCodigo int identity primary key not null,
	EspecialidadDescripcion varchar(50),
)

create table Especialista
(
	EspecialistaCMP int primary key not null,
	EspecialistaNombre varchar(30),
	EspecialistaApellido varchar(50),
	EspecialidadCodigo int foreign key (EspecialidadCodigo) references Especialidad
)

create table ActoMedico
(
	ActoMedicoCodigo int identity primary key not null,
	ActoMedicoFecha datetime,
	HHCCCodigo int foreign key (HHCCCodigo) references HHCC,
	EspecialistaCMP int foreign key (EspecialistaCMP) references Especialista,
	ActoMedicoObservacion varchar(250)
)

DROP TABLE ActoMedicoDetalle

create table ActoMedicoDetalle
(
	ActoMedicoCodigo int FOREIGN KEY (ActoMedicoCodigo) REFERENCES ActoMedico,
	fiebre float,
	tos bit,
	dolorCabeza bit,
	dolorMusculares bit,
	malestarGeneral bit,
	dolorGarganta bit,
	secreciónNasal bit
)

----------------------------------------------------------------
--PROCEDIMIENTO ALMACENADO

create proc usp_InsertarPaciente
(
	@PacienteCodigo varchar(8),
	@PacienteNombre varchar(30),
	@PacienteApellido varchar(50),
	@PacienteDireccion varchar(150),
	@PacienteTelefono int,
	@PacienteNacimiento date,
	@EECCCodigo tinyint,
	@GeneroCCodigo tinyint
)
as
begin
begin try
INSERT INTO [dbo].[Paciente]
           ([PacienteCodigo]
           ,[PacienteNombre]
           ,[PacienteApellido]
           ,[PacienteDireccion]
           ,[PacienteTelefono]
           ,[PacienteNacimiento]
           ,[EECCCodigo]
           ,[GeneroCCodigo])
     VALUES
           (@PacienteCodigo,@PacienteNombre,
	@PacienteApellido,@PacienteDireccion,
	@PacienteTelefono,@PacienteNacimiento,
	@EECCCodigo,@GeneroCCodigo)
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_EliminarPaciente
(
	@PacienteCodigo varchar(8)
)
as
begin
begin try
DELETE FROM [dbo].[Paciente]
      WHERE PacienteCodigo=@PacienteCodigo 
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_ActualizarPaciente
(
	@PacienteCodigo varchar(8),
	@PacienteNombre varchar(30),
	@PacienteApellido varchar(50),
	@PacienteDireccion varchar(150),
	@PacienteTelefono int,
	@PacienteNacimiento date,
	@EECCCodigo tinyint,
	@GeneroCCodigo tinyint
)
as
begin
begin try
UPDATE [dbo].[Paciente]
   SET
      [PacienteNombre] = @PacienteNombre
      ,[PacienteApellido] = @PacienteApellido
      ,[PacienteDireccion] = @PacienteDireccion
      ,[PacienteTelefono] = @PacienteTelefono
      ,[PacienteNacimiento] = @PacienteNacimiento
      ,[EECCCodigo] = @EECCCodigo
      ,[GeneroCCodigo] = @GeneroCCodigo
 WHERE [PacienteCodigo] = @PacienteCodigo
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_ListarPacienteDNI
(
	@PacienteCodigo varchar(8)
)
as
begin
	begin try
	select * from Paciente
	WHERE [PacienteCodigo] = @PacienteCodigo
	end try
	begin catch
		select ERROR_NUMBER(),ERROR_MESSAGE()
	end catch
end

use DB_Clinica

SET DATEFORMAT DMY

INSERT INTO [dbo].[Paciente]
           ([PacienteCodigo]
           ,[PacienteNombre]
           ,[PacienteApellido]
           ,[PacienteDireccion]
           ,[PacienteTelefono]
           ,[PacienteNacimiento]
           ,[EECCCodigo]
           ,[GeneroCCodigo])
     VALUES
           ('00054321','PABLO','MARMOL',
		   'CALLE ROCADURA 321',999654321,
		   '25/02/2000',1,2)
GO

SELECT * FROM Paciente

EXEC usp_ListarPaciente

select
datediff(year,p.PacienteNacimiento,GETDATE())
from Paciente p

use DB_Clinica

insert Especialidad
values('Medicina General'),
('Medicina Interna'),
('Cirugìa'),
('Endocrinologia'),
('Obstetricia'),
('Odontologìa')

select * from Especialidad

--PA - ESPECIALISTA
--CRUD - TOTAL
CREATE PROC usp_ListaEspecialista
as
begin
begin try
	select * from Especialista
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end

create procedure usp_ListaEspecialistaCMP 666
(@EspecialistaCMP int)
as
begin 
begin try
	select * from Especialista
	where EspecialistaCMP=@EspecialistaCMP
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end

create proc usp_InsertarEspecialista
(
	@EspecialistaCMP int,
	@EspecialistaNombre varchar(30),
	@EspecialistaApellido varchar(50),
	@EspecialidadCodigo int
)
as
begin 
begin try
	INSERT INTO [dbo].[Especialista]
           ([EspecialistaCMP]
           ,[EspecialistaNombre]
           ,[EspecialistaApellido]
           ,[EspecialidadCodigo])
     VALUES
           (@EspecialistaCMP,@EspecialistaNombre,
			@EspecialistaApellido,@EspecialidadCodigo)
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end

usp_InsertarEspecialista 668,'Tetoco','Tu Angulo',5

create proc usp_ActualizarEspecialista
(
	@EspecialistaCMP int,
	@EspecialistaNombre varchar(30),
	@EspecialistaApellido varchar(50),
	@EspecialidadCodigo int
)
as
begin 
	UPDATE [dbo].[Especialista]
	   SET [EspecialistaCMP] = @EspecialistaCMP
		  ,[EspecialistaNombre] = @EspecialistaNombre
		  ,[EspecialistaApellido] = @EspecialistaApellido
		  ,[EspecialidadCodigo] = @EspecialidadCodigo
	 WHERE EspecialistaCMP=@EspecialistaCMP
end

create proc EliminarEspecialista 668
(
	@EspecialistaCMP int
)
as
begin 
begin try
	DELETE FROM [dbo].[Especialista]
		  WHERE EspecialistaCMP=@EspecialistaCMP
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end

select * from Especialista

---------------------------------------------------------
--PA Historia Clinica

use DB_Clinica

alter proc usp_ListarHHCC
as
begin
begin try
	select [HHCCCodigo], [HHCCFecha], [PacienteCodigo] 
	from [dbo].[HHCC]
	order by HHCCFecha desc 
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end 

create proc usp_ListarHHCCDni
(
	@PacienteCodigo varchar(8)
)
as
begin
begin try
	select h.[HHCCCodigo], h.[HHCCFecha], 
	p.[PacienteCodigo], p.[PacienteNombre], p.[PacienteApellido] 
	from [dbo].[HHCC] h
	right join Paciente p 
	on h.PacienteCodigo=p.PacienteCodigo
	where p.PacienteCodigo=@PacienteCodigo
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end 

alter proc usp_InsertarHHCC 
(	
    @PacienteCodigo varchar(8)
)
as
begin
begin try
INSERT INTO [dbo].[HHCC]
           ([HHCCFecha]
           ,[PacienteCodigo])
     VALUES
           (GETDATE(),@PacienteCodigo)
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end

create proc usp_ActualizarHHCC 
(
	@HHCCCodigo int,
	@PacienteCodigo varchar(8)
)
as
begin 
begin try
	UPDATE [dbo].[HHCC]
	SET [HHCCFecha] = getdate()
	   ,[PacienteCodigo] = @PacienteCodigo
 WHERE [HHCCCodigo]=@HHCCCodigo
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

------------------------------------------------------------------------------

create proc usp_CargaComboEspecialidad
as
begin
begin try
	select
	[EspecialidadCodigo], [EspecialidadDescripcion]
	from Especialidad
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_CargaComboEECC
as
begin
begin try
	select
	[EECCCodigo], [EECCDescripcion]
	from EECC
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_CargaComboGenero
as
begin
begin try
	select
	[GeneroCCodigo], [GeneroDescripcion]
	from Genero
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

------------------------------------------------

create proc usp_ListarActoMedico
AS
BEGIN
begin try
	select
		am.[ActoMedicoCodigo] 'AM-Codigo', 
		am.[ActoMedicoFecha] 'AM-Fecha', h.[HHCCCodigo] 'HHCC',
		p.PacienteNombre+' '+p.PacienteApellido 'Paciente',
		e.[EspecialistaCMP] 'CMP', 
		e.EspecialistaNombre+' '+e.EspecialistaApellido 'Especialista',
		[ActoMedicoObservacion] 'Observacion'
	from ActoMedico am
	join [dbo].[HHCC] h on am.HHCCCodigo=h.HHCCCodigo
	join [dbo].[Paciente] p on h.PacienteCodigo=p.PacienteCodigo
	join [dbo].[Especialista] e on am.EspecialistaCMP=e.EspecialistaCMP
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
END

create proc usp_ListarActoMedicoCodigo
(
	@ActoMedicoCodigo int
)
AS
BEGIN
begin try
	select
		am.[ActoMedicoCodigo] 'AM-Codigo', 
		am.[ActoMedicoFecha] 'AM-Fecha', h.[HHCCCodigo] 'HHCC',
		p.PacienteNombre+' '+p.PacienteApellido 'Paciente',
		e.[EspecialistaCMP] 'CMP', 
		e.EspecialistaNombre+' '+e.EspecialistaApellido 'Especialista',
		[ActoMedicoObservacion] 'Observacion'
	from ActoMedico am
	join [dbo].[HHCC] h on am.HHCCCodigo=h.HHCCCodigo
	join [dbo].[Paciente] p on h.PacienteCodigo=p.PacienteCodigo
	join [dbo].[Especialista] e on am.EspecialistaCMP=e.EspecialistaCMP
	where [ActoMedicoCodigo]=@ActoMedicoCodigo
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
END

create proc usp_InsertarActoMedico
(
	@ActoMedicoFecha datetime,
	@HHCCCodigo int,
	@EspecialistaCMP int,
	@ActoMedicoObservacion varchar(250)
)
as
begin
begin try
	INSERT INTO [dbo].[ActoMedico]
           ([ActoMedicoFecha]
           ,[HHCCCodigo]
           ,[EspecialistaCMP]
           ,[ActoMedicoObservacion])
     VALUES
           (@ActoMedicoFecha,@HHCCCodigo,
	@EspecialistaCMP,@ActoMedicoObservacion)
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

sp_helptext usp_ActualizarActoMedico

create proc usp_ActualizarActoMedico
(
	@ActoMedicoCodigo int,
	@ActoMedicoFecha datetime,
	@HHCCCodigo int,
	@EspecialistaCMP int,
	@ActoMedicoObservacion varchar(250)
)
with encryption 
as
begin 
begin try
	UPDATE [dbo].[ActoMedico]
	SET [ActoMedicoFecha] = @ActoMedicoFecha
      ,[HHCCCodigo] = @HHCCCodigo
      ,[EspecialistaCMP] = @EspecialistaCMP
      ,[ActoMedicoObservacion] = @ActoMedicoObservacion
 where [ActoMedicoCodigo]=@ActoMedicoCodigo
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

[ActoMedicoCodigo], [ActoMedicoFecha], [HHCCCodigo], [EspecialistaCMP], [ActoMedicoObservacion]

create proc ups_CargaComboEspecialista
as
begin
begin try
	select
	e.EspecialistaCMP,
	e.EspecialistaApellido+' '+e.EspecialistaNombre 'EspecialistaNombre'
	from Especialista e
	order by e.EspecialistaApellido asc
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end


create proc usp_BuscaHHCCDni
(
	@PacienteCodigo varchar(8)
)
as
begin
begin try
	select
	[HHCCCodigo], [HHCCFecha], [PacienteCodigo]
	from [dbo].[HHCC]
	where [PacienteCodigo]=@PacienteCodigo
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch
end 