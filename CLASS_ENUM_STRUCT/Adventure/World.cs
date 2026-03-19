using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adventure.Player;

namespace Adventure
{
    public class World
    {
        public int[,] Map { get; set; }
        public string WorldName { get; set; }
        public Point2D StartingPoint { get; set; }
        public Point2D Goal { get; set;}
        // 2 -  Tee World klass, koos nelja andmeväljaga
        //      World klassis on üks konstruktor, kus kasutatakse kõiki andmeid
        //      andmeväljad on: int[,] Map, string WorldName, Point2D Start, Point2D Goal

        /// <summary>
        /// Constructor for default world, with size of 10x10
        /// </summary>
        /// <param name="thisMap">2d array for the map of the world, contains integers that represent different events</param>
        /// <param name="thisWorldName">Name for this world</param>
        /// <param name="start">Where the player is spawned at</param>
        /// <param name="end">Where the player finishes the game</param>
        public World(int[,] thisMap, string thisWorldName, Point2D start, Point2D end)
        {
            Map = thisMap;
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        /// <summary>
        /// Constructor for default world, with size of 10x10, map is generated randomly.
        /// </summary>
        /// <param name="thisWorldName">Name for this world</param>
        /// <param name="start">Where the player is spawned at</param>
        /// <param name="end">Where the player finishes the game</param>
        public World( string thisWorldName, Point2D start, Point2D end)
        {
            Map = NewMap(10,WhatEvent.GetNames(typeof(WhatEvent)).Length);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        /// <summary>
        /// Method to generate a new map randomly
        /// </summary>
        /// <param name="size">the size of the map, both x and y axis</param>
        /// <param name="maxEventInteger">the integer id for the last possible event to be put into the array</param>
        /// <returns>a new generated map</returns>
        private int[,] NewMap(int size,int maxEventInteger)
        {
            int[,] newMap = new int[size, size];
            Random rng = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newMap[i, j] = rng.Next(1, maxEventInteger + 1);
                }
            }
            return newMap;
        }
    }
}
