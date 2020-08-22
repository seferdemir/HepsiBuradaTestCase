namespace MarsRover
{
    public class Rover
    {
        private int coor_X { get; set; }
        private int coor_Y { get; set; }
        private char or { get; set; }

        public Rover(int coor_X, int coor_Y, char or)
        {
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
                    coor_Y++;
                    break;
                case 'S':
                    coor_Y--;
                    break;
                case 'E':
                    coor_X++;
                    break;
                case 'W':
                    coor_X--;
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
