class Program
{
    static void Main()
    {
        Console.Write("Informe o ano de nascimento: ");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());

        int anoAtual = DateTime.Now.Year;

        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Sua idade é: {idade} anos");
    }
}
