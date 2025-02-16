class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual double CalculateBonus()
    {
        return Salary * 0.05; 
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee: {Name}, Salary: ${Salary}, Bonus: ${CalculateBonus()}");
    }
}

class Manager:Employee
{
    public Manager(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.10; 
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Manager: {Name}, Salary: ${Salary}, Bonus: ${CalculateBonus()}");
    }
}

class Director : Employee
{
    public Director(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.20; 
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Director: {Name}, Salary: ${Salary}, Bonus: ${CalculateBonus()}");
    }
}

class EmployeeHierarchy
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee("jayant", 70000);
        emp.DisplayDetails();

        Manager mgr = new Manager("Anurag", 50000);
        mgr.DisplayDetails();

        Director dir = new Director("Mohit pal", 120000);
        dir.DisplayDetails();

    }
}
