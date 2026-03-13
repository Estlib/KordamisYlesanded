namespace Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 -  Tee Player klass, koos viie andmeväljaga
            //      Player klassis on üks konstruktor, kus kasutatakse kõiki andmeid
            //      Andmeväljad on: Lives, Health, Location (struct kus on X ja Y), Backpack, Money
            //      Vaikeväärtused on Lives (3) ja Health (100)
            // 1.1- Tee Player klassi üks klassile kuuluv meetod - CheckHealth()
            //      Checkhealth kontrollib, kui player objekti Health andmeväli on 0 või vähem,
            //      lahutatakse Lives väljalt 1 maha, ja Health seatakse tagasi arvule 100.
            // 1.2- Tee Player klassi üks enum - public enum Weapon. Sinna pane 3 relva: PlankWithNail, RustyShiv, Knife

            // 2 -  Tee World klass, koos nelja andmeväljaga
            //      World klassis on üks konstruktor, kus kasutatakse kõiki andmeid
            //      andmeväljad on: int[,] Map, string WorldName, Point2D Start, Point2D Goal
            // 2.1- Tee World klassile 6 tühja void meetodit, Event_KratiMõistatus(), Event_Nõid(), Event_Seen(), Event_Nuga(), Event_Mätas(), Event_Pood()
            // 2.2| Tee World klassile GenerateMap_1010()
            //      GenerateMap_1010() kasutab randomit, ja tagastab kahemõõtmelise Massiivi koos juhuarvudega vahemikus 1 kuni 6, arvud kaasaarvatud.
            // 2.3- Tee World klassile meetod RandomEncounter()
            //      RandomEncounter() viib kasutaja tundmatusse olukorda, valides olemasolevaist random vahemiku abil. Meetod ise ei tagasta
            //      midagi, vaid kutsub esile teisi, eelloetletud "Event_XYZ" meetodeid.

            // 3 -  Paneme mängu loopi oma objektidega nüüd uuesti kokku - toimub refaktoreerimine monoliitprogrammilt, objektorienteeritud struktuurile

            Random rng = new Random();
            Player player = new Player(3, 100, new Player.Point2D(0, 0), new List<string>(), 0);
            string playAgain = "jah";

            do 
            {
                Console.Clear();
                Console.WriteLine("STATISTIKA ======================================");
                player.DisplayStats();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                EventSystem.NextEncounter(player, rng);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
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
            while (player.Lives > 0 || playAgain == "yes" );
            //do //tsükkel
            //{
            //    do
            //    {
            
            //        Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata");
            //        Console.ReadLine();
            //    } while (elud > 0);

            //    if (elud <= 0)
            //    {
            //        Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0 ==--"); //kas kasutaja soovib uuesti mängida
            //        mängijaMängib = Console.ReadLine(); //saa vastus
            //        if (mängijaMängib == "jah")
            //        {
            //            elud = 3;
            //        }
            //    }

            //} while (mängijaMängib == "jah"); //tsükkel teeb järgmise ringi kui kasutaja vastab jah, kõige muu puhul katkeb
        }
    }
}
