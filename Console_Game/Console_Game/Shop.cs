namespace Console_Game
{
    using System;
    using System.Collections.Generic;
    using Console_Game.Creatures;

    public class Shop
    {
        public void AddUnitToPlayer(Player player, Creature unit, int amountOfUnits)
        {
            if (unit.GetType().Name == "Archer")
            {
                if (player.Gold - (amountOfUnits * 50) >= 0)
                {
                    for (int i = 0; i < amountOfUnits; i++)
                    {
                        player.Gold -= 50; // One Archer costs 50 gold
                        player.Units.Add(new Archer(), 50);
                    }
                }
                else
                {
                    var remainingGold = player.Gold - amountOfUnits * 50;
                    Console.WriteLine("Not enough gold! {0} remaining", -remainingGold);
                }
            }

            else if (unit.GetType().Name == "Footman")
            {
                if (player.Gold - (amountOfUnits * 90) >= 0)
                {
                    for (int i = 0; i < amountOfUnits; i++)
                    {
                        player.Gold -= 90; // One Footman costs 90 gold
                        player.Units.Add(new Footman(), 90);
                    }
                }
                else
                {
                    var remainingGold = player.Gold - amountOfUnits * 90;
                    Console.WriteLine("Not enough gold! {0} remaining", -remainingGold);
                }
            }

            else if (unit.GetType().Name == "Griffon")
            {
                if (player.Gold - (amountOfUnits * 150) >= 0)
                {
                    for (int i = 0; i < amountOfUnits; i++)
                    {
                        player.Gold -= 150; // One Griffon costs 150 gold
                        player.Units.Add(new Griffon(), 150);
                    }
                }
                else
                {
                    var remainingGold = player.Gold - amountOfUnits * 150;
                    Console.WriteLine("Not enough gold! {0} remaining", -remainingGold);
                }
            }

            else if (unit.GetType().Name == "Peasant")
            {
                if (player.Gold - (amountOfUnits * 30) >= 0)
                {
                    for (int i = 0; i < amountOfUnits; i++)
                    {
                        player.Gold -= 30; // One Peasant costs 30 gold
                        player.Units.Add(new Peasant(), 30);
                    }
                }
                else
                {
                    var remainingGold = player.Gold - amountOfUnits * 30;
                    Console.WriteLine("Not enough gold! {0} remaining", -remainingGold);
                }
            }
        }
    }
}
