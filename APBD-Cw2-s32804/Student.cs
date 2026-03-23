namespace APBD_Cw2_s32804;

public class Student : User
{
    public string StudentNumber { get; set; }

    public Student(string firstName, string lastName, string studentNumber)
        : base(firstName, lastName)
    {
        StudentNumber = studentNumber;
    }
}