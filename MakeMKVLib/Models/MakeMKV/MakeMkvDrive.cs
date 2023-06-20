using MakeMKVLib.Models.Sources;

namespace MakeMKVLib.Models.MakeMKV;

public class MakeMkvDrive : BaseMakeMkv<Drive, DriveInfo>
{

    private int sourceId;
    
    public SourceInfo info;

    public MakeMkvDrive(int sourceId)
    {
        this.sourceId = sourceId;
    }

    public override DriveInfo ReadInfo()
    {
        return new DriveInfo("ASUS 4K Blu-ray Player");
    }

    public DiskInfo ReadDiskInfo()
    {
        return new DiskInfo("Get Out");
    }
}