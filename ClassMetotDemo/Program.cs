using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                MusteriAdi = "Jack",
                MusteriSoyadi = "Sparrow",
                Yas = 30,
                Cinsiyet = "Erkek",
                Uyruk = "T.C.",
                Tckn = "14614655580"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                MusteriAdi = "Darth",
                MusteriSoyadi = "Vader",
                Yas = 38,
                Cinsiyet = "Erkek",
                Uyruk = "T.C.",
                Tckn = "50014655580"
            };

            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                MusteriAdi = "Barış",
                MusteriSoyadi = "Manço",
                Yas = 27,
                Cinsiyet = "Erkek",
                Uyruk = "T.C.",
                Tckn = "80014655580"
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.musteriListele(musteriler);

        }
    }
}
