namespace interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            // interface new'lenemez 
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            projectManager projectManager = new projectManager();
            IPersonManager internManager = new InternManager();
           projectManager.Add(internManager);
        }
    }

    // class >>>inherits ----------------------- interface >>> implements
    interface IPersonManager
    {
        // implemented opreation // tamamlamış operasyon 
        void Add(); 
        void Update();
        
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("müşteri ekleme :");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
            
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("çalışan ekleme :");
        }

        public void Update()
        {
            Console.WriteLine("çalışan güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajyer güncellendi ");
        }
    }

    class projectManager // tüm projeyi tek noktadan yönetecek bir class oluşturduk     
    {
        //add parametre olarak customer manager alacak ben ona göre eklemeyi yapayım 
        public void Add(IPersonManager personManager) // genel bir add fonk. diğerlerinden bağımsız 
        {
            personManager.Add();
        }
    }
       
       
}