using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdateUserDetails(User i_User);
    public class MyProfileFacade
    {
        public event UpdateUserDetails updateUserDetails;
        private FacadesShardData m_facadesShardData =  FacadesShardData.GetFacadesShardDataInstance();
        public void FetchUserDetails()
        {
            updateUserDetails?.Invoke(m_facadesShardData.FacebookUser);
        }
    }
}
