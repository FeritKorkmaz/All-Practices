namespace abstract_ornek
{
    internal class Program
    {

        // interface(Arayüzler) e gore abstract siniflar kalitim almak icin kullanilan siniflardir.
        // Abstract siniflar ile interface te yaptigimiz ornek ayni iken kod yaziminda abstract siniflarin
        // daha sade ve düzenlenebbilir kod yazimi vardir detayli incele.
        private static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.StandartRengiNe());
            Console.WriteLine(focus.kacTekerlektenOlusur());

            Console.WriteLine("***************************");


            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci());
            Console.WriteLine(corolla.StandartRengiNe());
            Console.WriteLine(corolla.kacTekerlektenOlusur());

            Console.WriteLine("***************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.StandartRengiNe());
            Console.WriteLine(civic.kacTekerlektenOlusur());

            Console.WriteLine("***************************");
            
            

            


        }
    } 
}