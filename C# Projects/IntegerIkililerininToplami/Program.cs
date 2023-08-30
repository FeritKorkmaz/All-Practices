namespace integer_İkililerinin_Toplami
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // kullanicidan consol'a girilecek sayi adeti isteniyor.
            int sayiAdeti;
            Console.Write("Lutfen sayi adetini cift sayi olarak giriniz: ");
            sayiAdeti = Convert.ToInt32(Console.ReadLine());
            
            // kullanicidan alinan sayi adetinin cift olup olmadigini kontrol ediyoruz.
            // eger cift degilse uyari verip programi sonlandiriyoruz.
            if (sayiAdeti % 2 == 0)
            {   
                // sayi adeti kadar sayi girilmesini istiyor ve sayilari bir dizinin icinde tutuyoruz.
                Console.WriteLine(sayiAdeti + " adet sayi giriniz: ");
                int [] sayilar = new int [sayiAdeti];
                
                for (int i = 0; i < sayiAdeti; i++)
                {
                    Console.Write("lütfen {0}. sayiyi giriniz: ", i+1);
                    sayilar[i] =Convert.ToInt32(Console.ReadLine());
                }

                // sayilari for dongusu ile 2ser 2ser donuyor ve toplamlarini console a yazdiriyoruz.
                // sayilar birbirine esitse toplamlarinin karesini yazdiriyoruz.
                for( int i = 0; i < sayiAdeti; i+=2)
                {
                    if(sayilar[i] == sayilar[i+1])
                    {
                        int toplam = sayilar[i] + sayilar[i+1];
                        int toplamKare =  toplam * toplam;
                        Console.WriteLine(toplamKare);
                    }
                    else
                    {
                        int toplam = sayilar[i] + sayilar[i+1];
                        Console.WriteLine(toplam);
                    }                                   
                }
            }
            else
            {
                Console.WriteLine("Yanlis Giris Yaptiniz...");
            }
            
        }
    }
}