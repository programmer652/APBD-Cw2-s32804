namespace APBD_Cw2_s32804;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting program...\n");

        IService service = new Service();
        
        Student student = new Student("Jan", "Kowalski", "s12345");
        Employee employee = new Employee("Anna", "Nowak", "IT");

        service.AddUser(student);
        service.AddUser(employee);
        
        Camera camera = new Camera("Canon EOS", 24, true);
        Laptop laptop = new Laptop("Dell XPS", 16, "Intel i7");
        Projector projector = new Projector("Epson X200", 3000, true);

        service.AddEquipment(camera);
        service.AddEquipment(laptop);
        service.AddEquipment(projector);
        
        Console.WriteLine("All equipment:");
        foreach (var eq in service.GetAllEquipment())
        {
            Console.WriteLine($"ID: {eq.Id}, Name: {eq.Name}, Available: {eq.IsAvailable}");
        }
        
        Console.WriteLine("\nBorrowing equipment");
        service.Borrow(student, camera, 5);
        service.Borrow(employee, laptop, 3);
        service.Borrow(student, camera, 5);
        
        Console.WriteLine("\nAvailable equipment:");
        foreach (var eq in service.GetAvailableEquipment())
        {
            Console.WriteLine($"{eq.Name}");
        }
        
        Console.WriteLine("\nStudent loans:");
        var studentLoans = service.GetUserLoans(student);
        foreach (var loan in studentLoans)
        {
            Console.WriteLine($"{loan.Equipment.Name}, Due: {loan.DueDate}");
        }
        
        Console.WriteLine("\nReturning equipment");
        var loanToReturn = studentLoans.First();
        service.Return(loanToReturn);
        
        Console.WriteLine("\nReport:");
        service.GenerateReport();

        Console.WriteLine("\nProgram finished.");

    }
}