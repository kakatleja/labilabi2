public class Employee
{
    public string Name { get; }
    public Department Department { get; }

    public Employee(string name, Department department)
    {
        Name = name;
        Department = department;
        department.Employees.Add(this);
    }

    public override string ToString()
    {
        if (Department.Boss == this)
            return $"{Name} начальник отдела {Department.Name}";

        return $"{Name} работает в отделе {Department.Name}, начальник которого {Department.Boss.Name}";
    }
}
