using EscolaLibrary.Models;

// instanciando a classe -----PESSOA-----

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Samuel Enderson Lima";
pessoa.Idade = 21;

Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Eduardo Fagundes";
pessoa2.Idade = 28;

pessoa.Apresentar();
pessoa2.Apresentar();

// instanciando a classe -----ESCOLA-----

Escola escola = new Escola("FIAP", "AVENIDA PAULISTA 1066");


escola.ExibirInformacoes();


// instanciando a classe -----ALUNO-----

Aluno aluno = new Aluno();

aluno.Nome = pessoa.Nome;
aluno.Idade = pessoa.Idade;
aluno.Matricula = 96677;
aluno.Escola = escola;


aluno.Apresentar();

// instanciando a classe -----PROFESSOR-----

Professor prof = new Professor();

prof.Nome = pessoa2.Nome;
prof.Idade = pessoa2.Idade;
prof.Disciplina = "MATEMATICA";
prof.Escola = escola;

prof.Apresentar();

// instanciando a classe -----NOTA-----

double[] notas = { 7.5, 8.0, 6.5, 9.0 }; // Exemplo de notas
Nota nota = new Nota("Matemática", notas);
double media = nota.CalcularMedia();

Console.WriteLine($"A média das notas em {nota.Disciplina} é {media}");
    

