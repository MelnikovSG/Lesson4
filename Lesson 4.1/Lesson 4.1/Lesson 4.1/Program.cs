using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Solution.EnterNumber();

            

            bool isNum = int.TryParse(Solution.EnterNumber(value), out number);

            if (isNum)
            {
                Solution.Sol();
                
            } else
            {
                Solution.EnterNumber();
                return;
            }
            
            
        }
    
    public class Solution
        {
            public static void EnterNumber()
            {

                Console.WriteLine("пожалуйста введите число: ");
                string value = Console.ReadLine();
                int number;

            }

            public static void Sol()
            {

                Program prog = new Program();
                
                int c1 = 1; int c2 = 0;
                int c3 = 0;
                for (int i = 1; i <= prog.; i++)
                {
                    c1 = c1 * i;
                    c2 = c2 + i;
                    if (i % 2 == 0)
                    {
                        c3 = i;
                    }
                }

                Console.WriteLine("Факториал равет " + Solution().c1); Console.WriteLine("Сума от 1 до N равна " + c2);

                Console.WriteLine("максимальное четное число меньше N равно" + c3);

                Console.ReadLine();
            }
        }
        
    }
}
