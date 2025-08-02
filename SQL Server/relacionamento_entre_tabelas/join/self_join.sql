--Comando SELF JOIN, relaciona uma tabela consigo mesma, pegando as linhas que condizerem com a condição
--Exemplo: Relacionamos a coluna Clientes com si mesma. As linhas da tabela que possuírem o mesmo nome e um id diferente serão mostradas

--Juntando a tabela Clientes com si mesma
SELECT *
FROM Clientes A, Clientes B
WHERE A.Id <> B.Id
AND A.Sobrenome <> B.Sobrenome
AND A.Nome = B.Nome
ORDER BY A.Nome;

--Juntando a tabela Clientes com si mesma, mas selecionando dados específicos
SELECT 
    A.Sobrenome,
    B.Sobrenome,
    A.Nome
FROM Clientes A, Clientes B
WHERE A.Id <> B.Id
AND A.Sobrenome <> B.Sobrenome
AND A.Nome = B.Nome
ORDER BY A.Nome;