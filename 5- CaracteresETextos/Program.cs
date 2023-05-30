using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        //o tipo char serve para caracteres de texto apenas (aceita até 16 bits) e ele aceita apenas aspas simples ''. Não aceita valores vazios.
        char letra = 'a';
        Console.WriteLine(letra);

        //além disso, o tipo char pode usar uma ASCII Table para dar um valor novo equivalente ao código usado
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);


        // string é o tipo texto, recebe valores do tipo texto entre aspas "" - Aceita valores vazios.
        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        //Para que a lista fique na vertical, basta colocar um @ antes da primeira aspas, e depois dar enter para elas ficarem em formato de lista. Conforme abaixo:
        string cursos = @"Cursos disponíveis: 
-Go 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);

        Console.Write("Tecle enter duas vezes para sair da tela.");
        Console.ReadLine();
    }
}