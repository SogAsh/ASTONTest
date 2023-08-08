using System;

namespace ASTONTest
{
    public class TaskSecond
    {
        public static void FindName()
        {
            string name;

            Console.WriteLine("Введите любое имя и нажмите Enter");
            name = Console.ReadLine().ToString();

            if (name == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
                Console.WriteLine("Нет такого имени");
        }
    }
}
