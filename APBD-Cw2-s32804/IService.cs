namespace APBD_Cw2_s32804;

public interface IService
{
    void AddUser(User user);
    void AddEquipment(Equipment equipment);

    List<Equipment> GetAllEquipment();
    List<Equipment> GetAvailableEquipment();

    void Borrow(User user, Equipment equipment, int days);
    void Return(Loan loan);

    void MarkUnavailable(Equipment equipment);

    List<Loan> GetUserLoans(User user);
    List<Loan> GetLateLoans();

    void GenerateReport();
}