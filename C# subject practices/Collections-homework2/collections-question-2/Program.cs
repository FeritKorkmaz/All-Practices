internal class Program
{
    public static void Main(string[] args)
    {
        // diziyi olusturduk consol dan gelen 20 sayiyi diziye ekledik.
        Console.WriteLine("Dizi icin Pozitif 20 Sayi Giriniz");
        int [] sayilar = new int [20];
        int diziElemani;
        for (int i = 0; i < sayilar.Length; i++)
        {            
            Console.Write("Diziye Eklenecek {0}. Elemani Tanimlayin: ",(i+1));
            diziElemani = Convert.ToInt32(Console.ReadLine());
            sayilar[i] = diziElemani;
        }

        // diziyi siraladik ve sonra ters cevirdik buyukten kucuge dogru.
        Array.Sort(sayilar);
        Array.Reverse(sayilar);

        // en buyuk ve en kucuk sayilari yazdirdik     
        int [] enbuyuk3 = {sayilar[0], sayilar[1], sayilar[2]};
        int [] enkucuk3 = {sayilar[sayilar.Length-1], sayilar[sayilar.Length-2], sayilar[sayilar.Length-3]};
        foreach (var item in enbuyuk3)
        {
            Console.WriteLine("En Buyuk 3 Sayi: " + item);            
        }
        foreach (var item in enkucuk3)
        {
            Console.WriteLine("En Kucuk 3 Sayi: " + item);          
        }


        // bu sayilarin toplamlarini bulduk. Ortalamasini aldik ve toplamlari ile birlikte yazdirdik.
        int enbuyukToplam = 0;
        int enkucukToplam = 0;
        for (int i = 0; i < enkucuk3.Length; i++)
        {
            enbuyukToplam += enbuyuk3[i];
            enkucukToplam += enkucuk3[i];
        }
        double enbuyukOrt = Convert.ToDouble(enbuyukToplam)/ (Convert.ToDouble(enbuyuk3.Length));
        double enkucukOrt = Convert.ToDouble(enkucukToplam) / (Convert.ToDouble(enkucuk3.Length));
        double ortalamaToplam = Convert.ToDouble(enbuyukOrt) + (Convert.ToDouble(enkucukOrt));

        Console.WriteLine("En Kucuk 3 Sayinin Ortalamasi: " + enkucukOrt.ToString());
        Console.WriteLine("En Buyuk 3 Sayinin Ortalamasi: " + enbuyukOrt.ToString());
        Console.WriteLine("Ortalama Toplamlari: " + ortalamaToplam.ToString());

        



        




        
    }
}