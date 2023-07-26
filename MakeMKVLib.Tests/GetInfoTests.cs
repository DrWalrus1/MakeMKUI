using MakeMKVLib.Models;
using MakeMKVLib.Tests.Stubs;
using DriveInfo = MakeMKVLib.Models.DriveInfo;

namespace MakeMKVLib.Tests;

public class GetInfoTests
{
    private IMakeMkv _makeMkv = new StubbedDrive();


    [Fact]
    public void SuccessfullyGetDriveInfo()
    {

        //Act
        var info = _makeMkv.ReadDrive(0);
        
        //Assert
        Assert.Equal("ASUS 4K Blu-ray Player", info.driveName);
        Assert.Equal("Get Out", info.diskName);
    }
    [Fact]
    public void SuccessfullyGetSecondDriveInfo()
    {
        //Act
        var info = _makeMkv.ReadDrive(1);
        
        //Assert
        Assert.Equal("Some LG Optical Drive", info.driveName);
        Assert.Equal("John Wick Chapter 4", info.diskName);
    }
    
}