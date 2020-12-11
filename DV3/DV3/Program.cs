using System;

namespace DV3
{
    public class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine (CheckIntersection (n));
            Console.Read();

        }
            static bool CheckIntersection (int n) {

            bool result = false;

            int[] horizontalCoordinates = new int[n + 1];    
            horizontalCoordinates[0] = 0;

            int[] verticalCoordinates = new int[n + 1];
            verticalCoordinates[0] = 0;

            for (int k = 1; k < n+1; k++)
            {

                string direction = Console.ReadLine();

                switch (direction)
                {

                    case "left":

                        horizontalCoordinates[k] = horizontalCoordinates[k-1] - 1;
                        verticalCoordinates[k] = verticalCoordinates[k-1] + 0;


                        for (int i = 0; i < k - 1; i++)
                        {
                            if (horizontalCoordinates[i] == horizontalCoordinates[k] &&
                            verticalCoordinates[i] == verticalCoordinates[k])

                            {
                                result = true;
                            }

                        }

                        break;

                    case "right":
                        horizontalCoordinates[k] = horizontalCoordinates[k-1] + 1;
                        verticalCoordinates[k] = verticalCoordinates[k-1] +  0;

                        for (int i = 0; i < k - 1; i++)
                        {
                            if (horizontalCoordinates[i] == horizontalCoordinates[k] &&
                            verticalCoordinates[i] == verticalCoordinates[k])

                            {
                                result = true;
                            }

                        }
                        break;

                    case "up":
                        verticalCoordinates[k] = verticalCoordinates [k-1] +  1;
                        horizontalCoordinates[k] = horizontalCoordinates[k-1] +  0;

                        for (int i = 0; i < k - 1; i++)
                        {
                            if (horizontalCoordinates[i] == horizontalCoordinates[k] &&
                            verticalCoordinates[i] == verticalCoordinates[k])

                            {
                                result = true;
                            }
                        }

                        break;

                    case "down":
                        verticalCoordinates[k] = verticalCoordinates[k-1] - 1;
                        horizontalCoordinates[k] = horizontalCoordinates[k-1] + 0;

                        for (int i = 0; i < k - 1; i++)
                        {
                            if (horizontalCoordinates[i] == horizontalCoordinates[k] &&
                            verticalCoordinates[i] == verticalCoordinates[k])

                            {
                                result = true;
                            }
                        }

                        break;
                }

                Console.WriteLine(horizontalCoordinates[k]);
                Console.WriteLine(verticalCoordinates[k]);

      /*          horizontalCoordinates[k] = x;*/

               /* for (int i = k; i < horizontalCoordinates.Length-1; i++)
                {
                        if (horizontalCoordinates[i] == horizontalCoordinates[i - 1]) 
                    {
                        result = true;
                    }
                }

                verticalCoordinates[k] = y;

                for (int j = k; j < verticalCoordinates.Length-1; j++)
                        {

                    if (verticalCoordinates[j] == verticalCoordinates[j - 1])
                    {
                        result = true;
                    }

                        }*/
            
        }

            return result;

        }

    }

}




   


