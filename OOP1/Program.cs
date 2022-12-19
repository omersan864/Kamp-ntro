namespace OOP1
{
    class Program
    {
        // class lar ikiye ayrılır içerisinde özellik barındıran ve içerisinde özellik barındıran 
        // Main in olduğu yer anasayfa 

        //işlem sırası 
        // öncelikle product referansı hangi değerleri tutacak onu belirle
        // manager kısmına git ve fonksiyonu kısmen yaz add gibi
        // sonra gel bir tane product ekle
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            // int double bool .... >>> değer tipler olarak gecer  >>> atamalar tamamnen değeri üzerinden olur ve bağlantı kopar
            // class abstract diziler interface  >>> refreans tip olarak gecer 

            Product product2 = new Product { Id=2,CategoryId=5,
            UnitInStock=5,ProductName="Kalem",UnitPrice=35};

            // case sensitive (küçük büyük harf duyarlı )
            // instance creation örnek oluşturma 
            //Pascalcase    //camelCase 
            ProductManager productManager = new ProductManager();
            // stack kısmı                  // heap kısmı 
            
            
            productManager.Add(product1);



            productManager.Topla2(3, 6);

            int toplamaSonucu =productManager.Topla(3,6);
            // return kısmı eşittirden sonrası 
            Console.WriteLine(toplamaSonucu*2) ; // bu kısımda return kullanılır 

        }
    }
}