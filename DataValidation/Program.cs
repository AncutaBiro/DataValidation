
/*program pentru a verifica daca un text este panagram, adica contine toate literele din alphabetul englezesc*/

using System;

namespace DataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (CheckLetters("ana"));
        }

/*var 1*/
        static bool CheckLetters (string s) 
        { 
                string chs = "abcdefghijklmnoqprstuvwxyz";
                string ss = s.ToLower();
                bool b = true;

                for (int i = 0; i < chs.Length; i++)
                {
                    bool b2 = false;
                    int count = 0;
                    for (int j = 0; j < s.Length; j++)
                        if (ss[j] == chs[i]) count++;
                    if (count > 0) b2 = true;



                    if (b2 == false)
                        b = false;
                }

                if (b == false)
                    return false;
                else
                {
                    return true;
                }

            }
/*var 2*/
        static bool IsPanagram(string text)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (text.ToLower().IndexOf(c) == -1)
                {
                    return false;
                }
            }
            return true;
        }




    }
    }

