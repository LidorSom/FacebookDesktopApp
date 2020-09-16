using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using FacebookDesktopApp;

namespace FacebookDesktopAppFacades
{
    public static class ReaderFactory
    {
        public static IUserReader GetUserReader(string i_Path)
        {
            return new OldFriendStreamReaderAdapter(
                string.Format(
                    "{0}{1}",
                    i_Path,
                    ".txt"));
        }
    }
}
