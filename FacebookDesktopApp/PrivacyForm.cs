using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public partial class PrivacyForm : Form
    {
        private readonly FacebookAppEngine r_AppEngine;
        private readonly Color r_ColorForEveryonePrivacyLevel = Color.Red;
        private readonly Color r_ColorForCustomPrivacyLevel = Color.Orange;
        private readonly Color r_ColorForOtherPrivacyLevel = Color.LightGreen;

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
           groupBindingSource.DataSource = r_AppEngine.Groups;
           albumBindingSource.DataSource = r_AppEngine.Albums;
        }

      /*  private void addToPrivacySettings(string i_ExaminedItem, string i_PrivacyLevel)
        {
            ListViewItem itemToAdd = new ListViewItem(i_ExaminedItem);
            ListViewItem.ListViewSubItem subItemToAdd = new ListViewItem.ListViewSubItem
            {
                Text = i_PrivacyLevel
            };

            itemToAdd.SubItems.Add(subItemToAdd);
            privacyListView.Items.Add(itemToAdd);

            privacyListView.Items[privacyListView.Items.Count - 1].UseItemStyleForSubItems = false;

            if (i_PrivacyLevel.Equals("everyone"))
            {
                subItemToAdd.BackColor = r_ColorForEveryonePrivacyLevel;
            }
            else if (i_PrivacyLevel.Equals("custom"))
            {
                subItemToAdd.BackColor = r_ColorForCustomPrivacyLevel;
            }
            else
            {
                subItemToAdd.BackColor = r_ColorForOtherPrivacyLevel;
            }
        }
        */
      private void albumBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void privacyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void privcaySettingsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
