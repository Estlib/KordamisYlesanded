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
                case 6:
                    Event6_Shop(player);
                    break;
                default:
                    break;
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


