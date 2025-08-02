--Operador AND, todos os valores devem ser válidos

--Pesquisando onde o nome for Adam e o sobrenome for Reynolds
SELECT * FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'



--Operador OR, pelo menos um dos valores de ser válido

--Pesquisando onde o nome for Adam ou o sobrenome for Reynolds
SELECT * FROM Clientes
WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds'



--Operador NOT, nega a ação, fazendo-a ter sentido contrário

--Pesquisando onde o nome não for Adam ou o sobrenome não for Reynolds
SELECT * FROM Clientes
WHERE NOT Nome = 'Adam' OR Sobrenome = 'Reynolds'



--BETWEEN (Entre um certo escopo)

--BETWEEN com número
SELECT * FROM Clientes
WHERE Idade BETWEEN 20 AND 30

--BETWEEN com textos
SELECT * FROM Clientes
WHERE Nome BETWEEN 'Eduardo' AND 'Leonardo'

--BETWEEN com datas
SELECT * FROM Clientes
WHERE DataCadastro BETWEEN #01/01/0001# AND #31/12/9999#



--LIKE (Procura por um padrão)

--Filtro (%)

--Buscando clientes cujos nomes comecem com a letra G
SELECT * FROM Clientes
WHERE Nome LIKE 'G%'

--Buscando clientes que tenham a letra G no nome
SELECT * FROM Clientes
WHERE Nome LIKE '%G%'

--Filtro (_)

--Buscando clientes cujos nomes comecem com a letra l e tenham 5 caracteres
SELECT * FROM Clientes
WHERE Nome LIKE 'L____'

--Buscando clientes que tenham a letra G no 3 caractere do nome e 7 caracteres
SELECT * FROM Clientes
WHERE Nome LIKE '__G___'

--Filtro ([])

--Buscando clientes cujos nomes comecem com a letra j, k ou n
SELECT * FROM Clientes
WHERE Nome LIKE '[jkn]%'

--Filtro (-)

--Buscando clientes cujos nomes comecem entre a letra a e f
SELECT * FROM Clientes
WHERE Nome LIKE '[a-f]%'

--Filtro (^)

--Buscando clientes cujos nomes não comecem entre a letra a e f
SELECT * FROM Clientes
WHERE Nome LIKE '[a-f]'



--IN (Especifica possíveis valores para uma coluna)
SELECT * FROM Clientes
WHERE Nome IN ('Leonardo', 'Eduardo', 'Marcos');



--Operador IS NULL, verifica se o valor é NULL

--Pesquisando clientes cujo nome está vazio
SELECT *
FROM Clientes
WHERE Nome IS NULL;



--Operador EXISTS, retorna TRUE se a subquery retornar um ou mais valores

--verificando se na tabela Clientes existe um cliente com nome Leonardo
SELECT *
FROM Clientes
WHERE EXISTS (SELECT * FROM Clientes WHERE Nome = 'Leonardo');



--Operador ANY, retorna TRUE se a subquery retornar um ou mais valores que combinem com a condição estabelecida

--Verificando se na tabela Clientes existe um cliente com nome Leonardo
SELECT *
FROM Clientes
WHERE Nome = 'Leonardo' ANY (SELECT * FROM Clientes);



--Operador ALL, retorna TRUE se todos valores retornados pela subquery, combinarem com a condição estabelecida

--Verificando se na tabela Clientes todos os cliente possuem o nome Leonardo
SELECT *
FROM Clientes
WHERE Nome = 'Leonardo' ALL (SELECT * FROM Clientes);