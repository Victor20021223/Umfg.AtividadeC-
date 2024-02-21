using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public int TotalFaltas { get; set; }

    public double CalcularMedia()
    {
        return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    }

    public double CalcularPercentualFrequencia()
    {
        return (25 - TotalFaltas) / 25.0 * 100;
    }

    public string ObterSituacao()
    {
        double media = CalcularMedia();
        double frequencia = CalcularPercentualFrequencia();

        if (frequencia >= 75 && media >= 7)
        {
            return "APROVADO";
        }
        else
        {
            return "REPROVADO";
        }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nRA: {RA}\nNota Prova: {NotaProva}\nNota Trabalho: {NotaTrabalho}\n" +
               $"Média: {CalcularMedia():F2}\nTotal de Faltas: {TotalFaltas}\n" +
               $"Percentual de Frequência: {CalcularPercentualFrequencia():F2}%\nSituação: {ObterSituacao()}\n";
    }
}

class Program
{
    static void Main()
    {
        List<Aluno> listaAlunos = new List<Aluno>();

        while (true)
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Cadastro de Notas");
            Console.WriteLine("3 - Cadastro Total de Faltas");
            Console.WriteLine("4 - Relação de Alunos, Notas, Média, Faltas e Situação");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarAluno(listaAlunos);
                    break;
                case 2:
                    CadastrarNotas(listaAlunos);
                    break;
                case 3:
                    CadastrarFaltas(listaAlunos);
                    break;
                case 4:
                    ExibirRelacaoAlunos(listaAlunos);
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CadastrarAluno(List<Aluno> listaAlunos)
    {
        Aluno aluno = new Aluno();

        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite o RA do aluno: ");
        aluno.RA = Console.ReadLine();

        listaAlunos.Add(aluno);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void CadastrarNotas(List<Aluno> listaAlunos)
    {
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();

        Aluno aluno = ProcurarAlunoPorRA(listaAlunos, ra);

        if (aluno != null)
        {
            Console.Write("Digite a nota da prova (máximo 10): ");
            double notaProva = Math.Max(0, Math.Min(10, Convert.ToDouble(Console.ReadLine())));

            Console.Write("Digite a nota do trabalho (máximo 10): ");
            double notaTrabalho = Math.Max(0, Math.Min(10, Convert.ToDouble(Console.ReadLine())));

            aluno.NotaProva = notaProva;
            aluno.NotaTrabalho = notaTrabalho;

            Console.WriteLine("Notas cadastradas com sucesso!");
        }
    }

    static void CadastrarFaltas(List<Aluno> listaAlunos)
    {
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();

        Aluno aluno = ProcurarAlunoPorRA(listaAlunos, ra);

        if (aluno != null)
        {
            Console.Write("Digite o total de faltas do aluno: ");
            int totalFaltas = Math.Max(0, Convert.ToInt32(Console.ReadLine()));

            aluno.TotalFaltas = totalFaltas;

            Console.WriteLine("Total de faltas cadastrado com sucesso!");
        }
    }

    static void ExibirRelacaoAlunos(List<Aluno> listaAlunos)
    {
        Console.WriteLine("\nRelação de Alunos, Notas, Média, Faltas e Situação:");

        foreach (Aluno aluno in listaAlunos)
        {
            Console.WriteLine(aluno.ToString());
        }
    }

    static Aluno ProcurarAlunoPorRA(List<Aluno> listaAlunos, string ra)
    {
        Aluno aluno = listaAlunos.Find(a => a.RA == ra);

        if (aluno == null)
        {
            Console.WriteLine("Aluno não encontrado.");
        }

        return aluno;
    }
}
