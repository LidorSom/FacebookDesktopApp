using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PhotosForm : Form
    {
        private readonly FacebookAppEngine  r_AppEngine;

        public PhotosForm(FacebookAppEngine i_AppEngine)
        {
            r_AppEngine = i_AppEngine;
            i_AppEngine.AddingAlbums += setAlbum;
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
    }
}
