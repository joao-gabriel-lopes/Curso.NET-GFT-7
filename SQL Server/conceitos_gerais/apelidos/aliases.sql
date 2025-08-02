--Comando ALIAS, fornece apelidos para as tabelas ou colunas, facilitando o código

--Selecionando o IdCliente da tabela Enderecos como Id
SELECT IdCliente AS Id
FROM Enderecos;

--Juntando a tabela enderecos com a tabela clientes, mas com apelidos
SELECT 
    C.Nome,
    C.Sobrenome,
    C.Email,
    E.Rua,
    E.Bairro,
    E.Cidade,
    E.Estado
FROM Clientes C
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 4