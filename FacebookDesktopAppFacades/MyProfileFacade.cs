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

        private readonly FacadesSharedData r_FacadesSharedData = FacadesSharedData.GetFacadesSharedDataInstance();

        public void FetchUserDetails()
        {
            updateUserDetails?.Invoke(r_FacadesSharedData.FacebookUser);
        }
    }
}
