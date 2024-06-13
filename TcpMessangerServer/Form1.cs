using Networking;
using System.Text;

namespace TcpMessangerServer
{
    public partial class Form1 : Form
    {
        private TcpServerManager _serverManager;
        public Form1()
        {
            InitializeComponent();
            _serverManager = new TcpServerManager();
            _serverManager.Received += _serverManager_Received;
        }

        private void _serverManager_Received(Request request)
        {
            Request sendReq = new Request();
            string auditMessage = "";
            switch (request.Path)
            {
                case "login":
                    string username = Encoding.UTF8.GetString(request.Data);
                    sendReq.Path = "message";
                    auditMessage = $"User {username} has joined";
                    sendReq.Data = Encoding.UTF8.GetBytes(auditMessage);
                    break;
                case "message":
                    string message = Encoding.UTF8.GetString(request.Data);
                    sendReq.Path = "message";
                    auditMessage = $"{Encoding.UTF8.GetString(request.UserName)}: {Encoding.UTF8.GetString(request.Data)}";
                    sendReq.Data = Encoding.UTF8.GetBytes(auditMessage);
                    break;
                case "file":
                    byte[] file = request.Data;
                    File.WriteAllBytes("test.txt", file);
                    sendReq.Path = "message";
                    auditMessage = $"{Encoding.UTF8.GetString(request.UserName)}: test.txt was downloaded";
                    sendReq.Data = Encoding.UTF8.GetBytes(auditMessage);
                    break;
            }

            this.Invoke(() => audit.Items.Add(auditMessage));
            _serverManager.Send(sendReq);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serverManager.Connect("127.0.0.1", 4545);
        }
    }
}
