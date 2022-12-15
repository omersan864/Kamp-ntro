// See https://aka.ms/new-console-template for more information
namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "omer";
            int yas = 22;
            // kurs tipi aşağıda sınıfda olan yapıları içinde tutuyor 
            Kurs kurs1=new Kurs();
            kurs1.Kursadi = "c#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "java";
            kurs2.egitmen = "Kerem Yavaş";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "python";
            kurs3.egitmen = "ömer şan";
            kurs3.IzlenmeOranı = 81;

            Kurs kurs4 = new Kurs ();
            kurs4.Kursadi = "dta";
            Console.WriteLine(kurs1.egitmen + ":" + kurs1.Kursadi);

            // bu yapıyı kurduğumuzda normalde içinde string tutarken
            // bu yapıda 3 tip tutabiliriz 
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            kurslar.Append(kurs4);

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi);
                //Console.WriteLine(kurs1.egitmen + ":" + kurs1.Kursadi);

            }

          

        }
    }


    class Kurs
    {
        // 3 bilgiyi tutan bir tip tanımladık 
        public string Kursadi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

        


    }
}
