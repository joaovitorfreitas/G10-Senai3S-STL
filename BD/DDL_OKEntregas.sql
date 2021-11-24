CREATE DATABASE OKEntregas

USE OKEntregas

Go

CREATE TABLE Usuarios
(
		IdUsuario INT IDENTITY PRIMARY KEY NOT NULL,
		Nome VARCHAR(200) NOT NULL,
		Sobrenome VARCHAR(200) NOT NULL,
		Email VARCHAR(200) UNIQUE NOT NULL,
		Senha VARCHAR(200) NOT NULL,
		TipoUsuario VARCHAR(50) NOT NULL,
		VerificacaoEmail BIT NOT NULL
);

GO

CREATE TABLE Empresa (
		IdEmpresa INT IDENTITY PRIMARY KEY NOT NULL,
		NomeEmpresa VARCHAR(255) NOT NULL,
		NumeroDeFuncionarios INT NOT NULL ,
		NumeroDeTelefone VARCHAR(13),	/* Tipo Int Mudado para varchar*/
		EmailEmpresa VARCHAR(255) NOT NULL,
		NomeFantasia VARCHAR(255),
		Cnpj VARCHAR (14) NOT NULL,
		SegmentoDeMercado VARCHAR(255) NOT NULL
);

CREATE TABLE UsuarioLeads(
		IdUsuarioLeads INT IDENTITY PRIMARY KEY NOT NULL,
		statusLead VARCHAR(255) NOT NULL,
		Nome VARCHAR (255) NOT NULL,
		Email VARCHAR(255) NOT NULL,
		Cargo VARCHAR(255) NOT NULL
);

GO

CREATE TABLE Leads(
		IdLeads INT IDENTITY PRIMARY KEY NOT NULL,
		Score VARCHAR (100) NOT NULL,
		Telefone VARCHAR(13) NOT NULL,	
		Necessidades VARCHAR (255) NOT NULL,
		IdUsuarioLeads INT FOREIGN KEY REFERENCES UsuarioLeads(IdUsuarioLeads) NOT NULL,
		IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa) NOT NULL 
);

GO

CREATE TABLE Reuniao(
		IdReuniao INT IDENTITY PRIMARY KEY NOT NULL,
		DataInicio DATETIME NOT NULL, 
		DataTermino DATETIME NOT NULL,
		ATA VARCHAR(255),
		IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario) NOT NULL,
		IdLeads INT FOREIGN KEY REFERENCES Leads(IdLeads) NOT NULL,
);

GO


