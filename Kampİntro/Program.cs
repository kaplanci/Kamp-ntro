using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //do not repeat yourself
            string kategoriEtiketi="Kategori";
            int ogrenciSayisi = 32000;
            double faziOrani = 1.45;
            bool sistemeGirişYapıldı = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                    Console.WriteLine("değimeiş");
            }

            if (sistemeGirişYapıldı==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
            }
            else
            {
                    Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
