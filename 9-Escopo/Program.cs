using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 0;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        } else
        {
            textoAdicional = "João não está acompanhado";
        }


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.Write(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}