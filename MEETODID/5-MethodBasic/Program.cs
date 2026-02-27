namespace _5_MethodBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> koodid = new List<int>() { 4321,1166,1182,9001,0067,1620 };
            List<double> kontod = new List<double>() {0, -23.6d, 144d, 10512.11d,-402, 6.70d };
            //Pangaautomaat
            Console.WriteLine("Tere tulemast Hansapanka, palun sisesta oma pin-kood, ");
            int pinKood = KoodiSisestus(koodid);
            TervitaKasutajat(pinKood);
            EsitaKontojääk(pinKood,koodid,kontod);
            Console.WriteLine("Mida sa teha soovid? palun vali arvuga:");
            string[] valikud = new string[] { "Võta raha välja","Pane raha sisse" };
            for (int i = 0; i < valikud.Length; i++)
            {
                Console.WriteLine((i+1)+". "+valikud[i]);
            }
            int kasutajaValik = Valik(new List<int> { 1,2});
            if (kasutajaValik-1 == 0)
            {
                kontod = KontojäägiHaldur(koodid, kontod, pinKood);
            }
            else if (kasutajaValik-1 == 1)
            {
                kontod = KontojäägiHaldur(koodid, kontod, pinKood, false);
            }           

            EsitaKontojääk(pinKood, koodid, kontod);

        }

        private static List<double> KontojäägiHaldur(List<int> koodid, List<double> kontod, int pinKood, bool? isPositive = true)
        {
            if (isPositive == true)
            {
                Console.WriteLine("Kui palju raha soovid välja võtta?: ");
            }
            else
            {
                Console.WriteLine("Kui palju raha soovid sisse panna?: ");
            }
            
            double väljaSumma = double.Parse(Console.ReadLine());
            while (väljaSumma < 0)
            {

                Console.WriteLine("Negatiivset arvu sisestada ei saa, proovi uuesti: ");
                väljaSumma = double.Parse(Console.ReadLine());
            }
            if (isPositive == true)
            {
                kontod = Väljavõte(pinKood, koodid, kontod, väljaSumma);
            }
            else
            {
                kontod = Väljavõte(pinKood, koodid, kontod, -väljaSumma);
            }
            return kontod;
        }

        public static List<double> Väljavõte(int filter, List<int> accounts, List<double> balances, double withdrawAmount)
        {
            int elementLocation = accounts.IndexOf(filter);
            balances[elementLocation] -= withdrawAmount;
            return balances;
        }

        public static void EsitaKontojääk(int filter, List<int> accounts, List<double> balances)
        {
            int elementLocation = accounts.IndexOf(filter);
            Console.WriteLine("Teie kontojääk on: "+balances.ElementAt(elementLocation));
        }

        public static void TervitaKasutajat(int userPin)
        {
            Console.WriteLine("Tere, "+userPin+" oled sisenenud Hansapanga automaati");
        }

        private static int Valik(List<int> valikud)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta oma valik:");
                valik = int.Parse(Console.ReadLine());
            } while (!valikud.Contains(valik));
            return valik;
        }

        private static int KoodiSisestus(List<int> andmebaasiInfo)
        {
            int pinKood;
            do
            {
                Console.WriteLine("Sisesta kood:");
                pinKood = int.Parse(Console.ReadLine());
            } while (!andmebaasiInfo.Contains(pinKood));
            return pinKood;
        }
    }
}
