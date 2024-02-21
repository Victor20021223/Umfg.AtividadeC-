class Program
{
    static void Main()
    { 
        Console.Write("Digite o valor para conversão : ");
        double valorReal = Convert.ToDouble(Console.ReadLine());

        double valorDolar = valorReal * 0.193259;

        Console.WriteLine($"O Valor {valorReal} em Reais equivalem a {valorDolar} em Dólares");
    }
}
