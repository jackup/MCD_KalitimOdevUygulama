using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_KalitimOdevUygulama
{
    public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void YeniUrunEkle(Base data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Barkod))
            {
                db.Add(data);
                EkranaYazdir();
            }
        }


        private static void EkranaYazdir()
        {
            foreach (Bilgisayar item in SanalDatabase.db)
            {
                Console.WriteLine("Marka: " + item.marka + " model: " + item.model + " işlemci: " + item.islemci + " alış fiyatı: " + item.AlisFiyat + " satış fiyatı: " + item.SatisFiyat + " kampanya fiyatı: " + item.KampanyaFiyat + " barkod: " + item.Barkod);
            }
        }

        public static bool DbBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;

            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    Base bc = (Base)db[i];
                    if (bc.Barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                    
                }
            }
            
            return kontrolIslemi;
        }
    }
}
