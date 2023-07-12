using System;

class AreaCirclePerimeter
{

    static void Main()
    {

        float raio;
        const float PI = 3.14f;

        Console.Write("Insira o raio do Círculo: ");
        raio = Convert.ToSingle(Console.ReadLine());

        float area = PI * raio * raio;
        float perimetro = 2.0f * PI * raio;

        Console.Write("Valor da Área: {0} m2 | Perimetro: {1} m", area, perimetro);
    }
}