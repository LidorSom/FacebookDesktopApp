namespace FacebookDesktopApp
{
    partial class PrivacyForm
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
            System.Windows.Forms.Label AlbumsPrivacy_Label;
            System.Windows.Forms.Label EventsPrivacy_Label;
            System.Windows.Forms.Label GroupPrivacy_Label;
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.privcaySettingsListBox = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.privacyListBox = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.privacyListBox1 = new System.Windows.Forms.ListBox();
            AlbumsPrivacy_Label = new System.Windows.Forms.Label();
            EventsPrivacy_Label = new System.Windows.Forms.Label();
            GroupPrivacy_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // AlbumsPrivacy_Label
            // 
            AlbumsPrivacy_Label.AutoSize = true;
            AlbumsPrivacy_Label.Location = new System.Drawing.Point(68, 64);
            AlbumsPrivacy_Label.Name = "AlbumsPrivacy_Label";
            AlbumsPrivacy_Label.Size = new System.Drawing.Size(82, 13);
            AlbumsPrivacy_Label.TabIndex = 1;
            AlbumsPrivacy_Label.Text = "Albums Privacy:";
            AlbumsPrivacy_Label.Click += new System.EventHandler(this.privcaySettingsLabel_Click);
            // 
            // privcaySettingsListBox
            // 
            this.privcaySettingsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.albumBindingSource, "PrivcaySettings", true));
            this.privcaySettingsListBox.DataSource = this.albumBindingSource;
            this.privcaySettingsListBox.DisplayMember = "PrivcaySettings";
            this.privcaySettingsListBox.FormattingEnabled = true;
            this.privcaySettingsListBox.Location = new System.Drawing.Point(71, 92);
            this.privcaySettingsListBox.Name = "privcaySettingsListBox";
            this.privcaySettingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privcaySettingsListBox.Size = new System.Drawing.Size(120, 186);
            this.privcaySettingsListBox.TabIndex = 2;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // EventsPrivacy_Label
            // 
            EventsPrivacy_Label.AutoSize = true;
            EventsPrivacy_Label.Location = new System.Drawing.Point(515, 64);
            EventsPrivacy_Label.Name = "EventsPrivacy_Label";
            EventsPrivacy_Label.Size = new System.Drawing.Size(81, 13);
            EventsPrivacy_Label.TabIndex = 2;
            EventsPrivacy_Label.Text = "Events Privacy:";
            // 
            // privacyListBox
            // 
            this.privacyListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eventBindingSource, "Privacy", true));
            this.privacyListBox.DataSource = this.eventBindingSource;
            this.privacyListBox.DisplayMember = "Privacy";
            this.privacyListBox.FormattingEnabled = true;
            this.privacyListBox.Location = new System.Drawing.Point(518, 92);
            this.privacyListBox.Name = "privacyListBox";
            this.privacyListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privacyListBox.Size = new System.Drawing.Size(120, 186);
            this.privacyListBox.TabIndex = 3;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // GroupPrivacy_Label
            // 
            GroupPrivacy_Label.AutoSize = true;
            GroupPrivacy_Label.Location = new System.Drawing.Point(281, 64);
            GroupPrivacy_Label.Name = "GroupPrivacy_Label";
            GroupPrivacy_Label.Size = new System.Drawing.Size(82, 13);
            GroupPrivacy_Label.TabIndex = 4;
            GroupPrivacy_Label.Text = "Groups Privacy:";
            // 
            // privacyListBox1
            // 
            this.privacyListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "Privacy", true));
            this.privacyListBox1.DataSource = this.groupBindingSource;
            this.privacyListBox1.DisplayMember = "Privacy";
            this.privacyListBox1.FormattingEnabled = true;
            this.privacyListBox1.Location = new System.Drawing.Point(284, 92);
            this.privacyListBox1.Name = "privacyListBox1";
            this.privacyListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privacyListBox1.Size = new System.Drawing.Size(120, 186);
            this.privacyListBox1.TabIndex = 5;
            // 
            // PrivacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 507);
            this.Controls.Add(GroupPrivacy_Label);
            this.Controls.Add(this.privacyListBox1);
            this.Controls.Add(EventsPrivacy_Label);
            this.Controls.Add(this.privacyListBox);
            this.Controls.Add(AlbumsPrivacy_Label);
            this.Controls.Add(this.privcaySettingsListBox);
            this.Name = "PrivacyForm";
            this.Text = "PrivacyReport";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ListBox privcaySettingsListBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.ListBox privacyListBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.ListBox privacyListBox1;
    }
}