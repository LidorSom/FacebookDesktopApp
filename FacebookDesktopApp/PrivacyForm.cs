using System;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookDesktopApp
{
    public partial class PrivacyForm : Form
    {
        private readonly PrivacyFacade r_AppEngine = new PrivacyFacade();

        public PrivacyForm()
        {
            r_AppEngine.UpdatingPrivacyData += updateBindingSources;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(() => r_AppEngine.FetchPrivacyData());
            thread.Start();
            
        }

        private void updateBindingSources(FacebookObjectCollection<Event> i_Events, FacebookObjectCollection<Album> i_Albums)
        {

            eventBindingSource.DataSource = i_Events;
            albumBindingSource.DataSource = i_Albums;
            //// groupBindingSource.DataSource = r_AppEngine.Groups; // groups' privacy - no permission
        }

        private void privcaySettingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void privcaySettingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
