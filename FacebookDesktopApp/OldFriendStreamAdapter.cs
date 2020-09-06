using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApp
{

    public class OldfriendStreamAdapter : IDisposable
    {
        private readonly string r_FileTextPath = null;
        private readonly StreamReader r_streamReader = null;
        
        
        public OldfriendStreamAdapter(string i_FileTextPath)
        {
            r_FileTextPath = i_FileTextPath;
            if (File.Exists(r_FileTextPath))
            {
                r_streamReader = new StreamReader(r_FileTextPath);
            }

        }

        


        public OldFriend ReadOldFriend()
        {

            OldFriend toReturnOlfFriend = null;
            if (File.Exists(r_FileTextPath))
            {
                try
                {
                    string currentLine;
                    if ((currentLine = r_streamReader.ReadLine()) != null)
                    {
                        string[] arrayOfUserData = currentLine.Split(' ');

                        string stringToAdd = string.Format("{0} {1}", arrayOfUserData[1], arrayOfUserData[2]);

                        toReturnOlfFriend = new OldFriend(arrayOfUserData[0]
                            , stringToAdd
                            , arrayOfUserData[3]);
                    }
                }
                catch(NullReferenceException nullReferenceException)
                {
                    
                }

            }

            return toReturnOlfFriend;
        }

        public bool serachFriend(User i_User)
        {
            bool doesExistInFile = false;

            if (File.Exists(r_FileTextPath))
            {
                //StreamReader newFileStream = new StreamReader(r_FileTextPath);
                
                try
                {
                    string line;

                    while ((line = r_streamReader.ReadLine()) != null)
                    {
                        string[] arrayOfData = line.Split(' ');

                        if (arrayOfData[0] == i_User.Id)
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
    }
}
