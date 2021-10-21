using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            int teller = 0;
            int getal;
            int maxgetal = 0;
           
            
            while (teller<3)
            {
                Console.WriteLine("Een getal aub...");
                getal=int.Parse(Console.ReadLine());

                if (getal>maxgetal)
                {
                    maxgetal = getal;
                }
                teller++;

            }
       
            
            Console.WriteLine($"maximum getal is ..:{maxgetal}");

            Console.ReadLine();
        }
    }
}
