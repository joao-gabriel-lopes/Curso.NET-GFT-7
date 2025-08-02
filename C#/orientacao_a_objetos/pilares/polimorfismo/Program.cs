using polimorfismo.Models;

//Polimorfismo permite sobrescrever métotos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação

Aluno aluno1 = new Aluno();
aluno1.Nome = "Guilherme";
aluno1.Idade = 16;
aluno1.Nota = 8.5;
aluno1.Apresentar();

Professor professor1 = new Professor();
professor1.Nome = "Enéias";
professor1.Idade = 45;
professor1.Salario = 2500M;
professor1.Apresentar();