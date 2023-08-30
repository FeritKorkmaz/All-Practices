internal class Program
{
    
    static void Main(string[] args)
    {

        
        Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
        // Nesne olustururken private olan ozelliklere erisemedik. direk set edecek sekilde kurucu metota atama yaptik.
        Calisan calisan = new Calisan ("Ferit", "Korkmaz", "AR-GE");
        Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

        

        // static sinif yeni nesne olustururken class ismi nokta seklinde ulasiriz.
        Console.WriteLine("topla: {0}", Islemler.Topla(100,200)); 
        Console.WriteLine("topla: {0}", Islemler.Cikar(400,150));



                      
    }
}

// Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
class Calisan 
{
    private static int calisanSayisi;

    // Disaridan erisimi kapattik yani set'i. Ama olusturdugumuz kurucu metot ile calisan sayiini get edip kurucu metot da icerigini degistirebildik. iceri acik disari kapali. 
    public static int CalisanSayisi { get => calisanSayisi;}
    private string Isim;
    private string Soyİsim;
    private string Departman;
    
    // console a yazdirdigimizda bu kurucu metota sadece ilk cagirildiginda girer set eder sonra birdaha girmez direk asagidaki kurucu metota girer ve calisan sayisini ordan artirir.
    static Calisan () {
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyİsim, string departman)
    {
        this.Isim = isim;
        this.Soyİsim = soyİsim;
        this.Departman = departman;
        calisanSayisi ++;
    }
} 


// Stati siniflarda static olmayan ozellik olamaz.
static class Islemler 
{
    public static long Topla (int sayi1, int sayi2)
    {
        return(sayi1 + sayi2);
    }
     public static long Cikar (int sayi1, int sayi2)
    {
        return(sayi1 - sayi2);
    }

}