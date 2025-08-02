--Consulta de número 7

--Código SQL
SELECT
    Ano,
    Count(*) AS Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC