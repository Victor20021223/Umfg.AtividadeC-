class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nomeUsuario = Console.ReadLine();

        string nomeMinusculo = nomeUsuario.ToLower();

        int contadorVogais = 0;

        foreach (char caractere in nomeMinusculo)
        {
            if (IsVogal(caractere))
            {
                contadorVogais++;
            }
        }

        Console.WriteLine($"O nome {nomeUsuario} possui {contadorVogais} vogais.");
    }

    static bool IsVogal(char c)
    {
        return "aeiou".Contains(c);
    }
}
