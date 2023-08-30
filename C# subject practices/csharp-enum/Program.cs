internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.pazar);
        Console.WriteLine((int)Gunler.cumartesi); // index degerine ulasmak icin int e cevirdik.

        int sicaklik = 32;
        if(sicaklik <= (int)havaDurumu.normal)
        {
            Console.WriteLine("Disariya cikmak icin isinmasini bekle.");
        }
        else if(sicaklik > (int)havaDurumu.sicak)
        {
            Console.WriteLine("Disariya cikmak icin cok sicak bir gun.");
        }
        else if(sicaklik >= (int)havaDurumu.normal && sicaklik <= (int)havaDurumu.sicak)
        {
            Console.WriteLine("Hadi disari cikalim");
        }
        
        
    }
}


// index seklinde tutar. Ardisik ve degismeyecek tanimlamalrda kullanilabilir.
// 6. index yerinde carsamba seklinde isimlendirdigimiz icin daha anlamli sekilde elemana erisebiliyoruz
// ve index degerlerini degistirebiliyoruz.
enum Gunler 
{
    pazartesi,
    sali,
    carsamba,
    persembe,
    cuma = 23,
    cumartesi,
    pazar
}

enum havaDurumu
{
    soguk = 5,
    normal = 20,
    sicak = 25,
    cokSicak =35
}