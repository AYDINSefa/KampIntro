using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //nameing convention
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi !"+ urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama,  double fiyat , int stok )
        {
            Console.WriteLine("Tebrikler. Sepete eklendi !" + urunAdi);
        }
    }
}
