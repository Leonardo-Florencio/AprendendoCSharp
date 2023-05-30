using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 10 - Calcula Poupança");

        double investimento = 1000.00;

        //rendimento de 0.5% ao mês = (0.005) ao mês

        //investimento = investimento + investimento * 0.005;

        Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes += 1;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}