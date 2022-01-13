using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 10;

            Console.WriteLine((answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine");
        }
    }
}
