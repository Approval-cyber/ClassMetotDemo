using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClassMetotDemo
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Aşağıda ki Bilgilere Sahip Kullanıcıya Eklendi!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| İd : "+musteri.İd+"        |");
            Console.WriteLine("| Ad : "+musteri.Ad+"        |");
            Console.WriteLine("| Soyad : "+musteri.Soyad+"  |");
            Console.WriteLine("-----------------------------");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Aşağıda ki Bilgilere Sahip Kullanıcıdan Silindi!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| İd : " + musteri.İd + "        |");
            Console.WriteLine("| Ad : " + musteri.Ad + "        |");
            Console.WriteLine("| Soyad : " + musteri.Soyad + "  |");
            Console.WriteLine("-----------------------------");
        }
        public void List(Musteri[] List)
        {
            foreach (var x in List)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("| İd : " + x.İd + "        |");
                Console.WriteLine("| Ad : " + x.Ad + "        |");
                Console.WriteLine("| Soyad : " + x.Soyad + "  |");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
