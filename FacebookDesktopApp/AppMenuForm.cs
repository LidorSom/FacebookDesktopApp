using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class AppMenuForm : Form
    {
        private eMenuChoice MenuChoice { get; set; }

        public AppMenuForm()
        {
            InitializeComponent();
        }

        private void myProfileButtonPressed(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.profile);
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.friends);
        }

        private void activateForm(eMenuChoice i_MenuChoice)
        {
            Form toDisplayForm = FormFactory.GetForm(i_MenuChoice);
            Thread thread = new Thread((() => toDisplayForm.ShowDialog()));
            thread.Start();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.posts);
        }

        private void photosButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.photos);
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.checkIns);
        }

        private void PrivacyReportButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.privacy);
        }

        private void OldFriendsButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.oldFriends);
        }

        private void LikesCounterButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.likeCounter);
        }
    }
}
