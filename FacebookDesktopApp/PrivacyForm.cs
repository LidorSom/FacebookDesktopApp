using System;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class PrivacyForm : Form
    {
        private readonly FacebookAppEngine r_AppEngine;

        public PrivacyForm(FacebookAppEngine i_AppEngine)
        {
            r_AppEngine = i_AppEngine;
            r_AppEngine.UpdatingPrivacyData += updateBindingSources;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            r_AppEngine.FetchPrivacyData();
        }

        private void updateBindingSources()
        {
           eventBindingSource.DataSource = r_AppEngine.Events; 
           // groupBindingSource.DataSource = r_AppEngine.Groups; // groups' privacy - no permission
           albumBindingSource.DataSource = r_AppEngine.Albums;
        }

        private void privcaySettingsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
