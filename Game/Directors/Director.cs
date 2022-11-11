using System.Collections.Generic;
using Greed.Game.Casting;
using Greed.Game.Services;


namespace Greed.Game.Directing
{
    // <summary>
    // <para>A person who directs the game.</para>
    // <para>
    // The responsibility of a Director is to control the sequence of play.
    // </para>
    // </summary>
    public class Director
    {
        private KeyboardService _keyboardService = null;
        private VideoService _videoService = null;
        int pointTotal = 0;

        // <summary>
        // Constructs a new instance of Director using the given KeyboardService and VideoService.
        // </summary>
        // <param name="keyboardService">The given KeyboardService.</param>
        // <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;
        }

        // <summary>
        // Starts the game by running the main game loop for the given cast.
        // </summary>
        // <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            _videoService.CloseWindow();
        }

        // <summary>
        // Gets directional input from the keyboard and applies it to the user.
        // </summary>
        // <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor user = cast.GetFirstActor("user");
            Point velocity = _keyboardService.GetDirection();
            user.SetVelocity(velocity);
        }

        // <summary>
        // Updates the robot's position and resolves any collisions with artifacts.
        // </summary>
        // <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            //#1 Spawn rocks and gems
            int gemsNum = cast.GetActors("gems").Count;
            while (gemsNum < 50) { //makes sure there's always 50 or more projectiles on screen
                Projectile gem = new Projectile();
                gem.AddProjectile("gems");
                cast.AddActor("projectiles", gem);
                gemsNum++;
                
            }
            int rocksNum = cast.GetActors("rocks").Count;
            while (rocksNum < 50) {
                Projectile rock = new Projectile();
                rock.AddProjectile("rocks");
                cast.AddActor("projectiles", rock);
                rocksNum++;
            }
           //#2 get all actors form cast
            Actor banner = cast.GetFirstActor("banner");
            Actor user = cast.GetFirstActor("user");
            List<Actor> projectiles = cast.GetActors("projectiles");
            //#3 updat all actors 

            banner.SetText("");
            
            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            user.MoveNext(maxX, maxY);
            foreach (Actor projectile in projectiles)
            {
                projectile.MoveNext(maxX, maxY);
            }
            //#4 handle collitions
            // check if there is a collision between user and projectile
            // add or subtract from the score if it is a rock of a gem that was hit
            // also check if they reached the bottom and spawn a new one on top
            foreach (Actor actor in projectiles)
            {
                // change this to adding or subtracting from the score based on the projectile value
                // and kill it if it hit the user and spawn a new one
                if (user.GetPosition().Equals(actor.GetPosition()))
                {
                    Projectile projectile = (Projectile) actor;
                    pointTotal += projectile.pointvalue;
                    // This will be repurposed to a scoreboard
                    //Add the rock value to the user banner value
                    //change int to string
                    banner.SetText(pointTotal.ToString());
                    //romove
                    string text = actor.GetText();
                    cast.RemoveActor(text, actor);
                }
                // checks for it the rock reached the if it did kill it and replace it
                if (actor.GetPosition().Equals(maxY))
                {
                    string text = actor.GetText();
                    cast.RemoveActor(text, actor);

                }
            
            } 
            

            ///Add Actors
            
            
           

            


        }

        // <summary>
        // Draws the actors on the screen.
        // </summary>
        // <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            _videoService.ClearBuffer();
            _videoService.DrawActors(actors);
            _videoService.FlushBuffer();
        }

    }
}