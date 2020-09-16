using System;
using System.Threading;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class MyProfileForm : Form
    {
        private readonly MyProfileFacade r_AppEngine  = new MyProfileFacade();
        
        public MyProfileForm()
        {
            r_AppEngine.updateUserDetails += updateBindingSource;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Thread thread = new Thread(() => r_AppEngine.FetchUserDetails());
            thread.Start();
        }

        private void updateBindingSource(User i_User)
        {
            userBindingSource.DataSource = i_User;
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void imageNormalPictureBox_Click_1(object sender, EventArgs e)
        {
        }
    }
}
