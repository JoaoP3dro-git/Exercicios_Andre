class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número inteiro:");
        int numeroInt = int.Parse(Console.ReadLine() ?? "");

        Imprime(ref numeroInt);

        Console.WriteLine($"Número inteiro: {numeroInt}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    
    static void Imprime(ref int numeroInt)
    {
        Console.WriteLine(numeroInt);
        numeroInt = 0;
    }
}


