using System;
using System.Collections;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public interface IUserReader : IEnumerable, IDisposable
    {
         bool SearchFriend(User i_User);

       //  OldFriend ReadOldFriend();
    }
}
