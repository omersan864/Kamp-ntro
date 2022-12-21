namespace OOP2
{
    // Miras inheratance // müşteri sınıfından Gerçek  müşteriyi miras aldı 

    internal class IndividualCustomer : Customer
    {
        // Gerçek Müşteri 

        public string TcNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
