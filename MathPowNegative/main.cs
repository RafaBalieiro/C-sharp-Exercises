using System;

class MathPowNegative
{

    static void Main()
    {

        double valor,
               expoente;

        Console.Write("Insira o valor para a base: ");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o valor do expoente negativo: ");
        expoente = Convert.ToDouble(Console.ReadLine());

        double resultado = Math.Pow(valor, expoente);

        Console.Write("Valor {0}^{1} = {2}", valor, expoente, resultado);
    }
}