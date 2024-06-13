namespace TcpMessanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            messageTb = new TextBox();
            listBox = new ListBox();
            tabPage2 = new TabPage();
            connectBtn = new Button();
            nameTb = new TextBox();
            label3 = new Label();
            portTb = new TextBox();
            label2 = new Label();
            addressTb = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1014, 552);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(221, 239, 240);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(messageTb);
            tabPage1.Controls.Add(listBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(1006, 519);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Messanger";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(191, 224, 226);
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(826, 430);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 40);
            button2.TabIndex = 2;
            button2.Text = "Send file";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(191, 224, 226);
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(826, 386);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // messageTb
            // 
            messageTb.BackColor = Color.FromArgb(242, 249, 249);
            messageTb.Font = new Font("Segoe UI", 16F);
            messageTb.Location = new Point(21, 386);
            messageTb.Margin = new Padding(2, 2, 2, 2);
            messageTb.Name = "messageTb";
            messageTb.Size = new Size(779, 43);
            messageTb.TabIndex = 1;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(242, 249, 249);
            listBox.Font = new Font("Segoe UI", 14F);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 31;
            listBox.Location = new Point(21, 22);
            listBox.Margin = new Padding(2, 2, 2, 2);
            listBox.Name = "listBox";
            listBox.Size = new Size(962, 221);
            listBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(221, 239, 240);
            tabPage2.Controls.Add(connectBtn);
            tabPage2.Controls.Add(nameTb);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(portTb);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(addressTb);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(1006, 519);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // connectBtn
            // 
            connectBtn.BackColor = Color.FromArgb(191, 224, 226);
            connectBtn.Font = new Font("Segoe UI", 16F);
            connectBtn.Location = new Point(85, 225);
            connectBtn.Margin = new Padding(2, 2, 2, 2);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(202, 57);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = false;
            connectBtn.Click += connectBtn_Click;
            // 
            // nameTb
            // 
            nameTb.BackColor = Color.FromArgb(242, 249, 249);
            nameTb.Font = new Font("Segoe UI", 16F);
            nameTb.Location = new Point(166, 141);
            nameTb.Margin = new Padding(2, 2, 2, 2);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(229, 43);
            nameTb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(14, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // portTb
            // 
            portTb.BackColor = Color.FromArgb(242, 249, 249);
            portTb.Font = new Font("Segoe UI", 16F);
            portTb.Location = new Point(166, 78);
            portTb.Margin = new Padding(2, 2, 2, 2);
            portTb.Name = "portTb";
            portTb.Size = new Size(229, 43);
            portTb.TabIndex = 1;
            portTb.Text = "4545";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(14, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 37);
            label2.TabIndex = 0;
            label2.Text = "Port";
            // 
            // addressTb
            // 
            addressTb.BackColor = Color.FromArgb(242, 249, 249);
            addressTb.Font = new Font("Segoe UI", 16F);
            addressTb.Location = new Point(166, 21);
            addressTb.Margin = new Padding(2, 2, 2, 2);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(229, 43);
            addressTb.TabIndex = 1;
            addressTb.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(14, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 0;
            label1.Text = "IP Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 239, 240);
            ClientSize = new Size(1014, 552);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "TCP Messanger";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox addressTb;
        private TextBox portTb;
        private Label label2;
        private TextBox nameTb;
        private Label label3;
        private Button connectBtn;
        private ListBox listBox;
        private TextBox messageTb;
        private Button button1;
        private Button button2;
    }
}
