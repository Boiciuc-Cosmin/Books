using System;
using System.IO;

namespace Books
{
    
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public string GetName()
        {
            return $"{ FirstName } { LastName }";
        }
        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine($"Name changed to '{ this.GetName() }'");
        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }
    class DataStorage
    {
        // Save an employee object to a file
        // named with the Employee name.
        
            public static Employee Load(string firstName, string lastName)
            {
                Employee employee = new Employee();
                // Instantiate a FileStream using FirstNameLastName.d
                // for the filename. FileMode.Open will open
                // an existing file or else report an error.
                FileStream stream = new FileStream(firstName + lastName + ".dat", FileMode.Open);
                // Create a StreamReader for reading text from the fi
                StreamReader reader = new StreamReader(stream);
                // Read each line from the file and place it into
                // the associated property.
                employee.FirstName = reader.ReadLine();
                employee.LastName = reader.ReadLine();
                employee.Salary = reader.ReadLine();
                // Close the StreamReader and its stream.
                reader.Dispose(); // Automatically closes the stream
                return employee;
            }
        
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Create);
            

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            writer.Dispose();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1;
            //Employee employee2 = new Employee();

            //employee2.SetName("Inigo", "Montoya");
            //employee2.Save();
            //IncreaseSalary(employee2);
            //employee1 = DataStorage.Load("Inigo", "Montoya");
            //Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");
            Console.WriteLine("80");
            

            
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}
