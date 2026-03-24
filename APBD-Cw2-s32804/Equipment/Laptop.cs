namespace APBD_Cw2_s32804;

public class Laptop : Equipment
{
    public int RamGb { get; set; }
    public string Cpu { get; set; }

    public Laptop(string name, int ramGb, string cpu)
        : base(name)
    {
        RamGb = ramGb;
        Cpu = cpu;
    }
}