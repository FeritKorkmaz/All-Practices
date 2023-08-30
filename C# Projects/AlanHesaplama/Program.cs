namespace AlanVeCevreHesaplama
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Kullanicidan secmek istedigi geometrik sekli aliyorum.
            Console.WriteLine("Luften istediginiz geometrik sekli seciniz: Daire(1) Ucgen(2) Kare(3) Dikdortgen(4)");
            int secim = Convert.ToInt32(Console.ReadLine());
            
            // Secim seceneklerde var mi diye kontrol ediyorum.
            if (secim == 1 || secim == 2 || secim == 3 || secim == 4)
            {
                // Kullanicidan hangi islemi yapmak istedigini aliyorum.
                Console.WriteLine("Luften yapmak istediginiz islemi seciniz: CevreHesaplama(1) AlanHesaplama(2)");
                int islemSecim = Convert.ToInt32(Console.ReadLine());
                

                // Kullanicidan alinan islem seciminin sonucunda yapacagi islemi ve secimin dogrulugunu kontrol ediyorum.
                if(islemSecim == 1)
                {                  
                    CevreHesaplama(secim);
                }
                else if(islemSecim == 2)
                {               
                    AlanHesaplama(secim);
                }
                else
                {
                    Console.WriteLine("Yanlis Giris Yaptiniz.");
                }
            }            
            else
            {
                Console.WriteLine("Yanlis Giris Yaptiniz.");
            }
            
        }

        // Bu metot kullanicinin sectigi geometrik sekle gore alan hesaplamalarini yapiyor ve konsola yazdiriyor. 
        public static void AlanHesaplama(int secim)
        {
            if (secim == 1) // Daire
            {
                double alan;
                double r;
                Console.Write("yaricap giriniz: ");
                r = Convert.ToDouble(Console.ReadLine());
                alan = Math.PI * r * r;
                Console.WriteLine("Dairenin Alani: " + alan);
            }
            else if(secim == 2) // Ucgen
            {
                double alan;
                double tabanUzunlugu;
                double yukseklik;

                Console.Write("Taban uzunlugunu giriniz: ");
                tabanUzunlugu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Yuksekligi giriniz: ");
                yukseklik = Convert.ToDouble(Console.ReadLine());
                
                alan = (tabanUzunlugu * yukseklik) / 2 ;
                Console.Write("Ucgenin alani: " + alan);
            }
            else if(secim == 3) // Kare
            {
                double kenar;
                double alan;

                Console.Write("Kenar uzunlugunu giriniz: ");
                kenar = Convert.ToDouble(Console.ReadLine());

                alan = kenar * kenar;
                Console.Write("Karenin alani: " + alan);               
            }
            else if(secim == 4) // Diktortgen
            {
                double kisaKenar;
                double uzunKenar;
                double alan;

                Console.Write("Kisa kenari giriniz: ");
                kisaKenar = Convert.ToDouble(Console.ReadLine());

                Console.Write("Uzun kenari giriniz: ");
                uzunKenar = Convert.ToDouble(Console.ReadLine());

                alan = kisaKenar * uzunKenar;
                Console.Write("Diktorgenin alani: " + alan); 

            }
        }


        // Bu metot kullanicinin sectigi geometrik sekle gore cevre hesaplamalarini yapiyor ve konsola yazdiriyor.
         public static void CevreHesaplama(int secim)
        {
            if (secim == 1) // Daire
            {
                double cevre;
                double r;
                Console.Write("yaricap giriniz: ");
                r = Convert.ToDouble(Console.ReadLine());
                cevre = 2 * Math.PI * r;
                Console.WriteLine("Dairenin Cevresi: " + cevre);
            }
            else if(secim == 2) // Ucgen
            {
                double cevre;
                double tabanUzunlugu;
                double kenar1;
                double kenar2;

                Console.Write("Taban uzunlugunu giriniz: ");
                tabanUzunlugu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Birinci kenari giriniz: ");
                kenar1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci kenari giriniz: ");
                kenar2 = Convert.ToDouble(Console.ReadLine());
                
                cevre = tabanUzunlugu + kenar1 + kenar2;
                Console.Write("Ucgenin cevresi: " + cevre);
            }
            else if(secim == 3) // Kare
            {
                double kenar;
                double cevre;

                Console.Write("Kenar uzunlugunu giriniz: ");
                kenar = Convert.ToDouble(Console.ReadLine());

                cevre = kenar * 4;
                Console.Write("Karenin cevresi: " + cevre);               
            }
            else if(secim == 4) // Diktorgen
            {
                double kisaKenar;
                double uzunKenar;
                double cevre;

                Console.Write("Kisa kenari giriniz: ");
                kisaKenar = Convert.ToDouble(Console.ReadLine());

                Console.Write("Uzun kenari giriniz: ");
                uzunKenar = Convert.ToDouble(Console.ReadLine());

                cevre = 2 * (kisaKenar + uzunKenar);
                Console.Write("Diktorgenin cevresi: " + cevre); 

            }
        }


    }    
    
}


