using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class EnemyController
    {
        //variables

        public void setup()
        {
            //runs once
        }
        public void update()
        {
            //runs every frame
            CirclePosition();
        }
        public void CirclePosition()
        {
            Vector2 circlePosition = new Vector2();
            float circleRadius = 50.0f;

            Draw.FillColor = Color.Red;
            Draw.LineSize = 0;
            Draw.Circle(circlePosition, circleRadius);
        }
    }
}
