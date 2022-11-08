///<summary>
///Definition: A fired, thrown, or otherwise propelled object, 
///such as a bullet, having no capacity for self-propulsion.
///
///Responsibility: make gems and rocks downward movement
/// falling object

/// responsibility is to keep track of point value(if a rock or gem)

using System;
using System.Collections.Generic;

namespace Greed.Game.Casting
{
    public class Projectile : Actor
    {
        static Random rnd = new Random();
        public static int[] points = {-500,-50,50,500};
        static List<int> pointlist = new List<int>(points);
        public string Name = "I dont know what that was...";
        ///Text is how it looks
        public string Text = "?";
        public void AddProjectile() 
        {
            ///int index = rnd.Next(pointlist.Count);
            int pointvalue = pointlist[rnd.Next(pointlist.Count)];

            if (pointvalue > 0)
            {
                Name = "A Gem";
                Text = "@";

            }
            else if (pointvalue < 0) 
            {
                Name = "A lump of Coal";
                Text = "▣";
                
            }
            else
            {
                return;
            }
        }
    }   
}



