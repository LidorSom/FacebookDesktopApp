using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void AddCheckInDelegate(FacebookObjectCollection<Checkin> i_CheckIns);

    public class CheckInFacade
    {
        public event AddCheckInDelegate AddingCheckIn;

        public int Property
        {
            get => default(int);
            set
            {
            }
        }

        private readonly FacadesSharedData r_FacadesSharedData  = FacadesSharedData.GetFacadesSharedDataInstance();

        public void FetchCheckIns()
        {
            AddingCheckIn?.Invoke(r_FacadesSharedData.FacebookUser.Checkins);
        }
    }
}
