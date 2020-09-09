﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0908
{
    class Program
    {
        static int EmberNyer(int gep, int ember)
        {
            if (ember == 0 && gep == 1 //Gép nyer
                     ||
                     (ember == 1 && gep == 2)
                     ||
                     (ember == 2 && gep == 0))
            {
                return 1;
            }
            else if (gep == ember) //Döntetlen
            {
                return 0;
            }
            else //Játékos nyer
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };


            int gepValasz = vel.Next(0, 3);
            //Console.WriteLine("Gép választása:{0}",lehetoseg[gepValasz]);

            int jatekosValasz;
            Console.WriteLine("Kő (0), Papír (1), Olló (2).");
            Console.Write("Válasz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}",lehetoseg[jatekosValasz]);
            switch (EmberNyer(gepValasz,jatekosValasz))
            {
                case 0:
                    Console.WriteLine("Döntetlen.");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyert.");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
