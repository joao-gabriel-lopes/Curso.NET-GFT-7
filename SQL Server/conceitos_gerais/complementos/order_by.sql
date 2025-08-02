--Comando ORDER BY, organiza os dados de uma pesquisa realizada com SELECT

--ORdenando com base no nome
SELECT * FROM Clientes
ORDER BY Nome

--Ordenando de maneira crescente
SELECT * FROM Clientes
ORDER BY Sobrenome ASC

--Ordenando de maneira decrescente
SELECT * FROM Clientes
ORDER BY Sobrenome DESC

--Ordenando de com duas colunas
SELECT * FROM Clientes
ORDER BY Nome, Sobrenome