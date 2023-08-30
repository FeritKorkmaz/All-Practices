namespace VotingApp
{
    // bir kullanici listesi olusturuyor ve icine iki adet sabit kullanici ekliyorum.
    public class VarsayilanKullancilar
    {       
        public static List<string> Kullanicilar;
        

        static VarsayilanKullancilar()
        {
            Kullanicilar = new List<string>();
            {
                string sabitKullanici1 = new string ("ferit");
                string sabitKullanici2 = new string ( "selim");
                Kullanicilar.Add(sabitKullanici1);
                Kullanicilar.Add(sabitKullanici2);
            };
        }
    }


    // yeni kullanici kayit etmek icin olusturulan ve olusturduktan sonrasinda listeye ekleyen metot.
    public class kayitEtmek 
    {
        public static void Kayit()
        {
            Console.WriteLine("Kullanici Adi: ");
            string username = Console.ReadLine();
            Console.WriteLine("Kayit Basarili.");
            VarsayilanKullancilar.Kullanicilar.Add(username);

        }

    }

   



}