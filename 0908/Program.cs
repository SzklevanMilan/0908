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
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
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


        static void Main(string[] args)
        {
            bool tovabb = true;
            while (tovabb)
            {
                int gepValasz = GepValasztas();
                //Console.WriteLine("Gép választása:{0}",lehetoseg[gepValasz]);

                int jatekosValasz = JatekosValasztas();

                EredmenyKiiras(gepValasz, jatekosValasz);

               tovabb = AkarJatszani();
            }

            Console.ReadKey();
        }

       
    }
}
