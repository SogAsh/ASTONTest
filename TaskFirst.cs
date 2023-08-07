using System;

namespace ASTONTest
{
    public class TaskFirst
    {
        public static void FindSeven()
        {
            int num;

            Console.WriteLine("Введите любое число и нажмите Enter");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 7)
            {
                Console.WriteLine("Привет");
                return;
            }
        }
    }
}
