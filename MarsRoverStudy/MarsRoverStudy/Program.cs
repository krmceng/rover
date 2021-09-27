using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hi Technical Team!");
                Console.WriteLine("Please Write Command");
                var topPoint = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                var startPoint = Console.ReadLine().Trim().Split(' ');
                var action = Console.ReadLine().Trim();

                if (startPoint.Count() == 3)
                { 
                    var pointX = Convert.ToInt32(startPoint[0]);
                    var pointY = Convert.ToInt32(startPoint[1]);
                    var direction = startPoint[2];

                    var move = new Move(pointX, pointY, direction);
                    var location = move.DoAction(topPoint, action);

                    Console.WriteLine($"New Location is: {location}");
                }
                else
                    throw new Exception("Invalid Start Point!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
