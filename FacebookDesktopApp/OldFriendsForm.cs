using System;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class OldFriendsForm : Form
    {
        private readonly FacebookAppEngine r_AppEngine;

        public OldFriendsForm(FacebookAppEngine i_AppEngine)
        {
            r_AppEngine = i_AppEngine;
            r_AppEngine.UpdatingOldFriends += addOldFriends;
            InitializeComponent();
        }

        private void addOldFriends(OldFriend i_OldFriend)
        {
            OldFriendsListBox.Items.Add(i_OldFriend);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            r_AppEngine.FetchOldFriends();
        }

        private void OldFriendsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            OldFriend chosenOldFriend = OldFriendsListBox.SelectedItem as OldFriend;

            if (chosenOldFriend != null)
            {
                OldFriendPictureBox.ImageLocation = chosenOldFriend.ProfilePictureUrl;
            }
        }
    }
}
