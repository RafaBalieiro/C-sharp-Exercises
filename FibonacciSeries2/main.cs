using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    class Program
    {

        static long[] numeros; //Array para armazenar os valores

        static long Fib(int n)
        {

            if (0 == numeros[n])
            {
                numeros[n] = Fib(n - 1) + Fib(n - 2);
            }
            return numeros[n];
        }

        static void Main()
        {

            int posicao; //Valor da posicao dentro da sequencia;

            Console.Write("Insira o valor da posicao do valor: ");
            posicao = Convert.ToInt32(Console.ReadLine());

            numeros = new long[posicao + 2];

            numeros[1] = 1;
            numeros[2] = 1;

            long resultado = Fib(posicao);

            Console.Write("Valor da posição {0}: {1}", posicao, resultado);
        }
    }

}
