--Comando LEFT JOIN, relaciona tabelas pegando todas as linhas da tabela da esquerda e completando com os valores da tabela da direita. Se a tabela alguma linha da tabela da direita não possuir valor ele assumirá o valor NULL
--Exemplo: Relacionamos a coluna Clientes com a Enderecos através das colunas Id e IdCliente, respectivamente. Todas as linhas da tabela Clientes serão retornadas e as linhas vazias da coluna Enderecos serão preenchidas com NULL

--Juntando a tabela enderecos com a tabela clientes
SELECT *
FROM Clientes
LEFT JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente

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
LEFT JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente