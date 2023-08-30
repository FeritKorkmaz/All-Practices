internal class Program
{
    public static void Main(string[] args)
    {   
        // Gunun tarihi ve Detaylarini Getirirler.
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        // haftanin kacinci gunu ve yılın kacıncı gunu
        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        // tarihi ve zamani uzun ve kisa versiyon seklinde getirir.
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());


        // DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));      // 03
        Console.WriteLine(DateTime.Now.ToString("ddd"));     // Sat
        Console.WriteLine(DateTime.Now.ToString("dddd"));    // Saturday
        Console.WriteLine(DateTime.Now.ToString("MM"));      // 06
        Console.WriteLine(DateTime.Now.ToString("MMM"));     // jun 
        Console.WriteLine(DateTime.Now.ToString("MMMM"));    // June
        Console.WriteLine(DateTime.Now.ToString("yy"));      // 23
        Console.WriteLine(DateTime.Now.ToString("yyyy"));    // 2023gi

        // Math Kutuphanesi
        Console.WriteLine(Math.Abs(-25)); // Mutlak alır.
        Console.WriteLine(Math.Sin(10)); // Sinus alır.
        Console.WriteLine(Math.Cos(10)); // Cosunus alır.
        Console.WriteLine(Math.Tan(10)); // Tanjant alır.

        Console.WriteLine(Math.Ceiling(22.3)); // Yukari Yuvarlar. 23
        Console.WriteLine(Math.Round(22.3)); // Yakina Yuvarlar.   22
        Console.WriteLine(Math.Round(22.7)); // Yakina Yuvarlar.   23
        Console.WriteLine(Math.Floor(22.7)); // Asagi Yuvarlar.    22

        Console.WriteLine(Math.Min(10,6)); // 6 verir.
        Console.WriteLine(Math.Max(10,6)); // 10 verir.

        Console.WriteLine(Math.Pow(3,4)); // 3^4'u verir. 81
        Console.WriteLine(Math.Sqrt(9)); // karakok alır. 3
        Console.WriteLine(Math.Log(9)); // 9un e tabanindaki logoritmik karsiligini getirir.
        Console.WriteLine(Math.Exp(3)); // e uzeri 3'u verir.
        Console.WriteLine(Math.Log10(10)); // 10 sayisisnin log 10 tabaninda karsiligini verir.














        


        

        

    }
}