/*
 Să se scrie o aplicație consolă ce primește un text și listează caracterele distincte ce apar în text și de câte ori apar.

Caracterele distincte trebuie afișate câte unul pe linie, în ordinea în care apar pentru prima dată în text. Fiecare caracter e urmat de un spațiu și apoi de numărul de apariții.

Notă: Uneori e tentant să arunci cu totul codul vechi și să refaci funcționalitatea de la început. Dar acum scopul e să înțelegi și să fixezi erorile dintr-un cod existent, chiar și atunci când e scris urât. Din două motive:
Pentru că inevitabil o să ajungi în cariera de programator să lucrezi cu cod scris prost și trebuie să te descurci.
Dacă vezi pe pielea ta cum e să lucrezi cu un cod scris urât, începi să te gândești mai mult la cum arată codul scris de tine.
Deci folosește execuția pas cu pas pentru a localiza și fixa erorile din proiectul atașat.

Exemplu:

Pentru datele de intrare:

test
La consolă se va afișa:

t 2
e 1
s 1
 
 
 */


using System;

namespace CharsCountUgly
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            char[] chs = new char[0];

            for (int i = 0; i < s.Length; i++)
            {
                int k = -1;

                for (int j = 0; j < chs.Length; j++)
                {
                    if (chs[j] == s[i])
                    {
                        k = j;
                    }
                }

                if (k == -1)
                {
                    Array.Resize(ref chs, chs.Length + 1);
                    chs[chs.Length - 1] = s[i];
                }
            }

            int[] chsC = new int[chs.Length];

            for (int i = 0; i < chs.Length; i++)
            {
                for (int j = i ; j < s.Length; j++)
                {
                    if (chs[i] == s[j])
                    {
                        chsC[i]++;
                    }
                }
            }

            for (int i = 0; i < chs.Length; i++)
            {
                Console.WriteLine(chs[i] + " " + chsC[i]);
            }

            Console.Read();
        }
    }
}

