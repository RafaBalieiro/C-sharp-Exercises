using System;

class ConvertDollarsToCent
{

    static void Main()
    {

        double dollars;
        int cents;

        Console.Write("Insira a quantidade de doláres: ");
        dollars = Convert.ToDouble(Console.ReadLine());

        cents = (int)(dollars * 100);

        Console.WriteLine("Valor de {0} dólares em centavos: {1}", dollars, cents);
    }
}