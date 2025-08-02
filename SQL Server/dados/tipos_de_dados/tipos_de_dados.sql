--Tipos STRING

char(n) --Número fixo de caracteres (n)  --Máximo: 8000 caracteres
varchar(n) --Número variável de caracteres (n)  --Máximo: 8000 caracteres
varchar(max) --Número variável de caracteres (max)  --Máximo: 1073741824 caracteres
text --Número variável de caracteres --Máximo: 2GB de texto
nchar(n) --Número fixo de caracteres com Unicode (n)  --Máximo: 4000 caracteres
nvarchar(n) --Número variável de caracteres com Unicode (n)  --Máximo: 4000 caracteres
nvarchar(max) --Número variável de caracteres com Unicode (max)  --Máximo: 536870912 caracteres
ntext --Número variável de caracteres com Unicode  --Máximo: 2GB de texto
binary(n) --Número fixo de caracteres binários (n) --Máximo: 8000 bytes
varbinary(n) --Número variável de caracteres binários (n)  --Máximo: 8000 bytes
varbinary(max) --Número variável de caracteres binários (max)  --Máximo: 2GB
image --Número variável de caracteres binários  --Máximo: 2GB


--Tipos NUMÉRICOS

bit --Inteiro que pode representar 0, 1 ou NULL
tinyint --Permite números inteiros entre 0 e 255
smallint --Permite números inteiros entre -32768 32767
int --Permite números inteiros entre -2147483648 a 2147483647
bigint -- Permite números inteiros entre -9223372036854775808 a 9223372036854775807
decimal(p, s) --Permite números com casas decimais, onde (p, max: 38, default: 18) é o número de dígitos que o número pode ter e o (s, default: 0) é o número máximo de casas decimais
numeric(p, s) --Permite números com casas decimais, onde (p, max: 38, default: 18) é o número de dígitos que o número pode ter e o (s, default: 0) é o número máximo de casas decimais
smallmoney --Permite números monetários entre -2147483648 a 2147483647
money -- Permite números monetários entre -9223372036854775808 a 9223372036854775807
float(n) --Permite números com casas decimais, (n, 24 ou 53, default: 53) é o tamanho que ele ocupa, sendo (24) 4 bytes e (53) 8 bytes
real --Permite números com casas decimais, com o dobro da capacidade do float


--Tipos DATA
datetime --Permite datas de 01/01/1753 a 31/12/9999, com precisão de 3.33 milisegundos
datetime2 --Permite datas de 01/01/0001 a 31/12/9999, com precisão de 100 nanosegundos
smalldatetime --Permite datas de 01/01/1900 a 06/06/2079, com precisão de 1 minuto
date --Permite apenas datas de 01/01/0001 a 31/12/9999
time --Permite apenas tempo, com precisão de 100 nanosegundos
datetimeoffset --Permite datas de 01/01/0001 a 31/12/9999, com precisão de 100 nanosegundos e com um fuso horário definido
timestamp --Contém um número único que é atualizado toda vez que uma linha é criada ou modificada. Cada tabela só pode possuir uma variável do tipo timestamp
