/*
 Să se scrie o aplicație consolă ce primește un text și listează caracterele distincte ce apar în text și de câte ori apar.

Caracterele distincte trebuie afișate câte unul pe linie, în ordinea în care apar pentru prima dată în text. Fiecare caracter e urmat de un spațiu și apoi de numărul de apariții.

Notă: Folosește execuția pas cu pas pentru a localiza și fixa erorile din proiectul atașat. Observă stilul de codare folosit în acest proiect comparativ cu proiectul de la stadiul precedent.

Exemplu:

Pentru datele de intrare:

test
La consolă se va afișa:

t 2
e 1
s 1
 
 */


using System;

namespace CharsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string distinctChars = GetDistinctChars(text);
            foreach (char c in distinctChars)
            {
                Console.WriteLine(c + " " + CountCharOccurrences(text, c));
            }
            Console.ReadLine();
        }

        private static int CountCharOccurrences(string text, char charToCount)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == charToCount)
                {
                    count++;
                }
            }
            return count;
        }

        private static string GetDistinctChars(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (result.IndexOf(c) == -1)
                {
                    result += c;
                }
            }
            return result;
        }
    }
}

