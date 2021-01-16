using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            /// sayi1 kaç derdi
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0]=999;
            /// array , class, interface = referans tipidir
            /// int, double, float, decimal, bool = değer tip
            /// 
            /// değer ditp olanlar stack de gerçekleşiyor. sayi1=10 , sayi2=30;
            /// sayilar1 tanımladımızda stack alanında oluşur new dediğimiz zaman heap alanında 
            /// sayilar1 içersindeki değerler heap alanında oluşturulur ve stackda sayilar1 işe eşleştirilir
            /// 
            /// sayilar1 = sayilar2 dediğimizde heap alanında oluşan  sayilar2 nini değerlerini göstemeye başlar 
            /// sayilar1 stack deki sayilar1 değikeni
            /// 

        }
    }
}
