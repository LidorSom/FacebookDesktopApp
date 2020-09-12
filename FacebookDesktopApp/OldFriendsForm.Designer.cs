namespace FacebookDesktopApp
{
    partial class OldFriendsForm
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
            System.Windows.Forms.Label nameLabel;
            this.OldFriendsListBox = new System.Windows.Forms.ListBox();
            this.oldFriendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.profilePictureUrlPictureBox = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oldFriendBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureUrlPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(80, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // OldFriendsListBox
            // 
            this.OldFriendsListBox.DataSource = this.oldFriendBindingSource;
            this.OldFriendsListBox.FormattingEnabled = true;
            this.OldFriendsListBox.ItemHeight = 16;
            this.OldFriendsListBox.Location = new System.Drawing.Point(85, 94);
            this.OldFriendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.OldFriendsListBox.Name = "OldFriendsListBox";
            this.OldFriendsListBox.Size = new System.Drawing.Size(159, 260);
            this.OldFriendsListBox.TabIndex = 0;
            this.OldFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.OldFriendsListBox_SelectedIndexChanged);
            // 
            // oldFriendBindingSource
            // 
            this.oldFriendBindingSource.DataSource = typeof(FacebookDesktopApp.OldFriend);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(this.profilePictureUrlPictureBox);
            this.panel1.Location = new System.Drawing.Point(331, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 289);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oldFriendBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(208, 18);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(134, 40);
            this.nameLabel1.TabIndex = 1;
            // 
            // profilePictureUrlPictureBox
            // 
            this.profilePictureUrlPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.oldFriendBindingSource, "ProfilePictureUrl", true));
            this.profilePictureUrlPictureBox.Location = new System.Drawing.Point(52, 61);
            this.profilePictureUrlPictureBox.Name = "profilePictureUrlPictureBox";
            this.profilePictureUrlPictureBox.Size = new System.Drawing.Size(256, 217);
            this.profilePictureUrlPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureUrlPictureBox.TabIndex = 3;
            this.profilePictureUrlPictureBox.TabStop = false;
            this.profilePictureUrlPictureBox.Click += new System.EventHandler(this.profilePictureUrlPictureBox_Click_1);
            // 
            // OldFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OldFriendsListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OldFriendsForm";
            this.Text = "OldFriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.oldFriendBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureUrlPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OldFriendsListBox;
        private System.Windows.Forms.BindingSource oldFriendBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox profilePictureUrlPictureBox;
    }
}