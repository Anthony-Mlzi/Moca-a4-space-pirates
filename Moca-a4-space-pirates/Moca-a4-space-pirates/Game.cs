// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        CanonBall[] canonBalls = new CanonBall[0];
        int canonBallIndex = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //add basic setup information
            Window.SetSize(800, 600);
            Window.SetTitle("SPACE PIRATES");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

 

            //Making code for CanonBall input.
            if (Input.IsMouseButtonPressed(MouseInput.Left)) SpawnCanonBall();
          

        }

        //Set up spawn for CanonBall.
        void SpawnCanonBall()
        {
            CanonBall canonBall = new CanonBall();
            canonBall.position = Window.Size / 2.0f;

            canonBalls[canonBallIndex] = canonBall;
            canonBallIndex++;

            if (canonBallIndex >= canonBalls.Length) canonBallIndex = 0;

            Window.ClearBackground(Color.White);
          

        }
    }

}
