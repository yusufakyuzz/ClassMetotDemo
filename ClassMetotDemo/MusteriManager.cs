using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi"+" : "+musteri.Adi);    
        } 

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" : sıra numaralı ismi "+musteri.Adi+" olan kayıt silindi");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" isimli musteri getirildi.");
        }

    }

   



}
