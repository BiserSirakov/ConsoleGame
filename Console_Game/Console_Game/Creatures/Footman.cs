namespace Console_Game.Creatures
{
    public class Footman : Creature
    {
        public Footman()
            :base(3, 3, 30, 3, 4, 3)
        {
            this.Position = new Coordinate(1, 0);
        }
    }
}
