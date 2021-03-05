using System;


namespace Lesson_4._1
{
    class EnterNumber
    {
        public static void Enter()
        {
            Console.WriteLine("пожалуйста введите число: ");
            string value = Console.ReadLine();
            int number;

            bool isNum = int.TryParse(value, out number);

            if (isNum)
            {
                Solution.Sol(number);

            }
            else
            {
                Console.WriteLine("Вы ошиблись!");
                Enter();
            }
        }
    }
}
