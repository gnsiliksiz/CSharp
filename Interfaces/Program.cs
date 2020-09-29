using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro
            //Interface new ile kullanılamaz bc tek basına anlam ıfade etmıyor.
            // IPerson person = new Customer(); Kullanımı dogrudur.
            //CustomerInterfaceCagır();
            //Yeni bir db eklemen gerektıgı zaman arayuz sayesınde kodda degısıklık yapmadan ılgılı alanlara ekleme yaparak sorun cozulmektedır.
            
            ICustomerDal[] customerDals = new ICustomerDal[] { 
                new SqlServerCustomerDal(),
                new OracleCustomerDal() 
            }; 
            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 3,
                FirstName = "Güneş",
                LastName = "İliksiz",
                Phone = "911"
            };
            Student student = new Student
            {
                Id = 4,
                FirstName = "Cemre",
                LastName = "İliksiz",
                Bolum = "Muhasebe"
            };
            personManager.Add(customer);
            personManager.Add(student);
            // personManager.Add(new Customer { Id=3,FirstName="Güneş",LastName="İliksiz",Phone="911"});
        }

        private static void CustomerInterfaceCagır()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
    }
    //interface degişken isimleride Interface I ile başlar. Degişkenin ilk harfide buyuk olur.
    //Soyut nesnedir.Tek başına hiç birşey anlam ifade etmezler.
    interface IPerson
    {
        //Amaç: Temel operasyon olusturup butun nesnelerı ondan ımplemente etmektır.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    //Somut Nesnedir
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //müşteriye ait spesifik özellik 
        public string Phone { get; set; }
    }
    class Student : IPerson
    {
        //implemente
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //öğrencıye ait spesifik özellik 
        public string Bolum { get; set; }
    }
    //Manager ifadesi genellikle business katmanı sınıfları için kullanılır.
    class PersonManager
    {

        public void Add(IPerson person)
        {

            Console.WriteLine(person.FirstName);
        }

        //Boyle bir kullanım yerine interface vercez

        //public void Add(Customer customer)
        //{

        //    Console.WriteLine(customer.FirstName);
        //}
        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.FirstName);
        //}
    }

}
