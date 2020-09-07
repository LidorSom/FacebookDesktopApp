namespace FacebookDesktopApp
{
    partial class PhotosForm
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
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label pictureAlbumURLLabel;
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.coverPhotoListBox = new System.Windows.Forms.ListBox();
            this.pictureAlbumURLPictureBox = new System.Windows.Forms.PictureBox();
            imageNormalLabel = new System.Windows.Forms.Label();
            pictureAlbumURLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbumURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            this.albumBindingSource.CurrentChanged += new System.EventHandler(this.albumBindingSource_CurrentChanged);
            // 
            // albumListBox
            // 
            this.albumListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.albumBindingSource, "Pictures", true));
            this.albumListBox.DisplayMember = "Comments";
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.Location = new System.Drawing.Point(56, 45);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(300, 212);
            this.albumListBox.TabIndex = 0;
            this.albumListBox.ValueMember = "Comments";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(565, 319);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(75, 13);
            imageNormalLabel.TabIndex = 1;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.Location = new System.Drawing.Point(526, 284);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(152, 130);
            this.imageNormalPictureBox.TabIndex = 2;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // coverPhotoListBox
            // 
            this.coverPhotoListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.albumBindingSource, "CoverPhotoLargeURL", true));
            this.coverPhotoListBox.FormattingEnabled = true;
            this.coverPhotoListBox.Location = new System.Drawing.Point(430, 57);
            this.coverPhotoListBox.Name = "coverPhotoListBox";
            this.coverPhotoListBox.Size = new System.Drawing.Size(162, 173);
            this.coverPhotoListBox.TabIndex = 3;
            this.coverPhotoListBox.ValueMember = "Album";
            // 
            // pictureAlbumURLLabel
            // 
            pictureAlbumURLLabel.AutoSize = true;
            pictureAlbumURLLabel.Location = new System.Drawing.Point(684, 34);
            pictureAlbumURLLabel.Name = "pictureAlbumURLLabel";
            pictureAlbumURLLabel.Size = new System.Drawing.Size(100, 13);
            pictureAlbumURLLabel.TabIndex = 4;
            pictureAlbumURLLabel.Text = "Picture Album URL:";
            // 
            // pictureAlbumURLPictureBox
            // 
            this.pictureAlbumURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "PictureAlbumURL", true));
            this.pictureAlbumURLPictureBox.Location = new System.Drawing.Point(684, 89);
            this.pictureAlbumURLPictureBox.Name = "pictureAlbumURLPictureBox";
            this.pictureAlbumURLPictureBox.Size = new System.Drawing.Size(100, 79);
            this.pictureAlbumURLPictureBox.TabIndex = 5;
            this.pictureAlbumURLPictureBox.TabStop = false;
            // 
            // PhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 489);
            this.Controls.Add(pictureAlbumURLLabel);
            this.Controls.Add(this.pictureAlbumURLPictureBox);
            this.Controls.Add(this.coverPhotoListBox);
            this.Controls.Add(imageNormalLabel);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.albumListBox);
            this.Name = "PhotosForm";
            this.Text = "PhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbumURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.ListBox coverPhotoListBox;
        private System.Windows.Forms.PictureBox pictureAlbumURLPictureBox;
    }
}