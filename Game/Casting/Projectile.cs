///<summary>
///Definition: A fired, thrown, or otherwise propelled object, 
///such as a bullet, having no capacity for self-propulsion.
///
///Responsibility: make gems and rocks downward movement
/// falling object

/// responsibility is to keep track of point value(if a rock or gem)

using System;
namespace Greed.Game.Casting
{
    public class Projectile
    {
        public int[] pointlist = {-500,-50,-5,5,50,500};
        private string Name = "I dont know what that was...";
        ///Text is how it looks
        private string Text = "@";
        public void Addrock();
        {
            public int pointvalue = Random.Next(pointlist.Count);

            if (pointvalue > 0)
            {
                Name = "A Gem";
                Text = "";

            }
            else if (pointvalue < 0)
            {
                Name = "A lump of Coal";
                Text = "";
            }
            else
            {
                return;
            }
        }
    }
}








// ///public int Color = Color.Color; 
        // public int COLS = Program.COLS;
        // public int ROWS = Program.ROWS;
        // ///Cell_Size is the Number of pixals for each unit of movment
        // public int velocity = Program.CELL_SIZE;
        // public int FONT_SIZE = Program.FONT_SIZE;
        // private int[] pointlist = {-500,-50,-5,5,50,500};

        // public void Addrock()
        // {
        //     // create the Projectile
        //     Random random = new Random();
        //     for (int i = 0; i < DEFAULT_PROJECTILE; i++)
        //     {
        //         string text = ((char)random.Next(33, 126)).ToString();

        //         int pointvalue = random.Next(pointlist);

        //         int velocity = random.Next(velocitylist);

        //         int x = random.Next(1, COLS);
        //         int y = (ROWS);
        //         Point position = new Point(x, y);
        //         position = position.Scale(CELL_SIZE);

        //         ///int r = random.Next(0, 256);
        //         ///int g = random.Next(0, 256);
        //         ///int b = random.Next(0, 256);
        //         ///Color color = new Color(r, g, b);

        //         ///Projectile projectile = new Projectile();
        //         ///text = How it looks
        //         ///projectile.SetText(text);
        //         ///projectile.SetFontSize(FONT_SIZE);
        //         ///projectile.SetColor(color);
        //         ///projectile.SetPosition(position);
        //         ///projectile.SetVelocity(velocity);
        //         ///pointvalue = adding or subtracting points
        //         ///projectile.Setpointvalue(pointvalue);

        //         ///if (pointvalue > 0)
        //         ///{
        //         ///    cast.AddActor("a Gem", projectile);
        //         ///}
        //         ///else if (pointvalue < 0)
        //         ///{
        //         ///    cast.AddActor("a piece of Coal", projectile);
        //         ///}
        //         ///else
        //         ///{
        //         ///    return;
        //         ///}