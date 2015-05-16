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
            this.player = new Player();
            this.enemy = new Player();
        }

        public void Start()
        {
            // TODO: the start
        }

        public void VisitShop()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. List of the available units and their prices");
            Console.WriteLine("2. Buy");
            Console.WriteLine("3. Available gold");
            Console.WriteLine("4. Back to main menu");
            Console.WriteLine("-----------------------------");
            Console.Write("Type here: ");
            var input = Console.ReadLine();
            ExecuteShopMenu(input);
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void Menu()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to the Console Game !");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Visit the Shop");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-----------------------------");
            Console.Write("Type here: ");
            var input = Console.ReadLine();
            ExecuteMainInput(input);
        }

        public void ExecuteMainInput(string input)
        {
            switch (input)
            {
                case "1": Start();
                    break;
                case "2": VisitShop();
                    break;
                case "3": Exit();
                    break;
                default: Console.WriteLine("\nWrong input!\n");
                    Menu();
                    break;
            }
        }

        public void ExecuteShopMenu(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Peasant - 30g");
                    Console.WriteLine("Footman - 90g");
                    Console.WriteLine("Archer - 50g");
                    Console.WriteLine("Griffon - 150g");
                    Console.WriteLine("-----------------------------");
                    GoBackToShop();
                    break;
                case "2": 
                    break;
                case "3":
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Your gold: " + player.Gold);
                    Console.WriteLine("-----------------------------");
                    GoBackToShop();
                    break;
                case "4": Menu();
                    break;
                default: Console.WriteLine("\nWrong input!\n");
                    VisitShop();
                    break;
            }
        }

        private void GoBackToShop()
        {
            Console.Write("Back ? yes/no: ");
            var input = Console.ReadLine();
            
            if (input == "yes")
            {
                VisitShop();
            }
            else
            {
                Exit();
            }
        }

        public void Run()
        {
            Menu();
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
            
        }
    }
}
