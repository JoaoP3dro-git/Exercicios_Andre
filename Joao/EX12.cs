class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine() ?? "");

        int res = Soma(num1, num2);
        Console.WriteLine($"O resultado entre {num1} + {num2} = {res}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int Soma(int num1, int num2)
    {
        int valor = num1 + num2;
        return valor;
    }

}

