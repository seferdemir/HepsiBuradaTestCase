using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static int bound_X;
        static int bound_Y;
        static int coor_X;
        static int coor_Y;
        static char or;

        static void Main(string[] args)
        {
            string[] result = Test(new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static string[] Test(string[] lines)
        {
            List<string> result = new List<string>();

            int.TryParse(lines[0].Split(' ')[0], out bound_X);
            int.TryParse(lines[0].Split(' ')[1], out bound_Y);

            for (int i = 1; i < lines.Length; i += 2)
            {
                int.TryParse(lines[i].Split(' ')[0], out coor_X);
                int.TryParse(lines[i].Split(' ')[1], out coor_Y);
                char.TryParse(lines[i].Split(' ')[2], out or);

                Rover rover = new Rover(coor_X, coor_Y, or);

                for (int j = 0; j < lines[i + 1].Length; j++)
                {
                    rover.Control(lines[i + 1][j]);
                }

                result.Add(rover.GetPosition());
            }

            return result.ToArray();
        }
    }
}
