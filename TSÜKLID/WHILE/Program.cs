namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While ülesanded*/

            // 1. "niikaua kuni ohtu pole"
            // tee muutuja "CO2tase" mille sees on komakohaga float 0.0f
            // kirjuta while tsükkel
            // -> while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "CO2tase" on arv väiksem kui 40.000
            // tsükli tegevusena kuva sõnum "mis on co2 tase?"
            // pane muutujasse "CO2tase" info kasutajalt
            // tee tingimuslauseline kontroll, mis kontrollib, kui kasutaja sisestus on väiksem kui 40.000,
            // siis kuva sõnum kasutajale teavitades, et otsest ohtu ei ole
            // peale tsüklit kuva sõnum "evakueeri hoonest, süsihappegaasi tase on liiga kõrgel"
            /* 
             * NB programm peab niikaua käima kuni kasutaja sisestus on suurem või võrdne kui 40.000
             */

            // 2. "vibumees"
            // tee muutuja "mehike" mille sees on täisarv 0
            // tee muutuja "vastus" mille sees on tühi tekst
            // kirjuta while tsükkel
            // -> while tsükli tingimuseks kirjuta kontroll:
            //      mis kontrollib kas muutujas "mehike" on täisarv 5 või vähem
            //      või
            //      muutujas "vastus" on tekst "jah"
            // tsükli tegevuseks küsi kasutajalt "kas tahad mehikesse noole lasta?"
            // tsükli tegevuseks pane muutujasse "vastus" väärtus kasutajalt käsurea pealt 
            // tsükli tegevuseks kontrolli tingimuslausega kas vastus oli "jah"
            // tsükli tegevuseks Kui tingimuslause vastus oli jah, siis:
            // kuva kasutajale tekst "mitu noolt lased?"
            // lisa muutujasse "mehike" kasutajalt saadud täisarv
            // peale tsüklit kontrolli kas muutujas "mehike" olev arv on väiksem kui 5
            // kui on väiksem kui 5 siis kuva sõnum "mehike elab :D"
            // kõikidel muudel juhtudel kuva sõnum "tapsid mehikese ära :c"
        }
    }
}
