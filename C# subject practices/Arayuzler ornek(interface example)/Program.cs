namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            
            

            Civic civic = new Civic();
            Console.WriteLine(civic.hangiMarkaninAraci().ToString());
            Console.WriteLine(civic.kacTekerlektenOlusur());
            Console.WriteLine(civic.standartRengiNe().ToString());
        }
    }
    
}
