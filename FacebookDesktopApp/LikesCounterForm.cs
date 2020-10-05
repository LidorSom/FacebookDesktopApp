using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class LikesCounterForm : Form
    {
        private readonly LikeCounterFacade r_AppEngine = new LikeCounterFacade();

        public LikesCounterForm()
        {
            r_AppEngine.UpdateLikesData += updateLikesData;
            r_AppEngine.SortUsersByLikes += sortUpUserByLikes;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(() => r_AppEngine.FetchLikesData());
            thread.Start();
        }

        private bool sortUpUserByLikes(KeyValuePair<User, int> i_KeyValue1, KeyValuePair<User, int> i_KeyValue2)
        {
            return i_KeyValue1.Value < i_KeyValue2.Value;
        }

        private void updateLikesData(ICollection<KeyValuePair<User, int>> i_LikesDataDictionary)  // to change it to string Key - client shouldn't know User Class
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

        private void likesDataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}