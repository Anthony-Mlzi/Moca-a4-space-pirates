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
        EnemyController enemy = new EnemyController();
        int canonBallIndex = 0;
        Environment environment = new Environment();

        bool titleScreen;
        bool gameGoing;
        bool rulesScreen;

        //maybe a back button?

        // environment variable goes here
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("SPACE PIRATES");

            titleScreen = true;
            gameGoing = false;
            rulesScreen = false;

            // create the environment object here

            // run the environment Setup()
            environment.Setup();
        }

        //Test
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            // calls cannonball update for all currently present cannonballs
            for (int i = 0; i < canonBallIndex; i++)
            {
                canonBalls[i].Update();
            }

            //Making code for CanonBall input.
            if (Input.IsMouseButtonPressed(MouseInput.Left)) SpawnCanonBall();

            Console.WriteLine("null");

            if (titleScreen)
            {
                Console.WriteLine("title running");
                Window.ClearBackground(Color.White);

                Text.Size = 40;
                Text.Color = Color.Black;
                Text.Draw("My Space Game", new Vector2(150, 200));

                Text.Size = 20;
                Text.Color = Color.Black;
                Text.Draw("Press SPACE to start", new Vector2(250, 400));

                if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    titleScreen = false;
                    gameGoing = true; // switch to main game
                }
            }

            else if (gameGoing)
            {
                Console.WriteLine("game going");
                Window.ClearBackground(Color.Black);

                Text.Size = 20;
                Text.Color = Color.White;
                Text.Draw("Game is running!", new Vector2(300, 300));
                // TODO: add your gameplay drawing here

                // CALL environment.Update()
                environment.Update();
            }

            else if (rulesScreen)
            {
                Console.WriteLine("rules");
                Window.ClearBackground(Color.Gray);

                Text.Size = 20;
                Text.Color = Color.Black;
                Text.Draw("Rules go here...", new Vector2(200, 200));
                // TODO: add back button logic
            }

        }

        //Set up spawn for CanonBall.
        void SpawnCanonBall()
        {
            CanonBall canonBall = new CanonBall();
            canonBall.position = Window.Size / 2.0f;

            canonBalls[canonBallIndex] = canonBall;
            canonBallIndex++;

            if (canonBallIndex >= canonBalls.Length) canonBallIndex = 0;
        }
    }
}





