namespace MakeMKVLib.Models.MakeMKV.Sources;

public interface IDriveSources
{
    IEnumerable<DriveInfo> GetOpticalDrives();
}