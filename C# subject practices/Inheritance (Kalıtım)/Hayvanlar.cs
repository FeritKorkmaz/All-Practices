public class hayvanlar:canlilar
{
    public void adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir");
    }    
}

public class surungenler:hayvanlar
{
    public void hareket()
    {
        Console.WriteLine("Surungenler surunerek hareket eder");
    }
}

public class kuslar:hayvanlar
{
    public void hareket()
    {
        Console.WriteLine("Kuslar ucar");
    }
}