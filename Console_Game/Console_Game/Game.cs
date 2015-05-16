namespace Console_Game
{
    using System;
    using System.Linq;
    using Console_Game.Creatures;

    public class Game
    {
        private Player player;
        private Player enemy;
        private Shop shopkeeper;

        public Game() 
        {
            this.shopkeeper = new Shop();
            // Add units to player and enemy, which can be purchased and their price
        }

        public void Start()
        {
            // TODO: the start
        }

        public void VisitShop()
        {
            // TODO: the shop visit
        }

        public void Exit()
        {
            // TODO: the exit
        }

        public void Menu()
        {
            // TODO: the menu
        }

        public void Run()
        {
            // Testing the different parts here
            //Player player1 = new Player();

            //Creature archer1 = new Archer();
            //Creature hero = new Hero();

            //Shop shop = new Shop();

            //shop.AddUnitToPlayer(player1, archer1, 2);
            //shop.AddUnitToPlayer(player1, hero, 1);

            //player1.ListUnits();
            //Console.WriteLine();
            //Console.WriteLine("gold: " + player1.Gold);
            Console.Write("Type here: ");
            var commandLine = Console.ReadLine().Split(' ');
        }
    }
}
