using System;

class ConvertDollarsToCent2
{

    static void Main()
    {

        double dollars;

        Console.Write("Insira o valor: ");
        dollars = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor de {0} doláres para centávos: {1}", dollars, convertDollars(dollars));
    }

    static int convertDollars(double dollars)
    {

        return (int)(dollars * 100);
    }
}