using AbstractInterfaceDemo.Abstract;

namespace AbstractInterfaceDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string NatinonalityId { get; set; }
    }
}