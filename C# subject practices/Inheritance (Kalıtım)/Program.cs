internal class Program
{
    static void Main(string[] args)
    {
        //                           canlilar
        //                              |
        //            bitkiler                       hayvanlar
        //         |             |                 |             |
        //     tohumlu        tohumsuz         surungenler     kuslar 

        tohumluBitkiler tohumluBitki = new tohumluBitkiler();
        tohumluBitki.beslenme();
        tohumluBitki.bosaltim();        
        tohumluBitki.solunum();
        // tohumluBitki.fotosentez(); artik nesneden direk fotosenteze erisemiyoruz cünkü erisim belirteci protected yaptik
        // ama yinede calistirdigimizda fotosentez metodu da calisti cunku kurucu metot(construct)a base ile ekledik.
        // bu sekilde hepsini base a atabilir direk run edip yazdirabiliriz ben ornek olarak birini yapip biraktim
        tohumluBitki.tohumlaCogalma();

        Console.WriteLine("----------------------------------------------------------------");

        kuslar marti = new kuslar();
        marti.beslenme();
        marti.bosaltim();
        marti.solunum();
        marti.adaptasyon();
        marti.hareket();


        //                              Polymorphism ve Sealed Class
        // Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.
        // Virtual metot tanımı :

        // public virtual void UyaranlaraTepki() 
        //  { 
        //      Console.WriteLine("Canlılar uyaranlara tepki verir.");
        //  }


        // Alt sınıf içerisinde override metot kullanımı:

        // public override void UyaranlaraTepki() 
        // {
        //     base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
        //     Console.WriteLine("Bitkiler güneşe tepki verir.");
        // }




      



        
    }
}

