using System;

class QuotientAndRemainder
{

    static void Main()
    {

        float valor;
        float divisor;

        Console.Write("Insira um valor: ");
        valor = Convert.ToSingle(Console.ReadLine());

        Console.Write("Insira o divisor: ");
        divisor = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Divisão {0} / {1} = {2} | Resto = {3}", valor, divisor, valor / divisor, valor % divisor);

    }

}