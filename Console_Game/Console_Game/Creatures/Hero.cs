namespace Console_Game.Creatures
{
    public class Hero : Creature
    {
        public Hero()
            :base(3, 2, 1, 3, 1, 5)
        {
            this.Position = new Coordinate(11, 11); // The heroes are outside of the battlefield
        }
    }
}
