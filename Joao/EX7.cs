class Program
{
    static void Main()
    {
       int multiplicando = 0, multiplicador = 0, produto = 0;

        Console.WriteLine("Informe o multiplicando: ");
        string input = Console.ReadLine() ?? "";
        multiplicando = int.Parse(input);

        Console.WriteLine("Informe o multiplicandor: ");
        string input2 = Console.ReadLine() ?? "";
        multiplicador = int.Parse(input2);

        produto = soma(multiplicando, multiplicador);

        Console.WriteLine($"O produto é: {produto}");
    }

    static int soma(int x, int y)
    {
        if(y == 1){
            return x;
        } else {
            return x + soma(x, y-1);
        }
    }
}

