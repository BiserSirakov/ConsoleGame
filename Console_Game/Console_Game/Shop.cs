namespace Console_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Console_Game.Creatures;

    public class Shop
    {
        public void AddUnitToPlayer(Player player, Creature unit, int amountOfUnits)
        {
            if (unit.GetType().Name == "Archer")
            {
                for (int i = 0; i < amountOfUnits; i++)
			    {
                    player.Gold -= 50; // One Archer costs 50 gold
                    player.Units.Add(new Archer(), 50); 
			    }
            }

            else if (unit.GetType().Name == "Footman")
            {
                for (int i = 0; i < amountOfUnits; i++)
                {
                    player.Gold -= 90; // One Footman costs 90 gold
                    player.Units.Add(new Footman(), 90);
                }
            }

            else if (unit.GetType().Name == "Griffon")
            {
                for (int i = 0; i < amountOfUnits; i++)
                {
                    player.Gold -= 150; // One Griffon costs 150 gold
                    player.Units.Add(new Griffon(), 150);
                }
            }

            else if (unit.GetType().Name == "Hero")
            {
                for (int i = 0; i < amountOfUnits; i++)
                {
                    player.Gold -= 200; // One Hero costs 200 gold, it is not written in the .pdf file but I set it this way ( so a Player can have only one Hero )
                    player.Units.Add(new Hero(), 200);
                }
            }

            else if (unit.GetType().Name == "Peasant")
            {
                for (int i = 0; i < amountOfUnits; i++)
                {
                    player.Gold -= 30; // One Peasant costs 30 gold
                    player.Units.Add(new Peasant(), 30);
                }
            }
        }
    }
}
