namespace ChatClient
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
            this.chatPanel = new System.Windows.Forms.Panel();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.joinChatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.sendMessageButton);
            this.chatPanel.Controls.Add(this.label2);
            this.chatPanel.Controls.Add(this.messageTextBox);
            this.chatPanel.Controls.Add(this.welcomeLabel);
            this.chatPanel.Controls.Add(this.chatListBox);
            this.chatPanel.Location = new System.Drawing.Point(0, 183);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(536, 262);
            this.chatPanel.TabIndex = 0;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(31, 78);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(31, 49);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(197, 22);
            this.messageTextBox.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(220, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(66, 17);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome";
            // 
            // chatListBox
            // 
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.ItemHeight = 16;
            this.chatListBox.Location = new System.Drawing.Point(252, 49);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(272, 196);
            this.chatListBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // joinChatButton
            // 
            this.joinChatButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.joinChatButton.Location = new System.Drawing.Point(182, 138);
            this.joinChatButton.Name = "joinChatButton";
            this.joinChatButton.Size = new System.Drawing.Size(75, 23);
            this.joinChatButton.TabIndex = 2;
            this.joinChatButton.Text = "Join";
            this.joinChatButton.UseVisualStyleBackColor = true;
            this.joinChatButton.Click += new System.EventHandler(this.joinChatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Super Chat program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinChatButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.chatPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListBox chatListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button joinChatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

