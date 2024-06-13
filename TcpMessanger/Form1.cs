using Networking;
using System.Text;

namespace TcpMessanger
{
    public partial class Form1 : Form
    {
        private TcpManager _tcpManager;

        public Form1()
        {
            InitializeComponent();
            _tcpManager = new TcpManager();
            _tcpManager.Received += _tcpManager_Received;
        }

        private void _tcpManager_Received(Request request)
        {
            string message = "";
            switch (request.Path)
            {
                case "message":
                    message = Encoding.UTF8.GetString(request.Data);
                    messageTb.Text = "";
                    break;
                case "name":
                    MessageBox.Show("This name is already taken");
                    SetConnectionControlsState(true);
                    break;
            }

            this.Invoke(() => listBox.Items.Add(message));
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTb.Text.Trim()))
                {
                    MessageBox.Show("Enter your name.");
                    return;
                }

                _tcpManager.Connect(addressTb.Text.Trim(), int.Parse(portTb.Text.Trim()));
                Request request = new Request()
                {
                    Path = "login",
                    UserName = Encoding.UTF8.GetBytes(nameTb.Text.Trim()),
                    Data = Encoding.UTF8.GetBytes(nameTb.Text.Trim())
                };
                _tcpManager.Send(request);
                SetConnectionControlsState(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(messageTb.Text.Trim()))
                {
                    MessageBox.Show("Your message is empty.");
                    return;
                }

                Request request = new Request()
                {
                    Path = "message",
                    UserName = Encoding.UTF8.GetBytes(nameTb.Text.Trim()), 
                    Data = Encoding.UTF8.GetBytes(messageTb.Text.Trim())
                };
                _tcpManager.Send(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    using var ms = new MemoryStream();
                    fs.CopyTo(ms);
                    Request request = new Request()
                    {
                        Path = "file",
                        UserName = Encoding.UTF8.GetBytes(nameTb.Text.Trim()),
                        Data = ms.ToArray()
                    };
                    _tcpManager.Send(request);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetConnectionControlsState(bool enabled)
        {
            connectBtn.Enabled = enabled;
            addressTb.Enabled = enabled;
            portTb.Enabled = enabled;
            nameTb.Enabled = enabled;
            button1.Enabled = !enabled;
            button2.Enabled = !enabled;
        }
    }
}
