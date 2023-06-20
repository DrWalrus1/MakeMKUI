using MakeMKVLib.Models;
using MakeMKVLib.Models.MakeMKV;
using DriveInfo = MakeMKVLib.Models.DriveInfo;

namespace MakeMKVLib.Tests;

public class GetInfoTests
{
    [Fact]
    public void SuccessfullyGetDriveName()
    {
        // Arrange
        MakeMkvDrive drive = new MakeMkvDrive(0);
        
        //Act
        DriveInfo info = drive.ReadInfo();
        
        //Assert
        Assert.Equal("ASUS 4K Blu-ray Player", info.driveName);
    }
    
    [Fact]
    public void SuccessfullyGetDiskInfo()
    {
        // Arrange
        MakeMkvDrive drive = new MakeMkvDrive(0);
        
        //Act
        DiskInfo info = drive.ReadDiskInfo();
        
        //Assert
        Assert.Equal("Get Out", info.diskName);
    }
    
}