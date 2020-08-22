using System;

namespace MarsRover
{
    public class Rover
    {
        private int bound_X { get; set; }
        private int bound_Y { get; set; }
        private int coor_X { get; set; }
        private int coor_Y { get; set; }
        private char or { get; set; }

        public Rover(int bound_X, int bound_Y, int coor_X, int coor_Y, char or)
        {
            this.bound_X = bound_X;
            this.bound_Y = bound_Y;
            this.coor_X = coor_X;
            this.coor_Y = coor_Y;
            this.or = or;
        }

        public void SpinLeft()
        {
            switch (or)
            {
                case 'N':
                    or = 'W';
                    break;
                case 'W':
                    or = 'S';
                    break;
                case 'S':
                    or = 'E';
                    break;
                case 'E':
                    or = 'N';
                    break;
                default:
                    break;
            }
        }

        public void SpinRight()
        {
            switch (or)
            {
                case 'N':
                    or = 'E';
                    break;
                case 'E':
                    or = 'S';
                    break;
                case 'S':
                    or = 'W';
                    break;
                case 'W':
                    or = 'N';
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            switch (or)
            {
                case 'N':
                    if (coor_Y < bound_Y)
                        coor_Y++;
                    //else
                    //    Console.WriteLine("Rover out of bounds!");
                    break;
                case 'S':
                    if (coor_Y > 0)
                        coor_Y--;
                    //else
                    //    Console.WriteLine("Rover out of bounds!");
                    break;
                case 'E':
                    if (coor_X < bound_X)
                        coor_X++;
                    //else
                    //    Console.WriteLine("Rover out of bounds!");
                    break;
                case 'W':
                    if (coor_X > 0)
                        coor_X--;
                    //else
                    //    Console.WriteLine("Rover out of bounds!");
                    break;
                default:
                    break;
            }
        }

        public void Control(char command)
        {
            switch (command)
            {
                case 'L':
                    SpinLeft();
                    break;
                case 'R':
                    SpinRight();
                    break;
                case 'M':
                    Move();
                    break;
                default:
                    break;
            }
        }

        public string GetPosition()
        {
            return string.Format("{0} {1} {2}", coor_X, coor_Y, or);
        }
    }
}
