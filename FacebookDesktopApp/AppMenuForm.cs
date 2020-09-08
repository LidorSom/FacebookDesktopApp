using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            activateForm(eMenuChoice.profile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.friends);
        }

        private void activateForm(eMenuChoice i_MenuChoice)
        {
            Form toDisplayForm = FormFactory.GetForm(i_MenuChoice, AppEngine);
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

        private void button6_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.checkIns);
        }

        private void PrivacyReportButton_Click(object sender, EventArgs e)
        {
            activateForm(eMenuChoice.privacy);
        }
    }
}
