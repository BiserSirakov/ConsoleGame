namespace Console_Game.Creatures
{
    public class Griffon : Creature
    {
        public Griffon()
            :base(1, 1, 1, 1, 5, 1)
        {
            this.Position = new Coordinate(0, 0);
        }
    }
}
