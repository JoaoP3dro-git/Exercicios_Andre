class Program
{
    static void Main()
    {
        float Sal_10 = 0, Sal_15 = 0, Sal_20 = 0;
        Console.WriteLine("Informe o valor do Sal_15:");
        string input1 = Console.ReadLine() ?? "";
        Sal_15 = float.Parse(input1);

        Sal_10 = Calcula(ref Sal_15, ref Sal_20);
        Mostra(Sal_10, Sal_15, Sal_20);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static float Calcula(ref float p1, ref float p2)
    {
        float Aux = 0;
        Aux = p1 + (p1 * (10f / 100));
        p2 = p1 + (p1 * (20f / 100));
        p1 = p1 + (p1 * (15f / 100));
        return Aux;
    }

    static void Mostra(float p_Sal_10, float p_Sal_15, float p_Sal_20)
    {
        Console.WriteLine($"O salario 1 é {p_Sal_10:F2}");
        Console.WriteLine($"O salario 2 é {p_Sal_15:F2}");
        Console.WriteLine($"O salario 3 é {p_Sal_20:F2}");
    }
}
