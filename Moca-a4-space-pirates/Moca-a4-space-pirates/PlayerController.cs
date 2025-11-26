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

        public Vector2 CursorDelay(Vector2 CurrentCursorPos, Vector2 MousePos, float smoothing)
        {
            return CurrentCursorPos + (MousePos - CurrentCursorPos) * smoothing;
        }
        public void setup()
        {
            
            CannonPos = new Vector2(400, 500);
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

        }
       

    }
}
