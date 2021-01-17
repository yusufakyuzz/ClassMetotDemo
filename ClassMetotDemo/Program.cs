using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 66;
            musteri1.Adi = "Yusuf";
            musteri1.Meslek = "Asker";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);

            musteriManager.MusteriListele(musteri1);

            musteriManager.MusteriSil(musteri1);

        }
    }
}
