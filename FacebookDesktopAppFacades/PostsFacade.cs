using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdatePostDelegate(FacebookObjectCollection<Post> i_Post);
    public class PostsFacade
    {
        private FacadesShardData facadesShardData =
            FacadesShardData.GetFacadesShardDataInstance();
        public event UpdatePostDelegate UpdatingPosts;
        public void FetchPosts()
        {
            UpdatingPosts?.Invoke(facadesShardData.FacebookUser.Posts);
        }

    }
}
