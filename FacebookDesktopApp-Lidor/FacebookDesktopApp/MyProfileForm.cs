using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class MyProfileForm : Form
    {
        public  FacebookAppEngine AppEngine { get; set; }
        
        public MyProfileForm(FacebookAppEngine i_FacebookAppEngine)
        {
            AppEngine = i_FacebookAppEngine;
            AppEngine.updateUserDetails += updateBindingSource;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(()=> AppEngine.FetchUserDetails()));
            thread.Start();
        }

        private void updateBindingSource(User i_User)
        {
            userBindingSource.DataSource = i_User;
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureNormalURLPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void imageNormalPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void imageNormalLabel_Click(object sender, EventArgs e)
        {

        }

        private void imageNormalPictureBox_Click_1(object sender, EventArgs e)
        {

        }
    }
}
