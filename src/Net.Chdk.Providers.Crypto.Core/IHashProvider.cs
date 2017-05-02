namespace Net.Chdk.Providers.Crypto
{
    public interface IHashProvider
    {
        string GetHashString(string filePath, string hashName);
    }
}
