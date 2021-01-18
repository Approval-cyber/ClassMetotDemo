using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.İd = 43434;
            musteri.Ad = "Mehmet";
            musteri.Soyad = "Approval";
            Musteri musteri1 = new Musteri();
            musteri1.İd = 54232;
            musteri1.Ad = "Batu";
            musteri1.Soyad = "Sheid";
            Musteri musteri2 = new Musteri();
            musteri2.İd = 2324;
            musteri2.Ad = "Eray";
            musteri2.Soyad = "Nikos";
            ClassMetotDemo classMetotDemo = new ClassMetotDemo();
            Musteri[] mustericik = new Musteri[] { musteri, musteri1, musteri2 };
            classMetotDemo.Add(musteri);
            classMetotDemo.Delete(musteri2);
            classMetotDemo.List(mustericik);
            Console.ReadLine();
        }
    }
}
