///<summary>
///Definition: A fired, thrown, or otherwise propelled object, 
///such as a bullet, having no capacity for self-propulsion.
///
///Responsibility:Is to create a point value. Then give if coal or a gem And Seen image

using System;
using System.Collections.Generic;

namespace Greed.Game.Casting
{
    public class Projectile : Actor
    {
        static Random rnd = new Random();
        public static int[] points = {-550,-500,-333,-225,-59,-51,30,50,99,159,500,1000};
        public static int[] rockpoints = {-550,-500,-333,-225,-59,-51};
        public static int[] gempoints = {30,50,99,159,500,1000};
        static List<int> pointlist = new List<int>(points);
        static List<int> rockpointlist = new List<int>(rockpoints);
        static List<int> gempointlist = new List<int>(gempoints);
        public string Name = "I dont know what that was...";
        ///Text is how it looks
        public string Text = "?";
        public int pointvalue = 0;
        public void AddProjectile(string Name) 
        {
            ///int index = rnd.Next(pointlist.Count);
            // pointvalue = pointlist[rnd.Next(pointlist.Count)];

            if (Name == "gems")
            {
                Text = "@";
                pointvalue = gempointlist[rnd.Next(gempointlist.Count)];

            }
            else if (Name == "rocks") 
            {
                Text = "▣";
                pointvalue = rockpointlist[rnd.Next(rockpointlist.Count)];
            }
            else
            {
                return;
            }
        }
    }   
}



