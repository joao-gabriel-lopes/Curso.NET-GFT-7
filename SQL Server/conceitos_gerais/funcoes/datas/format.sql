--Comando FORMAT, Modifica o formato que uma data é mostrada

--(d) são os dias
--(M) são os meses
--(y) são os anos
--(H/h) são as horas (H mostra formato 24H, h mostra formato 12H)
--(m) são os minutos
--(s) são os segundos

--Formatando a data de cadastro dos clientes
SELECT Nome, FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') FROM Clientes