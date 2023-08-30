namespace VotingApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           VotingApp();           
        }

        public static void VotingApp()
        {
            Console.WriteLine("Yapmak istediginiz islemi seciniz.");
            Console.WriteLine("Oy Kullan(1), Uygulama Kapat(2)");
            int secim =int.Parse(Console.ReadLine());


            if( secim == 1 )
            {
                Console.Write("Lütfen kullanici adinizi giriniz: ");         
                string isim =Console.ReadLine();             
        
                if (VarsayilanKullancilar.Kullanicilar.Contains(isim) == true)
                {
                    Console.WriteLine("Kullanici Kayitli:");
                    kategoriler.OyVerme();
                    kategoriler.OylamaSonuc();
                    VotingApp();                   
                }
                else
                {
                    Console.WriteLine("Kullanici kayitli degil. Lutfen kayit olunuz.");
                    kayitEtmek.Kayit();
                    kategoriler.OyVerme();
                    kategoriler.OylamaSonuc();
                    VotingApp();                    
                }
            }
            else if( secim == 2 )
            {
                kategoriler.OylamaSonuc();
            }
            else
            {
                Console.WriteLine("Bir secim yapiniz.");
            }

        
        }

    
    }
    
}
