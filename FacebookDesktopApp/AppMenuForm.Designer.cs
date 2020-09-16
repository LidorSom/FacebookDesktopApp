namespace FacebookDesktopApp
{
    public partial class AppMenuForm
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
            this.MyProfileButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.photosButton = new System.Windows.Forms.Button();
            this.CheckInsButton = new System.Windows.Forms.Button();
            this.PrivacyReportButton = new System.Windows.Forms.Button();
            this.LikesCounterButton = new System.Windows.Forms.Button();
            this.OldFriendsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyProfileButton
            // 
            this.MyProfileButton.AccessibleName = "myProfileButton";
            this.MyProfileButton.Location = new System.Drawing.Point(224, 8);
            this.MyProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyProfileButton.Name = "MyProfileButton";
            this.MyProfileButton.Size = new System.Drawing.Size(89, 27);
            this.MyProfileButton.TabIndex = 0;
            this.MyProfileButton.Text = "Profile";
            this.MyProfileButton.UseVisualStyleBackColor = true;
            this.MyProfileButton.Click += new System.EventHandler(this.myProfileButtonPressed);
            // 
            // postButton
            // 
            this.postButton.AccessibleName = "postButton";
            this.postButton.Location = new System.Drawing.Point(224, 105);
            this.postButton.Margin = new System.Windows.Forms.Padding(2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(89, 28);
            this.postButton.TabIndex = 1;
            this.postButton.Text = "Posts";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // friendsButton
            // 
            this.friendsButton.AccessibleName = "friendsButton";
            this.friendsButton.Location = new System.Drawing.Point(224, 39);
            this.friendsButton.Margin = new System.Windows.Forms.Padding(2);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(89, 27);
            this.friendsButton.TabIndex = 2;
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = true;
            this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // photosButton
            // 
            this.photosButton.Location = new System.Drawing.Point(224, 176);
            this.photosButton.Margin = new System.Windows.Forms.Padding(2);
            this.photosButton.Name = "photosButton";
            this.photosButton.Size = new System.Drawing.Size(89, 27);
            this.photosButton.TabIndex = 4;
            this.photosButton.Text = "Photos";
            this.photosButton.UseVisualStyleBackColor = true;
            this.photosButton.Click += new System.EventHandler(this.photosButton_Click);
            // 
            // CheckInsButton
            // 
            this.CheckInsButton.Location = new System.Drawing.Point(224, 207);
            this.CheckInsButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckInsButton.Name = "CheckInsButton";
            this.CheckInsButton.Size = new System.Drawing.Size(89, 27);
            this.CheckInsButton.TabIndex = 5;
            this.CheckInsButton.Text = "CheckIns";
            this.CheckInsButton.UseVisualStyleBackColor = true;
            this.CheckInsButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // PrivacyReportButton
            // 
            this.PrivacyReportButton.AccessibleName = "privacyButton";
            this.PrivacyReportButton.Location = new System.Drawing.Point(224, 238);
            this.PrivacyReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.PrivacyReportButton.Name = "PrivacyReportButton";
            this.PrivacyReportButton.Size = new System.Drawing.Size(89, 27);
            this.PrivacyReportButton.TabIndex = 6;
            this.PrivacyReportButton.Text = "Privacy Report";
            this.PrivacyReportButton.UseVisualStyleBackColor = true;
            this.PrivacyReportButton.Click += new System.EventHandler(this.PrivacyReportButton_Click);
            // 
            // LikesCounterButton
            // 
            this.LikesCounterButton.AccessibleName = "likesCounterButton";
            this.LikesCounterButton.Location = new System.Drawing.Point(224, 137);
            this.LikesCounterButton.Margin = new System.Windows.Forms.Padding(2);
            this.LikesCounterButton.Name = "LikesCounterButton";
            this.LikesCounterButton.Size = new System.Drawing.Size(89, 35);
            this.LikesCounterButton.TabIndex = 7;
            this.LikesCounterButton.Text = "Likes Counter";
            this.LikesCounterButton.UseVisualStyleBackColor = true;
            this.LikesCounterButton.Click += new System.EventHandler(this.LikesCounterButton_Click);
            // 
            // OldFriendsButton
            // 
            this.OldFriendsButton.Location = new System.Drawing.Point(224, 71);
            this.OldFriendsButton.Name = "OldFriendsButton";
            this.OldFriendsButton.Size = new System.Drawing.Size(89, 29);
            this.OldFriendsButton.TabIndex = 8;
            this.OldFriendsButton.Text = "Old Friends";
            this.OldFriendsButton.UseVisualStyleBackColor = true;
            this.OldFriendsButton.Click += new System.EventHandler(this.OldFriendsButton_Click);
            // 
            // AppMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 366);
            this.Controls.Add(this.OldFriendsButton);
            this.Controls.Add(this.LikesCounterButton);
            this.Controls.Add(this.PrivacyReportButton);
            this.Controls.Add(this.CheckInsButton);
            this.Controls.Add(this.photosButton);
            this.Controls.Add(this.friendsButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.MyProfileButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppMenuForm";
            this.Text = "AppMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyProfileButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.Button photosButton;
        private System.Windows.Forms.Button CheckInsButton;
        private System.Windows.Forms.Button PrivacyReportButton;
        private System.Windows.Forms.Button LikesCounterButton;
        private System.Windows.Forms.Button OldFriendsButton;
    }
}