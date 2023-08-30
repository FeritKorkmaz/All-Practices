namespace Interface 
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            fileLogger fileLogger = new fileLogger ();
            fileLogger.writeLog();
            //  iki sekildede kullanilabilir bir logmanager olusturup ordan turettiginmiz nesnenin weiteloguna eristik.
            // bu sekilde istedigimiz log seklini log managerin write logu ile yazdirabiliriz.
            LogManager logManager = new LogManager(new fileLogger());
            logManager.writeLog();

            
            

            databaseLogger databaseLogger = new databaseLogger();
            databaseLogger.writeLog();

            smsLogger smsLogger = new();
            smsLogger.writeLog();

            
        }
    }
}