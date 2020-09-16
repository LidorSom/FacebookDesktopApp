namespace FacebookDesktopApp
{
    public partial class AppMainForm
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
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutoLogin
            // 
            this.AutoLogin.AccessibleName = "autoLoginCheckBox";
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Location = new System.Drawing.Point(139, 204);
            this.AutoLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(94, 21);
            this.AutoLogin.TabIndex = 19;
            this.AutoLogin.Text = "AutoLogin";
            this.AutoLogin.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "loginButton";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoginButton.Location = new System.Drawing.Point(291, 194);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(120, 36);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(192, 177);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 36);
            this.LogoutButton.TabIndex = 20;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 401);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AutoLogin);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppMainForm";
            this.Text = "AppMainForm";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}