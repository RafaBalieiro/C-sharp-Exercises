using System;

class RectangleArea
{

    static void Main()
    {

        float largura;
        float comprimento;

        Console.Write("Insira o valor para a largura: ");
        largura = Convert.ToSingle(Console.ReadLine());

        Console.Write("Insira o valor para o comprimento: ");
        comprimento = Convert.ToSingle(Console.ReadLine());

        float area = largura * comprimento;

        Console.WriteLine("Valor da área do retângulo: {0} * {1} = {2} m^2", largura, comprimento, area);
    }
}