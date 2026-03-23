namespace APBD_Cw2_s32804;

public class Loan
{
    public User User { get; set; }
    public Equipment Equipment { get; set; }

    public DateTime BorrowDate { get; set; }
    public int DurationDays { get; set; }

    public DateTime? ReturnDate { get; set; }

    public DateTime DueDate => BorrowDate.AddDays(DurationDays);

    public bool IsReturnedOnTime
    {
        get
        {
            if (ReturnDate == null) return false;
            return ReturnDate <= DueDate;
        }
    }
}