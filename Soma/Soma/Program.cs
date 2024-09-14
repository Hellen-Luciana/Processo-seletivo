using System;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int INDICE = 12, SOMA = 0, K = 1;
            while (K < INDICE)
            {
                K = K + 1; 
                SOMA = SOMA + K;
            }

            Console.WriteLine("O valor da variável SOMA é: " + SOMA);
        }
    }
}
