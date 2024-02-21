class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            int opcao = Convert.ToByte(Console.ReadLine());

            if (opcao == 0)
            {
                Console.WriteLine("Encerrando a calculadora.");
                break;
            }

            if(opcao > 4 || opcao < 0) 
            {
                Console.WriteLine("Opção inválida!!!");
                Console.WriteLine("Selecione apenas opção demostradas abaixo!!!\n");
            }

            if(opcao > 0 && opcao <= 4) 
            { 

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Resultado de 0, já que o valor divido por 0 será 0 \n");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
            }

            Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
