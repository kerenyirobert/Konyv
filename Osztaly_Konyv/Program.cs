using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 100; i++)
            {
                Konyv konyv = new Konyv("1212", "121212", "dfsdasasdas", 1988, "magyar", false, 'i');
                Console.WriteLine(i);
            }
            int szorzo = (int)Math.Ceiling((double)130 / 11);*/
            Konyv k = new Konyv();
            bool? helyes = false;
            do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);




            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
