namespace FacebookDesktopApp
{
    partial class AppMenuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "myProfileButton";
            this.button1.Location = new System.Drawing.Point(24, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.myProfileButtonPressed);
            // 
            // postButton
            // 
            this.postButton.AccessibleName = "postButton";
            this.postButton.Location = new System.Drawing.Point(24, 69);
            this.postButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(77, 27);
            this.postButton.TabIndex = 1;
            this.postButton.Text = "posts";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // friendsButton
            // 
            this.friendsButton.AccessibleName = "friendsButton";
            this.friendsButton.Location = new System.Drawing.Point(24, 37);
            this.friendsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(77, 27);
            this.friendsButton.TabIndex = 2;
            this.friendsButton.Text = "friends";
            this.friendsButton.UseVisualStyleBackColor = true;
            this.friendsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "pokesButton";
            this.button4.Location = new System.Drawing.Point(24, 101);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "pokes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 164);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "photos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 132);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "checkIns";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AccessibleName = "privacyButton";
            this.button7.Location = new System.Drawing.Point(24, 196);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "Privacy";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AccessibleName = "likesCounterButton";
            this.button8.Location = new System.Drawing.Point(24, 228);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = "Likes Counter";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AccessibleName = "Logout";
            this.button9.Location = new System.Drawing.Point(24, 259);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 29);
            this.button9.TabIndex = 8;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // AppMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.friendsButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppMenuForm";
            this.Text = "AppMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}