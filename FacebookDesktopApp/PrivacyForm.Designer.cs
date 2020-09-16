namespace FacebookDesktopApp
{
    public partial class PrivacyForm
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
            // AlbumsPrivacy_Label
            // 
            AlbumsPrivacy_Label.AutoSize = true;
            AlbumsPrivacy_Label.Location = new System.Drawing.Point(91, 79);
            AlbumsPrivacy_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AlbumsPrivacy_Label.Name = "AlbumsPrivacy_Label";
            AlbumsPrivacy_Label.Size = new System.Drawing.Size(108, 17);
            AlbumsPrivacy_Label.TabIndex = 1;
            AlbumsPrivacy_Label.Text = "Albums Privacy:";
            AlbumsPrivacy_Label.Click += new System.EventHandler(this.privacySettingsLabel_Click);
            // 
            // EventsPrivacy_Label
            // 
            EventsPrivacy_Label.AutoSize = true;
            EventsPrivacy_Label.Location = new System.Drawing.Point(687, 79);
            EventsPrivacy_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EventsPrivacy_Label.Name = "EventsPrivacy_Label";
            EventsPrivacy_Label.Size = new System.Drawing.Size(105, 17);
            EventsPrivacy_Label.TabIndex = 2;
            EventsPrivacy_Label.Text = "Events Privacy:";
            // 
            // GroupPrivacy_Label
            // 
            GroupPrivacy_Label.AutoSize = true;
            GroupPrivacy_Label.Location = new System.Drawing.Point(375, 79);
            GroupPrivacy_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GroupPrivacy_Label.Name = "GroupPrivacy_Label";
            GroupPrivacy_Label.Size = new System.Drawing.Size(109, 17);
            GroupPrivacy_Label.TabIndex = 4;
            GroupPrivacy_Label.Text = "Groups Privacy:";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // privcaySettingsListBox
            // 
            this.privcaySettingsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.albumBindingSource, "PrivcaySettings", true));
            this.privcaySettingsListBox.DataSource = this.albumBindingSource;
            this.privcaySettingsListBox.DisplayMember = "PrivcaySettings";
            this.privcaySettingsListBox.FormattingEnabled = true;
            this.privcaySettingsListBox.ItemHeight = 16;
            this.privcaySettingsListBox.Location = new System.Drawing.Point(95, 113);
            this.privcaySettingsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privcaySettingsListBox.Name = "privcaySettingsListBox";
            this.privcaySettingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privcaySettingsListBox.Size = new System.Drawing.Size(159, 228);
            this.privcaySettingsListBox.TabIndex = 2;
            this.privcaySettingsListBox.SelectedIndexChanged += new System.EventHandler(this.privacySettingsListBox_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // privacyListBox
            // 
            this.privacyListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eventBindingSource, "Privacy", true));
            this.privacyListBox.DataSource = this.eventBindingSource;
            this.privacyListBox.DisplayMember = "Privacy";
            this.privacyListBox.FormattingEnabled = true;
            this.privacyListBox.ItemHeight = 16;
            this.privacyListBox.Location = new System.Drawing.Point(691, 113);
            this.privacyListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privacyListBox.Name = "privacyListBox";
            this.privacyListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privacyListBox.Size = new System.Drawing.Size(159, 228);
            this.privacyListBox.TabIndex = 3;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // privacyListBox1
            // 
            this.privacyListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "Privacy", true));
            this.privacyListBox1.DataSource = this.groupBindingSource;
            this.privacyListBox1.DisplayMember = "Privacy";
            this.privacyListBox1.FormattingEnabled = true;
            this.privacyListBox1.ItemHeight = 16;
            this.privacyListBox1.Location = new System.Drawing.Point(379, 113);
            this.privacyListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.privacyListBox1.Name = "privacyListBox1";
            this.privacyListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.privacyListBox1.Size = new System.Drawing.Size(159, 228);
            this.privacyListBox1.TabIndex = 5;
            // 
            // PrivacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 624);
            this.Controls.Add(GroupPrivacy_Label);
            this.Controls.Add(this.privacyListBox1);
            this.Controls.Add(EventsPrivacy_Label);
            this.Controls.Add(this.privacyListBox);
            this.Controls.Add(AlbumsPrivacy_Label);
            this.Controls.Add(this.privcaySettingsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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