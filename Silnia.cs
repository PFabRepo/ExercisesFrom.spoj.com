using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereOnlineJudgeExercises
{
    class Silnia
    {
        int counter = 1;

        public void Introduce()
        {
            Console.WriteLine("Hello I am apllication what count !Silnia(!strong)");
            Console.WriteLine("Give me number to calculation !Silnia");

            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("You gave the wrong number! You can't calculate number = 0 or ' - ' . Try again");
                Introduce();
            }
            
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    counter *= i;
                }
                Console.WriteLine($"Your number: {number} and it is !Silnia: {counter}");
            }


        }



       public static void Run()
        {
            Console.WriteLine("Write a number");
            string inputValue = Console.ReadLine();
            long factorialValue = CalculateFactorial(inputValue);
            Console.WriteLine($"Factorial({inputValue}) is {factorialValue}");


        }
        private static long CalculateFactorial(string input)
        {
            int inputValue = int.Parse(input);
            long factorialValue = Factorial(inputValue);
            long Factorial(int dataValue)
            {
                if (dataValue == 1)
                {
                    return 1;
                }
                else
                {
                    return dataValue * Factorial(dataValue - 1);
                }
            }

            return factorialValue;
        }


    }
}
