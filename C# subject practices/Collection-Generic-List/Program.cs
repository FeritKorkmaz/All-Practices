internal class Program
{
    public static void Main(string[] args)
    {
        // List <T> class
        // System.Collections.Generic
        // T --> object turundedir.

        List<int> sayiList = new List<int>();

        sayiList.Add(23);
        sayiList.Add(10);
        sayiList.Add(56);
        sayiList.Add(5);
        sayiList.Add(92);
        sayiList.Add(4);

        List<string> renkList = new List<string>();

        renkList.Add("Kirmizi");
        renkList.Add("Mavi");
        renkList.Add("Sari");
        renkList.Add("Turuncu");
        renkList.Add("Yesil");

        // count
        Console.WriteLine(renkList.Count());
        Console.WriteLine(sayiList.Count());

        // foreach ve list.ForEach ile elemanlara erişim.        
        foreach (var sayi in sayiList)
        {
            Console.WriteLine(sayi);
        }
        sayiList.ForEach(sayi => Console.WriteLine(sayi));

        foreach (var renk in renkList)
        {
            Console.WriteLine(renk);
            
        }
        renkList.ForEach(renk => Console.WriteLine(renk));


        // Listeden eleman cikarma

        // eleman ismi ile
        sayiList.Remove(4);
        renkList.Remove("Yesil");
        
        // index ile cikar
        sayiList.RemoveAt(0);
        renkList.RemoveAt(1);

        sayiList.ForEach(sayi => Console.WriteLine(sayi));
        renkList.ForEach(renk => Console.WriteLine(renk));
         
        
        // Liste icerisinde arama
        if(sayiList.Contains(10))
        {
            Console.WriteLine("10 liste icerisinde bulundu");
        }

        // Eleman ismi ile indexi bulma
        Console.WriteLine(renkList.BinarySearch("Sari"));

        // Diziyi List e Cevirmek
        string[] hayvanlar = {"kedi", "kopek", "kus"};

        List<string> hayvanlarList = new List<string>(hayvanlar);

        // Listeyi Nasil Temizlerim
        hayvanlarList.Clear();


        // List icerisinde nesne tutmak  
        List<Kullanicilar> kullanicilarList = new List<Kullanicilar>();


        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Ayse";
        kullanici1.Soyisim = "Yilmaz";
        kullanici1.Yas = 26;


        
        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Mehmet";
        kullanici2.Soyisim = "Gulsum";
        kullanici2.Yas = 26;

        kullanicilarList.Add(kullanici1);
        kullanicilarList.Add(kullanici2);

        List<Kullanicilar> yeniList = new List<Kullanicilar>();
        yeniList.Add(new Kullanicilar(){
            Isim = "Mehmet",
            Soyisim = "Yildiz",
            Yas = 28
        });

        foreach (var kullanici in kullanicilarList)
        {
            Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
            Console.WriteLine("Kullanici Adi: " + kullanici.Soyisim);
            Console.WriteLine("Kullanici Adi: " + kullanici.Yas);
        }
        yeniList.Clear();
         
    }
}

public class Kullanicilar{
    string isim;
    string soyisim;
    int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}