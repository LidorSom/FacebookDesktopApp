using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public delegate void LoginErrorDelegate(string i_ErrorMessage);

    public delegate void UpdatePostDelegate(FacebookObjectCollection<Post> i_Post);

    public delegate void UpdateProfilePictureDelegate(string i_ProfilePictureUrl);

    public delegate void UpdatePokeDelegate(Poke i_Poke);

    public delegate void UpdateFriendsDelegate(FacebookObjectCollection<User> i_User);

    public delegate void UpdateGenderDelegate(User.eGender? i_Gender);

    public delegate void UpdateNameDelegate(string i_Name);

    public delegate void UpdateBirthdayDelegate(string i_BirthDay);

    public delegate void UpdateOldFriendsDelegate(OldFriend i_OldFriend);

    public delegate void AddCheckInDelegate(Checkin i_CheckIn);

    public delegate void AddAlbumsDelegate(Album i_Album);

    public delegate void UpdateLikesDataDelegate(Dictionary<User, int> i_LikesDictionary);

    public delegate void UpdatePrivacyStatusDelegate(string i_TypeOfObject, string i_PrivacyLevel);

    public delegate void UpdateUserDetails(User i_User);

    public class FacebookAppEngine
    {
        private const string k_AppId = "701913560360175";
        private const byte k_CollectionLimit = 50;
        private readonly List<User> r_FriendsToUpdate = new List<User>();
        private readonly List<OldFriend> r_OldFriends = new List<OldFriend>();
        private LoginResult m_LoginResult;

        public string AccessToken { get; set; }

        private User FacebookUser { get; set; }

        private string FriendsTextFile { get; set; }

        public event Action LoggedOutSuccessfully;

        public event LoginErrorDelegate NoticingLoginError;

        public event UpdateUserDetails updateUserDetails;
        public event UpdateProfilePictureDelegate UpdatingProfilePicture;

        public event UpdatePostDelegate UpdatingPosts;

        public event UpdatePokeDelegate UpdatingPokes;

        public event UpdateFriendsDelegate UpdatingFriendsList;

        public event UpdateBirthdayDelegate UpdatingBirthday;

        public event UpdateNameDelegate UpdatingName;

        public event UpdatePrivacyStatusDelegate UpdatingPrivacyData;

        public event UpdateOldFriendsDelegate UpdatingOldFriends;

        public event UpdateGenderDelegate UpdatingGender;

        public event AddAlbumsDelegate AddingAlbums;

        public event AddCheckInDelegate AddingCheckIn;

        public event UpdateLikesDataDelegate UpdateLikesData;

        public void Login()
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            m_LoginResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_posts",
                "user_hometown",
                "user_photos");

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) || m_LoginResult.ErrorMessage == " ()")
            {
                FacebookUser = m_LoginResult.LoggedInUser;
                AccessToken = m_LoginResult.AccessToken;
                InvokeLoginHandlers();
            }
            else
            {
                NoticingLoginError(m_LoginResult.ErrorMessage);
            }
        }

        public void Logout()
        {
            FacebookService.Logout(LoggedOutSuccessfully);
            AccessToken = null;
        }

        public void FetchUserDetails()
        {
            updateUserDetails?.Invoke(FacebookUser);
        }

        public void Connect()
        {
            m_LoginResult = FacebookService.Connect(AccessToken);
            FacebookUser = m_LoginResult.LoggedInUser;
        }

        public void InvokeLoginHandlers()
        {
            FriendsTextFile = string.Format(
                "{0}{1}{2}",
                "FriendsHistory",
                FacebookUser.Id,
                ".txt");

            FacebookUser.Pictures.LoadPicturesAsync();
        }

        public void FetchPosts()
        {
            UpdatingPosts(FacebookUser.Posts);
        }

        public void FetchPokes() // Fetching Pokes is deprecated in version 2.4
        {
            foreach (Poke poke in FacebookUser.Pokes)
            {
                UpdatingPokes(poke);
            }
        }

        public void FetchLikesData()
        {
            Dictionary<User, int> likesDictionary = new Dictionary<User, int>(FacebookUser.Friends.Count);

            foreach (User friend in FacebookUser.Friends)
            {
                likesDictionary.Add(friend, 0);
            }

            try
            {
                updateDictionaryWithPosts(likesDictionary);
                updateDictionaryWithPhotos(likesDictionary);
            }
            catch (Exception exception) //// we catch general exception in order to display something in this feature
            {
            }
            finally
            {
                UpdateLikesData(likesDictionary); //// In Finally because we want to display Something
            }
        }

        private void updateDictionaryWithPhotos(Dictionary<User, int> i_LikesDictionary)
        {
            foreach (Album album in FacebookUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    foreach (User likeUser in photo.LikedBy)
                    {
                        updateDictionaryWithLikeUser(i_LikesDictionary, likeUser);
                    }
                }
            }
        }

        private void updateDictionaryWithPosts(Dictionary<User, int> i_LikesDictionary)
        {
            foreach (var post in FacebookUser.Posts)
            {
                foreach (User likedUser in post.LikedBy)
                {
                    updateDictionaryWithLikeUser(i_LikesDictionary, likedUser);
                }
            }
        }

        private void updateDictionaryWithLikeUser(Dictionary<User, int> i_LikesDictionary, User i_LikeUser)
        {
            if (i_LikesDictionary.ContainsKey(i_LikeUser))
            {
                i_LikesDictionary[i_LikeUser]++;
            }
            else
            {
                i_LikesDictionary.Add(i_LikeUser, 1);
            }
        }

        public void FetchPrivacyData()
        {
            int objectsCounter = 1;

            foreach (Album album in FacebookUser.Albums)
            {
                UpdatingPrivacyData(string.Format("Album N.{0}", objectsCounter), album.PrivcaySettings);
                objectsCounter++;
            }

            /*  foreach (Group group in FacebookUser.Groups) // unaccessible
              {
                  UpdatePrivacyData(string.Format("Group N.{0}", objectsCounter), group.Privacy.ToString());
                  objectsCounter++;
              }
          */

            objectsCounter = 1;

            foreach (Event declinedEvent in FacebookUser.Events)
            {
                UpdatingPrivacyData(string.Format("Event N.{0}", objectsCounter), declinedEvent.Privacy.ToString());
                objectsCounter++;
            }
        }

        public void FetchCheckIns()
        {
            foreach (Checkin checkIn in FacebookUser.Checkins)
            {
                AddingCheckIn(checkIn);
            }
        }

        public void FetchOldFriends()
        {
            updateFriendsFile();
            fetchOldFriendsFromFile();
            try
            {
                foreach (OldFriend oldFriend in r_OldFriends)
                {
                    UpdatingOldFriends?.Invoke(oldFriend);
                }
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("old friend handler is null", e);
            }
        }

        public void FetchPhotos()
        {
            AddingAlbums?.Invoke(FacebookUser.Albums[0]);
        }

        private void fetchOldFriendsFromFile()
        {
            using (OldfriendStreamAdapter fileStream = new OldfriendStreamAdapter(FriendsTextFile))
            {
                OldFriend oldFriend;
                while ((oldFriend = fileStream.ReadOldFriend()) != null)
                {
                    if (searchInFriendsListById(oldFriend.Id) == false)
                    {
                            r_OldFriends.Add(oldFriend);
                    }
                }
            }

        }
        

        private bool searchInFriendsListById(string i_Id)
        {
            bool doesExistInFriendsList = false;

            foreach (User friend in FacebookUser.Friends)
            {
                if (i_Id == friend.Id)
                {
                    doesExistInFriendsList = true;
                    break;
                }
            }

            return doesExistInFriendsList;
        }

        public void FetchFriends()
        {
            UpdatingFriendsList(FacebookUser.Friends);
            foreach (User friend in FacebookUser.Friends)
            {

                if (searchInFriendsFile(friend.Id) == false)
                {
                    r_FriendsToUpdate.Add(friend);
                }

            }
        }

        private void updateFriendsFile()
        {
            StreamWriter streamWriter = new StreamWriter(FriendsTextFile, true);

            foreach (User friend in r_FriendsToUpdate)
            {
                streamWriter.WriteLine(string.Format("{0} {1} {2} {3}",
                    friend.Id,
                    friend.FirstName,
                    friend.LastName,
                    friend.PictureNormalURL));
            }

            streamWriter.Close();
            r_FriendsToUpdate.Clear();
        }

        private bool searchInFriendsFile(string i_FriendId)
        {
            bool doesExistInFile = false;
            
            if (File.Exists(FriendsTextFile))
            {
                StreamReader newFileStream = new StreamReader(FriendsTextFile);
                try
                {
                    string line;

                    while ((line = newFileStream.ReadLine()) != null)
                    {
                        string[] arrayOfData = line.Split(' ');

                        if (arrayOfData[0] == i_FriendId)
                        {
                            doesExistInFile = true;
                            break;
                        }
                    }
                }
                finally
                {
                    newFileStream.Close();
                }
            }

            return doesExistInFile;
        }

        public void PublishPost(string i_StringToPost)
        {
            FacebookUser.PostStatus(i_StringToPost);
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return FacebookUser.Friends;
        }
    }

    //// List of permissions denied:
    //// FacebookUser.Subscribers //This option removed as of version 2.0 of the Graph API'
    //// FacebookUser.Albums.Photos // Tried accessing non existing field (tags) on node type (Photo)
    //// LikedBy
}
