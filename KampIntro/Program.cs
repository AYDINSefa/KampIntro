using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ahsap ahsap1 = new ahsap();
            ahsap1.ahsap_turu = "kayın";
            ahsap1.ahsap_boy = 400;
            ahsap1.ahsap_eni = 20;
            ahsap1.ahsap_bolge = "karadeniz bölgesi";

            ahsap ahsap2 = new ahsap();
            ahsap2.ahsap_turu = "ardıç";
            ahsap2.ahsap_boy = 200;
            ahsap2.ahsap_eni = 15;
            ahsap2.ahsap_bolge = "marmara bölgesi";

            //ahşap bilgilerini ahsap tipinde oluşturduğumuz  keresteler adlı bir diziye attık 
            ahsap[] keresteler = new ahsap[] { ahsap1, ahsap2 };

            // foreach kullanımı
            Console.WriteLine("\n" + "1-foreach döngüsü");
            foreach (ahsap kereste in keresteler)
            {
                
                Console.WriteLine(" Kerestenin Adı: "+kereste.ahsap_turu +" \n Kerestenin Bölgesi :"+ kereste.ahsap_bolge+
                    "\n Keresenin Eni " + kereste.ahsap_eni+ " \n Kerestenin Boyu " + kereste.ahsap_boy+ "\n\n");
            }

            Console.WriteLine("\n" + "1-for döngüsü");
            for (int i = 0; i < keresteler.Length; i++)
            {
                Console.WriteLine(" Kerestenin Adı: " + keresteler[i].ahsap_turu + " \n Kerestenin Bölgesi :" + keresteler[i].ahsap_bolge +
                    "\n Keresenin Eni " + keresteler[i].ahsap_eni + " \n Kerestenin Boyu " + keresteler[i].ahsap_boy + "\n\n");
            }

            Console.WriteLine("\n" + "1-while  döngüsü");
            int sayac = 0;
            while (sayac < keresteler.Length)
            {
                Console.WriteLine(" Kerestenin Adı: " + keresteler[sayac].ahsap_turu + " \n Kerestenin Bölgesi :" + keresteler[sayac].ahsap_bolge +
                   "\n Keresenin Eni " + keresteler[sayac].ahsap_eni + " \n Kerestenin Boyu " + keresteler[sayac].ahsap_boy + "\n\n");
                sayac++;
            }

        }

       
    }
    class ahsap
    {
        public string ahsap_turu { set; get; }
        public int ahsap_boy { set; get; }// cm cinsinde 
        public int ahsap_eni { set; get; }// cm cinsinden 

        public string ahsap_bolge { set; get; }
    }
}
