namespace _3_Ilmaprognoos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //meetoditega programm - Jõgeva - "Ilmaprognoos 2"
            //
            // * SISENDITE KÄSITLUS * 
            //
            //¤ Käsitle tekstisisendeid nii, et inimese nimi oleks kõik sõnad esisuurtäht, 
            //¤ kõik muud tekstisisendid standardiseeri kas suureks või väikeseks
            //¤ arvsisendid try-catchitakse ning catchi puhul seatakse tsükli tingimus nii, et tsükkel jätkuks ja küsimus küsitakse uuesti
            //
            // * PROGRAMMI TÖÖ *
            //
            //¤ programmis on tuplede või arrayde list kus hoitakse kolme andmet, string kasutajanimi, string pärisnimi, string parool
            //¤ programmi töö alguses ei oma list mitte ühtegi andmesisestust. kasutajale antakse valik kas sisse logida või registreerida
            //¤ kui registreerib, siis tehakse uus sisestus ka listi koos kolme andmega mis kasutajalt küsitakse. täisnimi (ees ja perekonnanimi), soovitud kasutajanimi ja parool
            //see on kui "andmebaas"
            //¤ NB! ees ja perekonnanimi küsitakse ühe sisestusega, programm ise peab ümbervormindama ta tavakujule (sisendite käsitlus)
            //¤ NB! parooli *EI TOHI* mingil kujul ringi töödelda.
            //¤ sisendi kättesaamiseks on oma meetod
            //¤ sisendi töötlemiseks on erinevad meetodid (arvsisestuse kontroll, esisuurtähe töötlus, ja parooli (ning soovi korral ka kasutajanime) puhul ei kasutata üldse)
            //¤ kui kasutaja on registreerinud siis kuvatakse endiselt sisselogimis või registreerimisvõimalus
            //¤ kui kasutaja logib sisse, esitatakse talle tervitus, tema ees ja perekonnanimega, 
            //¤ kusjuures perekonnanimi "andmebaasis" olevast kuvamise hetkeks eemaldatakse
            //¤ Programm siis küsib mitme päeva infot ta sisestada tahab. 
            //¤ Kui tehakse tühi sisestus, siis teavitatakse et on vaja vähemalt 1 päev sisestada ja küsitakse uuesti
            //¤ tsüklis küsitakse niimitu korda erinevate päevade kohta infot kui kasutaja ütles.
            //¤ programm omab ka loendit nädalapäevadest
            //¤ programm küsib milline nädalapäev vastab esimesena sisestatud andmele, kasutaja vastab ühe tähega ETKNRLP
            //¤ Kasutades eelnevalt tunnis tehtud näiteülesannet kus kuvame välja temperatuuri pulgana, 
            //¤ tee meetod, mis võtab sisse temperatuuri ning nädalapäeva nime ja tekitab vastava andmepulga, kuhu *SAMA REA LÕPPU* kirjutatakse temperatuur arvväärtusena ja nädalapäeva nimi
            //¤ Tsükkel kasutab esimest nädalapäeva ja kuvab meetodi abil kõikide sisestatud päevade info.
            //¤ peale kuvamist küsib kasutajalt kas ta soovib jätkata, ning kui soovib, siis algab programm uuesti andmete sisestusest, mitte sisselogimisest, 
            //¤ kui ei, kuvatakse uuesti sisselogimine
            //
            // 40% = 3
            // 65% = 4
            // 80% = 5
        }
    }
}
