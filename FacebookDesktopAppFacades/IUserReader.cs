using System;
using System.Collections;
using System.Collections.Generic;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public interface IUserReader : IEnumerable<OldFriend>, IDisposable
    {
         bool SearchFriend(User i_User);

       //  OldFriend ReadOldFriend();
    }
}
