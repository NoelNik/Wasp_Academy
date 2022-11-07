using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOL");
        }
    }
}


/* First_task
 *for (int first = 3; first <= 9; first++)
            {
                for (int second = first - 1; second >= 2; second--)
                {
                    for (int third = second - 1; third >= 1; third--)
                    {
                        for (int fourth = third - 1; fourth >= 0; fourth--)
                        {
                            Console.WriteLine($"{first}{second}{third}{fourth}");
                        }    
                    }
                }
            }
 */

/* Second_task
 * Console.WriteLine("Enter the number >>>   ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j) { Console.Write($"{size, -4}"); }
                    if (j > i) { Console.Write($"{size - j + i, -4}"); }
                    if (j < i) { Console.Write($"{size - i + j, -4}"); }
                }
                Console.Write("\n\n");
            }
*/

/* Third_task
 * Console.WriteLine("Enter the cords >>> ");
            int[,] cords = new int[3, 2];
            for (int i = 0; i < 3; i++)
            {
                int[] first = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                cords[i, 0] = first[0];
                cords[i, 1] = first[1];
            }
            int x_max = 0;
            int y_max = 0;
            for (int i = 0; i < 3; i++)
            {
                if (cords[i, 0] > x_max) { x_max = cords[i, 0]; }
                if (cords[i, 1] > y_max) { y_max = cords[i, 1]; }
            }
            for (int i = 0; i <= y_max; i++)
            {
                for (int j = 0; j <= x_max; j++)
                {
                    int first_check = ((cords[0, 0] - j) * (cords[1, 1] - cords[0, 1])) - ((cords[1, 0] - cords[0, 0]) * (cords[0, 1] - i));
                    int second_check = ((cords[1, 0] - j) * (cords[2, 1] - cords[1, 1])) - ((cords[2, 0] - cords[1, 0]) * (cords[1, 1] - i));
                    int third_check = ((cords[2, 0] - j) * (cords[0, 1] - cords[2, 1])) - ((cords[0, 0] - cords[2, 0]) * (cords[2, 1] - i));
                    
                    if ((first_check >= 0) && (second_check >= 0) && (third_check >= 0) ||
                        (first_check <= 0) && (second_check <= 0) && (third_check <= 0))
                    {
                        Console.Write("* ");
                    }
                    else { Console.Write("_ "); }
                }
                Console.WriteLine("\n");
            }
*/