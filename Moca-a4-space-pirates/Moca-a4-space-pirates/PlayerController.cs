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
        float cursorSpeed = 8.0f; // have the cursor follow behind mouseposition to make aiming more of a challenge

        public Vector2 CursorDelay(Vector2 OldCursorPos, Vector2 MousePos, float smoothing)
        {
            return OldCursorPos + (MousePos - OldCursorPos) * smoothing;
        }
        public void setup()
        {
                     
            CursorPos = new Vector2(Input.GetMouseX(), Input.GetMouseY());

        }


        public void update()
        {
            Vector2 MousePos = new Vector2(Input.GetMouseX(), Input.GetMouseY());
            float smoothing = cursorSpeed * Time.DeltaTime;
            CursorPos = CursorDelay(CursorPos, MousePos, smoothing);
            DrawCursor();
            DrawCannon();

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
            Vector2 CannonCenter = new Vector2(Window.Width / 2, Window.Height - 20f);

            float cannonWidth = 50;
            float cannonHeight = 100;
            float rotation = MathF.Atan2(CursorPos.Y - CannonCenter.Y, CursorPos.X - CannonCenter.X);
            Vector2 top = CannonCenter + new Vector2(
                MathF.Cos(rotation) * cannonHeight / 2,
                MathF.Sin(rotation) * cannonWidth / 2);

            Draw.LineColor = Color.Gray;
            Draw.LineSize = 10;
            Draw.Line(CannonCenter, top);
            Draw.FillColor = Color.Black;
            Draw.Circle(CannonCenter, cannonWidth / 4);

        }
       

    }
}
