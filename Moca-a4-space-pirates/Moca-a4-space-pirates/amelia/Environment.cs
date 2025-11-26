using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Environment
    {
        // Variables
        Vector2[] circlePositions;   // store the positions of the circles
        //Random rand;                 // random number generator

        public void Setup()
        {
            //rand = new Random();
            circlePositions = new Vector2[10];

            // generate 10 random positions
            for (int i = 0; i < circlePositions.Length; i++)
            {
                //float x = rand.Next(0, 800) // assuming window width = 800
                float x = Random.Float(0, 800);

                // FOR AMELIA TO FIX:
                //float y = rand.Next(0, 600); // assuming window height = 600
                float y = Random.Float(0, 600);
                circlePositions[i] = new Vector2(x, y);
            }
        }

        public void Update()
        {
            

            // draw each circle
            for (int i = 0; i < circlePositions.Length; i++)
            {
                Draw.FillColor = Color.White;
                Draw.Circle((int)circlePositions[i].X, (int)circlePositions[i].Y, 10);
            }
        }
    }
}