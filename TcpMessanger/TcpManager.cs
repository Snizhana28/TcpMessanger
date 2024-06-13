using Networking;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TcpMessanger;

public class TcpManager
{
    private NetworkStream _stream;
    private TcpClient _client;
    private IFormatter _formatter = new BinaryFormatter();

    public event Action<Request>? Received;

    public void Connect(string address, int port)
    {
        _client = new TcpClient();
        _client.Connect(IPAddress.Parse("127.0.0.1"), 4545);
        _stream = _client.GetStream();
        Thread thread = new Thread(Listen);
        thread.IsBackground = true;
        thread.Start();
    }

    public void Send(Request request) {
        _stream = _client.GetStream();
        MemoryStream memoryStream = new MemoryStream();
        _formatter.Serialize(memoryStream, request);
        byte[] buffer = memoryStream.ToArray();
        _stream.Write(buffer, 0, buffer.Length);
        _stream.Flush();
    }

    private void Listen()
    {
        StreamReader streamReader;
        while(true)
        {
            if (_stream == null) continue;
            streamReader = new StreamReader(_stream);
            if (_stream.DataAvailable)
            {
                Request request = (Request)_formatter.Deserialize(streamReader.BaseStream);
                Received?.Invoke(request);
            }
        }
    }
}
