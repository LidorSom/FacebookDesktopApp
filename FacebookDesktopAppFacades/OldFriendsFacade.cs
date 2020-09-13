using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdateOldFriendsDelegate(List<OldFriend> i_OldFriend);

    public class OldFriendsFacade
    {
        private FacadesSharedData FacadesSharedData { get; set; }
            = FacadesSharedData.GetFacadesSharedDataInstance();

        private readonly FriendFacadeBase r_FriendFacadeBase = new FriendFacadeBase();

        private readonly List<OldFriend> r_OldFriends = new List<OldFriend>();

        // private readonly List<User> r_FriendsToUpdate = new List<User>();

        public event UpdateOldFriendsDelegate UpdatingOldFriends;

        public void FetchOldFriends()
        {
            r_OldFriends.Clear();
            r_FriendFacadeBase.CompareAndUpdateOldFriendsFile();
            fetchOldFriendsFromFile();
            UpdatingOldFriends?.Invoke(r_OldFriends);
        }

        private void fetchOldFriendsFromFile()
        {
            using (IUserReader fileStream =
               IOldFriendReaderFactory.GetUserReader(r_FriendFacadeBase.FriendsDataPath)) 
            {
                OldFriend oldFriend;

                while ((oldFriend = fileStream.ReadOldFriend()) != null)
                {
                    if (r_FriendFacadeBase.SearchInFriendsListById(oldFriend.Id) == false)
                    {
                        r_OldFriends.Add(oldFriend);
                    }
                }
            }
        }
    }
}
