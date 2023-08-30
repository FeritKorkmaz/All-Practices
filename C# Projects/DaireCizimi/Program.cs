internal class Program
{
    static void Main(string[] args)
    {  
        Console.Write("Radius giriniz: ");
        DrawCircle(Convert.ToInt32(Console.ReadLine()));        

    }
    public static void DrawCircle(int radius)
    {
        int centerOfX = 30; // X coordinate of center of circle
        int centerOfY = 10; // Y coordinate of center of circle
            // radius of circle

        // Draw circle
        for (int y = centerOfY - radius; y <= centerOfY + radius; y++)
        {
            for (int x = centerOfX - radius; x <= centerOfX + radius; x++)
            {
                double d = Math.Sqrt(Math.Pow(x - centerOfX, 2) + Math.Pow(y - centerOfY, 2));
                if (d < radius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

	
}

