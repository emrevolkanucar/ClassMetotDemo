using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public bool musteriListKontrol (Musteri[] musteri)
        {
            if (musteri.Length > 0)
            {
                return true;
            } else
            {
                Console.WriteLine("Henüz listenize müşteri eklenmemiş.");
                return false;
            }
        }
        public void musteriListele(Musteri[] musteriler, Musteri musteri = null)
        {
            if (musteriListKontrol(musteriler))
            {
                foreach (Musteri musteri1 in musteriler)
                {
                    Console.WriteLine("Müşteri Adı: " + musteri1.MusteriAdi + "\nMüşteri Soyadı: " + musteri1.MusteriSoyadi + "\nMüşteri T.C. Kimlik No: " + musteri1.Tckn + "\nMüşteri Uyruk: " + musteri1.Uyruk + "\n-----------------------------------");
                }
            }
        }
    }
}
