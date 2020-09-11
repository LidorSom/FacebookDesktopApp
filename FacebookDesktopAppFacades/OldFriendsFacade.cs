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
        private FacadesShardData m_FacadesShardData { get; set; }
            = FacadesShardData.GetFacadesShardDataInstance();
        private FriendFacadeBase m_friendFacadeBase = new FriendFacadeBase();
        private readonly List<OldFriend> r_OldFriends = new List<OldFriend>();
        public event UpdateOldFriendsDelegate UpdatingOldFriends;
        private readonly List<User> r_FriendsToUpdate = new List<User>();
        public OldFriendsFacade()
        {
        }

        public void FetchOldFriends()
        {
            r_OldFriends.Clear();
            m_friendFacadeBase.CompareAndUpdateOldFriendsFile();
            fetchOldFriendsFromFile();
            UpdatingOldFriends?.Invoke(r_OldFriends);
        }

        private void fetchOldFriendsFromFile()
        {
            using (OldFriendStreamAdapter fileStream =
                new OldFriendStreamAdapter(m_friendFacadeBase.FriendsTextFile)) 
            {
                OldFriend oldFriend;

                while ((oldFriend = fileStream.ReadOldFriend()) != null)
                {
                    if (m_friendFacadeBase.searchInFriendsListById(oldFriend.Id) == false)
                    {
                        r_OldFriends.Add(oldFriend);
                    }
                }
            }
        }


    }

}
