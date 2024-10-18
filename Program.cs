using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat1
{
    internal class Program
    {
        static void vegeredmeny() 
        { 
        Console.WriteLine("Add meg a vásárlás végösszegét");
        int osszeg = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Van törzsvásárlói kártyája?");
        var van = Console.ReadLine();
        double vegosszeg5 = osszeg - osszeg * 0.05;
        double vegosszeg10 = osszeg - osszeg * 0.1;

            if (osszeg < 10000) 
            { 
                Console.WriteLine("A fizetendő összeg: " + osszeg);
            }
            else if (osszeg >= 10000 && osszeg < 50000 && van == "nincs")
            {
                Console.WriteLine("A fizetendő összeg: " + osszeg); 
                if (osszeg >= 10000  && osszeg < 50000 && van == "van")
                {
                    Console.WriteLine("A fizetendő összeg: " + vegosszeg5);
                }
            }
            else if (osszeg >= 50000 && van == "nincs")
            {
                Console.WriteLine("A fizetendő összeg: " + vegosszeg5);
                if (osszeg >= 50000 && van == "van")
                {
                    Console.WriteLine("A fizetendő összeg: " + vegosszeg10);
                }
            }

        }
        static void Main(string[] args)
        {
            vegeredmeny();
        }
    }
}
