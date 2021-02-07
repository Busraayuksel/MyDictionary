using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(123, "BÜŞRA");
            Console.WriteLine(ogrenciler.Length1);

            ogrenciler.Add(345, "MELİSA");
            Console.WriteLine(ogrenciler.Length2);

            foreach (var number in ogrenciler.Numbers)
            {
                Console.WriteLine(number);
            }

            foreach (var name in ogrenciler.Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
