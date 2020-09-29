using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıf ismi ilk harfi buyuk olur ornegını olusturdugunuzda Camel Case olur.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            //--Customer sınıfı ilgili işlemler
            //1.yontem
            Customer customer = new Customer();
            customer.Id = 2;
            customer.FirstName = "Güneş";
            customer.LastName = "İliksiz";
            customer.Phone = "911 911 911 ";
            customer.Adress = "Top Selvi Cad Ada Sitesi No:13 ";
            //2.yontem

            Customer customer2 = new Customer
            {
                // set işlemi yani bişey atıyorsunuz
                Id = 2, Adress = "istanbul", FirstName = "Güneş", LastName="İliksiz",Phone="911"
            };
                                //get işlemi 
            Console.WriteLine(customer.Phone);
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Uploaded!");
        }

    }
}
