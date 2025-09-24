namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Muutujad, Matematilised tehtad, If, ELSE IF ja ELSE

            //1. tuvasta sinu võrdluses tühja stringiga, string, andmetüüp
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            //2. tuvasta arvuvahelik, võrdluses piirvaäärtustega, int/double/float andmetüüp 
            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{
            //   if (kasutajavanus < 18)
            //   {
            //       Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled monsterist ilma 😒")
            //   }
            //   else
            //   {
            //       Console.WriteLine("Saad osta Monsterit, YIPPIE 😀😀");
            //   }
            //}

            //2.2 mitu tingimust 
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled monsterist ilma 😒");
            }
            else
            {
                Console.WriteLine("Saad osta Monsterit, YIPPIE 😀😀");
            }
            Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (pikkus < 1.5d && pikkus > 1.25d)
            {
                Console.WriteLine("Oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("Täielik tulnukas, luidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkus ei tunta");
            }

            //4 parool, if ja string andmetüüp
            Console.WriteLine("Programmi edasiseks tööks sisesra palun parool:");
            string password = Console.ReadLine();

            if (password == "simsalabim")
            {
                Console.WriteLine("parool on õige, aarete laegas avaneb");
            }
            else if (password == "saatana" || password == "tuborosho")
            {
                Console.WriteLine("Parool on sobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("parool on õige, aarete laegas avaneb");
            }

            //
            Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            string favouriteColour = Console.ReadLine();
            if (favouriteColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (favouriteColour == "oranz")
            {
                Console.WriteLine("kahjuks oranzi ei ole");
            }
            if (favouriteColour == "kollane")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (favouriteColour == "rohaline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("Värvi ei tunne");
            }
            Console.WriteLine("Värv muudetud")
        }
    }
}
