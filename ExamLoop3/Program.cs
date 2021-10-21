using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLoop3
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"20 : {i+1}: Een getal please..:");
                getal = int.Parse(Console.ReadLine());

                if (getal%2==0)
                {
                    Console.WriteLine($"Mod2=0  {getal} is Even.\n");
                }
                else
                {
                    Console.WriteLine($"{getal} is Oneven.\n");
                }
 
            }
            Console.ReadLine();
        }
    }
}
