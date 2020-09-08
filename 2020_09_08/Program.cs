using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
            int gepValaszt = vel.Next(0, 3);
            Console.WriteLine("Gép választása: {0}",lehetoseg[gepValaszt]);
            int jatekosValasz;
            Console.WriteLine("Kő (0), Papír(1), Olló(2)");
            Console.WriteLine("Válassz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékoks választása : {0}",lehetoseg[jatekosValasz]);
            Console.ReadKey();
        }
    }
}
