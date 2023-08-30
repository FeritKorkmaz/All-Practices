namespace VotingApp
{
    // Static ozellikli kategoriler olusturdum.    
    // Bunlarin toplam oya oranini hesaplayan static ozellikler olusturdum.
    public class kategoriler
    {
        // Sabit oylar
        public static double Galatasaray = 5;
        public static double Fenerbahce = 3;
        public static double Besiktas = 3;       

        // Oy verme icin kullanicidan secim yapmasini istedim.
        // Standart degerler verilen kategorilerin kullanici oy verdiginde deger artisini sagladim.        
        public static void OyVerme()
        {           
            Console.WriteLine("Galatasaray(1), Fenerbahce(2), Besiktas(3)");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Galatasaray++;
            }
            else if (secim == 2)
            {
                Fenerbahce++;
            }
            else if (secim == 3)
            {
                Besiktas++;
            }
            else
            {
                Console.WriteLine("yanlis giris yaptiniz:");
                OyVerme();
            }
        }
           


        // Oy sonucu gosteren metot.
        public static void OylamaSonuc()
        {
            double toplam = Galatasaray + Fenerbahce + Besiktas;
            double GalOrt = (Galatasaray * 100) / toplam;
            double FenOrt = (Fenerbahce * 100) / toplam;
            double BesOrt = (Besiktas * 100) / toplam;       
       
            Console.WriteLine("Galatasaray: " + Galatasaray + " oy / Yuzde: " + GalOrt );
            Console.WriteLine("Fenerbahce:  " + Fenerbahce + " oy / Yuzde: " + FenOrt );
            Console.WriteLine("Besiktas:    " + Besiktas + " oy / Yuzde: " + BesOrt );
        }
    }



}