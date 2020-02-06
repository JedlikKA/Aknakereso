using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pálya = new char[10, 10];
            Feltölt(pálya);
            Kirajzoló(pálya);
            Console.ReadKey();
        }

        static void Kirajzoló(char[,] pálya)
        {


            for (int sor = 0; sor < pálya.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{pálya[sor, oszlop]}|");
                }
                Console.WriteLine();
            }
        }

        static void Feltölt(char[,] pálya)
        {
            int sor;
            int oszlop;
            for (sor = 0; sor < pálya.GetLength(0); sor++)
            {
                for (oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                {
                    pálya[sor, oszlop] = '_';
                }
            }
            Console.WriteLine("Adjon meg oszlop számot.");
            int oszlopszám = int.Parse(Console.ReadLine());
            Console.WriteLine("Adjon meg egy sor számot.");
            int sorszám = int.Parse(Console.ReadLine());
            if (oszlopszám < 10 && sorszám < 10)
            {
                do
                {
                    sor = sorszám;
                    oszlop = oszlopszám;
                } while (pálya[sor, oszlop] == 'X');
                pálya[sor, oszlop] = 'X';
            }
            else
            {
                Console.WriteLine("Túl haladt az értéken.");
            }
        }
    }
}
