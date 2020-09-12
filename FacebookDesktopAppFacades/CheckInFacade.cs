using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void AddCheckInDelegate(FacebookObjectCollection<Checkin> i_CheckIns);
    public class CheckInFacade
    {
        public event AddCheckInDelegate AddingCheckIn;
        private readonly FacadesShardData m_FacadesShardData  = FacadesShardData.GetFacadesShardDataInstance();

        public void FetchCheckIns()
        {
            AddingCheckIn?.Invoke(m_FacadesShardData.FacebookUser.Checkins);
        }
    }
}
