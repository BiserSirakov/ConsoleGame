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
        private Battlefield battlefield;

        public Game()
        {
            this.shopkeeper = new Shop();
            this.player = new Player();
            this.enemy = new Player();
            this.battlefield = new Battlefield();
        }

        public void Start()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Print list of bought units");
            Console.WriteLine("2. Move unit(s)");
            Console.WriteLine("3. Attack enemy`s unit(s)");
            Console.WriteLine("4. Print current version of the field");
            Console.WriteLine("5. End of turn");
            Console.WriteLine("6. Go back to main menu");
            Console.WriteLine("-----------------------------");
            Console.Write("Type here: ");
            var input = Console.ReadLine();
            ExecuteStartMenu(input);
        }

        private void ExecuteStartMenu(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("-----------------------------");
                    player.ListUnits();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
                case "2":
                    Console.WriteLine("-----------------------------");
                    MoveUnits();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
                case "3":
                    Console.WriteLine("-----------------------------");
                    AttackUnits();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
                case "4":
                    Console.WriteLine("-----------------------------");
                    PrintField();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
                case "5":
                    Console.WriteLine("-----------------------------");
                    EndOfTurn();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
                case "6":
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.Write("\nWrong input! Press any key... ");
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                    break;
            }
        }

        private void EndOfTurn()
        {
            // TODO: implenet end of turn
        }

        private void PrintField()
        {
            // TODO: print field
        }

        private void AttackUnits()
        {
            // TODO: implement attack
            // move unit next to enemy <= unit.stamina
            // unit.attack(enemy)
        }

        private void MoveUnits()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Write which unit you want to move as the example: \nmove /source coords/ /destination coords/ \n( move (2,2) (5,5) )");
            Console.Write("\nType here: ");
            var input = Console.ReadLine().Split(' ');

            if (input[0] != "move" || input.Length != 3)
            {
                Console.WriteLine("\nWrong input!");
            }
            else
            {
                var currentPosition = input[1];
                var currentX = int.Parse(currentPosition[1].ToString()); // from char to string and then to int
                var currentY = int.Parse(currentPosition[3].ToString());
                var destination = input[2];
                var destinationX = int.Parse(destination[1].ToString());
                var destinationY = int.Parse(destination[3].ToString());

                if (destinationX >= 10 || destinationY >= 10 || destinationX < 0 || destinationY < 0)
                {
                    Console.WriteLine("\nYou can not move the units out of the battlefield");
                }
                else
                {
                    foreach (var unit in player.Units)
                    {
                        if (unit.Key.Position.X == currentX && unit.Key.Position.Y == currentY)
                        {
                            unit.Key.Move(new Coordinate(destinationX, destinationY));
                        }
                        else
                        {
                            Console.WriteLine("\nThere is no unit at that coordinate");
                        }
                    }
                }
            }

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
            Console.WriteLine("Welcome to the Console Game !");
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
                case "1":
                    Console.Clear();
                    Start();
                    break;
                case "2":
                    Console.Clear();
                    VisitShop();
                    break;
                case "3":
                    Exit();
                    break;
                default:
                    Console.Write("\nWrong input! Press any key... ");
                    Console.ReadLine();
                    Console.Clear();
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
                    Console.WriteLine("Archer  - 50g");
                    Console.WriteLine("Footman - 90g");
                    Console.WriteLine("Griffon - 150g");
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    VisitShop();
                    break;
                case "2":
                    Console.WriteLine("-----------------------------");
                    BuyCommand();
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    VisitShop();
                    break;
                case "3":
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Your gold: " + player.Gold);
                    Console.WriteLine("-----------------------------");
                    Console.Write("Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    VisitShop();
                    break;
                case "4":
                    Console.Clear();
                    Menu();
                    break;
                default: Console.Write("\nWrong input! Press Enter to go back... ");
                    Console.ReadLine();
                    Console.Clear();
                    VisitShop();
                    break;
            }
        }

        private void BuyCommand()
        {
            Console.WriteLine("Write what you can buy as the example:\nbuy peasant/archer/footman/griffon amount (buy griffon 10)");
            Console.Write("\nType here: ");
            var input = Console.ReadLine().Split(' ');

            if (input[0] != "buy" || int.Parse(input[2]) <= 0)
            {
                Console.WriteLine("\nWrong input!");
            }
            else
            {
                switch (input[1])
                {
                    case "archer":
                        shopkeeper.AddUnitToPlayer(player, new Archer(), int.Parse(input[2]));
                        break;
                    case "footman":
                        shopkeeper.AddUnitToPlayer(player, new Footman(), int.Parse(input[2]));
                        break;
                    case "griffon":
                        shopkeeper.AddUnitToPlayer(player, new Griffon(), int.Parse(input[2]));
                        break;
                    case "peasant":
                        shopkeeper.AddUnitToPlayer(player, new Peasant(), int.Parse(input[2]));
                        break;
                    default:
                        Console.WriteLine("\nWrong input!");
                        break;
                }
            }
        }

        public void Run()
        {
            Menu();

            // Testing the different parts here

            //Creature archer = new Archer();
            //Creature footman = new Footman();
            //Console.WriteLine(footman.IsDead);
            //archer.Attack(footman);
            //Console.WriteLine(footman.Health);
            //Console.WriteLine(footman.IsDead);

            //Hero hero = new Hero();
            //Console.WriteLine(hero.Health);

            //Battlefield a = new Battlefield();
            //Console.WriteLine(a);
            
            //Player player1 = new Player();

            //Creature archer1 = new Archer();
            //Creature hero = new Hero();

            //Shop shop = new Shop();

            //shop.AddUnitToPlayer(player1, archer1, 2);
            //shop.AddUnitToPlayer(player1, hero, 1);

            //player1.ListUnits();
            //Console.WriteLine();
            //Console.WriteLine("gold: " + player1.Gold);
            //Console.WriteLine(battlefield.Matrix[8, 0].X);
        }
    }
}
