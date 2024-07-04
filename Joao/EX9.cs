class Program
{
    static void Main()
    {
        int num = 0, resp = 0;

        Console.WriteLine("Informe um número inteiro: ");
        string input = Console.ReadLine() ?? "";
        num = int.Parse(input);

        resp = sum(num);

        Console.WriteLine($"A somatória dos números é: {resp}");

    }

    static int sum(int num){
        int acumulo = 0;
        if(num > 0){
            acumulo = sum(num-1)+num;
        }
        return acumulo;
    }

}

