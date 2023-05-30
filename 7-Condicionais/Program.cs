using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Ele está acompanahdo, portanto, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}