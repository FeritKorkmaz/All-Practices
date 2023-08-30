using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;


namespace BarcodeGenerator
{


    internal class Program
    {
        private static void Main(string[] args)
        {
            

            // Bir API örneği oluşturun
            Barcode barcode = new Barcode();

            int imageWidth = 500; // barcode image width
            int imageHigh = 300; // //barcode image height

            Color foreColor = Color.Black; // Color to print barcode
            Color backColor = Color.Transparent; //  Color to print barcode
            
             // numeric string to generate barcode
            Console.Write("Lufen Barkod Numarasini Griniz: ");
            string numericString = Console.ReadLine();

            // Generate the barcode with your settings
            Image barcodeImage = barcode.Encode(TYPE.CODE128, numericString, foreColor, backColor, imageWidth, imageHigh);

            // Store image in some path with the desired format
            // note: you must have permission to save file in the specified path
            barcodeImage.Save(@"D:\Barcode.png", ImageFormat.Png);
            
        }
   
       
    }
    
}
