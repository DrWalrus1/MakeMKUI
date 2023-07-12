using MakeMKVLib.Models.Sources;

namespace MakeMKVLib.Models;

public abstract class BaseMakeMkv<T> : IMakeMkv<T> where T : Source
{
    protected int sourceId;
    public T source;
    
}