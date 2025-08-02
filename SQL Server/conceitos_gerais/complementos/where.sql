--Comando WHERE, filtra valores específicos dentro de uma tabela

--Pesquisando onde o nome for ADAM
SELECT * FROM Clientes
WHERE Nome = 'Adam'

--Pesquisando onde o nome for Adam e o sobrenome for Reynolds
SELECT * FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'

--Pesquisando onde o nome for Adam ou o sobrenome for Reynolds
SELECT * FROM Clientes
WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds'

--Pesquisando clientes que aceitam comunicados
SELECT * FROM Clientes
WHERE AceitaComunicados = 1
