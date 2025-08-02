using classe_curso.Models;

Pessoa pessoa1 = new Pessoa("Leonardo", "Buta");

Pessoa pessoa2 = new Pessoa(nome: "Eduardo", sobrenome: "Albuquerque");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(pessoa1);
cursoDeIngles.AdicionarAlunos(pessoa2);

cursoDeIngles.ListarAlunos();