using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class MenuController : Window
    {
        private MainMenu _gameWindow;
        private PlayerSelectionMenu _playerController;
        private DiceSelectionMenu _diceController;
        private GameController _gameController;       

        public MenuController() : base(0, 0, 120, 30, '%')
        {
            _gameWindow = new MainMenu();
            _gameWindow.Render();
        }

        public void ShowMenu()
        {
            CheckKey();
        }

        public void CheckKey()
        {
            var ch = Console.ReadKey(true).Key;
            switch (ch)
            {
                case ConsoleKey.P:
                    if (_gameWindow.buttons[0].IsActive)
                    {
                        _playerController = new PlayerSelectionMenu();
                        _playerController.Render();
                        checkPlayerWindow();
                    }

                    else
                    {
                        break;
                    }
                    break;
                case ConsoleKey.Q:
                    if (_gameWindow.buttons[1].IsActive)
                    {
                        break;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    _gameWindow.LeftActive();
                    CheckKey();
                    break;
                case ConsoleKey.RightArrow:
                    _gameWindow.RightActive();
                    CheckKey();
                    break;
                default:
                    CheckKey();
                    break;
            }
        }

        public void checkPlayerWindow()
        {
            var check = Console.ReadKey(true).Key;
            switch (check)
            {
                case ConsoleKey.Enter:
                    _diceController = new DiceSelectionMenu();
                    _diceController.Render();
                    CheckDiceWindow();
                    break;
                case ConsoleKey.LeftArrow:
                    _playerController.LeftActive();
                    checkPlayerWindow();
                    break;
                case ConsoleKey.RightArrow:
                    _playerController.RightActive();
                    checkPlayerWindow();
                    break;
                case ConsoleKey.UpArrow:
                    _playerController.UpDownActive();
                    checkPlayerWindow();
                    break;
                case ConsoleKey.DownArrow:
                    _playerController.UpDownActive();
                    checkPlayerWindow();
                    break;
                default:
                    checkPlayerWindow();
                    break;
            }
        }

        public void CheckDiceWindow()
        {
            var check = Console.ReadKey(true).Key;
            switch (check)
            {
                case ConsoleKey.Enter:
                    _gameController = new GameController();
                    _gameController.Render();
                    _gameController.StartGame();
                    break;
                case ConsoleKey.OemMinus:
                    _diceController.MinusActive();
                    CheckDiceWindow();
                    break;
                case ConsoleKey.OemPlus:
                    _diceController.PlusActive();
                    CheckDiceWindow();
                    break;
                default:
                    CheckDiceWindow();
                    break;
            }
        }
    }
}
