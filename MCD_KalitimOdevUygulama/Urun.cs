using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    public class Urun : Base
    {
        public string marka { get; set; } // Belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin.
        public string model { get; set; }
        private decimal alisFiyat;
        public decimal AlisFiyat
        {
            get
            {
                return alisFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı sıfırdan büyük olmalıdır.");
                }
                else
                {
                    alisFiyat = value;
                }
            }
        }
        private decimal satisFiyat;
        public decimal SatisFiyat
        {
            get
            {
                return satisFiyat;
            }
            set
            {
                if (value < alisFiyat)
                {
                    Console.WriteLine("Ürünün satış fiyatı alış fiyatından küçük olamaz.");
                }
                else
                {
                    satisFiyat = value;
                }
            }
        }

        private decimal kampanyaFiyat;
        public decimal KampanyaFiyat
        {
            get
            {
                return kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı sıfırdan küçük olamaz.");
                }
                else
                {
                    kampanyaFiyat = value;
                }
            }
        }
    }
}
