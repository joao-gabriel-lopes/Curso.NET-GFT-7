--PRIMARY KEY. Chave única que identifica cada registro na tabela

--FOREIGN KEY. Chave que identifica e relaciona um registro existente em outra tabela


--Criando tabela Clientes com Primary Key (Id)
CREATE TABLE dbo.Clientes(
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NULL,
	Sobrenome varchar(255) NULL,
	Email varchar(255) NULL,
	AceitaComunicados bit NULL,
	DataCadastro datetime2(7) NULL
)

--Criando tabela Enderecos com Foreign Key (IdCliente)
CREATE TABLE Enderecos(
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdCliente int NULL,
    Rua varchar(255) NULL,
    Bairro varchar(255) NULL,
    Cidade varchar(255) NULL,
    Estado char(2) NULL,

    --Criando a relação entre Id da tabela Clientes e IdCliente da tabela Enderecos
    CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
    REFERENCES Clientes(Id)
)