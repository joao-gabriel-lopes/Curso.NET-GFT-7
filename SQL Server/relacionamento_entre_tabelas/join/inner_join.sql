--Comando INNER JOIN, relaciona tabelas pegando apenas as linhas que tenham valores nas duas colunas que se relacionam
--Exemplo: Relacionamos a coluna Clientes com a Enderecos através das colunas Id e IdCliente, respectivamente. Apenas as linhas que possuirem valores em ambas as colunas irão aparecer.

--Juntando a tabela enderecos com a tabela clientes
SELECT *
FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4

--Juntando a tabela enderecos com a tabela clientes, mas selecionando dados específicos
SELECT 
    Clientes.Nome,
    Clientes.Sobrenome,
    Clientes.Email,
    Enderecos.Rua,
    Enderecos.Bairro,
    Enderecos.Cidade,
    Enderecos.Estado
FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente