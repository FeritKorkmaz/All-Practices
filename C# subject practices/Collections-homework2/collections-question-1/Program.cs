using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {
        // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        Console.WriteLine("Dizi icin Pozitif 20 Sayi Giriniz");
        int [] sayilar = new int [20];
        int diziElemani;
        int asalToplam = 0;
        int asalDegilToplam = 0;
        
        // eleman sayisi kadar for ile don ve diziye ekle. Ekledigin sayilari for ile tekrar don ve asalligini kotrol et.
        for (int i = 0; i < sayilar.Length; i++)
        {            
            Console.Write("Diziye Eklenecek {0}. Elemani Tanimlayin: ",(i+1));
            diziElemani = Convert.ToInt32(Console.ReadLine());
            if (diziElemani > 0)
            {
                sayilar[i] = diziElemani;
            }
                // listeye ekledigimiz sayilari ayni zamanda topla
                for (int j = 2; j <= sayilar[i] ; j++)
                {
                     if(sayilar[i] % j == 0 && j != sayilar[i])
                     {
                        asalOlmayanSayilar.Add(sayilar[i]);
                        asalDegilToplam += Convert.ToInt32(sayilar[i]);                        
                        break;
                     }
                     if(sayilar[i] % j == 0 && j == sayilar[i])
                     {                        
                        asalSayilar.Add(sayilar[i]);
                        asalToplam += Convert.ToInt32(sayilar[i]);                        
                     }
                }
                             
        }

        // listeleri buyukten kucuge sirala ve yazdir
        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();
        foreach (var item in asalOlmayanSayilar)
        {
            Console.WriteLine("Asal Degil: " + item);
            
        }
        // eleman sayisini(count) ve ortalama yazdirma       
        double asalDegilOrtalama = Convert.ToDouble(asalDegilToplam) /Convert.ToDouble(asalOlmayanSayilar.Count);
        Console.WriteLine("Asal Olmayan Sayilarin Ortalamasi: " + asalDegilOrtalama.ToString());
        Console.WriteLine("Eleman Sayisi: " + asalOlmayanSayilar.Count);
        


        Console.WriteLine("----------------");

        asalSayilar.Sort();
        asalSayilar.Reverse();
        foreach (var item in asalSayilar)
        {
            Console.WriteLine("Asal : " + item);           
            
        }
        // eleman sayisini(count yazdirma)
        double asalOrtalama =Convert.ToDouble(asalToplam) / Convert.ToDouble(asalSayilar.Count);
        Console.WriteLine("Asal Sayilarin Ortalamasi: " + asalOrtalama.ToString());
        Console.WriteLine("Eleman Sayisi: " + asalSayilar.Count);
        

        

        
               
       
        


        

        
        
    }
}