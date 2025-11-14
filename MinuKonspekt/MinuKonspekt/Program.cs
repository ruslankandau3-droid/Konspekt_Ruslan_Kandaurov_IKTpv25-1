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

    //        //5
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

            //2. Loend:

            // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse 
            //            täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüüpi andmed seal loendis on.
            //            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on.Loendisse saab dünaamiliselt elemente juurde lisada
            //            ehk tema pikkus ei ole fikseeritud. Sarnaselt massiiviga saab temas hoida ka teisi loendeid.
            // Esimene tekitusviis:
            List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldis "List<>" näitab et tegu on loendiga. Listi noolsulgude <> vahel on loendis 
                                                      //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. Muutuja enda 
                                                      //nimeks on "arvuNimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja 
                                                      //täisarvuloendi sätestusega "List<int>()".

            // Teine tekitusviis:

            List<int> arvuNimekiri2 = new List<int>() { 1, 2, 3 }; //Teine loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi 
                                                                   //noolsulgude vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int"
                                                                   //mis tähistab täisarve. Muutuja enda nimeks on "arvuNimekiri2". Omistame selle muutujasse 
                                                                   //kaitstud sõna "new" abil uue täisarvuloendi, aga seekord, peale sätestust "List<int>()" saame 
                                                                   //instantsieerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid 
                                                                   //"1", "2" ja "3". Elemendid sisestatakse nimekirja loogeliste sulgude vahel. Enam ei ole tegu 
                                                                   //tühja nimekirjaga, vaid loendiga kus kolm elementi juba sees.
            // kolmas tekitusviis:
            List<int> arvuNimekiri3 = new List<int>(3); //Kolmas loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude 
                                                        //vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. 
                                                        //Muutuja enda nimeks on "arvuNimekiri3". Omistame sellesse muutujasse kaitstud sõna "new" abil uue 
                                                        //täisarvuloendi, aga tavaliste sulgude vahele paneme arvu "3". Sarnaselt massiiviga ütleb see, et
                                                        //loend on 3 elemendi suurune. Loend ise ja tema elemendid on tühjad, aga seal on 3 elementi. Arv "3" 
                                                        //on parameeter mida Listi konstruktor pikkuse määramiseks kasutab. Nimekiri säilitab oma omaduse muuta 
                                                        //pikkust elementide lisamise-eemaldamisega, aga vajadusel saab nii anda talle pikkuse.
            int aa = 9901;
            // -- Loendi sisemised meetodid:
            arvuNimekiri.Add(99); //Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisatakse on Add meetodi sulgude 
                                  //vahel. Elementi sasab lisada otse (antud juhul täisarv "99")
            arvuNimekiri.Add(aa); //või muutujana.
            int loendiPikkus = arvuNimekiri3.Count; // Loendi meetod "Count()" loeb mitu elementi järjendis on, meetod tagastab täisarvu mis vastub
                                                    //elementide kogusele.
            bool KasSeeArvOn = arvuNimekiri3.Contains(3) //Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel olevale 
                                                         //parameetrile. Meetod tagastab kas "true" või "false" on leitud või ei ole. Tegemist on 
                                                         //põhimõtteliselt foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi.
            arvuNimekiri3.Remove(4);  //Loendid meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal asukohal oleva elemendi. Sulgude vahel on parameetriks
                                      //eemaldatava elemendi sukohajärjekorranumber




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


            //Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserimmine moodulit "Console", punkti abil Ütlema, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega jutumärkidega. kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause löppeb lauselõpumärgiga ";".

            //int arv1 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekond on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse, ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele.
            //Lause löppeb lauselõpumärgiga ";".


            //Console.WriteLine("Tere. Sisesta esimene arv");
            //Adresserimmine moodulit "Console", punkti abil Ütlema, et kasutame funktsiooni WriteLine
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega jutumärkidega. kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
            //Lause löppeb lauselõpumärgiga ";".


            //int arv2 = int.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
            //Aga seekond on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse, ning paneme
            //ReadLine funktsiooni Parse() sulgude vahele.
            //Lause löppeb lauselõpumärgiga ";".

            //Console.WriteLine("Sisesta tehtemärk: / * + -");
            //Adresseerime moodulit "Console" koos "Writeline" funktsiooniga, et esitada kasutajale 
            //küsimuse "Sisesta tehtemärk: / * + -". Punkti abil saame moodulist console, funktsiooni
            //WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            //jutumärkidega. Lause löppeb lauselõpumärgiga ";".

            //string tehtetyyp = Console.ReadLine();
            //instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string"
            //Omistame õrdusmärgi abil, sellesse muutujasse kasutajalt sisend mille saame kasutade
            //"Console" moodulis oleva Readline() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

            //int tulemus = 0;
            //instantsieerime muutuja niega "tulemus", andmetüübiga int, ning omistame talle alguse 
            // väärtuse võrdusmärgi abil, milleks on 0.Lause löppeb lauselõpumärgiga ";".


            //if (tehtetyyp == "+")
            //teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on
            //võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul
            //nagu võrdusmärkdest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
            //ole koodiga mis midagi kindlalt veel ära teeb.
            //{
            //    tulemus = arv1 + arv2;
            //}
            //peale tingimust on koodiplokk {} sulgude vahel, is sialdab endas ühte kodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            //kus liidame kokku muutaja "arv1" ja muutuja "arv2" sise. //jutumärkidega. Lause löppeb lauselõpumärgiga ";".


            //else if (tehtetyyp == "-")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //saamal kujul magu võrdusmärkidest teisel pool oplev tekst "-" kui eelnev tingimus ei
            //täitund. Lause siil ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 - arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodirida. Selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            //tuemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            //jutumärkidega. Lause löppeb lauselõpumärgiga ";".
            //else if (tehtetyyp == "/")
            //teeme sekundaarse tingimuslause "else if", ning määrassme tema tingimuse ära sulgudeaga.
            //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnel tingimus ei
            //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 / arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil jagamistehte 
            //tulemuse, kus korrutame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva väärtuse
            //kordi. jutumärkidega. Lause löppeb lauselõpumärgiga ";".


            //else if (tehtetyyp == "*")
            // teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega .
            //Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
            //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = arv1 * arv2;
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus korrutame muutjas "arv2" oleva vääruse muutujas "arv1" oleva väärtuse
            //koodi.Lause löppeb lauselõpumärgiga ";".
            //else if (tehtetyyp == "*")
            //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel on võrduskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid 
            //samal kujul nagu bõrdusmärkidest teisel pool olev tekst "^" kui eelnev tingimus ei
            //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            //{
            //    tulemus = (int)Math.Pow(arv1, arv2);
            //}
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
            //"math" moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena
            //sisse muutujad "arv1" ja  "arv2". Esimine parameetr on astendatav, teine parameeter
            //on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja 
            //"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks.
            //Lause löppeb lauselõpumärgiga ";".
            //else
            //peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide 
            //muude tingimuslause osade miitetäitumisel. Siin eraldi tingimust välja ei kirjutada
            //ning sellest tulenevalt ei ole ka sulge. Järneb ainult koodiplokk
            //{
            //    Console.WriteLine("palun sisesta tehe, mida kalkulaator tuvastada oskab");
            //}
            //peale "else" on koodiplokk {} loogelistesulgude vahel, mis sisaldab endas ühte
            //koodirida. Sellses koodireas kasutame moodulist "Console" punkti abil funktsiooni
            //"writeLine" et õelda kasutajale "palun sisesta tehe, mida kalkulaator tuvastada oskab"
            //koodirida lõppeb lauselõpumärgiga ";".

            //Console.WriteLine(tulemus);
            //kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ";".

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            else if(ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahindlust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma <21 && ostusumma > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestatud on vigane arv");
            }


            //string kasutajaNimi = "";
            //do
            //{
            //    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
            //    kasutajaNimi = Console.ReadLine();
            //} while (kasutajaNimi != "user1");
            //if (kasutajaNimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruutu saada taahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

            //    char reaMujund = '█';
            //    string üksRida = "";
            //    int tsükliMuutuja = ruuduSuurus;


            //    do
            //    {
            //        üksRida = üksRida + "_" + reaMujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siion on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //}

            /* tingimulause osad */
            if (true) { } //kaitstud sõna if kutsub esile tingimualuse, mille tingimus on sulgude vahel, ning millele järgneb
                          //koodiplokk tingimuse täitumisel teostatava koodiga
            else if (true) { }  //kaitstud sõnad "else" ja "if" (else if) kutsuvad elsile sekundaarse tingimuslause, mille tingimus
                                //on saamamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if". Tingimuse täitumisel
                                //ja eelneva tingimuse mittetäitumisel, teostatakse koodiploki sees olev kood.
            else { } //kaitstud sõna "else" kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiploki sisu
                     //täidetakse kõikide teise "if" ja "else if" tingimuste läbikukkumisel.


            int option = 3; // -------
            switch (option) //*switch on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada.
                            //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub, siin sulgude vahel 
                            //ei ole tingimus ise, vaid  kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
                            //pärast lülitusvalikut tuleb koodiplokk.
            {
                case 1:     //koodiplokki sees on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse,
                            //kas muutujas "option" on vääristus 1, millele järgned koolon ":" väljendades tingimuse täitumisel tehtava
                            //kooditegevuse algust
                    break;  //kui tegevus on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingiustikust kaitstud
                            //sõnaga "break". Peale breaki on läuselõpumärk ";".
                case 2:     //Juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt.
                    break;
                case 3:
                    Console.WriteLine(option);  //tehav kooditegevus.
                    break;
                default:    //Default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;  //Ka default lõppeb sõnaga break.
            }


            /* sõne tööristad ja nuud tekstiga seotut */
            string alfa = "a\nb";         // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
            string beta = $"a {alfa} b";  // $  -> lubab kasutada muutujaid loogeliste sulgudega otse teksti sees. on variant
                                          //       formateeritud stringist.




            /* Loogilised tehted */

            // $$ -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) juhul kui
            //             mõlemal pool "$$" märki olevad tingimused on täidetud. kui üks neist ei ole, siis annab negatiivse castuse (false).
            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
            //             vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
            // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse interteetimiseks. Tulemus, mis midu tagastaks (true),
            //             hüümargi abil tagastab (false), ja vastupidi - tulemus mis midu tagastaks (false), hüümargi abil tagastab (true)

            /* Võrdlusoperaarorid */

            // == -> "on võrdne". Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //       objektiga. ei ole sama nagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ile võrdne". Võrgusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //       Ta võib olla ükskõik mis muul kujul, aga mitte võrreldaava objektiga samal kujul. Võrdlusoperaator on kombinatsioon
            //       "on võrdne operaatorist, ja loogilisest "not".
            // >  -> "on suurem kui". märgist vasakul pool olev objekt peaks  olema suurem, kui paremal pool olev objekt.
            // <  -> "on väiksem kui". Märgist vasakul pool olev objekt  peaks olema väiksem, kui paremal pool olev objekt.
            // >= -> "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne kui suurem kui parempoolne objekt.
            //       Võrdusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            // <= -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parepoolne objekt.
            //       Võrdlusoperaator on kombinatsiion "on võrdne" ja "on väikem kui" operaatoritest.


            /* omistusoperatoorid ja kiirtehted */

            int thing = 1; // =  -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nine.
            thing += 1;    // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                           //       asendab tehte "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;    // -= -> Võrdusmärk mille ees on miinus, automaatselt lauhtab muutujast maha võrdusmärgi teisel pool oleva arvu. 
                           //       asendab tehet "thing = thing - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "=". thing *= 2;
            thing *= 2;    // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                           //       oleva arvu kordi.asendab tehet "thing = thing * 2".on kombinatsioon matemaatilisest tehtest "*" ja omistamisest""
            thing /= 2;    // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehet "thing = thing / 2".
                           //       on kombinatsioon matemaatilisest tehtest "/" ja omistamisest "=".
            thing++;       //++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe.
            thing--;        //-- -> on spetsiifiliselt ühe maha lahutamiseks kiirtehe.

            /* Tsüklid */
            // 1. do while 
            int dew = 0;
            do // "do" on kaitsud sõma, mis alustab do-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi
            {
                dew++;
            } while (dew != 5); //niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse ellnev koodi uuesti.

            // 2. while  
            int i = 1;        //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel 
            while (int < 5)   //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist 
                              //tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel, 
                              //siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                              // antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel 
                              //katkeb.

            {
                //koodiplokk kus midagi tehakse 
                i++;  // ning seejärel muudetakse tsüklimuutja  "i" olekut. antud juhul liidetakse  1 juurde kiirtehtega "++".




            }

            // 4. foreach
             int[] arvuloend = { 3, 67, 420, 69, 42 }; //massiiv mida foreach kasutab või töötleb mingil kujul
            foreach (var arvInLoend in arvuloend)      //kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse 
                                                       //ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev 
                                                       //kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend" 
                                                       //muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtasvat
                                                       //tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub, ehk tsükli töö käib 
                                                       //iga üksiku elemendi kohta andmekogumis individuaalselt. Tsüklilfei ole vaja tsüklimuutujat, kuna 
                                                       //sisse ehitatud vaikimisi elemendi järjestuse jälgimine. Niipalju kui andmeid loendis on, ongi see 
                                                       //mis ütleb ära, mitu korda tsükkel käivitatakse.
                                                       //peale sulge, on koodiplokk {} kus tehakse mingi tegevus
                                                       //Antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi,hetkel tsükis olev element.
            { 
                Console.WriteLine(arvInLoend);
            }
             

        }


    }
    }

   
}
