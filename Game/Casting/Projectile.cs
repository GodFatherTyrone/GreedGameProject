///<summary>
///Definition: A fired, thrown, or otherwise propelled object, 
///such as a bullet, having no capacity for self-propulsion.
///
///Responsibility: make gems and rocks downward movement
/// falling object

using System;
namespace Greed.Game.Casting
{
    public class Projectile
    {
        private int COLS = Program.COLS;
        Program CELL_SIZE = (CELL_SIZE);
        Program FONT_SIZE= FONT_SIZE;
        private string[] pointlist = [-500,-50,-5,5,50,500];

        public void Addrock()
        {
            // create the Projectile
            Random random = new Random();
            for (int i = 0; i < DEFAULT_PROJECTILE; i++)
            {
                string text = ((char)random.Next(33, 126)).ToString();
                int pointvalue = random.Next(pointlist);

                int x = random.Next(1, COLS);
                int y = (ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Projectile projectile = new Projectile();
                ///text = How it looks
                projectile.SetText(text);
                projectile.SetFontSize(FONT_SIZE);
                projectile.SetColor(color);
                projectile.SetPosition(position);
                ///pointvalue = adding or subtracting points
                projectile.Setpointvalue(pointvalue);

                if (pointvalue > 0)
                {
                    cast.AddActor("a Jem", projectile);
                }
                else if (pointvalue < 0)
                {
                    cast.AddActor("a piece of Coal", projectile);
                }
                else
                {
                    return;
                }
            }
        }
    }
}