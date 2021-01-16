using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engindemirog";
            kurs1.IzlenmeOrani = 67;


            Kurs kurs2= new Kurs();

            kurs2.KursAdi = "c";
            kurs2.Egitmen = "maze";
            kurs2.IzlenmeOrani = 7;


            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "python";
            kurs3.Egitmen = "kerem";
            kurs3.IzlenmeOrani = 88;


            Kurs[] kurslar = new Kurs[]
            {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }







            //nsole.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
        }
    }

    class Kurs

    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public  int  IzlenmeOrani { get; set; }
    }
}
