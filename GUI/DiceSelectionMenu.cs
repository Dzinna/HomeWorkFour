using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class DiceSelectionMenu : Window
    {
        private int _countOfDice = 1;
        public static int _diceCount { get; set; }
        private TextBlock _titleTextBlock;
        public Button _buttonCount;

        public DiceSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "CHOOSE HOW MANY DICE YOU WANT TO ROLL WITH + AND -" });
            _buttonCount = new Button(48, 15, 18, 3, "1");
        }

        public override void Render()
        {
            base.Render();
            _titleTextBlock.Render();
            _buttonCount.Render();
            Console.SetCursorPosition(33, 13);
        }

        public void ButtonValue()
        {
            _buttonCount = new Button(48, 15, 18, 3, Convert.ToString(_countOfDice));
            _buttonCount.SetActive();
        }

        public void PlusActive()
        {
            if (_countOfDice > 0)
            {
                if (_countOfDice == 4)
                {
                    _countOfDice = 4;
                    _diceCount = _countOfDice;
                    ButtonValue();
                }
                else
                {
                    _countOfDice++;
                    _diceCount = _countOfDice;
                    ButtonValue();
                }
            }
            else
            {
                _countOfDice = 1;
                _diceCount = _countOfDice;
                ButtonValue();
            }
        }

        public void MinusActive()
        {
            if (_countOfDice == 1)
            {
                _countOfDice = 1;
                _diceCount = _countOfDice;
                ButtonValue();
            }
            else
            {
                _countOfDice--;
                _diceCount = _countOfDice;
                ButtonValue();
            }
        }
    }
}
