namespace Console_Game
{
    using System;

    public class Coordinate
    {
        private int x;
        private int y;

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.y = value;
            }
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", this.X, this.Y);
        }
    }
}
