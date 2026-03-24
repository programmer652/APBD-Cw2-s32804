namespace APBD_Cw2_s32804;

public class Service : IService
{
    private List<User> users = new List<User>();
    private List<Equipment> equipmentList = new List<Equipment>();
    private List<Loan> loans = new List<Loan>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        equipmentList.Add(equipment);
    }

    public List<Equipment> GetAllEquipment()
    {
        return equipmentList;
    }

    public List<Equipment> GetAvailableEquipment()
    {
        return equipmentList.Where(e => e.IsAvailable).ToList();
    }

    public void Borrow(User user, Equipment equipment, int days)
    {
        if (GetLateLoans().Count == 2 & user.GetType() == typeof(Student))
        {
            throw new Exception("Student already has 2 active loans");
            return;
        }

        if (GetLateLoans().Count == 5 & user.GetType() == typeof(Employee))
        {
            throw new Exception("Employee already has 5 active loans");
            return;
        }

        if (equipment.IsAvailable)
        {
            equipment.IsAvailable = false;
            loans.Add(new Loan(user, equipment, days));
        }
        else
            throw new Exception("Not available");
    }

    public void Return(Loan loan)
    {
        loan.ReturnDate = DateTime.Now;
       
        if (loan.IsReturnedOnTime)
        {
            int daysLate = (DateTime.Now.Subtract(loan.ReturnDate.Value).Days);
            Console.WriteLine("late return by: " + daysLate);// late fee rule = daysLate*20 zlotys
            Console.WriteLine("User needs to pay additionally: " + (daysLate*20)+" zlotys");
        }
        loan.Equipment.IsAvailable = true;
        
    }

    public void MarkUnavailable(Equipment equipment)
    {
       equipment.IsAvailable = false;
    }

    public List<Loan> GetUserLoans(User user)
    {
        return loans.Where(l => l.User == user).ToList();
    }

    public List<Loan> GetLateLoans()
    {
        return loans.Where(l => !l.IsReturnedOnTime).ToList();
    }

    public List<Loan> GetActiveLoans()
    {
        return loans.Where(l => l.ReturnDate == null).ToList();
    }
    
    public void GenerateReport()
    {
        Console.WriteLine("Generating report");
        Console.WriteLine("Users: "+users.Count);
        Console.WriteLine("Equipments: "+equipmentList.Count);
        Console.WriteLine("Loans: "+loans.Count);
        Console.WriteLine("Active loans: "+GetActiveLoans().Count);
        Console.WriteLine("Late loans: "+GetLateLoans().Count);
    }
}