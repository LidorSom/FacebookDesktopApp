using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PhotosForm : Form
    {
        private readonly FacebookAppEngine  r_appEngine;
        public PhotosForm(FacebookAppEngine AppEngine)
        {
            r_appEngine = AppEngine;
            AppEngine.AddingAlbums += setAlbum;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Thread thread = new Thread(new ThreadStart(()=> r_appEngine.FetchPhotos()));
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
