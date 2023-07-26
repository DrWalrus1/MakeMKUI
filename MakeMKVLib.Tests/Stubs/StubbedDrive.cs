using MakeMKVLib.Models;
using DriveInfo = MakeMKVLib.Models.DriveInfo;

namespace MakeMKVLib.Tests.Stubs;

public class StubbedDrive : IMakeMkv
{
    public DriveInfo ReadDrive(int driveNumber)
    {
        if (driveNumber == 0)
        {
            return new DriveInfo
            {
                driveName = "ASUS 4K Blu-ray Player",
                diskName = "Get Out"
            };
        }

        return new DriveInfo
        {
            driveName = "Some LG Optical Drive",
            diskName = "John Wick Chapter 4"
        };
    }
}