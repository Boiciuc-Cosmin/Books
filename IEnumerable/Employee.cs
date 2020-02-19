namespace IEnumerable
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ Title })";
        }
    }
}