internal class Program
{
    static void Main(string[] args)
    {
        // dizi olusturma
        string[] renkler = new string[5];
        string[] hayvanlar = {"kedi","kopek","fare"};
        int[] dizi;
        dizi = new int[5];


        // dizilere deger atama ve erisim
        renkler[0] = "Mavi";
        Console.WriteLine(hayvanlar[0]);
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Dongulerle dizi kullanimi
        // klavyeden girilen n tane sayinin ortalamasini bulalim

        Console.Write("Lutfen dizinin eleman sayisini giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int [] sayiDizisi = new int[diziUzunlugu];
        
         for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("lütfen {0}. sayiyi giriniz:", i+1);
            sayiDizisi[1] = int.Parse(Console.ReadLine());
        }

        int toplamSayi = 0;
        foreach (var sayi in sayiDizisi)           
        toplamSayi += sayi;

        Console.WriteLine(toplamSayi/diziUzunlugu);
    }
}