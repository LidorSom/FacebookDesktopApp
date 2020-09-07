using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public partial class FacebookAppForm : Form
    {
        private readonly FacebookAppEngine r_AppEngine;
        private readonly ApplicationSettings r_ApplicationSettings;
        private readonly Color r_ColorForEveryonePrivacyLevel = Color.Red;
        private readonly Color r_ColorForCustomPrivacyLevel = Color.Orange;
        private readonly Color r_ColorForOtherPrivacyLevel = Color.LightGreen;

        public FacebookAppForm()
        {
            r_AppEngine = new FacebookAppEngine();
            r_ApplicationSettings = ApplicationSettings.ApplicationSettingsInstance;
            r_AppEngine.NoticingLoginError += showErrorMessage;
            r_AppEngine.UpdatingProfilePicture += updatingProfilePicture;
            //r_AppEngine.UpdatingPosts += addToPosts;
            r_AppEngine.UpdatingPokes += addToPokes;
           // r_AppEngine.UpdatingFriendsList += addToFriendsListBox;
            r_AppEngine.UpdatingName += setName;
            r_AppEngine.UpdatingGender += setGender;
            r_AppEngine.UpdatingBirthday += setBirthDay;
            r_AppEngine.UpdatingOldFriends += addOldFriends;
            //r_AppEngine.AddingCheckIn += addingCheckIn;
            r_AppEngine.UpdatingPrivacyData += addToPrivacySettings;
           // r_AppEngine.AddingAlbums += addAlbums;
            r_AppEngine.UpdateLikesData += updateLikesData;
            InitializeComponent();
            loadApplicationSettings();
        }

        private void loadApplicationSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Size = r_ApplicationSettings.LastWindowSize;
            this.Location = r_ApplicationSettings.LastWindowLocation;
            this.AutoLogin.Checked = r_ApplicationSettings.AutoLogin;
            r_AppEngine.AccessToken = r_ApplicationSettings.AccessToken;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            r_AppEngine.Login();
            updateFormButtonsWithLogin();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (r_ApplicationSettings.AutoLogin && !string.IsNullOrEmpty(r_ApplicationSettings.AccessToken))
            {
                r_AppEngine.Connect();

                populateUIWithFacebookData();

                updateFormButtonsWithLogin();
            }
        }

        private void updateFormButtonsWithLogin()
        {
            LoginButton.Visible = false;
            AutoLogin.Visible = false;
            LogOutButton.Visible = true;
            DateOfBirth_Label.Visible = true;
            Gender_Label.Visible = true;
            checkinsListBox.DisplayMember = "Name";
            postListBox.DisplayMember = "Name";
            friendsListBox.DisplayMember = "Name";
            oldFriendsListBox.DisplayMember = "Name";
            PicturelistBox.DisplayMember = "Message";
            AlbumlistBox.DisplayMember = "Name";
        }

        private void setName(string i_Name)
        {
            nameLabel.Text = i_Name;
            nameLabel.Visible = true;
        }

        private void setBirthDay(string i_BirthDay)
        {
            birthdayLabel.Text = i_BirthDay;
            birthdayLabel.Visible = true;
        }

        private void setGender(User.eGender? i_Gender)
        {
            genderLabel.Text = i_Gender.ToString();
            genderLabel.Visible = true;
        }

        private void updatingProfilePicture(string i_ProfilePictureUrl)
        {
            profilePictureBox.ImageLocation = i_ProfilePictureUrl;
            profilePictureBox.Visible = true;
        }

        private void showErrorMessage(string i_ErrorMessage)
        {
            MessageBox.Show(i_ErrorMessage);
        }

        private void addToPosts(Post i_PostString)
        {
            postListBox.Items.Add(i_PostString);
        }

        private void addToPokes(Poke i_Poke)
        {
            pokesListBox.Items.Add(i_Poke);
        }

        private void loadPostsButton_Click(object sender, EventArgs e)
        {
            postListBox.Items.Clear();
            r_AppEngine.FetchPosts();
            Description_Label.Visible = true;
        }

        private void loadPokesButton_Click(object sender, EventArgs e)
        {
            pokesListBox.Items.Clear();
            try
            {
                r_AppEngine.FetchPokes();
            }
            catch (Exception exception)
            {
                showErrorMessage(string.Format("Unable to fetch pokes:{0}", exception.Message));
            }
        }

        private void loadFriendsButton_Click(object sender, EventArgs e)
        {
            friendsListBox.Items.Clear();
            oldFriendsListBox.Items.Clear();
            LoadFriendsError_Label.Visible = false;
            oldFriendsListBox.Visible = true;
            ChooseFriendLabel.Visible = true;

            r_AppEngine.FetchFriends();
            r_AppEngine.FetchOldFriends();
        }

        private void addToFriendsListBox(User i_User)
        {
            friendsListBox.Items.Add(i_User);
        }

        private void publishPostButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_AppEngine.PublishPost(postListBox.Text);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
            finally
            {
                postTextBox.ResetText();
            }
        }

        private void addOldFriends(OldFriend i_OldFriend)
        {
            oldFriendsListBox.Items.Add(i_OldFriend);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_ApplicationSettings.LastWindowSize = this.Size;
            r_ApplicationSettings.LastWindowLocation = this.Location;
            r_ApplicationSettings.AutoLogin = this.AutoLogin.Checked;

            if (r_ApplicationSettings.AutoLogin)
            {
                r_ApplicationSettings.AccessToken = r_AppEngine.AccessToken;
            }
            else
            {
                r_ApplicationSettings.AccessToken = null;
            }

            r_ApplicationSettings.SaveToFile();

            if (!LoginButton.Visible)
            {
                try
                {
                    FacebookService.Logout(showSuccessLogoutMessage);
                }
                catch (Exception exception)
                {
                    showFailLogoutMessage(exception);
                }
            }
        }

        private void addAlbums(Album i_Album)
        {
            AlbumlistBox.Items.Add(i_Album);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(showSuccessLogoutMessage);
            }
            catch (Exception exception)
            {
                showFailLogoutMessage(exception);
            }

            r_AppEngine.AccessToken = null;
            cleanFormUserData();
            LoginButton.Visible = true;
            AutoLogin.Visible = true;
        }

        private void showSuccessLogoutMessage()
        {
            MessageBox.Show("Logged out successfully");
        }

        private void showFailLogoutMessage(Exception i_Exception)
        {
            MessageBox.Show("Log out didn't succeed: {0}", i_Exception.Message);
        }

        private void cleanFormUserData()
        {
            LogOutButton.Visible = false;
            profilePictureBox.Visible = false;
            nameLabel.Visible = false;
            birthdayLabel.Visible = false;
            genderLabel.Visible = false;
            DateOfBirth_Label.Visible = false;
            Gender_Label.Visible = false;
        }

        private void populateUIWithFacebookData()
        {
            r_AppEngine.InvokeLoginHandlers();
        }

        private void oldFriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OldFriend chosenUser = oldFriendsListBox.SelectedItem as OldFriend;

            if (chosenUser != null)
            {
                oldFriendsPictureBox.ImageLocation = chosenUser.ProfilePictureUrl;
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            User chosenUser = friendsListBox.SelectedItem as User;

            if (chosenUser != null)
            {
                friendsPictureBox.ImageLocation = chosenUser.PictureNormalURL;
            }
        }

        private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album chosenAlbum = AlbumlistBox.SelectedItem as Album;

            PicturelistBox.Items.Clear();

            try
            {
                if (chosenAlbum != null)
                {
                    foreach (Photo photo in chosenAlbum.Photos)
                    {
                        PicturelistBox.Items.Add(photo);
                    }
                    //// exception when using .Photos or .Description

                    chosemPictureBox.ImageLocation = chosenAlbum.PictureAlbumURL;
                }
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
            finally
            {
                chosemPictureBox.ImageLocation = chosenAlbum.PictureAlbumURL;
            }
        }

        private void PictureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo chosenPhoto = PicturelistBox.SelectedItem as Photo;

            if (chosenPhoto != null)
            {
                chosemPictureBox.ImageLocation = chosenPhoto.PictureNormalURL;
            }
        }

        private void postListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post chosenPost = postListBox.SelectedItem as Post;

            if (chosenPost != null)
            {
                MessageBox.Show(chosenPost.Message);
            }
        }

        private void addToPrivacySettings(string i_ExaminedItem, string i_PrivacyLevel)
        {
            ListViewItem itemToAdd = new ListViewItem(i_ExaminedItem);
            ListViewItem.ListViewSubItem subItemToAdd = new ListViewItem.ListViewSubItem
            {
                Text = i_PrivacyLevel
            };

            itemToAdd.SubItems.Add(subItemToAdd);
            privacyListView.Items.Add(itemToAdd);

            privacyListView.Items[privacyListView.Items.Count - 1].UseItemStyleForSubItems = false;

            if (i_PrivacyLevel.Equals("everyone"))
            {
                subItemToAdd.BackColor = r_ColorForEveryonePrivacyLevel;
            }
            else if (i_PrivacyLevel.Equals("custom"))
            {
                subItemToAdd.BackColor = r_ColorForCustomPrivacyLevel;
            }
            else
            {
                subItemToAdd.BackColor = r_ColorForOtherPrivacyLevel;
            }
        }

        private void loadPhotos_Click(object sender, EventArgs e)
        {
            AlbumlistBox.Items.Clear();
            PicturelistBox.Items.Clear();
            r_AppEngine.FetchPhotos();
        }

        private void addingCheckIn(Checkin i_CheckIn)
        {
            checkinsListBox.Items.Add(i_CheckIn);
        }

        private void checkInsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checkin chosenCheckIn = checkinsListBox.SelectedItem as Checkin;
            if (chosenCheckIn != null)
            {
                MessageBox.Show(chosenCheckIn.Name);
            }
        }

        private void loadCheckInsButton_Click(object sender, EventArgs e)
        {
            checkinsListBox.Items.Clear();
            r_AppEngine.FetchCheckIns();
        }

        private void ReportLoad_Button_Click(object sender, EventArgs e)
        {
            try
            {
                privacyListView.Items.Clear();
                r_AppEngine.FetchPrivacyData();
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void fetchLikesButton_Click(object sender, EventArgs e)
        {
            likesDataListView.Items.Clear();
            r_AppEngine.FetchLikesData();
        }

        private void updateLikesData(Dictionary<User, int> i_LikesDataDictionary)
        {
            foreach (KeyValuePair<User, int> userAndLikeData in i_LikesDataDictionary)
            {
                ListViewItem itemToAdd = new ListViewItem(userAndLikeData.Key.Name);
                ListViewItem.ListViewSubItem subItemToAdd = new ListViewItem.ListViewSubItem
                {
                    Text = userAndLikeData.Value.ToString()
                };
                itemToAdd.SubItems.Add(subItemToAdd);
                likesDataListView.Items.Add(itemToAdd);
            }
        }

        private void pokesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poke chocenPoke = pokesListBox.SelectedItem as Poke;
            if (chocenPoke != null)
            {
                MessageBox.Show(string.Format(
                    "poke from {0} to {1} at {2}",
                    chocenPoke.From,
                    chocenPoke.To,
                    chocenPoke.CreatedTime));
            }
        }
    }
}