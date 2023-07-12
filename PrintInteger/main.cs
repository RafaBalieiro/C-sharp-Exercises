using System;

class PrintInteger
{

    static void Main()
    {

        int numero;

        Console.Write("Insira um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Inteiro digitado: {0}", numero);
    }
}