using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //convention naming
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! :" + urun.Adı);
        }

        public void Ekle2(string urunAdi ,string açıklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! :" + urunAdi);
        }
    }
}
