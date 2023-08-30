// Implicit conversions(bilincsiz donusum)

internal class Program
{
    private static void Main(string[] args)
    {
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("d: " + d);

        long h = d;
        Console.WriteLine("h: " + h);

        float f = h;
        Console.WriteLine("f: " + f);

        string s = "ferit";
        char ch = 'k';
        object o = s + ch + d;
        Console.WriteLine("o: " + o);

        // explicit conversions(bilincli donusum)
        int x = 4;
        byte by = (byte)x;
        Console.WriteLine("by: " + by);

        float fl = 10.3f;
        byte z = (byte)fl;
        Console.WriteLine("z: " + z);


        // tostring method
        Console.WriteLine("ToString Method");
        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" + zz);

        // System.Convert
        Console.WriteLine("System.Convert sinifi");
        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        toplam = sayi1 + sayi2;
        Console.WriteLine("toplam:" + toplam);

        // Parse 
        Console.WriteLine("Parse");
        parseMethod();  
    }
    public static void parseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1 :" + rakam1);
            Console.WriteLine("double1 :" + double1); 
        }
}