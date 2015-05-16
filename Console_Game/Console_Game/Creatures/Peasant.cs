namespace Console_Game.Creatures
{
    public class Peasant : Creature
    {
        public Peasant()
            :base()
        {

        }

        public Peasant(int damage, int defense, int health, int mana, int stamina, int critChance)
            :base(damage, defense, health, mana, stamina, critChance)
        {

        }

        public override void Attack()
        {
            base.Attack();
        }
        // TODO: those two are for future implementation 2
        public override void Move()
        {
            base.Move();
        }
    }
}
