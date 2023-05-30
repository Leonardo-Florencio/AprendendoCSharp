using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        // o resultado do console abaixo vai ser 30 e não 25, pois o WriteLine foi chamado antes da modificação. É uma interpretação linear.
        Console.WriteLine(idadeAna);

        idade = 25;



        Console.WriteLine("Tecle enter duas vezes para fechar...");
        Console.ReadLine();
    }

}
