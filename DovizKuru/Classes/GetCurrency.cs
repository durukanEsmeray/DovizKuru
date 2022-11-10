using DovizKuru.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DovizKuru.Classes
{
    public class GetCurrency
    {
        ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();


        public void SaveCurrencyDolar()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlis = dolarAlis.Replace(".", ",");
            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatis = dolarSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 1;
            t.CureencyBuying = decimal.Parse(dolarAlis);
            t.CureencySelling = decimal.Parse(dolarSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }


        public void SaveCurrencyEuro()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlis = euroAlis.Replace(".", ",");
            string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            euroSatis = euroSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 2;
            t.CureencyBuying = decimal.Parse(euroAlis);
            t.CureencySelling = decimal.Parse(euroSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }


        public void SaveCurrencyPound()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string poundAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            poundAlis = poundAlis.Replace(".", ",");
            string poundSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            poundSatis = poundSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyID = 4;
            t.CureencyBuying = decimal.Parse(poundAlis);
            t.CureencySelling = decimal.Parse(poundSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
    }
}
