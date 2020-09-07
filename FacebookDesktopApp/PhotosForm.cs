using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class PhotosForm : Form
    {
        public FacebookAppEngine AppEngine { get; set; }

        public PhotosForm(FacebookAppEngine i_FacebookAppEngine)
        {
            AppEngine = i_FacebookAppEngine;
            AppEngine.AddingAlbums += updateBindingSource;
            InitializeComponent();
        }

        private void updateBindingSource(Album i_Albums)
        {
            albumBindingSource.DataSource = i_Albums;
        }

        private void albumBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
