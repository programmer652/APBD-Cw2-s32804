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
}