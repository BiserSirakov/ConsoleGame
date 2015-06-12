namespace Console_Game.Creatures
{
    public class Archer : Creature
    {
        public Archer()
            :base(10, 2, 2, 2, 3, 2)
        {
            this.Position = new Coordinate(2, 0);
        }
    }
}
