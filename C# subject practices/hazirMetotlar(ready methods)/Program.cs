internal class Program
{
    public static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hosgeldiniz!";
        string degisken2 = "Dersimiz CSharp";



        // length
        Console.WriteLine(degisken.Length);

        // toUpper toLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        // Concat
        Console.WriteLine(String.Concat(degisken," Merhaba")); // birlestirir

        // Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); // iki degiskenin arasindaki degeri kiyaslar. a = b ise 0 a > b ise 1 a < b ise -1 dondurur
        Console.WriteLine(String.Compare(degisken,degisken2,true)); // kiyaslanan degiskenin buyuk kucuk harf duyarlılıgı true veya false ile belirlenir
        Console.WriteLine(String.Compare(degisken,degisken2,false));

        // Contains
        Console.WriteLine(degisken.Contains(degisken2)); // bool donus yapar. degisken icinde degisken2 var mi
        
        // StartsWith, EndsWith
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // bunun ile bitiyor mu?
        Console.WriteLine(degisken.StartsWith("Hosgeldiniz!")); // bunun ile basliyor mu? boolean
        
        // Indexof :  degisken icinde arar ilk buldugunun indexini geitirir.Sonrasina bakmaz. Bulamazsa -1 doner.
        Console.WriteLine(degisken.IndexOf("CS"));

        // LastIndexOf : bulugu degerin son indexini getirir
        Console.WriteLine(degisken.LastIndexOf("i"));

        // Insert : belirttigin indexten sonrasina eklemek istedigini ekler
        Console.WriteLine(degisken.Insert(0,"Merhaba: "));

        // PadLeft, PadRight : degiskenin sagina veya soluna verilen rakama tamamlayacak kadar bir ey ekleme
        Console.WriteLine(degisken2 + degisken2.PadLeft(30));
        Console.WriteLine(degisken2 + degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken2 + degisken2.PadRight(30));
        Console.WriteLine(degisken2 + degisken2.PadRight(30,'-'));

        // Remove: ilk verilen indexten basla ikinci verilen rakam kadarini sil. 2. deger verilmemise sonuna kadar sil
        Console.WriteLine(degisken.Remove(10)); // 10. indexten sonrasini sil
        Console.WriteLine(degisken.Remove(5,3));// 5 ten basla 3 index sil
        Console.WriteLine(degisken.Remove(0,1));// 0 dan basla 1 index sil

        // Replace : ilk yazilan degerle 2. yazilan degeri degistir.
        Console.WriteLine(degisken.Replace("CSharp", "C#"));
        Console.WriteLine(degisken.Replace(" ", "*"));

        // Split : bosluklardan kes olusan elmanlari diziye at. ornekte dizi olustuktan sonra 1. index i yazdirdik
        Console.WriteLine(degisken.Split(' ')[1]);

        // Substring : remove ile calisma mantigi ayni fakat o silerken bu ise o karakterleri silmeyip getiriyor.Yani geri kalanini siliyor
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));









        
        







        
    }
}