using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MenuController menuController = new MenuController();
            menuController.ShowMenu();
            Console.ReadKey();
        }
    }
}
