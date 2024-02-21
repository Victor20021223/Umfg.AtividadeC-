class Program
{
    static void Main()
    {
        Console.Write("Informe a distância total percorrida em KM: ");
        double distanciaTotalKM = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o gasto de combustível em litros: ");
        double gastoCombustivelLitros = Convert.ToDouble(Console.ReadLine());

        double mediaConsumo = distanciaTotalKM / gastoCombustivelLitros;

        Console.WriteLine($"A média de consumo do automóvel é de {mediaConsumo} KM/L");
    }
}
