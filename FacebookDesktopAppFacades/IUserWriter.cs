using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    interface IUserWriter : IDisposable
    {
      void WriteFriend(User i_Friend);
    }
}
