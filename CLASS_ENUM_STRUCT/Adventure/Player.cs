using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public struct Point2D
        {
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;

            public override string ToString()
            {
                return X+","+Y;
            }
        }
        public Player(int lives, int health, Point2D location, List<string> backpack, int money)
        {
            Lives = lives;
            Health = health;
            Location = location;
            Backpack = backpack;
            Money = money;
        }
        public int Lives { get; set; } = 3;
        public int Health { get; set; } = 100;
        public Point2D Location { get; set; }
        public List<string> Backpack { get; set; } = new List<string>();
        public int Money { get; set; } = 0;

        public void DisplayStats()
        {
            Console.WriteLine($"Vapper rüütel, sul on hetkel alles {Lives} elu, ja tervis on {Health}.");
            Console.WriteLine($"Oled siin: {Location.ToString()} ja raha on sul {Money}");
            Console.WriteLine($"Seljakotis on: {string.Join(", ",Backpack)}");
        }

        /* meetod checkhealth*/
        public void CheckHealth()
        {
            if (Health <= 0)
            {
                Lives -= 1;
                Health = 100;
            }
        }
    }
}
