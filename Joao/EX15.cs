public struct TipoFuncionario
{
    public int Numero;
    public string Nome;
    public float[] SalarioMes;
    public float SalarioAno;
}

class Program
{
    static void Main()
    {
        TipoFuncionario func = new TipoFuncionario();
        float salAno = 0.0f;

        Console.WriteLine("Informe o código do funcionário:");
        func.Numero = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Informe o nome do funcionário:");
        func.Nome = Console.ReadLine() ?? "";

        func.SalarioMes = new float[12];

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Informe o salário do mês {i + 1}:");
            func.SalarioMes[i] = float.Parse(Console.ReadLine() ?? "");
            salAno += func.SalarioMes[i];
        }

        func.SalarioAno = salAno;

        Console.WriteLine("*************************************************************");
        Console.WriteLine("*************************************************************");

        Console.WriteLine($"O código do funcionário é {func.Numero}");
        Console.WriteLine($"O nome do funcionário é {func.Nome}");

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Recebe no mês {i + 1} R$ {func.SalarioMes[i]:F2}");
        }

        Console.WriteLine($"O salário anual é R$ {func.SalarioAno}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
