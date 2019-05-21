using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class GameOverMenu : Window
    {
        private TextBlock _titleTextBlock;
        public List<Button> _btn { get; set; } = new List<Button>();

        public GameOverMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "GAME OVER" });

            _btn.Add(new Button(20, 13, 18, 5, "REPLAY"));
            _btn[0].SetActive();
            _btn.Add(new Button(50, 13, 18, 5, "MENU"));
            _btn.Add(new Button(80, 13, 18, 5, "QUIT"));
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();
            _btn[0].Render();
            _btn[1].Render();
            _btn[2].Render();

            Console.SetCursorPosition(33, 13);
        }

        public void LeftActive()
        {
            if (_btn[0].IsActive)
            {
                _btn[0].DeActive();
                _btn[0].Render();
                _btn[2].SetActive();
                _btn[2].Render();
            }
            else if (_btn[1].IsActive)
            {
                _btn[1].DeActive();
                _btn[1].Render();
                _btn[0].SetActive();
                _btn[0].Render();
            }
            else
            {
                _btn[2].DeActive();
                _btn[2].Render();
                _btn[1].SetActive();
                _btn[1].Render();
            }
        }

        public void RightActive()
        {
            if (_btn[0].IsActive)
            {
                _btn[0].DeActive();
                _btn[0].Render();
                _btn[1].SetActive();
                _btn[1].Render();
            }
            else if (_btn[1].IsActive)
            {
                _btn[1].DeActive();
                _btn[1].Render();
                _btn[2].SetActive();
                _btn[2].Render();
            }
            else
            {
                _btn[2].DeActive();
                _btn[2].Render();
                _btn[0].SetActive();
                _btn[0].Render();
            }
        }
    }
}
