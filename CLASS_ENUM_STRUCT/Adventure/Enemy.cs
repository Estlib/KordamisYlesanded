using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Enemy
    {
        public string EnemyName { get; set; }
        public int EnemyHealth { get; set; }
        public int EnemyLives { get; set; } = 1;
        public string Catchphrase { get; set; }
        public int HitPower { get; set; }

        public Enemy(string name, int hp, string msg, int power)
        {
            EnemyName = name;
            EnemyHealth = hp;
            Catchphrase = msg;
            HitPower = power;
        }
    }
}
