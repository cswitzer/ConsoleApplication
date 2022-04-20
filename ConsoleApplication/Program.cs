using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string location;
            
            // step 2
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            // step 3
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are from " + location);

            // step 4
            DateTime currentDate = DateTime.Today;
            Console.WriteLine("Today's date is " + currentDate.ToString("d"));

            // step 5
            DateTime christmasDate = new DateTime(2022, 12, 25);
            int numDaysTilChristmas = christmasDate.Subtract(currentDate).Days;
            Console.WriteLine("There are " + numDaysTilChristmas + " 'til Christmas!");

            // step 6


            Console.ReadKey();
        }
    }
}
