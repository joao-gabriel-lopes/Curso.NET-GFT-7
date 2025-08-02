--Comando DATEDIFF, faz a diferença entre duas datas, podendo retornar o tempo em diferentes formatos (ano, mês, dia, hora, minuto, segundo)

--Fazendo a diferença entre duas datas e retornando o valor em anos
SELECT DATEDIFF(year, '2017/08/25', '2011/08/25') AS DateDiff;