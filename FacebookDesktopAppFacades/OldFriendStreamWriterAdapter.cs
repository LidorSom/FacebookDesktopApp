using System;
using System.IO;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public class OldFriendStreamWriterAdapter : IUserWriter
    {

        private readonly string r_FileTextPath = null;
        private readonly StreamWriter r_StreamWriter = null;


        public OldFriendStreamWriterAdapter(string i_FileTextPath)
        {
            r_FileTextPath = i_FileTextPath;
            r_StreamWriter = new StreamWriter(r_FileTextPath,true);
        }

        public void Dispose()
        {
            r_StreamWriter.Dispose();
        }

        public void WriteFriend(User i_Friend)
        {
            r_StreamWriter.WriteLine(string.Format("{0} {1} {2} {3}",
                i_Friend.Id,
                i_Friend.FirstName,
                i_Friend.LastName,
                i_Friend.PictureNormalURL));
        }
    }
}
