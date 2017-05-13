using System.IO;

namespace Net.Chdk.Providers.Crypto
{
    public interface IHashProvider
    {
        string GetHashString(Stream stream, string hashName);
        string GetHashString(byte[] buffer, string hashName);
    }
}
