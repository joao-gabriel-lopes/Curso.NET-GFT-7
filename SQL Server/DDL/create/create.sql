--Comando CREATE, cria uma tabela ou banco de dados

--Criando um banco de dados
CREATE DATABASE Produtos

--Criando uma tabela de produtos
CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)