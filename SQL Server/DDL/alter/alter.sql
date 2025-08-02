--Comando ALTER, modifica uma tabela existente

--Adiciona uma coluna na tabela
ALTER TABLE Produtos
ADD DataCadastro DATETIME2

--Deleta uma coluna na tabela
ALTER TABLE Produtos
DROP COLUMN DataCadastro

--Renomeia uma coluna
ALTER TABLE Clientes
RENAME COLUMN DataCadastro to DataCadastro2;

--Modificar o tipo de uma coluna
ALTER TABLE Clientes
ALTER COLUMN DataCadastro DATETIME2;

--Adiciona constraint em uma coluna na tabela
ALTER TABLE Clientes
ADD CONSTRAINT PK_Cliente PRIMARY KEY (Id);