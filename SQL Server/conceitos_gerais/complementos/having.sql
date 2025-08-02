--Comando HAVING, filtra valores específicos dentro de uma tabela, precisando usar funções aggregate ou GROUP BY

--Pesquisando nomes de clientes que aparecem mais de uma vez
SELECT 
    Nome
FROM Clientes 
GROUP BY Nome
HAVING COUNT(Nome) > 1
