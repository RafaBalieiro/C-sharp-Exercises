using System;

class MultiplyTwoFloating
{

    static void Main()
    {

        float valor1;
        float valor2;

        Console.Write("Insira o primeiro valor float: ");
        valor1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Insira o segundo valor float: ");
        valor2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Multplicação {0} * {1} = {2}", valor1, valor2, valor1 * valor2);
    }
}