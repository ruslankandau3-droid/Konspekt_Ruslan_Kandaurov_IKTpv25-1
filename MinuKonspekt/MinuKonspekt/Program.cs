namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //        ////Console.WriteLine("Hello, World!");

    //        //Muutujad, Matematilised tehtad, If, ELSE IF ja ELSE

    //        //1. tuvasta sinu võrdluses tühja stringiga, string, andmetüüp
    //        Console.WriteLine("Tere kasutaja, mis on sinu nimi");
    //        string nimi = Console.ReadLine();

    //        if (nimi == "")
    //        {
    //            Console.WriteLine("Kasutaja ei sisestanud oma nime");
    //        }
    //        else if (nimi != "")
    //        {
    //            Console.WriteLine("Tere " + nimi + "!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Kasutaja ei sisestanud oma nime");
    //        }

    //        //2. tuvasta arvuvahelik, võrdluses piirvaäärtustega, int/double/float andmetüüp 
    //        Console.WriteLine(nimi + ", mis on sinu vanus?: ");
    //        int kasutajavanus = int.Parse(Console.ReadLine());

    //        //2.1 mitu tingimust pesastatud if-ide abil
    //        //if (kasutajavanus > 0)
    //        //{
    //        //   if (kasutajavanus < 18)
    //        //   {
    //        //       Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled monsterist ilma 😒")
    //        //   }
    //        //   else
    //        //   {
    //        //       Console.WriteLine("Saad osta Monsterit, YIPPIE 😀😀");
    //        //   }
    //        //}

    //        //2.2 mitu tingimust 
    //        if (kasutajavanus > 0 && kasutajavanus < 18)
    //        {
    //            Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled monsterist ilma 😒");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Saad osta Monsterit, YIPPIE 😀😀");
    //        }
    //        Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
    //        double pikkus = double.Parse(Console.ReadLine());
    //        if (pikkus < 1.00d)
    //        {
    //            Console.WriteLine("oled juntsu");
    //        }
    //        else if (pikkus < 1.25d && pikkus > 1.00d)
    //        {
    //            Console.WriteLine("Oled peaaegu allameetrimees");
    //        }
    //        else if (pikkus < 1.5d && pikkus > 1.25d)
    //        {
    //            Console.WriteLine("Oioi, päkapikk enam ei olegi " + nimi + " !");
    //        }
    //        else if (pikkus < 1.75d && pikkus > 1.5d)
    //        {
    //            Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
    //        }
    //        else if (pikkus < 2.00d && pikkus > 1.75d)
    //        {
    //            Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
    //        }
    //        else if (pikkus > 2.00d)
    //        {
    //            Console.WriteLine("Täielik tulnukas, luidas pilved välja näevad?");
    //        }
    //        else
    //        {
    //            Console.WriteLine("pikkus ei tunta");
    //        }

    //        //4 parool, if ja string andmetüüp
    //        Console.WriteLine("Programmi edasiseks tööks sisesra palun parool:");
    //        string password = Console.ReadLine();

    //        if (password == "simsalabim")
    //        {
    //            Console.WriteLine("parool on õige, aarete laegas avaneb");
    //        }
    //        else if (password == "saatana" || password == "tuborosho")
    //        {
    //            Console.WriteLine("Parool on sobimatu, palun mingi muu");
    //        }
    //        else
    //        {
    //            Console.WriteLine("parool on õige, aarete laegas avaneb");
    //        }

    //        //
    //        Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
    //        string favouriteColour = Console.ReadLine();
    //        if (favouriteColour == "punane")
    //        {
    //            Console.BackgroundColor = ConsoleColor.Red;
    //        }
    //        if (favouriteColour == "oranz")
    //        {
    //            Console.WriteLine("kahjuks oranzi ei ole");
    //        }
    //        if (favouriteColour == "kollane")
    //        {
    //            Console.BackgroundColor = ConsoleColor.Yellow;
    //        }
    //        if (favouriteColour == "rohaline")
    //        {
    //            Console.BackgroundColor = ConsoleColor.Green;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Värvi ei tunne");
    //        }
    //        Console.WriteLine("Värv muudetud");
    //        //

    //        //# Калькулятор грузчика - Напишите программу, которая:
    //        //# - Спрашивает пользователя, хочет ли он измерить картонную коробку или бочку для масла.
    //        Console.WriteLine("sa tahad mõõta pappkasti või õlitünni?");
    //        string sisend = Console.ReadLine();
    ////# - в зависимости от ввода пользователя, спрашивает:

    ////# - - для бочки:
    //    if (sisend = "õlitünn")
    //        {
    //              //# - - - знает ли пользователь радиус дна (r) или диаметр дна (d):
    //            Console.WriteLine("Kas sa tead tünni raadiust R või läbimõttu D");
    //            string rvõid = Console.ReadLine();
    //            Console.WriteLine("Mis on selle raadius/lääbimõõt? meetrites");
    //            double kasutajamõõt = double.Parse(Console.ReadLine());

    //            //# - - - высота бочки
    //            Console.WriteLine("Kui kõrge on su tünni? meetrites");
    //            double kõrgus = double.Parse(Console.ReadLine());

    //            //# - - - толщина крышки (толщина крышки вычитается из высоты бочки, так как крышка занимает некоторое место внутри бочки)
    //            Console.WriteLine("Kui paks on su tünni? meetrites");
    //            double kaanepaksus = double.Parse(Console.ReadLine());
    //            //# - - - Вычисляет объем бочки, боковую площадь бочки, общую площадь бочки
    //            double Sp = 0;
    //            if (rvõid == "R")
    //            {
    //                Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
    //            }
    //            else if (rvõid == "D")
    //            {
    //                kasutajamõõt = kasutajamõõt / 2;
    //                Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
    //            }
    //            double V = 0;
    //            kõrgus = kõrgus - kaanepaksus;
    //            V = Sp * kõrgus;
    //            //
    //            kõrgus += kaanepaksus;
    //            double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;
    //            //
    //            double S = Sp + Sk;
    //            Console.WriteLine($"Sinu tüün mahutab {V}\nTünni küljepindala on {Sk}\nTünni kogupindala on {S}");

    //        }
    //        //# - - для коробки:
    //        if (sisend = "pappkasti") 
    //        {
    //            //# - - - Является ли коробка кубом или прямоугольным параллелепипедом

    //            //# - - - - если это куб, спрашивает пользователя только о длине стороны

    //            //# - - - - если это прямоугольный параллелепипед, спрашивает пользователя:

    //            //# - - - - длину самой длинной стороны, 

    //            //# - - - - длину самой короткой стороны и

    //            //# - - - - - высота коробки

    //            //# - - вычисляет общую площадь коробки, объем и самую длинную сквозную линию (d)

                Console.WriteLine("hapukapsas");
                // "Console"    -> on moodul C# mida me adresserime, Console aitav teha tegevusi käsureal
                // .            -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
                //              mooduli "Console" seest.
                // "WriteLine"  -> Funktsioon mida me parasjagu kasutame.
                // ()           -> sulupaar ms omab funktsiooni tööks vajalikku infot
                // []           -> tähistab massiivne
                // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespace või funktsiooni
                // "hapukapsas" -> parameeter mis antakse funktsioonile WriteLine töölemiseks kaasa.
                //              -> Taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood
                //              asub, see on vajalik ka kompilaatorile samal eesmärgil.
                // ;            -> köik koodilaused lõppevad komakooloniga, mis tähistavad lause lõppu 
                // //           -> tähistab üherealist kommentaari
                // /**/         -> tähistab mitmerealist koomentari või kommentaariregiooni

                int muutuja = 3;
                // int          -> on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist
                //                 tüüpi andmed selle muutuja sees on.
                // "muutuja"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
                //                 sõnaga, ja mille abil saab neid addresseerida koodi sees.
                // =            -> üksik võrandusmärk omistab muutuja sisse vastava väärtuse mis asub
                //                 teiselpool võrdusmärki.
                // 3            -> muutujale omistatav väärtus.

                /* Võimalikud andmetüübid mida vaja võib minna: */
                int a = 1; // int on taäisarv
                decimal b = 2.1M; // decimal on kümnendsüsteemis olev komakohaga arv
                float c = 3.9f; // float on 32-bitine komakohag arv
                double d 5.6d; // double on 64-bitine komakohaga arv
                char c1 = 'a'; // üksainus täht või tähemärk mis tähistatakse ülekomaga ''
                string s = "tekst"; // tähtedest koosnev sõna või tekst, tähistatakse jutumäridega ""
                var x = "abc"; // var on ebamäärase andmetüübiga kohalik muutuja 
                var y = 123;   // ta võib omada endas teisi andmetüüpe 
                const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on ready-only

                //põhilised maatemaatilised tehted
                int liitme = 1 + 1; //liitimine, kaks arvu liidetakse kokku
                int lahutamine = 1 - 1; // lahutamine, kus esimesest arvust lahutatakse maha teine 
                double korrutamine = 1 * 2; // korrutamine, kus teine arv korrutatakse esimese arvu kordi
                double jagamine = 1 / 2; // jagamine. esimene arv jagatakse teise arvuga.
                double astendamine = Math.Pow(2.2); // astendamine, esimene arv astendatakse teisega
                double juurime = Math.Sqrt(2); // ruutjuur, parameetrina juuritav arv

                // muutuja nimed
                int arv = 0; // sobib
                string sõne = "abc"; // sobib
                                     // string string = "abc"; kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnevad sõnad:
            // abstract, as, base, bool, break, byte, case,
            // catch, char, cheked, class, count, continue, decimal
            // default, delagate, do, double, else, enum, event,
            // explicit, extern, false, finally, fixed, float, for
            // foreach, goto, if, implicit, in, int, interface, internal
            // is , lock, long, namespace, new, null, object, operator, 
            // out, override, params, private, protected, public, readonly,
            // ref retur, sbyte, sealed, short, sizeof, stackalloc, 
            // static, string, struct, switch, this, throw, try, typeof, 
            // uint, ulong, uncheked, unsafe, ushort, using, virtual,
            // void, volatile, while.


            Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserimmine moodulit "Console", punkti abil Ütlema, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega jutumärkidega. kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause löppeb lauselõpumärgiga ";".

            int arv1 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekond on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse, ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele.
            //Lause löppeb lauselõpumärgiga ";".


            Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserimmine moodulit "Console", punkti abil Ütlema, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega jutumärkidega. kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause löppeb lauselõpumärgiga ";".


            int arv2 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekond on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse, ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele.
            //Lause löppeb lauselõpumärgiga ";".

            Console.WriteLine("Sisesta tehtemärk: / * + -");
            //Adresseerime moodulit "Console" koos "Writeline" funktsiooniga, et esitada kasutajale 
            //küsimuse "Sisesta tehtemärk: / * + -". Punkti abil saame moodulist console, funktsiooni
            //WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            //jutumärkidega. Lause löppeb lauselõpumärgiga ";".

            string tehtetyyp = Console.ReadLine();
            //instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string"
            //Omistame õrdusmärgi abil, sellesse muutujasse kasutajalt sisend mille saame kasutade
            //"Console" moodulis oleva Readline() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

            int tulemus = 0;
            //instantsieerime muutuja niega "tulemus", andmetüübiga int, ning omistame talle alguse 
            // väärtuse võrdusmärgi abil, milleks on 0.Lause löppeb lauselõpumärgiga ";".


            if (tehtetyyp == "+")
                 //teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on
                 //võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
                 //nagu võrdusmärkdest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
                 //ole koodiga mis midagi kindlalt veel ära teeb.
            {
                tulemus = arv1 + arv2;
            }
            //peale tingimust on koodiplokk {} sulgude vahel, is sialdab endas ühte kodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            //kus liidame kokku muutaja "arv1" ja muutuja "arv2" sise. //jutumärkidega. Lause löppeb lauselõpumärgiga ";".


            else if (tehtetyyp == "-")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
                //saamal kujul magu võrdusmärkidest teisel pool oplev tekst "-" kui eelnev tingimus ei
                //täitund. Lause siil ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 - arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodirida. Selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            //tuemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            //jutumärkidega. Lause löppeb lauselõpumärgiga ";".
            else if (tehtetyyp == "/")
                //teeme sekundaarse tingimuslause "else if", ning määrassme tema tingimuse ära sulgudeaga.
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnel tingimus ei
                //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 / arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil jagamistehte 
            //tulemuse, kus korrutame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva väärtuse
            //kordi. jutumärkidega. Lause löppeb lauselõpumärgiga ";".


            else if (tehtetyyp == "*")
                // teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega .
                //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
                //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 * arv2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus korrutame muutjas "arv2" oleva vääruse muutujas "arv1" oleva väärtuse
            //koodi.Lause löppeb lauselõpumärgiga ";".
            else if (tehtetyyp == "*")
                //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                //Sulgude vahel on võrduskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid 
                //samal kujul nagu bõrdusmärkidest teisel pool olev tekst "^" kui eelnev tingimus ei
                //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
            //"math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena
            //sisse muutujad "arv1" ja  "arv2". Esimine parameetr on astendatav, teine parameeter
            //on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja 
            //"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks.
            //Lause löppeb lauselõpumärgiga ";".
            else
                //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide 
                //muude tingimuslause osade miitetäitumisel. Siin eraldi tingimust välja ei kirjutada
                //ning sellest tulenevalt ei ole ka sulge. Järneb ainult koodiplokk
            {
                Console.WriteLine("palun sisesta tehe, mida kalkulaator tuvastada oskab");
            }
            //peale "else" on koodiplokk {} loogelistesulgude vahel, mis sisaldab endas ühte
            //koodirida. Sellses koodireas kasutame moodulist "Console" punkti abil funktsiooni
            //"writeLine" et õelda kasutajale "palun sisesta tehe, mida kalkulaator tuvastada oskab"
            //koodirida lõppeb lauselõpumärgiga ";".

            Console.WriteLine(tulemus);
            //kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ";".


        }


    }
    }

   
}
