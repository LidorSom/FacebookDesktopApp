using System;
using System.Windows.Forms;
using  System.Threading;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PostsForm : Form
    {
        private PostsFacade AppEngine = new PostsFacade();

        public PostsForm()
        {
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
