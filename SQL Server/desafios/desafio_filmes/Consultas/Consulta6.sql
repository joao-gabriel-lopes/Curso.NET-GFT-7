--Consulta de número 6

--Código SQL
SELECT
    Nome,
    Ano,
    Duracao
FROM Filmes
WHERE Duracao > 100
AND Duracao < 150
ORDER BY Duracao