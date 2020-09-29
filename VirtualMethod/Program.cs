using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
            Console.ReadLine();
        }
    }
    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer :DataBase
    {
        //sql server crud işlemleri farklı oldugu için sanal methodlar ile override yapılır.
        //Sql Server Base Database 
        //Virtual olan override edilebilmektedir.
        public override void Add()
        {
            //override ile bir önceki temel kod ezilir.
            Console.WriteLine("Added by Sql Code");
            //base atası demek miras alınan 
            base.Add();
        }
        public override void Delete()
        {
            base.Delete();
        }
    }
    class MySqlServer:DataBase
    {
        public override void Add()
        {
            base.Add();
        }
        public override void Delete()
        {
            base.Delete();
        }
    }
}
