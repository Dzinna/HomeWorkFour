using DiceGame.GameStatusInfo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class GameController : Window
    {
        private TextBlock _titleTextBlock;
        private GameOverMenu _gameOverController = new GameOverMenu();
        private MenuController _menuController;
        public static List<Player> Players;
        public static List<DiceD6> Dice;
        public static List<string> ComputerNames = new List<string> { "Gina", "Arnas", "Tomas", "Arune", "Rima", "Jule", "Marius" };

        public GameController() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "!!! THE GAME STARTS !!!" });

        }
        public void StartGame()
        {
            GetPlayers();
            DisplayPlayers();
            Begin(Players);
        }

        private static void GetPlayers()
        {
            Players = new List<Player>();

            for (int i = 1; i <= PlayerSelectionMenu.PlayerCount; i++)
            {
                Player player = new Player(i);
                Players.Add(player);
            }
        }

        public static void DisplayPlayers()
        {
            Debug.Assert(Players != null && Players.Count >= 2);

            Console.WriteLine("Players in the game...");

            foreach (Player player in Players)
            {
                Console.WriteLine(player.CountOfPlayers + ". " + GameController.ComputerNames);
            }
        }

        public void Begin(List<Player> players)
        {
            Dice = new List<DiceD6>();

            for (int i = 1; i <= DiceSelectionMenu._diceCount; i++)
            {
                DiceD6 dice = new DiceD6();
                Dice.Add(dice);
            }
            Debug.Assert(Players != null && Players.Count >= 2);
            Debug.Assert(Dice != null && Dice.Count > 0);

            for (int i = 1; i <= DiceSelectionMenu._diceCount; i++)
            {
                foreach (Player p in players)
                {
                    Console.WriteLine("Player " + p.CountOfPlayers + "(" + p.Name + ") " + "roll... (Press enter to roll)");
                    Console.ReadLine();
                    Console.WriteLine("Player " + p.CountOfPlayers + "(" + p.Name + ") " + "rolled a " + p.RollDice() + Environment.NewLine);
                }
            }
            GetWinner();
            Console.ReadKey();
            GameOverMenu _gameOverController = new GameOverMenu();
            _gameOverController.Render();
            CheckMenu();
        }

        private static void GetWinner()
        {
            int maxWins = 0;
            List<Player> winners = new List<Player>();

            foreach (Player p in GameController.Players)
            {
                if (p.Wins >= maxWins)
                {
                    maxWins = p.Wins;
                }
            }

            foreach (Player p in GameController.Players)
            {
                if (p.Wins == maxWins)
                {
                    winners.Add(p);
                }
            }

            if (winners.Count == 1)
            {
                Console.WriteLine("Player " + winners.First().CountOfPlayers + "(" + winners.First().Name + ") won!!!");
            }
            else
            {
                Console.WriteLine("Tie!");
                Console.Write("Players ");
                foreach (Player p in winners)
                {
                    if (winners.Last() == p)
                    {
                        Console.Write(p.CountOfPlayers + "(" + p.Name + ") ");
                    }
                    else
                    {
                        Console.Write(p.CountOfPlayers + "(" + p.Name + "), ");
                    }

                }
                Console.Write("Tied!");
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            Console.SetCursorPosition(33, 13);
        }

        public void CheckMenu()
        {
            var ch = Console.ReadKey(true).Key;
            switch (ch)
            {
                case ConsoleKey.R:
                    if (_gameOverController._btn[0].IsActive)
                    {
                        Render();
                        StartGame();
                    }
                    else
                    {
                        break;
                    }
                    break;
                case ConsoleKey.M:
                    if (_gameOverController._btn[0].IsActive)
                    {
                        _menuController = new MenuController();
                        _menuController.Render();
                        _menuController.ShowMenu();
                    }
                    break;
                case ConsoleKey.Q:
                    if (_gameOverController._btn[1].IsActive)
                    {
                        break;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    _gameOverController.LeftActive();
                    CheckMenu();
                    break;
                case ConsoleKey.RightArrow:
                    _gameOverController.RightActive();
                    CheckMenu();
                    break;
                default:
                    CheckMenu();
                    break;
            }
        }
    }
}
