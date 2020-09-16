using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookDesktopApp;

namespace FacebookDesktopAppFacades
{
    public static class WriterFactory
    {
        public static IUserWriter GetUserWriter(string i_Path)
        {
            return new OldFriendStreamWriterAdapter(string.Format("{0}{1}", i_Path, ".txt"));
        }
    }
}
