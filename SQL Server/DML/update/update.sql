--Comando UPDATE, atualiza os dados de uma tabela

--Fazer um SELECT antes, para verificar os campos a serem atualizados
SELECT * FROM CLientes WHERE Nome = "Eduardo"

--Comandos para criar um "checkpoint", em caso de necessidade de voltar o código
BEGIN TRAN
ROLLBACK

--Atualizando os dados do cliente com id 1002
UPDATE Clientes
SET Email = 'emailatualizado@gmail.com', 
	AceitaComunicados = 0
WHERE Id = 1002

--Atualizando os dados do clientes com nome Eduardo
UPDATE Clientes
SET Email = 'emailatualizado@gmail.com', 
	AceitaComunicados = 0
WHERE Nome = "Eduardo"