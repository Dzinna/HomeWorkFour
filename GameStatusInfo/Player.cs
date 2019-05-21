using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GameStatusInfo
{
    class Player
    {
        public string Name { get; set; }
        public int CountOfPlayers { get; set; }
        public int Wins { get; set; }
        public int RoundScore { get; set; }
  


        public Player(int playerNumber)
        {
            CountOfPlayers = playerNumber;
            
        }

        private void GenerateName()
        {
            Random rand = new Random();
            while (string.IsNullOrEmpty(Name))
            {
                int index = rand.Next(1, GameController.ComputerNames.Count);
                if (GameController.Players.Where(x => x.Name == GameController.ComputerNames[index]).FirstOrDefault() == null)
                {
                    Name = GameController.ComputerNames[index];
                }
            }
        }

        public void AddWin()
        {
            Wins++;
        }

        public int RollDice()
        {
            int rollScore = 0;
            foreach (DiceD6 diceD6 in GameController.Dice)
            {
                rollScore = diceD6.Roll();
            }
            RoundScore = rollScore;
            return rollScore;
        }
    }
}
