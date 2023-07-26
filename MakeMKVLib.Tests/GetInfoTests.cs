using MakeMKVLib.Models;
using MakeMKVLib.Tests.Stubs;
using DriveInfo = MakeMKVLib.Models.DriveInfo;

namespace MakeMKVLib.Tests;

public class GetInfoTests
{
    private IMakeMkv _makeMkv = new StubbedDrive();


    [Fact]
    public void SuccessfullyGetDriveName()
    {

        //Act
        var info = _makeMkv.ReadDrive(0);
        
        //Assert
        Assert.Equal("ASUS 4K Blu-ray Player", info.driveName);
    }
    
    [Fact]
    public void SuccessfullyGetDiskInfo()
    {

        //Act
        var info = _makeMkv.ReadDrive(0);
        
        //Assert
        Assert.Equal("Get Out", info.diskName);
    }
    
}