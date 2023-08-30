internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;


        // Expression
        switch (month)
        {
            case 1:
                Console.WriteLine("ocak ayindasiniz");
                break;
            
            case 2:
                Console.WriteLine("subat ayindasiniz");
                break;
            
            case 5:
                Console.WriteLine("mayis ayindasiniz");
                break;        

            default:
                Console.WriteLine("yanlis giris yaptiniz");
            break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
            Console.WriteLine("kis ayindasiniz");
            break;

            case 3:
            case 4:
            case 5:
            Console.WriteLine("ilkbahar ayindasiniz");
            break;

            case 6:
            case 7:
            case 8:
            Console.WriteLine("yaz ayindasiniz");
            break;

            case 9:
            case 10:
            case 11:
            Console.WriteLine("sonbahar ayindasiniz");
            break;

            // hic birine uymuyor ise
            default:
            break;
        }
    }
}