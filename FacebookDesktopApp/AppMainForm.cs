using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class AppMainForm : Form
    {
        private readonly ApplicationSettings r_ApplicationSettings;
        private readonly FacebookAppEngine r_AppEngine;

        public AppMainForm()
        {
            r_ApplicationSettings = ApplicationSettings.ApplicationSettingsInstance;
            r_AppEngine = new FacebookAppEngine();

            InitializeComponent();
        }

        private void loadApplicationSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Size = r_ApplicationSettings.LastWindowSize;
            this.Location = r_ApplicationSettings.LastWindowLocation;
            this.AutoLogin.Checked = r_ApplicationSettings.AutoLogin;
            r_AppEngine.AccessToken = r_ApplicationSettings.AccessToken;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (r_ApplicationSettings.AccessToken == null)
            {
                r_AppEngine.Login();
            }
            else
            {
                r_AppEngine.AccessToken = r_ApplicationSettings.AccessToken;
                r_AppEngine.Connect();
            }


            AppMenuForm menuForm = new AppMenuForm(){AppEngine = r_AppEngine };
            menuForm.ShowDialog();

        }
    }
}
