internal class Program
{
    static void Main(string[] args)
    {
        //ogrenci adinda nesne olusturduk.
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ferit";
        ogrenci.Soyisim = "Korkmaz";
        ogrenci.OgrenciNo = 634;
        ogrenci.Sinif = 8;
        ogrenci.ogrenciBilgileriniGetir();
        
        // sinifi atlatip tekrar yazdirdik
        ogrenci.sinifAtlat();
        ogrenci.ogrenciBilgileriniGetir();


        // Dolu olan kurucu metotumuz ile olusturduk.
        Ogrenci ogrenci1 = new Ogrenci("Selim", "Kirikkovali", 256, 1);
        // 1 den daha asagiya dusurmeye calisip yazdiriyoruz ve uyari aliyoruz.
        ogrenci1.sinifDusur();
        ogrenci1.sinifDusur();

        ogrenci1.ogrenciBilgileriniGetir();

        
    }
}


class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;


    // Burda metotlari(fonsiyonlari) private olarak tanimladigimiz icin encapsule edip getiren ve setiren metotlar olusturduk.Bunlar olmaz ise main classin icinde erisemezdik.
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

    // burada encapsule ettikten sonra sinifi en fazla 1'e kadar dusurebilip daha fazla dusurunce uyarı vermesi ve 1 den kucuk olmamasi icin metotun icerigii degistirdik.
    public int Sinif 
    { 
        get => sinif; 
        set 
        {
            if(value<1)
            {
                Console.WriteLine("Sinif 1 den kucuk olamaz");
                sinif = 1;
            }
            else
            {
                sinif = value;
            }

        }
         
    }

    // kurucu metot iki adet asiri yuklenmis. overload edilmis.
    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}

    // ogrenci bilgilerini yazdirdik.
    public void ogrenciBilgileriniGetir ()
    {
        Console.WriteLine("*****Ogrenci Bilgileri*******");
        Console.WriteLine("Ogrenci Adi    : {0}", this.isim); // {0}, this isim = 0 yazan yerde "bu" yani isim yazsin demek.
        Console.WriteLine("Ogrenci Soyadi    : {0}", this.soyisim);
        Console.WriteLine("Ogrenci No    : {0}", this.ogrenciNo);
        Console.WriteLine("Ogrenci Sinif    : {0}", this.sinif);
    }

    public void sinifAtlat ()
    {
        this.sinif += 1;
    }
    public void sinifDusur ()
    {
        this.sinif -= 1;
    }
}