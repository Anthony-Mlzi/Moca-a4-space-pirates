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
        bool titleScreen;
        bool gameGoing;
        bool rulesScreen;

        Buttons[] titleScreenButtons =
        {

        };

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
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //can you see this
        }
    }

}
