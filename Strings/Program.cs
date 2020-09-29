using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro();

            //String Methods
            string sentence = " my name is Güneş Cemre";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            var result3 = sentence.IndexOf("name");
            var result4 = sentence.LastIndexOf(" ");



            Console.ReadLine();
        }

        private static void intro()
        {
            //Her string birer char array'dir.
            string city = "ankara";
            string city2 = "istanbul";
            //Bellekte fazladan bir degişken tuttuk.
            string result = city + " " + city2;
            //String.Format kullanımı
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

        }
    }
}
