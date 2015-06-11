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
            int rows = this.Matrix.GetLength(0); // rows = 10
            int cols = this.Matrix.GetLength(1); // cols = 10

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    this.Matrix[row, col] = new Coordinate(row, col);
                }
            }
        }
    }
}
