internal class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Bir sayi giriniz");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)
        {
          if ( i%2 == 1 )
          Console.WriteLine(i);
        }


        // 1 ile 1000 arasındaki tek ve cift sayilarin kendi aralarindaki toplami
        int tekToplam = 0;
        int ciftToplam = 0;
        
        for (int i = 1; i <= 1000; i++)
        {
            if ( i%2 == 1 )
                tekToplam += i; // tekToplam + i demek
            else
                ciftToplam += i; // ciftToplam + i demek
        }
        Console.WriteLine("Tek Toplam: " + tekToplam);
        Console.WriteLine("Cift Toplam: " + ciftToplam);

        // break, continue

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
            break;  // 1 den basladi 4 de durdu eger break yerine continue yazsaydik 4 u atlar ve 10 a kadar devam ederdi.
            Console.WriteLine(i);
        }
    }
}