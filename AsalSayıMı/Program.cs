using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayıMı
{
    class Program
    {
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i=2;i<number-1;i++)
            {
                if(number%i==0)
                {
                    result = false;
                    //Ex 1000 basamaklı bır sayı oldugunda 1000%2 ilk false oldugu zaman programı durdurmak performans acısından onemlıdır.
                    //break yerine i number esıtlersek performans sorununu çozerız.
                    i = number;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            if(IsPrimeNumber(5))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
