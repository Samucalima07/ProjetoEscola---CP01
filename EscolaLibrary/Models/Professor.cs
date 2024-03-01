using System;

namespace EscolaLibrary.Models
{
    public class Professor : Pessoa
    {
        // Variaveis
        public string Disciplina { get; set; }
        public Escola Escola { get; set; } // Adicionando o atributo Escola erdando da classe ESCOLA
        // Construtor 
        public Professor()
        {
        }
        public Professor(string nome, int idade, string disciplina, Escola escola) : base(nome, idade)
        {
            Disciplina = disciplina;
            Escola = escola; // Definindo a escola
        }

        // Método Professor
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, leciono {Disciplina} na escola {Escola.Nome}." + "\n");
        }
    }
}
