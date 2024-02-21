class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nomeUsuario = Console.ReadLine();

        Console.Write("Digite sua data de nascimento (no formato dd/mm/aaaa): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        int idade = CalcularIdade(dataNascimento);

        string faixaEtaria = DeterminarFaixaEtaria(idade);

        Console.WriteLine($"{nomeUsuario}, você está na faixa etária de {faixaEtaria}.");
    }

    static int CalcularIdade(DateTime dataNascimento)
    {
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - dataNascimento.Year;

        if (dataNascimento.Date > dataAtual.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }

    static string DeterminarFaixaEtaria(int idade)
    {
        if (idade >= 0 && idade <= 19)
        {
            return "Jovem";
        }
        else if (idade >= 20 && idade <= 59)
        {
            return "Adulto";
        }
        else
        {
            return "Idoso";
        }
    }
}
