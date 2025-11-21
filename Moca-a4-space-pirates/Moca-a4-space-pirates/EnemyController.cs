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
        public float circleX = -50; //circle X movement
        public float circleY = Random.Float(50.0f, 550.0f); //circle Y position

        public float circleRadius = 50.0f; //circle radius
        public float speed = Random.Float(100.0f, 200.0f);

        public Vector2 circleHealthPosition = new(100, 25);
        public Vector2 circleHealthSize = new(600, 10);
        public float circleHealthBar;

        public void setup()
        {
            //runs once

        }
        public void update()
        {
            //runs every frame

            CircleCollision();

            CirclePosition();

            CircleHealth();
        }
        public void CirclePosition()
        {
            Vector2 circlePosition = new Vector2(circleX, circleY);

            circleX += Time.DeltaTime * speed;

            Draw.FillColor = Color.Red;
            Draw.LineSize = 0;
            Draw.Circle(circlePosition, circleRadius);

            if (Vector2.Distance(circlePosition, Input.GetMousePosition()) < circleRadius && Input.IsMouseButtonPressed(MouseInput.Left))
            {
                Console.WriteLine("HIT");
                circleHealthSize.X -= 20;
            }
        }
        public void CircleCollision()
        {
            if (circleX > 850)
            {
                circleX = -50;
                circleY = Random.Float(50.0f, 550.0f);
            }
        }
        public void CircleHealth()
        {
            Draw.LineSize = 2;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(circleHealthPosition, circleHealthSize);
        }
    }
}
