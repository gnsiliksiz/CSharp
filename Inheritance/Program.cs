using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer
                { FirsName="Güneş" ,
                  LastName="iliksiz"
                },
                new Student
                { 
                    FirsName="Cemre",
                    LastName="İliksiz" 
                },
                new Person
                { 
                    FirsName="Pars", 
                    LastName="İliksiz"
                } //interface tek basına anlam ifade etmez iken inheritance anlam ifade etmektedir.
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirsName);
            }

            Console.ReadLine();
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }
    class Person2
    {

    }
    //Inheritance ex
    //Bir nesne sadece bir kere inheritance alınabılır.Ama birden cok implemente edebılırsınız.
    class Customer:Person // ,Person2 Ata tek olur 
    {
        public String City { get; set; }
    }
    class Student : Person
    {

    }
}
