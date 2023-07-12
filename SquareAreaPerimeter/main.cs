using System;

class SquareAreaPerimeter
{

    static void Main()
    {

        float lado;

        Console.Write("Digite o valor para o lado: ");
        lado = Convert.ToSingle(Console.ReadLine());

        float area = lado * lado;
        float perimetro = lado * 4;

        Console.Write("Área: {0} m^2 | Perimetro: {1} m", area, perimetro);
    }
}