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
        private readonly IFacebookEngine r_AppEngine;

        public AppMainForm()
        {
            r_ApplicationSettings = ApplicationSettings.ApplicationSettingsInstance;
            r_AppEngine = new FacebookAppEngineProxy();

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

    }
}
