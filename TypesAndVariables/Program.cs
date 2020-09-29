using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types  değer tipi integer
            // referans tipi 
            int numberInt = 13;
            long  numberLong = 15;
            short numberShort = 16;
            byte  numberByte = 255;
            bool  condition = false;
            char  character = 'G';
            string CharacterArray = "Güneş";
            Double ondalikliSayi = 15.5;
            
            Decimal ondalikliDeci = 1.5m;
            var numbert = 10;


            Console.WriteLine("Number is {0}", numberInt);
            Console.ReadLine();
        


        }
    }

    //inam deger atamadıgımız zaman ardısık olarak number atar.
    enum Days
    {
        Monday = 1, Sunday = 4, Wednesday
    }
}
