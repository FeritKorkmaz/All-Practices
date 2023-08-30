
internal class Program
{
    private static void Main(string[] args)
    {       
        // try
        // {
        //     Console.WriteLine("Bir sayi giriniz");
        //     int sayi = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("girmis oldugunuz sayi" + sayi); 
        // }
        // catch (Exception ex) 
        // {
        //     Console.WriteLine("Hata: " + ex.Message.ToString());
        // }
        // finally
        // {
        //     Console.WriteLine("islem tamamlandi.");
        // }

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-20000000000");


        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("bos deger girdiniz");
            Console.WriteLine(ex);

        }
         catch (FormatException ex)
        {
            Console.WriteLine("veri tipi uygun degil");
            Console.WriteLine(ex);

        }
         catch (OverflowException ex)
        {
            Console.WriteLine("cok kucuk veya buyuk bir deger girdiniz");
            Console.WriteLine(ex);

        }

        finally
        {
            Console.WriteLine("islem basariyla tamamlandi");
        }

    }
}








