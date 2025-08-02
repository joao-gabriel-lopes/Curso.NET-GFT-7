using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_curso.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int Quantidade = Alunos.Count();
            return Quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");

            for (int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "N° " + i + " " + Alunos[i].NomeCompleto;

                string texto = $"N° {i + 1} {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }

        }
    }
}