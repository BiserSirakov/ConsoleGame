namespace Console_Game.Creatures
{
    public class Peasant : Creature
    {
        public Peasant()
            :base(2, 2, 3, 1, 3, 1)
        {
            this.Position = new Coordinate(3, 0);
        }
    }
}
