using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classlar birer inheritance özelligidir.
            //interface gibi abstract class new yapamıyoruz
            //Database database = new Database();
            //Oracle ve Sql server implemente edebiliriz.
            Database databaseOracle = new Oracle();
            databaseOracle.Add();
            databaseOracle.Delete();

            Database databasesql = new SqlServer();
            databasesql.Add();
            databasesql.Delete();
            Console.ReadLine();
        }
    }
    //interface ve virtual methodların birleşimi gibi dusunebiliriz.
    abstract class Database
    {
        //Tamamlanmıs method
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        //tamamlanmamış method
        //içi dolu olmayan virtual methodtur.
        public abstract void Delete();

    }
    class SqlServer : Database
    {
        //Delete her ortamda ayrı işlem olacagı için hepsının ayrı ayrı ımpleente edılmesı gerekır.
        public override void Delete()
        {
            Console.WriteLine("Deleted by  Sql Server ");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by  Oracle");
        }
    }

}
