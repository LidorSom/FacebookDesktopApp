using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDesktopAppFacades
{
    public delegate void AddAlbumsDelegate(FacebookObjectCollection<Album> i_Albums);
    public class PhotosFacade
    {
        private FacadesShardData m_FacadesShardData = FacadesShardData.GetFacadesShardDataInstance();
        public event AddAlbumsDelegate AddingAlbums;
        public void FetchPhotos()
        {
            AddingAlbums?.Invoke(m_FacadesShardData.FacebookUser.Albums);
        }
    }
}
