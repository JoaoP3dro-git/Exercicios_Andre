class Program
{
    static void Main()
    {

        int[,] mat1 = new int[5, 5];
        int[,] mat2 = new int[5, 5];
        int[,] matresul = new int[5, 5];
        int l, c;

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                Console.WriteLine($"Informe o valor da posição [{l},{c}] da primeira matriz:");
                string input1 = Console.ReadLine() ?? "";
                mat1[l, c] = int.Parse(input1);
            }
        }

        Console.WriteLine("\nSegunda Matriz\n");

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                Console.WriteLine($"Informe o valor da posição [{l},{c}] da segunda matriz:");
                string input2 = Console.ReadLine() ?? "";
                mat2[l, c] = int.Parse(input2);
            }
        }

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                matresul[l, c] = mat1[l, c] + mat2[l, c];
            }
        }

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                Console.Write($"| {matresul[l, c]} |");
            }
            Console.WriteLine();
        }

        int diagonal = 0;
        for (int i = 0; i < 5; i++)
        {
            diagonal += matresul[i, i];
        }

        Console.WriteLine($"\n\nO valor da Diagonal Principal é {diagonal}\n\n");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
