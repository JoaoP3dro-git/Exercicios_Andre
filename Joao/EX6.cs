class Program
{
    static void Main()
    {
        float alt = 0, @base = 0, resp = 0;

        Console.WriteLine("INFORME A MEDIDA LATERAL DO TERRENO:");
        string input1 = Console.ReadLine() ?? "";
        alt = float.Parse(input1);

        Console.WriteLine("INFORME A BASE DO TERRENO:");
        string input2 = Console.ReadLine() ?? "";
        @base = float.Parse(input2);

        resp = calculo(alt, @base);

        Console.WriteLine($"\n\nÁrea = {resp:F2}m², referente às medidas: {alt:F2}m e {@base:F2}m.\n\n");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static float calculo(float p_alt, float p_base)
    {
        float resp = 0;
        resp = p_alt * p_base;
        return resp;
    }
}
