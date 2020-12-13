using System;

namespace DV4Students_Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string [] studensName= ReadStudentsName (n);

            int[] grades = ReadGrades(n);

            int[] coinsPerStudent = (DistributionOfCoins(grades, InitializeCoinsArray(grades)));

            for (int j = 0; j < studensName.Length; j++) {
          
                Console.WriteLine(studensName[j] + " " + coinsPerStudent[j]);
            }

            Console.Read();
        }


        static string[] ReadStudentsName (int n) 
        {
            string [] studentsName = new string[n];

            for (int i = 0; i < n; i++) 
            {
                studentsName [i] = Console.ReadLine();
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

        static int[] InitializeCoinsArray(int[] grades)
        {

            int[] coinsPerStudent = new int[grades.Length];

            for (int k = 0; k < coinsPerStudent.Length; k++)
            {
                coinsPerStudent[k] = 1;
            }

            return coinsPerStudent;
        }


        static int[] DistributionOfCoins(int[] grades, int [] coinsPerStudent)

        {
            
            for (int k = 0; k < coinsPerStudent.Length; k++)
            {
               
                for (int i = 1; i < grades.Length - 1; i++)
                {

                    if (grades[0] > grades[1]) 
                    {
                        coinsPerStudent[0] = coinsPerStudent[1] + 1; 
                    }
                       
                    if (grades[i] > grades[i + 1] || grades[i] > grades[i-1])
                    {
                        coinsPerStudent[i] = coinsPerStudent[i+1] + 1 ;
                    }

                    if (grades[grades.Length-1] > grades[grades.Length - 2])
                    {
                        coinsPerStudent[grades.Length-1] = coinsPerStudent[grades.Length -2] + 1;
                    }
                }
            }

            return coinsPerStudent;
        }
    }
}
