// Declaração de bibliotecas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static long[] numeros; //Array para os valores da sequência

        static void Main()
        {
            int posicao;

            Console.Write("Insira o valor da posição: ");

            posicao = Convert.ToInt32(Console.ReadLine());

            numeros = new long[posicao];
            numeros[0] = 1;
            numeros[1] = 1;

            //Preenche a sequencia até o valor dado;
            for (int i = 2; i < posicao; i++)
            {
                numeros[i] = numeros[i - 1] + numeros[i - 2];
            }

            //Exibe a sequência
            foreach (int valores in numeros)
            {
                Console.Write("{0} ", valores);
            }

            //Especifica o valor da posição dada
            Console.Write("\nValor da posição {0}: {1}", posicao, numeros[posicao - 1]);
        }
    }
}