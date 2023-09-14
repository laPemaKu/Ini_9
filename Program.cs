using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno_ponavljanje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = {4, 22, 0, 8, 104, 90, 1 };
            for (int i = 0; i < niz.Length - 1; i++)
            {
                for (int j = 0; j < niz.Length - 1; j++) 
                {
                    if (niz[j] > niz[j + 1])
                    {
                        int number = niz[j];
                        niz[j] = niz[j+1];
                        niz[j + 1] = number;
                    }
                }
            }
            foreach(int i in niz)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
