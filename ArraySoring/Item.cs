namespace ArraySorting;

public class Item
{

    public Item(int id, string firstName, string lastName, decimal salary)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public int Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public decimal Salary { get; private set; }

    public string Name { get { return $"{FirstName} + {LastName}"; } }

    public override string ToString()
    {
        return $"{Id}, {Name}, Salary: {Salary}";
    }

}