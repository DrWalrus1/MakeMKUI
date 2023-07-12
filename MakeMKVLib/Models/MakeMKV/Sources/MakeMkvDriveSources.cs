namespace MakeMKVLib.Models.MakeMKV.Sources;

public class MakeMkvDriveSources : IDriveSources
{
    public IEnumerable<DriveInfo> GetOpticalDrives()
    {
        var logicalDrives = Directory.GetLogicalDrives();

        var opticalDrives = new List<DriveInfo>();

        foreach (var logicalDrive in logicalDrives)
        {
            var driveInfo = new DriveInfo(logicalDrive.ToUpper());

            if (driveInfo.DriveType == DriveType.CDRom)
            {
                opticalDrives.Add(driveInfo);
            }
        }

        return opticalDrives;
    }
}