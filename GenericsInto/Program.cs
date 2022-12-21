namespace GenericInto
{
    class Program
    {
        static void Main(string[] args)
        {
            //// generic bir yapıya sahip olduğu için çalışacağı yapıyı belirtmek gerek <string >
            //Mylist<string> isimler = new Mylist<string> ();
            //isimler.add("engin");

            List<string> sehirler = new List<string>();
            //Console.WriteLine(sehirler.Count); // bu bir property method olsa parantez olurdu , count değeri şu an 0 
            sehirler.Add("hatay"); // parantez açıldığında string bir item istiyor
            sehirler.Add("hatay");
            sehirler.Add("hatay");
            sehirler.Add("hatay");
            sehirler.Add("hatay");
            Console.WriteLine(sehirler.Count);

            Mylist<string> sehirler2 = new Mylist<string>();
            sehirler2.Add("hatay");
            sehirler2.Add("hatay");
            sehirler2.Add("hatay");
            sehirler2.Add("hatay");
            sehirler2.Add("hatay");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class Mylist<T>// Generic class 
    {
        T[] _array;
        T[] _tempArray;
        public Mylist()
        {
            _array = new T[0];// 0 elemanlı bir array yapmış olduk 
        }
        public void Add(T item)
        {
            _tempArray = _array;// bu kısımda temparray arayin referansını tutuyor 
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // tutulan iki arrayin değerini birbirine eşitledik 
            }
            _array[_array.Length - 1] = item; // son eklenen elemanın eklenmesi 
        }



        public int Count
        {
            get { return _array.Length; }

        }

    }
}
