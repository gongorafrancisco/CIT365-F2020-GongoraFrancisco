//CIT 365
//Francisco Gongora
//W01 Assignment
//September 19th, 2020
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName = "Francisco Gongora";
            String myLocation = "Playa del Carmen, Mexico";
            String today = DateTime.UtcNow.ToShortDateString();
            DateTime christmasDate = new DateTime(2020, 12, 25);
            int daysForChristmas = (christmasDate - DateTime.UtcNow).Days;

            Console.WriteLine("Hello I am " + myName);
            Console.WriteLine("I am from: " + myLocation);
            Console.WriteLine("The current date is " + today);
            Console.WriteLine("Number of days left for Christmas: " + daysForChristmas);

            //Program from Book 2.1

            Console.WriteLine("This part of the program calculates the Wood Lenght and Glass Area for a window.");
            double width, height, woodLength, glassArea;
            String widthString, heightString;

            Console.WriteLine("Enter the width of the Window (in feet)");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height of the Window in (in meters)");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.5;
            glassArea = 2 * (width + height);

            Console.WriteLine("The lenght of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");
            Console.Write("Pres <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
