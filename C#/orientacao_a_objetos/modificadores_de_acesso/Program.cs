//Instanciando a classe

using modificadores_de_acesso.Models;

Pessoa pessoa1 = new Pessoa();


//Modificador PUBLIC

//Permite o acesso livre para consultar e modificar os atributos (pode ser herdado)
pessoa1.Idade = 25;

//Modificador PRIVATE

//barra o acesso para consultar e modificar os atributos, necessitando de um método GET e SET (além de não poder ser heradado)
pessoa1.Nome = "José";

//Modificador PROTECTED

//barra o acesso para consultar e modificar os atributos, necessitando de um método GET e SET (poder ser heradado)
pessoa1.Sobrenome = "Carvalho";


//Executando o método apresentar

pessoa1.Apresentar();