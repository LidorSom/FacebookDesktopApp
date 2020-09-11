
using FacebookDesktopAppFacades;
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
        private readonly AppMainFacade r_AppEngine = new AppMainFacade();

        public AppMainForm()
        {
            r_ApplicationSettings = ApplicationSettings.ApplicationSettingsInstance;
            r_AppEngine.LoggedOutSuccessfully += showSuccessLogoutMessage;
            InitializeComponent();
            loadApplicationSettings();
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
            r_AppEngine.Login();

            showMenuFormAndUpdateMainForm();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (r_ApplicationSettings.AutoLogin && !string.IsNullOrEmpty(r_ApplicationSettings.AccessToken))
            {
                r_AppEngine.Connect();
                showMenuFormAndUpdateMainForm();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_ApplicationSettings.LastWindowSize = this.Size;
            r_ApplicationSettings.LastWindowLocation = this.Location;
            r_ApplicationSettings.AutoLogin = this.AutoLogin.Checked;

            if (r_ApplicationSettings.AutoLogin)
            {
                r_ApplicationSettings.AccessToken = r_AppEngine.AccessToken;
            }
            else
            {
                r_ApplicationSettings.AccessToken = null;
            }

            r_ApplicationSettings.SaveToFile();

            if (!LoginButton.Visible)
            {
                try
                {
                    r_AppEngine.Logout();
                }
                catch (Exception exception)
                {
                    showFailLogoutMessage(exception);
                }
            }

        }

        private void showMenuFormAndUpdateMainForm()
        {
            updateFormButtonsWithLogin();
            Form menuForm = FormFactory.GetForm(eMenuChoice.Menu);
            this.Visible = false;
            menuForm.ShowDialog();
            this.Visible = true;
        }

        private void updateFormButtonsWithLogin()
        {
            LoginButton.Visible = false;
            AutoLogin.Visible = false;
            LogoutButton.Visible = true;
        }

        private void updateFormButtonsWithLogout()
        {
            LogoutButton.Visible = false;
            LoginButton.Visible = true;
            AutoLogin.Visible = true;
        }

        private void showSuccessLogoutMessage()
        {
            MessageBox.Show("Logged out successfully");
        }

        private void showFailLogoutMessage(Exception i_Exception)
        {
            MessageBox.Show("Log out didn't succeed: {0}", i_Exception.Message);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_AppEngine.Logout();
            }
            catch (Exception exception)
            {
                showFailLogoutMessage(exception);
            }

            updateFormButtonsWithLogout();
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
