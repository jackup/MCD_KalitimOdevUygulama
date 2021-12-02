using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
            //B1.ID = 1;// set edilemez olduğu için yapılamaz!
            B1.marka = "Lenovo";
            B1.model = "Z50";
            B1.islemci = "i5";
            B1.AlisFiyat = 1000;
            B1.SatisFiyat = 1500;
            B1.KampanyaFiyat = 1000;
            B1.Barkod = "1234567890";//=>
            SanalDatabase.YeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();
            B2.marka = "HP";
            B2.model = "Pavilion DV-6";
            B2.islemci = "i7";
            B2.AlisFiyat = 2000;
            B2.SatisFiyat = 2500;
            B2.KampanyaFiyat = 2300;
            B2.Barkod = "1234667890";//=>
            SanalDatabase.YeniUrunEkle(B2);

            
        }
    }
}
