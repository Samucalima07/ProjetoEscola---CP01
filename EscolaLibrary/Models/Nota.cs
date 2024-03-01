using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaLibrary.Models
{
    public class Nota
    {
        public string Disciplina { get; set; }
        public double[] Valores { get; set; } // Estou colocando um array para o programa aceitar uma lista de notas

        // Construtor
        public Nota() { }
        public Nota(string disciplina, double[] valores)
        {
            Disciplina = disciplina;
            Valores = valores;
        }

        // Método de calcular a média das notas
        public double CalcularMedia()
        {
            double soma = 0;
            foreach (double valor in Valores)
            {
                soma += valor;
            }
            return soma / Valores.Length;
        }
    }
}
