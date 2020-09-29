using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not  10");
            }
            // if ile yazılan blokların Switch Case ile yazılması.
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }
            //Single line if
            //Koşul işlemini  Eger number eşit 10 is bunu degilse bunu yaz.
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10 or 20");
            //Sart Dogru       Sart Yanlış    
            Console.ReadLine();
            //Control K ardından Control D ile kod dugun şekilde yerleşir.
        }
    }
}
