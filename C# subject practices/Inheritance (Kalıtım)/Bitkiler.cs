public class bitkiler:canlilar
{
    protected void fotosentez() // erisim belirtecini protected e cevirdik ki fotosenteze sadece bitkiler ve mirascilari erissin
    {
        Console.WriteLine("Bitkiler fotosentez yapar");
    }
}
public class tohumluBitkiler:bitkiler
{
    // fotosenteze erismek icin base ile kurucu metot(constructor) a ekliyoruz
    public tohumluBitkiler()
    {
        base.fotosentez();
    }
    public void tohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla cogalir");
    }

}
public class tohumsuzBitkiler:bitkiler
{
    // fotosenteze erismek
    public tohumsuzBitkiler()
    {
        base.fotosentez();
    }
    public void sporlaCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
    }

}
    
    
 
