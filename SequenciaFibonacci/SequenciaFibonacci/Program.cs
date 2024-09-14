using System;

namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long f = 0;
            long anterior = 0;
            long atual = 1;
            long valor = 10;

            while (true) {
                f = anterior + atual;
                anterior = atual;
                atual = f;

                if (f >= valor)
                {
                    break;
                }
            }


            Console.WriteLine("pertence a sequencia Fibonacci ?");

            if (f == valor)
            {
                Console.WriteLine("pertence");

            }
            else
            {
                Console.WriteLine("não pertence");
            }

            Console.ReadLine();




        }
    }
}
