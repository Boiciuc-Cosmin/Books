using System;
using System.Collections.Generic;
using System.Linq;



namespace IEnumerable
{


    internal class Program
    {
        private static void Main(string[] args)
        {

            IEnumerable<Department> departments = CorporateData.Departments;
            Print(departments);
            Console.WriteLine();
            IEnumerable<Employee> employees = CorporateData.Employees;
            Print(employees);


        }

        public static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}