//namespace Product
//{
//    class pc
//    {
//        static void Main(string[] args)
//        {

//            // info olarak  bir değişken değeri tutucu tanımladım info adı 4 tane değer tutuyor  
//            info product1 = new info(); // birinci ürünü product1 olarak girdim 
//            product1.cihaz_adi = "MSI";
//            product1.fiyat = 10000;
//            product1.detay = "sağlam makina";
//            product1.satici = "semih kaya satar";

//            info product2 = new info();
//            product2.cihaz_adi = "dell";
//            product2.fiyat = 13000;
//            product2.detay = "güzel para";
//            product2.satici = "ömer şan";

//            info product3 = new info();
//            product3.cihaz_adi = "lenovo";
//            product3.detay = "emektar";
//            product3.fiyat = 4500;
//            product3.satici = "ömer şann";

//            info product4 = new info();
//            product4.cihaz_adi = "asus";
//            product4.detay = "emektar";
//            product4.fiyat = 4500;
//            product4.satici = "ömer şann";

//            Console.WriteLine(product3.cihaz_adi + ":" + product3.fiyat);   

//            info[] products= new info[] {product1,product2,product3,product4};  // products adında bir array oluşturdum  türü info olan 

//            foreach (var product in products) // products array inin içinde product olarak gezin ve her product değerinin cihaz_adı özelliğini yazdır 
//            {
//                Console.WriteLine(product.cihaz_adi);
//            }

            
//            for (int i=0 ; i < products.Length; i++) // i değerini bir bir arttır products array değeri kadar dönecek 
//            {
//                Console.WriteLine(products[i].cihaz_adi);
//            }

//        }
//    }
//    class info
//    {
//        // ürün bilgilerini tutmak için bir sınıf olşturduk 
//        // bu sınıf içinde hangi bilgileri tutmak istiyorsak onları belirledik

//        public string cihaz_adi { get; set; }
//        public int fiyat { get; set; }
//        public string detay { get; set; }
//        public string satici { get; set; }
//    }
//}
