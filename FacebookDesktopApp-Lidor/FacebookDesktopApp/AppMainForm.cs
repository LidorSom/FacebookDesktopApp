﻿using System;
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

            AppMenuForm menuForm = new AppMenuForm() { AppEngine = r_AppEngine };
            menuForm.ShowDialog();
        }

        private void updateFormButtonsWithLogin()
        {
            LoginButton.Visible = false;
            AutoLogin.Visible = false;
            LogOutButton.Visible = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
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

        private void updateFormButtonsWithLogout()
        {
            LogOutButton.Visible = false;
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
    }
}