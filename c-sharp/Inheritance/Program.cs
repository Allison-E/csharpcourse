using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary secretary = new Secretary("John", "1", 84);
            Programmer programmer = new Programmer("Helen", "2", "python");
            Engineer engineer = new Engineer("Mike", "3", "windows");
            Employee employee = new Employee("Mathilde", "4");

            secretary.display();
            programmer.display();
            engineer.display();
            employee.display();
        }
    }

    class Employee
    {
        protected string name;
        protected string id;

        public Employee(string empname, string empid)
        {
            name = empname;
            id = empid;
        }
        public void display()
        {
           Console.WriteLine("Employee " + name + " has id of " + id + ".");
        }
    }

    class Secretary : Employee
    {
        public int wpm;

        public Secretary(string empname, string empid, int w) : base(empname, empid)
        {
            name = empname;
            id = empid;
            wpm = w;
        }

        public void display()
        {
            Console.WriteLine("Employee " + name + " has id of " + id + "and a wpm of " + wpm + ".");
        }
    }

    class Programmer : Employee
    {
        public string lang;

        public Programmer(string empname, string empid, string l) : base(empname, empid)
        {
            name = empname;
            id = empid;
            lang = l;
        }
    public void display()
    {
        Console.WriteLine("Employee " + name + " has id of " + id + "and codes in " + lang + ".");
    }
}
    class Engineer : Employee
    {
        public string os;

        public Engineer(string empname, string empid, string o) : base(empname, empid)
        {
            name = empname;
            id = empid;
            os = o;
        }
        public void display()
        {
            Console.WriteLine("Employee " + name + " has id of " + id + "and uses " + os + ".");
        }
    }
    
}
