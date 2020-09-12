using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdateFriendsDelegate(FacebookObjectCollection<User> i_User);

    public class FriendsFacade
    {
        private readonly FriendFacadeBase r_FriendFacadeBase = new FriendFacadeBase();
        private readonly FacadesSharedData r_FacadesSharedData = FacadesSharedData.GetFacadesSharedDataInstance();

        public event UpdateFriendsDelegate UpdatingFriendsList;

        public void FetchFriends()
        {
            UpdatingFriendsList?.Invoke(r_FacadesSharedData.FacebookUser.Friends);
            r_FriendFacadeBase.CompareAndUpdateOldFriendsFile();
        }
    }
}
