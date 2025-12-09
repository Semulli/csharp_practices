namespace MyApp;

public class Employee
{
    private int EmployeeId { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private static int Salary { get; set; }

    static Employee()
    {
        Salary = 6000;
        
    }

    public Employee(int employyeId, string firstName, string lastName)
    {
        EmployeeId = employyeId;
        FirstName = firstName;
        LastName = lastName;
    }

    public void showInfo()
    {
        Console.WriteLine("Show informations");
        Console.WriteLine($"Id: {EmployeeId}");
        Console.WriteLine($"Firstname: {FirstName}");
        Console.WriteLine($"Lastname: {LastName}");
        Console.WriteLine($"Salary: {Salary}");
    }

    public void Zampyap(int zamMiktari)
    {
        Console.WriteLine("kullaniciya maas yapiliyor.....");
        Console.WriteLine($"current salary {Salary + zamMiktari}");
    }
}