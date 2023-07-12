using System;

class countWords
{

    static void Main()
    {

        string frase;

        Console.Write("Insira uma frase: ");
        frase = Console.ReadLine();

        // Conta palavras dentro da string

        //Separa as palavras da string
        string[] palavras = frase.Split(' ');

        /*
        foreach (string words in palavras)
        {
            Console.WriteLine(words);
        }
        */

        //Conta palavras

        int qtdPalavras = palavras.Length;

        Console.WriteLine("Quantidade de palavras: {0}", qtdPalavras);
    }
}