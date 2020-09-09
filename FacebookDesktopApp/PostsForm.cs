using System;
using System.Windows.Forms;
using  System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PostsForm : Form
    {
        private FacebookAppEngine AppEngine;

        public PostsForm(FacebookAppEngine i_AppEngine)
        {
            AppEngine = i_AppEngine;
            AppEngine.UpdatingPosts += updatePostList;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(new ThreadStart((() => AppEngine.FetchPosts())) );
            thread.Start();
        }

        private void updatePostList(FacebookObjectCollection<Post> i_PostCollection)
        {
            postBindingSource.DataSource = i_PostCollection;
        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
