namespace APBD_Cw2_s32804;

public class Camera : Equipment
{
    public int ResolutionMp { get; set; }
    public bool HasVideo { get; set; }

    public Camera(string name, int resolutionMp, bool hasVideo)
        : base(name)
    {
        ResolutionMp = resolutionMp;
        HasVideo = hasVideo;
    }
}