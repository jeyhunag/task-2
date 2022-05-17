using System;

namespace task_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 1;
            int val2 = 100;
            int sum = 0;
            for (int i = val1; i <= val2; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
