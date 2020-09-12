using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void AddAlbumsDelegate(FacebookObjectCollection<Album> i_Albums);

    public class PhotosFacade
    {
        private readonly FacadesSharedData r_FacadesSharedData = FacadesSharedData.GetFacadesSharedDataInstance();

        public event AddAlbumsDelegate AddingAlbums;

        public void FetchPhotos()
        {
            AddingAlbums?.Invoke(r_FacadesSharedData.FacebookUser.Albums);
        }
    }
}
