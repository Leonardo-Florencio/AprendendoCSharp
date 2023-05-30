using System;

class Programa
{
    static void Main(string[] args)
    {   // double é um tipo de variável que aceita int e float
        double salario = 3000.15;
        Console.WriteLine(salario);

        //usar o (tipo) é uma maneira de mudar o tipo do valor de uma variável recebida por outra. Casting é o caso abaixo (double pra int)
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // long é um tipo que aceita numeros maiores do que 64 bits
        long x = 20000000000000000;
        Console.WriteLine(x);

        // long é um tipo que aceita apenas números menores do que 16 bits
        short y = 15000;
        Console.WriteLine(y);

        // quando usamos o tipo float, o compilador vai alertar um erro, querendo que deixemos como double. Nesse caso, usamos "f" no final para indicar que o float está correto
        float z = 5.647f;
        Console.WriteLine(z);


        Console.WriteLine("Tecle enter duas vezes para fechar...");
        Console.ReadLine();
    }
}
