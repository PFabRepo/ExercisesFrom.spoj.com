using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereOnlineJudgeExercises
{
    class PrimeNumbers
    {
       
        public List<int> numbers = new List<int>();
        //Random rnd = new Random();
        int yourNumbers;
        public void Introduce()
        {
            Console.WriteLine("Hello I'am an aplication that check the prime numbers! ");
            Console.WriteLine("Give me numbers to check:)!");

            for (int i = 0; i <= 5; i++)
            {
                 yourNumbers = int.Parse(Console.ReadLine());
                //yourNumbers = rnd.Next(1 , 101);
                numbers.Add(yourNumbers);

            }

            foreach (var item in numbers)
            {
                //Console.WriteLine(item);
                if ((item % 2 != 0 || item == 2) && (item % 3 != 0 || item == 3))
                {
           
                    Console.WriteLine($"Number {item} is a Prime number!!");
                }
                else
                {
                    Console.WriteLine($"No! {item} It is not a Prime number ");
                }

              
            }




        }



    }
}
