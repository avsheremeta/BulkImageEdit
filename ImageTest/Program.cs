using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageTest;

namespace ImageTest
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.Write("Enter the number of team members: ");          
            int countCrew = Int32.Parse(Console.ReadLine());

            // save personal speeds of employees 
            int[] speedPersons = new int[countCrew];

            for (int i = 0; i < speedPersons.Length; i++)
            {
                Console.Write("Enter the personal speed of the {0} employee: ", i + 1);              
                speedPersons[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // total number of pictures  
            Console.Write("Enter the number of pictures to edit: ");
            int allImages = Int32.Parse(Console.ReadLine());

            // total working time 
            double totalTime = Person.TotalTime(speedPersons, allImages);

            // show total time
            Console.WriteLine("The total working time is: " + totalTime + " minutes \n");

            // show personal work 
            Person.Each_Make(totalTime, allImages, speedPersons);

            Console.ReadLine();             
        }       
    }
}
