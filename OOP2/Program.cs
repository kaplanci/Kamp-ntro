using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 45;
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "engo";
            musteri1.Soyad = "demo";
            musteri1.TcNo = "21468448";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 78;
            musteri2.MusteriNo = "5432";
            musteri2.SirketAdi = "Kodlamacaa";
            musteri2.VergiNo = "7878";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




        }
    }
}
