namespace MakeMKVLib.Models;

public class DriveInfo : SourceInfo
{
    public int driveId;
    public string driveName;

    public DriveInfo(int driveId)
    {
        this.driveId = driveId;
    }

    public DriveInfo(string driveName)
    {
        this.driveName = driveName;
    }
}