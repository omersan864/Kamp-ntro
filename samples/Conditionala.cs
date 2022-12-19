using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samples
{
    // projelere isim verilirken ilk harf büyük harfle başlamalı pascal case isimlendirme 
    public class Conditionala // şartlar 
    {
        //  methodlar bir methodu daha sonra tekrar tekrar kullanmak için  kayıt edilir 
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2(20, 30);
            /*

            int number1 = 20;//
            int number2 = 100;// değer tip olarak geçer değişkenin değeri ile ilgilenilir 

            var result2 = Add3(out number1, number2); // 130 değerini alır sebebi referance değerini kullanmamızdan kaynaklı      
            Console.WriteLine(result2); // ref yerine out da kullanabilirdik 
            Console.Write(number1); // 20 değerini alır 

            */

            // ref ve out farkları 
            // ref parametresinde number1 e bir değer ataman gerekir 
            // out parametresinde böyle bir zorunluluk yoktur 
            // out kullandığımızda number1 değerinin bir kere parametre içinde set edilmesi gerekmektedir 


            int result = Add4(3, 4, 5, 6, 6, 7);

            Console.WriteLine(result);

            Console.WriteLine(Multiply(2, 3, 4));

        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        // default değerlerler her zaman methodların en sonunda olması gerekir 
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        // Overloading aşırı yükleme verilen methodda aynı isimle verilen parametre değerleri arttırma işlemi 
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) // bu kısımda sonradan girilecek sayıları bilmediğimiz için toplama parametresi verdik 
        {
            return numbers.Sum();
        }
    }
}
