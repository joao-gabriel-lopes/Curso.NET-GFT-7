--Comando GETDATE, retorna o horário atual do dispositivo

--Atualizando a data de cadastro do cliente de id 1004
UPDATE Clientes
SET DataCadastro = GETDATE()
WHERE Id = 1004