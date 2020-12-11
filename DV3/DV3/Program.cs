/*
 Se dă o listă de N tronsoane verticale și orizontale consecutive de dimensiuni fixe sub forma unei succesiuni de direcții (left, right, up, down).
Scrie o funcție care verifică dacă tronsoanele se intersectează.

Exemplu:

Pentru datele de intrare:

6
down
right
down
left
up
left
La consolă se va afișa:

True
 */

using System;

namespace DV3
{
    public class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = false;

            int[] horizontalCoordinates = new int[n + 1];
            horizontalCoordinates[0] = 0;

            int[] verticalCoordinates = new int[n + 1];
            verticalCoordinates[0] = 0;

            for (int k = 1; k < n + 1; k++)
            {
                CreateCoordinates(k, horizontalCoordinates, verticalCoordinates);
                for (int i = 0; i < k - 1; i++)
                {
                    if (horizontalCoordinates[i] == horizontalCoordinates[k] &&
                    verticalCoordinates[i] == verticalCoordinates[k])
                    {
                        result = true;
                    }
                }
            }

            Console.WriteLine(result);
            Console.Read();
        }

        static void CreateCoordinates(int k, int[] horizontalCoordinates, int[] verticalCoordinates)
        {
                switch (Console.ReadLine())
                {
                    case "left":
                        horizontalCoordinates[k] = horizontalCoordinates[k - 1] - 1;
                        verticalCoordinates[k] = verticalCoordinates[k - 1] + 0;
                        break;

                    case "right":
                        horizontalCoordinates[k] = horizontalCoordinates[k - 1] + 1;
                        verticalCoordinates[k] = verticalCoordinates[k - 1] + 0;
                        break;

                    case "up":
                        verticalCoordinates[k] = verticalCoordinates[k - 1] + 1;
                        horizontalCoordinates[k] = horizontalCoordinates[k - 1] + 0;
                        break;

                    case "down":
                        verticalCoordinates[k] = verticalCoordinates[k - 1] - 1;
                        horizontalCoordinates[k] = horizontalCoordinates[k - 1] + 0;
                        break;
                }
            }
        }
}