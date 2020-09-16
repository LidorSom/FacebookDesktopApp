using System;
using System.Threading;
using System.Windows.Forms;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PhotosForm : Form
    {
        private readonly PhotosFacade r_AppEngine = new PhotosFacade();

        public PhotosForm()
        {
            r_AppEngine.AddingAlbums += setAlbum;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(() => r_AppEngine.FetchPhotos());
            thread.Start();
        }

        private void setAlbum(FacebookObjectCollection<Album> i_Albums)
        {
            albumBindingSource.DataSource = i_Albums;
        }

        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            photoBindingSource.DataSource = (AlbumsListBox.SelectedItem as Album).Photos;
        }

        private void photoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void photosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
