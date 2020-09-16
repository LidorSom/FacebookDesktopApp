using System.Collections.Generic;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    internal class FriendFacadeBase
    {
        private FacadesSharedData FacadesSharedData { get; } = FacadesSharedData.GetFacadesSharedDataInstance();

        private readonly List<User> r_FriendsToUpdate = new List<User>();

        public string FriendsDataPath { get; private set; }

        public FriendFacadeBase()
        {
            FriendsDataPath = string.Format(
                "{0}{1}",
                "FriendsHistory",
                FacadesSharedData.FacebookUser.Id);
        }

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

            using (IUserReader streamReaderAdapter = ReaderFactory.GetUserReader(FriendsDataPath))
            {
                doesExistInFile = streamReaderAdapter.SearchFriend(i_FriendId);
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
            using (IUserWriter streamWriterAdapter = WriterFactory.GetUserWriter(FriendsDataPath))
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
