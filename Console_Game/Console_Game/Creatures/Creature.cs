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

        private bool isDead;
        private Coordinate position;

        public Creature(int damage, int defense, int health, int mana, int stamina, int critChance)
        {
            this.Damage = damage;
            this.Defense = defense;
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.CritChance = critChance;
            this.IsDead = false;
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

        public bool IsDead
        {
            get
            {
                return this.isDead;
            }

            protected set
            {
                this.isDead = value;
            }
        }

        public Coordinate Position
        {
            get
            {
                return this.position;
            }

            protected set
            {
                this.position = value;
            }
        }

        public virtual void Attack(Creature enemy)
        {
            enemy.Health -= this.Damage * 5 - enemy.Defense; // Overall damage

            if (enemy.Health <= 0)
            {
                enemy.Health = 0;
                enemy.IsDead = true;
            }
        }

        public virtual void Move(Coordinate point)
        {
            this.Position.X = point.X;
            this.Position.Y = point.Y;
        }
    }
}
