using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereOnlineJudgeExercises
{
    class Exponentiation
    {
        int counter = 1;
        public void YourPower() 
        {
            Console.WriteLine("Hello! Give me basic number!");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, give me the exponent");
            int exponent = int.Parse(Console.ReadLine());

            for (int i = 0; i < exponent; i++)
            {
                counter *= number;
            }
            Console.WriteLine($"Your basic number {number} and exponent: {exponent} and the result of Exponentiation: {counter}");
            Console.WriteLine($"How much ten in your Exponentation: {counter / 10}");
        }



    }
}
