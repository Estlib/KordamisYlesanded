namespace _6_MethodBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////on meetod mis kuvab kasutajale ühe sõnumi.
            //KuvaSõnum();
            ////on meetod, mis tahab teada, kui palav õues on : temperatuur
            //KuiPalavOn(100);
            ////on meetod, mis arvutab järjendi kõikide elementide keskmise, hoiab muutujas meeles
            ////ja kuvab eraldi real välja peaprogrammis, mitte meetodis, meetod ainult tagastab väärtuse
            //double scores = ArvutaKeskmine(new List<double> { 3.5, 7.7, 1.1, 5, 8, 9.2 });
            //Console.WriteLine("keskmine skoor on: "+scores);

            //õnneennustaja
            //vaja on:
            // - kasutajanime
            // - tema sünniaastat
            // - lemmikvääriskivi
            // - lemmiklooma liik
            Console.WriteLine("Tere õhtust, eksind rändaja, kas sa soovid oma tulevikku vaadata?\n Kui jah, siis kirjuta oma nimi");
            string eksinudNimi = Console.ReadLine();
            Console.WriteLine("Mis aastal oled siia ilma eksinud?");
            string eksinudAasta = Console.ReadLine();
            Console.WriteLine("Mis on sinu lemmikvääriskivi?");
            string eksinudVääriskivi = Console.ReadLine();
            Console.WriteLine("Mis on sinu lemmik loomaliik?");
            string eksinudLoom = Console.ReadLine();

            int nimeTähed = eksinudNimi.Length;
            int viimaneAastaArv = int.Parse(eksinudAasta.Substring(eksinudAasta.Length-1,1));
            RahaÕnn(nimeTähed,viimaneAastaArv);
            string iseloom = LapseÕnn(eksinudLoom);
            if (iseloom == "ei-tea")
            {
                Console.WriteLine("OI ÕUDUST, SELLIST ELAJAT EI TOHI VALLA LASTA!!! \n congrats oled incel");
            }
            else 
            {
                Console.WriteLine("Kallis "+eksinudNimi+", sinu laps, ma näen, saab olema "+iseloom+".");
            }
            KaitseÕnn(eksinudVääriskivi);
        }
        
        /// <summary>
        /// Kuvab kasutajale olenevalt tema lemmikkivist tema õnne.
        /// </summary>
        /// <param name="kivi">Kasutaja poolt kirjutatud vääriskivim</param>
        public static void KaitseÕnn(string kivi)
        {
            List<string> vargus = new List<string>() {"ahhaat", "graniit", "topaas" };
            List<string> vigastus = new List<string>() {"smaragd", "rubiin", "jaspis" };
            List<string> hullumus = new List<string>() {"tiigrisilm", "kvarts", "amazoniit" };
            if (vargus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - "+kivi+" - kaitseb sindd hästi varguste eest");
            }
            else if (vigastus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - "+kivi+" - kaitseb sind igasuguste vigastuste eest");
            }
            else if (hullumus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - "+kivi+" - hoiab sind mentaalselt tasakaalus");
            }
            else
            {
                Console.WriteLine("Puhas praht, viska minema.");
            }
        }

        /// <summary>
        /// Olenevalt kasutaja poolt sisestatud lemmiku loomaliigipõhjal, ennustab milline tema järgmine laps oma iseloomult on.
        /// </summary>
        /// <param name="loom">Kasutaja poolt sisestatud loomaliigi nimetus</param>
        /// <returns></returns>
        public static string LapseÕnn(string loom) 
        {
            if (loom == "jänes")
            {
                return "krapsakas";
            }
            else if(loom == "karu")
            {
                return "ablas";
            }
            else if(loom == "öökull")
            {
                return "teadlik";
            }
            else if(loom == "rebane")
            {
                return "kaval";
            }
            else if(loom == "kaelkirjak")
            {
                return "uudishimulik";
            }
            else if(loom == "sääsk")
            {
                return "tüütu ja pinisev";
            }
            else
            {
                return "ei-tea";
            }                
        }

        /// <summary>
        /// Olenevalt nimepikkuse ja aastaarvu keskmisest ennustab isiku varalist õnne.
        /// </summary>
        /// <param name="nimetähearv">Kasutaja poolt sisestatud nimes olevate tähtede arv</param>
        /// <param name="aastaarv">Kasutaja poolt sisestatud sünniaasta viimane arv</param>
        public static void RahaÕnn(int nimetähearv, int aastaarv)
        {
            int õnnekeskmine = (nimetähearv + aastaarv) / 2;
            // väiksem kui 0 suurem kui 10
            if(õnnekeskmine < 0 || õnnekeskmine > 10)
            {
                Console.WriteLine("OIoiOIoiOI sinu õnn on põhimõtteliselt olematu, tunnen su rahakotipõuale kaasa.");
            }
            else
            {
                switch (õnnekeskmine)
                {
                    case 1:
                        Console.WriteLine("Aiaa, su lauaarvuti RAM suri ära, nüüd pead oma kolm neeru maha müüma.");
                        break;
                    case 2:
                        Console.WriteLine("Kurat võttis su õnne endale, piinled töötukassas.");
                        break;
                    case 3:
                        Console.WriteLine("Täitsa pekkis, jätsid oma telefoni rongi.");
                        break;
                    case 4:
                        Console.WriteLine("Lõid varba ära ja astusid lego peale ka.");
                        break;
                    case 5:
                        Console.WriteLine("Rahakott on normaalselt ka edaspidigi natukese koormaga");
                        break;
                    case 6:
                        Console.WriteLine("võitsid niisama summi, +15 eur :D");
                        break;
                    case 7:
                        Console.WriteLine("Sulle naeratab rahaõnn haljastusvaldkonnas");
                        break;
                    case 8:
                        Console.WriteLine("Pärisid rikka soome onu varanduse");
                        break;
                    case 9:
                        Console.WriteLine("Leiad varsti elu armastuse ja rikkuse.");
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Arvutab meetodisse parameetrina kaasa antud nimekirjas olevate arvude keskmise
        /// </summary>
        /// <param name="andmed">Meetodi töö jaoks vajaminev sisend</param>
        /// <returns>komakohaga arvu andmete keskmise arvutusega</returns>
        public static double ArvutaKeskmine(List<double> andmed)
        {
            double keskmine = 0;

            for(int i = 0;i < andmed.Count; i++)
            {
                keskmine += andmed[i];
            }
            keskmine /= andmed.Count;
            KuiPalavOn(keskmine);
            return keskmine;
        }

        public static void KuiPalavOn(double temp)
        {
            if (temp <= 0 && temp >= -50 ) 
            {
                Console.WriteLine("KÜLM BLYAT");
            }
            else if (temp > 0 && temp <= 15)
            {
                Console.WriteLine("jahe");
            }
            else if (temp > 15 && temp <= 25)
            {
                Console.WriteLine("Päris soe");
            }
            else if (temp > 25 && temp <= 40)
            {
                Console.WriteLine("PALAV BLYAT");
            }
            else
            {
                Console.WriteLine("UR DED");
            }
        }

        public static void KuvaSõnum()
        {
            Console.WriteLine("TeRe");
        }



    }
}
