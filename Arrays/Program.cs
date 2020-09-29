using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tek Boyutlu dizi Tanımlama 1.Yontem
            string[] arrays = new string[4];
            arrays[0] = "Pars";
            arrays[1] = "Güneş";
            arrays[2] = "Cemre";

            //Tek Boyutlu dizi Tanımlama 2.Yontem
            string[] digerTanım = new string[] {"Pars","Gunes","Cemre" };
         
            foreach (var arrayss in arrays)
            {
                Console.WriteLine(arrayss);
            }
            //Cok Boyutlu dizi Tanımlama 
            string[,] regions = new string[2, 2]
            {
                {"Yalova","istanbul"},
                { "Kayseri","Ankara"}
            };
            for(int i=0;i<=regions.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
