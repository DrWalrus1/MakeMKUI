namespace MakeMKVLib.Models;

public interface IMakeMkv
{
    DiskInfo ReadDrive(int driveNumber);
}