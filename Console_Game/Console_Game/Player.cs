namespace Console_Game
{
    using System;
    using System.Collections.Generic;
    using Console_Game.Creatures;

    public class Player
    {
        private int gold;
        private IDictionary<Creature, int> units;

        public Player()
        {
            this.Gold = 300; // starting gold
            this.units = new Dictionary<Creature, int>(); // the Player starts with no units
        }

        public int Gold
        {
            get
            {
                return this.gold;
            }
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.gold = value;
            }
        }

        public IDictionary<Creature, int> Units
        {
            get
            {
                return this.units;
            }
            set
            {
                this.units = value;
            }
        }

        public void ListUnits()
        {
            foreach (var item in Units)
            {
                Console.WriteLine("Creature: " + item.Key.GetType().Name + ", price: " + item.Value);
                Console.WriteLine("Damage: " + item.Key.Damage);
                Console.WriteLine("Defense: " + item.Key.Defense);
                Console.WriteLine("Health: " + item.Key.Health);
                Console.WriteLine("Mana: " + item.Key.Mana);
                Console.WriteLine("Stamina: " + item.Key.Stamina);
                Console.WriteLine("Critical Chance: " + item.Key.CritChance);
                Console.WriteLine();
            }
        }
    }
}
