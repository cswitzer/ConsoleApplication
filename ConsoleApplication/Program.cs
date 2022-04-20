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
            CalcGlazerDimensions();

            Console.ReadKey();
        }

        static void CalcGlazerDimensions()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the window's width in metres: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the window's height in metres: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width * height) * 3.25;
            glassArea = width * height;

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");
        }
    }
}
