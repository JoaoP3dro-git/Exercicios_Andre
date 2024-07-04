class Program
{
    static void Main()
    {
        int peq = 0, med = 0, grd = 0;
        
        Console.WriteLine("Informe a quantidade de camisetas pequenas(R$ 10,00):");
        string input = Console.ReadLine() ?? "";
        peq = int.Parse(input);

        Console.WriteLine("Informe a quantidade de camisetas medias(R$ 17,00):");
        string input2 = Console.ReadLine() ?? "";
        med = int.Parse(input2);

        Console.WriteLine("Informe a quantidade de camisetas grandes(R$ 21,00):");
        string input3 = Console.ReadLine() ?? "";
        grd = int.Parse(input3);

        calc(peq, med, grd);
    }

    static void calc(int peq, int med, int grd){
        int peq_valor = peq * 10;
        int med_valor = med * 17;
        int grd_valor = grd * 21;

        Console.WriteLine($"O valor total é R${peq_valor + med_valor + grd_valor}");
    }

}

