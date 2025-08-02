--Comando MAX, retorna o maior valor de uma coluna

--Pegando o maior preço
SELECT MAX(Preco) FROM Produtos

--Pegando o maior preço de produtos tamanho M
SELECT MAX(Preco) FROM Produtos
WHERE Tamanho = 'M'



--Comando MIN, retorna o menor valor de uma coluna

--Pegando o menor preço
SELECT MIN(Preco) FROM Produtos

--Pegando o menor preço de produtos tamanho M
SELECT MIN(Preco) FROM Produtos
WHERE Tamanho = 'M'



--Comando AVG, retorna a média de uma coluna

--Pegando a média de preço dos produtos
SELECT AVG(Preco) FROM Produtos

--Pegando a média de preço de produtos tamanho M
SELECT AVG(Preco) FROM Produtos
WHERE Tamanho = 'M'
