using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdateFriendsDelegate(FacebookObjectCollection<User> i_User);
    public class FriendsFacade
    {
        FriendFacadeBase friendFacadeBase = new FriendFacadeBase();
        private OldFriendsFacade oldFriendsFacade = new OldFriendsFacade();
        private FacadesShardData m_FacadesShardData = FacadesShardData.GetFacadesShardDataInstance();
        public event UpdateFriendsDelegate UpdatingFriendsList;
        public void FetchFriends()
        {
            UpdatingFriendsList?.Invoke(m_FacadesShardData.FacebookUser.Friends);
            friendFacadeBase.CompareAndUpdateOldFriendsFile();
        }
    }
}
