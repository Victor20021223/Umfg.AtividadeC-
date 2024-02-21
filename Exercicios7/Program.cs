using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nomeUsuario = Console.ReadLine();

        string nomeMinusculo = nomeUsuario.ToLower();

        int contadorConsoantes = 0;

        foreach (char caractere in nomeMinusculo)
        {
            if (IsConsoante(caractere))
            {
                contadorConsoantes++;
            }
        }

        Console.WriteLine($"O nome {nomeUsuario} possui {contadorConsoantes} consoantes.");
    }

    static bool IsConsoante(char c)
    {
        return char.IsLetter(c) && !"aeiou".Contains(c);
    }
}
