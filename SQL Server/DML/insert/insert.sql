--Adiciona valores dentro de uma tabela

--Adicionando valores especificando as colunas (é possível mudar a onde de inserção dos dados)
INSERT INTO CLientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Leonardo', 'Buta', 'email@gmail.com', 1, GETDATE())

--Adicionando valores sem especificar as colunas
INSERT INTO Clientes 
VALUES ('Leonardo', 'Buta', 'email@gmail.com', 1, GETDATE())