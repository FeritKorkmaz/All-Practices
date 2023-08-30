namespace Interface
{
    public class smsLogger : ILogger
    {
        public void writeLog()
        {
           // throw new NotImplementedException();
           Console.WriteLine("sms olarak log yazar");
        }
    }
}