using MakeMKVLib.Models.Sources;

namespace MakeMKVLib.Models;

public abstract class BaseMakeMkv<T, W> : IMakeMkv<T, W> where T : Source where W : SourceInfo
{
    protected int sourceId;
    public T source;

    public abstract W ReadInfo();
}