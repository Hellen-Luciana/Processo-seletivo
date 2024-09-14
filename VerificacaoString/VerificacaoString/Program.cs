using System;
using System.Text.RegularExpressions;

namespace VerificacaoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caracteres = "Miguel Angelo";

            MatchCollection matches = Regex.Matches(caracteres.ToUpper(), "A");

            if (matches.Count > 0)
            {
                Console.WriteLine($"Existe a letra ‘a’ ou 'A'.\nA quantidade de vezes em que ela aparece é {matches.Count}");
            }
            else
            {
                Console.WriteLine($"Não existe a letra ‘a’ ou 'A'.");
            }
            Console.ReadLine();
        }
    }
}
