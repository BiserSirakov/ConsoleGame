namespace Console_Game.Creatures
{
    public class Hero : Creature
    {
        public Hero()
            :base()
        {

        }

        public Hero(int damage, int defense, int health, int mana, int stamina, int critChance)
            :base(damage, defense, health, mana, stamina, critChance)
        {

        }

        public override void Attack()
        {
            base.Attack();
        }
        // TODO: those two are for future implementation 6
        public override void Move()
        {
            base.Move();
        }
    }
}
