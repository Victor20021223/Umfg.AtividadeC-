using System;

struct Livro
{
    public string Titulo;
    public string Autor;
    public decimal Valor;

    public override string ToString()
    {
        return $"Título: {Titulo}\nAutor: {Autor}\nValor: {Valor:C}\n";
    }
}

class Program
{
    static void Main()
    {
        Livro livroCadastrado = CadastrarLivro();

        Console.WriteLine("\nLivro Cadastrado:\n" + livroCadastrado.ToString());
    }

    static Livro CadastrarLivro()
    {
        Livro livro;

        Console.Write("Digite o título do livro: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Digite o valor do livro: ");
        livro.Valor = Convert.ToDecimal(Console.ReadLine());

        return livro;
    }
}
