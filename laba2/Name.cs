using System.Linq;

public class Name
{
    public string LastName { get; }
    public string FirstName { get; }
    public string MiddleName { get; }

    public Name(string lastName = null, string firstName = null, string middleName = null)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }

    public override string ToString()
    {
        return string.Join(" ",
            new[] { LastName, FirstName, MiddleName }
            .Where(s => !string.IsNullOrEmpty(s)));
    }
}
