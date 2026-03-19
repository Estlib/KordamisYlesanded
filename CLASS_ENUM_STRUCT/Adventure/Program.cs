using Adventure.Enemies;
using System.Collections.Generic;
using static Adventure.Player;

namespace Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Lisa eventsystemile juurde uus event "enemyduel"
            Lisa juurde kaks uut klassi, baasklass enemy ja enemyl baseeruv klass Boss
            enemyl on omadusteks nimi (string), health (int), elud on enemy puhul algväärtusega 1, bopssil võib 
            rohkem olla (int), ja catchphrase (string) ning hitpower (int)
            boss omab ka andmevälja "BossWeaponName" (string) ja "BossWeaponHitPower" (int)

            eventsystemys enemyduel event teostab eventi sees tsüklis kakluse mis kestab
            niikaua kuni kas mängijal on elud otsas või enemyl on elud otsas.
            juhuarvuga otsustatakse kas vastaseks on üks kolmest enemy objektist (genereeritakse program.csis) või boss.
            bossi puhul juhuarvuga otsustatakse kas löök on mööda, boss lööb relvaga või boss lööb käega, 
            tavalise enemy puhul ainult mööda või käega. kui boss sureb, on mängijal võimalus relv üles võtta.
            */

            Random rng = new Random();
            string playAgain = "jah";
            World map = new World("helloworld", new Point2D(3, 9), new Point2D(6, 8));
            Player player = new Player(3, 100, map.StartingPoint, new List<string>(), 0);
            List<Enemy> enemies = new List<Enemy>() {
                    new Enemy("vanameeš",10,"AH MINE POE LEHMAPÕUE!",1),
                    new Enemy("põhjakonn",20,"...rooks.",5),
                    new Enemy("elon musk",1,"( ͡° ͜ʖ ͡°)",1),
                    new Enemy("ussike",60,"SSTSTSTSTT....!",25),
                    new Enemy("bätmän",10,"IM BATMAN",40),
                    new Enemy("blyadimir putsin",10,"Stand still, it is only special milteri operasson",1),
                };
            Boss boss = new Boss(
                "Kahepoolne sõjakirves",
                75,
                "Conan the Barbarian",
                100,
                3,
                "-",
                100
                );

            do
            {
                Console.Clear();
                Console.WriteLine("STATISTIKA ======================================");
                player.DisplayStats();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                bool didPlayerwin = EventSystem.CheckWin(player.Location, map.Goal);
                if (didPlayerwin)
                {
                    break;
                }
                EventSystem.NextEncounter(player, map, enemies, boss);
                EventSystem.NextLocation(player, map);

                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                player.CheckHealth();

                Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata");
                Console.ReadLine();
                Console.Clear();
                if (player.Lives <= 0)
                {
                    Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0, said surma ==--"); //kas kasutaja soovib uuesti mängida
                    playAgain = Console.ReadLine(); //saa vastus
                    if (playAgain == "jah")
                    {
                        player.Lives = 3;
                    }
                }
            }
            while (player.Lives > 0 || playAgain == "yes");
            if (player.Lives > 0)
            {
                Console.WriteLine("Võitsid");
            }
        }
    }
}
