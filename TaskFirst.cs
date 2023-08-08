using System;

namespace ASTONTest
{
    public class TaskFirst
    {
        public static void FindSeven()
        {
            double num;

            Console.WriteLine("Введите любое число и нажмите Enter");
            num = Double.Parse(Console.ReadLine());

            if (num > 7)
            {
                Console.WriteLine("Привет");
            }
        }
    }
}
