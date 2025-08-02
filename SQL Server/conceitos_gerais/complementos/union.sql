--Comando UNION, combina o resultado de dois ou mais SELECTS. as condições passadas devem possuir o mesmo número de colunas e com tipos de dados semelhantes, além disso, as colunas devem estar na mesma ordem
--UNION retorna apenas valores distintos
--UNION ALL retorna todos os valores

--Selecionando as cidades dos clientes e dos fornecedores (UNION)
SELECT Cidade FROM Clientes
UNION
SELECT Cidade FROM Fornecedores
ORDER BY Cidade;

--Selecionando as cidades dos clientes e dos fornecedores (UNION ALL)
SELECT Cidade FROM Clientes
UNION ALL
SELECT Cidade FROM Fornecedores
ORDER BY Cidade;