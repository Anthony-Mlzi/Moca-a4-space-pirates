using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Buttons
    {
        Vector2 size;
        Vector2 position;
        private string text;


        public Buttons(Vector2 position, Vector2 size, string text)
        {
            this.position = position;
            this.size = size;
            this.text = text;

        }

        public void Update()
        {
            DrawButton();
        }
        public void DrawButton()
        {
            Draw.FillColor = Color.LightGray;
            Draw.Rectangle(position, size);
            Text.Size = 30;
            Text.Draw(text, position);

        }

        public bool ClickCheck()
        {
            Vector2 mousePosition = Input.GetMousePosition();
            bool buttonPressed = false;
            if (mousePosition.X > position.X && mousePosition.X < position.X + size.X && mousePosition.y > position.y && mousePosition.Y < position.Y + size.Y && Input.IsMouseButtonPressed(0))
            {
                buttonPressed = true;
                return buttonPressed;
            }
            else
            {
                return false;
            }
        }

    }

}
