namespace Console_Game.Creatures
{
    public class Griffon : Creature
    {
        public Griffon()
            :base()
        {

        }

        public Griffon(int damage, int defense, int health, int mana, int stamina, int critChance)
            :base(damage, defense, health, mana, stamina, critChance)
        {

        }

        public override void Attack()
        {
            base.Attack();
        }
        // TODO: those two are for future implementation 5
        public override void Move()
        {
            base.Move();
        }
    }
}
