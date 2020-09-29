using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {

        //Private tanımlı oldugu blok için geçerlidir.

       // private int id;

        //Tanımlı oludugu blok ve miras aldıgı yerde gecerlıdır.-Protected
        protected int ID { get; set; }
        public void Save()
        {
            Customer customer = new Customer();
            //customer.id; kullanılabılır.
        }

    }
    class Student:Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
           // customer.id;
           // ID kullanılabılır protected property tanımlandı.
        }
    }
    //Bir class için  default değer internaldır.
    //Internal class: Bağlı olduğu proje içerisinde referans ihtiyacı olmadan kullanılabilir.
    //Üst seviyeli bir class private,protected olamaz.
    //iç içe class tanımlamalarında private olarak kullanabılırız.
    public class Course
    {
        public string name { get; set; }
        private class NestedClass
        {

        }
    }
}
