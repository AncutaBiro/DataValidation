using System;
using System.Collections.Generic;

namespace DataValidation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            string direction = "up";
            /*
                        int[,] location = CheckIntersection(n, direction);
            */
     /*       foreach (int i in location)
            {
                foreach (int j in location)
                {*/
                   CheckIntersection(n, direction);




                }


                static string CheckIntersection(int n, string direction)

                {
            int x = 0;
            int y = 0;

            List<List<int>> coordonates = new List<List<int>>();
            
                 
                    for (int i = 0; i <= n; i++)

                    {

                List<int> list = new List<int>();
                coordonates.Add(list);

                switch (direction)
                        {
                            case "down":
                                y--;
                        coordonates[i].Add(y);
                                break;

                            case "up":
                                y++;
                        coordonates[i].Add(y);
                        break;

                            case "left":
                        coordonates[i].Add(x);
                        x--;
                                break;

                            case "right":
                        coordonates[i].Add(x);
                        x++;
                                break;
                        }

                    }

                    return coordonates.ToString();
                }


            }
        }
    
