namespace InfiniteTyping
{
    partial class InfiniteTyping
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
            this.textToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.textServerID = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.textChannelID = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textToken
            // 
            this.textToken.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textToken.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textToken.Location = new System.Drawing.Point(153, 6);
            this.textToken.Name = "textToken";
            this.textToken.PasswordChar = '•';
            this.textToken.Size = new System.Drawing.Size(413, 23);
            this.textToken.TabIndex = 0;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(12, 9);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(116, 15);
            this.labelToken.TabIndex = 1;
            this.labelToken.Text = "Authenication Token";
            // 
            // textServerID
            // 
            this.textServerID.AutoSize = true;
            this.textServerID.Location = new System.Drawing.Point(12, 45);
            this.textServerID.Name = "textServerID";
            this.textServerID.Size = new System.Drawing.Size(53, 15);
            this.textServerID.TabIndex = 2;
            this.textServerID.Text = "Server ID";
            // 
            // textBoxServer
            // 
            this.textBoxServer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxServer.Location = new System.Drawing.Point(71, 42);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(180, 23);
            this.textBoxServer.TabIndex = 3;
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxChannel.Location = new System.Drawing.Point(386, 42);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(180, 23);
            this.textBoxChannel.TabIndex = 4;
            // 
            // textChannelID
            // 
            this.textChannelID.AutoSize = true;
            this.textChannelID.Location = new System.Drawing.Point(315, 45);
            this.textChannelID.Name = "textChannelID";
            this.textChannelID.Size = new System.Drawing.Size(65, 15);
            this.textChannelID.TabIndex = 5;
            this.textChannelID.Text = "Channel ID";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(93, 269);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(81, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 71);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(554, 192);
            this.logTextBox.TabIndex = 8;
            this.logTextBox.Text = "";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 269);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 277);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(246, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "@ ChillingStar Software | GitHub: ChillingSoft";
            // 
            // InfiniteTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textChannelID);
            this.Controls.Add(this.textBoxChannel);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.textServerID);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.textToken);
            this.Name = "InfiniteTyping";
            this.Text = "InfiniteTyping";
            this.Load += new System.EventHandler(this.InfiniteTyping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textToken;
        private Label labelToken;
        private Label textServerID;
        private TextBox textBoxServer;
        private TextBox textBoxChannel;
        private Label textChannelID;
        private Button buttonCopy;
        private RichTextBox logTextBox;
        private Button buttonRefresh;
        private Label label1;
    }
}