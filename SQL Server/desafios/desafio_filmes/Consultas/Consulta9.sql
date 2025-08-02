--Consulta de número 9

--Código SQL
SELECT
    Id,
    PrimeiroNome,
    UltimoNome,
    Genero
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome