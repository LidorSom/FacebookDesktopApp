namespace FacebookDesktopApp
{
    public partial class PhotosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photosListBox = new System.Windows.Forms.ListBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureNormalURLPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.DataSource = this.albumBindingSource;
            this.AlbumsListBox.DisplayMember = "Name";
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 16;
            this.AlbumsListBox.Location = new System.Drawing.Point(60, 105);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(120, 260);
            this.AlbumsListBox.TabIndex = 0;
            this.AlbumsListBox.ValueMember = "Comments";
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // photosListBox
            // 
            this.photosListBox.DataSource = this.photoBindingSource;
            this.photosListBox.DisplayMember = "Name";
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.ItemHeight = 16;
            this.photosListBox.Location = new System.Drawing.Point(226, 105);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(120, 260);
            this.photosListBox.TabIndex = 1;
            this.photosListBox.SelectedIndexChanged += new System.EventHandler(this.photosListBox_SelectedIndexChanged);
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            this.photoBindingSource.CurrentChanged += new System.EventHandler(this.photoBindingSource_CurrentChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureNormalURLPictureBox);
            this.panel1.Location = new System.Drawing.Point(416, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 260);
            this.panel1.TabIndex = 2;
            // 
            // pictureNormalURLPictureBox
            // 
            this.pictureNormalURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.pictureNormalURLPictureBox.Location = new System.Drawing.Point(-43, -63);
            this.pictureNormalURLPictureBox.Name = "pictureNormalURLPictureBox";
            this.pictureNormalURLPictureBox.Size = new System.Drawing.Size(482, 425);
            this.pictureNormalURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNormalURLPictureBox.TabIndex = 1;
            this.pictureNormalURLPictureBox.TabStop = false;
            // 
            // PhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.photosListBox);
            this.Controls.Add(this.AlbumsListBox);
            this.Name = "PhotosForm";
            this.Text = "PhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.ListBox photosListBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureNormalURLPictureBox;
    }
}