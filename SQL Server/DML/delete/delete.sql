--Comando UPDATE, deleta os dados de uma tabela

--Fazer um SELECT antes, para verificar os campos a serem deletados
SELECT * FROM CLientes WHERE Nome = "Eduardo"

--Comandos para criar um "checkpoint", em caso de necessidade de voltar o código
BEGIN TRAN
ROLLBACK

--Deletando o cliente com id 1004 da tabela
DELETE Clientes
WHERE Id = 1004

--Deletando os clientes com nome Leonardo
DELETE Clientes
WHERE Nome = 'Leonardo'