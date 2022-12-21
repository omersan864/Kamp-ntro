using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace samples
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            MyDictionary<string> lectures= new MyDictionary<string>();
            lectures.Add("artifical intelligence");
            lectures.Add("Decision Supoort System");
            lectures.Add("Management Informatıon System");
            lectures.Add("Mobil App");
            Console.WriteLine(lectures.count);

            foreach (var item in lectures._array)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
