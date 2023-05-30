using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Desafio - Múltiplos de 3");

        for (int multiplo = 3; multiplo < 100; multiplo += 3)
        {
            Console.WriteLine(multiplo);
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}