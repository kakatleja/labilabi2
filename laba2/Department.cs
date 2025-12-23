using System.Collections.Generic;

public class Department
{
    public string Name { get; }
    public Employee Boss { get; private set; }
    public List<Employee> Employees { get; } = new List<Employee>();

    public Department(string name)
    {
        Name = name;
    }

    public void SetBoss(Employee employee)
    {
        Boss = employee;
    }
}
