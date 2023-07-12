using System;

class MathPow
{

    static void Main()
    {

        double valor,
            potencia;

        Console.Write("Insira o valor: ");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o expoente: ");
        potencia = Convert.ToDouble(Console.ReadLine());

        double resultado = Math.Pow(valor, potencia);
        Console.Write("Potencia de {0}^{1} = {2}", valor, potencia, resultado);

    }
}