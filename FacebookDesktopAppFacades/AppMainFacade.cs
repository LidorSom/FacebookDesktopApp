using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
namespace FacebookDesktopAppFacades
{
    public delegate void LoginErrorDelegate(string i_ErrorMessage);
   
    public class AppMainFacade
    {
        private const string k_AppId = "701913560360175";
        private const byte k_CollectionLimit = 50;
        private FacadesShardData facadesShardData =
            FacadesShardData.GetFacadesShardDataInstance();
        private LoginResult m_LoginResult;
        public string AccessToken { get; set; }
        public event LoginErrorDelegate NoticingLoginError;
        public event Action LoggedOutSuccessfully;
        public void Login()
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            m_LoginResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_posts",
                "user_hometown",
                "user_photos");

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) || m_LoginResult.ErrorMessage == " ()")
            {
                facadesShardData.FacebookUser = m_LoginResult.LoggedInUser;
                AccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                NoticingLoginError(m_LoginResult.ErrorMessage);
            }
        }

        public void Connect()
        {
            //must add condtions and try& catch
            m_LoginResult = FacebookService.Connect(AccessToken);
            facadesShardData.FacebookUser = m_LoginResult.LoggedInUser;
        }
        public void Logout()
        {
            FacebookService.Logout(LoggedOutSuccessfully);
            AccessToken = null;
        }

    }
}
