internal class Program
{
    public static void Main(string[] args)
    {
        // recursive = Oz yineleme
        // 3^4


        int result = 1;
        for (int i = 1; i <= 4; i++)
        result = result * 3;
        Console.WriteLine(result);
        Islemler instance = new ();
        Console.WriteLine(instance.expo(3,4));

        // Extension Methods
        string ifade = "Ferit Korkmaz";
        bool sonuc = ifade.checkSpaces();
        Console.WriteLine(sonuc);
        if(sonuc) 
        {
            Console.WriteLine(ifade.removeWhiteSpaces());
        }
        Console.WriteLine(ifade.makeUpperCase());


        int [] dizi = {0,1,2,9,7,5,3};
        dizi.SortArray();
        dizi.ekranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.isEvent());


        Console.WriteLine(ifade.getFirstChar());
        


    }    
}

public class Islemler 
{
     public int expo(int sayi, int üs)
     {
        if (üs < 2)
        {
            return sayi;
        }
        return expo(sayi, üs - 1) * sayi; 
     }
     // expo(3,4)
     // expo(3,3) * 3;
     // expo(3,2) * 3 * 3;
     // expo(3,1) * 3 * 3 * 3;
     // 3 * 3 * 3 * 3= 3^4
}

public static class Extension
{
    public static bool checkSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string removeWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }

    public static string makeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static int [] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    
    public static void ekranaYazdir(this int [] param)
    {
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool isEvent(this int param)
    {
       return param%2 == 0;
    }

    public static string getFirstChar(this string param)
    {
        return param.Substring(0,1);
    }



}
