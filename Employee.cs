using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Generic_Collections
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }

        //constructor with 4 parameters
        public Employee(int iD, string name, string gender, float salary)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Salary = salary; ;
        }
        // method that prints the objects info
        public void PrintInfo()
        {
            Console.WriteLine($"\nId: {ID}\nName: {Name}\nGender: {Gender}\nSalary: {Salary}");
        }
        //method that counts and outputs how many items is left in the stack myStack
        public void CountStack(Stack <Employee> myStack)
        {
            Console.WriteLine("Items left in stack: " + myStack.Count);
        }
    }
}
