using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookDesktopApp;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    interface IUserReader: IDisposable
    {
         bool SearchFriend(User i_User);
         OldFriend ReadOldFriend();
    }
}
