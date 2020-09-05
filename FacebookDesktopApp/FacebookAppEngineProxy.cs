using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDesktopApp
{
    class FacebookAppEngineProxy : IFacebookEngine
    {
        private readonly FacebookAppEngine r_AppEngine;

        public FacebookAppEngineProxy()
        {
            r_AppEngine = new FacebookAppEngine();
        }

        public string AccessToken
        {
            get { return r_AppEngine.AccessToken; }

            set { r_AppEngine.AccessToken = AccessToken; }
        }

        public void Connect()
        {
            try
            {
                r_AppEngine.Connect();
            }
            catch
            {
                throw new Exception("Unsuccessful connecting");
            }
        }

        public void Login()
        {
            try
            {
                r_AppEngine.Login();
            }
            catch(Exception e)
            {
                throw new Exception("Unsuccessful login");
            }
        }

        public void FetchLikesData()
        {

        }

        public void FetchPrivacyData()
        {

        }

        public void FetchCheckIns()
        {

        }

        public void FetchFriends()
        {

        }

        public void FetchOldFriends()
        {

        }

        public void FetchOldPhotos()
        {

        }

        public void PublishPost()
        {

        }
    }
}
