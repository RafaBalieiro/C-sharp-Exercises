using System;

class Average3Numbers
{

    static void Main()
    {

        int valor1,
            valor2,
            valor3;

        Console.Write("Insira o primeiro valor: ");
        valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo valor: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o terceiro valor: ");
        valor3 = Convert.ToInt32(Console.ReadLine());

        float media = (valor1 + valor2 + valor3) / 3;

        Console.WriteLine("Média dos números {0} {1} {2}: {3}", valor1, valor2, valor3, media);
    }
}