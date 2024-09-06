// Main program execution
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Employee class
        Employee employee = new Employee() { FirstName = "John", LastName = "Doe" };

        // Using polymorphism: object of type IQuittable
        IQuittable quittable = employee;

        // Calling the Quit method on the IQuittable object
        quittable.Quit();

        // Pausing the console so the output can be seen
        Console.ReadLine();
    }
}
