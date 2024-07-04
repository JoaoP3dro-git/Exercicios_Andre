class Program {
    static void Main() {
        int[,] mat1 = new int[3,3];
        int[,] mat2 = new int[3,3];
        int[,] matSoma = new int[3,3];

        Console.WriteLine("Primeira matriz:");

        for(int j = 0; j < 3; j++){
            for(int k = 0; k < 3; k++){
                Console.WriteLine($"Informe o {j+1}° valor");
                string input1 = Console.ReadLine() ?? "";
                mat1[j, k] = int.Parse(input1);
            }
        }

        Console.WriteLine("Segunda matriz:");

        for(int j = 0; j < 3; j++){
            for(int k = 0; k < 3; k++){
                Console.WriteLine($"Informe o {j}° valor");
                string input1 = Console.ReadLine() ?? "";
                mat2[j, k] = int.Parse(input1);
            }
        }

        for(int j = 0; j < 3; j++){
            for(int k = 0; k < 3; k++){
                matSoma[j, k] = mat1[j,k] + mat2[j,k];
            }
        }

        Console.WriteLine("Matriz final:");

        for(int j = 0; j < 3; j++){
            for(int k = 0; k < 3; k++){
                Console.WriteLine($"{mat1[j,k]}");
            }
            Console.WriteLine("\n");
        }

    }
}