using System;

namespace DV_SudokuGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[9, 9];

            if (!ReadAndValidateInputData(board))
            {
                Console.WriteLine("Please enter a 9x9 sudoku board: numbers between 1-9 separated by spaces");
            }

            else
            { 
                Console.WriteLine();

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static bool ReadAndValidateInputData(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                if (line.Length != 9)
                {
                    return false;
                }

                for (int j = 0; j < 9; j++)
                {

                    if (!int.TryParse(line[j], out board[i, j]))
                        return false;

                    if (Convert.ToInt32(line[j]) < 1 || Convert.ToInt32(line[j]) > 9)
                        return false;

                }
            }
            return true;
        }
    }
}




    



    

