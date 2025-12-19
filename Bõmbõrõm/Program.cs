using System;

namespace EsimeneProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* näiteprogramm */
            ///* ctrl + k + c/u */
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{

            //    Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles"); // print(kontojääk + " puulehte on alles")
            //Console.WriteLine(" palun sisesta oma hästi tehtud töö boonus: ");
            //int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("palun sisesta oma hästi tehtud töö boonus: "))
            //kontojääk = kontojääk + boonus; // same python
            //Console.WriteLine("sinu lõppväljavõte on: " + kontojääk + " puulehte");


            /*
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18öeldakse kasutajale "tõmba metsa, kuradi alakas"
             * kui ta on vanem kui 18, pakutakse mojitot
             * 
             */

            int kasutajavanus = 0;
            Console.WriteLine("kui vana sa oled?");
            kasutajavanus = int.parse(console.readline());
            if (kasutajavanus >= 18)
            {
                console.writeline("tere tulemast, palun teie mojito 🍸");
            }
            else
            {
                console.writeline("tõmba metsa, kuradi alakas");
            }

            ///*     -= A N D M E T Ü Ü B I D =-       */
            //string tekst = "mingisugune inimloetav tekstike"; //TEKST
            //char täht = 'A';
            //int arv = 1; //täisarv
            //float komakohagaarv = 1.5f; //32bit
            //double suuremkomakohagaarv = 1.5d; //64bit
            //decimal kümmendsüsteemiskomakohagaarv = 1.5M;
            //var x = 123;
            //var y = "ABC";
            //bool jahvõiei = false; //kas true või false.

            ///**/
            ////string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud
        }
    }
}
