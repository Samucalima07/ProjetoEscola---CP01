using System;

namespace EscolaLibrary.Models
{
    public class Escola
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        // Construtor da classe Escola
        public Escola(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        // Método escola
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Escola: {Nome}\nEndereço: {Endereco}" + "\n");
        }
    }
}
