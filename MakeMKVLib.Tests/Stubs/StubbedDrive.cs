using MakeMKVLib.Models;
using DriveInfo = MakeMKVLib.Models.DriveInfo;

namespace MakeMKVLib.Tests.Stubs;

public class StubbedDrive : IMakeMkv
{
    public DriveInfo ReadDrive(int driveNumber)
    {
        return new DriveInfo
        {
            driveName = "ASUS 4K Blu-ray Player",
            diskName = "Get Out"
        };
    }
}