using System;

namespace ConsoleProgram
{
    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            int result = a + b / 2;
            return result;

        }

        public static void Main(string[] args)
        {

           Console.WriteLine(Average(5, 3));

        }

    }
}
