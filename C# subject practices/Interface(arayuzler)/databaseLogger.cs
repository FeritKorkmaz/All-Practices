namespace Interface
{
    public class databaseLogger : ILogger
    {
        public void writeLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Database a log yazar");
        }
    }
}