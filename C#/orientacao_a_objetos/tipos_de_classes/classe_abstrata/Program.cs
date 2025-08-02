using classe_abstrata.Models;

//Classe abstrata tem como objetivo ser um modelo para ser herdado, portanto não pode ser instanciada

//Conta conta1 = new Conta(); //Não é possível instanciar uma classe abstrata

Corrente conta = new Corrente();
conta.Creditar(500);
conta.ExibirSaldo();