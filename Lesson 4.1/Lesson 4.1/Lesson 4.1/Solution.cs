using System;


namespace Lesson_4._1
{
    public class Solution
    {
        public static void Sol(int num)
        {
            int num1 = 1, num2 = 0, num3 = 0;

            for (int i = 1; i <= num; i++)
            {
                num1 *= i;
                num2 += i;
                if (i % 2 == 0)
                {
                    num3 = i;
                }
            }

            Console.WriteLine($"Факториал равен {num1} Сумма от 1 до N равна {num2}");

            Console.WriteLine($"Максимальное четное число меньше N равно {num3}");

            Console.ReadLine();
        }
    }

}
