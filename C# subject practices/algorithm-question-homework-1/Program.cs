internal class Program
{
    public static void Main(string[] args)
    { 
        // 1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        Console.WriteLine("Pozitif Bir Sayi Giriniz");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n + " adet pozitif sayi giriniz");
        int [] sayilar = new int [n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("lütfen {0}. sayiyi giriniz:", i+1);
            sayilar[i] = int.Parse(Console.ReadLine());           
        }

        foreach (var sayi in sayilar)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi);
            }
        }

        // 2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("Pozitif iki Sayi Giriniz");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(x + " adet pozitif sayi giriniz");
        int [] dizi = new int [x];
        for (int i = 0; i < x; i++)
        {
            Console.Write("lütfen {0}. sayiyi giriniz:", i+1);
            dizi[i] = int.Parse(Console.ReadLine());           
        }

        foreach (var sayi in dizi)
        {
            if (sayi == y || sayi % y == 0)
            {
            Console.WriteLine(sayi);              
            }
        }

        // 3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        
        Console.WriteLine("Pozitif bir Sayi Giriniz");

        int z = int.Parse(Console.ReadLine());

        Console.WriteLine(z + " adet kelime giriniz");

        string [] stDizi = new string [z];

        for (int i = 0; i < z; i++)

        {

            Console.Write("lütfen {0}. kelimeyi giriniz:", i+1);

            stDizi[i] = (Console.ReadLine());           

        }


        for (int i = z-1; i >= 0; i--)

        {

            Console.WriteLine(stDizi[i]); 

        }
        
        
        // 4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("Bir Cümle Giriniz");
        string c = (Console.ReadLine());      
        int harfSayac = 0;
        for (int i = 0; i < c.Length ; i++)
        {
            if (c.Contains(c[i]))
            {
                harfSayac++;    
            }
            if (c[i]==' ')
            {
                harfSayac -= 1;
            }             
        }        
        string [] kelime = c.Split(' ');
        int kelimeSayac = kelime.Length;

        Console.WriteLine("HarfSayisi: " + harfSayac);
        Console.WriteLine("KelimeSayisi: " + kelimeSayac);

       

        


        


        
       




    
    
    }

}