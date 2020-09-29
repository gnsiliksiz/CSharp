using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    //
    class Program
    {
        //Loglama hepsı ıcın ayrı ıslemler gerektırdıgı ıcın ınterface kullanıldı.Cougunda aynı bır kacı farklı olasaydı vırtual yapardık.
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger(); //interface nesnesini olusturduk.
            customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        //interface property tanımla
     
        public ILogger Logger { get; set; }

        public void Add()
        {
            //DatabaseLogger logger = new DatabaseLogger();-Kullanımı dogru degıl.Herzaman tek bişeye bagımlı kalınıyo.
            //ILogger logger = new DatabaseLogger();
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
    //Bir classın mutlaka bir base olmalı .
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged !");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("log to File");
        }
    }
    //Yeni eklendi.Sadece implemente edip kullandık.
    class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to sms");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
