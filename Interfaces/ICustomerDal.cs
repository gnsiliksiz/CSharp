using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Dal veri işlemlerini yaptıgımız anlamına gelıyor.Data Access Layer =DAL
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }

    class CustomerManager
    {
        //Interface ile veri tabanından bağımsız olarak DB CRUD işlemleri yapabiliriz.
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
