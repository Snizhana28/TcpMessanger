namespace Networking;

[Serializable]
public class Request
{
    public string Path { get; set; }

    public byte[] UserName { get; set; }
    public byte[] Data { get; set; }
}
