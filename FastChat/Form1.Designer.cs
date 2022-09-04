namespace FastChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ServerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ServerPortTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerPortLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ServerIPTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServerIPLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ServerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ConnectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ClientPortTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientPortLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientIPTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientIPLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MessageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChatScreenTextBox = new System.Windows.Forms.ListBox();
            this.ServerPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerPanel
            // 
            this.ServerPanel.Controls.Add(this.ServerPortTextBox);
            this.ServerPanel.Controls.Add(this.ServerPortLabel);
            this.ServerPanel.Controls.Add(this.ServerIPTextBox);
            this.ServerPanel.Controls.Add(this.ServerIPLabel);
            this.ServerPanel.Controls.Add(this.ServerLabel);
            this.ServerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerPanel.Location = new System.Drawing.Point(0, 0);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(809, 116);
            this.ServerPanel.TabIndex = 0;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerPortTextBox.DefaultText = "";
            this.ServerPortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerPortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerPortTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerPortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPortTextBox.Location = new System.Drawing.Point(464, 47);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.PasswordChar = '\0';
            this.ServerPortTextBox.PlaceholderText = "";
            this.ServerPortTextBox.SelectedText = "";
            this.ServerPortTextBox.Size = new System.Drawing.Size(200, 32);
            this.ServerPortTextBox.TabIndex = 4;
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServerPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortLabel.Location = new System.Drawing.Point(393, 51);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(41, 18);
            this.ServerPortLabel.TabIndex = 3;
            this.ServerPortLabel.Text = "PORT";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerIPTextBox.DefaultText = "";
            this.ServerIPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerIPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerIPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerIPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerIPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerIPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerIPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerIPTextBox.Location = new System.Drawing.Point(121, 47);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.PasswordChar = '\0';
            this.ServerIPTextBox.PlaceholderText = "";
            this.ServerIPTextBox.SelectedText = "";
            this.ServerIPTextBox.Size = new System.Drawing.Size(200, 32);
            this.ServerIPTextBox.TabIndex = 2;
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServerIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPLabel.Location = new System.Drawing.Point(69, 51);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(15, 18);
            this.ServerIPLabel.TabIndex = 1;
            this.ServerIPLabel.Text = "IP";
            // 
            // ServerLabel
            // 
            this.ServerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLabel.Location = new System.Drawing.Point(25, 17);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(49, 18);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ConnectBtn);
            this.guna2Panel1.Controls.Add(this.ClientPortTextBox);
            this.guna2Panel1.Controls.Add(this.ClientPortLabel);
            this.guna2Panel1.Controls.Add(this.ClientIPTextBox);
            this.guna2Panel1.Controls.Add(this.ClientIPLabel);
            this.guna2Panel1.Controls.Add(this.ClientLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 116);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(809, 116);
            this.guna2Panel1.TabIndex = 1;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BorderThickness = 1;
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConnectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConnectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConnectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConnectBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConnectBtn.ForeColor = System.Drawing.Color.Black;
            this.ConnectBtn.Location = new System.Drawing.Point(691, 39);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(103, 45);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "CONNECT";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ClientPortTextBox
            // 
            this.ClientPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientPortTextBox.DefaultText = "";
            this.ClientPortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientPortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientPortTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientPortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientPortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientPortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientPortTextBox.Location = new System.Drawing.Point(464, 47);
            this.ClientPortTextBox.Name = "ClientPortTextBox";
            this.ClientPortTextBox.PasswordChar = '\0';
            this.ClientPortTextBox.PlaceholderText = "";
            this.ClientPortTextBox.SelectedText = "";
            this.ClientPortTextBox.Size = new System.Drawing.Size(200, 32);
            this.ClientPortTextBox.TabIndex = 4;
            // 
            // ClientPortLabel
            // 
            this.ClientPortLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPortLabel.Location = new System.Drawing.Point(393, 51);
            this.ClientPortLabel.Name = "ClientPortLabel";
            this.ClientPortLabel.Size = new System.Drawing.Size(41, 18);
            this.ClientPortLabel.TabIndex = 3;
            this.ClientPortLabel.Text = "PORT";
            // 
            // ClientIPTextBox
            // 
            this.ClientIPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientIPTextBox.DefaultText = "";
            this.ClientIPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientIPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientIPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientIPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientIPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientIPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientIPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientIPTextBox.Location = new System.Drawing.Point(121, 47);
            this.ClientIPTextBox.Name = "ClientIPTextBox";
            this.ClientIPTextBox.PasswordChar = '\0';
            this.ClientIPTextBox.PlaceholderText = "";
            this.ClientIPTextBox.SelectedText = "";
            this.ClientIPTextBox.Size = new System.Drawing.Size(200, 32);
            this.ClientIPTextBox.TabIndex = 2;
            // 
            // ClientIPLabel
            // 
            this.ClientIPLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIPLabel.Location = new System.Drawing.Point(69, 51);
            this.ClientIPLabel.Name = "ClientIPLabel";
            this.ClientIPLabel.Size = new System.Drawing.Size(15, 18);
            this.ClientIPLabel.TabIndex = 1;
            this.ClientIPLabel.Text = "IP";
            // 
            // ClientLabel
            // 
            this.ClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLabel.Location = new System.Drawing.Point(25, 17);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(42, 18);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Client";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.SendBtn);
            this.guna2Panel2.Controls.Add(this.MessageTextBox);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 529);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(809, 116);
            this.guna2Panel2.TabIndex = 3;
            // 
            // SendBtn
            // 
            this.SendBtn.BorderThickness = 1;
            this.SendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SendBtn.ForeColor = System.Drawing.Color.Black;
            this.SendBtn.Location = new System.Drawing.Point(679, 27);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(103, 57);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "SEND";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.DefaultText = "";
            this.MessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageTextBox.Location = new System.Drawing.Point(34, 27);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.PlaceholderText = "";
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.Size = new System.Drawing.Size(630, 57);
            this.MessageTextBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ChatScreenTextBox
            // 
            this.ChatScreenTextBox.FormattingEnabled = true;
            this.ChatScreenTextBox.Location = new System.Drawing.Point(34, 261);
            this.ChatScreenTextBox.Name = "ChatScreenTextBox";
            this.ChatScreenTextBox.Size = new System.Drawing.Size(748, 238);
            this.ChatScreenTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(809, 645);
            this.Controls.Add(this.ChatScreenTextBox);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ServerPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ServerPanel.ResumeLayout(false);
            this.ServerPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel ServerPanel;
        private Guna.UI2.WinForms.Guna2TextBox ServerPortTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ServerPortLabel;
        private Guna.UI2.WinForms.Guna2TextBox ServerIPTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ServerIPLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ServerLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ConnectBtn;
        private Guna.UI2.WinForms.Guna2TextBox ClientPortTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ClientPortLabel;
        private Guna.UI2.WinForms.Guna2TextBox ClientIPTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ClientIPLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ClientLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button SendBtn;
        private Guna.UI2.WinForms.Guna2TextBox MessageTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox ChatScreenTextBox;
    }
}

