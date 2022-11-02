namespace Greed;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Greed.Game.Directing;
using Greed.Game.Services;



{
    /// <summary>
    /// The program's entry point.COLS
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        ///public CELL_SIZE For the movment scale for all of Casting
        public static int CELL_SIZE = 15;
        ///Public Fontsize for size of all casting
        public static int FONT_SIZE = 15;
        private static int COLS = 60;
        ///public ROWS for the casting to know where to start(on the x Axis)
        public static int ROWS = 40;
        private static string CAPTION = "Greed";
        private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_ARTIFACTS = 40;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner for points
            Actor banner = new Actor();
            banner.SetText("");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            // create the user
            Actor user = new Actor();
            user.SetText("#");
            user.SetFontSize(FONT_SIZE);
            user.SetColor(WHITE);
            user.SetPosition(new Point(MAX_X / 2, MAX_Y / 2));
            cast.AddActor("user", user);

            ///Andrew, you can get rid of messages
            // load the messages
            List<string> messages = File.ReadAllLines(DATA_PATH).ToList<string>();

           

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}