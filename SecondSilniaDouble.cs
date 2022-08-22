using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereOnlineJudgeExercises
{
    class SecondSilniaDouble
    {
        int counter = 1;

        public void IntroduceCalculate() 
        {
            Console.WriteLine("Hello I'm apllication what calculate !Silnia from your number and give back how much there are number of unities and numbers of ten");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                counter *= i;
            }
            Console.WriteLine($"Your number {number} and your !Silnia: {counter}");
            Console.WriteLine($"Number of ten: {counter / 10}");
            Console.WriteLine($"Number of unities: {counter % 10}");


        }


    }
}
