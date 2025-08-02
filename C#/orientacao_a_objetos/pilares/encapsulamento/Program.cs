using encapsulamento.Models;

//Encapsulamento consiste em proteger um classe e definir limites para a alterção de suas propriedades, buscando ocultar seu comportamento e expor somente o necessário.

ContaCorrente conta1 = new ContaCorrente(123, 1000);

conta1.ExibirSaldo();
conta1.Sacar(500);
conta1.ExibirSaldo();