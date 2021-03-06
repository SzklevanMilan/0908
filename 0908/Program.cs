﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace _0908
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;
        static int[] adat = new int[3];
        static int GepValasztas()
        {
            Random vel = new Random();
            return vel.Next(0, 3);
        }


        static int JatekosValasztas()
        {
            Console.WriteLine("Kő (0), Papír (1), Olló (2).");
            Console.Write("Válasz: ");
            return Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Játékos választása: {0}",lehetoseg[jatekosValasz]);
        }


        static void EredmenyKiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}",lehetoseg[gep],lehetoseg[ember]);

            switch (EmberNyer(gep, ember))
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

        }


        static int EmberNyer(int gep, int ember)
        {
            if (ember == 0 && gep == 1 //Gép nyer
                     ||
                     (ember == 1 && gep == 2)
                     ||
                     (ember == 2 && gep == 0))
            {
                gepNyer++;
                return 1;
            }
            else if (gep == ember) //Döntetlen
            {
                return 0;
            }
            else //Játékos nyer
            {
                jatekosNyer++;
                return 2;
            }
        }

         static bool AkarJatszani()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.Write("Tovább? [i/n]:");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------");

            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

         static void StatisztikaKiiras()
        {
            Console.WriteLine("\t Menetek száma: {0} \t" +
                "Játékos győzelmek száma: {1} \t" +
                "Gép győzelmének száma: {2}", menet, jatekosNyer, gepNyer);
        }
  
        static void statisztikaFajlbol()
        {
            StreamReader stat = new StreamReader("statisztika.txt");
            while(!stat.EndOfStream)
            {
                string[] sor = stat.ReadLine().Split(';');
                adat[0] = int.Parse(sor[0]);
                adat[1] = int.Parse(sor[1]);
                adat[2] = int.Parse(sor[2]);
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(sor[i]);
                }
                    Console.WriteLine(" {0} {1} {2}", adat[0], adat[1], adat[2]);


                //Console.WriteLine("{0} {1} {2}",adat[0],adat[1],adat[2]);
            }
            stat.Close();
            Console.WriteLine("---------------------------->Statisztika vége<----------------------------");
        }
        static void StatisztikaFajlba()
        {
            string adat = menet.ToString() + ";" +
                jatekosNyer.ToString() + ";" +
                gepNyer.ToString();
            //FileStream ki = new FileStream("statisztika.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter("statisztika.txt",true);
            sw.WriteLine(adat);
            sw.Close();
        }

        static void Main(string[] args)
        {
            statisztikaFajlbol();

            bool tovabb = true;
            while (tovabb)
            {
                menet++;
                int gepValasz = GepValasztas();
                //Console.WriteLine("Gép választása:{0}",lehetoseg[gepValasz]);

                int jatekosValasz = JatekosValasztas();

                EredmenyKiiras(gepValasz, jatekosValasz);

               tovabb = AkarJatszani();
            }
            StatisztikaKiiras();
            StatisztikaFajlba();
            Console.ReadKey();
        }
    }
}
