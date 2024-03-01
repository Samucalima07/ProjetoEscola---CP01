using System;

namespace EscolaLibrary.Models
{
    public class Pessoa
    {
        // Declarando minhas variaveis
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor 

        public Pessoa()
        {
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método comum a Aluno e Professor
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos." + "\n");
        }
    }
}
