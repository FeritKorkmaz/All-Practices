internal class Program
{
    private static void Main(string[] args)
    {
        // system.collections.Generic
        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
        
        kullanicilar.Add(10, "Ayse Yilmaz");
        kullanicilar.Add(12, "Ahmet Yilmaz");
        kullanicilar.Add(18, "Mehmet Yilmaz");
        kullanicilar.Add(15, "Mustafa Yilmaz");

        // Dizinin elemanlarina Erisim
        Console.WriteLine("******Elamanlara Erisim******");
        Console.WriteLine(kullanicilar[12]);
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        // Count(kac elemanli)
        Console.WriteLine("******Count******");
        Console.WriteLine(kullanicilar.Count());

        // Containtns (boolean cevap verir key e yada value ye gore elemani sorgular var mi yok mu)
        Console.WriteLine("******Coantains******");
        Console.WriteLine(kullanicilar.ContainsKey(12));
        Console.WriteLine(kullanicilar.ContainsValue("Ferit Korkmaz"));

        // Remove (kullanici cikarmak. key veya value a gore)
        Console.WriteLine("******Remove******");
        kullanicilar.Remove(12);
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }


        // Keys (Sadece keys uzerinde islem yapabilmek)
        Console.WriteLine("******Keys******");
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);
        }


        // Value  (Sadece values uzerinde islem yapabilmek)
        Console.WriteLine("******Values******");
        foreach (var item in kullanicilar.Values)
        {
            Console.WriteLine(item);
        }









    }
}