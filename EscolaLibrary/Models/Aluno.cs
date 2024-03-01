using System;

namespace EscolaLibrary.Models
{
    public class Aluno : Pessoa
    {
        // Declarando minhas variavei
        public int Matricula { get; set; }
        public Escola Escola { get; set; } // Adicionando o atributo Escola erdando da classe ESCOLA

        // Construtor 
        public Aluno()
        {
        }
        public Aluno(string nome, int idade, int matricula, Escola escola) : base(nome, idade)
        {
            Matricula = matricula;
            Escola = escola;
        }

        // Método Aluno
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, minha matrícula é {Matricula} e estudo na faculdade {Escola.Nome}." +"\n");
        }
    }
}
