class Program
{
    static void Main()
    { 
        Console.Write("Digite o valor para conversão : ");
        double valorDolar = Convert.ToDouble(Console.ReadLine());
  
        double valorReal = valorDolar * 5.22;

        Console.WriteLine($"O Valor {valorDolar} em Dólares equivalem a {valorReal} em Reais");
    }
}
