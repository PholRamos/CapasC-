create database DB_Clinica
on
(
    name='DB_Clinica_Data',
    filename = 'F:\ProyectoLP\BD\DB_Clinica_Data.mdf',
    size = 5Mb,
    maxsize = unlimited,
    filegrowth=1mb
)
log on
(
    name='DB_Clinica_Log',
    filename = 'F:\ProyectoLP\BD\DB_Clinica_Log.ldf',
    size = 5Mb,
    maxsize = unlimited,
    filegrowth=1mb
)

use DB_Clinica

create table EECC
(
    EECCCodigo int identity primary key not null,
    EECCDescripcion varchar(10)
)

create table Genero
(
    GeneroCodigo int identity primary key not null,
    GeneroDescripcion varchar(10)
)

create table Especialidad
(
    EspecialidadCodigo int identity primary key not null,
    EspecialidadDescripcion varchar(30)
)

create table Paciente
(
    PacienteDNI varchar(8) primary key not null,
    PacienteNombre varchar(50),
    PacienteApellido varchar(50),
    PacienteTelefono int,
    PacienteDireccion varchar(100),
    EECCCodigo int foreign key (EECCCodigo) references EECC,
    GeneroCodigo int foreign key (GeneroCodigo) references Genero
)

create table HistoriaClinica
(
    HHCCCodigo int identity primary key not null,
    PacienteDNI varchar(8) foreign key (PacienteDNI) references Paciente,
    HHCCFechaCreacion datetime
)

create table ActoMedico
(
    ActoMedicoCodigo int identity primary key not null,
    HHCCCodigo int foreign key (HHCCCodigo) references HistoriaClinica,
    ActoMedicoFecha datetime,
    EspecialidadCodigo int foreign key(EspecialidadCodigo) references Especialidad,
    ActoMedicoConsulta varchar(250)    
)

create table PacienteDiabetes
(
    ActoMedicoCodigo int foreign key (ActoMedicoCodigo) references ActoMedico,
    Embarazos int,
    Glucosa float,
    PresionArterial float,
    EspesorPiel float,
    Insulina float,
    BMI float,
    DiabetesPedigreeFunction float,
    Age int,
    Resultado BIT
)

--CREACION DE PROCEDIMIENTOS ALMACENADOS
create proc usp_listaPaciente
as
BEGIN
    begin try
        select * from Paciente
    end try
    begin CATCH
        select ERROR_NUMBER(),ERROR_MESSAGE()
    end CATCH
END

create proc usp_guardaPaciente
(
	@PacienteDNI varchar(8),
	@PacienteNombre varchar(50),
	@PacienteApellido varchar(50),
	@PacienteTelefono int,
	@PacienteDireccion varchar(100),
	@EECCCodigo int,
	@GeneroCodigo int
)
as
begin
begin try
INSERT INTO [dbo].[Paciente]
           ([PacienteDNI]
           ,[PacienteNombre]
           ,[PacienteApellido]
           ,[PacienteTelefono]
           ,[PacienteDireccion]
           ,[EECCCodigo]
           ,[GeneroCodigo])
     VALUES
           (@PacienteDNI,@PacienteNombre,@PacienteApellido,@PacienteTelefono,@PacienteDireccion,@EECCCodigo,@GeneroCodigo)
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_modificaPaciente
(
	@PacienteDNI varchar(8),
	@PacienteNombre varchar(50),
	@PacienteApellido varchar(50),
	@PacienteTelefono int,
	@PacienteDireccion varchar(100),
	@EECCCodigo int,
	@GeneroCodigo int
)
as
begin
begin try
	UPDATE [dbo].[Paciente]
	SET [PacienteDNI] = @PacienteDNI
      ,[PacienteNombre] = @PacienteNombre
      ,[PacienteApellido] = @PacienteApellido
      ,[PacienteTelefono] = @PacienteTelefono
      ,[PacienteDireccion] = @PacienteDireccion
      ,[EECCCodigo] = @EECCCodigo
      ,[GeneroCodigo] = @GeneroCodigo
 WHERE [PacienteDNI] = @PacienteDNI
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end

create proc usp_eliminaPaciente
(
	@PacienteDNI varchar(8)
)
as
begin
begin try
DELETE FROM [dbo].[Paciente]
      WHERE [PacienteDNI] = @PacienteDNI
end try
begin catch
	select ERROR_NUMBER(),ERROR_MESSAGE()
end catch
end