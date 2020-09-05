using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using  System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class FriendsForm : Form
    {
        private FacebookAppEngine AppEngine;
        public FriendsForm(FacebookAppEngine i_AppEngine)
        {
            AppEngine = i_AppEngine;
            AppEngine.UpdatingFriendsList += updateFriendsList;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread =  new Thread(new ThreadStart(()=> AppEngine.FetchFriends()));
            thread.Start();
        }

        

        private void updateFriendsList(FacebookObjectCollection<User> i_User)
        {
            userBindingSource.DataSource = i_User;
        }


        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void friendsListBox_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void friendsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }
    }
}
