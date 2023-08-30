using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // system.collections namespace

        // Array list olusturma ve iceriine eleman atama
        ArrayList list = new ArrayList();
        // list.Add("Ayse");
        // list.Add(2);
        // list.Add(true);
        // list.Add('A');

        // icerisindeki elemanlara erisme
        // Console.WriteLine(list[1]);
        // foreach (var item in list)
        // {
        //     Console.WriteLine(item.ToString());  // item.ToString yapma sebebim kapsullemede boxing unboxing yapmasin diye denedim. Normalde direk Console.Writeline(item) diye yazdirabilirdik.
        // }

        // AddRange methodu
        Console.WriteLine("*****AddRange*****");
        // string[] renkler = {"kirmizi", "sari", "yesil"};
        List<int> sayilar = new List<int>(){1, 3, 7, 9, 55, 2}; 
        // list.AddRange(renkler);
        list.AddRange(sayilar);
        
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Sort
        Console.WriteLine("*****Sort*****");
        //list.Sort();              // Sort buarada hata vermesede calitirinca hata aliriz cünkü arrayin icinde her cesit eleman var siralayamaz. Yorum satirina alıp calistirdik. 


        // Binary Search
        Console.WriteLine("*****Binary Search*********");        
        Console.WriteLine(list.BinarySearch(9));

        // Reverse  aynalama
        Console.WriteLine("*****Reverse*********");
        list.Reverse();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //Clear temizleme
        Console.WriteLine("*****Clear temizleme*********");
        list.Clear();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }





    }
}