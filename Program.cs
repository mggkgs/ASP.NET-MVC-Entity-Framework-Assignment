using System;

// Employee class with Id, FirstName, and LastName properties
public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize properties
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overloading the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) && employee1.Id == employee2.Id;
    }

    // Overloading the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Invert the result of the "==" operator
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee(1, "John", "Doe");
        Employee employee2 = new Employee(2, "Jane", "Doe");

        // Compare the two Employee objects using the overloaded operators
        bool areEqual = employee1 == employee2;

        // Display the results
        Console.WriteLine("Employees are equal: " + areEqual);
    }
}