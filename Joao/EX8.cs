class Program
{
    static void Main()
    {
        string nome = "";
        int mat = 0;
        float media = 0, nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;

        Console.WriteLine("Informe sua matricula: ");
        string input = Console.ReadLine() ?? "";
        mat = int.Parse(input);

        while (mat != 0) {
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine() ?? "";

            Console.WriteLine("Informe a nota 1: ");
            string input2 = Console.ReadLine() ?? "";
            nota1 = int.Parse(input2);

            Console.WriteLine("Informe a nota 2: ");
            string input3 = Console.ReadLine() ?? "";
            nota2 = int.Parse(input3);

            Console.WriteLine("Informe a nota 3: ");
            string input4 = Console.ReadLine() ?? "";
            nota3 = int.Parse(input4);

            Console.WriteLine("Informe a nota 4: ");
            string input5 = Console.ReadLine() ?? "";
            nota4 = int.Parse(input5);

            media = calc(nota1, nota2, nota3, nota4);
            show(nome, mat, media);
        } 

    }

    static float calc(float nota1, float nota2, float nota3, float nota4){
        float result = (nota1 + nota2 + nota3 + nota4) / 4;
        return result;
    }

    static void show(string nome, int mat, float media){
        Console.WriteLine($"O aluno {nome} da matrícula {mat} possui {media} de média!");
    }
}

