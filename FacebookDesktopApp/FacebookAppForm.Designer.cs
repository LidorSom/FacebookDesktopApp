namespace FacebookDesktopApp
{
    partial class FacebookAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
        ///
        
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.Pages = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.DateOfBirth_Label = new System.Windows.Forms.Label();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.loadFriendsButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.postTabPage = new System.Windows.Forms.TabPage();
            this.Description_Label = new System.Windows.Forms.Label();
            this.chosenPostLabel = new System.Windows.Forms.Label();
            this.TextPost_Label = new System.Windows.Forms.Label();
            this.publishPostButton = new System.Windows.Forms.Button();
            this.loadpostsButton = new System.Windows.Forms.Button();
            this.postListBox = new System.Windows.Forms.ListBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.pokesTabPage = new System.Windows.Forms.TabPage();
            this.pokesListBox = new System.Windows.Forms.ListBox();
            this.LoadPokeButton1 = new System.Windows.Forms.Button();
            this.OldFriends = new System.Windows.Forms.TabPage();
            this.LoadFriendsError_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseFriendLabel = new System.Windows.Forms.Label();
            this.oldFriendsPictureBox = new System.Windows.Forms.PictureBox();
            this.oldFriendsListBox = new System.Windows.Forms.ListBox();
            this.photosTabPage = new System.Windows.Forms.TabPage();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.loadPhotos = new System.Windows.Forms.Button();
            this.chosemPictureBox = new System.Windows.Forms.PictureBox();
            this.PicturelistBox = new System.Windows.Forms.ListBox();
            this.AlbumlistBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loadCheckInsButton = new System.Windows.Forms.Button();
            this.checkinsListBox = new System.Windows.Forms.ListBox();
            this.PrivacyTab = new System.Windows.Forms.TabPage();
            this.ReportLoad_Button = new System.Windows.Forms.Button();
            this.privacyListView = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.whoLikeMeTabPage = new System.Windows.Forms.TabPage();
            this.fetchLikesButton = new System.Windows.Forms.Button();
            this.likesDataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.Pages.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            this.postTabPage.SuspendLayout();
            this.pokesTabPage.SuspendLayout();
            this.OldFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldFriendsPictureBox)).BeginInit();
            this.photosTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosemPictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.PrivacyTab.SuspendLayout();
            this.whoLikeMeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "loginButton";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoginButton.Location = new System.Drawing.Point(380, 210);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(120, 36);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBox.Location = new System.Drawing.Point(347, 28);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(187, 159);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Visible = false;
           
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.MainTabPage);
            this.Pages.Controls.Add(this.tabPage2);
            this.Pages.Controls.Add(this.postTabPage);
            this.Pages.Controls.Add(this.pokesTabPage);
            this.Pages.Controls.Add(this.OldFriends);
            this.Pages.Controls.Add(this.photosTabPage);
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Controls.Add(this.PrivacyTab);
            this.Pages.Controls.Add(this.whoLikeMeTabPage);
            this.Pages.Location = new System.Drawing.Point(3, 1);
            this.Pages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(925, 608);
            this.Pages.TabIndex = 3;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.Gender_Label);
            this.MainTabPage.Controls.Add(this.DateOfBirth_Label);
            this.MainTabPage.Controls.Add(this.AutoLogin);
            this.MainTabPage.Controls.Add(this.LogOutButton);
            this.MainTabPage.Controls.Add(this.genderLabel);
            this.MainTabPage.Controls.Add(this.birthdayLabel);
            this.MainTabPage.Controls.Add(this.nameLabel);
            this.MainTabPage.Controls.Add(this.profilePictureBox);
            this.MainTabPage.Controls.Add(this.LoginButton);
            this.MainTabPage.Location = new System.Drawing.Point(4, 25);
            this.MainTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabPage.Size = new System.Drawing.Size(917, 579);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "My Page";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Location = new System.Drawing.Point(303, 340);
            this.Gender_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(60, 17);
            this.Gender_Label.TabIndex = 12;
            this.Gender_Label.Text = "Gender:";
            this.Gender_Label.Visible = false;
            // 
            // DateOfBirth_Label
            // 
            this.DateOfBirth_Label.Location = new System.Drawing.Point(277, 282);
            this.DateOfBirth_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateOfBirth_Label.Name = "DateOfBirth_Label";
            this.DateOfBirth_Label.Size = new System.Drawing.Size(133, 28);
            this.DateOfBirth_Label.TabIndex = 11;
            this.DateOfBirth_Label.Text = "DateOfBirth:";
            this.DateOfBirth_Label.Visible = false;
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Location = new System.Drawing.Point(215, 220);
            this.AutoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(94, 21);
            this.AutoLogin.TabIndex = 8;
            this.AutoLogin.Text = "AutoLogin";
            this.AutoLogin.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(380, 414);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(120, 28);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(417, 340);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender";
            this.genderLabel.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(417, 282);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(82, 17);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "DateOfBirth";
            this.birthdayLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(417, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChooseLabel);
            this.tabPage2.Controls.Add(this.friendsPictureBox);
            this.tabPage2.Controls.Add(this.loadFriendsButton);
            this.tabPage2.Controls.Add(this.friendsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(917, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friends";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(21, 399);
            this.ChooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(276, 17);
            this.ChooseLabel.TabIndex = 3;
            this.ChooseLabel.Text = "Choose a friend in order to see their photo";
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.Location = new System.Drawing.Point(408, 103);
            this.friendsPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(353, 366);
            this.friendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendsPictureBox.TabIndex = 2;
            this.friendsPictureBox.TabStop = false;
            // 
            // loadFriendsButton
            // 
            this.loadFriendsButton.Location = new System.Drawing.Point(85, 48);
            this.loadFriendsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadFriendsButton.Name = "loadFriendsButton";
            this.loadFriendsButton.Size = new System.Drawing.Size(107, 23);
            this.loadFriendsButton.TabIndex = 1;
            this.loadFriendsButton.Text = "Load Friends";
            this.loadFriendsButton.UseVisualStyleBackColor = true;
            this.loadFriendsButton.Click += new System.EventHandler(this.loadFriendsButton_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(51, 103);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(193, 292);
            this.friendsListBox.TabIndex = 0;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // postTabPage
            // 
            this.postTabPage.Controls.Add(this.Description_Label);
            this.postTabPage.Controls.Add(this.chosenPostLabel);
            this.postTabPage.Controls.Add(this.TextPost_Label);
            this.postTabPage.Controls.Add(this.publishPostButton);
            this.postTabPage.Controls.Add(this.loadpostsButton);
            this.postTabPage.Controls.Add(this.postListBox);
            this.postTabPage.Controls.Add(this.postTextBox);
            this.postTabPage.Location = new System.Drawing.Point(4, 25);
            this.postTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postTabPage.Name = "postTabPage";
            this.postTabPage.Size = new System.Drawing.Size(917, 579);
            this.postTabPage.TabIndex = 2;
            this.postTabPage.Text = "Posts";
            this.postTabPage.UseVisualStyleBackColor = true;
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(215, 448);
            this.Description_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(206, 17);
            this.Description_Label.TabIndex = 11;
            this.Description_Label.Text = "Choose a post in order to see it";
            this.Description_Label.Visible = false;
            // 
            // chosenPostLabel
            // 
            this.chosenPostLabel.AutoSize = true;
            this.chosenPostLabel.Location = new System.Drawing.Point(583, 220);
            this.chosenPostLabel.MaximumSize = new System.Drawing.Size(200, 199);
            this.chosenPostLabel.Name = "chosenPostLabel";
            this.chosenPostLabel.Size = new System.Drawing.Size(84, 17);
            this.chosenPostLabel.TabIndex = 10;
            this.chosenPostLabel.Text = "ChosenPost";
            this.chosenPostLabel.Visible = false;
            // 
            // TextPost_Label
            // 
            this.TextPost_Label.AutoSize = true;
            this.TextPost_Label.Location = new System.Drawing.Point(21, 59);
            this.TextPost_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPost_Label.Name = "TextPost_Label";
            this.TextPost_Label.Size = new System.Drawing.Size(140, 17);
            this.TextPost_Label.TabIndex = 9;
            this.TextPost_Label.Text = "Type here your post:";
            // 
            // publishPostButton
            // 
            this.publishPostButton.Location = new System.Drawing.Point(573, 55);
            this.publishPostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publishPostButton.Name = "publishPostButton";
            this.publishPostButton.Size = new System.Drawing.Size(75, 30);
            this.publishPostButton.TabIndex = 8;
            this.publishPostButton.Text = "publish";
            this.publishPostButton.UseVisualStyleBackColor = true;
            this.publishPostButton.Click += new System.EventHandler(this.publishPostButton_Click);
            // 
            // loadpostsButton
            // 
            this.loadpostsButton.Location = new System.Drawing.Point(259, 162);
            this.loadpostsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadpostsButton.Name = "loadpostsButton";
            this.loadpostsButton.Size = new System.Drawing.Size(91, 23);
            this.loadpostsButton.TabIndex = 7;
            this.loadpostsButton.Text = "Load Posts";
            this.loadpostsButton.UseVisualStyleBackColor = true;
            this.loadpostsButton.Click += new System.EventHandler(this.loadPostsButton_Click);
            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.ItemHeight = 16;
            this.postListBox.Location = new System.Drawing.Point(183, 220);
            this.postListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(259, 212);
            this.postListBox.TabIndex = 6;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.postListBox_SelectedIndexChanged);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(204, 59);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(323, 22);
            this.postTextBox.TabIndex = 5;
            // 
            // pokesTabPage
            // 
            this.pokesTabPage.Controls.Add(this.pokesListBox);
            this.pokesTabPage.Controls.Add(this.LoadPokeButton1);
            this.pokesTabPage.Location = new System.Drawing.Point(4, 25);
            this.pokesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pokesTabPage.Name = "pokesTabPage";
            this.pokesTabPage.Size = new System.Drawing.Size(917, 579);
            this.pokesTabPage.TabIndex = 3;
            this.pokesTabPage.Text = "Pokes";
            this.pokesTabPage.UseVisualStyleBackColor = true;
            this.pokesTabPage.Visible = false;
            // 
            // pokesListBox
            // 
            this.pokesListBox.FormattingEnabled = true;
            this.pokesListBox.ItemHeight = 16;
            this.pokesListBox.Location = new System.Drawing.Point(297, 176);
            this.pokesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pokesListBox.Name = "pokesListBox";
            this.pokesListBox.Size = new System.Drawing.Size(239, 212);
            this.pokesListBox.TabIndex = 8;
            this.pokesListBox.SelectedIndexChanged += new System.EventHandler(this.pokesListBox_SelectedIndexChanged);
            // 
            // LoadPokeButton1
            // 
            this.LoadPokeButton1.Location = new System.Drawing.Point(363, 126);
            this.LoadPokeButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadPokeButton1.Name = "LoadPokeButton1";
            this.LoadPokeButton1.Size = new System.Drawing.Size(109, 23);
            this.LoadPokeButton1.TabIndex = 7;
            this.LoadPokeButton1.Text = "Load Pokes";
            this.LoadPokeButton1.UseVisualStyleBackColor = true;
            this.LoadPokeButton1.Click += new System.EventHandler(this.loadPokesButton_Click);
            // 
            // OldFriends
            // 
            this.OldFriends.AccessibleName = "oldFriendsPageTab";
            this.OldFriends.Controls.Add(this.LoadFriendsError_Label);
            this.OldFriends.Controls.Add(this.label2);
            this.OldFriends.Controls.Add(this.ChooseFriendLabel);
            this.OldFriends.Controls.Add(this.oldFriendsPictureBox);
            this.OldFriends.Controls.Add(this.oldFriendsListBox);
            this.OldFriends.Location = new System.Drawing.Point(4, 25);
            this.OldFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldFriends.Name = "OldFriends";
            this.OldFriends.Size = new System.Drawing.Size(917, 579);
            this.OldFriends.TabIndex = 4;
            this.OldFriends.Text = "No Longer Friends";
            this.OldFriends.UseVisualStyleBackColor = true;
            // 
            // LoadFriendsError_Label
            // 
            this.LoadFriendsError_Label.AutoSize = true;
            this.LoadFriendsError_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoadFriendsError_Label.Location = new System.Drawing.Point(240, 236);
            this.LoadFriendsError_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadFriendsError_Label.Name = "LoadFriendsError_Label";
            this.LoadFriendsError_Label.Size = new System.Drawing.Size(296, 31);
            this.LoadFriendsError_Label.TabIndex = 4;
            this.LoadFriendsError_Label.Text = "Please load friends first";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // ChooseFriendLabel
            // 
            this.ChooseFriendLabel.AutoSize = true;
            this.ChooseFriendLabel.Location = new System.Drawing.Point(37, 463);
            this.ChooseFriendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseFriendLabel.Name = "ChooseFriendLabel";
            this.ChooseFriendLabel.Size = new System.Drawing.Size(276, 17);
            this.ChooseFriendLabel.TabIndex = 2;
            this.ChooseFriendLabel.Text = "Choose a friend in order to see their photo";
            this.ChooseFriendLabel.Visible = false;
            // 
            // oldFriendsPictureBox
            // 
            this.oldFriendsPictureBox.Location = new System.Drawing.Point(421, 121);
            this.oldFriendsPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldFriendsPictureBox.Name = "oldFriendsPictureBox";
            this.oldFriendsPictureBox.Size = new System.Drawing.Size(405, 322);
            this.oldFriendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oldFriendsPictureBox.TabIndex = 1;
            this.oldFriendsPictureBox.TabStop = false;
            // 
            // oldFriendsListBox
            // 
            this.oldFriendsListBox.FormattingEnabled = true;
            this.oldFriendsListBox.ItemHeight = 16;
            this.oldFriendsListBox.Location = new System.Drawing.Point(41, 121);
            this.oldFriendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldFriendsListBox.Name = "oldFriendsListBox";
            this.oldFriendsListBox.Size = new System.Drawing.Size(257, 324);
            this.oldFriendsListBox.TabIndex = 0;
            this.oldFriendsListBox.Visible = false;
            this.oldFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.oldFriendsListBox_SelectedIndexChanged);
            // 
            // photosTabPage
            // 
            this.photosTabPage.Controls.Add(this.DescriptionLabel);
            this.photosTabPage.Controls.Add(this.loadPhotos);
            this.photosTabPage.Controls.Add(this.chosemPictureBox);
            this.photosTabPage.Controls.Add(this.PicturelistBox);
            this.photosTabPage.Controls.Add(this.AlbumlistBox);
            this.photosTabPage.Location = new System.Drawing.Point(4, 25);
            this.photosTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photosTabPage.Name = "photosTabPage";
            this.photosTabPage.Size = new System.Drawing.Size(917, 579);
            this.photosTabPage.TabIndex = 5;
            this.photosTabPage.Text = "Photos";
            this.photosTabPage.UseVisualStyleBackColor = true;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(85, 273);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(215, 17);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Choose a photo in order to see it";
            // 
            // loadPhotos
            // 
            this.loadPhotos.Location = new System.Drawing.Point(124, 37);
            this.loadPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadPhotos.Name = "loadPhotos";
            this.loadPhotos.Size = new System.Drawing.Size(117, 26);
            this.loadPhotos.TabIndex = 3;
            this.loadPhotos.Text = "Load photos";
            this.loadPhotos.UseVisualStyleBackColor = true;
            this.loadPhotos.Click += new System.EventHandler(this.loadPhotos_Click);
            // 
            // chosemPictureBox
            // 
            this.chosemPictureBox.Location = new System.Drawing.Point(439, 37);
            this.chosemPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chosemPictureBox.Name = "chosemPictureBox";
            this.chosemPictureBox.Size = new System.Drawing.Size(361, 401);
            this.chosemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chosemPictureBox.TabIndex = 2;
            this.chosemPictureBox.TabStop = false;
            // 
            // PicturelistBox
            // 
            this.PicturelistBox.FormattingEnabled = true;
            this.PicturelistBox.ItemHeight = 16;
            this.PicturelistBox.Location = new System.Drawing.Point(215, 85);
            this.PicturelistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicturelistBox.Name = "PicturelistBox";
            this.PicturelistBox.Size = new System.Drawing.Size(151, 148);
            this.PicturelistBox.TabIndex = 1;
            this.PicturelistBox.SelectedIndexChanged += new System.EventHandler(this.PictureListBox_SelectedIndexChanged);
            // 
            // AlbumlistBox
            // 
            this.AlbumlistBox.FormattingEnabled = true;
            this.AlbumlistBox.ItemHeight = 16;
            this.AlbumlistBox.Location = new System.Drawing.Point(17, 85);
            this.AlbumlistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlbumlistBox.Name = "AlbumlistBox";
            this.AlbumlistBox.Size = new System.Drawing.Size(153, 148);
            this.AlbumlistBox.TabIndex = 0;
            this.AlbumlistBox.SelectedIndexChanged += new System.EventHandler(this.albumListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loadCheckInsButton);
            this.tabPage1.Controls.Add(this.checkinsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(917, 579);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Checkins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loadCheckInsButton
            // 
            this.loadCheckInsButton.Location = new System.Drawing.Point(293, 75);
            this.loadCheckInsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadCheckInsButton.Name = "loadCheckInsButton";
            this.loadCheckInsButton.Size = new System.Drawing.Size(208, 23);
            this.loadCheckInsButton.TabIndex = 0;
            this.loadCheckInsButton.Text = "Load Checkins";
            this.loadCheckInsButton.UseVisualStyleBackColor = true;
            this.loadCheckInsButton.Click += new System.EventHandler(this.loadCheckInsButton_Click);
            // 
            // checkinsListBox
            // 
            this.checkinsListBox.FormattingEnabled = true;
            this.checkinsListBox.ItemHeight = 16;
            this.checkinsListBox.Location = new System.Drawing.Point(321, 134);
            this.checkinsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkinsListBox.Name = "checkinsListBox";
            this.checkinsListBox.Size = new System.Drawing.Size(147, 324);
            this.checkinsListBox.TabIndex = 1;
            this.checkinsListBox.SelectedIndexChanged += new System.EventHandler(this.checkInsListBox_SelectedIndexChanged);
            // 
            // PrivacyTab
            // 
            this.PrivacyTab.Controls.Add(this.ReportLoad_Button);
            this.PrivacyTab.Controls.Add(this.privacyListView);
            this.PrivacyTab.Location = new System.Drawing.Point(4, 25);
            this.PrivacyTab.Margin = new System.Windows.Forms.Padding(4);
            this.PrivacyTab.Name = "PrivacyTab";
            this.PrivacyTab.Size = new System.Drawing.Size(917, 579);
            this.PrivacyTab.TabIndex = 7;
            this.PrivacyTab.Text = "Privacy Report";
            this.PrivacyTab.UseVisualStyleBackColor = true;
            // 
            // ReportLoad_Button
            // 
            this.ReportLoad_Button.Location = new System.Drawing.Point(361, 43);
            this.ReportLoad_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ReportLoad_Button.Name = "ReportLoad_Button";
            this.ReportLoad_Button.Size = new System.Drawing.Size(100, 28);
            this.ReportLoad_Button.TabIndex = 1;
            this.ReportLoad_Button.Text = "Load Report";
            this.ReportLoad_Button.UseVisualStyleBackColor = true;
            this.ReportLoad_Button.Click += new System.EventHandler(this.ReportLoad_Button_Click);
            // 
            // PrivacyListView
            // 
            this.privacyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2});
            this.privacyListView.GridLines = true;
            this.privacyListView.HideSelection = false;
            this.privacyListView.Location = new System.Drawing.Point(264, 106);
            this.privacyListView.Margin = new System.Windows.Forms.Padding(4);
            this.privacyListView.Name = "privacyListView";
            this.privacyListView.Size = new System.Drawing.Size(303, 381);
            this.privacyListView.TabIndex = 0;
            this.privacyListView.UseCompatibleStateImageBehavior = false;
            this.privacyListView.View = System.Windows.Forms.View.Details;
            // 
            // column1
            // 
            this.column1.Text = "Examined Object";
            this.column1.Width = 114;
            // 
            // column2
            // 
            this.column2.Text = "Privacy Status";
            this.column2.Width = 107;
            // 
            // whoLikeMeTabPage
            // 
            this.whoLikeMeTabPage.Controls.Add(this.fetchLikesButton);
            this.whoLikeMeTabPage.Controls.Add(this.likesDataListView);
            this.whoLikeMeTabPage.Location = new System.Drawing.Point(4, 25);
            this.whoLikeMeTabPage.Name = "whoLikeMeTabPage";
            this.whoLikeMeTabPage.Size = new System.Drawing.Size(917, 579);
            this.whoLikeMeTabPage.TabIndex = 8;
            this.whoLikeMeTabPage.Text = "whoLikeMe";
            this.whoLikeMeTabPage.UseVisualStyleBackColor = true;
            // 
            // fetchLikesButton
            // 
            this.fetchLikesButton.Location = new System.Drawing.Point(352, 56);
            this.fetchLikesButton.Name = "fetchLikesButton";
            this.fetchLikesButton.Size = new System.Drawing.Size(126, 23);
            this.fetchLikesButton.TabIndex = 2;
            this.fetchLikesButton.Text = "fetch likes data";
            this.fetchLikesButton.UseVisualStyleBackColor = true;
            this.fetchLikesButton.Click += new System.EventHandler(this.fetchLikesButton_Click);
            // 
            // likesDataListView
            // 
            this.likesDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.likesDataListView.GridLines = true;
            this.likesDataListView.HideSelection = false;
            this.likesDataListView.Location = new System.Drawing.Point(286, 121);
            this.likesDataListView.Margin = new System.Windows.Forms.Padding(4);
            this.likesDataListView.Name = "likesDataListView";
            this.likesDataListView.Size = new System.Drawing.Size(280, 381);
            this.likesDataListView.TabIndex = 1;
            this.likesDataListView.UseCompatibleStateImageBehavior = false;
            this.likesDataListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "user name";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "amount of likes";
            this.columnHeader2.Width = 107;
            // 
            // FacebookDesktopAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(849, 604);
            this.Controls.Add(this.Pages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookDesktopAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.Pages.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            this.postTabPage.ResumeLayout(false);
            this.postTabPage.PerformLayout();
            this.pokesTabPage.ResumeLayout(false);
            this.OldFriends.ResumeLayout(false);
            this.OldFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldFriendsPictureBox)).EndInit();
            this.photosTabPage.ResumeLayout(false);
            this.photosTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosemPictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.PrivacyTab.ResumeLayout(false);
            this.whoLikeMeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage postTabPage;
        private System.Windows.Forms.TabPage pokesTabPage;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button loadpostsButton;
        private System.Windows.Forms.ListBox postListBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button loadFriendsButton;
        private System.Windows.Forms.ListBox pokesListBox;
        private System.Windows.Forms.Button LoadPokeButton1;
        private System.Windows.Forms.Button publishPostButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.Label DateOfBirth_Label;
        private System.Windows.Forms.Label TextPost_Label;
        private System.Windows.Forms.TabPage OldFriends;
        private System.Windows.Forms.ListBox oldFriendsListBox;
        private System.Windows.Forms.TabPage photosTabPage;
        private System.Windows.Forms.PictureBox chosemPictureBox;
        private System.Windows.Forms.ListBox PicturelistBox;
        private System.Windows.Forms.ListBox AlbumlistBox;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox oldFriendsPictureBox;
        private System.Windows.Forms.Label chosenPostLabel;
        private System.Windows.Forms.Button loadPhotos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox checkinsListBox;
        private System.Windows.Forms.Button loadCheckInsButton;
        private System.Windows.Forms.TabPage PrivacyTab;
        private System.Windows.Forms.Button ReportLoad_Button;
        private System.Windows.Forms.ListView privacyListView;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.Label LoadFriendsError_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChooseFriendLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.TabPage whoLikeMeTabPage;
        private System.Windows.Forms.Button fetchLikesButton;
        private System.Windows.Forms.ListView likesDataListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}