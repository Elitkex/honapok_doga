using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adj meg egy szamot 1-12 kozott: ");

            int honap = int.Parse(Console.ReadLine());
            if (honap < 1 || honap > 12)
            {
                Console.WriteLine("nem megfelelo ertek");
            }

            Console.ReadKey();
        }
        public string Evszak(int honap)
        {
            while(true)
            {
                if (honap == 3 || honap == 4 || honap == 5)
                {
                    Console.WriteLine("honap: tavasz");
                }
                if (honap == 6 || honap == 7 || honap == 8)
                {
                    Console.WriteLine("honap: nyár");
                }
                if (honap == 9 || honap == 10 || honap == 11)
                {
                    Console.WriteLine("honap: ősz");
                }
                if (honap == 1 || honap == 2 || honap == 12)
                {
                    Console.WriteLine("honap: tél");
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }
    }
}
