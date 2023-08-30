internal class Program
{
    private static void Main(string[] args)
    {
        // kullanicidan kac adet sayi girilecegi istenir.
        int sayiAdeti;
        Console.Write("Lutfen sayi adetini giriniz: ");
        sayiAdeti = Convert.ToInt32(Console.ReadLine());

        // girilen sayilar bir dizide tutulur.
        Console.WriteLine(sayiAdeti + " adet sayi giriniz: ");
        int [] sayilar = new int [sayiAdeti];
        int FarkToplam = 0;
        int FarkKareToplam = 0;
        
        // girilen sayilarin 67 den kucuk veya buyuk olma durumuna gore gerekli olan mat islemleri yapilir.
        // sonuclar console a yazdirilir. 
        for (int i = 0; i < sayiAdeti; i++)
        {
            Console.Write("lütfen {0}. sayiyi giriniz: ", i+1);
            sayilar[i] =Convert.ToInt32(Console.ReadLine());

            if (sayilar[i] < 67)
            {
                int fark = 67-sayilar[i];
                FarkToplam += fark;
            }
            else
            {
                int buyukSayiFark = Math.Abs(67 - sayilar[i]);
                int farkKare = buyukSayiFark * buyukSayiFark;
                FarkKareToplam += farkKare;             
            }          
        }

        Console.WriteLine("67 den kucuk sayilarin farklarinin toplam: " + FarkToplam);
        Console.WriteLine("67 den buyuk sayilarin farklarinin kareleri toplam: " + FarkKareToplam);


       
       
        

    

            
    }
}