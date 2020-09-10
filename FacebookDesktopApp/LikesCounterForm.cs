using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class LikesCounterForm : Form
    {
        private readonly FacebookAppEngine r_AppEngine;

        public LikesCounterForm(FacebookAppEngine i_AppEngine)
        {
            r_AppEngine = i_AppEngine;
            r_AppEngine.UpdateLikesData += updateLikesData;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Thread thread = new Thread(() => r_AppEngine.FetchLikesData());
            thread.Start();
        }


        private void updateLikesData(Dictionary<User, int> i_LikesDataDictionary)  // to change it to string Key - client shouldn't know User Class
        {
            foreach (KeyValuePair<User, int> userAndLikeData in i_LikesDataDictionary)
            {
                ListViewItem itemToAdd = new ListViewItem(userAndLikeData.Key.Name);

                ListViewItem.ListViewSubItem subItemToAdd = new ListViewItem.ListViewSubItem

                {
                    Text = userAndLikeData.Value.ToString()
                };

                itemToAdd.SubItems.Add(subItemToAdd);

                likesDataListView.Invoke(new Action(() => likesDataListView.Items.Add(itemToAdd)));
            }
        }
    }
}
