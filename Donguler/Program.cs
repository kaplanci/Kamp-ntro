using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılımcı yetiştirme kampı";
            string kurs2 = "Temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c++";

            //array dizlerde kullanırız

            string[] kurslar = new string[]
            {
                "Yazılımcı yetiştirme kampı","Temel kurs","java","python","c++"
            };


            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);
                
            }
            Console.WriteLine("sayfa sonu");


            
        }
    }
}
