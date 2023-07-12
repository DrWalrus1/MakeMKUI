using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace MakeMKVLib.Models;

public abstract class BaseScanMessage<T>
{
    protected abstract string LogCode { get; }

    public abstract T ParseCsvLine(CsvReader reader);
}