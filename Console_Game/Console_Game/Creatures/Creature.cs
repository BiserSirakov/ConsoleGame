namespace Console_Game.Creatures
{
    using System;

    public abstract class Creature
    {
        private int damage;
        private int defense;
        private int health;
        private int mana;
        private int stamina;
        private int critChance;

        public Creature()
        {
            this.Damage = 0;
            this.Defense = 0;
            this.Health = 0;
            this.Mana = 0;
            this.Stamina = 0;
            this.CritChance = 0;
        }

        public Creature(int damage, int defense, int health, int mana, int stamina, int critChance)
        {
            this.Damage = damage;
            this.Defense = defense;
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.CritChance = critChance;
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.damage = value;
            }
        }

        public int Defense
        {
            get
            {
                return this.defense;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.defense = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.health = value;
            }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.mana = value;
            }
        }

        public int Stamina
        {
            get
            {
                return this.stamina;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.stamina = value;
            }
        }

        public int CritChance
        {
            get
            {
                return this.critChance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.critChance = value;
            }
        }

        public virtual void Attack()
        {

        }
        // TODO: those two are for future implementation
        public virtual void Move()
        {

        }
    }
}
