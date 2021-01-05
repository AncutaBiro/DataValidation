using System;

namespace Students_CoinsTests
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] studensName = ReadStudentsName(n);

            int[] grades = ReadGrades(n);

            int[] coinsPerStudent = new int[grades.Length];

            coinsPerStudent[0] = 1;

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > grades[i - 1])
                {
                    coinsPerStudent[i] = coinsPerStudent[i - 1] + 1;
                }

               /*case grades 9/10/8/7 = coins 3/4/2/1 when it should be 1/3/2/1 */
                else
                {
                    coinsPerStudent[i] = 1;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (grades[i] < grades[j])
                        {
                            coinsPerStudent[j]++;
                        }
                    }
                }



                for (int k = 0; k < studensName.Length; k++)
                {
                    Console.WriteLine(studensName[k] + " " + coinsPerStudent[k]);
                }
            }

                Console.WriteLine();

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

            /*static int[] DistributionOfCoins(int[] grades, int[] coinsPerStudent, int i)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (grades[i] < grades[j])
                    {
                        coinsPerStudent[i]++;
                    }
                }

                return coinsPerStudent;*/
            
        }
    }

