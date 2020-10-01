using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();
            Product product = new Product { ID = 1, Name = "Laptop" };

            Product product2 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            Console.ReadLine();
        }
    }
    //newlendiği zaman çalışacak kod bloğudur.
    class CustomerManager
    {
        //ctor tab tab = constructur kısa tanımlama
        //sınıfın parametrelere ihtiyacı oldugunda kullanırız.
        //private vir field alt çizgi ile başlatılır bu best practice
        private int _count=15;
        //method halinde alt çizgi kullanılmaz.
        public CustomerManager(int count)
        {
            _count = count;
        }
        //Overloading yapılabilir.
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed : {0} ",_count);
            Console.WriteLine("Listed : "+ _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
        
    }

    
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;

        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();

            Console.WriteLine("Added");
        }
    }

    //Bütün classlarda kullanacagımız ortak ozellıklerı tanımladıgımız kısım: Base Class
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message");

        }
    }
    //inheritance Base class 
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {


    }

}
