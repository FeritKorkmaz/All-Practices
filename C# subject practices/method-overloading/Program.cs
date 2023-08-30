internal class Program
{
    public static void Main(string[] args)
    {
        // out parametreler
        string sayi = "999";
        
        bool sonuc = int.TryParse(sayi, out int outSayi);
        if (sonuc)
        {
            Console.WriteLine("Basarali");
            Console.WriteLine(outSayi);
        }
        else {
            Console.WriteLine("basarisiz");
        }
        
        methods instane = new methods();
        instane.Topla(2,3, out int sonuclar);
        Console.WriteLine(sonuclar);

        // metho asırı yukleme -- overloading
        
        int ifade = 999;
        instane.ekranaYazdir(Convert.ToString(ifade));
        instane.ekranaYazdir(ifade);
        instane.ekranaYazdir("Ferit", "Korkmaz");

        // method imzasi
        // methodAdi   + parametre sayisi + parametre = 3 u ayni olursa o zaman hata verir asiri yukleme kabul etmez



    }
}

class methods
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }

// ekrana yazdir metoduna(fonksiyonuna) hem int hem string deger atadik
    public void ekranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

     public void ekranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

     public void ekranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}