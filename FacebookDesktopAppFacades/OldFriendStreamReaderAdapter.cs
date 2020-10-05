using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using FacebookDesktopAppFacades;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{
    public class OldFriendStreamReaderAdapter : IUserReader
    {
        private readonly string r_FileTextPath;
        private readonly StreamReader r_streamReader = null;

        public OldFriendStreamReaderAdapter(string i_FileTextPath)
        {
            r_FileTextPath = i_FileTextPath;

            if (File.Exists(r_FileTextPath))
            {
                r_streamReader = new StreamReader(r_FileTextPath);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new OldFriendStreamReaderEnumerator(this);
        }

        private OldFriend readOldFriend(long i_FilePosition)
        {
            OldFriend toReturnOlfFriend = null;

            if (File.Exists(r_FileTextPath))
            {
                try
                {
                    r_streamReader.BaseStream.Position = i_FilePosition;

                    string currentLine;

                    if ((currentLine = r_streamReader.ReadLine()) != null)
                    {
                        string[] arrayOfUserData = currentLine.Split(' ');

                        string stringToAdd = string.Format("{0} {1}", arrayOfUserData[1], arrayOfUserData[2]);

                        toReturnOlfFriend = new OldFriend(
                            arrayOfUserData[0],
                            stringToAdd,
                            arrayOfUserData[3]);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Cannot read", e);
                }
            }

            return toReturnOlfFriend;
        }

        public bool SearchFriend(User i_User)
        {
            bool doesExistInFile = false;

            if (File.Exists(r_FileTextPath))
            {
                try
                {
                    foreach (OldFriend oldFriend in this)
                    {
                        if (oldFriend.Id == i_User.Id)
                        {
                            doesExistInFile = true;
                            break;
                        }
                    }
                }
                finally
                {
                    r_streamReader.Close();
                }
            }

            return doesExistInFile;
        }

        public void Dispose()
        {
            r_streamReader?.Dispose();
        }

        private class OldFriendStreamReaderEnumerator : IEnumerator
        {
            private const long k_ResetValue = 0;
            private long m_CurrentPosition;
            private OldFriend m_CurrentOldFriend;
            private readonly OldFriendStreamReaderAdapter r_Adapter;

            public OldFriendStreamReaderEnumerator(OldFriendStreamReaderAdapter i_Adapter,
                long i_FilePosition = k_ResetValue)
            {
                m_CurrentPosition = i_FilePosition;
                m_CurrentOldFriend = null;
                r_Adapter = i_Adapter;
            }

            public object Current
            {
                get { return m_CurrentOldFriend; }
            }

            public bool MoveNext()
            {
                m_CurrentOldFriend = r_Adapter.readOldFriend(m_CurrentPosition);
                m_CurrentPosition = r_Adapter.r_streamReader.BaseStream.Position;

                return (m_CurrentOldFriend == null);
            }

            public void Reset()
            {
                m_CurrentPosition = k_ResetValue;
            }
        }
    }
}
