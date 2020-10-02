using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new BirinciMevzuat());
        }
    }
    class CustomerManager
    {
        IMevzuat _mevzuat;
        public CustomerManager (IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }
        public void Add()
        {
            //Bir method içinde birden falza sorumluluk yapmak dogru degıldır.Solıd prensıblerınden Single Responsibility çiğnenmş olur ani
            //her method,class,library sadece tek sorumluluk tasımalıdır.
            //if(true)
            //{
            //    //işlemler
            //}
            //else
            //{
            //    //işlmelr
            //}
            _mevzuat.islemYap();  
        }
    }
    interface IMevzuat
    {
        void islemYap();
    }
    class BirinciMevzuat : IMevzuat
    {
        public void islemYap()
        {
            Console.WriteLine("müsteri 1. mevzuata gore  eklendi");
        }
    }
    class IkinciMevzuat : IMevzuat
    {
        public void islemYap()
        {
            Console.WriteLine("müsteri 2. mevzuata gore  eklendi");
        }
    }
    //yeni bir operasyon ekledıgımızde yenı kod ekleyebılmelı ama mevzcut kodları degıstırmıyo olmalıyız .Bu şekilde open closed prensıbıne uygun kod gelıstırırız.

    class UcuncuMevzuat:IMevzuat
    {
        public void islemYap ()
        {
            Console.WriteLine("yeni kural eklemdi")
        }
    }
}
