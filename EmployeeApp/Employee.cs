// Employee class inherits from IQuittable
using System;

public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementing the Quit method from IQuittable interface
    public void Quit()
    {
        // Custom implementation of Quit method
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}
