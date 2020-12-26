using System;
using System.Collections.Generic;

namespace DV_SudokuGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] board = new int[9, 9];*/

            int[,] board = new int[9, 9]
                            {
                            {9,1,8,5,7,2,6,4,3},
                            {7,5,3,6,9,4,1,8,2},
                            {2,6,4,1,8,3,7,9,5},
                            {1,9,6,4,2,8,5,3,7},
                            {3,8,2,7,5,6,9,1,4},
                            {5,4,7,9,3,1,8,2,6},
                            {4,7,9,2,1,5,3,6,8},
                            {8,2,5,3,6,9,4,7,1},
                            {6,3,1,8,4,7,2,5,9}};

            /*if (!ReadAndValidateInputData(board))
            {
                Console.WriteLine("Please enter a 9x9 sudoku board: numbers between 1-9 separated by spaces");
            }
            else
            {
                Console.WriteLine(CheckBoard(board));
            }*/

            Console.WriteLine(CheckBoard(board));
            Console.Read();
        }

        static bool ReadAndValidateInputData(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                if (i == 2 || i == 5)
                {
                    Console.WriteLine(" ");
                }

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

        /* static int[,] validBoard PrintBoard(int[,] board)
         {
             int[,] validBoard = new int[9, 9];

             for (int i = 0; i < 9; i++)
             {
                 for (int j = 0; j < 9; j++)
                 {
                     Console.Write(board[i, j] + " ");
                 }
                 Console.WriteLine();
             }

             return validBoard;
         }
 */

        static bool CheckRow(int[,] board, int row)
        {
            int[] rowArray = new int[9];

            for (int i = 0; i < 9; i++)
            {
                rowArray[i] = board[row, i];
            }

            for (int i = 0; i < 9; i++) 
            {
                if (Array.IndexOf(rowArray, board[row, i]) != -1)
                    return false;  
            } 

            return true;
        }

        static bool CheckColumn(int[,] board, int col)
        {
            int[] columnArray = new int[9];

            for (int i = 0; i < 9; i++)
            {
                columnArray[i] = board[i, col];
            }

            for (int i = 0; i < 9; i++)
            {
                if (Array.IndexOf(columnArray, columnArray[i]) != -1)
                    return false;
            }
            return true;
        }

        static bool CheckBlock(int[,] board) 
        {
            HashSet<int> set = new HashSet<int>();

            for (int row = 0; row < 9; row += 3) 
            {
                for (int col = 0; col < 9; col += 3)
                {
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++) 
                        {
                            if (set.Add(board[i, j]) == false)
                                return false;
                        }
                    }
                }          
            }
            return true;
        }

        static bool CheckBoard(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!CheckRow(board, i) || !CheckColumn(board, i) || !CheckBlock(board))
                    return false;
            }

            return true;
        }
    }
}



    



    

