using System.Security.Cryptography.X509Certificates;

namespace AbstractClass
{
    class Program
    {
        // kalıtım implementation 
        static void Main(string[] args)
        {
            Samples samples = new Work();
            samples.X(); // abstract olan sınıfa eriştim 
        }
        abstract class MyClass
        {
            // bu sınıf içerisinde yer alan method ve property'ler bu sınıftan kalıtım alan her sınıfta uygulanmak zorunda
            //abstract property veya methodların gövdeleri tanımlandıkları class içersinde yazılmazlar 
            //sadece imza dediğimiz geri dönüş tipleri isimleri ve erişim belirleyicileri tanımlanabilir
            //gövdeleri kalıtım alan sınıfta override edilerek yazılır
            //abstract elemanlar private olamazlar 
            //class'ın içinde abstract bir yapı bulunacaksa sınıfında abstract olması gerekir   
            //abstract class'lardan nesne yaratılmaz referans noktası alınabilir 

            //public abstract string Name { get; set; }

            //public abstract void X();

        }
        abstract class Samples
        {
            abstract public void X();

            public abstract int Y { get; set; }


        }

        class Work : Samples // her work bir samples ama her samples bir work değil 
        {
            //OVERRİDE olarak tanımlıyor 
            public override int Y { get => throw new NotImplementedException(); 
                                    set => throw new NotImplementedException(); }

            public override void X()
            {
                Console.WriteLine("bu kısım çalışıyor");
            }
        }
    }
}