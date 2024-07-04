public struct FichaCandidato
{
    public int Codigo;
    public float Salario;
    public string Mail;
}

class Program
{
    const int TAM = 3;

    static void Main()
    {
        FichaCandidato[] candidatos = new FichaCandidato[TAM];

        for (int i = 0; i < TAM; i++)
        {
            Console.WriteLine("\nInforme o código do candidato:");
            candidatos[i].Codigo = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("\nInforme o salário:");
            candidatos[i].Salario = float.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("\nInforme o e-mail:");
            candidatos[i].Mail = Console.ReadLine() ?? "";
        }

        Console.WriteLine("************************************************************");
        Console.WriteLine("************************************************************");

        for (int i = 0; i < TAM; i++)
        {
            Console.WriteLine($"\nCandidato {i + 1}");
            Console.WriteLine(candidatos[i].Codigo);
            Console.WriteLine(candidatos[i].Salario.ToString("F2"));
            Console.WriteLine(candidatos[i].Mail);
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
