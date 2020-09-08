using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0908
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };


            int gepValasz = vel.Next(0, 3);
            Console.WriteLine("Gép választása:{0}",lehetoseg[gepValasz]);

            int jatekosValasz;
            Console.WriteLine("Kő (0), Papír (1), Olló (2).");
            Console.Write("Válasz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}",lehetoseg[jatekosValasz]);
            for (int i = 0; i < lehetoseg.Length; i++)
            {
                if (lehetoseg[gepValasz] == "Kő" && lehetoseg[jatekosValasz] == "2")
                {
                    Console.WriteLine("Sajnos a gép nyert.");
                    if (lehetoseg[gepValasz] == "Kő" && lehetoseg[jatekosValasz] == "1")
                    {
                        Console.WriteLine("Ön nyert.");
                    }
                }
            }

            for (int i = 0; i <lehetoseg.Length; i++)
            {
                if (lehetoseg[gepValasz] == "Olló" && lehetoseg[jatekosValasz] == "0")
                {
                    Console.WriteLine("Ön nyert.");
                    if (lehetoseg[gepValasz] == "Olló" && lehetoseg[jatekosValasz] == "1")
                    {
                        Console.WriteLine("Sajnos a gép nyert.");
                    }
                }
            }
            for (int i = 0; i < lehetoseg.Length; i++)
            {
                    if (lehetoseg[gepValasz] == "Papír" && lehetoseg[jatekosValasz] == "0")
            {
                Console.WriteLine("Sajnos a gép nyert.");
                if (lehetoseg[gepValasz] == "Papír" && lehetoseg[jatekosValasz] == "2")
                {
                    Console.WriteLine("Ön nyert.");
                }
            }
            }
     
            Console.ReadKey();
        }
    }
}
