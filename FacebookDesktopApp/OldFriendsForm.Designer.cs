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
            this.OldFriendsListBox = new System.Windows.Forms.ListBox();
            this.OldFriendPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OldFriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OldFriendsListBox
            // 
            this.OldFriendsListBox.FormattingEnabled = true;
            this.OldFriendsListBox.Location = new System.Drawing.Point(64, 76);
            this.OldFriendsListBox.Name = "OldFriendsListBox";
            this.OldFriendsListBox.Size = new System.Drawing.Size(120, 212);
            this.OldFriendsListBox.TabIndex = 0;
            this.OldFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.OldFriendsListBox_SelectedIndexChanged);
            // 
            // OldFriendPictureBox
            // 
            this.OldFriendPictureBox.Location = new System.Drawing.Point(320, 76);
            this.OldFriendPictureBox.Name = "OldFriendPictureBox";
            this.OldFriendPictureBox.Size = new System.Drawing.Size(176, 194);
            this.OldFriendPictureBox.TabIndex = 1;
            this.OldFriendPictureBox.TabStop = false;
            // 
            // OldFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OldFriendPictureBox);
            this.Controls.Add(this.OldFriendsListBox);
            this.Name = "OldFriendsForm";
            this.Text = "OldFriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.OldFriendPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OldFriendsListBox;
        private System.Windows.Forms.PictureBox OldFriendPictureBox;
    }
}