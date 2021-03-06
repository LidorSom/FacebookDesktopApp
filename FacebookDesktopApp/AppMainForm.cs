﻿using System;
using System.Windows.Forms;
using FacebookDesktopAppFacades;

namespace FacebookDesktopApp
{
    public partial class AppMainForm : Form
    {
        private readonly ApplicationSettings r_ApplicationSettings;
        private readonly AppMainFacade r_AppEngine = new AppMainFacade();

        public event Action LoggingIn;

        public event Action LoggingOut;

        public AppMainForm()
        {
            r_ApplicationSettings = ApplicationSettings.ApplicationSettingsInstance;
            LoggingIn += r_AppEngine.Login;
            LoggingOut += r_AppEngine.Logout;
            r_AppEngine.UpdatingSuccessfulLogin += showMenuFormAndUpdateMainForm;
            r_AppEngine.LoggedOutSuccessfully += showSuccessLogoutMessage;
            r_AppEngine.NoticingLoginError += showFailLoginMessage;
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
            try
            {
                LoggingIn.Invoke();

                showMenuFormAndUpdateMainForm();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Couldn't login please try again", exception.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                if (r_ApplicationSettings.AutoLogin && !string.IsNullOrEmpty(r_ApplicationSettings.AccessToken))
                {
                    r_AppEngine.Connect();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please login manually, auto-login didn't succeed: ", exception.Message);
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
                    showFailLogoutMessage(exception.Message);
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

        private void showFailLogoutMessage(string i_errorMessage)
        {
            MessageBox.Show("Log out didn't succeed: ", i_errorMessage);
        }

        private void showFailLoginMessage(string i_errorMessage)
        {
            MessageBox.Show("Login didn't succeed: ", i_errorMessage);

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggingOut.Invoke();
            }
            catch (Exception exception)
            {
                showFailLogoutMessage(exception.Message);
            }

            updateFormButtonsWithLogout();
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
