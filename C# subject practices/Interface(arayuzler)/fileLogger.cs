namespace Interface
{
    public class fileLogger : ILogger
    {
        public void writeLog()
        {
           // throw new NotImplementedException();
            Console.WriteLine("dosyaya log yazar");
        }
    }
}