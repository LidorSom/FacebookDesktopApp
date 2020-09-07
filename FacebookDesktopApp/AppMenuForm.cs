using System;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class AppMenuForm : Form
    {
        public FacebookAppEngine AppEngine { get; set; }
        private eMenuChoice MenuChoice { get; set; }
        public AppMenuForm()
        {
            InitializeComponent();
        }

        private void myProfileButtonPressed(object sender, EventArgs e)
        {
            Form toDisplayForm = FormFactory.GetForm(eMenuChoice.profile, AppEngine);
            toDisplayForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.friends);
        }

        private void activateForm(eMenuChoice i_MenuChoice)
        {
            Form toDisplayForm = FormFactory.GetForm(i_MenuChoice, AppEngine);
            toDisplayForm.ShowDialog();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.posts);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form toDisplayForm = FormFactory.GetForm(eMenuChoice.photos, AppEngine);
            toDisplayForm.ShowDialog();
        }
    }
}
