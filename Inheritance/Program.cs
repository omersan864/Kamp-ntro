namespace Inheritance
{ //kalıtım 
    class Program
    {
        public static void Main (string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="ömer"},
                new Student{FirstName="Şan"},
                new Person{FirstName="onur"}
               
            };
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

  

    class Customer:Person
    {
        public string City { get; set; }

    }

    class Student : Person
    {
        public string  Department { get; set; }
    }
}