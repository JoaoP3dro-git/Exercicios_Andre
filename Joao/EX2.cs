class Program {
    static void Main() {
        int codigo = 0, depen = 0, cont = 0;
	    float rendamensal = 0, valorinss = 0, valorfinalinss = 0,valorimposto = 0, valorfinal = 0, inssanual = 0, iranual = 0, resultado12salario = 0;
	    float valorcalculoIR = 0;

        Console.WriteLine("\n Digite seu código: ");
        string input1 = Console.ReadLine() ?? "";
        codigo = int.Parse(input1);

        while (codigo > 0) {
            Console.WriteLine("\n Quantos dependentes vc tem?: ");
            string input2 = Console.ReadLine() ?? "";
            depen = int.Parse(input2);

            for(cont = 0; cont < 12; cont++){
                Console.WriteLine($"\n Digite o {cont+1}° salário bruto do ano: ");
                string input3 = Console.ReadLine() ?? "";
                rendamensal = int.Parse(input3);


                switch (true) {
                    case var _ when rendamensal <= 1399.12:
                        valorinss = (float)(rendamensal * 0.08);
                        break;
                    case var _ when rendamensal >= 1399.13 && rendamensal <= 2331.88:
                        valorinss = (float)(rendamensal * 0.09);
                        break;
                    case var _ when rendamensal >= 2331.89 && rendamensal < 4663.75:
                        valorinss = (float)(rendamensal * 0.11);
                        break;
                    case var _ when rendamensal >= 4663.75:
                        valorinss = 513.01f;
                        break;
                    default:
                        Console.WriteLine("Invalid income value.");
                        return;
                }

                Console.WriteLine($"INSS mensal: R$ {valorinss:F2}");

                valorfinalinss = rendamensal - valorinss;
                valorcalculoIR = valorfinalinss - (depen * 189.59f);

                 switch (true) {
                    case var _ when valorcalculoIR <= 1903.98:
                        valorfinal = valorfinalinss;
                        Console.WriteLine($"\nIR mensal: R$ 0,0 .");
                        Console.WriteLine($"Salário líquido: R$ {valorfinal:F2}");
                        break;

                    case var _ when valorcalculoIR >= 1903.99 && valorcalculoIR <= 2826.65:
                        valorimposto = (float)((valorcalculoIR * 0.075) - 142.80);
                        valorfinal = valorfinalinss - valorimposto;
                        Console.WriteLine($"\nIR mensal: R$ {valorimposto:F2} .");
                        Console.WriteLine($"Salário líquido: R$ {valorfinal:F2}");
                        break;

                    case var _ when valorcalculoIR >= 2826.66 && valorcalculoIR <= 3751.05:
                        valorimposto = (float)((valorcalculoIR * 0.15) - 354.80);
                        valorfinal = valorfinalinss - valorimposto;
                        Console.WriteLine($"\nIR mensal: R$ {valorimposto:F2} .");
                        Console.WriteLine($"Salário líquido: R$ {valorfinal:F2}");
                        break;

                    case var _ when valorcalculoIR >= 3751.06 && valorcalculoIR <= 4664.68:
                        valorimposto = (float)((valorcalculoIR * 0.225) - 636.13);
                        valorfinal = valorfinalinss - valorimposto;
                        Console.WriteLine($"\nIR mensal: R$ {valorimposto:F2} .");
                        Console.WriteLine($"Salário líquido: R$ {valorfinal:F2}");
                        break;

                    case var _ when valorcalculoIR > 4664.68:
                        valorimposto = (float)((valorcalculoIR * 0.275) - 869.36);
                        valorfinal = valorfinalinss - valorimposto;
                        Console.WriteLine($"\nIR mensal: R$ {valorimposto:F2} .");
                        Console.WriteLine($"Salário líquido: R$ {valorfinal:F2}");
                        break;

                    default:
                        Console.WriteLine("Invalid income value.");
                        break;
                }

                inssanual = valorfinalinss * 12;
                iranual = valorimposto * 12;
                resultado12salario = valorfinal * 12;
            }
        }

        Console.WriteLine($"INSS anual: R$ {inssanual:F2} .");
        Console.WriteLine($"IR anual: R$ {iranual:F2} .");
        Console.WriteLine($"Salário líquido Anual: R$ {resultado12salario:F2} .");
        Console.WriteLine("\n\n\n");

        Console.WriteLine("Digite seu código:");
        codigo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Você digitou o código: {codigo}");
    }
}