using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace MakeMKVLib.Models;

public class DriveScanMessage : BaseScanMessage<DriveScanMessage>
{
    protected override string LogCode => "DRV";

    [Index(1)] private bool isVisible;

    [Index(2)] private bool isEnabled;

    [Index(3)] private string flags;

    [Index(4)] private string driveName;

    [Index(5)] private string discName;


    public DriveScanMessage ParseCsvLine(CsvReader reader)
    {
        return reader.GetRecord<DriveScanMessage>();
        // throw new NotImplementedException();
    }
}