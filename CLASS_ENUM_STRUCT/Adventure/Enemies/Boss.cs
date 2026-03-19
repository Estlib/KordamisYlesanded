using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    public class Boss : Enemy
    {
        public string BossWeaponName { get; set; }
        public int BossWeaponHitPower  { get; set; }
        public Boss(string weapon, int weaponpower, string name, int hp, int lives, string msg, int power) : base(name, hp, msg, power)
        {
            BossWeaponName = weapon;
            BossWeaponHitPower = weaponpower;
            EnemyName = name;
            EnemyHealth = hp;
            EnemyLives = lives;
            Catchphrase = msg;
            HitPower = power;
        }
    }
}
