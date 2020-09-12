using System;
using System.Windows.Forms;
using FacebookDesktopAppFacades;

namespace FacebookDesktopApp
{
    public partial class PrivacyForm : Form
    {
        //move it all to data binding & separate  Thread ! 
        private readonly PrivacyFacade r_AppEngine = new PrivacyFacade();

        public PrivacyForm()
        {
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
            // bad implementation, you shouldnt take data like this, use delegates !!!
            //eventBindingSource.DataSource = r_AppEngine.Events; 
            //// groupBindingSource.DataSource = r_AppEngine.Groups; // groups' privacy - no permission
            //albumBindingSource.DataSource = r_AppEngine.Albums;
        }

        private void privcaySettingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void privcaySettingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
