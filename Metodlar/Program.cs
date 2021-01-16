using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyerbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };
            // type safe 
            foreach (Urun urun  in urunler)
            {
               Console.WriteLine(urun.Adi);
               Console.WriteLine(urun.Fiyati);
               Console.WriteLine(urun.Aciklama);
               Console.WriteLine("--------");
            }
            Console.WriteLine("-------------------- Metodlar ------------");
            // instance
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("domate", "çorum domatesi", 15, 9);
            sepetManager.Ekle2("patates", "bolu domatesi", 15, 9);
            sepetManager.Ekle2("armut", "kelmahmut", 15, 9);

        }
    }
}// Dont repart yourself - Kendini tekrar etme !- DRY - Clean Code - Best Practice -


