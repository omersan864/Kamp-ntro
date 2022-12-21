namespace OOP3
{
    public class FileLoggerService : ILoggerService
    {
        // interface içinde imza methodları olur içi dolu olmaz 
        public void Log()
        {
            Console.WriteLine("Dosyaya  loglandı");
        }
    }
}
