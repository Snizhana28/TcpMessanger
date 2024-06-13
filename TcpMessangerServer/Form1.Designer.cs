namespace TcpMessangerServer
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
            audit = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // audit
            // 
            audit.BackColor = Color.FromArgb(242, 249, 249);
            audit.Font = new Font("Segoe UI", 12F);
            audit.FormattingEnabled = true;
            audit.ItemHeight = 28;
            audit.Location = new Point(10, 106);
            audit.Margin = new Padding(2, 2, 2, 2);
            audit.Name = "audit";
            audit.Size = new Size(966, 396);
            audit.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(191, 224, 226);
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(14, 14);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(246, 50);
            button1.TabIndex = 1;
            button1.Text = "Start Server";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 239, 240);
            ClientSize = new Size(984, 539);
            Controls.Add(button1);
            Controls.Add(audit);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListBox audit;
        private Button button1;
    }
}
