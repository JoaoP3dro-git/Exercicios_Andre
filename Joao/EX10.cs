class Program
{
    static void Main()
    {
        string resp = "";
        int num = 0;

        Console.WriteLine("Informe um número inteiro: ");
        string input = Console.ReadLine() ?? "";
        num = int.Parse(input);

        resp = par_impar(num);
        Console.WriteLine($"O {num} é {resp}");
    }

    static string par_impar(int num){
        string resp = "";
        if(num % 2 == 0){
            resp = "Par";
        } else {
            resp = "Impar";
        }

        return resp;
    }

}

