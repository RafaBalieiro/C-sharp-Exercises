using System;

class SimpleInterest
{

    static void Main()
    {

        double capital;
        double taxaJuros;
        int meses;

        Console.Write("Insira o valor do Capital: ");
        capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o valor da Taxa de Juros: ");
        taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a quantidade de meses: ");
        meses = Convert.ToInt32(Console.ReadLine());

        double juros = (capital * taxaJuros * meses) / 100;

        Console.WriteLine("Calculo de Juros Simples (Capital * taxa * meses)");
        Console.WriteLine("Juros = {0} * {1} * {2} = {3:c}", capital, taxaJuros, meses, juros);
    }
}