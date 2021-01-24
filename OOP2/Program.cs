using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri(); 
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Samet";
            musteri1.Soyadi = "Sen";
            musteri1.TcNo = "12312312123";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Asina";
            musteri2.VergiNo = "1234567890";

            //SOLID


            //Musteri sınıfı hem gerçek hem tüzel müşteri 
            //referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
