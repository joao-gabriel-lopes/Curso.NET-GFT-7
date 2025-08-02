--Comando CASE, passa por condições para determinar uma ação, caso nenhuma seja verdadeira, o ELSE será executado

--Estrutura base
CASE
    WHEN Condição1 THEN resultado1
    WHEN Condição2 THEN resultado2
    WHEN CondiçãoN THEN resultadoN
    ELSE resultado
END;

--Verifica a quantidade de cada pedido, passando por várias condições para determinar um texo
SELECT IdPedido, Quantidade,
CASE
    WHEN Quantidade > 30 THEN 'A quantidade é maior que 30'
    WHEN Quantidade = 30 THEN 'A quantidade é 30'
    ELSE 'A quantidade é menor que 30'
END AS TextoQuantidade
FROM PedidosDetalhes;