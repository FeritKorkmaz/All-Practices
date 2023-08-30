internal class Program
{

    // Struct'lar yani yapılar sınıflara çok benzerler. Struct ile yapıp sınıf ile yapamayacağız bir işlem yoktur diyebiliriz. Peki o halde struct yani yapılara neden ihtiyaç duyulur?
    // Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz.    
    static void Main(string[] args)
    {
        Diktortgen diktortgen = new Diktortgen();
        diktortgen.KisaKenar=3;
        diktortgen.UzunKenar=4;
        Console.WriteLine("Class Alan Hesbi : {0}" , diktortgen.AlanHesapla());

        // Diktortgen_Struct diktortgen_Struct = new Diktortgen_Struct(); 
        Diktortgen_Struct diktortgen_Struct; // classda bu sekilde erisemeyiz. Struct da ise iki sekilde erisebiliriz.
        diktortgen_Struct.KisaKenar = 3;
        diktortgen_Struct.UzunKenar = 4;
        Console.WriteLine("Class Alan Hesbi : {0}" , diktortgen_Struct.AlanHesapla());
        
    }
}

class Diktortgen 
{
    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}



// class lara gore erisim ve tanimlama yaparken syntax farklari var.
// temel farklardan birisi class lar referans türü veri tipindeki iken struct ise degildir.
// buda performans farklari ortaya cikarabiliyor. Sinif daha güclü ve ram'de tutulduklari yer farkli.  
struct Diktortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

     public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }

}