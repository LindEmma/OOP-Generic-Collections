namespace OOP___Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates 5 objects from class Employee
            Employee e1 = new Employee(1, "Emma", "female", 35000);
            Employee e2 = new Employee(2, "Edwin", "male", 34000);
            Employee e3 = new Employee(3, "Wynja", "female", 37000);
            Employee e4 = new Employee(4, "Tyra-Lisa", "female", 43000);
            Employee e5 = new Employee(5, "Ken", "male", 22000);

            Console.WriteLine("****STACK****\n");

            //new stack myStack
            Stack<Employee> myStack = new Stack<Employee>();

            // pushes objects into myStack
            myStack.Push(e1);
            myStack.Push(e2);
            myStack.Push(e3);
            myStack.Push(e4);
            myStack.Push(e5);

            Console.WriteLine("All objects in stack:");

            // foreach loop that outputs the info of every object in the stack
            // and count how many that is left
            foreach (var emp in myStack)
            {
                emp.PrintInfo();
                emp.CountStack(myStack);
            }

            Console.WriteLine("\nRetrieve using Pop Method:");

            //value of numberOfItems decide how many times the for loop will run 
            int numberOfItems = myStack.Count();

            // loops through every item in myStack, pop them and prints info. 
            // can not be done with a foreach loop because myStack shrinks in size
            // each time it loops. 
            for (int i = 0; i < numberOfItems; i++)
            {
                var pop = myStack.Pop();
                pop.PrintInfo();
                pop.CountStack(myStack);
            }

            // push objects back in stack
            myStack.Push(e1);
            myStack.Push(e2);
            myStack.Push(e3);
            myStack.Push(e4);
            myStack.Push(e5);

            Console.WriteLine("\nRetrieve two objects using Peek Method");

            // for loop that peeks at top object of myStack two times
            for (int i = 0; i < 2; i++)
            {
                var peek = myStack.Peek();
                peek.PrintInfo();
                peek.CountStack(myStack);
            }

            Console.WriteLine("\n-----------------------------------------\n");

            Console.WriteLine("****LIST****\n");

            List<Employee> myList = new List<Employee>();

            myList.Add(e1);
            myList.Add(e2);
            myList.Add(e3);
            myList.Add(e4);
            myList.Add(e5);

            //Kollar om listan innehåller objektet E5
            if (myList.Contains(e5))
            {
                Console.WriteLine("The list contains object E5\n");
            }
            else
            {
                Console.WriteLine("The list does not contain object E5\n");
            }

            //Finds and outputs info of first object with Gender = "male"
            var maleEmployee = myList.Find(e => e.Gender == "male");

            Console.WriteLine("First male employee: ");
            maleEmployee.PrintInfo();

            //Finds and outputs all objects with Gender = "male" and prints out their info in a foreach-loop
            var maleEmployees = myList.FindAll(m => m.Gender == "male");

            Console.WriteLine("\nAll male employees:");

            foreach (var males in maleEmployees)
            {
                males.PrintInfo();
            }
        }
    }
}