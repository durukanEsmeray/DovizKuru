using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DovizKuru.Classes;
using DovizKuru.Model;

namespace DovizKuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleDbProjeEntities db=new ConsoleDbProjeEntities();
            GetCurrency getCurrency = new GetCurrency();
            Sale sale = new Sale();

            void CurrencyList()
            {
                Console.WriteLine();
                Console.WriteLine("Döviz Listesi");
                Console.WriteLine();
                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName);
                }
            }

            void CurrentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Güncel Kur Listesi");
                Console.WriteLine();
                var values = db.TblCurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("Döviz: " + item.TblCurrency.CurrencyName + " Alış : " + item.CureencyBuying + " Satış : " + item.CureencySelling);
                }
            }

            void GetCurrencyClass()
            {
                
                getCurrency.SaveCurrencyDolar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencyPound();
            }
            


            Console.WriteLine("Döviz İşlemlerine Hoş Geldiniz");
            Console.WriteLine();
            Console.WriteLine("Mevcut Kullanıcı : Admin" + "    Tarih:" + DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçin");
            Console.WriteLine();
            Console.WriteLine("1-Döviz Listesi");
            Console.WriteLine("2-Güncel Kurçar");
            Console.WriteLine("3-Satış Yap");
            Console.WriteLine("4-Müşterilere Yapılan Satış Hareketleri");
            Console.WriteLine("5-Müşterilerden Alınan Satış Hareketleri");
            Console.WriteLine("6-Kurları Veri Tabanına Kaydet");
            Console.WriteLine("7-Yardım");
            Console.WriteLine("8-Çıkış Yap");
            Console.WriteLine();
            Console.Write("İşlem Numarası :");

            string choose;
            choose = Console.ReadLine();

            if(choose=="1")
            {
                CurrencyList();
            }
            if (choose == "2")
            {
                CurrentCurrency();
            }
            if (choose == "3")
            {
                Console.WriteLine();
                Console.Write("Müşteri Adı :");
                string customerName = Console.ReadLine();
                Console.Write("Müşteri Soyadı :");
                string customerSurname = Console.ReadLine();
                Console.Write("Döviz Kodu :");
                int currencyCode=int.Parse(Console.ReadLine());
                Console.Write("İşem Türü :");
                string operationType = Console.ReadLine();
                Console.Write("Güncel Kur Değeri :");
                decimal currentValue= decimal.Parse(Console.ReadLine());
                Console.Write("Alınacak Tutar :");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.Write("Toplam Ücret :");
                decimal totalAmount = decimal.Parse(Console.ReadLine());

                sale.MakeSale(customerName, customerSurname, currencyCode, operationType, currentValue, amount, totalAmount);
            }

            if (choose == "4")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationAlis();
            }

            if (choose == "5")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationSatis();
            }


            if (choose == "6")
            {
                GetCurrencyClass();
                Console.WriteLine("Dövizler başarılı bir şekilde veri tabanına kaydedildi");
            }

            if (choose == "7")
            {               
                Console.WriteLine("Tüm sorularınız için mail@gmail.com adresinden bize ulaşabilirsiniz");
            }

            if (choose == "8")
            {
                Environment.Exit(1);
            }
            Console.ReadLine();
        }
    }
}
