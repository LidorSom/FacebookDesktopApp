using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class OldFriendsForm : Form
    {
        private readonly OldFriendsFacade r_AppEngine = new OldFriendsFacade();

        public OldFriendsForm()
        {
            r_AppEngine.UpdatingOldFriends += addOldFriends;
            InitializeComponent();
        }

        private void addOldFriends(List<OldFriend> i_OldFriends)
        {
            oldFriendBindingSource.DataSource = i_OldFriends;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(() => r_AppEngine.FetchOldFriends());
            thread.Start();
        }

        private void OldFriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void profilePictureUrlPictureBox_Click_1(object sender, EventArgs e)
        {
        }
    }
}