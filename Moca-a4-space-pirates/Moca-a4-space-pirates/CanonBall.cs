using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class CanonBall
    {
        public Vector2 position;
        public Vector2 velocity;

        float speed = 400.0f;

        public void Setup()
        {

        }

        public void Update()
        {
            ProcessPhysics();
            DrawCanonBall();
        }

        void ProcessPhysics()
        {
            position += speed * velocity * Time.DeltaTime;
        }

        void DrawCanonBall()
        {
            Draw.LineSize = 2;
            Draw.FillColor = Color.Black;
            Draw.Circle(position, 7.0f);
        }
    }
}
