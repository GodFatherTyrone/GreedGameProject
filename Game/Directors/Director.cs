using System;

namespace Unit03.Game;
{
    public class Director
    {
        public Director()
        {


        }
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

        private void GetInputs(Cast cast)
        {

        }

        private void DoUpdates(Cast cast)
        {

        }

        public void DoOutputs(Cast cast)
        {

        }
        
    }
}


