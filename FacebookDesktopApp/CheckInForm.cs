using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class CheckInForm : Form
    {
        private readonly CheckInFacade r_FacebookAppEngine = new CheckInFacade();

        public CheckInForm()
        {
            r_FacebookAppEngine.AddingCheckIn += updateCheckIns;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(() => r_FacebookAppEngine.FetchCheckIns());
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
