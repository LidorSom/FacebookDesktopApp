using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using FacebookDesktopApp;

namespace FacebookDesktopAppFacades
{
    static class IOldFriendReaderFactory
    {
        public static IUserReader GetUserReader(string i_Path)
        {
            return new OldFriendStreamAdapter(string.Format("{0}{1}",
                i_Path, ".txt"));
        }
    }
}
