using MakeMKVLib.Models;

namespace MakeMKVLib.Tests;

public class GetDiskInfoTest
{
    [Fact]
    public void SuccessfullyGetDiskInfo()
    {
        // Arrange
        IMakeMkv makeMKV = new MakeMkv();
        
        //Act
        DiskInfo info = makeMKV.ReadDrive(0);
        
        //Assert
        Assert.Equal("Get Out", info.diskName);
    }
}