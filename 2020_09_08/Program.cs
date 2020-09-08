using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2020_09_08
{
    class Program
    {
            static int dont=0;
            static int nyert=0;
            static int veszt=0;





        static void jatek()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            string kezdes = "KŐ PAPÍR OLLÓ JÁTÉK KÖVETKEZIK.";
            Console.WriteLine("{0,80}", kezdes);
            string folytatas = "Press Any key to continue";
            Console.WriteLine();
            Console.Write("{0,77}", folytatas);
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            string jatekosValasz;

            Console.Write("\n \n Válassz a 3 lehetőség közül: Kő, Papír Olló:      ");
            jatekosValasz = Console.ReadLine();
            Console.Clear();
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
            int gepValaszt = vel.Next(0, 3);
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("\n");
            if (gepValaszt == 0 && jatekosValasz.ToLower() == "kő")
            {
                Console.WriteLine("\n");

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\t \t \t \t \t \t Döntetlen.");
                dont++;
            }
            if (gepValaszt == 0 && jatekosValasz.ToLower() == "papír")
            {

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Te nyertél!");
                nyert++;
            }
            if (gepValaszt == 0 && jatekosValasz.ToLower() == "olló")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Vesztettél!");
                veszt++;
            }
            if (gepValaszt == 1 && jatekosValasz.ToLower() == "kő")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Vesztettél!");
                veszt++;
            }
            if (gepValaszt == 1 && jatekosValasz.ToLower() == "papír")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Döntetlen.");
                dont++;
            }
            if (gepValaszt == 1 && jatekosValasz.ToLower() == "olló")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Te nyertél!");
                nyert++;
            }
            if (gepValaszt == 2 && jatekosValasz.ToLower() == "kő")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Te nyertél!");
                nyert++;
            }
            if (gepValaszt == 2 && jatekosValasz.ToLower() == "papír")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Vesztettél!");
                veszt++;
            }
            if (gepValaszt == 2 && jatekosValasz.ToLower() == "olló")
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("\n Gép választása: {0}", lehetoseg[gepValaszt]);
                Console.WriteLine("\n \n \n \t \t \t \t \t \t Döntetlen.");
                dont++;
            }
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            

        }
        static void Main(string[] args)
        {




            
                string ujjatek = "igen";
                string ujkezdet;
            


            while (ujjatek.ToLower()== "igen")
            {
                jatek();
                StreamWriter sw = new StreamWriter("statisztika.txt") ;
                sw.Write("Nyert körök száma: ");
                sw.WriteLine(nyert);
                sw.Write("\n Döntetlen körök száma: ");
                sw.WriteLine(dont);
                sw.Write("\n Vesztett körök száma: ");
                sw.WriteLine(veszt);
                sw.Close();
                ujkezdet = "Play Again? (igen/nem)";
                Console.Write("\n {0,70} \n \n \t \t \t \t \t \t \t", ujkezdet);
                ujjatek = Console.ReadLine();
           
            }

            
            if (ujjatek.ToLower() == "nem")
            {
                Console.Clear();
                string vege = "\n Kilépéshez nyomj entert.";
                Console.Write("\n \t {0,110}",vege);
            }





            Console.ReadKey();
        }
    }
}
