using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 11 - Calcula Poupança");


        //rendimento de 0.5% ao mês = (0.005) ao mês

        //investimento = investimento + investimento * 0.005;

        //while (mes <= 12)
        //{
        //    investimento = investimento + investimento * 0.005;
        //    mes += 1;
        //    Console.WriteLine("No mês " + mes + " você tem " + investimento);
        //}

        double investimento = 1000.00;


        for (int mes = 1; mes <= 12; mes += 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}