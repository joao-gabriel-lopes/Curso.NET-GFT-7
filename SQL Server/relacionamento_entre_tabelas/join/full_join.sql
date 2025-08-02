--Comando FULL JOIN, relaciona tabelas pegando todas as linhas de todas as tabelas, independentemente se há valores que se relacionam ou não
--Exemplo: Relacionamos a coluna Clientes com a Enderecos através das colunas Id e IdCliente, respectivamente. Todas as linhas da tabela Enderecos e da tabela Clientes serão retornadas, desde que tenham um valor

--Juntando a tabela enderecos com a tabela clientes
SELECT *
FROM Clientes
FULL JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente

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
FULL JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente