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
            CannonPos = new Vector2();
            
            
        }


        public void update()
        {
            DrawCursor(CursorPosX, CursorPosY);


        }

        void DrawCursor(float x, float y)
        {
            Color deepred = new Color("#A83A27");
            Draw.FillColor = Color.Clear;
            Draw.LineColor = deepred;
            Draw.LineSize = 2;
            Draw.Circle(CursorPosX, CursorPosY, 10);
        }

        void DrawCannon()
        {

        }
    }
}
