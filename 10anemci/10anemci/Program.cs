using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10anemci
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("kolko uchenici");
           int n = int.Parse(Console.ReadLine());
           
            //int uchenici;
            //Console.WriteLine("kolko uchenici");
            //    uchenici = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {          
 Console.WriteLine("na kolko godini e uchenika");
            int godini = int.Parse(Console.ReadLine());
             Console.WriteLine("koi mesec e roden uchenika");
                  int mesec = int.Parse(Console.ReadLine());
 

                if (godini == 14 )
                {
                    Console.WriteLine("Ti si v 8 klas");
                    if (mesec <= 9 || mesec >= 1)
                    {
                        Console.WriteLine("Ti si v 8 klas");
                    }

                }
                else
                {
                    if (godini >= 13)
                    {
                        Console.WriteLine("ne si za tuka");

                    }
                }
               
                if (godini == 15)
                {
                    Console.WriteLine("Ti si v 9 klas");
                    if (mesec >= 9 || mesec <= 9)
                    {
                        Console.WriteLine("Ti si v 9 klas");
                    }
                }
                else
                {
                    if (godini >= 13)
                    {
                        Console.WriteLine("ne si za tuka");
                    }
                }
                if (godini == 16)
                {
                    Console.WriteLine("ti si v 10 klas");
                    if (mesec <= 9 || mesec >= 1)
                    {
                        Console.WriteLine("ti si v 10 klas");
                    }
                }
                else
                {
                    if (godini >= 13)
                    {
                        Console.WriteLine("ne si za tuka");
                    }
                }
                if (godini == 17)
                {
                    Console.WriteLine("ti si v 11 klas");
                    if (mesec >= 9 || mesec <= 9)
                    {
                        Console.WriteLine("ti si v 11 klas");
                    }
                }
                else
                {
                    if (godini >= 13)
                    {
                        Console.WriteLine("ne si za tuka");
                    }
                }
                if (godini == 18 )
                {
                    Console.WriteLine("ti si v 12 klas");
                    if (mesec <= 9 || mesec >= 1)
                    {
                        Console.WriteLine("ti si v 12 klas");
                    }
                }
                else
                {
                    if (godini >= 13 || mesec <= 9)
                    {
                        Console.WriteLine("ne si za tuka");
                    }
                }

            }
        }
    }
}
