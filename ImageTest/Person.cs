using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTest
{
    static class Person
    {
        // a method that calculates the total time for which the work will be done. ( A=V*t ). t=A/(V1+V2+V3) 
        public static double TotalTime(int[] items, int countImg)
        {
            double sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                sum += (double)1 / items[i];

            }
            return Math.Ceiling(countImg / sum);
        }

        // a method that determines whether a number is prime
        private static bool IsPrimeNumber(int number)
        {
            int sqrtNumber = (int)(Math.Sqrt(number));
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // a method that counts the work of each employee 
        public static void Each_Make(double timeTotal, int restImage, int[] items)
        {
            //save personal work 
            int[] personalWork = new int[items.Length];

            // for each employee we check his productivity depending on his speed for the total time 
            for (int i = 1; i <= timeTotal; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (IsPrimeNumber(i) & (i % items[j] == 0) & restImage != 0)
                    {
                        personalWork[j] += 1;
                        restImage -= 1;
                    }
                    else
                    if ((i % items[j] == 0) & (i != 0) & restImage != 0)
                    {
                        personalWork[j] += 1;
                        restImage -= 1;
                    }
                }
            }

            // show productivity of each employee 
            for (int i = 0; i < personalWork.Length; i++)
            {
                Console.WriteLine("Person {0} edit: {1} images ", i + 1, personalWork[i]);
            }
            Console.ReadLine();
        }
    }
}
