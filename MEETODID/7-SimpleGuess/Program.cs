namespace _7_SimpleGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Lisa juurde raha muutuja ja kolm eventi mis muudavad raha seisu - MEETODITEGA
             */



            int elud = 3;
            List<string> seljaKott = new List<string>();
            Random juhuArv = new Random(); //tee random generaator
            string mängijaMängib = "jah"; // vastus küsimusele kas mängija mängib
            do //tsükkel
            {
                do
                {
                    Console.Clear();
                    int järgmineEvent = juhuArv.Next(1, 5);
                    switch (järgmineEvent)
                    {
                        case 1:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb elukas.");
                            Console.WriteLine("Sul on alles " + elud + " elu.");
                            Console.WriteLine("Sul on seljakotis +"+seljaKott.Count+" asja.\n");
                            elud = KratiM6istatus(juhuArv, elud);
                            break;
                        case 2:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb elukas.");
                            Console.WriteLine("Sul on alles " + elud + " elu.");
                            Console.WriteLine("Sul on seljakotis +" + seljaKott.Count + " asja.\n");
                            elud = Nõid(juhuArv, elud);
                            break;
                        case 3:
                            Console.WriteLine("Kõnnid metsas ja vastu tuleb seen.");
                            Console.WriteLine("Sul on alles " + elud + " elu.");
                            Console.WriteLine("Sul on seljakotis +" + seljaKott.Count + " asja.\n");
                            elud = Seen(juhuArv, elud);
                            break;
                        case 4:
                            Console.WriteLine("Kõnnid tänaval ja näed maas midagi helkimas:");
                            Console.WriteLine("Sul on alles " + elud + " elu.");
                            Console.WriteLine("Sul on seljakotis " + seljaKott.Count + " asja.\n");
                            seljaKott = Nuga(seljaKott);
                            break;
                        default:
                            break;
                    }                
                    Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata");
                    Console.ReadLine();
                } while (elud > 0);

                if (elud <= 0)
                {
                    Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0 ==--"); //kas kasutaja soovib uuesti mängida
                    mängijaMängib = Console.ReadLine(); //saa vastus
                    if (mängijaMängib == "jah")
                    {
                        elud = 3;
                    }
                }

            } while (mängijaMängib == "jah"); //tsükkel teeb järgmise ringi kui kasutaja vastab jah, kõige muu puhul katkeb
        }

        private static List<string> Nuga(List<string> seljaKott)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                seljaKott.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
            return seljaKott;
        }

        private static int Seen(Random juhuArv, int elud)
        {
            int seeneEffekt = juhuArv.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                if (seeneEffekt >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde "+seeneEffekt+" elu.");
                    return elud + seeneEffekt;
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid "+(-seeneEffekt)+" elu.");
                    return elud + seeneEffekt;
                }
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");
                return elud;
            }
        }

        private static int Nõid(Random juhuArv, int elud)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                return elud;
            }
            else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                return elud + 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE "+vastus);
                return elud-1;
            }
        }

        private static int KratiM6istatus(Random juhuArv, int elud)
        {
            int seeJuhuArv = juhuArv.Next(1, 10); //suvaline täisarv vahemikus 1-10

            Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
            Console.WriteLine("Arva:"); //oota kasutajalt sisestust
            int kasutajaArv = int.Parse(Console.ReadLine());

            if (seeJuhuArv == kasutajaArv) // kontrolli sisestust tingimuslauses
            {
                Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                return elud;
            }
            else
            {
                Console.WriteLine("HJEHJEHJEH - õige vastus oli" + seeJuhuArv + "!!!! sa kaotasid!"); //kui on vale
                return elud -= 1;
            }
        }
    }
}
