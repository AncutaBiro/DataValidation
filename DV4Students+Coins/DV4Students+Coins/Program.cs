/*Se dă o listă de N elevi și o listă ce conține nota corespunzătoare fiecărui elev.

Toti elevii primesc monede. Un elev care are nota mai mare decat vecinii lui din listă primește mai multe monede decât ei. Să se determine numărul minim de monede care trebuie dat fiecărui elev.

Exemplu:

Pentru datele de intrare:

8
Ionel
Mihai
Elena
Maria
Vasile
George
Irina
Diana
9
10
8
7
6
9
9
10
La consolă se va afișa:

Ionel 1
Mihai 4
Elena 3
Maria 2
Vasile 1
George 2
Irina 1
Diana 2*/

using System;

namespace DV4StudentsCoins
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] studensName = ReadStudentsName(n);

            int[] grades = ReadGrades(n);

            int[] coinsPerStudent = DistributionOfCoins(grades);





            for (int k = 0; k < studensName.Length; k++)
            {
                Console.WriteLine(studensName[k] + " " + coinsPerStudent[k]);
            }

            Console.Read();
        }

        static string[] ReadStudentsName(int n)
        {
            string[] studentsName = new string[n];

            for (int i = 0; i < n; i++)
            {
                studentsName[i] = Console.ReadLine();
            }

            return studentsName;
        }

        static int[] ReadGrades(int n)
        {
            int[] grades = new int[n];

            for (int i = 0; i < n; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            return grades;
        }

        static int[] DistributionOfCoins(int[] grades)
        {
            int[] coinsPerStudent = new int[grades.Length];

            coinsPerStudent[0] = 1;

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > grades[i - 1])
                {
                    coinsPerStudent[i] = coinsPerStudent[i - 1] + 1;
                }
                else
                {
                    coinsPerStudent[i] = 1;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (grades[i] < grades[j])
                        {
                            coinsPerStudent[i]++;
                        }
                    }
                }
            }

            return coinsPerStudent;
        }
    }
}
