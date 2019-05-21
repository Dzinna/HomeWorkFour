using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class MainMenu : Window
    {
        private TextBlock _titleTextBlock;
        public List<Button> buttons { get; set; } = new List<Button>();

        public MainMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "!!! WELCOME TO THE DICE GAME !!!"});

            buttons.Add(new Button(20, 13, 18, 5, "PLAY"));
            buttons[0].SetActive();
            buttons.Add(new Button(80, 13, 18, 5, "QUIT"));
            
        }

        public override void Render()
        {
            base.Render();
            _titleTextBlock.Render();
            buttons[0].Render();
            buttons[1].Render();
            Console.SetCursorPosition(20, 13);
        }

        public void LeftActive()
        {
            if (buttons[0].IsActive)
            {
                buttons[0].DeActive();
                buttons[0].Render();
                buttons[1].SetActive();
                buttons[1].Render();
            }
            else
            {
                buttons[1].DeActive();
                buttons[1].Render();
                buttons[0].SetActive();
                buttons[0].Render();
            }

        }

        public void RightActive()
        {
            if (buttons[0].IsActive)
            {
                buttons[0].DeActive();
                buttons[0].Render();
                buttons[1].SetActive();
                buttons[1].Render();
            }
            else 
            {
                buttons[1].DeActive();
                buttons[1].Render();
                buttons[0].SetActive();
                buttons[0].Render();
            }
        }
    }
}
