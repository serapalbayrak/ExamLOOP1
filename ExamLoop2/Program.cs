using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLoop2
{
    class Program
    {
        static void Main(string[] args)
        {

            string naam;
            int puntEngels, puntProg, puntNetwerk;
            double gemiddel;
            double som;
            int teller=0;
            do
            {
                som = 0;
                gemiddel = 0;
                teller++;

                Console.WriteLine("Student name .....2");
                naam=Console.ReadLine();

                Console.WriteLine("Engels Punt .....");
                puntEngels = int.Parse(Console.ReadLine());

                Console.WriteLine("Programatie Punt .....");
                puntProg = int.Parse(Console.ReadLine());

                Console.WriteLine("Netwerken Punt .....");
                puntNetwerk = int.Parse(Console.ReadLine());

                som = puntNetwerk + puntProg + puntEngels;
                gemiddel = som / 3;


                Console.WriteLine($"Student {naam} heb totaal {som} punten en {gemiddel} gemiddelde punten;;\n\n");
                

            } while (teller<5);




            Console.ReadLine();
        }
    }
}
