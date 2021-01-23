using System;
using System.Collections.Generic;
using System.Globalization;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{
            //    "engin","murat","kerem","ali"
            //};

            List<string> isimler2 = new List<string>
            {
                "Murat","kerem","Halil","mako"
            };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("maze");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            



        }
    }
}
