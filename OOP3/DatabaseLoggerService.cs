using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class DatabaseLoggerService:ILoggerService
    {
        // interface içinde imza methodları olur içi dolu olmaz 
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
