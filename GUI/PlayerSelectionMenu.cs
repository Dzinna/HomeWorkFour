using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class PlayerSelectionMenu : Window
    {
        private TextBlock _titleTextBlock;
        public List<Button> _buttons { get; set; } = new List<Button>();
        public static int PlayerCount { get; set; }

        public PlayerSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "CHOOSE HOW MANY PLAYERS WILL PLAY AND PRESS ENTER" });

            _buttons.Add(new Button(33, 13, 18, 5, "P2"));
            _buttons[0].SetActive();
            _buttons.Add(new Button(50, 13, 18, 5, "P3"));
            _buttons.Add(new Button(67, 13, 18, 5, "P4"));
            _buttons.Add(new Button(33, 17, 18, 5, "P5"));
            _buttons.Add(new Button(50, 17, 18, 5, "P6"));
            _buttons.Add(new Button(67, 17, 18, 5, "P7"));
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            _buttons[0].Render();
            _buttons[1].Render();
            _buttons[2].Render();
            _buttons[3].Render();
            _buttons[4].Render();
            _buttons[5].Render();

            Console.SetCursorPosition(33, 13);
        }

        public void LeftActive()
        {
            if (_buttons[0].IsActive)
            {
                _buttons[0].DeActive();
                _buttons[0].Render();
                _buttons[5].SetActive();
                PlayerCount = 7;
                _buttons[5].Render();
            }
            else if (_buttons[1].IsActive)
            {
                _buttons[1].DeActive();
                _buttons[1].Render();
                _buttons[0].SetActive();
                PlayerCount = 2;
                _buttons[0].Render();
            }
            else if (_buttons[2].IsActive)
            {
                _buttons[2].DeActive();
                _buttons[2].Render();
                _buttons[1].SetActive();
                PlayerCount = 3;
                _buttons[1].Render();
            }

            else if (_buttons[3].IsActive)
            {
                _buttons[3].DeActive();
                _buttons[3].Render();
                _buttons[2].SetActive();
                PlayerCount = 4;
                _buttons[2].Render();
            }

            else if (_buttons[4].IsActive)
            {
                _buttons[4].DeActive();
                _buttons[4].Render();
                _buttons[3].SetActive();
                PlayerCount = 5;
                _buttons[3].Render();
            }

            else
            {
                _buttons[5].DeActive();
                _buttons[5].Render();
                _buttons[4].SetActive();
                PlayerCount = 6;
                _buttons[4].Render();
            }
        }

        public void RightActive()
        {
            if (_buttons[0].IsActive)
            {
                _buttons[0].DeActive();
                _buttons[0].Render();
                _buttons[1].SetActive();
                PlayerCount = 3;
                _buttons[1].Render();
            }
            else if (_buttons[1].IsActive)
            {
                _buttons[1].DeActive();
                _buttons[1].Render();
                _buttons[2].SetActive();
                PlayerCount = 4;
                _buttons[2].Render();
            }
            else if (_buttons[2].IsActive)
            {
                _buttons[2].DeActive();
                _buttons[2].Render();
                _buttons[3].SetActive();
                PlayerCount = 5;
                _buttons[3].Render();
            }

            else if (_buttons[3].IsActive)
            {
                _buttons[3].DeActive();
                _buttons[3].Render();
                _buttons[4].SetActive();
                PlayerCount = 6;
                _buttons[4].Render();
            }

            else if (_buttons[4].IsActive)
            {
                _buttons[4].DeActive();
                _buttons[4].Render();
                _buttons[5].SetActive();
                PlayerCount = 7;
                _buttons[5].Render();
            }

            else
            {
                _buttons[5].DeActive();
                _buttons[5].Render();
                _buttons[0].SetActive();
                PlayerCount = 2;
                _buttons[0].Render();
            }
        }

        public void UpDownActive()
        {
            if (_buttons[0].IsActive)
            {
                _buttons[0].DeActive();
                _buttons[0].Render();
                _buttons[3].SetActive();
                PlayerCount = 5;
                _buttons[3].Render();
            }
            else if (_buttons[1].IsActive)
            {
                _buttons[1].DeActive();
                _buttons[1].Render();
                _buttons[4].SetActive();
                PlayerCount = 6;
                _buttons[4].Render();
            }
            else if (_buttons[2].IsActive)
            {
                _buttons[2].DeActive();
                _buttons[2].Render();
                _buttons[5].SetActive();
                PlayerCount = 7;
                _buttons[5].Render();
            }

            else if (_buttons[3].IsActive)
            {
                _buttons[3].DeActive();
                _buttons[3].Render();
                _buttons[0].SetActive();
                PlayerCount = 2;
                _buttons[0].Render();
            }

            else if (_buttons[4].IsActive)
            {
                _buttons[4].DeActive();
                _buttons[4].Render();
                _buttons[1].SetActive();
                PlayerCount = 3;
                _buttons[1].Render();
            }

            else
            {
                _buttons[5].DeActive();
                _buttons[5].Render();
                _buttons[2].SetActive();
                PlayerCount = 4;
                _buttons[2].Render();
            }

        }
    }
}
