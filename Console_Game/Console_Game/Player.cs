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
            this.Units = new Dictionary<Creature, int>(); // the Player starts with no units
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
                Console.WriteLine("DMG: " + item.Key.Damage);
                Console.WriteLine("DEF: " + item.Key.Defense);
                Console.WriteLine("HP:  " + item.Key.Health);
                Console.WriteLine("MP:  " + item.Key.Mana);
                Console.WriteLine("STA: " + item.Key.Stamina);
                Console.WriteLine("CC:  " + item.Key.CritChance + "%");
                Console.WriteLine();
            }
        }
    }
}
