internal class Program
{
    static void Main(string[] args)
    {
        // Soz Dizisi
        // class sinif adi
        // {
        //     (Erisim Belirleyici) [Version Tipi] OzellikAdi;
        //     (Erisim Belirleyici) [Geri Donus Tipi] MetotAdi(Parametre Listesi)
        //     {
        //         Metot Komutlari
        //     }
        // }
        
        // Erisim Belirleyici
        // * Public ---- Her yerden erisebilir
        // * Private ---- Sadece kendi icerisinde erisilebilen metotlara 
        // * Internal ---- Sadece kendi bulundugu o proje icerisinde erisilebilen degiskenlere ve metotlara
        // * Protected -- Sadece tanimlandigi siniflar ve miras aldigi siniflara 

        calisan calisan1 = new calisan();
        calisan1.Ad = "Selim";
        calisan1.Soyadi = "Kirikkovali";
        calisan1.No = 1545445441;
        calisan1.Departman = "İnsan Kaynaklari";
        calisan1.calisanBilgileri();

        Console.WriteLine("****************************************************************");

        calisan calisan2 = new calisan(); 
        calisan2.Ad = "Ferit";
        calisan2.Soyadi = "Korkmaz";
        calisan2.No = 1545445442;
        calisan2.Departman = "Satin Alma";
        calisan2.calisanBilgileri();

    }
}

class calisan
{
    public string Ad;
    public string Soyadi;
    public int No;
    public string Departman;
    public void calisanBilgileri ()
    {
        Console.WriteLine("Calisan Adi:{0}", Ad);
        Console.WriteLine("Calisan Soyadi:{0}", Soyadi);
        Console.WriteLine("Calisan Numarasi:{0}", No);
        Console.WriteLine("Calisan Departmani:{0}", Departman);
    }
}