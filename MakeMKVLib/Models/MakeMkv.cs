namespace MakeMKVLib.Models;

public class MakeMkv : IMakeMkv 
{
    public DiskInfo ReadDrive(int driveNumber)
    {
        return new DiskInfo("Get Out");
    }
}