using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(2, 6);
            var number1 = 1;
            var number2 = 2;
            var result3 = Add3(ref number1, number2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        // Dont Repeat yourself so method use
        static void Add()
        {
            Console.WriteLine("added!");

        }
        //Default value her zaman sonda olmalıdır.
        //deger tipler degişkenin değeri neyse odur.Atamalarda degerın kendısı atanır.
        static int Add2(int number1, int number2 = 10)
        {
            var result = number1 + number2;
            return result;

        }
        // Referans tip parametrenin basına ref gelmelıdır.
        static int Add3(ref int number1, int number2 = 10)
        {
            number1 = 5;
            var result = number1 + number2;
            return result;

        }
        //Ref keyword alternatifi out.Mantık olarak aynıdır.
        //Ref kullnırken defult parametre degerı set etmek gerekır.Ama out kullnırken ihtiyacınız yok
        //out verdiginiz methdd iinde parametre degerı set edılmıs olmalıdır.
        static int Add4(out int number1, int number2 = 10)
        {
            number1 = 5;
            var result = number1 + number2;
            return result;

        }
        //Over loading method 
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2;
        }
        //Degısken paramerelı methodla ıcın parametre dızısı olusturabılırız.
        static int ParamsArray(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
