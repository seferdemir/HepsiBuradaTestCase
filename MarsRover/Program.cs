using System;
using System.Collections.Generic;

namespace MarsRover
{
    /* 
     * Sefer Demir - Hepsiburada Case Study Mars Rover - 23.08.2020
     * Gezginin plato sınırlar içerisinde hareket edilmesi sağlanmış, hata durumlarının kontrolü yapılmıştır.
     * Hatalarının yazdırılması istenilmediği için yoruma alınmıştır.
     */
    class Program
    {
        static int bound_X;
        static int bound_Y;
        static int coor_X;
        static int coor_Y;
        static char or;

        static void Main(string[] args)
        {
            Test(new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" });
            //Test(new string[] { "5 5", "1 2 N", "LMLMLM", "2 2 N", "LMLML" });
            //Test(new string[] { "5 5", "1 2 N", "LMMMM", "2 2 N", "RMMMML" });

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

                Rover rover = new Rover(bound_X, bound_Y, coor_X, coor_Y, or);

                for (int j = 0; j < lines[i + 1].Length; j++)
                {
                    if (lines[i + 1][j] == 'L' || lines[i + 1][j] == 'R' || lines[i + 1][j] == 'M')
                        rover.Control(lines[i + 1][j]);
                    //else
                    //    Console.WriteLine("Wrong command!");
                }

                //if (result.Contains(rover.GetPosition()))
                //    Console.WriteLine("There is another rover at this position!");
                Console.WriteLine(rover.GetPosition());

                result.Add(rover.GetPosition());
            }

            return result.ToArray();
        }
    }
}
