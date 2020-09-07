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
    public partial class CheckInForm : Form
    {
        private FacebookAppEngine facebookAppEngine;
        public CheckInForm(FacebookAppEngine i_AppEngine)
        {
            facebookAppEngine = i_AppEngine;
            facebookAppEngine.AddingCheckIn += updateCheckIns;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(new ThreadStart(()=> facebookAppEngine.FetchCheckIns()));
            thread.Start();
        }

        private void updateCheckIns(FacebookObjectCollection<Checkin> i_Checkins)
        {
            if (i_Checkins == null || i_Checkins.Count == 0)
            {
                checkInListBox.Visible = false;
                panel1.Visible = false;
            }
            checkinBindingSource.DataSource = i_Checkins;
        }

        private void checkInListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
