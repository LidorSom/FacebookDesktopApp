using System.Collections.Generic;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    internal class FriendFacadeBase
    {
        private FacadesSharedData FacadesSharedData { get; } = FacadesSharedData.GetFacadesSharedDataInstance();

        private readonly List<User> r_FriendsToUpdate = new List<User>();

        public string FriendsTextFile { get; private set; }

        public FriendFacadeBase()
        {
            FriendsTextFile = string.Format(
                "{0}{1}{2}",
                "FriendsHistory",
                FacadesSharedData.FacebookUser.Id,
                ".txt");
        }

        //private void fetchOldFriendsFromFile()
        //{
        //    using (OldFriendStreamAdapter fileStream = new OldFriendStreamAdapter(FriendsTextFile))
        //    {
        //        OldFriend oldFriend;

        //        while ((oldFriend = fileStream.ReadOldFriend()) != null)
        //        {
        //            if (SearchInFriendsListById(oldFriend.Id) == false)
        //            {
        //                r_OldFriends.Add(oldFriend);
        //            }
        //        }
        //    }
        //}

        public void CompareAndUpdateOldFriendsFile()
        {
            foreach (User friend in FacadesSharedData.FacebookUser.Friends)
            {
                if (SearchInFriendsFile(friend) == false)
                {
                    r_FriendsToUpdate.Add(friend);
                }
            }

            updateFriendsFile();
        }

        public bool SearchInFriendsFile(User i_FriendId)
        {
            bool doesExistInFile = false;

            using (OldFriendStreamAdapter streamReaderAdapter = new OldFriendStreamAdapter(FriendsTextFile))
            {
                doesExistInFile = streamReaderAdapter.searchFriend(i_FriendId);
            }

            return doesExistInFile;
        }

        public bool SearchInFriendsListById(string i_Id)
        {
            bool doesExistInFriendsList = false;

            foreach (User friend in FacadesSharedData.FacebookUser.Friends)
            {
                if (i_Id == friend.Id)
                {
                    doesExistInFriendsList = true;
                    break;
                }
            }

            return doesExistInFriendsList;
        }

        private void updateFriendsFile()
        {
            using (OldFriendStreamWriterAdapter streamWriterAdapter = new OldFriendStreamWriterAdapter(FriendsTextFile))
            {
                foreach (User friend in r_FriendsToUpdate)
                {
                    streamWriterAdapter.WriteFriend(friend);
                }
            }

            r_FriendsToUpdate.Clear();
        }
    }
}

