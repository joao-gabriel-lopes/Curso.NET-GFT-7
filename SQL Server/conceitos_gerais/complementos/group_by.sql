--Comando GROUP BY, agrupa valores de acordo com uma condição

--Agrupando os produtos por tamanho
SELECT Tamanho, COUNT(*) Quantidade
FROM Produtos
GROUP BY Tamanho

--Agrupando os produtos por tamanho e ordenando por quantidade
SELECT Tamanho, COUNT(*) Quantidade
FROM Produtos
GROUP BY Tamanho
ORDER BY Quantidade DESC