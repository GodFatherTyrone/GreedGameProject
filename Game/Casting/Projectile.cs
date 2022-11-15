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
        ///inishalizes random
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
        public int MAX_X = Program.MAX_X;
        public int MAX_Y = Program.MAX_Y;
        
        ///static int[] startpointlist = {25,50,75,100,125,150,175,200,225,250,275,300,325,350,375,400,425,450};
        ///int index = random.Next(startpointlist.Count);

        public void AddProjectile(string Name) 
        {
            ///int index = rnd.Next(pointlist.Count);
            // pointvalue = pointlist[rnd.Next(pointlist.Count)];
            
            //x = list[index];
            
            
            //int x = rnd.Next(0,600);
            int x = rnd.Next(0,60);
            int x2 = x * 25;
            
            //this.SetPosition(MAX_X,MAX_Y); 
            this.SetPosition(new Point(x2, MAX_Y));

            if (Name == "gems")
            {
                this.SetText("@");
                //Text = "@";
                pointvalue = gempointlist[rnd.Next(gempointlist.Count)];
                this.SetVelocity(new Point(0,10));

            }
            else if (Name == "rocks") 
            {
                //Text = "▣";
                this.SetText("▣");
                pointvalue = rockpointlist[rnd.Next(rockpointlist.Count)];
                this.SetVelocity(new Point(0,10));
            }
            else
            {
                return;
            }
        }
    }   
}



