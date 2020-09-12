using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdatePrivacyStatusDelegate(FacebookObjectCollection<Event> i_Events, FacebookObjectCollection<Album> i_Albums);

    public class PrivacyFacade
    {
        private readonly FacadesSharedData r_FacadesSharedData =
            FacadesSharedData.GetFacadesSharedDataInstance();

        public event UpdatePrivacyStatusDelegate UpdatingPrivacyData;

        public void FetchPrivacyData()
        {
            UpdatingPrivacyData?.Invoke(
                r_FacadesSharedData.FacebookUser.Events,
                r_FacadesSharedData.FacebookUser.Albums);
        }
    }
}
