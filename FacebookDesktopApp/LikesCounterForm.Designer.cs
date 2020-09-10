namespace FacebookDesktopApp
{
    partial class LikesCounterForm
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
            this.likesDataListView = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // likesDataListView
            // 
            this.likesDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.LikesAmount});
            this.likesDataListView.GridLines = true;
            this.likesDataListView.HideSelection = false;
            this.likesDataListView.Location = new System.Drawing.Point(80, 76);
            this.likesDataListView.Name = "likesDataListView";
            this.likesDataListView.Size = new System.Drawing.Size(195, 256);
            this.likesDataListView.TabIndex = 0;
            this.likesDataListView.UseCompatibleStateImageBehavior = false;
            this.likesDataListView.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "Friend\'s Name";
            this.UserName.Width = 83;
            // 
            // LikesAmount
            // 
            this.LikesAmount.Text = "Likes";
            this.LikesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LikesAmount.Width = 108;
            // 
            // LikesCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.likesDataListView);
            this.Name = "LikesCounterForm";
            this.Text = "LikesCounterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView likesDataListView;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader LikesAmount;
    }
}