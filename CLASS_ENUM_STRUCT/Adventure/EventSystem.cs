using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adventure
{
    public class EventSystem
    {
        public static void NextEncounter(Player player, Random rng)
        {
            int nextEncounterInt = rng.Next(1, 7);
            switch (nextEncounterInt)
            {
                case 1:
                    Event1_Kratt(player);
                    break;
                case 2:
                    Event2_Witch(player);
                    break;
                case 3:
                    Event3_Mushroom(player);
                    break;
                case 4:
                    Event4_Knife(player);
                    break;
                case 5:
                    Event5_Hill(player);
                    break;
                case 6:
                    Event6_Shop(player);
                    break;
                default:
                    break;
            }
        }

        private static void Event6_Shop(Player player)
        {
            List<string> shelf = new List<string>()
            {
                "katkine saabas",
                "mingi lambipirn",
                "DDR5 32GB 2x16 kit",
                "Juustukera",
                "Kotitäis lambasoolikaid"
            };
            List<int> prices = new List<int>()
            {
                1000,
                12,
                1600,
                3,
                -6,
            };
            for (int i = 0; i < shelf.Count; i++)
            {
                Console.WriteLine($"Riiulil paistab {shelf[i]} ning see maksab {prices[i]}.");
                Console.WriteLine("Kas sa tahad seda osta? (jah/ei)");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    if (prices[i] < player.Money)
                    {
                        player.Backpack.Add(shelf[i]);
                        player.Money -= prices[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sul pole piisavalt raha selle jaoks, vaata midagi muud.");
                    }
                }
                else
                {
                    Console.WriteLine("Vaatad järgmist asja");
                }
            }
            Console.WriteLine("Lahkusid poest");
        }

        private static void Event5_Hill(Player player)
        {
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvtava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    player.Money += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    player.Lives -= 1;
                    break;
            }

        }

        private static void Event4_Knife(Player player)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string response = Console.ReadLine();
            if (response == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                player.Backpack.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
        }

        private static void Event3_Mushroom(Player player)
        {
            Random newrng = new Random();
            int mushroomAffect = newrng.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string response = Console.ReadLine();
            if (response == "jah")
            {
                if (mushroomAffect >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + mushroomAffect + " elu.");
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-mushroomAffect) + " elu.");
                }
                player.Lives += mushroomAffect;
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");                
            }
        }

        private static void Event2_Witch(Player player)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string response = Console.ReadLine();
            if (response.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
            }
            else if (response.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                player.Lives += 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + response);
                player.Lives -= 1;
            }
        }

        private static void Event1_Kratt(Player player)
        {
            Random newrng = new Random();
            int generation = newrng.Next(1, 10); //suvaline täisarv vahemikus 1-10
            if (!player.Backpack.Contains("nuga"))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                int userGuess = int.Parse(Console.ReadLine());

                if (generation == userGuess) // kontrolli sisestust tingimuslauses
                {
                    Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb häbisse*"); //kui on õige
                }
                else
                {
                    Console.WriteLine("HJEHJEHJEH - õige vastus oli" + generation + "!!!! sa kaotasid!"); //kui on vale
                    player.Lives -= 1;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                    int userGuess = int.Parse(Console.ReadLine());

                    if (generation == userGuess) // kontrolli sisestust tingimuslauses
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb häbisse*"); //kui on õige
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli" + generation + "!!!! sa kaotasid!"); //kui on vale
                        player.Lives -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    player.Money += 25;
                    player.Backpack.Remove("nuga");
                }
            }
        }
    }
}


