using System;

namespace CG_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length of rectangle: ");
            String rectangleLength;
            rectangleLength = Console.ReadLine();
            int rectangleLengthInt = int.Parse(rectangleLength);
            

            Console.Write("Width of rectangle: ");
            String rectangleWidth;
            rectangleWidth = Console.ReadLine();
            int rectangleWidthInt = int.Parse(rectangleWidth);

            Console.WriteLine("Rectangle Area: " + " " + (rectangleLengthInt * rectangleWidthInt) );
            Console.ReadLine();


        }
    }
}
