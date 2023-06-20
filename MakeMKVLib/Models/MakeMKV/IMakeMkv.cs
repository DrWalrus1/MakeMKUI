namespace MakeMKVLib.Models;

public interface IMakeMkv<T, W> where T : Source where W : SourceInfo
{
    W ReadInfo();
}