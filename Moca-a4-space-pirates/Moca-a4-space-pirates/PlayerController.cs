using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class PlayerController
    {
        Vector2 CursorPos;
        Vector2 CannonPos;
        public void setup()
        {
            
            CannonPos = new Vector2(400, 500);
            
            
        }


        public void update()
        {
            CursorPos = new Vector2(Input.GetMouseX(), Input.GetMouseY());
            DrawCursor();


        }

        void DrawCursor()
        {
            Color deepred = new Color("#A83A27");
            Draw.FillColor = Color.Clear;
            Draw.LineColor = deepred;
            Draw.LineSize = 2;
            Draw.Circle(CursorPos, 10);
        }

        void DrawCannon()
        {

        }
    }
}
