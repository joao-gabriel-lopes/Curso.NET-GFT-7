//Herança visa agrupar características comuns entre diversas classes em uma classe mais genérica, na qual as outras classes irão herdar essas características, evitando a duplicação de código e facilitando a manutenção

using heranca.Models;

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