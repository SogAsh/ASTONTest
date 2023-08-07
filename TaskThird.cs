using System;

namespace ASTONTest
{
    public class TaskThird
    {
        public static void FindMultipleOf3(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                    Console.WriteLine(array[i]);
            }
        }
    }
}
