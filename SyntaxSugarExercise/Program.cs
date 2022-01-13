using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 10;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
