/*Să se scrie o aplicație consolă ce traduce un text dat la limba păsărească.
Un text se traduce la limba păsărească astfel: după fiecare vocală se inserează litera p și vocala respectivă.

Nota 1: Aplicația păstrează literele mari și mici din textul original, dar litera p și vocalele nou introduse sunt întotdeauna litere mici.

Nota 2: Folosește execuția pas cu pas pentru a localiza și fixa erorile din proiectul atașat. Observă stilul de codare folosit în acest proiect comparativ cu proiectul de la stadiul precedent.

Exemplu:
Pentru datele de intrare:
Ana are mere.
La consolă se va afișa:
Apanapa aparepe meperepe.
*/

using System;

namespace ToGibberish
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(TranslateToGibberish(text));
            Console.Read();
        }

        private static string TranslateToGibberish(string text)
        {
            string translatedText = "";
            foreach (char c in text)
            {
                translatedText += c.ToString();
                if (IsVowel(c))
                {
                    translatedText += "p" + c.ToString().ToLower();
                }
            }
            return translatedText;
        }

        private static bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) != -1;
        }
    }
}

