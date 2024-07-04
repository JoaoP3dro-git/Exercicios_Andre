class Program {
    static void Main() {
        int cod1, cod2;
        float lanche = 0, bebida = 0, total;


        Console.WriteLine("\n Digite o código do lanche: ");
        string input1 = Console.ReadLine() ?? "";
        cod1 = int.Parse(input1);
        Console.WriteLine("\n Digite o código da bebida: ");
        string input2 = Console.ReadLine() ?? "";
        cod2 = int.Parse(input2);

        switch (cod1) {
            case 100:
                lanche = 1.20f;
                Console.WriteLine("\n R$ 1,20\n ");
                break;
            case 101:
                lanche = 1.30f;
                Console.WriteLine("\n R$ 1,30\n ");
                break;
            case 102:
                lanche = 1.50f;
                Console.WriteLine("\n R$ 1,50\n ");
                break;
            case 103:
                lanche = 1.70f;
                Console.WriteLine("\n R$ 1,70\n ");
                break;
            default:    
                Console.WriteLine("\n Código incorreto\n ");
                break;
        }

        switch (cod2) {
            case 200:
                bebida = 1.20f;
                Console.WriteLine("\n R$ 1,20\n ");
                break;
            case 201:
                bebida = 1.50f;
                Console.WriteLine("\n R$ 1,50\n ");
                break;
            case 202:
                bebida = 0.70f;
                Console.WriteLine("\n R$ 0,70\n ");
                break;
            default:
                Console.WriteLine("\n Código incorreto\n ");
                break;
        }
        

        total = lanche + bebida;

        Console.WriteLine($"\n Total a pagar: R$ {total}");
    }
}