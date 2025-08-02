--Comando RIGHT JOIN, relaciona tabelas pegando todas as linhas da tabela da direita e completando com os valores da tabela da esquerda. Se a tabela alguma linha da tabela da direita não possuir valor ele assumirá o valor NULL
--Exemplo: Relacionamos a coluna Clientes com a Enderecos através das colunas Id e IdCliente, respectivamente. Todas as linhas da tabela Enderecos serão retornadas e as linhas vazias da coluna Clientes serão preenchidas com NULL

--Juntando a tabela enderecos com a tabela clientes
SELECT *
FROM Clientes
RIGHT JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente

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
RIGHT JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente