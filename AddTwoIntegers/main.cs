using System;

class AddTwoIntegers
{

    static void Main()
    {

        int valor1;
        int valor2;

        Console.Write("Digite o primeiro inteiro: ");
        valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo inteiro: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Soma {0} + {1} = {2}", valor1, valor2, valor1 + valor2);
    }
}