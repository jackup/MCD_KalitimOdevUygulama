using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    public class Base
    {
        public static int count = 1; //ilk oluştuğu zaman 1 değerini oto. alsın

        private int id;
        public int ID 
        { 
            get
            {
                return id;
            }
            private set
            {
                //bir sayaç içerisindeki değerden faydalanmak istiyoruz. id = count;
                //count ++;
                //nedeni basit, set alanı private olarak işaretlendi..

            }
        }

        public Base()
        {
            id = count;
            count++;
        }

        private string barkod;
        public string Barkod
        {
            get
            {
                return barkod;
            }
            set
            {
                bool kontrolIslemi = SanalDatabase.DbBarkodKontrol(value);
                if (!kontrolIslemi)//değer sanal db içinde yok
                {
                    barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal Database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        }

        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }
    }
}
