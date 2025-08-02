--Comando COUNT, conta o número de linhas de uma tabela

--Contando o número de produtos
SELECT COUNT(*) FROM Produtos

--Contando o número de produtos com preço menor que 30
SELECT COUNT(*) FROM Produtos
WHERE Preco > 30

--Contando o número de produtos com tamanho M
SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos
WHERE Tamanho = 'M'