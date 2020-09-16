namespace FacebookDesktopApp
{
    public partial class CheckInForm
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
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label messageLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.checkInListBox = new System.Windows.Forms.ListBox();
            captionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(72, 43);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(60, 17);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(72, 72);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(72, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(72, 116);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(69, 17);
            messageLabel.TabIndex = 6;
            messageLabel.Text = "Message:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(captionLabel);
            this.panel1.Controls.Add(this.captionTextBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionLabel1);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageLabel1);
            this.panel1.Location = new System.Drawing.Point(500, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 181);
            this.panel1.TabIndex = 0;
            // 
            // captionTextBox
            // 
            this.captionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Caption", true));
            this.captionTextBox.Location = new System.Drawing.Point(175, 40);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(200, 22);
            this.captionTextBox.TabIndex = 1;
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkinBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(175, 68);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(175, 93);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(200, 23);
            this.descriptionLabel1.TabIndex = 5;
            this.descriptionLabel1.Text = "label1";
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(175, 116);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(200, 23);
            this.messageLabel1.TabIndex = 7;
            this.messageLabel1.Text = "label1";
            // 
            // checkInListBox
            // 
            this.checkInListBox.DataSource = this.checkinBindingSource;
            this.checkInListBox.DisplayMember = "Name";
            this.checkInListBox.FormattingEnabled = true;
            this.checkInListBox.ItemHeight = 16;
            this.checkInListBox.Location = new System.Drawing.Point(77, 135);
            this.checkInListBox.Name = "checkInListBox";
            this.checkInListBox.Size = new System.Drawing.Size(223, 228);
            this.checkInListBox.TabIndex = 2;
            this.checkInListBox.SelectedIndexChanged += new System.EventHandler(this.checkInListBox_SelectedIndexChanged);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.checkInListBox);
            this.Controls.Add(this.panel1);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.ListBox checkInListBox;
    }
}