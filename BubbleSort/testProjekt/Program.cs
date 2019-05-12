using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //index                    0  1  2  3  4
            int[] array = new int[5] { 5, 2, 4, 1, 3 }; //array mit werten
            int zwischenvariable; 

            //bubble sort (langsam)
            for (int aussen_i = 0; aussen_i < array.Length; aussen_i++) // sortiere das array
            {
                for (int innen_j = aussen_i + 1; innen_j < array.Length; innen_j++)
                {
                    if (array[aussen_i] > array[innen_j]) //aufsteigend sortieren 
                    {
                        zwischenvariable = array[aussen_i];
                        array[aussen_i] = array[innen_j];
                        array[innen_j] = zwischenvariable;
                    }
                    else { } //mache nix
                    zwischenvariable = 0;// leert die zwischenvariable
                }
            }
            //ausgabe des arrays
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.ReadKey(); // konsole offen halten


        }
    }
}
