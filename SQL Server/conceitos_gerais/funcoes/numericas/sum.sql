--Comando Sum, soma os valores de uma coluna de uma tabela

--Somando o total de preços
SELECT SUM(Preco) PrecoTotal FROM Produtos

--Somando o total de preços de produtos de tamanho M
SELECT SUM(Preco) PrecoTotalProdutosTamanhoM FROM Produtos
WHERE Tamanho = 'M'

