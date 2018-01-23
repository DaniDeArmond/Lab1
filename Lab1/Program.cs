using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {



        static void Main(string[] args)
        {
            //declaring variaables
            double Width, Length, Height, Perimeter, Area, Volume;
            char DoAgain;
            bool Repeat1 = true;

            Console.WriteLine("This program will measure the perimeter, area, and volume of a room." + Environment.NewLine);
                        
            while (Repeat1 == true)
            {
                Console.WriteLine(Environment.NewLine + "Please enter the Width of your room.");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine(Environment.NewLine + "Please enter the Length of your room.");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine(Environment.NewLine + "Please enter the Height of your room.");
                Height = double.Parse(Console.ReadLine());

                Perimeter = (2 * Length) + (2 * Width);
                Area = (Length * Width);
                Volume = (Length * Width * Height);

                Console.WriteLine($"Perimeter: {Perimeter}" + Environment.NewLine + $"Area: {Area}" + Environment.NewLine + $"Volume: {Volume}" + Environment.NewLine);

                Console.WriteLine(Environment.NewLine + "Would you like to calculate this for another room? (Y or N)");

                DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'Y' | DoAgain == 'y')
                {
                    Repeat1 = true;
                }
                else
                {
                    Repeat1 = false;
                }
            }
        }
    }
}
