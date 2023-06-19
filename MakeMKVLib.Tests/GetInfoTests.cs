using MakeMKVLib.Models;

namespace MakeMKVLib.Tests;

public class GetInfoTests
{
    [Fact]
    public void SuccessfullyGetDriveName()
    {
        // Arrange
        IMakeMkv makeMkv = new BaseMakeMkv();
        
        //Act
        DriveInfo info = makeMkv.ReadDrive(0);
        
        //Assert
        Assert.Equal("ASUS 4K Blu-ray Player", info.driveName);
    }
    
    [Fact]
    public void SuccessfullyGetDiskInfo()
    {
        // Arrange
        IMakeMkv makeMkv = new BaseMakeMkv();
        
        //Act
        DiskInfo info = makeMkv.ReadDrive(0);
        
        //Assert
        Assert.Equal("Get Out", info.diskName);
    }
    
}