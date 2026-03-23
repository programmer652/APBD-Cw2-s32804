namespace APBD_Cw2_s32804;

public class Employee :  User
{
    public string Department { get; set; }

    public Employee(string firstName, string lastName, string department)
        : base(firstName, lastName)
    {
        Department = department;
    }
}