using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            string bnum1 = to_binary(num1);
            string bnum2 = to_binary(num2);
            string bnum3 = to_binary(num1 + num2);
            while (bnum2.Length != bnum1.Length)
            {
                if (bnum2.Length > bnum1.Length) { bnum1 = '0' + bnum1; }
                else { bnum2 = '0' + bnum2; }
            }
            bnum1 = '0' + bnum1;
            bnum2 = '0' + bnum2;
            Console.WriteLine($" {bnum1}\n {bnum2}\n ***********************\n {bnum3}");

        }
        static string to_binary(int n)
        {
            string ans = "";
            string ans_add = "";
            while (n != 1)
            {
                ans = Convert.ToString(n & 1) + ans;
                n >>= 1;
            }
            ans = Convert.ToString(n & 1) + ans;
            return (ans);
        }
    }
}


/* task_1.1
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

/* Task_1.2
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

/* Task_1.3
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
/* task_1.4
 * {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($" {factorial(i) / (factorial(j) * factorial(i - j))} ");
                }
                Console.WriteLine("\n");
            }

        }
        static int factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }


task_2.1
{
            int num = Convert.ToInt32(Console.ReadLine());
            string res = to_binary(num);
            Console.WriteLine(res);
        }
        static string to_binary(int n)
        {
            string ans = "";
            string ans_add = "";
            while (n != 1)
            {
                ans = Convert.ToString(n & 1) + ans;
                n >>= 1;
            }
            ans = Convert.ToString(n & 1) + ans;
            return (ans);
        }
    }


task 2.2
{
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            string bnum1 = to_binary(num1);
            string bnum2 = to_binary(num2);
            string bnum3 = to_binary(num1 + num2);
            while (bnum2.Length != bnum1.Length)
            {
                if (bnum2.Length > bnum1.Length) { bnum1 = '0' + bnum1; }
                else { bnum2 = '0' + bnum2; }
            }
            bnum1 = '0' + bnum1;
            bnum2 = '0' + bnum2;
            Console.WriteLine($" {bnum1}\n {bnum2}\n ***********************\n {bnum3}");

        }
        static string to_binary(int n)
        {
            string ans = "";
            string ans_add = "";
            while (n != 1)
            {
                ans = Convert.ToString(n & 1) + ans;
                n >>= 1;
            }
            ans = Convert.ToString(n & 1) + ans;
            return (ans);
        }
*/
/* task 3.1
 * static void Main(string[] args)
{
    int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int[] my_list = new int[input[0]];
    for (int i = 0; i < input[0]; i++)
    {
        my_list[i] = Convert.ToInt32(Console.ReadLine());
    }
    int sum = 0;
    for (int i = 0; i < input[0]; i++)
    {
        sum += (int)Math.Pow(my_list[i], input[1]);
    }
    Console.WriteLine(Math.Pow(sum, (1.0 / input[1])));
}
 */