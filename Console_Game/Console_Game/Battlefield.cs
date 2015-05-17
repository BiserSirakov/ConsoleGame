namespace Console_Game
{
    public class Battlefield
    {
        private Coordinate[,] matrix;

        public Battlefield()
        {
            this.Matrix = new Coordinate[10, 10];
            FillBattlefield();
        }


        public Coordinate[,] Matrix
        {
            get 
            { 
                return this.matrix; 
            }
            set 
            { 
                this.matrix = value;
            }
        }
        
        private void FillBattlefield()
        {
            for (int i = 0; i < this.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.Matrix.GetLength(1); j++)
                {
                    this.Matrix[i, j] = new Coordinate(i, j);
                }
            }
        }
    }
}
