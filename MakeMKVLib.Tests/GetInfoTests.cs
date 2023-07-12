using MakeMKVLib.Models;
using MakeMKVLib.Models.MakeMKV;
using MakeMKVLib.Models.MakeMKV.Sources;
using Xunit.Abstractions;

namespace MakeMKVLib.Tests;

public class GetInfoTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public GetInfoTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GetAllDrives()
    {
        var driveSources = new MakeMkvDriveSources().GetOpticalDrives();

        Assert.Equal(@"G:\", driveSources.First().VolumeLabel);
    }
    
    [Fact]
    public void SuccessfullyGetDriveName()
    {
        // Arrange
        MakeMkvDrive drive = new MakeMkvDrive(0);
        
        //Act
        DriveInfo info = drive.ReadInfo();
        
        //Assert
        // Assert.Equal("ASUS 4K Blu-ray Player", info.driveName);
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